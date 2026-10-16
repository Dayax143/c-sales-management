using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace key_luxery1
{
	public partial class uProducts : UserControl
	{
		private sharedClass db = new sharedClass();

		// Pagination state variables
		private int currentPage = 1;
		private int pageSize = 15; // Number of records per page
		private int totalRecords = 0;
		private int totalPages = 1;

		public uProducts()
		{
			InitializeComponent();
		}

		private void uProducts_Load(object sender, EventArgs e)
		{
			LoadProductsData();
			LoadCategories();
		}

		public void LoadProductsData(string searchKeyword = "", string category = "")
		{
			try
			{
				// 1. Get total record count for pagination calculation based on active filters
				string countQuery = "SELECT COUNT(*) FROM tblProduct WHERE deleted = 0";

				if (!string.IsNullOrEmpty(searchKeyword))
				{
					string safeKeyword = searchKeyword.Replace("'", "''");
					countQuery += $" AND (product_name LIKE '%{safeKeyword}%' OR product_id LIKE '%{safeKeyword}%' OR barcode LIKE '%{safeKeyword}%')";
				}

				if (!string.IsNullOrEmpty(category) && category != "All Categories")
				{
					countQuery += $" AND category = '{category.Replace("'", "''")}'";
				}

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
				string query = "SELECT product_id AS [ID], product_name AS [Product Name], category AS [Category], price AS [Price], UnitCost AS [Cost], quantity AS [Stock], barcode AS [Barcode], date AS [Date Added] FROM tblProduct WHERE deleted = 0";

				if (!string.IsNullOrEmpty(searchKeyword))
				{
					string safeKeyword = searchKeyword.Replace("'", "''");
					query += $" AND (product_name LIKE '%{safeKeyword}%' OR product_id LIKE '%{safeKeyword}%' OR barcode LIKE '%{safeKeyword}%')";
				}

				if (!string.IsNullOrEmpty(category) && category != "All Categories")
				{
					query += $" AND category = '{category.Replace("'", "''")}'";
				}

				query += $" ORDER BY product_id DESC OFFSET {offset} ROWS FETCH NEXT {pageSize} ROWS ONLY";

				// Calls your sharedClass DisplayData method
				sharedClass.DisplayData(dgvProducts, query);

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

		private void LoadCategories()
		{
			try
			{
				cmbFilterCategory.Items.Clear();
				cmbFilterCategory.Items.Add("All Categories");

				DataTable dt = sharedClass.GetData("SELECT DISTINCT category FROM tblProduct WHERE deleted = 0 AND category IS NOT NULL");
				foreach (DataRow row in dt.Rows)
				{
					if (row["category"] != DBNull.Value)
					{
						cmbFilterCategory.Items.Add(row["category"].ToString());
					}
				}

				if (cmbFilterCategory.Items.Count > 0)
				{
					cmbFilterCategory.SelectedIndex = 0;
				}
			}
			catch
			{
				cmbFilterCategory.Items.Add("All Categories");
				cmbFilterCategory.SelectedIndex = 0;
			}
		}

		private void txtSearchFilter_TextChanged(object sender, EventArgs e)
		{
			currentPage = 1; // Reset to page 1 on new search
			LoadProductsData(txtSearchFilter.Text.Trim(), cmbFilterCategory.SelectedItem?.ToString());
		}

		private void cmbFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			currentPage = 1; // Reset to page 1 on category filter change
			LoadProductsData(txtSearchFilter.Text.Trim(), cmbFilterCategory.SelectedItem?.ToString());
		}

		private void btnPrev_Click(object sender, EventArgs e)
		{
			if (currentPage > 1)
			{
				currentPage--;
				LoadProductsData(txtSearchFilter.Text.Trim(), cmbFilterCategory.SelectedItem?.ToString());
			}
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			if (currentPage < totalPages)
			{
				currentPage++;
				LoadProductsData(txtSearchFilter.Text.Trim(), cmbFilterCategory.SelectedItem?.ToString());
			}
		}

		private void btnAddProduct_Click(object sender, EventArgs e)
		{
			frmManageProduct manageForm = new frmManageProduct();
			manageForm.ShowDialog();
			LoadProductsData(); // Refresh list after managing products
			LoadCategories();
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			txtSearchFilter.Clear();
			currentPage = 1;
			LoadProductsData();
			MessageBox.Show("Inventory product list refreshed.", "Refreshed", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnExport_Click(object sender, EventArgs e)
		{
			try
			{
				if (dgvProducts.Rows.Count > 0)
				{
					SaveFileDialog sfd = new SaveFileDialog();
					sfd.Filter = "CSV (*.csv)|*.csv";
					sfd.FileName = "Product_Inventory_" + DateTime.Now.ToString("yyyyMMdd") + ".csv";

					if (sfd.ShowDialog() == DialogResult.OK)
					{
						using (StreamWriter sw = new StreamWriter(sfd.FileName))
						{
							for (int i = 0; i < dgvProducts.Columns.Count; i++)
							{
								sw.Write(dgvProducts.Columns[i].HeaderText);
								if (i < dgvProducts.Columns.Count - 1) sw.Write(",");
							}
							sw.WriteLine();

							foreach (DataGridViewRow row in dgvProducts.Rows)
							{
								if (!row.IsNewRow)
								{
									for (int i = 0; i < dgvProducts.Columns.Count; i++)
									{
										if (row.Cells[i].Value != null)
										{
											sw.Write('"' + row.Cells[i].Value.ToString().Replace("\"", "\"\"") + '"');
										}
										if (i < dgvProducts.Columns.Count - 1) sw.Write(",");
									}
									sw.WriteLine();
								}
							}
						}
						MessageBox.Show("Inventory report exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				else
				{
					MessageBox.Show("No inventory records to export.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error exporting data: " + ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Delete selected products from the DataGridView
		private void btnDeleteSelected_Click(object sender, EventArgs e)
		{
			try
			{
				List<string> selectedIDs = new List<string>();

				foreach (DataGridViewRow row in dgvProducts.Rows)
				{
					bool isChecked = Convert.ToBoolean(row.Cells["chkSelect"].Value);
					if (isChecked)
					{
						string productId = row.Cells["ID"].Value.ToString();
						selectedIDs.Add(productId);
					}
				}

				if (selectedIDs.Count == 0)
				{
					MessageBox.Show("Please check at least one product checkbox to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				DialogResult confirm = MessageBox.Show($"Are you sure you want to delete {selectedIDs.Count} selected product(s)?",
													   "Confirm Multiple Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (confirm == DialogResult.Yes)
				{
					try
					{
						string idsString = string.Join(",", selectedIDs);
						string query = $"UPDATE tblProduct SET deleted = 1 WHERE product_id IN ({idsString})";

						db.ExecuteQueries(query);

						MessageBox.Show("Selected products deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

						// Reload grid data and categories
						LoadProductsData(txtSearchFilter.Text.Trim(), cmbFilterCategory.SelectedItem?.ToString());
						LoadCategories();
					}
					catch (Exception ex)
					{
						MessageBox.Show($"Error deleting products: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnStock_Click(object sender, EventArgs e)
		{
			frmStock stock = new frmStock();
			stock.ShowDialog();
		}

		private void btnImport_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
				openFileDialog.Title = "Select Excel File to Import Products";

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					string filePath = openFileDialog.FileName;
					int successCount = 0;
					int errorCount = 0;

					try
					{
						using (var workbook = new XLWorkbook(filePath))
						{
							var worksheet = workbook.Worksheet(1);
							var rows = worksheet.RowsUsed();
							bool isHeader = true;

							foreach (var row in rows)
							{
								if (isHeader)
								{
									isHeader = false;
									continue;
								}

								try
								{
									string productName = row.Cell(1).Value.ToString();
									string category = row.Cell(2).Value.ToString();

									int quantity = int.TryParse(row.Cell(3).Value.ToString(), out int q) ? q : 0;
									int barcode = int.TryParse(row.Cell(4).Value.ToString(), out int b) ? b : 0;

									decimal unitCost = decimal.TryParse(row.Cell(5).Value.ToString(), out decimal uc) ? uc : 0;
									decimal price = decimal.TryParse(row.Cell(6).Value.ToString(), out decimal p) ? p : 0;

									string status = row.Cell(7).Value.ToString();

									string query = @"INSERT INTO tblProduct 
													(product_name, category, quantity, barcode, UnitCost, price, status, date, deleted) 
													VALUES 
													('" + productName.Replace("'", "''") + "', '" +
														  category.Replace("'", "''") + "', " +
														  quantity + ", " +
														  barcode + ", " +
														  unitCost + ", " +
														  price + ", '" +
														  status.Replace("'", "''") + "', GETDATE(), 0)";

									db.ExecuteQueries(query);
									successCount++;
								}
								catch (Exception rowEx)
								{
									errorCount++;
								}
							}

							MessageBox.Show($"Import completed!\nSuccessfully imported: {successCount} rows.\nErrors/Skipped: {errorCount} rows.",
											"Import Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

							LoadProductsData();
							LoadCategories();
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show($"Fatal error reading Excel file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}
	}
}