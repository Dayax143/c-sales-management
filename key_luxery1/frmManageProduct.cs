using System;
using System.Data;
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
				btnClean_Click(sender, e);
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
			db.clearData(txtProductID, txtProductName, cmbCategory, txtStock, txtCost, txtPrice,txtBarcode,txtSearch,cmbSearchBy);
		}
		private void btnGet_Click(object sender, EventArgs e)
		{
			// Validate that a search criteria is selected
			if (cmbSearchBy.SelectedIndex == -1)
			{
				MessageBox.Show("Please select whether to search by Product Name or Barcode.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cmbSearchBy.Focus();
				return;
			}

			string searchText = txtSearch.Text.Trim();

			if (string.IsNullOrEmpty(searchText))
			{
				MessageBox.Show("Please enter a keyword to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtSearch.Focus();
				return;
			}

			string selectedCriteria = cmbSearchBy.SelectedItem.ToString();
			string query = "";

			// Build the query dynamically based on the selected dropdown option
			if (selectedCriteria == "Product Name")
			{
				query = @"SELECT product_id, product_name, category, quantity, barcode, UnitCost, price, status 
                  FROM tblProduct 
                  WHERE product_name LIKE '%" + searchText.Replace("'", "''") + "%' AND deleted = 0";
			}
			else if (selectedCriteria == "Barcode")
			{
				query = @"SELECT product_id, product_name, category, quantity, barcode, UnitCost, price, status 
                  FROM tblProduct 
                  WHERE barcode = '" + searchText.Replace("'", "''") + "' AND deleted = 0";
			}

			try
			{
				// Fetch data using your sharedClass method
				DataTable dt = sharedClass.GetData(query);

				if (dt != null && dt.Rows.Count > 0)
				{
					DataRow row = dt.Rows[0]; // Take the matched record

					// Populate form controls
					txtProductID.Text = row["product_id"].ToString();
					txtProductName.Text = row["product_name"].ToString();
					cmbCategory.Text = row["category"].ToString();
					txtStock.Text = row["quantity"].ToString();
					txtBarcode.Text = row["barcode"].ToString();
					txtCost.Text = row["UnitCost"].ToString();
					txtPrice.Text = row["price"].ToString();
				}
				else
				{
					MessageBox.Show($"No active product found matching that {selectedCriteria.ToLower()}.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ClearFields();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error searching for product: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ClearFields()
		{
			txtProductID.Clear();
			txtProductName.Clear();
			cmbCategory.SelectedIndex = -1;
			txtStock.Clear();
			txtBarcode.Clear();
			txtCost.Clear();
			txtPrice.Clear();
			txtSearch.Clear();
			txtSearch.Focus();
		}



	}
}