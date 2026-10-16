using System;
using System.Data;
using System.Windows.Forms;

namespace key_luxery1
{
	public partial class frmLogin : Form
	{
		private sharedClass db = new sharedClass();

		public frmLogin()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string username = TxtUser.Text.Trim();
			string password = TxtPassword.Text.Trim();


			// Open main dashboard and hide login screen
			frmDashboard dashboard = new frmDashboard();

			// Validate inputs
			if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
			{
				MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			try
			{
				// Query user record matching exact schema columns
				string query = $"SELECT userName, passWord, role, user_Status FROM tblUser WHERE userName = '{username.Replace("'", "''")}'";
				DataTable dt = sharedClass.GetData(query);

				if (dt.Rows.Count > 0)
				{
					DataRow row = dt.Rows[0];
					string dbPassword = row["passWord"]?.ToString();
					string userStatus = row["user_Status"]?.ToString();
					string role = row["role"]?.ToString();

					// Check if user status is active (supporting string "Active" or numeric/boolean flags)
					bool isActive = string.Equals(userStatus, "Active", StringComparison.OrdinalIgnoreCase) ||
									string.Equals(userStatus, "1", StringComparison.OrdinalIgnoreCase) ||
									string.Equals(userStatus, "True", StringComparison.OrdinalIgnoreCase);

					if (!isActive)
					{
						MessageBox.Show("Your account is inactive or disabled. Please contact the administrator.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}

					// Verify password
					if (dbPassword == password)
					{
						if(role=="Admin")
						{
							dashboard.PnlSidebar.Visible = true;
							dashboard.BtnSidebar.Visible = true;
						}
						else if(role!="Admin")
						{
							//dash.btnReport.Visible = false;
							//dash.pnlReport.Visible = false;
							//dash.BtnUsers.Visible = false;
							//dash.PnlUsers.Visible = false;
							dashboard.PnlSidebar.Visible = false;
							dashboard.BtnSidebar.Visible = false;
						}
						else
						{
							MessageBox.Show("Your role is not recognized. Please contact the administrator.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							return;
						}	
						MessageBox.Show($"Welcome back, {username}!\nRole: {role}", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

						dashboard.lblUsername.Text = username;
						dashboard.Show();
						this.Hide();
					}
					else
					{
						MessageBox.Show("Invalid password. Please try again.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
						TxtPassword.Clear();
						TxtPassword.Focus();
					}
				}
				else
				{
					MessageBox.Show("Username not found in the system.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
					TxtUser.Focus();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Database login error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
		{
			// If the checkbox is checked, reveal the password text; otherwise, mask it.
			if (chkShowPassword.Checked==true)
			{
				TxtPassword.UseSystemPasswordChar = false;
			}
			else
			{
				TxtPassword.UseSystemPasswordChar = true;
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
