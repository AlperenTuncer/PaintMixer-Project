using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO.Ports;
using System.Threading;
using System.Globalization;
using System.IO;
using DatabaseConnections;

namespace ScaleProcess
{
    public partial class ScaleProcess : Form
    {
        string currentusername;
        string currentuserid;
        string currentperm;
        public ScaleProcess(string us_name,string us_id,string us_perm)
        {
            InitializeComponent();
            currentusername = us_name;
            currentuserid = us_id;
            currentperm = us_perm;  
        }
        SqlConnection Conn = new SqlConnection(Connections.conntext);
        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CurrentUserNameLabel.Text = currentusername;
            if (currentperm == "True")
            {
                // Ayarlar Enabled True
            }
            else
            {
                // Ayarlar Enabled False
            }

        }

    }
}
