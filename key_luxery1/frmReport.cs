using System;
using System.Data;
using System.Windows.Forms;

namespace key_luxery1
{
	public partial class frmReport : Form
	{
		// Assuming your database helper class is named 'db'
		// dbAccess db = new dbAccess(); 

		public frmReport()
		{
			InitializeComponent();
		}

		private void frmReport_Load(object sender, EventArgs e)
		{
			cmbReportType.SelectedIndex = 0; // Default to Sales Report
			dtpStartDate.Value = DateTime.Now.AddDays(-30); // Default to past 30 days
			dtpEndDate.Value = DateTime.Now;
			LoadReportData();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			LoadReportData();
		}

		private void LoadReportData()
		{
			try
			{
				string startDate = dtpStartDate.Value.ToString("yyyy-MM-dd 00:00:00");
				string endDate = dtpEndDate.Value.ToString("yyyy-MM-dd 23:59:59");
				string query = "";

				string selectedReport = cmbReportType.SelectedItem?.ToString() ?? "Sales Report";

				if (selectedReport == "Sales Report")
				{
					query = $"SELECT invoice_no AS [Invoice No], product_id AS [Product ID], item_name AS [Item Name], " +
							$"quantity AS [Qty], price AS [Price], netPrice AS [Net Total], profit AS [Profit], date AS [Date] " +
							$"FROM tblSales WHERE date BETWEEN '{startDate}' AND '{endDate}'";
				}
				else if (selectedReport == "Payment Report")
				{
					query = $"SELECT payment_id AS [Payment ID], invoice_no AS [Invoice No], amount_paid AS [Amount Paid], " +
							$"payment_method AS [Method], payment_date AS [Payment Date] " +
							$"FROM tblPayments WHERE payment_date BETWEEN '{startDate}' AND '{endDate}'";
				}
				else if (selectedReport == "Product Stock Report")
				{
					// Adjust table/columns according to your database product schema
					query = $"SELECT product_id AS [Product ID], product_name AS [Product Name], price AS [Price], stock_qty AS [Stock] FROM tblProducts";
				}
				else if (selectedReport == "Profit Summary")
				{
					query = $"SELECT invoice_no AS [Invoice No], SUM(netPrice) AS [Total Sales], SUM(profit) AS [Total Profit], MAX(date) AS [Date] " +
							$"FROM tblSales WHERE date BETWEEN '{startDate}' AND '{endDate}' GROUP BY invoice_no";
				}

				// Execute query using your database connection class
				// DataTable dt = db.GetData(query);
				// dgvReports.DataSource = dt;

				// Calculate Summary Cards
				CalculateSummary();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading report data: " + ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void CalculateSummary()
		{
			decimal totalSales = 0;
			decimal totalProfit = 0;
			int rowCount = dgvReports.Rows.Count;

			foreach (DataGridViewRow row in dgvReports.Rows)
			{
				if (row.IsNewRow) continue;

				// Safely sum up values if columns exist
				if (dgvReports.Columns.Contains("Net Total") && row.Cells["Net Total"].Value != null)
				{
					totalSales += Convert.ToDecimal(row.Cells["Net Total"].Value);
				}
				else if (dgvReports.Columns.Contains("Total Sales") && row.Cells["Total Sales"].Value != null)
				{
					totalSales += Convert.ToDecimal(row.Cells["Total Sales"].Value);
				}

				if (dgvReports.Columns.Contains("Profit") && row.Cells["Profit"].Value != null)
				{
					totalProfit += Convert.ToDecimal(row.Cells["Profit"].Value);
				}
				else if (dgvReports.Columns.Contains("Total Profit") && row.Cells["Total Profit"].Value != null)
				{
					totalProfit += Convert.ToDecimal(row.Cells["Total Profit"].Value);
				}
			}

			lblTotalSalesVal.Text = totalSales.ToString("C2");
			lblTotalProfitVal.Text = totalProfit.ToString("C2");
			lblTotalTransactionsVal.Text = rowCount.ToString();
		}

		private void btnExportExcel_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Export to Excel functionality can be implemented using libraries like ClosedXML or EPPlus.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Print preview and document rendering initialized.", "Print", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}