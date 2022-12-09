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
using Excel = Microsoft.Office.Interop.Excel;
using System.Globalization;
using System.IO;
using DatabaseConnections;
using ErrorLog;
using Microsoft.VisualBasic;


namespace Terazi
{
    public partial class main : Form
    {
        public static bool move;
        public static int mouse_x, mouse_y;
        string CurrentUserName;
        string CurrentUserID;
        string CurrentUserPerm;
        public main(string us_name,string us_id,string us_perm)
        {
            InitializeComponent();
            CurrentUserName = us_name;
            CurrentUserID = us_id;
            CurrentUserPerm = us_perm;
        }
        SqlConnection Conn = new SqlConnection(Connections.conntext);
        DataTable dt = new DataTable();
        DataTable filmatdt = new DataTable();
        Thread oku;
        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
            oku.Abort();
            }
            catch (Exception ex)
            {
                Error.errorlog(ex, Application.StartupPath); ;
            }
            Application.Exit();
        }

        public void main_Load(object sender, EventArgs e)
        {
            label1.Text = CurrentUserName;
            current.BackColor = pictureBox1.BackColor;
            CheckForIllegalCrossThreadCalls = false;
            oku = new Thread(new ThreadStart(portislem));
            contin = true;
            stages = 0;
            filmatdt.Clear();
            DataTable ptypedt = new DataTable();
            Conn.Open();
            SqlDataAdapter filmat = new SqlDataAdapter("Select * From materials", Conn);
            SqlDataAdapter ptype = new SqlDataAdapter("Select * From type", Conn);
            ptype.Fill(ptypedt);
            
            filmat.Fill(filmatdt);
            Conn.Close();
            DataRow[] matrows = filmatdt.Select();
            DataRow[] tyrows = ptypedt.Select();
            matbox.DisplayMember = "Text";
            matbox.ValueMember = "Value";
            ptypebox.DisplayMember = "Text";
            ptypebox.ValueMember = "Value";
            pstagebox.DisplayMember = "Text";
            pstagebox.ValueMember = "Value";
            for (int x = 1; x <= filmatdt.Rows.Count; x++)
            {
                matbox.Items.Add(new { Text = matrows[x - 1]["material"].ToString() + " - " + matrows[x - 1]["s_text"].ToString(), Value = matrows[x - 1]["material"].ToString() });
            }
            for (int z = 1; z <= ptypedt.Rows.Count; z++)
            {
                ptypebox.Items.Add(new { Text = tyrows[z - 1]["ty_text"].ToString() , Value = tyrows[z - 1]["ty_id"].ToString() });
            }
            if (CurrentUserPerm != "True")
            {
                portcontrol();
            }

            
        }
        int stages = 0;
        Boolean isfirst = false;
        Boolean contin;
        [Obsolete]
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

       
        [Obsolete]
        public void button2_Click(object sender, EventArgs e)
        {
            var ci = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            ci.NumberFormat.NumberDecimalSeparator = ".";
            try
            {
            oku.Suspend();
            }
            catch (Exception ex)
            {
                Error.errorlog(ex, Application.StartupPath);
            }
            if (stages <= 3)
            {
                try
                {
                sport.Close();
                }
                catch (Exception ex)
                {
                    Error.errorlog(ex, Application.StartupPath);
                }
                if (stages == 0)
                {
                    daratxt.Text = current.Text;
                }
                if (stages == 1)
                {
                    nowa.Text = current.Text;
                }
                if (stages == 2)
                {
                    nowb.Text = current.Text;
                }
                if (stages == 3)
                {
                    nowc.Text = current.Text;
                    button2.Text = "Tamamlandı.";
                }
                try
                {
                sport.Open();
                }
                catch (Exception ex)
                {
                    Error.errorlog(ex, Application.StartupPath);
                }
                finally
                {
                    if (!sport.IsOpen)
                    {
                        try
                        {
                            sport.Open();
                        }
                        catch(Exception ex)
                        {
                            Error.errorlog(ex, Application.StartupPath);

                        }
                    }
                }
                try
                {
                sport.WriteLine("Z");
                sport.Close();
                }
                catch (Exception ex)
                {
                    Error.errorlog(ex, Application.StartupPath);
                }
                try
                {
                oku.Resume();
                sport.Open();
                }
                catch (Exception ex)
                {
                    Error.errorlog(ex, Application.StartupPath);
                }
                stages += 1;
                stagestr();
            }
            else
            {
                try
                {
                sport.Close();
                sport.Open();
                sport.WriteLine("Z");
                sport.Close();
                }
                catch (Exception ex)
                {
                    Error.errorlog(ex, Application.StartupPath);
                }
                // Total çıkartma
                nowtot.Text = ( float.Parse(nowa.Text,ci) + float.Parse(nowb.Text,ci) + float.Parse(nowc.Text,ci) ).ToString();
                // Log kaydı kısmı : 

                DateTime tarih = DateTime.Now;
                string tarihsql = tarih.Date.ToString("yyyy-MM-dd HH:mm:ss");
                int issuccess;
                if (stages == 5)
                {
                    issuccess = 0;
                }
                else
                {
                    issuccess = 1;
                }
                string log_kaydi = "Insert Into log Values('"+tarihsql+"','"+CurrentUserID+"','"+selectedmat+"','"+ ((paintbox.SelectedItem as dynamic).Value).ToString() + "','"+prdordertxt.Text+"'," + Int16.Parse((ptypebox.SelectedItem as dynamic).Value) + "," + Int16.Parse((pstagebox.SelectedItem as dynamic).Value) + ",'"+ calca.Text + "','" + calcb.Text + "','" + calcc.Text + "','" + calctot.Text + "','" + nowa.Text + "','" + nowb.Text + "','" + nowc.Text + "','" + nowtot.Text + "',"+issuccess.ToString()+")";
                try
                {
                    Conn.Open();
                    SqlCommand logcmd = new SqlCommand(log_kaydi, Conn);
                    logcmd.ExecuteNonQuery();
                    Conn.Close();
                }
                catch (Exception ex)
                {
                    Conn.Close();
                    Error.errorlog(ex, Application.StartupPath);
                }
               
                // İşlemler Bittikten Sonra Tekrardan Çalışabilir hale gelmesi için Yapılan İşlemler
                this.Controls.Clear();
                this.InitializeComponent();
                main_Load(sender,e);
                //resettostart();
            }
        }
        SerialPort sport = new SerialPort();

        [Obsolete]
        private void resettostart()
        {
            try
            {
            oku.Suspend();
            }
            catch (Exception ex)
            {
                Error.errorlog(ex, Application.StartupPath);
            }
            stages = 0;
            button2.Text = "Sonraki";
            nowa.Text = "0";
            nowb.Text = "0";
            nowc.Text = "0";
            nowtot.Text = "0";
            calca.Text = "0";   
            calcb.Text = "0";   
            calcc.Text = "0";   
            calctot.Text = "0";
            groupBox2.Visible = false;
            groupBox3.Enabled = true;
            button3.Visible = false;
        }
        private void stagestr()
        {
            if (stages == 0)
            {
                dotxt.Text = "Dara Tartılıyor.";
            }
            if (stages == 1)
            {
                dotxt.Text = "Boya Tartılıyor.";
            }
            if (stages == 2)
            {
                dotxt.Text = "Sertleştirici Tartılıyor.";
            }
            if (stages == 3)
            {
                dotxt.Text = "Tiner Tartılıyor.";
            }
        }
        string getstr;

        private void portcontrol()
        {
            SerialPort sport = Connections.sport;
            try
            {
                sport.Open();
                sport.WriteLine("T");
                sport.Close();
            }
            catch(Exception ex)
            {
                sport.Close();
                Error.errorlog(ex, Application.StartupPath);
                MessageBox.Show("Lütfen Bağlantı Ayarlarınızı Kontrol Edip Tekrar Yapınız !");
                Application.Restart();
            }
        }
        public void portislem()
        {
          
            var ci = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            ci.NumberFormat.NumberDecimalSeparator = ".";
            var cir = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            cir.NumberFormat.NumberDecimalSeparator = ",";
            try
            {
                //sport = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
                sport = Connections.sport;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terazi Bağlantısı Gerçekleştirilemedi.");
                Error.errorlog(ex, Application.StartupPath);
            }
            if (stages == 0 && isfirst == true)
            {
                try
                {
                    sport.Open();
                    sport.WriteLine("Z");
                    sport.Close();
                    isfirst = false;    
                }
                catch (Exception ex)
                {
                    Error.errorlog(ex, Application.StartupPath);
                }
            }
            while (contin == true)
            {
                if (stages <= 3)
                    {
                    try
                    {
                        sport.Open();
                        sport.WriteLine("SI");
                        getstr = sport.ReadLine();
                    }
                    catch (Exception ex)
                    {
                        Error.errorlog(ex, Application.StartupPath);
                    }
                    finally
                    {
                        if (getstr.Substring(0, 2) != "ES" & getstr.Length >= 17)
                        {
                            current.Text = getstr.Substring(8, 6);
                            Thread.Sleep(1000);
                            try
                            {
                            sport.Close();
                            }
                            catch (Exception ex)
                            {
                                Error.errorlog(ex, Application.StartupPath);
                            }
                            if (stages != 0)
                            {
                                float oran = 0;
                                if (stages == 1)
                                {
                                    oran = float.Parse(calca.Text,cir);
                                }
                                else if (stages == 2)
                                {
                                    oran = float.Parse(calcb.Text,cir);
                                }
                                else if (stages == 3)
                                {
                                    oran = float.Parse(calcc.Text,cir);
                                }
                                if (float.Parse(current.Text,ci) <= oran - (oran * 3 / 100) )
                                {
                                    pictureBox1.BackColor = Color.Yellow;
                                    current.BackColor = pictureBox1.BackColor;
                                    stagestr();
                                    button3.Enabled = false;
                                    button2.Enabled = false;
                                }
                                else if (float.Parse(current.Text, ci) >= oran + (oran * 3 / 100) )
                                {
                                    pictureBox1.BackColor = Color.Red;
                                    current.BackColor = pictureBox1.BackColor;
                                    stagestr();
                                    dotxt.Text = dotxt.Text + "\n İstenilen Gramı Geçtiniz !!! \n İşlemi İptal Ediniz.";
                                    button3.Enabled = true;
                                    button2.Enabled = false;
                                }
                                else
                                {
                                    pictureBox1.BackColor = Color.Green;
                                    current.BackColor = pictureBox1.BackColor;
                                    stagestr();
                                    button3.Enabled = false;
                                    button2.Enabled = true;
                                }
                            }
                        }
                        else
                        {
                            current.Text = "0";
                            try
                            {
                            sport.Close();
                            }
                            catch (Exception ex)
                            {
                                Error.errorlog(ex, Application.StartupPath);
                            }
                        }
                    }
                }
                else
                {
                    dotxt.Text = "Lütfen Karışımı Tartının Üzerinden Alınız \n Ve İşlemi Tamamlayınız. ";
                    current.Visible = false;
                    pictureBox1.BackColor = Color.Green;
                    current.BackColor = pictureBox1.BackColor;
                    button3.Enabled = false;
                    button2.Enabled = true;
                }
            }
        }
        [Obsolete]
        private void button3_Click(object sender, EventArgs e)
        {
            if (stages == 0)
            {
                daratxt.Text = current.Text;
            }
            if (stages == 1)
            {
                nowa.Text = current.Text;
            }
            if (stages == 2)
            {
                nowb.Text = current.Text;
            }
            if (stages == 3)
            {
                nowc.Text = current.Text;
            }
            stages = 5; // iptal
            button2_Click(sender, e);   
            resettostart();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(CurrentUserPerm == "True")
            {
            BitirmeProjesi.YoneticiPaneli setngs = new BitirmeProjesi.YoneticiPaneli();
            setngs.ShowDialog();
            }
            else
            {
                MessageBox.Show("Yetkiniz Olmadığından Bu Sayfaya Giremezsiniz !" + CurrentUserPerm);
            }
        }
        string selectedmat;
        private void matbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (matbox.SelectedIndex != -1)
            {
                selectedmat = (matbox.SelectedItem as dynamic).Value.ToString();
                Conn.Open();
                SqlDataAdapter filformula = new SqlDataAdapter("Select * From formulas Where(f_id = (Select lining_f from materials Where material = '"+selectedmat+ "' ) or f_id = (Select lastcoat_f From materials Where material = '" + selectedmat + "'))", Conn);
                DataTable filformuladt = new DataTable();
                filformula.Fill(filformuladt);
                Conn.Close();
                DataRow[] formularows = filformuladt.Select();
                paintbox.DisplayMember = "Text";
                paintbox.ValueMember = "Value";
                paintbox.Items.Clear();
                for (int x = 1; x <= filformuladt.Rows.Count; x++)
                {
                    paintbox.Items.Add(new { Text = formularows[x - 1]["f_text"].ToString(), Value = formularows[x - 1]["f_id"].ToString() });
                }
                ptypebox.Enabled = true;
                paintbox.SelectedIndex = -1;
                paintbox.Text = "";
            } 
        }

        private void ptypebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ptypebox.SelectedIndex != -1)
            {
                pstagebox.Items.Clear();
                Conn.Open();
                DataTable pstagedt = new DataTable();
                
                
                if ((ptypebox.SelectedItem as dynamic).Text.ToString() == "Tamir")
                {
                    SqlDataAdapter pstage = new SqlDataAdapter("Select * From stages Where stg_text = 'Tamir'", Conn);
                    pstage.Fill(pstagedt);
                    Conn.Close();
                    DataRow[] strows = pstagedt.Select();
                    for (int y = 1; y <= pstagedt.Rows.Count; y++)
                    {
                        pstagebox.Items.Add(new { Text = strows[y - 1]["stg_text"].ToString(), Value = strows[y - 1]["stg_id"].ToString() });
                    }
                }
                else
                {
                    SqlDataAdapter pstage = new SqlDataAdapter("Select * From stages Where stg_text != 'Tamir'", Conn);
                    pstage.Fill(pstagedt);
                    Conn.Close();
                    DataRow[] strows = pstagedt.Select();
                    for (int y = 1; y <= pstagedt.Rows.Count; y++)
                    {
                        pstagebox.Items.Add(new { Text = strows[y - 1]["stg_text"].ToString(), Value = strows[y - 1]["stg_id"].ToString() });
                    }
                }
                pstagebox.SelectedIndex = -1;
                pstagebox.Text = "";
                pstagebox.Enabled = true;
            }
        }

        private void pstagebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pstagebox.SelectedIndex != -1)
            {
                paintbox.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (CurrentUserPerm == "True")
            {
                if (MessageBox.Show("Yetkili Olduğunuzdan dolayı terazi bağlantı ayarları kontrol edilmedi. Devam Edilsin mi ?", "Uyarı !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                portcontrol();
                }
                else
                {
                    return;
                }
                
            }
            float paint, thinner, hardener, totall;
            if(prdordertxt.Text != "" && matbox.SelectedIndex != -1 && ptypebox.SelectedIndex != -1 && pstagebox.SelectedIndex != -1 && paintbox.SelectedIndex != -1 && paintgr.Text != "" && paintgr.Text != "0" && Int16.Parse(paintgr.Text) <= 7500) 
            {
                var cir = (CultureInfo)CultureInfo.CurrentCulture.Clone();
                cir.NumberFormat.NumberDecimalSeparator = ",";
                groupBox3.Enabled = false;
                Conn.Open();
                SqlDataAdapter curformula = new SqlDataAdapter("Select * From formulas Where f_id ="+ ((paintbox.SelectedItem as dynamic).Value).ToString(), Conn);
                DataTable curformuladt = new DataTable();
                curformula.Fill(curformuladt);
                Conn.Close();
                DataRow[] curformularows = curformuladt.Select();
                Boolean qrcontrol = true;
                while (qrcontrol == true)
                {
                    string qrcur = curformularows[0]["p_qr"].ToString();
                    if (qrcur == Interaction.InputBox(curformularows[0]["p_text"].ToString() + " üzerindeki barkodu okutunuz."))
                    {
                        qrcontrol = false;
                        break;
                    }
                }
                qrcontrol = true;
                while (qrcontrol == true)
                {
                    string qrcur = curformularows[0]["h_qr"].ToString();
                    if (qrcur == Interaction.InputBox(curformularows[0]["h_text"].ToString() + " üzerindeki barkodu okutunuz."))
                    {
                        qrcontrol = false;
                        break;
                    }
                }
                qrcontrol = true;
                while (qrcontrol == true)
                {
                    string qrcur = curformularows[0]["t_qr"].ToString();
                    if (qrcur == Interaction.InputBox(curformularows[0]["t_text"].ToString() + " üzerindeki barkodu okutunuz."))
                    {
                        qrcontrol = false;
                        break;
                    }
                }
                totall = float.Parse(paintgr.Text, cir);
                paint = float.Parse(curformularows[0]["paint"].ToString(),cir);
                hardener = float.Parse(curformularows[0]["hardener"].ToString(),cir);
                thinner = float.Parse(curformularows[0]["thinner"].ToString(),cir);
                calca.Text = ((totall * paint) / 100).ToString();
                calcb.Text = ((totall * hardener) / 100).ToString();
                calcc.Text = ((totall * thinner) / 100).ToString();
                calctot.Text = totall.ToString();
                label3.Text = curformularows[0]["p_text"].ToString();
                label4.Text = curformularows[0]["h_text"].ToString();
                label6.Text = curformularows[0]["t_text"].ToString();
                groupBox2.Visible = true;
                stages = 0;
                isfirst = true;
                if (oku.ThreadState == ThreadState.Unstarted)
                {
                    oku.Start();
                }
                else
                {
                    oku.Resume();
                }
                stagestr();
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Bilgileri Düzgünce Doldurunuz !");
                if(Int16.Parse(paintgr.Text) >= 7501)
                {
                    MessageBox.Show("Lütfen 7500 gramdan fazla karışım hazırlamayınız !");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
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
                this.SetDesktopLocation(MousePosition.X - (mouse_x+5), MousePosition.Y - (mouse_y));
            }
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

 
    }
}
