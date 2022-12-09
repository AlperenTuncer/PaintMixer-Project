using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ErrorLog;

namespace BitirmeProjesi
{
    public partial class YoneticiPaneli : Form
    {
        public YoneticiPaneli()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        
        }
        public static bool move;
        public static int mouse_x, mouse_y;

        //Yönetici Panel Formunun içerisinde Form Açabilmek için Oluşturmuş Olduğum Method
        public void mdiForm(Form frm)
        {
            try
            {
                
                panel2.Controls.Clear();
                frm.MdiParent = this;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                panel2.Controls.Add(frm);
                frm.Show();

            }
            catch (Exception ex)
            {
                Error.errorlog(ex, Application.StartupPath);
                MessageBox.Show("Lütfen Veri Tabanı Bağlantınızı Kontrol Ediniz!");
                throw;
            }
           
        }
        private void StuffBtn_Click(object sender, EventArgs e)
        {
            label2.Text = "Personel Ayarları";
            //Basılan Butonun Enabled Özelliğini Değiştirip Diğer Butonların Enabled Özelliğini True Yapıyorum ve Methodumu Çağırıp Form içerisinde Belirtilen Formu Açıyorum
            StuffBtn.Enabled = !StuffBtn.Enabled;
            FormulaBtn.Enabled = true;
            ComponentBtn.Enabled = true;
            LogBtn.Enabled = true;
            BitirmeProjesi.StuffSettings StuffSettings = new BitirmeProjesi.StuffSettings();
            mdiForm(StuffSettings);
        }

        private void FormulaBtn_Click(object sender, EventArgs e)
        {
            label2.Text = "Formül Ayarları";
            //Basılan Butonun Enabled Özelliğini Değiştirip Diğer Butonların Enabled Özelliğini True Yapıyorum ve Methodumu Çağırıp Form içerisinde Belirtilen Formu Açıyorum
            StuffBtn.Enabled = true;
            FormulaBtn.Enabled = !FormulaBtn.Enabled;
            ComponentBtn.Enabled = true;
            LogBtn.Enabled = true;
            BitirmeProjesi.FormulaSettings FormulaSettings = new BitirmeProjesi.FormulaSettings();
            mdiForm(FormulaSettings);
        }

        private void ComponentBtn_Click(object sender, EventArgs e)
        {
            label2.Text = "Parça Ayarları";
            //Basılan Butonun Enabled Özelliğini Değiştirip Diğer Butonların Enabled Özelliğini True Yapıyorum ve Methodumu Çağırıp Form içerisinde Belirtilen Formu Açıyorum
            StuffBtn.Enabled = true;
            FormulaBtn.Enabled = true;
            ComponentBtn.Enabled = !ComponentBtn.Enabled;
            LogBtn.Enabled = true;
            BitirmeProjesi.ComponentSettings ComponentSettings = new BitirmeProjesi.ComponentSettings();
            mdiForm(ComponentSettings);
        }

        private void LogBtn_Click(object sender, EventArgs e)
        {
            label2.Text = "Log Kaydı";
            //Basılan Butonun Enabled Özelliğini Değiştirip Diğer Butonların Enabled Özelliğini True Yapıyorum ve Methodumu Çağırıp Form içerisinde Belirtilen Formu Açıyorum
            StuffBtn.Enabled = true;
            FormulaBtn.Enabled = true;
            ComponentBtn.Enabled = true;
            LogBtn.Enabled = !LogBtn.Enabled;
            BitirmeProjesi.LogForm logForm = new BitirmeProjesi.LogForm();
            mdiForm(logForm);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.UseVisualStyleBackColor = false;
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.UseVisualStyleBackColor = true;
            button1.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - (mouse_x+300), MousePosition.Y - (mouse_y + 1));
            }
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
     
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

      
    }
}
