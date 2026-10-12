using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace key_luxery1
{
	public partial class frmNewSale : Form
	{
		private sharedClass db = new sharedClass();

		public frmNewSale()
		{
			InitializeComponent();

			// Wire up event handlers for button and list selection
			this.Load += new System.EventHandler(this.frmNewSale_Load);
			this.lvProducts.SelectedIndexChanged += new System.EventHandler(this.lvProducts_SelectedIndexChanged);
			this.btnSaveSale.Click += new System.EventHandler(this.btnSaveSale_Click);
		}

		private void frmNewSale_Load(object sender, EventArgs e)
		{
			ConfigureListView();
			LoadProducts("");
		}

		/// <summary>
		/// Configures the ListView headers and grid lines for product lookup.
		/// </summary>
		private void ConfigureListView()
		{
			lvProducts.View = View.Details;
			lvProducts.FullRowSelect = true;
			lvProducts.GridLines = true;

			lvProducts.Columns.Clear();
			lvProducts.Columns.Add("Product ID", 80, HorizontalAlignment.Left);
			lvProducts.Columns.Add("Product Name", 240, HorizontalAlignment.Left);
			lvProducts.Columns.Add("Price", 90, HorizontalAlignment.Left);
			lvProducts.Columns.Add("Stock", 80, HorizontalAlignment.Left);
		}

		/// <summary>
		/// Loads products into the ListView, supporting live search filtering.
		/// </summary>
		private void LoadProducts(string searchFilter)
		{
			try
			{
				string query = "SELECT ProductID, ProductName, Price, StockQuantity from tblProduct WHERE StockQuantity > 0";
				if (!string.IsNullOrEmpty(searchFilter))
				{
					query += $" AND ProductName LIKE '%{searchFilter.Replace("'", "''")}%'";
				}

				DataTable dt = sharedClass.GetData(query);
				lvProducts.Items.Clear();

				foreach (DataRow row in dt.Rows)
				{
					ListViewItem item = new ListViewItem(row["ProductID"].ToString());
					item.SubItems.Add(row["ProductName"].ToString());
					item.SubItems.Add(Convert.ToDecimal(row["Price"]).ToString("0.00"));
					item.SubItems.Add(row["StockQuantity"].ToString());
					lvProducts.Items.Add(item);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			// Triggered when typing into txtSearchProduct
			LoadProducts(txtSearchProduct.Text.Trim());
			CalculateNetPrice();
		}

		private void lvProducts_SelectedIndexChanged(object sender, EventArgs e)
		{
			CalculateNetPrice();
		}

		private void txtDiscount_TextChanged(object sender, EventArgs e)
		{
			CalculateNetPrice();
		}

		/// <summary>
		/// Automatically calculates the net price based on the selected product price minus discount.
		/// </summary>
		private void CalculateNetPrice()
		{
			if (lvProducts.SelectedItems.Count > 0)
			{
				decimal price = Convert.ToDecimal(lvProducts.SelectedItems[0].SubItems[2].Text);
				decimal discount = 0;
				decimal.TryParse(txtDiscount.Text.Trim(), out discount);

				decimal net = price - discount;
				lblNetPriceValue.Text = "$" + (net > 0 ? net : 0).ToString("0.00");
			}
			else
			{
				lblNetPriceValue.Text = "$0.00";
			}
		}

		private void btnSaveSale_Click(object sender, EventArgs e)
		{
			if (lvProducts.SelectedItems.Count == 0)
			{
				MessageBox.Show("Please select a product from the list to process the sale.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				ListViewItem selected = lvProducts.SelectedItems[0];
				int productId = Convert.ToInt32(selected.Text);
				string productName = selected.SubItems[1].Text;
				decimal price = Convert.ToDecimal(selected.SubItems[2].Text);
				int quantity = 1; // Default quantity per selection

				decimal discount = 0;
				decimal.TryParse(txtDiscount.Text.Trim(), out discount);
				decimal netPrice = (price * quantity) - discount;
				decimal profit = netPrice * 0.20m; // Estimated 20% margin calculation

				string saleDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
				string invoiceNo = "INV-" + DateTime.Now.ToString("yyyyMMddHHmmss");
				int customerId = 1; // Default walk-in customer ID
				int paymentId = 1;  // Default cash payment ID

				using (SqlConnection con = sharedClass.GetConnection())
				{
					con.Open();
					using (SqlTransaction transaction = con.BeginTransaction())
					{
						try
						{
							// 1. Insert Master Invoice into tblInvoice and get the generated invoice_id
							string invQuery = "INSERT INTO tblInvoice (invoice_no, customer_id, payment_id, sale_date, subtotal, discount, grand_total, total_profit) " +
											  "OUTPUT INSERTED.invoice_id " +
											  "VALUES (@invNo, @custId, @payId, @date, @sub, @disc, @grand, @profit)";

							SqlCommand cmdInv = new SqlCommand(invQuery, con, transaction);
							cmdInv.Parameters.AddWithValue("@invNo", invoiceNo);
							cmdInv.Parameters.AddWithValue("@custId", customerId);
							cmdInv.Parameters.AddWithValue("@payId", paymentId);
							cmdInv.Parameters.AddWithValue("@date", saleDate);
							cmdInv.Parameters.AddWithValue("@sub", price * quantity);
							cmdInv.Parameters.AddWithValue("@disc", discount);
							cmdInv.Parameters.AddWithValue("@grand", netPrice);
							cmdInv.Parameters.AddWithValue("@profit", profit);

							int invoiceId = (int)cmdInv.ExecuteScalar();

							// 2. Insert Line Item into tblSale
							string saleQuery = "INSERT INTO tblSale (product_id, item_name, quantity, price, discount, netPrice, payment_id, customer_id, date, profit, returned, deleted) " +
											   "VALUES (@prodId, @name, @qty, @price, @disc, @net, @payId, @custId, @date, @profit, 0, 0)";

							SqlCommand cmdSale = new SqlCommand(saleQuery, con, transaction);
							cmdSale.Parameters.AddWithValue("@prodId", productId);
							cmdSale.Parameters.AddWithValue("@name", productName);
							cmdSale.Parameters.AddWithValue("@qty", quantity);
							cmdSale.Parameters.AddWithValue("@price", price);
							cmdSale.Parameters.AddWithValue("@disc", discount);
							cmdSale.Parameters.AddWithValue("@net", netPrice);
							cmdSale.Parameters.AddWithValue("@payId", paymentId);
							cmdSale.Parameters.AddWithValue("@custId", customerId);
							cmdSale.Parameters.AddWithValue("@date", saleDate);
							cmdSale.Parameters.AddWithValue("@profit", profit);

							cmdSale.ExecuteNonQuery();

							// 3. Deduct Stock Quantity from tblProduct table
							string stockQuery = "UPDATE Products SET StockQuantity = StockQuantity - @qty WHERE ProductID = @prodId";
							SqlCommand cmdStock = new SqlCommand(stockQuery, con, transaction);
							cmdStock.Parameters.AddWithValue("@qty", quantity);
							cmdStock.Parameters.AddWithValue("@prodId", productId);

							cmdStock.ExecuteNonQuery();

							// Commit transaction successfully
							transaction.Commit();

							MessageBox.Show($"Sale successfully completed!\nInvoice Number: {invoiceNo}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

							// Reset form fields
							txtSearchProduct.Clear();
							txtDiscount.Text = "0.00";
							lblNetPriceValue.Text = "$0.00";
							LoadProducts("");
						}
						catch (Exception ex)
						{
							transaction.Rollback();
							MessageBox.Show("Transaction failed: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving sale: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}