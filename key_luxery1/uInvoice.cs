using System;
using System.Data;
using System.Windows.Forms;

namespace key_luxery1
{
	public partial class uInvoice : UserControl
	{
		sharedClass db = new sharedClass();

		public uInvoice()
		{
			InitializeComponent();
		}

		private void uInvoice_Load(object sender, EventArgs e)
		{
			LoadInvoiceData();
		}

		public void LoadInvoiceData()
		{
			try
			{
				string query = @"SELECT i.invoice_id AS [ID], 
                                        i.invoice_no AS [Invoice No], 
                                        c.customer_name AS [Customer Name], 
                                        i.invoice_date AS [Date], 
                                        i.due_date AS [Due Date],
                                        i.subtotal AS [Subtotal ($)], 
                                        i.discount AS [Discount ($)], 
                                        i.tax AS [Tax ($)], 
                                        i.grand_total AS [Grand Total ($)], 
                                        i.total_profit AS [Profit ($)], 
                                        i.status AS [Status] 
                                 FROM tblInvoice i
                                 LEFT JOIN tblCustomer c ON i.customer_id = c.customer_id
                                 WHERE (i.deleted = 0 OR i.deleted IS NULL) AND i.status != 'Draft'
                                 ORDER BY i.invoice_id DESC";

				DataTable dt = sharedClass.GetData(query);
				dgvInvoices.DataSource = dt;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading invoices: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtSearchInvoice_TextChanged(object sender, EventArgs e)
		{
			string keyword = txtSearchInvoice.Text.Trim();
			try
			{
				string query = $@"SELECT i.invoice_id AS [ID], 
                                        i.invoice_no AS [Invoice No], 
                                        c.customer_name AS [Customer Name], 
                                        i.invoice_date AS [Date], 
                                        i.due_date AS [Due Date],
                                        i.subtotal AS [Subtotal ($)], 
                                        i.discount AS [Discount ($)], 
                                        i.tax AS [Tax ($)], 
                                        i.grand_total AS [Grand Total ($)], 
                                        i.total_profit AS [Profit ($)], 
                                        i.status AS [Status] 
                                 FROM tblInvoice i
                                 LEFT JOIN tblCustomer c ON i.customer_id = c.customer_id
                                 WHERE (i.deleted = 0 OR i.deleted IS NULL) 
                                   AND i.status != 'Draft' 
                                   AND i.invoice_no LIKE '%{keyword}%'
                                 ORDER BY i.invoice_id DESC";

				DataTable dt = sharedClass.GetData(query);
				dgvInvoices.DataSource = dt;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching invoices: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			txtSearchInvoice.Clear();
			LoadInvoiceData();
		}

		// --- DOUBLE-CLICK INVOICE TO OPEN PAYMENT FORM ---
		private void dgvInvoices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dgvInvoices.Rows[e.RowIndex];

				string invoiceId = row.Cells["ID"].Value.ToString();
				string invoiceNo = row.Cells["Invoice No"].Value.ToString();
				string grandTotal = row.Cells["Grand Total ($)"].Value.ToString();

				// Open the payment form and pass the selected invoice info
				frmManagePayment paymentForm = new frmManagePayment(invoiceId, invoiceNo, grandTotal);
				paymentForm.ShowDialog();

				// Refresh the invoice list after recording payment
				LoadInvoiceData();
			}
		}

		private void btnManageInvoice_Click(object sender, EventArgs e)
		{
			frmManageInvoice frmManageInvoice = new frmManageInvoice();
			frmManageInvoice.ShowDialog(this);
		}
	}
}