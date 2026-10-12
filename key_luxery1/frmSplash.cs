using System;
using System.Drawing;
using System.Windows.Forms;

namespace key_luxery1
{
	public partial class frmSplash : Form
	{
		private int loadCounter = 0;

		public frmSplash()
		{
			InitializeComponent();
		}

		private void timerSplash_Tick(object sender, EventArgs e)
		{
			loadCounter += 2; // Speed of progress bar loading
			progressBarLoading.Value = loadCounter;

			// Dynamically update status text based on progress stages
			if (loadCounter < 30)
			{
				lblLoadingStatus.Text = "Connecting to database...";
			}
			else if (loadCounter < 65)
			{
				lblLoadingStatus.Text = "Loading products & inventory...";
			}
			else if (loadCounter < 90)
			{
				lblLoadingStatus.Text = "Preparing user session...";
			}
			else
			{
				lblLoadingStatus.Text = "Launching Key Luxury...";
			}

			// Once the progress bar reaches 100%
			if (loadCounter >= 100)
			{
				timerSplash.Stop();

				// Hide splash screen and open the dashboard/login form
				this.Hide();

				// Check if connection works
				if (IsConnectionValid())
				{
					// TODO: Replace 'frmMain' with your actual main application form name
					frmLogin login = new frmLogin();
					login.Show();
				}
				else
				{
					frmConfig config = new frmConfig();
					config.Show();
				}
			}
		}
		private static bool IsConnectionValid()
		{
			try
			{
				using (var conn = sharedClass.GetConnection())
				{
					conn.Open();
					return true; // Connection successful
				}
			}
			catch
			{
				return false; // Connection failed, redirect to config
			}
		}
	}
}
