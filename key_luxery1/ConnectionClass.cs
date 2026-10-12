using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace key_luxery1
{
    public class ConnectionClass
    {

        // //manual enter the connection parameters
        //public void configureConnection(string connectionString)
        //{
        //    try
        //    {
        //        string newconnectionString = $"Server={server};Database={database};User Id={username};Password={password};";
        //        SaveConnectionString(newconnectionString);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}


        // save the new connection
        public void SaveConnectionString(string savedConnectionString)
        {
            try
            {
                Properties.Settings.Default.SqlConnectionString = savedConnectionString;
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
