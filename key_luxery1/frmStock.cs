using System;
using System.Data;
using System.Windows.Forms;

namespace key_luxery1
{
	public partial class frmStock : Form
	{
		private sharedClass db = new sharedClass();
		private string selectedProductId = "";

		public frmStock()
		{
			InitializeComponent();
		}

		private void frmStock_Load(object sender, EventArgs e)
		{
			LoadStockInventory();
			LoadStockLogs();
		}

		/// <summary>
		/// Loads current inventory quantities using sharedClass.DisplayData
		/// </summary>
		private void LoadStockInventory(string searchKeyword = "")
		{
			try
			{
				string query = "SELECT Product_ID AS [ID], Product_Name AS [Product Name], Category AS [Category], Quantity AS [Stock In Hand], Price AS [Unit Price] from tblProduct WHERE deleted=0";

				if (!string.IsNullOrEmpty(searchKeyword))
				{
					query += $" AND Product_Name LIKE '%{searchKeyword.Replace("'", "''")}%'";
				}

				query += " ORDER BY quantity ASC"; // Highlights low stock items at the top

				sharedClass.DisplayData(dgvCurrentStock, query);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading stock inventory: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// Loads stock movement logs/history ledger
		/// </summary>
		private void LoadStockLogs()
		{
			try
			{
				// Optional: If you maintain a stock movement audit log table, load it here.
				// Fallback query displays recent product records or activity.
				string query = "SELECT Product_ID, Product_Name, quantity, 'status' AS [Action Status] from tblProduct";
				sharedClass.DisplayData(dgvStockLogs, query);
			}
			catch
			{
				// Suppress if audit log table hasn't been created yet
			}
		}

		private void dgvCurrentStock_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dgvCurrentStock.Rows[e.RowIndex];
				selectedProductId = row.Cells["ID"].Value.ToString();
				string productName = row.Cells["Product Name"].Value.ToString();
				int currentStock = Convert.ToInt32(row.Cells["Stock In Hand"].Value);

				txtSelectedProduct.Text = $"{productName} (Qty: {currentStock})";
			}
		}

		private void txtSearchStock_TextChanged(object sender, EventArgs e)
		{
			LoadStockInventory(txtSearchStock.Text.Trim());
		}

		private void btnRestock_Click(object sender, EventArgs e)
		{
			ProcessStockAdjustment(true);
		}

		private void btnAdjust_Click(object sender, EventArgs e)
		{
			ProcessStockAdjustment(false);
		}

		/// <summary>
		/// Handles both Restocking (addition) and Shrinkage/Damage (subtraction) atomically.
		/// </summary>
		private void ProcessStockAdjustment(bool isRestock)
		{
			if (string.IsNullOrEmpty(selectedProductId))
			{
				MessageBox.Show("Please select a product from the inventory grid first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!int.TryParse(txtAdjustmentQty.Text.Trim(), out int qty) || qty <= 0)
			{
				MessageBox.Show("Please enter a valid numeric quantity greater than 0.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				string operation = isRestock ? "+" : "-";
				string actionType = isRestock ? "Restock" : "Shrinkage/Damage";

				string query = $"UPDATE tblProduct SET Quantity = Quantity {operation} {qty} WHERE Product_ID = {selectedProductId}";
				db.ExecuteQueries(query);

				MessageBox.Show($"Stock successfully adjusted! Action: {actionType} ({qty} units).", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

				// Refresh grids
				LoadStockInventory();
				LoadStockLogs();
				txtAdjustmentQty.Text = "1";
				txtSelectedProduct.Text = "Select item from grid ->";
				selectedProductId = "";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error updating stock: " + ex.Message, "Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}