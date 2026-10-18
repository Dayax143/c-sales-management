using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace key_luxery1
{
	public partial class frmRecoverProduct : Form
	{
		sharedClass db = new sharedClass();
		public frmRecoverProduct()
		{
			InitializeComponent();
		}

		private void btnRecover_Click(object sender, EventArgs e)
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

				DialogResult confirm = MessageBox.Show($"Are you sure you want to recover {selectedIDs.Count} selected product(s)?",
													   "Confirm Multiple Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (confirm == DialogResult.Yes)
				{
					try
					{
						string idsString = string.Join(",", selectedIDs);
						string query = $"UPDATE tblProduct SET deleted = 0 WHERE product_id IN ({idsString})";

						db.ExecuteQueries(query);

						MessageBox.Show("Selected products recover successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

						// Reload grid data and categories
						LoadProductsData(txtSearchFilter.Text.Trim(), cmbFilterCategory.SelectedItem?.ToString());
						LoadCategories();
					}
					catch (Exception ex)
					{
						MessageBox.Show($"Error recovering products: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public void LoadProductsData(string searchKeyword = "", string category = "")
		{
			try
			{
				// 1. Get total record count for pagination calculation based on active filters
				string countQuery = "SELECT COUNT(*) FROM tblProduct WHERE deleted = 1";

				if (!string.IsNullOrEmpty(searchKeyword))
				{
					string safeKeyword = searchKeyword.Replace("'", "''");
					countQuery += $" AND (product_name LIKE '%{safeKeyword}%' OR product_id LIKE '%{safeKeyword}%' OR barcode LIKE '%{safeKeyword}%')";
				}

				if (!string.IsNullOrEmpty(category) && category != "All Categories")
				{
					countQuery += $" AND category = '{category.Replace("'", "''")}'";
				}
								
				// 2. Build the paginated SELECT query
				string query = "SELECT product_id AS [ID], product_name AS [Product Name], category AS [Category], price AS [Price], UnitCost AS [Cost], quantity AS [Stock], barcode AS [Barcode], date AS [Date Added] FROM tblProduct WHERE deleted = 1";

				if (!string.IsNullOrEmpty(searchKeyword))
				{
					string safeKeyword = searchKeyword.Replace("'", "''");
					query += $" AND (product_name LIKE '%{safeKeyword}%' OR product_id LIKE '%{safeKeyword}%' OR barcode LIKE '%{safeKeyword}%')";
				}

				if (!string.IsNullOrEmpty(category) && category != "All Categories")
				{
					query += $" AND category = '{category.Replace("'", "''")}'";
				}

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

				DataTable dt = sharedClass.GetData("SELECT DISTINCT category FROM tblProduct WHERE deleted = 1 AND category IS NOT NULL");
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


		private void frmRecoverProduct_Load(object sender, EventArgs e)
		{
			LoadProductsData();
		}
	}
}
