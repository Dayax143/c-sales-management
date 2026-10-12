using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace key_luxery1
{
	public class sharedClass
	{
		// Properties kept to maintain class state
		public string query;
		public DialogResult confirm;
		public string message = "Are you sure you want to delete this record";
		public string title = "Confirmation dialog";

		// Get the connection string from your project settings
		public static SqlConnection GetConnection()
		{
			return new SqlConnection(Properties.Settings.Default.SqlConnectionString);
		}

		// Method for executing non-query commands (INSERT, UPDATE, DELETE)
		public void ExecuteQueries(string _query)
		{
			try
			{
				using (SqlConnection con = GetConnection())
				{
					con.Open();
					SqlCommand cmd = new SqlCommand(_query, con);
					cmd.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Consolidated method to display data in a DataGridView
		public static void DisplayData(DataGridView dgv, string _query)
		{
			try
			{
				using (SqlDataAdapter adapter = new SqlDataAdapter(_query, GetConnection()))
				{
					DataTable virtualTable = new DataTable();
					adapter.Fill(virtualTable);
					dgv.DataSource = virtualTable;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Added feature: Returns a DataTable for dropdown data binding (e.g., Customers, Products)
		public static DataTable GetData(string _query)
		{
			DataTable dt = new DataTable();
			try
			{
				using (SqlConnection con = GetConnection())
				{
					using (SqlDataAdapter adapter = new SqlDataAdapter(_query, con))
					{
						adapter.Fill(dt);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			return dt;
		}

		// Execute scalar queries (e.g., COUNT, SUM)
		public object ExecuteScalarQuery(string _query)
		{
			try
			{
				using (SqlConnection con = GetConnection())
				{
					con.Open();
					SqlCommand cmd = new SqlCommand(_query, con);
					return cmd.ExecuteScalar();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return null;
			}
		}

		// Clear simple input controls
		public void clearData(params Control[] controls)
		{
			try
			{
				foreach (Control control in controls)
				{
					if (control is TextBox textBox)
					{
						textBox.Clear();
					}
					else if (control is ComboBox comboBox)
					{
						comboBox.SelectedIndex = -1;
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