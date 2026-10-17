using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace key_luxery1
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frmSplash());

		//	// Check if connection works
		//	if (IsConnectionValid())
		//	{
		//		// TODO: Replace 'frmMain' with your actual main application form name
		//		Application.Run(new frmDashboard());
		//	}
		//	else
		//	{
		//		Application.Run(new frmConfig());
		//	}
		//}

		//private static bool IsConnectionValid()
		//{
		//	try
		//	{
		//		using (var conn = sharedClass.GetConnection())
		//		{
		//			conn.Open();
		//			return true; // Connection successful
		//		}
		//	}
		//	catch
		//	{
		//		return false; // Connection failed, redirect to config
		//	}
		}
	}
}