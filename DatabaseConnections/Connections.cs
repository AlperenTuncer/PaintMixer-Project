using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Data.SqlClient;

namespace DatabaseConnections
{
    public class Connections
    {
        public static string conntext;
        public static SerialPort sport = new SerialPort();
        public static void connect(string srname,string user, string pass) 
        {
            SqlConnectionStringBuilder conn = new SqlConnectionStringBuilder();
            conn.InitialCatalog = "paintmixer";
            conn.DataSource = srname;
            conn.UserID = user;
            conn.Password = pass;
            conntext = conn.ToString();
        }
        public static void comconnect(string portname,int baudrate,int databits,string stopbits,string parity)
        {
            sport.PortName = portname; //Properties.Settings.Default.Name;
            sport.BaudRate = baudrate;//Properties.Settings.Default.BaudRate; ;
            sport.DataBits = databits;//Properties.Settings.Default.DataBits;
            sport.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stopbits); //(StopBits)Enum.Parse(typeof(StopBits), Properties.Settings.Default.StopBits);
            sport.Parity = (Parity)Enum.Parse(typeof(Parity), parity);//(Parity)Enum.Parse(typeof(Parity), Properties.Settings.Default.Paritiy);
        }
        public static string Controls(string connectionstrings)
        {
            string connectinstring = connectionstrings;
            return connectinstring;

        }
    }
}
