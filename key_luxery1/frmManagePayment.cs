using System;
using System.Data;
using System.Windows.Forms;

namespace key_luxery1
{
	public partial class frmManagePayment : Form
	{
		sharedClass db = new sharedClass();
		private string targetInvoiceId = "";
		private string targetCustomerSql = "NULL";

		// Constructor accepting invoice parameters from double-click
		public frmManagePayment(string invoiceId, string invoiceNo, string grandTotal)
		{
			InitializeComponent();
			targetInvoiceId = invoiceId;
			txtInvoiceNo.Text = invoiceNo;
			txtTotalDue.Text = grandTotal;
			txtAmountPaid.Text = grandTotal; // Default to full payment
		}

		public frmManagePayment()
		{
			InitializeComponent();
		}

		private void frmManagePayment_Load(object sender, EventArgs e)
		{
			LoadInvoiceAndCustomerDetails();
		}

		private void LoadInvoiceAndCustomerDetails()
		{
			try
			{
				string query = $"SELECT customer_id FROM tblInvoice WHERE invoice_id = {targetInvoiceId}";
				DataTable dt = sharedClass.GetData(query);

				if (dt.Rows.Count > 0 && dt.Rows[0]["customer_id"] != DBNull.Value)
				{
					targetCustomerSql = dt.Rows[0]["customer_id"].ToString();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error fetching customer context: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// --- SAVE PAYMENT TO tblPayment TABLE ---
		private void btnSavePayment_Click(object sender, EventArgs e)
		{
			if (!decimal.TryParse(txtAmountPaid.Text.Trim(), out decimal amountPaid) || amountPaid <= 0)
			{
				MessageBox.Show("Please enter a valid payment amount.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (string.IsNullOrEmpty(cmbPaymentMethod.Text))
			{
				MessageBox.Show("Please select a payment method.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				string paymentDate = dtpPaymentDate.Value.ToString("yyyy-MM-dd HH:mm:ss");
				string paymentMethod = cmbPaymentMethod.Text.Trim();

				// 1. Insert into tblPayment table
				string insertPaymentQuery = $"INSERT INTO tblPayment (invoice_id, amount_paid, payment_date, payment_method) " +
											$"VALUES ({targetInvoiceId}, {amountPaid}, '{paymentDate}', '{paymentMethod}')";
				db.ExecuteQueries(insertPaymentQuery);

				// 2. Update Invoice status or paid amount if required
				string updateInvoiceQuery = $"UPDATE tblInvoice SET status = 'Paid' WHERE invoice_id = {targetInvoiceId}";
				db.ExecuteQueries(updateInvoiceQuery);

				MessageBox.Show("Payment saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving payment: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}