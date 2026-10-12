using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace key_luxery1
{
	public partial class uProducts : UserControl
	{
		private sharedClass db = new sharedClass();

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

				query += " ORDER BY product_id DESC";

				// Calls your sharedClass DisplayData method
				sharedClass.DisplayData(dgvProducts, query);
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
			LoadProductsData(txtSearchFilter.Text.Trim(), cmbFilterCategory.SelectedItem?.ToString());
		}

		private void cmbFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadProductsData(txtSearchFilter.Text.Trim(), cmbFilterCategory.SelectedItem?.ToString());
		}

		private void button1_Click(object sender, EventArgs e)
		{
			frmManageProduct manageForm = new frmManageProduct();
			manageForm.ShowDialog();
			LoadProductsData(); // Refresh list after managing products
			LoadCategories();
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			txtSearchFilter.Clear();
			//if (cmbFilterCategory.Items.Count > 0) cmbFilterCategory.SelectedIndex = 0;
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

		private void btnStock_Click(object sender, EventArgs e)
		{
			frmStock stock = new frmStock();
			stock.ShowDialog();
		}
	}
}