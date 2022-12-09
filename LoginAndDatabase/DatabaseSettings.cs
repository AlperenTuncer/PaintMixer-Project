using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using ErrorLog;


namespace LoginAndDatabase
{

   
    public partial class DatabaseSettings : Form
    {
        public static bool move;
        public static int mouse_x, mouse_y;

        public DatabaseSettings()
        {
            InitializeComponent();
            InitDataForCom();            //daha önceden propertyde bir veri varsa direkt olarak textboxları getirmesi için yazıldı

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
           
        }
        private void InitDataForCom()
        {
            //verileri comboboxlara getirmek için kullanıyorum Name boş ise getirmiyor gelicek coma göre yaptırıyorum. yani com gelmez ise kaydetmiyor gelicek coma göre ayarlarını
            //yapmasını istiyorum kısacası.
            if (Properties.Settings.Default.Name!=string.Empty)
            {
                if (Properties.Settings.Default.Remember2==true)
                {
                    comboBox1.Text = Properties.Settings.Default.Name;
                    comboBox2.Text = Properties.Settings.Default.BaudRate.ToString();
                    comboBox3.Text = Properties.Settings.Default.DataBits.ToString();
                    comboBox4.Text = Properties.Settings.Default.Paritiy;
                    comboBox5.Text = Properties.Settings.Default.StopBits;
                    checkBox2.Checked = true;                  
                }
                else
                {
                    comboBox1.Text = Properties.Settings.Default.Name;
                }
            }


        }
        private void SaveDataForCom()
        {
            //verileri beni hatırla seçeneği işaretli ise propertieslere kaydettiriyorum. com için
            try
            {
                if (checkBox2.Checked)
                {
                    int cmbx3 = Convert.ToInt32(comboBox3.Text);
                    int cmbx2 = Convert.ToInt32(comboBox2.Text);

                    Properties.Settings.Default.Name = comboBox1.Text;
                    Properties.Settings.Default.BaudRate = cmbx2;            
                    Properties.Settings.Default.DataBits = cmbx3;
                    Properties.Settings.Default.Paritiy = comboBox4.Text;
                    Properties.Settings.Default.StopBits = comboBox5.Text;
                    Properties.Settings.Default.Remember2 = true;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Name = "";
                    Properties.Settings.Default.BaudRate = -1;
                    Properties.Settings.Default.DataBits = -1;
                    Properties.Settings.Default.Paritiy = "";
                    Properties.Settings.Default.StopBits = "";

                    Properties.Settings.Default.Remember2 = false;
                    Properties.Settings.Default.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen tüm değerleri doldurunuz!");
                Error.errorlog(ex, Application.StartupPath);
            }
            

        }
     
        private void SaveData()
        { //verileri beni hatırla seçeneği işaretli ise propertieslere kaydettiriyorum. sql ayarları için 
            if (checkBox1.Checked)
            {
                //cesar şifreleme metodu ile kaydediyorum.
                //textboxlar boş oluyor.properties şifreli oluyor böyle bir koruma yapıyorum.
                Properties.Settings.Default.srvname = cesar.cesarpass.cesar(textBox1.Text);
                Properties.Settings.Default.user =cesar.cesarpass.cesar(textBox2.Text);
                Properties.Settings.Default.pass = cesar.cesarpass.cesar(textBox3.Text);
                Properties.Settings.Default.Remember = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Remember = false;
                Properties.Settings.Default.Save();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SaveData();
                DatabaseConnections.Connections.connect(textBox1.Text,textBox2.Text,textBox3.Text);
                MessageBox.Show("Girdiler kaydedildi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Girdiler kaydedilmedi!");
                Error.errorlog(ex, Application.StartupPath);
                return;//button2 den çıkartıyorum
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            string[] coms = SerialPort.GetPortNames();
            foreach (string prt in coms)
            {
                comboBox1.Items.Add(prt);//takılan portu comboboxa getirtiyorum yenile butonu ile 
                //ama veri alış verişi yapabileceğim bir şey olması lazım örneğin mouse takınca orada gözükmüyor.
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //string portname,int baudrate,int databits,string stopbits,string parity
            try
            {
                SaveDataForCom();
                DatabaseConnections.Connections.comconnect(comboBox1.Text,Convert.ToInt32(comboBox2.Text),Convert.ToInt32(comboBox3.Text), comboBox5.Text, comboBox4.Text);
                InitDataForCom();
                MessageBox.Show("Girdiler kaydedildi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Girdiler kaydedilmedi!");
                Error.errorlog(ex, Application.StartupPath);
                return;//buton4 den çıkartıyorum.

            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
    }
    }

