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
				// Validate that customer_name is required and cannot be null/empty
				if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
				{
					MessageBox.Show("Customer Name is required.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtCustomerName.Focus();
					return;
				}

				// Format DateTime properly for SQL string queries
				string formattedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

				// customer_name is mandatory
				string nameValue = $"'{txtCustomerName.Text.Trim().Replace("'", "''")}'";

				// Optional fields: if empty, insert SQL NULL, otherwise wrap in quotes
				string phoneValue = string.IsNullOrWhiteSpace(txtPhone.Text)
					? "NULL"
					: $"'{txtPhone.Text.Trim().Replace("'", "''")}'";

				string addressValue = string.IsNullOrWhiteSpace(txtAddress.Text)
					? "NULL"
					: $"'{txtAddress.Text.Trim().Replace("'", "''")}'";

				string query = $"INSERT INTO tblCustomer (customer_name, customer_phone, customer_address, status, date, deleted) " +
							   $"VALUES ({nameValue}, {phoneValue}, {addressValue}, 'Start', '{formattedDate}', 0)";

				db.ExecuteQueries(query);
				MessageBox.Show("Customer saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btnClear_Click(sender, e);
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
			db.clearData(txtCustomerID, txtCustomerName, txtAddress, txtPhone, txtSearchPhone,cmbstatus);
			cmbstatus.ResetText();
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

				string customerId = txtCustomerID.Text.Trim();

				// Check if the customer exists and what their current delete status is
				string checkQuery = $"SELECT deleted FROM tblCustomer WHERE customer_id = {customerId}";
				DataTable dt = sharedClass.GetData(checkQuery);

				if (dt == null || dt.Rows.Count == 0)
				{
					MessageBox.Show("This customer isn't registered yet.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				int isDeleted = Convert.ToInt32(dt.Rows[0]["deleted"]);

				if (isDeleted == 1)
				{
					MessageBox.Show("Customer is deleted already.", "Already Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				// Confirm deletion if active
				DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (dialogResult == DialogResult.Yes)
				{
					string updateQuery = $"UPDATE tblCustomer SET deleted = 1 WHERE customer_id = {customerId}";
					db.ExecuteQueries(updateQuery);
					MessageBox.Show("Customer deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

					// TODO: Call your refresh grid and clear input methods here
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error deleting customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void LoadCustomers()
		{
			try
			{
				string phone = txtSearchPhone.Text.Trim();
				if (string.IsNullOrEmpty(phone))
				{
					MessageBox.Show("Please enter a customer phone number.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtSearchPhone.Focus();
					return;
				}

				// Properly assign the returned DataTable from sharedClass.GetData
				// Added single quotes around phone value and sanitized input against quotes
				string query = $"SELECT customer_id, customer_name, customer_phone,customer_address,status FROM tblCustomer WHERE deleted = 0 AND customer_phone = '{phone.Replace("'", "''")}'";
				DataTable dt = sharedClass.GetData(query);

				// Check if any records were actually returned
				if (dt != null && dt.Rows.Count > 0)
				{
					// Use Rows[0] for the first matching record (0-based index)
					txtCustomerID.Text = dt.Rows[0]["customer_id"].ToString() ?? string.Empty; // Optional: handle nulls;
					txtCustomerName.Text = dt.Rows[0]["customer_name"].ToString() ?? string.Empty; // Optional: handle nulls;
					txtPhone.Text = dt.Rows[0]["customer_phone"].ToString() ?? string.Empty; // Optional: handle nulls
					txtAddress.Text = dt.Rows[0]["customer_address"]?.ToString() ?? string.Empty; // Optional: handle nulls
					cmbstatus.Text = dt.Rows[0]["status"]?.ToString() ?? string.Empty;
				}
				else
				{
					MessageBox.Show("No active customer found with that phone number.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
					txtCustomerID.Clear();
					txtCustomerName.Clear();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading customers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnGet_Click(object sender, EventArgs e)
		{
			LoadCustomers();
		}
	}
}
