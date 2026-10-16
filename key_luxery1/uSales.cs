using System;
using System.Data;
using System.Windows.Forms;

namespace key_luxery1
{
	public partial class uSales : UserControl
	{
		private sharedClass db = new sharedClass();
		// Pagination state variables
		private int currentPage = 1;
		private int pageSize = 15; // Number of records per page
		private int totalRecords = 0;
		private int totalPages = 1;

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
		//private void LoadSalesData(string filterKeyword = "")
		//{
		//	try
		//	{
		//		string query = "SELECT sale_id AS [Sale ID], product_id AS [Product ID], product_name AS [Item Name], quantity AS [Qty], unit_price AS [Price], total_price AS [Net Total], date AS [Sale Date], Invoice_id as [Invoice ID] FROM tblSale WHERE deleted = 0";

		//		if (!string.IsNullOrEmpty(filterKeyword))
		//		{
		//			string safeKeyword = filterKeyword.Replace("'", "''");
		//			query += $" AND product_name LIKE '%{safeKeyword}%' OR sale_id LIKE '%{safeKeyword}%'";
		//		}

		//		query += " ORDER BY date DESC";

		//		// Uses your sharedClass helper method directly
		//		sharedClass.DisplayData(dgvSales, query);
		//	}
		//	catch (Exception ex)
		//	{
		//		MessageBox.Show("Error loading sales data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		//	}
		//}
		/// <summary>
		/// Loads or filters records from tblSale into the grid using sharedClass.DisplayData.
		/// </summary>
		private void LoadSalesData(string searchKeyword = "", string category = "")
		{
			try
			{
				// 1. Get total record count for pagination calculation based on active filters
				string countQuery = "SELECT COUNT(*) FROM tblSale WHERE deleted = 0";

				if (!string.IsNullOrEmpty(searchKeyword))
				{
					string safeKeyword = searchKeyword.Replace("'", "''");
					countQuery += $" AND (item_name LIKE '%{safeKeyword}%' OR sale_id LIKE '%{safeKeyword}%' OR barcode LIKE '%{safeKeyword}%')";
				}

				//if (!string.IsNullOrEmpty(category) && category != "All Categories")
				//{
				//	countQuery += $" AND category = '{category.Replace("'", "''")}'";
				//}

				DataTable dtCount = sharedClass.GetData(countQuery);
				if (dtCount != null && dtCount.Rows.Count > 0)
				{
					totalRecords = Convert.ToInt32(dtCount.Rows[0][0]);
				}

				// Calculate total pages (minimum 1 page)
				totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
				if (totalPages == 0) totalPages = 1;

				// Keep current page within valid bounds
				if (currentPage > totalPages) currentPage = totalPages;
				if (currentPage < 1) currentPage = 1;

				int offset = (currentPage - 1) * pageSize;

				// 2. Build the paginated SELECT query
				string query = "SELECT sale_id AS [Sale ID], product_id AS [Product ID], product_name AS [Item Name], quantity AS [Qty], unit_price AS [Price], total_price AS [Net Total], date AS [Sale Date], Invoice_id as [Invoice ID] FROM tblSale WHERE deleted = 0";

				if (!string.IsNullOrEmpty(searchKeyword))
				{
					string safeKeyword = searchKeyword.Replace("'", "''");
					query += $" AND (item_name LIKE '%{safeKeyword}%' OR sale_id LIKE '%{safeKeyword}%' OR barcode LIKE '%{safeKeyword}%')";
				}

				//if (!string.IsNullOrEmpty(category) && category != "All Categories")
				//{
				//	query += $" AND returned = '{category.Replace("'", "''")}'";
				//}

				query += $" ORDER BY sale_id DESC OFFSET {offset} ROWS FETCH NEXT {pageSize} ROWS ONLY";

				// Calls your sharedClass DisplayData method
				sharedClass.DisplayData(dgvSales, query);

				// Update pagination UI elements if available
				if (lblPageInfo != null)
				{
					lblPageInfo.Text = $"Page {currentPage} of {totalPages}";
				}
				if (btnPrev != null)
				{
					btnPrev.Enabled = (currentPage > 1);
				}
				if (btnNext != null)
				{
					btnNext.Enabled = (currentPage < totalPages);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading products: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void btnPrev_Click(object sender, EventArgs e)
		{
			if (currentPage > 1)
			{
				currentPage--;
				LoadSalesData(txtFilterInput.Text.Trim(), cmbFilterCategory.SelectedItem?.ToString());
			}
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			if (currentPage < totalPages)
			{
				currentPage++;
				LoadSalesData(txtFilterInput.Text.Trim(), cmbFilterCategory.SelectedItem?.ToString());
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