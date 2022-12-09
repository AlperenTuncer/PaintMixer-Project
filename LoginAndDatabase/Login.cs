using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DatabaseConnections;
using System.IO.Ports;
using cesar;
using Terazi;
using ErrorLog;

namespace LoginAndDatabase
{
    public partial class Login : Form
    {
        
        DatabaseSettings databaseSettings = new DatabaseSettings();
        SqlConnection con;
        public static bool move;
        public static int mouse_x, mouse_y;
        public Login()
        {
            InitializeComponent();
        }



        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))  //rakam giriliyor metin girilemiyor
            {
                e.Handled = true;
            }
            if (Convert.ToInt32(e.KeyChar) == 13)  //rakam giriliyor metin girilemiyor
            {
                button1_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                //girilen girdinin veri tabanında olup olmadığına bakıyor.
                con.Open();
                string sql = "Select * from users where us_id=@id";
                SqlParameter prm1 = new SqlParameter("@id", textBox1.Text.Trim());
                SqlCommand command = new SqlCommand(sql,con);
                command.Parameters.Add(prm1);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);

                if (dt.Rows.Count >0)
                {
                    DataRow[] rows = dt.Select();
                    Terazi.main mainPage = new Terazi.main(rows[0]["us_name"].ToString()+" "+ rows[0]["us_surname"].ToString(), rows[0]["us_id"].ToString(), rows[0]["us_perm"].ToString());
                
                    mainPage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Personel Numarası Yanlış.");
                }
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hatalı tuş tıklandı veya Database ayarlarında sorun var!");
                button2_Click(sender, e);
                Error.errorlog(ex, Application.StartupPath);

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            databaseSettings.Show();
            this.Hide();
        }

    

        public void Login_Shown(object sender, EventArgs e)
        {
            this.MaximizeBox = false;

            //Property'de şifrelenmiş olan girdileri çözüyorum

            if (Properties.Settings.Default.Remember !=false)
            {
                Connections.connect(cesar.cesarpass.cesardec(Properties.Settings.Default.srvname), cesar.cesarpass.cesardec(Properties.Settings.Default.user), cesar.cesarpass.cesardec(Properties.Settings.Default.pass));

            }
        
            string constr = Connections.conntext;
            
      
            if (constr != "")
            {
                button1.Enabled = true;
                try
                {
                    //dll ile connection string oluşturuluyor.
                    if (Properties.Settings.Default.Remember2 !=false)
                    {
                        Connections.comconnect(Properties.Settings.Default.Name, Properties.Settings.Default.BaudRate, Properties.Settings.Default.DataBits, Properties.Settings.Default.StopBits, Properties.Settings.Default.Paritiy);

                    }
                    
                    con = new SqlConnection(Connections.conntext);
            }
                catch (Exception ex)
            {

                    Error.errorlog(ex, Application.StartupPath); //debug içindeki textinde içine hatayı gönderiyor.
                    button1.Enabled = false;
                    MessageBox.Show("veri tabanı bağlantısı veya com ayarlarınız yanlış!");
                    button2_Click(sender, e);

                }
            }
            else
            {
            
                button1.Enabled = false;
                MessageBox.Show("Lütfen ayarlarını yapınız");
                button2_Click(sender, e);

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - (mouse_x), MousePosition.Y - (mouse_y));
            }
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            button7.UseVisualStyleBackColor = false;
            button7.BackColor = Color.Red;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.UseVisualStyleBackColor = true;
            button7.BackColor = Color.FromArgb(229, 126, 49);
        }

    }
}
