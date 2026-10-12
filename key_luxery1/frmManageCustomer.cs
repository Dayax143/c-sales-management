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
	public partial class frmManageCustomer : Form
	{
		sharedClass db = new sharedClass();
		public frmManageCustomer()
		{
			InitializeComponent();
		}
		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				// Format DateTime properly for SQL string queries
				string formattedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

				string query = $"INSERT INTO tblCustomer (customer_name, customer_phone, customer_address, status, date,deleted) " +
							   $"VALUES ('{txtCustomerName.Text.Trim()}', {txtPhone.Text.Trim()}, '{txtAddress.Text.Trim()}', 'Start', '{formattedDate}',0)";

				db.ExecuteQueries(query);
				MessageBox.Show("Customer saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btnClear_Click(sender, e);

				// Optional: clear form or reload grid here
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void btnUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(txtCustomerID.Text))
				{
					MessageBox.Show("Please select a customer to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				string query = $"UPDATE tblCustomer SET " +
							   $"customer_name = '{txtCustomerName.Text.Trim()}', " +
							   $"customer_phone = {txtPhone.Text.Trim()}, " +
							   $"customer_address = '{txtAddress.Text.Trim()}', " +
							   $"status = '{cmbstatus.Text.Trim()}' " +
							   $"WHERE customer_id = {txtCustomerID.Text}";

				db.ExecuteQueries(query);
				MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btnClear_Click(sender, e);
				// Refresh grid and clear inputs
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error updating customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			db.clearData(txtCustomerID, txtCustomerName, txtAddress, txtPhone, txtSearchPhone);
		}
		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(txtCustomerID.Text))
				{
					MessageBox.Show("Please select a customer to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (dialogResult == DialogResult.Yes)
				{
					string query = $"UPDATE tblCustomer SET " +
												   $"deleted = 1 " +
												   $"WHERE customer_id = {txtCustomerID.Text}";
					db.ExecuteQueries(query);
					MessageBox.Show("Customer deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

					// Refresh grid and clear inputs
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error deleting customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
