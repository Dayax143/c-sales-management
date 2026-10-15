using System;
using System.Windows.Forms;

namespace key_luxery1
{
	public partial class frmManageProduct : Form
	{
		private sharedClass db = new sharedClass();

		public frmManageProduct()
		{
			InitializeComponent();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				// Handle optional Category: if empty, pass SQL NULL; otherwise, wrap in single quotes
				string categoryValue = string.IsNullOrWhiteSpace(cmbCategory.Text)
					? "NULL"
					: $"'{cmbCategory.Text.Trim().Replace("'", "''")}'";

				// Handle optional Barcode: if empty, pass SQL NULL; otherwise, wrap in single quotes
				string barcodeValue = string.IsNullOrWhiteSpace(txtBarcode.Text)
					? "NULL"
					: $"'{txtBarcode.Text.Trim().Replace("'", "''")}'";

				// Handle numerical fields with defaults if empty
				string quantity = string.IsNullOrWhiteSpace(txtStock.Text) ? "0" : txtStock.Text.Trim();
				string unitCost = string.IsNullOrWhiteSpace(txtCost.Text) ? "0" : txtCost.Text.Trim();
				string price = string.IsNullOrWhiteSpace(txtPrice.Text) ? "0" : txtPrice.Text.Trim();

				// Construct the SQL query for your SharedClass ExecuteQueries method
				string query = $@"INSERT INTO tblProduct (Product_Name, Category, quantity, UnitCost, Price, date, barcode, deleted) 
                     VALUES ('{txtProductName.Text.Trim().Replace("'", "''")}', 
                             {categoryValue}, 
                             {quantity}, 
                             {unitCost}, 
                             {price}, 
                             '{DateTime.Now:yyyy-MM-dd HH:mm:ss}', 
                             {barcodeValue}, 
                             0)";

				// Execute via your SharedClass instance
				db.ExecuteQueries(query);

				MessageBox.Show("Product saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btnClean_Click(sender, e);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				string query = $"UPDATE tblProduct SET Product_Name = '{txtProductName.Text.Trim()}', Category = '{cmbCategory.Text.Trim()}', Quantity = {txtStock.Text.Trim()}, UnitCost = {txtCost.Text.Trim()}, Price = {txtPrice.Text.Trim()} WHERE Product_ID = {txtProductID.Text.Trim()}";
				db.ExecuteQueries(query);
				MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error updating product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show(db.message, db.title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
				{
					string query = $"UPDATE tblProduct SET deleted = 1 WHERE Product_ID = {txtProductID.Text.Trim()}";
					;
					db.ExecuteQueries(query);
					MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					btnClean_Click(sender, e);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error deleting product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnClean_Click(object sender, EventArgs e)
		{
			db.clearData(txtProductID, txtProductName, cmbCategory, txtStock, txtCost, txtPrice);
		}
	}
}