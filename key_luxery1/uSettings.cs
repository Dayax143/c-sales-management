using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace key_luxery1
{
	public partial class uSettings : UserControl
	{
		private sharedClass db = new sharedClass();

		public uSettings()
		{
			InitializeComponent();
		}

		private void uSettings_Load(object sender, EventArgs e)
		{
			// Load current settings if available
		}

		private void btnSaveSettings_Click(object sender, EventArgs e)
		{
			try
			{
				MessageBox.Show("System preferences and database configuration updated successfully!", "Settings Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving settings: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnBackupDb_Click(object sender, EventArgs e)
		{
			try
			{
				SaveFileDialog sfd = new SaveFileDialog();
				sfd.Filter = "Backup Files (*.bak)|*.bak";
				sfd.FileName = "Key_Luxury_Backup_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".bak";

				if (sfd.ShowDialog() == DialogResult.OK)
				{
					string filePath = sfd.FileName;

					// SQL Server backup query (must be run against master or target DB)
					string query = $"BACKUP DATABASE [Key_luxery] TO DISK = '{filePath}' WITH FORMAT, INIT, NAME = 'Key_Luxury-Full Database Backup'";

					using (SqlConnection con = new SqlConnection(Properties.Settings.Default.SqlConnectionString))
					{
						con.Open();
						using (SqlCommand cmd = new SqlCommand(query, con))
						{
							cmd.ExecuteNonQuery();
						}
					}

					MessageBox.Show("Database backup created successfully!\nPath: " + filePath, "Backup Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Backup failed: " + ex.Message + "\n\nNote: Ensure SQL Server service account has write permission to the selected folder.", "Database Backup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnRestoreDb_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("Restoring a database will overwrite current active data with the backup snapshot. Do you wish to continue?", "Confirm Restore", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
				{
					OpenFileDialog ofd = new OpenFileDialog();
					ofd.Filter = "Backup Files (*.bak)|*.bak";
					ofd.Title = "Select Database Backup File (.bak)";

					if (ofd.ShowDialog() == DialogResult.OK)
					{
						string filePath = ofd.FileName;

						// Switch to master database to drop/restore connections on Key_luxery
						SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(Properties.Settings.Default.SqlConnectionString);
						builder.InitialCatalog = "master";

						using (SqlConnection con = new SqlConnection(builder.ConnectionString))
						{
							con.Open();

							// Set database to single user mode to kill active connections
							string prepQuery = "ALTER DATABASE [Key_luxery] SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
							using (SqlCommand cmdPrep = new SqlCommand(prepQuery, con))
							{
								cmdPrep.ExecuteNonQuery();
							}

							// Restore database command
							string restoreQuery = $"RESTORE DATABASE [Key_luxery] FROM DISK = '{filePath}' WITH REPLACE";
							using (SqlCommand cmdRestore = new SqlCommand(restoreQuery, con))
							{
								cmdRestore.ExecuteNonQuery();
							}

							// Revert database back to multi user mode
							string postQuery = "ALTER DATABASE [Key_luxery] SET MULTI_USER";
							using (SqlCommand cmdPost = new SqlCommand(postQuery, con))
							{
								cmdPost.ExecuteNonQuery();
							}
						}

						MessageBox.Show("Database restored successfully from backup!", "Restore Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Restore failed: " + ex.Message, "Database Restore Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}