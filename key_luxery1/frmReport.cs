using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace key_luxery1
{
	public partial class frmReport : Form
	{
		private PrintDocument printDocument = new PrintDocument();
		private int printableRowIndex = 0;
		private DataTable currentReportDataTable = null;

		public frmReport()
		{
			InitializeComponent();
			printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
		}

		private void frmReport_Load(object sender, EventArgs e)
		{
			try
			{
				dtpStartDate.Value = DateTime.Today.AddDays(-30);
				dtpEndDate.Value = DateTime.Today;

				if (cmbReportType.Items.Count == 0)
				{
					cmbReportType.Items.Add("Sales Report");
					cmbReportType.Items.Add("Payment Report");
					cmbReportType.Items.Add("Product Stock Report");
					cmbReportType.Items.Add("Profit Summary");
					cmbReportType.Items.Add("Customer Purchase History");
					cmbReportType.Items.Add("Daily Sales Summary");
					cmbReportType.Items.Add("Low Stock Inventory Report");
				}

				if (cmbReportType.SelectedIndex == -1)
				{
					cmbReportType.SelectedIndex = 0;
				}

				GenerateReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error loading reports: {ex.Message}", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			try
			{
				GenerateReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error searching records: {ex.Message}", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtSearchKeyword_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (currentReportDataTable == null) return;

				string filter = txtSearchKeyword.Text.Trim().Replace("'", "''");
				string reportType = cmbReportType.SelectedItem?.ToString() ?? "";

				if (string.IsNullOrEmpty(filter))
				{
					currentReportDataTable.DefaultView.RowFilter = string.Empty;
				}
				else
				{
					if (reportType == "Product Stock Report" || reportType == "Low Stock Inventory Report")
					{
						currentReportDataTable.DefaultView.RowFilter = string.Format("[Product] LIKE '%{0}%' OR [Category] LIKE '%{0}%'", filter);
					}
					else if (reportType == "Customer Purchase History")
					{
						currentReportDataTable.DefaultView.RowFilter = string.Format("[Customer Name] LIKE '%{0}%' OR [Phone Number] LIKE '%{0}%' OR [Product] LIKE '%{0}%'", filter);
					}
					else if (reportType == "Profit Summary")
					{
						currentReportDataTable.DefaultView.RowFilter = string.Format("[Invoice ID] LIKE '%{0}%' OR [Customer] LIKE '%{0}%'", filter);
					}
					else if (reportType == "Daily Sales Summary")
					{
						currentReportDataTable.DefaultView.RowFilter = string.Format("[Sale Date] LIKE '%{0}%'", filter);
					}
					else if (reportType == "Payment Report")
					{
						currentReportDataTable.DefaultView.RowFilter = string.Format("[Payment ID] LIKE '%{0}%' OR [Invoice ID] LIKE '%{0}%' OR [Method] LIKE '%{0}%'", filter);
					}
					else
					{
						currentReportDataTable.DefaultView.RowFilter = string.Format("[Product] LIKE '%{0}%' OR [Invoice ID] LIKE '%{0}%' OR [Sale ID] LIKE '%{0}%'", filter);
					}
				}

				CalculateSummary(currentReportDataTable, reportType);
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine("Filter Error: " + ex.Message);
			}
		}

		private void GenerateReport()
		{
			try
			{
				string reportType = cmbReportType.SelectedItem?.ToString() ?? "Sales Report";
				string startDate = dtpStartDate.Value.ToString("yyyy-MM-dd 00:00:00");
				string endDate = dtpEndDate.Value.ToString("yyyy-MM-dd 23:59:59");

				string query = string.Empty;

				switch (reportType)
				{
					case "Sales Report":
						query = $"SELECT s.sale_id AS [Sale ID], s.invoice_id AS [Invoice ID], s.product_name AS [Product], " +
								$"s.quantity AS [Qty], s.unit_price AS [Unit Price], s.total_price AS [Total], s.date AS [Date] " +
								$"FROM tblSale s WHERE s.deleted = 0 AND s.date BETWEEN '{startDate}' AND '{endDate}'";
						break;

					case "Payment Report":
						query = $"SELECT p.payment_id AS [Payment ID], p.invoice_id AS [Invoice ID], p.amount_paid AS [Amount Paid], " +
								$"p.payment_method AS [Method], p.payment_date AS [Date] " +
								$"FROM tblPayment p INNER JOIN tblInvoice i ON p.invoice_id = i.invoice_id " +
								$"WHERE i.deleted = 0 AND p.payment_date BETWEEN '{startDate}' AND '{endDate}'";
						break;

					case "Product Stock Report":
						query = $"SELECT p.product_id AS [Product ID], p.product_name AS [Product], p.category AS [Category], " +
								$"p.quantity AS [Current Stock], p.price AS [Selling Price], p.UnitCost AS [Cost], " +
								$"((p.price - p.UnitCost) * p.quantity) AS [Est. Total Profit] " +
								$"FROM tblProduct p WHERE p.deleted = 0";
						break;

					case "Profit Summary":
						query = $"SELECT i.invoice_id AS [Invoice ID], i.customer_name AS [Customer], " +
								$"i.subtotal AS [Subtotal], i.tax AS [Tax], i.discount AS [Discount], " +
								$"i.grand_total AS [Revenue], i.total_profit AS [Profit], i.invoice_date AS [Date] " +
								$"FROM tblInvoice i WHERE i.deleted = 0 AND i.status = 'Paid' AND i.invoice_date BETWEEN '{startDate}' AND '{endDate}'";
						break;

					case "Customer Purchase History":
						query = $"SELECT i.customer_name AS [Customer Name], c.phone AS [Phone Number], s.product_name AS [Product], " +
								$"SUM(s.quantity) AS [Total Qty], SUM(s.total_price) AS [Total Revenue], " +
								$"SUM((s.unit_price - COALESCE(p.UnitCost, 0)) * s.quantity) AS [Est. Profit], " +
								$"MAX(s.date) AS [Last Purchase Date] " +
								$"FROM tblSale s " +
								$"INNER JOIN tblInvoice i ON s.invoice_id = i.invoice_id " +
								$"LEFT JOIN tblCustomer c ON i.customer_id = c.customer_id " +
								$"LEFT JOIN tblProduct p ON s.product_id = p.product_id " +
								$"WHERE i.deleted = 0 AND s.deleted = 0 AND s.date BETWEEN '{startDate}' AND '{endDate}' " +
								$"GROUP BY i.customer_name, c.phone, s.product_name " +
								$"ORDER BY [Total Revenue] DESC";
						break;

					case "Daily Sales Summary":
						query = $"SELECT CAST(s.date AS DATE) AS [Sale Date], COUNT(DISTINCT s.invoice_id) AS [Total Invoices], " +
								$"SUM(s.quantity) AS [Items Sold], SUM(s.total_price) AS [Daily Revenue] " +
								$"FROM tblSale s WHERE s.deleted = 0 AND s.date BETWEEN '{startDate}' AND '{endDate}' " +
								$"GROUP BY CAST(s.date AS DATE) " +
								$"ORDER BY [Sale Date] DESC";
						break;

					case "Low Stock Inventory Report":
						query = $"SELECT product_id AS [Product ID], product_name AS [Product], category AS [Category], " +
								$"quantity AS [Current Stock], price AS [Selling Price], UnitCost AS [Cost] " +
								$"FROM tblProduct WHERE deleted = 0 AND quantity <= 5 " +
								$"ORDER BY quantity ASC";
						break;

					default:
						query = $"SELECT sale_id AS [Sale ID], invoice_id AS [Invoice ID], product_name AS [Product], " +
								$"quantity AS [Qty], total_price AS [Total], date AS [Date] " +
								$"FROM tblSale WHERE deleted = 0 AND date BETWEEN '{startDate}' AND '{endDate}'";
						break;
				}

				currentReportDataTable = sharedClass.GetData(query);
				dgvReports.DataSource = currentReportDataTable;
				CalculateSummary(currentReportDataTable, reportType);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error retrieving report data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void CalculateSummary(DataTable dt, string reportType)
		{
			try
			{
				decimal totalSales = 0;
				decimal totalProfit = 0;
				int totalTransactions = 0;

				DataTable viewTable = (dt != null) ? dt.DefaultView.ToTable() : null;
				totalTransactions = viewTable != null ? viewTable.Rows.Count : 0;

				if (viewTable != null)
				{
					foreach (DataRow row in viewTable.Rows)
					{
						if (reportType == "Sales Report" && row["Total"] != DBNull.Value)
						{
							totalSales += Convert.ToDecimal(row["Total"]);
						}
						else if (reportType == "Payment Report" && row["Amount Paid"] != DBNull.Value)
						{
							totalSales += Convert.ToDecimal(row["Amount Paid"]);
						}
						else if (reportType == "Profit Summary")
						{
							if (row["Revenue"] != DBNull.Value) totalSales += Convert.ToDecimal(row["Revenue"]);
							if (row["Profit"] != DBNull.Value) totalProfit += Convert.ToDecimal(row["Profit"]);
						}
						else if (reportType == "Product Stock Report")
						{
							if (row["Current Stock"] != DBNull.Value && row["Cost"] != DBNull.Value)
							{
								totalSales += Convert.ToDecimal(row["Current Stock"]) * Convert.ToDecimal(row["Cost"]);
							}
							if (row["Est. Total Profit"] != DBNull.Value)
							{
								totalProfit += Convert.ToDecimal(row["Est. Total Profit"]);
							}
						}
						else if (reportType == "Customer Purchase History")
						{
							if (row["Total Revenue"] != DBNull.Value) totalSales += Convert.ToDecimal(row["Total Revenue"]);
							if (row["Est. Profit"] != DBNull.Value) totalProfit += Convert.ToDecimal(row["Est. Profit"]);
						}
						else if (reportType == "Daily Sales Summary")
						{
							if (row["Daily Revenue"] != DBNull.Value) totalSales += Convert.ToDecimal(row["Daily Revenue"]);
						}
						else if (reportType == "Low Stock Inventory Report")
						{
							if (row["Current Stock"] != DBNull.Value && row["Cost"] != DBNull.Value)
							{
								totalSales += Convert.ToDecimal(row["Current Stock"]) * Convert.ToDecimal(row["Cost"]);
							}
						}
					}
				}

				lblTotalSalesVal.Text = totalSales.ToString("C2");
				lblTotalProfitVal.Text = totalProfit.ToString("C2");
				lblTotalTransactionsVal.Text = totalTransactions.ToString("N0");
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine("Calculation Error: " + ex.Message);
			}
		}

		private void btnExportExcel_Click(object sender, EventArgs e)
		{
			try
			{
				if (dgvReports.Rows.Count == 0)
				{
					MessageBox.Show("No data available to export.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				SaveFileDialog sfd = new SaveFileDialog();
				sfd.Filter = "CSV File|*.csv";
				sfd.FileName = $"{cmbReportType.SelectedItem?.ToString().Replace(" ", "_")}_{DateTime.Now:yyyyMMdd}.csv";

				if (sfd.ShowDialog() == DialogResult.OK)
				{
					using (System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName, false, System.Text.Encoding.UTF8))
					{
						for (int i = 0; i < dgvReports.Columns.Count; i++)
						{
							sw.Write(dgvReports.Columns[i].HeaderText);
							if (i < dgvReports.Columns.Count - 1) sw.Write(",");
						}
						sw.WriteLine();

						foreach (DataGridViewRow row in dgvReports.Rows)
						{
							for (int i = 0; i < dgvReports.Columns.Count; i++)
							{
								string cellValue = row.Cells[i].Value?.ToString() ?? "";
								sw.Write($"\"{cellValue.Replace("\"", "\"\"")}\"");
								if (i < dgvReports.Columns.Count - 1) sw.Write(",");
							}
							sw.WriteLine();
						}
					}

					MessageBox.Show("Report exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error exporting file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			try
			{
				if (dgvReports.Rows.Count == 0)
				{
					MessageBox.Show("No data available to print.", "Print", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				printableRowIndex = 0;
				PrintPreviewDialog previewDialog = new PrintPreviewDialog();
				previewDialog.Document = printDocument;
				previewDialog.Width = 950;
				previewDialog.Height = 750;
				previewDialog.ShowDialog();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Printing Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
		{
			try
			{
				Graphics graphics = e.Graphics;
				Font brandFont = new Font("Segoe UI", 16, FontStyle.Bold);
				Font titleFont = new Font("Segoe UI", 12, FontStyle.Bold);
				Font subtitleFont = new Font("Segoe UI", 9, FontStyle.Italic);
				Font headerFont = new Font("Segoe UI", 9, FontStyle.Bold);
				Font rowFont = new Font("Segoe UI", 9, FontStyle.Regular);
				Font summaryFont = new Font("Segoe UI", 9, FontStyle.Bold);
				Font conclusionFont = new Font("Segoe UI", 10, FontStyle.Bold);

				float startX = e.MarginBounds.Left;
				float startY = e.MarginBounds.Top;
				float printableWidth = e.MarginBounds.Width;

				// 1. Professional Store Header
				graphics.DrawString("KEY LUXURY STORE", brandFont, Brushes.Navy, startX, startY);

				string reportType = cmbReportType.SelectedItem?.ToString() ?? "Business Report";
				graphics.DrawString(reportType.ToUpper(), titleFont, Brushes.DarkSlateGray, startX, startY + 25);

				string dateRangeInfo = $"Reporting Period: {dtpStartDate.Value:yyyy-MM-dd} to {dtpEndDate.Value:yyyy-MM-dd}  |  Generated: {DateTime.Now:g}";
				graphics.DrawString(dateRangeInfo, subtitleFont, Brushes.DimGray, startX, startY + 48);

				graphics.DrawLine(Pens.Navy, startX, startY + 70, startX + printableWidth, startY + 70);

				startY += 85;

				int totalColumns = dgvReports.Columns.Count;
				float colWidth = printableWidth / totalColumns;

				// 2. Styled Column Headers
				float currentX = startX;
				for (int i = 0; i < totalColumns; i++)
				{
					string headerText = dgvReports.Columns[i].HeaderText;
					graphics.FillRectangle(new SolidBrush(Color.FromArgb(41, 128, 185)), currentX, startY, colWidth, 26);
					graphics.DrawRectangle(Pens.Navy, currentX, startY, colWidth, 26);
					graphics.DrawString(headerText, headerFont, Brushes.White, currentX + 6, startY + 5);
					currentX += colWidth;
				}

				startY += 26;

				decimal pageQtySum = 0;
				decimal pageAmountSum = 0;
				int rowsOnThisPage = 0;
				bool alternateRow = false;

				// 3. Data Rows Loop with Page Subtotal Trigger
				while (printableRowIndex < dgvReports.Rows.Count)
				{
					DataGridViewRow row = dgvReports.Rows[printableRowIndex];

					// Reserve space for conclusion box or subtotal
					if (startY + 22 > e.MarginBounds.Bottom - 110)
					{
						DrawPageSubtotal(graphics, startX, startY, printableWidth, rowsOnThisPage, pageQtySum, pageAmountSum, summaryFont);
						e.HasMorePages = true;
						return;
					}

					currentX = startX;
					Brush rowBgBrush = alternateRow ? Brushes.WhiteSmoke : Brushes.White;

					for (int i = 0; i < totalColumns; i++)
					{
						string colName = dgvReports.Columns[i].HeaderText;
						string cellValue = "";
						object val = row.Cells[i].Value;

						if (val != null && val != DBNull.Value)
						{
							if (val is DateTime dtVal)
							{
								cellValue = dtVal.ToString("yyyy-MM-dd");
							}
							else
							{
								cellValue = val.ToString();
								if (DateTime.TryParse(cellValue, out DateTime parsedDate) && cellValue.Length > 10)
								{
									cellValue = parsedDate.ToString("yyyy-MM-dd");
								}
							}

							if (decimal.TryParse(val.ToString(), out decimal numericVal))
							{
								if (colName.Contains("Qty") || colName.Contains("Quantity") || colName.Contains("Stock") || colName.Contains("Items"))
								{
									pageQtySum += numericVal;
								}
								else if (colName.Contains("Total") || colName.Contains("Amount") || colName.Contains("Revenue") || colName.Contains("Price") || colName.Contains("Cost"))
								{
									pageAmountSum += numericVal;
								}
							}
						}

						if (cellValue.Length > 28)
						{
							cellValue = cellValue.Substring(0, 25) + "...";
						}

						graphics.FillRectangle(rowBgBrush, currentX, startY, colWidth, 22);
						graphics.DrawRectangle(Pens.LightGray, currentX, startY, colWidth, 22);
						graphics.DrawString(cellValue, rowFont, Brushes.Black, currentX + 6, startY + 4);
						currentX += colWidth;
					}

					startY += 22;
					rowsOnThisPage++;
					alternateRow = !alternateRow;
					printableRowIndex++;
				}

				// 4. Professional Executive Conclusion & Summary Box on Final Page
				startY += 12;
				graphics.DrawLine(Pens.Navy, startX, startY, startX + printableWidth, startY);
				startY += 14;

				RectangleF summaryBox = new RectangleF(startX, startY, printableWidth, 120);
				graphics.FillRectangle(new SolidBrush(Color.FromArgb(248, 249, 250)), summaryBox);
				graphics.DrawRectangle(Pens.Navy, startX, startY, printableWidth, 120);

				// Title Inside Conclusion Box
				graphics.FillRectangle(new SolidBrush(Color.FromArgb(52, 73, 94)), startX, startY, printableWidth, 24);
				graphics.DrawString("EXECUTIVE REPORT CONCLUSION & AUDIT SUMMARY", headerFont, Brushes.White, startX + 10, startY + 5);

				// Summary Metrics Display
				string summaryText1 = $"• Total Records / Transactions: {lblTotalTransactionsVal.Text}";
				string summaryText2 = $"• Total Revenue / Valuation: {lblTotalSalesVal.Text}";
				string summaryText3 = lblTotalProfitVal.Visible && lblTotalProfitVal.Text != "$0.00" ? $"• Estimated Net Profit: {lblTotalProfitVal.Text}" : "• Status: Fully Verified & Audited";

				graphics.DrawString(summaryText1, headerFont, Brushes.DarkSlateGray, startX + 15, startY + 36);
				graphics.DrawString(summaryText2, headerFont, Brushes.DarkSlateGray, startX + 15, startY + 58);
				graphics.DrawString(summaryText3, headerFont, Brushes.ForestGreen, startX + 15, startY + 80);

				// Professional Management Approval Signature Area
				float sigX = startX + printableWidth - 230;
				graphics.DrawString("Management Approval:", headerFont, Brushes.Black, sigX, startY + 36);
				graphics.DrawLine(Pens.Black, sigX, startY + 95, sigX + 210, startY + 95);
				graphics.DrawString("Authorized Signature & Stamp", subtitleFont, Brushes.Gray, sigX + 25, startY + 98);

				e.HasMorePages = false;
				printableRowIndex = 0;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Printing Page Error: {ex.Message}", "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void DrawPageSubtotal(Graphics g, float startX, float startY, float printableWidth, int pageRowCount, decimal pageQty, decimal pageAmount, Font font)
		{
			startY += 6;
			g.FillRectangle(new SolidBrush(Color.FromArgb(220, 230, 242)), startX, startY, printableWidth, 26);
			g.DrawRectangle(Pens.SteelBlue, startX, startY, printableWidth, 26);

			string pageSubtotalText = $"Page Subtotal ({pageRowCount} Rows)   |   Total Units: {pageQty:N0}   |   Subtotal Amount: {pageAmount:C2}";
			g.DrawString(pageSubtotalText, font, Brushes.Navy, startX + 10, startY + 5);
		}
	}
}