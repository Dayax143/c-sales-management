using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace key_luxery1
{
	public partial class uPayments : UserControl
	{
		private sharedClass db = new sharedClass();

		public uPayments()
		{
			InitializeComponent();
		}

		private void uPayments_Load(object sender, EventArgs e)
		{
			LoadPaymentMethods();
			LoadPaymentsData();
		}

		public void LoadPaymentsData(string searchKeyword = "", string paymentMethod = "")
		{
			try
			{
				string query = "SELECT payment_id AS [Payment ID], invoice_id AS [Invoice ID], amount_paid AS [Amount Paid], payment_method AS [Method], reference_no AS [Reference], payment_date AS [Payment Date], Status FROM tblPayment WHERE 1=1";

				if (!string.IsNullOrEmpty(searchKeyword))
				{
					string safeKeyword = searchKeyword.Replace("'", "''");
					query += $" AND (payment_id LIKE '%{safeKeyword}%' OR invoice_id LIKE '%{safeKeyword}%')";
				}

				if (!string.IsNullOrEmpty(paymentMethod) && paymentMethod != "All Methods")
				{
					query += $" AND payment_method = '{paymentMethod.Replace("'", "''")}'";
				}

				query += " ORDER BY payment_date DESC";

				sharedClass.DisplayData(dgvPayments, query);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading payments: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LoadPaymentMethods()
		{
			try
			{
				cmbFilterMethod.Items.Clear();
				cmbFilterMethod.Items.Add("All Methods");

				DataTable dt = sharedClass.GetData("SELECT DISTINCT payment_method FROM tblPayment WHERE payment_method IS NOT NULL");
				foreach (DataRow row in dt.Rows)
				{
					if (row["payment_method"] != DBNull.Value)
					{
						cmbFilterMethod.Items.Add(row["payment_method"].ToString());
					}
				}

				if (cmbFilterMethod.Items.Count > 0)
				{
					cmbFilterMethod.SelectedIndex = 0;
				}
			}
			catch
			{
				cmbFilterMethod.Items.Add("All Methods");
				cmbFilterMethod.SelectedIndex = 0;
			}
		}

		private void txtSearchFilter_TextChanged(object sender, EventArgs e)
		{
			LoadPaymentsData(txtSearchFilter.Text.Trim(), cmbFilterMethod.SelectedItem?.ToString());
		}

		private void cmbFilterMethod_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadPaymentsData(txtSearchFilter.Text.Trim(), cmbFilterMethod.SelectedItem?.ToString());
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			txtSearchFilter.Clear();
			if (cmbFilterMethod.Items.Count > 0) cmbFilterMethod.SelectedIndex = 0;
			LoadPaymentsData();
			MessageBox.Show("Payment records refreshed.", "Refreshed", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnExport_Click(object sender, EventArgs e)
		{
			try
			{
				if (dgvPayments.Rows.Count > 0)
				{
					SaveFileDialog sfd = new SaveFileDialog();
					sfd.Filter = "CSV (*.csv)|*.csv";
					sfd.FileName = "Payment_Ledger_" + DateTime.Now.ToString("yyyyMMdd") + ".csv";

					if (sfd.ShowDialog() == DialogResult.OK)
					{
						using (StreamWriter sw = new StreamWriter(sfd.FileName))
						{
							for (int i = 0; i < dgvPayments.Columns.Count; i++)
							{
								sw.Write(dgvPayments.Columns[i].HeaderText);
								if (i < dgvPayments.Columns.Count - 1) sw.Write(",");
							}
							sw.WriteLine();

							foreach (DataGridViewRow row in dgvPayments.Rows)
							{
								if (!row.IsNewRow)
								{
									for (int i = 0; i < dgvPayments.Columns.Count; i++)
									{
										if (row.Cells[i].Value != null)
										{
											sw.Write('"' + row.Cells[i].Value.ToString().Replace("\"", "\"\"") + '"');
										}
										if (i < dgvPayments.Columns.Count - 1) sw.Write(",");
									}
									sw.WriteLine();
								}
							}
						}
						MessageBox.Show("Payment ledger exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				else
				{
					MessageBox.Show("No payment records to export.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error exporting data: " + ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dgvPayments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex >= 0)
				{
					DataGridViewRow row = dgvPayments.Rows[e.RowIndex];

					//id AS[Invoice ID], amount_paid AS[Amount Paid], payment_method AS[Method], reference_no AS[Reference],
					//	payment_date AS[Payment Date] FROM tblPayment WHERE 1 = 1";

					// Extract values from the selected row (adjust column names if needed)
					string invoiceId = row.Cells["Invoice ID"].Value.ToString();
					string grandTotal = row.Cells["Amount Paid"].Value.ToString();
					string reference = row.Cells["Reference"].Value.ToString();
					string paymentMethod = row.Cells["method"].Value.ToString();
					

					// Pass the 3 required string arguments matching your constructor
					frmManagePayment manageForm = new frmManagePayment(invoiceId, grandTotal, reference);

					if (manageForm.ShowDialog() == DialogResult.OK)
					{
						manageForm.txtAmountPaid.Text = grandTotal;
						manageForm.cmbPaymentMethod.Text = paymentMethod;

						// Refresh your payments grid here if necessary
						 //LoadPaymentsData();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}