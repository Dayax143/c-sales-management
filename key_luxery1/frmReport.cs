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

		public frmReport()
		{
			InitializeComponent();

			// Wire up the print document event
			printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
		}

		private void frmReport_Load(object sender, EventArgs e)
		{
			// Set default date range to current month
			dtpStartDate.Value = DateTime.Today.AddDays(-30);
			dtpEndDate.Value = DateTime.Today;

			// Select default report type
			if (cmbReportType.Items.Count > 0)
			{
				cmbReportType.SelectedIndex = 0;
			}

			// Load initial report data
			GenerateReport();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			GenerateReport();
		}

		private void GenerateReport()
		{
			string reportType = cmbReportType.SelectedItem?.ToString() ?? "Sales Report";
			string startDate = dtpStartDate.Value.ToString("yyyy-MM-dd 00:00:00");
			string endDate = dtpEndDate.Value.ToString("yyyy-MM-dd 23:59:59");

			string query = string.Empty;

			// Build query based on report type using tblSale schema
			switch (reportType)
			{
				case "Sales Report":
					query = $"SELECT sale_id AS [Sale ID], invoice_id AS [Invoice ID], product_name AS [Product], " +
							$"quantity AS [Qty], unit_price AS [Unit Price], total_price AS [Total], date AS [Date] " +
							$"FROM tblSale WHERE deleted = 0 AND date BETWEEN '{startDate}' AND '{endDate}'";
					break;

				case "Payment Report":
					query = $"SELECT sale_id AS [Sale ID], invoice_id AS [Invoice ID], total_price AS [Amount Paid], " +
							$"date AS [Date] FROM tblSale WHERE deleted = 0 AND returned = 0 AND date BETWEEN '{startDate}' AND '{endDate}'";
					break;

				case "Product Stock Report":
					query = $"SELECT product_id AS [Product ID], product_name AS [Product], " +
							$"SUM(quantity) AS [Total Sold], AVG(unit_price) AS [Avg Unit Price] " +
							$"FROM tblSale WHERE deleted = 0 GROUP BY product_id, product_name";
					break;

				case "Profit Summary":
					query = $"SELECT sale_id AS [Sale ID], invoice_id AS [Invoice ID], product_name AS [Product], " +
							$"total_price AS [Revenue], date AS [Date] " +
							$"FROM tblSale WHERE deleted = 0 AND date BETWEEN '{startDate}' AND '{endDate}'";
					break;

				default:
					query = $"SELECT * FROM tblSale WHERE deleted = 0 AND date BETWEEN '{startDate}' AND '{endDate}'";
					break;
			}

			try
			{
				// Call the method from your SharedClass
				DataTable dt = sharedClass.GetData(query);

				dgvReports.DataSource = dt;

				// Calculate summary values based on tblSale columns
				CalculateSummary(dt, reportType);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error retrieving data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void CalculateSummary(DataTable dt, string reportType)
		{
			decimal totalSales = 0;
			decimal totalProfit = 0;
			int totalTransactions = dt != null ? dt.Rows.Count : 0;

			if (dt != null)
			{
				foreach (DataRow row in dt.Rows)
				{
					if (reportType == "Sales Report" && row["Total"] != DBNull.Value)
					{
						totalSales += Convert.ToDecimal(row["Total"]);
					}
					else if (reportType == "Profit Summary")
					{
						if (row["Revenue"] != DBNull.Value) totalSales += Convert.ToDecimal(row["Revenue"]);
						if (row["Profit"] != DBNull.Value) totalProfit += Convert.ToDecimal(row["Profit"]);
					}
					else if (reportType == "Payment Report" && row["Amount Paid"] != DBNull.Value)
					{
						totalSales += Convert.ToDecimal(row["Amount Paid"]);
					}
				}
			}

			// Update UI Labels
			lblTotalSalesVal.Text = totalSales.ToString("C2");
			lblTotalProfitVal.Text = totalProfit.ToString("C2");
			lblTotalTransactionsVal.Text = totalTransactions.ToString("N0");
		}

		private void btnExportExcel_Click(object sender, EventArgs e)
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
				try
				{
					using (System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName, false, System.Text.Encoding.UTF8))
					{
						// Write Headers
						for (int i = 0; i < dgvReports.Columns.Count; i++)
						{
							sw.Write(dgvReports.Columns[i].HeaderText);
							if (i < dgvReports.Columns.Count - 1) sw.Write(",");
						}
						sw.WriteLine();

						// Write Rows
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
				catch (Exception ex)
				{
					MessageBox.Show($"Error exporting file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			try
			{
				// Reset pagination index before opening preview
				printableRowIndex = 0;

				// Setup and show the Print Preview Dialog
				PrintPreviewDialog previewDialog = new PrintPreviewDialog();
				previewDialog.Document = printDocument;
				previewDialog.Width = 900;
				previewDialog.Height = 700;
				previewDialog.ShowDialog();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			if (dgvReports.Rows.Count == 0)
			{
				MessageBox.Show("No data available to print.", "Print", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

		}

		private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Font titleFont = new Font("Arial", 16, FontStyle.Bold);
			Font subtitleFont = new Font("Arial", 10, FontStyle.Italic);
			Font headerFont = new Font("Arial", 10, FontStyle.Bold);
			Font rowFont = new Font("Arial", 9, FontStyle.Regular);

			float startX = 50;
			float startY = 50;
			float offsetY = 40;

			// Draw Report Title
			string reportTitle = cmbReportType.SelectedItem?.ToString() ?? "Business Report";
			graphics.DrawString(reportTitle, titleFont, Brushes.Black, startX, startY);

			// Draw Date Range Subtitle
			string dateRangeInfo = $"Period: {dtpStartDate.Value:yyyy-MM-dd} to {dtpEndDate.Value:yyyy-MM-dd}";
			graphics.DrawString(dateRangeInfo, subtitleFont, Brushes.Gray, startX, startY + 30);

			startY += 80;

			// Calculate column widths dynamically based on available print width
			float printableWidth = e.MarginBounds.Width;
			int totalColumns = dgvReports.Columns.Count;
			float colWidth = printableWidth / totalColumns;

			// Draw Column Headers
			float currentX = startX;
			for (int i = 0; i < totalColumns; i++)
			{
				string headerText = dgvReports.Columns[i].HeaderText;
				graphics.FillRectangle(Brushes.LightGray, currentX, startY, colWidth, 25);
				graphics.DrawRectangle(Pens.Black, currentX, startY, colWidth, 25);
				graphics.DrawString(headerText, headerFont, Brushes.Black, currentX + 5, startY + 4);
				currentX += colWidth;
			}

			startY += 25;

			// Draw Data Rows with pagination support
			while (printableRowIndex < dgvReports.Rows.Count)
			{
				DataGridViewRow row = dgvReports.Rows[printableRowIndex];

				// Stop if we exceed the bottom printable boundary of the current page
				if (startY + 20 > e.MarginBounds.Bottom)
				{
					e.HasMorePages = true;
					return;
				}

				currentX = startX;
				for (int i = 0; i < totalColumns; i++)
				{
					string cellValue = row.Cells[i].Value?.ToString() ?? "";

					// Truncate long text to prevent overflow within column bounds
					if (cellValue.Length > 25)
					{
						cellValue = cellValue.Substring(0, 22) + "...";
					}

					graphics.DrawRectangle(Pens.LightGray, currentX, startY, colWidth, 20);
					graphics.DrawString(cellValue, rowFont, Brushes.DarkSlateGray, currentX + 5, startY + 3);
					currentX += colWidth;
				}

				startY += 20;
				printableRowIndex++;
			}

			// No more pages left to print
			e.HasMorePages = false;
			printableRowIndex = 0; // Reset for subsequent prints
		}
	}
}