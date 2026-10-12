using System;
using System.Data;
using System.Windows.Forms;

namespace key_luxery1
{
	public partial class uManageUsers : UserControl
	{
		private sharedClass db = new sharedClass();

		public uManageUsers()
		{
			InitializeComponent();
		}

		private void uManageUsers_Load(object sender, EventArgs e)
		{
			LoadUsersData();
		}

		public void LoadUsersData(string searchKeyword = "")
		{
			try
			{
				// Assuming tblUser / tblManageUsers schema
				string query = "SELECT user_id AS [User ID], username AS [Username], role AS [Role], User_status AS [Status], date AS [Created Date] FROM tblUser WHERE 1=1";

				if (!string.IsNullOrEmpty(searchKeyword))
				{
					string safeKeyword = searchKeyword.Replace("'", "''");
					query += $" AND (username LIKE '%{safeKeyword}%' OR role LIKE '%{safeKeyword}%' OR user_status LIKE '%{safeKeyword}%')";
				}

				query += " ORDER BY date DESC";

				sharedClass.DisplayData(dgvUsers, query);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading system users: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtSearchFilter_TextChanged(object sender, EventArgs e)
		{
			LoadUsersData(txtSearchFilter.Text.Trim());
		}

		private void btnAddUser_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Open Add User dialog / form here.", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);
			LoadUsersData();
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			txtSearchFilter.Clear();
			LoadUsersData();
			MessageBox.Show("User list refreshed.", "Refreshed", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}