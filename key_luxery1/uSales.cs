using System;
using System.Windows.Forms;

namespace key_luxery1
{
	public partial class uSales : UserControl
	{
		private sharedClass db = new sharedClass();

		public uSales()
		{
			InitializeComponent();
		}

		private void uSales_Load(object sender, EventArgs e)
		{
			LoadSalesData();
		}

		/// <summary>
		/// Loads or filters records from tblSale into the grid using sharedClass.DisplayData.
		/// </summary>
		private void LoadSalesData(string filterKeyword = "")
		{
			try
			{
				string query = "SELECT sale_id AS [Sale ID], product_id AS [Product ID], product_name AS [Item Name], quantity AS [Qty], unit_price AS [Price], total_price AS [Net Total], date AS [Sale Date], Invoice_id as [Invoice ID] FROM tblSale WHERE deleted = 0";

				if (!string.IsNullOrEmpty(filterKeyword))
				{
					string safeKeyword = filterKeyword.Replace("'", "''");
					query += $" AND product_name LIKE '%{safeKeyword}%' OR sale_id LIKE '%{safeKeyword}%'";
				}

				query += " ORDER BY date DESC";

				// Uses your sharedClass helper method directly
				sharedClass.DisplayData(dgvSales, query);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading sales data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			txtFilterInput.Clear();
			LoadSalesData();
			MessageBox.Show("Sales table refreshed successfully.", "Refreshed", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void txtFilterInput_TextChanged(object sender, EventArgs e)
		{
			LoadSalesData(txtFilterInput.Text.Trim());
		}

		private void btnNewSale_Click(object sender, EventArgs e)
		{
			frmManageSale manageSaleForm = new frmManageSale();
			manageSaleForm.ShowDialog();
			LoadSalesData(); // Refresh grid after closing manage sale form
		}

		private void btnManageSale_Click(object sender, EventArgs e)
		{
			frmManageSale manageSaleForm = new frmManageSale();
			manageSaleForm.ShowDialog();
			LoadSalesData(); // Refresh grid after closing manage sale form
		}
	}
}