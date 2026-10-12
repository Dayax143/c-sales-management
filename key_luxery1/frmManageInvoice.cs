using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace key_luxery1
{
	public partial class frmManageInvoice : Form
	{
		sharedClass db = new sharedClass();
		private string selectedInvoiceNoForPrint = "";

		public frmManageInvoice()
		{
			InitializeComponent();
		}

		private void frmManageInvoice_Load(object sender, EventArgs e)
		{
			LoadInvoices();
		}

		// --- 1. LOAD INVOICES MATCHING EXACT tblInvoice SCHEMA ---
		public void LoadInvoices()
		{
			try
			{
				string query = @"SELECT i.invoice_id AS [ID], 
                                        i.invoice_no AS [Invoice No], 
                                        c.customer_name AS [Customer Name], 
                                        i.invoice_date AS [Invoice Date], 
                                        i.due_date AS [Due Date],
                                        i.subtotal AS [Subtotal ($)], 
                                        i.discount AS [Discount ($)], 
                                        i.tax AS [Tax ($)], 
                                        i.grand_total AS [Grand Total ($)], 
                                        i.total_profit AS [Profit ($)], 
                                        i.status AS [Status] 
                                 FROM tblInvoice i
                                 LEFT JOIN tblCustomer c ON i.customer_id = c.customer_id
                                 WHERE (i.deleted = 0 OR i.deleted IS NULL) AND i.status != 'Draft'
                                 ORDER BY i.invoice_id DESC";

				DataTable dt = sharedClass.GetData(query);
				dgvInvoices.DataSource = dt;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading invoices: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// --- 2. LIVE SEARCH FILTER ---
		private void txtSearchInvoiceNo_TextChanged(object sender, EventArgs e)
		{
			string keyword = txtSearchInvoiceNo.Text.Trim();
			try
			{
				string query = $@"SELECT i.invoice_id AS [ID], 
                                        i.invoice_no AS [Invoice No], 
                                        c.customer_name AS [Customer Name], 
                                        i.invoice_date AS [Invoice Date], 
                                        i.due_date AS [Due Date],
                                        i.subtotal AS [Subtotal ($)], 
                                        i.discount AS [Discount ($)], 
                                        i.tax AS [Tax ($)], 
                                        i.grand_total AS [Grand Total ($)], 
                                        i.total_profit AS [Profit ($)], 
                                        i.status AS [Status] 
                                 FROM tblInvoice i
                                 LEFT JOIN tblCustomer c ON i.customer_id = c.customer_id
                                 WHERE (i.deleted = 0 OR i.deleted IS NULL) 
                                   AND i.status != 'Draft' 
                                   AND i.invoice_no LIKE '%{keyword}%'
                                 ORDER BY i.invoice_id DESC";

				DataTable dt = sharedClass.GetData(query);
				dgvInvoices.DataSource = dt;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching invoices: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			txtSearchInvoiceNo.Clear();
			LoadInvoices();
		}

		// --- 3. VIEW ITEMS FOR SELECTED INVOICE ---
		private void btnViewItems_Click(object sender, EventArgs e)
		{
			if (dgvInvoices.SelectedRows.Count > 0)
			{
				string invoiceId = dgvInvoices.SelectedRows[0].Cells["ID"].Value.ToString();
				string invoiceNo = dgvInvoices.SelectedRows[0].Cells["Invoice No"].Value.ToString();

				try
				{
					string query = $"SELECT product_name AS [Product], quantity AS [Qty], unit_price AS [Price], total_price AS [Total] FROM tblSale WHERE invoice_id = {invoiceId}";
					DataTable dtItems = sharedClass.GetData(query);

					string summary = $"Items Breakdown for Invoice: {invoiceNo}\n\n";
					foreach (DataRow r in dtItems.Rows)
					{
						summary += $"- {r["Product"]} (x{r["Qty"]}) @ ${Convert.ToDecimal(r["Price"]):N2} = ${Convert.ToDecimal(r["Total"]):N2}\n";
					}
					MessageBox.Show(summary, "Invoice Items", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error loading invoice items: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Please select an invoice row to view items.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		// --- 4. RE-PRINT SELECTED INVOICE FROM HISTORY ---
		private void btnPrintInvoice_Click(object sender, EventArgs e)
		{
			if (dgvInvoices.SelectedRows.Count > 0)
			{
				selectedInvoiceNoForPrint = dgvInvoices.SelectedRows[0].Cells["Invoice No"].Value.ToString();

				try
				{
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
				catch (Exception ex)
				{
					MessageBox.Show("Printing error: " + ex.Message, "Printer Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			else
			{
				MessageBox.Show("Please select an invoice row to print.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		// --- 5. PRINT PAGE LAYOUT USING tblInvoice COLUMNS ---
		private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			if (string.IsNullOrEmpty(selectedInvoiceNoForPrint)) return;

			Graphics g = e.Graphics;
			Font titleFont = new Font("Segoe UI", 18, FontStyle.Bold);
			Font boldFont = new Font("Segoe UI", 10, FontStyle.Bold);
			Font regularFont = new Font("Segoe UI", 10, FontStyle.Regular);
			Brush brush = Brushes.Black;

			int startX = 50;
			int startY = 50;
			int offset = 40;

			// Fetch record matching tblInvoice schema columns
			string invoiceQuery = $@"SELECT i.invoice_id, i.invoice_no, i.subtotal, i.discount, i.tax, i.grand_total, i.invoice_date, c.customer_name 
                                     FROM tblInvoice i 
                                     LEFT JOIN tblCustomer c ON i.customer_id = c.customer_id 
                                     WHERE i.invoice_no = '{selectedInvoiceNoForPrint}'";
			DataTable dtInvoice = sharedClass.GetData(invoiceQuery);

			if (dtInvoice.Rows.Count == 0) return;
			DataRow invRow = dtInvoice.Rows[0];

			string customerName = invRow["customer_name"] != DBNull.Value ? invRow["customer_name"].ToString() : "Walk-in Customer";
			string invoiceDate = invRow["invoice_date"] != DBNull.Value ? Convert.ToDateTime(invRow["invoice_date"]).ToString("yyyy-MM-dd HH:mm") : "";
			decimal subtotal = invRow["subtotal"] != DBNull.Value ? Convert.ToDecimal(invRow["subtotal"]) : 0;
			decimal discount = invRow["discount"] != DBNull.Value ? Convert.ToDecimal(invRow["discount"]) : 0;
			decimal tax = invRow["tax"] != DBNull.Value ? Convert.ToDecimal(invRow["tax"]) : 0;
			decimal grandTotal = Convert.ToDecimal(invRow["grand_total"]);
			string invoiceId = invRow["invoice_id"].ToString();

			// Draw Header
			g.DrawString("KEY LUXURY STORE", titleFont, brush, startX, startY);
			offset += 30;
			g.DrawString("Official Sales Invoice (Copy)", boldFont, brush, startX, startY + offset);
			offset += 35;

			g.DrawString($"Invoice No: {selectedInvoiceNoForPrint}", regularFont, brush, startX, startY + offset);
			g.DrawString($"Date: {invoiceDate}", regularFont, brush, startX + 280, startY + offset);
			offset += 25;
			g.DrawString($"Customer: {customerName}", regularFont, brush, startX, startY + offset);
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

			// Fetch itemized products from tblSale
			string itemsQuery = $"SELECT product_name, unit_price, quantity, total_price FROM tblSale WHERE invoice_id = {invoiceId}";
			DataTable dtItems = sharedClass.GetData(itemsQuery);

			foreach (DataRow row in dtItems.Rows)
			{
				string pName = row["product_name"].ToString();
				string price = Convert.ToDecimal(row["unit_price"]).ToString("N2");
				string qty = row["quantity"].ToString();
				string lineTotal = Convert.ToDecimal(row["total_price"]).ToString("N2");

				g.DrawString(pName, regularFont, brush, startX, startY + offset);
				g.DrawString(price, regularFont, brush, startX + 280, startY + offset);
				g.DrawString(qty, regularFont, brush, startX + 370, startY + offset);
				g.DrawString(lineTotal, regularFont, brush, startX + 440, startY + offset);
				offset += 25;
			}

			g.DrawLine(Pens.Black, startX, startY + offset, startX + 550, startY + offset);
			offset += 20;

			// Draw Totals using tblInvoice columns
			g.DrawString($"Subtotal: ${subtotal:N2}", regularFont, brush, startX + 330, startY + offset);
			offset += 22;
			g.DrawString($"Discount: ${discount:N2}", regularFont, brush, startX + 330, startY + offset);
			offset += 22;
			g.DrawString($"Tax: ${tax:N2}", regularFont, brush, startX + 330, startY + offset);
			offset += 25;
			g.DrawString($"Grand Total: ${grandTotal:N2}", boldFont, brush, startX + 290, startY + offset);
			offset += 50;

			g.DrawString("Thank you for shopping with Key Luxury!", boldFont, brush, startX + 120, startY + offset);
		}

		// --- 6. SOFT DELETE INVOICE (deleted = 1) ---
		private void btnDeleteInvoice_Click(object sender, EventArgs e)
		{
			if (dgvInvoices.SelectedRows.Count > 0)
			{
				string invoiceId = dgvInvoices.SelectedRows[0].Cells["ID"].Value.ToString();
				string invoiceNo = dgvInvoices.SelectedRows[0].Cells["Invoice No"].Value.ToString();

				DialogResult result = MessageBox.Show($"Are you sure you want to delete invoice {invoiceNo}?",
					"Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (result == DialogResult.Yes)
				{
					try
					{
						string deleteQuery = $"UPDATE tblInvoice SET deleted = 1 WHERE invoice_id = {invoiceId}";
						db.ExecuteQueries(deleteQuery);

						MessageBox.Show("Invoice deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
						LoadInvoices();
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error deleting invoice: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				MessageBox.Show("Please select an invoice row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}