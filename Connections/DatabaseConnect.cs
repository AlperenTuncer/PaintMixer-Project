using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO.Ports;

namespace Connections
{
    public class DatabaseConnect
    {
       
        public static string conntext;
        public static SqlConnection con = new SqlConnection();
        public static DatabaseSettings databaseSettings = new DatabaseSettings();
        //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;

        public static void connect()
        {
            conntext = LoginAndDatabase.Properties.Settings.Default.ServerName;
        }

    }
}
