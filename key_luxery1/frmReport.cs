using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace key_luxery1
{
	public partial class frmReport : Form
	{
		private DataTable reportTable;
		private sharedClass db = new sharedClass();

		// Printing Fields
		private PrintDocument printDoc = new PrintDocument();
		private PrintPreviewDialog printPreviewDlg = new PrintPreviewDialog();
		private int currentPrintRow = 0;
		private int pageNumber = 0;

		public frmReport()
		{
			InitializeComponent();

			// Configure Print Document
			printDoc.DefaultPageSettings.Landscape = true; // Use Landscape for optimal column layout
			printDoc.BeginPrint += new PrintEventHandler(PrintDocument_BeginPrint);
			printDoc.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
		}

		private void frmReport_Load(object sender, EventArgs e)
		{
			// Default Date Range: Start of current month to today
			dtpStartDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
			dtpEndDate.Value = DateTime.Now;

			if (cmbReportType.Items.Count > 0)
			{
				cmbReportType.SelectedIndex = 0;
			}

			LoadSelectedReport();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			LoadSelectedReport();
		}

		private void LoadSelectedReport()
		{
			string startDate = dtpStartDate.Value.ToString("yyyy-MM-dd 00:00:00");
			string endDate = dtpEndDate.Value.ToString("yyyy-MM-dd 23:59:59");
			string reportType = cmbReportType.SelectedItem?.ToString() ?? "";

			string query = "";

			switch (reportType)
			{
				case "Expense Summary Report":
					query = string.Format(
						"SELECT Id, Category, Amount, ExpenseDate AS Date, Description " +
						"FROM tblExpenses " +
						"WHERE ExpenseDate BETWEEN '{0}' AND '{1}' " +
						"ORDER BY ExpenseDate DESC",
						startDate, endDate);
					break;

				case "Profit & Loss Report":
					query = string.Format(
						"SELECT 'Sales Revenue' AS Type, ISNULL(SUM(total_price), 0) AS Amount " +
						"FROM tblSale WHERE ISNULL(deleted, 0) = 0 AND ISNULL(returned, 0) = 0 AND date BETWEEN '{0}' AND '{1}' " +
						"UNION ALL " +
						"SELECT 'Operating Expenses' AS Type, ISNULL(SUM(Amount), 0) AS Amount " +
						"FROM tblExpenses WHERE ExpenseDate BETWEEN '{0}' AND '{1}'",
						startDate, endDate);
					break;

				case "Daily Sales & Expense Breakdown":
					query = string.Format(
						"SELECT ISNULL(CAST(s.date AS DATE), CAST(e.ExpenseDate AS DATE)) AS Date, " +
						"ISNULL(SUM(s.total_price), 0) AS TotalSales, " +
						"ISNULL(SUM(e.Amount), 0) AS TotalExpenses, " +
						"(ISNULL(SUM(s.total_price), 0) - ISNULL(SUM(e.Amount), 0)) AS NetProfit " +
						"FROM tblSale s " +
						"FULL OUTER JOIN tblExpenses e ON CAST(s.date AS DATE) = CAST(e.ExpenseDate AS DATE) " +
						"WHERE (ISNULL(s.deleted, 0) = 0) " +
						"AND ((s.date BETWEEN '{0}' AND '{1}') OR (e.ExpenseDate BETWEEN '{0}' AND '{1}')) " +
						"GROUP BY ISNULL(CAST(s.date AS DATE), CAST(e.ExpenseDate AS DATE)) " +
						"ORDER BY Date DESC",
						startDate, endDate);
					break;

				case "Sales Report":
				default:
					query = string.Format(
						"SELECT sale_id AS [Sale ID], invoice_id AS [Invoice ID], product_id AS [Product ID], " +
						"product_name AS [Product], quantity AS [Qty], unit_price AS [Unit Price], " +
						"total_price AS [Total], date AS [Date], returned AS [Returned] " +
						"FROM tblSale " +
						"WHERE ISNULL(deleted, 0) = 0 AND date BETWEEN '{0}' AND '{1}' " +
						"ORDER BY date DESC",
						startDate, endDate);
					break;
			}

			reportTable = sharedClass.GetData(query);
			dgvReports.DataSource = reportTable;

			FormatGridColumns();
			CalculateTotals(startDate, endDate);
		}

		private void CalculateTotals(string startDate, string endDate)
		{
			try
			{
				string salesQuery = string.Format(
					"SELECT SUM(total_price) FROM tblSale " +
					"WHERE ISNULL(deleted, 0) = 0 AND ISNULL(returned, 0) = 0 AND date BETWEEN '{0}' AND '{1}'",
					startDate, endDate);
				object salesObj = db.ExecuteScalarQuery(salesQuery);
				decimal totalSales = (salesObj != DBNull.Value && salesObj != null) ? Convert.ToDecimal(salesObj) : 0m;

				string expenseQuery = string.Format(
					"SELECT SUM(Amount) FROM tblExpenses WHERE ExpenseDate BETWEEN '{0}' AND '{1}'",
					startDate, endDate);
				object expObj = db.ExecuteScalarQuery(expenseQuery);
				decimal totalExpenses = (expObj != DBNull.Value && expObj != null) ? Convert.ToDecimal(expObj) : 0m;

				decimal netProfit = totalSales - totalExpenses;

				lblTotalSalesVal.Text = totalSales.ToString("C2");
				lblTotalExpensesVal.Text = totalExpenses.ToString("C2");
				lblTotalProfitVal.Text = netProfit.ToString("C2");
				lblTotalProfitVal.ForeColor = netProfit < 0 ? Color.Red : Color.ForestGreen;
				lblTotalTransactionsVal.Text = dgvReports.Rows.Count.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error calculating totals: " + ex.Message, "Calculation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void FormatGridColumns()
		{
			foreach (DataGridViewColumn col in dgvReports.Columns)
			{
				if (col.Name.Contains("Price") || col.Name.Contains("Total") || col.Name.Contains("Amount") ||
					col.Name.Contains("Sales") || col.Name.Contains("Expenses") || col.Name.Contains("NetProfit"))
				{
					col.DefaultCellStyle.Format = "C2";
				}
				if (col.Name.Contains("Date"))
				{
					col.DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
				}
				if (col.Name.Equals("Id", StringComparison.OrdinalIgnoreCase) || col.Name.Equals("Sale ID", StringComparison.OrdinalIgnoreCase))
				{
					col.Visible = false;
				}
			}
		}

		private void txtSearchKeyword_TextChanged(object sender, EventArgs e)
		{
			if (reportTable == null) return;

			string filter = txtSearchKeyword.Text.Trim().Replace("'", "''");

			if (string.IsNullOrEmpty(filter))
			{
				reportTable.DefaultView.RowFilter = string.Empty;
			}
			else
			{
				StringBuilder sb = new StringBuilder();
				for (int i = 0; i < reportTable.Columns.Count; i++)
				{
					if (i > 0) sb.Append(" OR ");
					sb.AppendFormat("CONVERT([{0}], 'System.String') LIKE '%{1}%'", reportTable.Columns[i].ColumnName, filter);
				}
				reportTable.DefaultView.RowFilter = sb.ToString();
			}

			lblTotalTransactionsVal.Text = dgvReports.Rows.Count.ToString();
		}

		private void btnExportExcel_Click(object sender, EventArgs e)
		{
			if (dgvReports.Rows.Count == 0)
			{
				MessageBox.Show("No data available to export.", "Export Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			SaveFileDialog sfd = new SaveFileDialog
			{
				Filter = "CSV File (*.csv)|*.csv",
				FileName = (cmbReportType.SelectedItem?.ToString().Replace(" ", "_") ?? "Report") + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv"
			};

			if (sfd.ShowDialog() == DialogResult.OK)
			{
				try
				{
					StringBuilder csv = new StringBuilder();
					for (int i = 0; i < dgvReports.Columns.Count; i++)
					{
						if (dgvReports.Columns[i].Visible)
						{
							csv.Append(dgvReports.Columns[i].HeaderText + (i == dgvReports.Columns.Count - 1 ? "" : ","));
						}
					}
					csv.AppendLine();

					foreach (DataGridViewRow row in dgvReports.Rows)
					{
						for (int i = 0; i < dgvReports.Columns.Count; i++)
						{
							if (dgvReports.Columns[i].Visible)
							{
								string val = row.Cells[i].Value?.ToString().Replace(",", " ") ?? "";
								csv.Append(val + (i == dgvReports.Columns.Count - 1 ? "" : ","));
							}
						}
						csv.AppendLine();
					}

					File.WriteAllText(sfd.FileName, csv.ToString(), Encoding.UTF8);
					MessageBox.Show("Report exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error exporting CSV: " + ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		// ----------------------------------------------------
		// STANDARDIZED PRINT & PRINT PREVIEW IMPLEMENTATION
		// ----------------------------------------------------
		private void btnPrint_Click(object sender, EventArgs e)
		{
			try
			{
				if (dgvReports.Rows.Count == 0)
				{
					MessageBox.Show("No data available to print.", "Print Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				printPreviewDlg.Document = printDoc;
				printPreviewDlg.Size = new Size(1100, 800);
				printPreviewDlg.StartPosition = FormStartPosition.CenterScreen;
				printPreviewDlg.ShowDialog();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Print Error: " + ex.Message, "Printing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void PrintDocument_BeginPrint(object sender, PrintEventArgs e)
		{
			// Reset page state every time printing begins or preview generates
			currentPrintRow = 0;
			pageNumber = 0;
		}

		private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
		{
			try
			{
				pageNumber++;
				Graphics g = e.Graphics;

				// Typography & Styling Fonts
				Font titleFont = new Font("Segoe UI", 16, FontStyle.Bold);
				Font subTitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
				Font metaFont = new Font("Segoe UI", 8.5f, FontStyle.Regular);
				Font headerFont = new Font("Segoe UI", 9, FontStyle.Bold);
				Font bodyFont = new Font("Segoe UI", 8.5f, FontStyle.Regular);
				Font summaryFont = new Font("Segoe UI", 9.5f, FontStyle.Bold);
				Font sigFont = new Font("Segoe UI", 9, FontStyle.Bold);

				// Safe Page Bounds calculation
				int margin = 40;
				int printWidth = Math.Max(400, e.PageBounds.Width - (margin * 2));
				int printBottom = e.PageBounds.Height - margin;
				int startX = margin;
				int currentY = margin;

				// Formatting Rules
				StringFormat cellFormatLeft = new StringFormat
				{
					Trimming = StringTrimming.EllipsisCharacter,
					FormatFlags = StringFormatFlags.NoWrap,
					LineAlignment = StringAlignment.Center,
					Alignment = StringAlignment.Near
				};

				StringFormat cellFormatRight = new StringFormat
				{
					Trimming = StringTrimming.EllipsisCharacter,
					FormatFlags = StringFormatFlags.NoWrap,
					LineAlignment = StringAlignment.Center,
					Alignment = StringAlignment.Far
				};

				// 1. BRANDING & HEADER SECTION
				g.DrawString("KEY LUXURY STORE", titleFont, Brushes.Navy, startX, currentY);
				currentY += 30;

				string reportTitle = "Official Report: " + (cmbReportType.SelectedItem?.ToString() ?? "Report");
				g.DrawString(reportTitle, subTitleFont, Brushes.DarkSlateGray, startX, currentY);

				string pageStr = "Page " + pageNumber;
				float pageStrWidth = g.MeasureString(pageStr, metaFont).Width;
				g.DrawString(pageStr, metaFont, Brushes.Gray, startX + printWidth - Math.Max(50, (int)pageStrWidth), currentY);
				currentY += 20;

				string dateRangeStr = "Period: " + dtpStartDate.Value.ToString("yyyy-MM-dd") + " to " + dtpEndDate.Value.ToString("yyyy-MM-dd");
				g.DrawString(dateRangeStr, metaFont, Brushes.DimGray, startX, currentY);

				string genDateStr = "Printed On: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm");
				float genDateWidth = g.MeasureString(genDateStr, metaFont).Width;
				g.DrawString(genDateStr, metaFont, Brushes.DimGray, startX + printWidth - Math.Max(120, (int)genDateWidth), currentY);
				currentY += 22;

				// Header Accent Line
				g.DrawLine(new Pen(Color.Navy, 2), startX, currentY, startX + printWidth, currentY);
				currentY += 15;

				// 2. DYNAMIC COLUMN SIZING & PROPORTIONAL FITTING
				List<DataGridViewColumn> visibleCols = new List<DataGridViewColumn>();
				foreach (DataGridViewColumn col in dgvReports.Columns)
				{
					if (col.Visible) visibleCols.Add(col);
				}

				if (visibleCols.Count == 0)
				{
					e.HasMorePages = false;
					return;
				}

				Dictionary<int, int> colWidths = new Dictionary<int, int>();
				float totalWeight = 0;

				foreach (var col in visibleCols)
				{
					float weight = 1.0f;
					if (col.Name.Contains("Product") || col.Name.Contains("Description")) weight = 2.4f;
					else if (col.Name.Contains("Date")) weight = 1.6f;
					else if (col.Name.Contains("Price") || col.Name.Contains("Amount") || col.Name.Contains("Total") || col.Name.Contains("Sales") || col.Name.Contains("Expenses") || col.Name.Contains("NetProfit")) weight = 1.4f;
					else if (col.Name.Contains("Qty") || col.Name.Contains("Returned")) weight = 0.8f;

					totalWeight += weight;
				}

				foreach (var col in visibleCols)
				{
					float weight = 1.0f;
					if (col.Name.Contains("Product") || col.Name.Contains("Description")) weight = 2.4f;
					else if (col.Name.Contains("Date")) weight = 1.6f;
					else if (col.Name.Contains("Price") || col.Name.Contains("Amount") || col.Name.Contains("Total") || col.Name.Contains("Sales") || col.Name.Contains("Expenses") || col.Name.Contains("NetProfit")) weight = 1.4f;
					else if (col.Name.Contains("Qty") || col.Name.Contains("Returned")) weight = 0.8f;

					int calculatedWidth = (int)((weight / totalWeight) * printWidth);
					colWidths[col.Index] = Math.Max(50, calculatedWidth); // Minimum 50px width per column
				}

				// 3. DRAW COLUMN HEADERS
				g.FillRectangle(new SolidBrush(Color.FromArgb(41, 128, 185)), startX, currentY, printWidth, 26);

				int currentHeaderX = startX;
				foreach (var col in visibleCols)
				{
					int w = colWidths[col.Index];
					Rectangle headerRect = new Rectangle(currentHeaderX + 2, currentY, Math.Max(10, w - 4), 26);

					bool isNumeric = col.Name.Contains("Price") || col.Name.Contains("Amount") || col.Name.Contains("Total") || col.Name.Contains("Sales") || col.Name.Contains("Expenses") || col.Name.Contains("NetProfit") || col.Name.Contains("Qty");
					g.DrawString(col.HeaderText, headerFont, Brushes.White, headerRect, isNumeric ? cellFormatRight : cellFormatLeft);

					currentHeaderX += w;
				}

				currentY += 26;

				// 4. DRAW DATA ROWS WITH PAGINATION
				int rowHeight = 24;
				while (currentPrintRow < dgvReports.Rows.Count)
				{
					DataGridViewRow row = dgvReports.Rows[currentPrintRow];

					// Reserve space for summary block and signatures on the final page
					if (currentY + rowHeight > printBottom - 160)
					{
						e.HasMorePages = true;
						return;
					}

					// Alternate Row Colors
					if (currentPrintRow % 2 == 0)
					{
						g.FillRectangle(new SolidBrush(Color.FromArgb(245, 247, 250)), startX, currentY, printWidth, rowHeight);
					}

					int cellX = startX;
					foreach (var col in visibleCols)
					{
						int w = colWidths[col.Index];
						string val = row.Cells[col.Index].FormattedValue?.ToString() ?? "";

						Rectangle cellRect = new Rectangle(cellX + 2, currentY, Math.Max(10, w - 4), rowHeight);
						bool isNumeric = col.Name.Contains("Price") || col.Name.Contains("Amount") || col.Name.Contains("Total") || col.Name.Contains("Sales") || col.Name.Contains("Expenses") || col.Name.Contains("NetProfit") || col.Name.Contains("Qty");

						g.DrawString(val, bodyFont, Brushes.Black, cellRect, isNumeric ? cellFormatRight : cellFormatLeft);
						cellX += w;
					}

					g.DrawLine(Pens.LightGray, startX, currentY + rowHeight, startX + printWidth, currentY + rowHeight);
					currentY += rowHeight;
					currentPrintRow++;
				}

				// 5. EXECUTIVE SUMMARY BLOCK (PRINTED ON LAST PAGE)
				currentY += 15;

				Rectangle summaryBox = new Rectangle(startX, currentY, printWidth, 42);
				g.FillRectangle(new SolidBrush(Color.FromArgb(236, 240, 241)), summaryBox);
				g.DrawRectangle(new Pen(Color.FromArgb(189, 195, 199), 1), summaryBox);

				string textSales = "Revenue: " + lblTotalSalesVal.Text;
				string textExp = "Expenses: " + lblTotalExpensesVal.Text;
				string textProfit = "Net Profit: " + lblTotalProfitVal.Text;
				string textRecords = "Records: " + lblTotalTransactionsVal.Text;

				int spacing = printWidth / 4;
				g.DrawString(textSales, summaryFont, Brushes.Navy, startX + 10, currentY + 11);
				g.DrawString(textExp, summaryFont, Brushes.DarkRed, startX + spacing + 5, currentY + 11);
				g.DrawString(textProfit, summaryFont, lblTotalProfitVal.ForeColor == Color.Red ? Brushes.Red : Brushes.ForestGreen, startX + (spacing * 2) + 5, currentY + 11);
				g.DrawString(textRecords, summaryFont, Brushes.DarkSlateGray, startX + (spacing * 3) + 5, currentY + 11);

				currentY += 65;

				// 6. OFFICIAL KEY LUXURY SIGNATURE BLOCKS
				int sigWidth = 220;
				int prepX = startX + 30;
				int apprX = startX + printWidth - sigWidth - 30;

				// Prepared By
				g.DrawLine(new Pen(Color.Black, 1.5f), prepX, currentY, prepX + sigWidth, currentY);
				g.DrawString("PREPARED BY (Key Luxury)", sigFont, Brushes.Black, prepX + 15, currentY + 6);

				// Approved By
				g.DrawLine(new Pen(Color.Black, 1.5f), apprX, currentY, apprX + sigWidth, currentY);
				g.DrawString("APPROVED BY (Key Luxury)", sigFont, Brushes.Black, apprX + 15, currentY + 6);

				currentY += 35;
				string footerMsg = "KEY LUXURY STORE • OFFICIAL CONFIDENTIAL REPORT";
				Font footerFont = new Font("Segoe UI", 8, FontStyle.Bold);
				float footerWidth = g.MeasureString(footerMsg, footerFont).Width;
				float footerX = startX + Math.Max(0, (printWidth - (int)footerWidth) / 2);
				g.DrawString(footerMsg, footerFont, Brushes.Gray, footerX, currentY);

				e.HasMorePages = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Printing layout error: " + ex.Message, "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}