using System;
using System.Windows.Forms;

namespace key_luxery1
{
	public partial class frmDashboard : Form
	{
		public frmDashboard()
		{
			InitializeComponent();
		}

		private void frmDashboard_Load(object sender, EventArgs e)
		{
			// Set current date on load
			lblDate.Text = "Date: " + DateTime.Now.ToString("dd MMM yyyy");

			// Default view to home/dashboard
			ShowControl(uHome1);
			HideAllIndicators();
			PnlDashboard.Visible = true;
		}

		private void ShowControl(Control control)
		{
			// Hide all user controls
			uHome1.Visible = false;
			uSales1.Visible = false;
			uProducts1.Visible = false;
			uPayments1.Visible = false;
			uCustomer1.Visible = false;
			uManageUsers1.Visible = false;
			uSettings1.Visible = false;
			uAbout1.Visible = false;
			uInvoice1.Visible = false;

			// Show selected control & bring to front
			control.Visible = true;
			control.BringToFront();
		}

		private void HideAllIndicators()
		{
			// Sidebar indicators
			PnlDashboard.Visible = false;
			PnlUsers.Visible = false;
			PnlSetting.Visible = false;
			pnlReport.Visible = false;
			PnlAbout.Visible = false;
			pnlProducts.Visible = false;

			// Top menu indicators
			pnlSale.Visible = false;
			pnlInvoice.Visible = false;
			pnlPayment.Visible = false;
			pnlInvoice.Visible = false;
		}

		private void BtnDashboard_Click(object sender, EventArgs e)
		{
			HideAllIndicators();
			PnlDashboard.Visible = true;
			ShowControl(uHome1);
		}

		private void BtnUsers_Click(object sender, EventArgs e)
		{
			HideAllIndicators();
			PnlUsers.Visible = true;
			ShowControl(uManageUsers1);
		}

		private void BtnSetting_Click(object sender, EventArgs e)
		{
			HideAllIndicators();
			PnlSetting.Visible = true;
			ShowControl(uSettings1);
		}

		private void btnReport_Click(object sender, EventArgs e)
		{
			HideAllIndicators();
			pnlReport.Visible = true;
			//ShowControl(uReport1);
			frmReport report = new frmReport();
			report.ShowDialog();
		}

		private void BtnAbout_Click(object sender, EventArgs e)
		{
			HideAllIndicators();
			PnlAbout.Visible = true;
			ShowControl(uAbout1);
		}

		private void btnLora_Click(object sender, EventArgs e) // Sales button
		{
			HideAllIndicators();
			pnlSale.Visible = true;
			ShowControl(uSales1);
		}

		private void btnPlates_Click(object sender, EventArgs e) // Products button
		{
			HideAllIndicators();
			pnlInvoice.Visible = true;
			ShowControl(uProducts1);
		}

		private void btnPayments_Click(object sender, EventArgs e)
		{
			HideAllIndicators();
			pnlPayment.Visible = true;
			ShowControl(uPayments1);
		}

		private void btnCustomer_Click(object sender, EventArgs e)
		{
			HideAllIndicators();
			ShowControl(uCustomer1);
			pnlInvoice.Visible = true;
			ShowControl(uInvoice1);
		}

		private void BtnSidebar_Click(object sender, EventArgs e)
		{
			// Expand/Collapse Sidebar Toggle functionality
			if (PnlSidebar.Width > 60)
			{
				PnlSidebar.Width = 60;
			}
			else
			{
				PnlSidebar.Width = 203;
			}
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				this.Hide();
				// frmLogin login = new frmLogin();
				// login.Show();
				this.Close();
			}
		}
	}
}