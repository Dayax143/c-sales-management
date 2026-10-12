using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace key_luxery1
{
	public partial class frmManageSale : Form
	{
		sharedClass db = new sharedClass();
		// Track state variables
		private string currentInvoiceId = "";
		private bool isSaleCompleted = false;

		// Found product cache
		private string foundProductId = "";
		private string foundProductName = "";
		private decimal foundProductPrice = 0;
		private int foundProductStock = 0;

		public frmManageSale()
		{
			InitializeComponent();
		}

		private void frmManageSale_Load(object sender, EventArgs e)
		{
			LoadCustomers();
			InitializeNewInvoiceOnOpen();
		}

		// --- 1. CREATE INVOICE IMMEDIATELY UPON OPENING FORM ---
		private void InitializeNewInvoiceOnOpen()
		{
			try
			{
				// Generate next Invoice Number sequence string
				DataTable dt = sharedClass.GetData("SELECT TOP 1 invoice_id FROM tblInvoice ORDER BY invoice_id DESC");
				int nextId = 1;
				if (dt.Rows.Count > 0 && dt.Rows[0]["invoice_id"] != DBNull.Value)
				{
					nextId = Convert.ToInt32(dt.Rows[0]["invoice_id"]) + 1;
				}

				string generatedInvoiceNo = $"INV-{DateTime.Now.Year}-{nextId.ToString("D3")}";
				string currentDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

				// Insert a draft/unpaid placeholder record immediately into tblInvoice
				string query = $"INSERT INTO tblInvoice (invoice_no, invoice_date, subtotal, discount,tax, grand_total, status) " +
							   $"VALUES ('{generatedInvoiceNo}', '{currentDate}', 0.00, 0.00, 0.00, 0.00, 'Draft')";
				db.ExecuteQueries(query);

				// Fetch the newly created database ID
				DataTable dtCreated = sharedClass.GetData($"SELECT invoice_id FROM tblInvoice WHERE invoice_no = '{generatedInvoiceNo}'");
				if (dtCreated.Rows.Count > 0)
				{
					currentInvoiceId = dtCreated.Rows[0]["invoice_id"].ToString();
					txtInvoiceId.Text = currentInvoiceId;
					txtInvoiceNo.Text = generatedInvoiceNo;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error initializing draft invoice: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LoadCustomers()
		{
			try
			{
				DataTable dt = sharedClass.GetData("SELECT customer_id, customer_name, customer_phone FROM tblCustomer WHERE deleted = 0");
				cmbCustomer.DataSource = dt;
				cmbCustomer.DisplayMember = "customer_name";
				cmbCustomer.ValueMember = "customer_id";
				cmbCustomer.SelectedIndex = -1;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading customers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Search customer automatically by typing phone number
		// Declare a variable at the form level to hold the ID
		public int? selectedCustomerId ;
		private void txtCustomerPhone_TextChanged(object sender, EventArgs e)
		{
			string phone = txtCustomerPhone.Text.Trim();
			selectedCustomerId = null; // Reset if not found

			if (!string.IsNullOrEmpty(phone))
			{
				foreach (DataRowView item in cmbCustomer.Items)
				{
					DataRow row = item.Row;
					string dbPhone = row["customer_phone"]?.ToString() ?? "";

					if (dbPhone.Equals(phone))
					{
						cmbCustomer.SelectedItem = item;

						// Get the customer ID from the data row
						selectedCustomerId = int.Parse(row["customer_id"].ToString());
						txtcustomer_id.Text = selectedCustomerId.ToString();
						break;
					}
				}
			}
		}

		// --- 2. FIND PRODUCT BY NAME & FETCH DATA ---
		private void btnFindProduct_Click(object sender, EventArgs e)
		{
			string searchName = txtSearchProduct.Text.Trim();
			if (string.IsNullOrEmpty(searchName))
			{
				MessageBox.Show("Please enter a product name to search.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				DataTable dt = sharedClass.GetData($"SELECT product_id, product_name, price, quantity FROM tblProduct WHERE product_name LIKE '%{searchName}%' AND deleted = 0");

				if (dt.Rows.Count > 0)
				{
					DataRow row = dt.Rows[0];
					foundProductId = row["product_id"].ToString();
					foundProductName = row["product_name"].ToString();
					foundProductPrice = Convert.ToDecimal(row["price"]);
					foundProductStock = Convert.ToInt32(row["quantity"]);

					txtSearchProduct.Text = foundProductName;
					MessageBox.Show($"Product Found!\nName: {foundProductName}\nPrice: ${foundProductPrice:N2}\nIn Stock: {foundProductStock}",
						"Product Match", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("No active product found with that name.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					foundProductId = "";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error finding product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnAddItem_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(foundProductId))
			{
				MessageBox.Show("Please search and click 'Find' for a valid product first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!int.TryParse(txtQuantity.Text.Trim(), out int qty) || qty <= 0)
			{
				MessageBox.Show("Please enter a valid quantity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (qty > foundProductStock)
			{
				MessageBox.Show($"Requested quantity exceeds available stock ({foundProductStock} left).", "Stock Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			foreach (DataGridViewRow row in dgvCart.Rows)
			{
				if (row.Cells["colProductID"].Value.ToString() == foundProductId)
				{
					int existingQty = Convert.ToInt32(row.Cells["colQuantity"].Value);
					int newQty = existingQty + qty;
					if (newQty > foundProductStock)
					{
						MessageBox.Show("Total cart quantity exceeds available stock.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}
					row.Cells["colQuantity"].Value = newQty;
					row.Cells["colSubtotal"].Value = newQty * foundProductPrice;
					CalculateGrandTotal();
					return;
				}
			}

			decimal subtotal = foundProductPrice * qty;
			dgvCart.Rows.Add(foundProductId, foundProductName, foundProductPrice, qty, subtotal);
			CalculateGrandTotal();
		}

		private void btnRemoveItem_Click(object sender, EventArgs e)
		{
			if (dgvCart.SelectedRows.Count > 0)
			{
				dgvCart.Rows.RemoveAt(dgvCart.SelectedRows[0].Index);
				CalculateGrandTotal();
			}
			else
			{
				MessageBox.Show("Please select a cart item to remove.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnClearCart_Click(object sender, EventArgs e)
		{
			dgvCart.Rows.Clear();
			CalculateGrandTotal();
		}

		private void txtDiscount_TextChanged(object sender, EventArgs e)
		{
			CalculateGrandTotal();
		}

		private void CalculateGrandTotal()
		{
			decimal subtotalSum = 0;
			foreach (DataGridViewRow row in dgvCart.Rows)
			{
				subtotalSum += Convert.ToDecimal(row.Cells["colSubtotal"].Value);
			}

			decimal discount = 0;
			decimal.TryParse(txtDiscount.Text.Trim(), out discount);

			decimal grandTotal = subtotalSum - discount;
			if (grandTotal < 0) grandTotal = 0;

			lblGrandTotalValue.Text = $"${grandTotal:N2}";
		}

		// --- 3. COMPLETE SALE & FINALISE DRAFT INVOICE ---
		private void btnCompleteSale_Click(object sender, EventArgs e)
		{
			if (cmbCustomer.SelectedIndex == -1)
			{
				MessageBox.Show("Please select a customer.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (dgvCart.Rows.Count == 0)
			{
				MessageBox.Show("Your cart is empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				string customerId = cmbCustomer.SelectedValue.ToString();
				string saleDate = dtpSaleDate.Value.ToString("yyyy-MM-dd HH:mm:ss");
				string paymentMethod = cmbPaymentMethod.Text;

				decimal subtotal = 0;
				foreach (DataGridViewRow row in dgvCart.Rows)
				{
					subtotal += Convert.ToDecimal(row.Cells["colSubtotal"].Value);
				}

				decimal discount = 0;
				decimal.TryParse(txtDiscount.Text.Trim(), out discount);
				decimal grandTotal = subtotal - discount;

				// 1. Update the Draft Invoice (Fixed column names to match database schema)
				string updateInvoice = $"UPDATE tblInvoice SET " +
									   $"invoice_date = '{saleDate}', " +
									   $"subtotal = {subtotal}, " +
									   $"discount = {discount}, " +
									   $"grand_total = {grandTotal}, " +
									   $"total_profit = {grandTotal}, " +
									   $"status = 'Paid' " +
									   $"WHERE invoice_id = {currentInvoiceId}";
				db.ExecuteQueries(updateInvoice);

				// 2. Insert Independent Sale Records & Deduct Stock for Each Product
				foreach (DataGridViewRow row in dgvCart.Rows)
				{
					string productId = row.Cells["colProductID"].Value.ToString();
					string price = row.Cells["colPrice"].Value.ToString();
					string qty = row.Cells["colQuantity"].Value.ToString();
					string lineTotal = row.Cells["colSubtotal"].Value.ToString();
					string product_name = row.Cells["colProductName"].Value.ToString();

					string insertsale = $"INSERT INTO tblSale (invoice_id, product_id,product_name, quantity, unit_price, total_price, date,deleted) " +
										$"VALUES ({currentInvoiceId}, {productId},'{product_name}', {qty}, {price}, {lineTotal}, '{saleDate}',0)";
					db.ExecuteQueries(insertsale);

					string updateStock = $"UPDATE tblProduct SET quantity = quantity - {qty} WHERE product_id = {productId}";
					db.ExecuteQueries(updateStock);
				}

				// 3. Insert Payment Record (Including customer_id as required by your table constraint)
				string insertPayment = $"INSERT INTO tblPayment (invoice_id, amount_paid, payment_date, payment_method) " +
									   $"VALUES ({currentInvoiceId}, {grandTotal}, '{saleDate}', '{paymentMethod}')";
				db.ExecuteQueries(insertPayment);

				isSaleCompleted = true;
				MessageBox.Show("Sale completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

				// Trigger Print Preview
				// 4. Safe Print Execution Block
				try
				{
					// Use PrintDialog to let the user select a valid printer and avoid default printer crashes
					PrintDialog printDialog = new PrintDialog();
					printDialog.Document = printDocument1;

					if (printDialog.ShowDialog() == DialogResult.OK)
					{
						printPreviewDialog1.Document = printDocument1;
						if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
						{
							printDocument1.Print();
						}
					}
				}

				catch (Exception printEx)
				{
					MessageBox.Show("Sale saved successfully, but printing failed due to printer settings: " + printEx.Message,
						"Printer Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}

				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error completing sale: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// --- 4. PRINT INVOICE LAYOUT ---
		private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			Graphics g = e.Graphics;
			Font titleFont = new Font("Segoe UI", 18, FontStyle.Bold);
			Font boldFont = new Font("Segoe UI", 10, FontStyle.Bold);
			Font regularFont = new Font("Segoe UI", 10, FontStyle.Regular);
			Brush brush = Brushes.Black;

			int startX = 50;
			int startY = 50;
			int offset = 40;

			g.DrawString("KEY LUXURY STORE", titleFont, brush, startX, startY);
			offset += 30;
			g.DrawString("Official Sales Invoice / Receipt", boldFont, brush, startX, startY + offset);
			offset += 35;

			g.DrawString($"Invoice No: {txtInvoiceNo.Text}", regularFont, brush, startX, startY + offset);
			g.DrawString($"Date: {dtpSaleDate.Value.ToShortDateString()}", regularFont, brush, startX + 300, startY + offset);
			offset += 25;
			g.DrawString($"Customer: {cmbCustomer.Text}", regularFont, brush, startX, startY + offset);
			g.DrawString($"Payment: {cmbPaymentMethod.Text}", regularFont, brush, startX + 300, startY + offset);
			offset += 30;

			g.DrawLine(Pens.Black, startX, startY + offset, startX + 550, startY + offset);
			offset += 10;
			g.DrawString("Product Name", boldFont, brush, startX, startY + offset);
			g.DrawString("Price", boldFont, brush, startX + 280, startY + offset);
			g.DrawString("Qty", boldFont, brush, startX + 370, startY + offset);
			g.DrawString("Subtotal", boldFont, brush, startX + 440, startY + offset);
			offset += 20;
			g.DrawLine(Pens.Black, startX, startY + offset, startX + 550, startY + offset);
			offset += 15;

			decimal subtotalSum = 0;
			foreach (DataGridViewRow row in dgvCart.Rows)
			{
				string pName = row.Cells["colProductName"].Value.ToString();
				string price = Convert.ToDecimal(row.Cells["colPrice"].Value).ToString("N2");
				string qty = row.Cells["colQuantity"].Value.ToString();
				string subtotal = Convert.ToDecimal(row.Cells["colSubtotal"].Value).ToString("N2");

				subtotalSum += Convert.ToDecimal(row.Cells["colSubtotal"].Value);

				g.DrawString(pName, regularFont, brush, startX, startY + offset);
				g.DrawString(price, regularFont, brush, startX + 280, startY + offset);
				g.DrawString(qty, regularFont, brush, startX + 370, startY + offset);
				g.DrawString(subtotal, regularFont, brush, startX + 440, startY + offset);
				offset += 25;
			}

			g.DrawLine(Pens.Black, startX, startY + offset, startX + 550, startY + offset);
			offset += 20;

			decimal discount = 0;
			decimal.TryParse(txtDiscount.Text.Trim(), out discount);
			decimal grandTotal = subtotalSum - discount;

			g.DrawString($"Subtotal: ${subtotalSum:N2}", regularFont, brush, startX + 330, startY + offset);
			offset += 22;
			g.DrawString($"Discount: ${discount:N2}", regularFont, brush, startX + 330, startY + offset);
			offset += 25;
			g.DrawString($"Grand Total: ${grandTotal:N2}", boldFont, brush, startX + 290, startY + offset);
			offset += 50;

			g.DrawString("Thank you for shopping with Key Luxury!", boldFont, brush, startX + 120, startY + offset);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Clean up empty draft invoice if cashier exits without completing the sale
		private void frmManageSale_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!isSaleCompleted && !string.IsNullOrEmpty(currentInvoiceId))
			{
				try
				{
					string cleanupQuery = $"DELETE FROM tblInvoice WHERE invoice_id = {currentInvoiceId} AND status = 'Draft'";
					db.ExecuteQueries(cleanupQuery);
				}
				catch
				{
					// Fail silently on cleanup if needed
				}
			}
		}

		private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}