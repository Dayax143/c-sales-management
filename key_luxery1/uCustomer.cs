using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace key_luxery1
{
	public partial class uCustomer : UserControl
	{
		private sharedClass db = new sharedClass();

		public uCustomer()
		{
			InitializeComponent();
		}

		private void uCustomers_Load(object sender, EventArgs e)
		{
			LoadCustomersData();
		}

		/// <summary>
		/// Loads or filters customer records from tblCustomer into the grid using sharedClass.DisplayData.
		/// </summary>
		public void LoadCustomersData(string searchKeyword = "")
		{
			try
			{
				string query = "SELECT customer_id AS [Customer ID], customer_name AS [Client Name], customer_phone AS [Phone Number], customer_address AS [Address], status AS [Status], date AS [Registration Date] FROM tblCustomer WHERE deleted=0";

				if (!string.IsNullOrEmpty(searchKeyword))
				{
					string safeKeyword = searchKeyword.Replace("'", "''");
					query += $" AND (customer_name LIKE '%{safeKeyword}%' OR customer_id LIKE '%{safeKeyword}%' OR CAST(customer_phone AS VARCHAR) LIKE '%{safeKeyword}%' OR customer_address LIKE '%{safeKeyword}%' OR status LIKE '%{safeKeyword}%')";
				}

				query += " ORDER BY date DESC";

				// Uses your sharedClass DisplayData method directly
				sharedClass.DisplayData(dgvCustomers, query);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading customer data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtSearchFilter_TextChanged(object sender, EventArgs e)
		{
			LoadCustomersData(txtSearchFilter.Text.Trim());
		}

		private void btnAddCustomer_Click(object sender, EventArgs e)
		{
			frmManageCustomer customer = new frmManageCustomer();
			customer.ShowDialog();
		}

		private void btnManageCustomer_Click(object sender, EventArgs e)
		{
			frmManageCustomer customer = new frmManageCustomer();
			customer.ShowDialog();
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			txtSearchFilter.Clear();
			LoadCustomersData();
			MessageBox.Show("Customer list refreshed.", "Refreshed", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnExport_Click(object sender, EventArgs e)
		{
			try
			{
				if (dgvCustomers.Rows.Count > 0)
				{
					SaveFileDialog sfd = new SaveFileDialog();
					sfd.Filter = "CSV (*.csv)|*.csv";
					sfd.FileName = "Customer_Directory_" + DateTime.Now.ToString("yyyyMMdd") + ".csv";

					if (sfd.ShowDialog() == DialogResult.OK)
					{
						using (StreamWriter sw = new StreamWriter(sfd.FileName))
						{
							for (int i = 0; i < dgvCustomers.Columns.Count; i++)
							{
								sw.Write(dgvCustomers.Columns[i].HeaderText);
								if (i < dgvCustomers.Columns.Count - 1) sw.Write(",");
							}
							sw.WriteLine();

							foreach (DataGridViewRow row in dgvCustomers.Rows)
							{
								if (!row.IsNewRow)
								{
									for (int i = 0; i < dgvCustomers.Columns.Count; i++)
									{
										if (row.Cells[i].Value != null)
										{
											sw.Write('"' + row.Cells[i].Value.ToString().Replace("\"", "\"\"") + '"');
										}
										if (i < dgvCustomers.Columns.Count - 1) sw.Write(",");
									}
									sw.WriteLine();
								}
							}
						}
						MessageBox.Show("Customer directory exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				else
				{
					MessageBox.Show("No customer records to export.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error exporting data: " + ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}