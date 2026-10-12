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
				string query = @"SELECT invoice_id AS [ID], 
                                        invoice_no AS [Invoice No], 
                                        customer_name AS [Customer Name], 
                                        invoice_date AS [Date], 
                                        due_date AS [Due Date],
                                        subtotal AS [Subtotal ($)], 
                                        discount AS [Discount ($)], 
                                        tax AS [Tax ($)], 
                                        grand_total AS [Grand Total ($)], 
                                        total_profit AS [Profit ($)], 
                                        status AS [Status] 
                                 FROM tblInvoice WHERE (deleted = 0 OR deleted IS NULL)  and status != 'Draft' and status !='Canceled'
                                 ORDER BY invoice_id DESC";

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
				string query = $@"SELECT invoice_id AS [ID], 
                                        invoice_no AS [Invoice No], 
                                        c.customer_name AS [Customer Name], 
                                        invoice_date AS [Date], 
                                        due_date AS [Due Date],
                                        subtotal AS [Subtotal ($)], 
                                        discount AS [Discount ($)], 
                                        tax AS [Tax ($)], 
                                        grand_total AS [Grand Total ($)], 
                                        total_profit AS [Profit ($)], 
                                        status AS [Status] 
                                 FROM tblInvoice WHERE (deleted = 0 OR deleted IS NULL) 
                                   AND (status != 'Draft' and status !='Canceled')
                                   AND invoice_no LIKE '%{keyword}%'
                                 ORDER BY invoice_id DESC";

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