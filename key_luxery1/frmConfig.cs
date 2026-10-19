using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace key_luxery1
{
    public partial class frmConfig : Form
    {
        // Use a manager class to handle connection logic, separating concerns.
        ConnectionClass _connectionManager = new ConnectionClass();

        public frmConfig()
        {
            InitializeComponent();
            //_connectionManager = new ConnectionClass();
        }

        // --- Event Handlers ---

        /// <summary>
        /// Handles the button click to save the database configuration.
        /// </summary>
        private void btnConfigure_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve user input from the text boxes.
                string server = TxtServer.Text;
                string database = TxtDB.Text;
                string username = TxtUser.Text;
                string password = TxtPassword.Text;

                // Call the ConnectionManager to save the connection string.
                _connectionManager.SaveConnectionString($"Data source={server}; database={database}; user id={username}; password={password};");

                MessageBox.Show("Configuration saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset the connection test label to its initial state.
                lblConTest.Text = "Waiting to test the Connection";
                lblConTest.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save configuration: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool TestConnectionAsync()
        {
            try
            {
                // Create a new SqlConnection using the saved connection string.
                using (SqlConnection con = new SqlConnection(Properties.Settings.Default.SqlConnectionString))
                {
                    con.Open(); // Open the connection asynchronously.
                    return true; // Connection successful.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Connection failed.
            }
        }

        /// <summary>
        /// Handles the button click to test the database connection.
        /// </summary>
        private void btnTest_Click(object sender, EventArgs e)
        {
            // Update the UI to show a test is in progress.
            lblConTest.Text = "Testing connection...";
            lblConTest.ForeColor = Color.DarkOrange;

            // Use an async method to prevent the UI from freezing.
            bool isConnected = TestConnectionAsync();

            if (isConnected)
            {
                MessageBox.Show("Connection successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                lblConTest.Text = "Connection successful!";
                lblConTest.ForeColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Connection failed! Please check your settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblConTest.Text = "Connection failed!";
                lblConTest.ForeColor = Color.Red;
            }
        }

		private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
		{
			// Toggle password character visibility
			if (chkShowPassword.Checked)
			{
				TxtPassword.PasswordChar = '\0'; // Show plain text
			}
			else
			{
				TxtPassword.PasswordChar = '●'; // Mask password
			}
		}

		/// <summary>
		/// Closes the current form and opens the login form.
		/// </summary>
		private void btnDone_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin loginForm = new frmLogin();
            loginForm.ShowDialog();
        }
    }
}
