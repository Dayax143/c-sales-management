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
				string query = $"INSERT INTO tblProduct (Product_Name, Category, quantity, UnitCost, Price,date,barcode, deleted) VALUES ('{txtProductName.Text.Trim()}', '{cmbCategory.Text.Trim()}', {txtStock.Text.Trim()}, {txtCost.Text.Trim()}, {txtPrice.Text.Trim()},'{DateTime.Now}',{txtBarcode.Text.Trim()}, 0)"; 
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