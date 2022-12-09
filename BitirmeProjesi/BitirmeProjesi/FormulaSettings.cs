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
using DatabaseConnections;
using ErrorLog;
using System.Text.RegularExpressions;

namespace BitirmeProjesi
{
    public partial class FormulaSettings : Form
    {
        public FormulaSettings()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection(Connections.conntext);
        DataTable Dt = new DataTable();
        Controls ControlClass = new Controls();
        //LoadData Methodu ile datagridview içerisine veritabanından verileri aktarıyoruz.
        private void LoadData()
        {
            try
            {
                if (Conn.State == ConnectionState.Broken)
                {
                    MessageBox.Show("Bağlantı Hatası Lütfen Bağlantıyı Kontrol Ediniz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Dt.Clear();
                string query = "SELECT f_id as Formul_id, f_text as Formul_ad,f_type as Formul_tip,paint as Boya_oran,hardener Sertlestirici_oran,thinner Tiner_oran,p_text as Boya_ad,h_text as Sertlestirici_ad,t_text as Tiner_ad,p_qr,h_qr,t_qr FROM formulas";
                Conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, Conn);
                dataAdapter.Fill(Dt);
                bindingSource1.DataSource = Dt;
                dataGridView1.DataSource = bindingSource1;
                Conn.Close();
            }
            catch (Exception ex)
            {
                Conn.Close();
                Error.errorlog(ex, Application.StartupPath);
                return;
            }

        }
        bool state;
        //cntrl Methodu ile TextBox içerisine geziyoruz ve istenmeyen bir değer var ise bizi 
        // error provider sayasinde uyarıyor
        private void cntrl()
        {
            Conn.Close();
            FormulaID.Focus();
            FormulaName.Focus();
            FormulTypeText.Focus();
            AText.Focus();
            BText.Focus();
            CText.Focus();
            PaintNameText.Focus();
            HardenerText.Focus();
            ThinnerText.Focus();
        }

        private void FormulaSettings_Load(object sender, EventArgs e)
        {
            LoadData();
            // Datagridview'i Sadece okunabilir moda aldım ve Binding Source işlemlerini ayarladım
            dataGridView1.ReadOnly = true;
            FormulaID.DataBindings.Add("Text", bindingSource1, "Formul_id");
            FormulaName.DataBindings.Add("Text", bindingSource1, "Formul_ad");
            FormulTypeText.DataBindings.Add("Text", bindingSource1, "Formul_tip");
            AText.DataBindings.Add("Text", bindingSource1, "Boya_oran");
            BText.DataBindings.Add("Text", bindingSource1, "Sertlestirici_oran");
            CText.DataBindings.Add("Text", bindingSource1, "Tiner_oran");
            PaintNameText.DataBindings.Add("Text", bindingSource1, "Boya_ad");
            HardenerText.DataBindings.Add("Text", bindingSource1, "Sertlestirici_ad");
            ThinnerText.DataBindings.Add("Text", bindingSource1, "Tiner_ad");
            PaintQrText.DataBindings.Add("Text", bindingSource1, "p_qr");
            HardenerQrText.DataBindings.Add("Text", bindingSource1, "h_qr");
            ThinnerQrText.DataBindings.Add("Text", bindingSource1, "t_qr");

        }

        private void FormulaAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //state validate kontrolleri için bize gerekli burada false yapıyoruz ki önceki değer 
                //etki etmesin
                state = false;
                //cntrl ile o anki state değerini ayarlıyoruz ki kontrol edebilelim
                cntrl();
                // Atext, Btext, Ctext adlı textboxlardan gelen sayısal değerlerin toplamının
                // %100 olup olmadığını kontrol ettiriyorum
                if (Convert.ToDouble(AText.Text.Replace("%","")) + Convert.ToDouble(BText.Text.Replace("%", "")) + Convert.ToDouble(CText.Text.Replace("%", "")) != 100)
                {
                    MessageBox.Show("Lütfen Formül Değerlerini %100 Olacak Şekilde Giriniz", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // veri tabanı bağlantısının kopup kopmadğını kontrol ediyoruz.
                if (Conn.State == ConnectionState.Broken)
                {
                    MessageBox.Show("Bağlantı Hatası Lütfen Bağlantıyı Kontrol Ediniz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // validation kontrollerini state değişkeni ile kontrol ediyoruz
                if (state)
                {
                    MessageBox.Show("Lütfen Gerekli Alanlara Değerleri Doğru Girdiğinizden Emin Olunuz!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Conn.Open();
                // veri tabanına veri giriş işlemi yaptırıyoruz ve en sonda tabloyu yeniden doldurtuyoruz
                string Query = "INSERT INTO formulas(f_text,f_type,paint,hardener,thinner,p_text,h_text,t_text,p_qr,h_qr,t_qr) " +
                               "Values(@name,@type,@a,@b,@c,@ptext,@htext,@ttext,@pqr,@hqr,@tqr)";
                SqlCommand command = new SqlCommand(Query, Conn);
                
                command.Parameters.AddWithValue("@name", FormulaName.Text);
                command.Parameters.AddWithValue("@type", FormulTypeText.Text);
                command.Parameters.AddWithValue("@a",  AText.Text.Replace("%",""));
                command.Parameters.AddWithValue("@b", BText.Text.Replace("%", ""));
                command.Parameters.AddWithValue("@c", CText.Text.Replace("%", ""));
                command.Parameters.AddWithValue("@ptext", PaintNameText.Text);
                command.Parameters.AddWithValue("@htext", HardenerText.Text);
                command.Parameters.AddWithValue("@ttext", ThinnerText.Text);
                command.Parameters.AddWithValue("@pqr", PaintQrText.Text);
                command.Parameters.AddWithValue("@hqr", HardenerQrText.Text);
                command.Parameters.AddWithValue("@tqr", ThinnerQrText.Text);
                command.ExecuteNonQuery();
                Conn.Close();
                LoadData();

            }
            catch (Exception ex)
            {
                // errorlog methodu ile programın pathinde bulunan text dosyasının içerisine 
                // programdaki hatanın detaylı ayrıntısını yazdırıyoruz
                Conn.Close();
                Error.errorlog(ex, Application.StartupPath);
                MessageBox.Show("Kayıt İşlemi Sırasında Hata Meydana Geldi! ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
              
        }

        private void FormulaDeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //state validate kontrolleri için bize gerekli burada false yapıyoruz ki önceki değer 
                //etki etmesin
                state = false;
                //cntrl ile o anki state değerini ayarlıyoruz ki kontrol edebilelim
                cntrl();
                // veri tabanı bağlantısının kopup kopmadğını kontrol ediyoruz.
                if (Conn.State == ConnectionState.Broken)
                {
                    MessageBox.Show("Bağlantı Hatası Lütfen Bağlantıyı Kontrol Ediniz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // kullanıcıdan son bir kez daha onay alıyoruz
                if (MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Mesaj", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                Conn.Open();
                // veri tabanına veri silme işlemi yaptırıyoruz ve en sonda tabloyu yeniden doldurtuyoruz
                string Query = "DELETE FROM formulas " +
                               "WHERE f_id = @id";
                SqlCommand command = new SqlCommand(Query, Conn);
                command.Parameters.AddWithValue("@id", FormulaID.Text);
                command.ExecuteNonQuery();
                Conn.Close();
                LoadData();
            }
            catch (Exception ex)
            {
                // errorlog methodu ile programın pathinde bulunan text dosyasının içerisine 
                // programdaki hatanın detaylı ayrıntısını yazdırıyoruz
                Conn.Close();
                Error.errorlog(ex, Application.StartupPath);
                MessageBox.Show("Silme İşlemi Sırasında Hata Meydana Geldi!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
               
          
            
        }

        private void FormulaUpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //state validate kontrolleri için bize gerekli burada false yapıyoruz ki önceki değer 
                //etki etmesin
                state = false;
                //cntrl ile o anki state değerini ayarlıyoruz ki kontrol edebilelim
                cntrl();

                // Atext, Btext, Ctext adlı textboxlardan gelen sayısal değerlerin toplamının
                // %100 olup olmadığını kontrol ettiriyorum
                if (Convert.ToDouble(AText.Text.Replace("%", "")) + Convert.ToDouble(BText.Text.Replace("%", "")) + Convert.ToDouble(CText.Text.Replace("%", "")) != 100)
                {
                    MessageBox.Show("Lütfen Formül Değerlerini %100 Olacak Şekilde Giriniz", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // veri tabanı bağlantısının kopup kopmadğını kontrol ediyoruz.
                if (Conn.State == ConnectionState.Broken)
                {
                    MessageBox.Show("Bağlantı Hatası Lütfen Bağlantıyı Kontrol Ediniz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // validation kontrollerini state değişkeni ile kontrol ediyoruz
                if (state)
                {
                    MessageBox.Show("Lütfen Gerekli Alanlara Değerleri Doğru Girdiğinizden Emin Olunuz!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Conn.Open();

                // veri tabanına veri güncelleme işlemi yaptırıyoruz ve en sonda tabloyu yeniden doldurtuyoruz
                string Query = "Update formulas SET " +
                               "f_text = @Name,f_type = @type, paint= @a, hardener= @b , thinner= @c, " +
                               "p_text = @paint, h_text=@hardener, t_text=@thinner , p_qr=@pqr, h_qr=@hqr, t_qr=@tqr " +
                               "WHERE f_id = @id";
                SqlCommand command = new SqlCommand(Query, Conn);
                command.Parameters.AddWithValue("@id", FormulaID.Text);
                command.Parameters.AddWithValue("@name", FormulaName.Text);
                command.Parameters.AddWithValue("@type", FormulTypeText.Text);
                command.Parameters.AddWithValue("@a", AText.Text.Replace("%", ""));
                command.Parameters.AddWithValue("@b", BText.Text.Replace("%", ""));
                command.Parameters.AddWithValue("@c", CText.Text.Replace("%", ""));
                command.Parameters.AddWithValue("@paint", PaintNameText.Text);
                command.Parameters.AddWithValue("@hardener", HardenerText.Text);
                command.Parameters.AddWithValue("@thinner", ThinnerText.Text);
                command.Parameters.AddWithValue("@pqr", PaintQrText.Text);
                command.Parameters.AddWithValue("@hqr", HardenerQrText.Text);
                command.Parameters.AddWithValue("@tqr", ThinnerQrText.Text);
                command.ExecuteNonQuery();
                Conn.Close();
                LoadData();
            }
            catch (Exception ex)
            {
                // errorlog methodu ile programın pathinde bulunan text dosyasının içerisine 
                // programdaki hatanın detaylı ayrıntısını yazdırıyoruz
                Error.errorlog(ex,Application.StartupPath);
                Conn.Close();
                MessageBox.Show("Güncelleme İşlemi Sırasında Hata Meydana Geldi!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            // browsetext adlı textbox içerisine yazılan değeri veri tabanında aratıyoruz
            DataView dv = Dt.DefaultView;
            dv.RowFilter = string.Format("f_text like '%{0}%'", BrowseText.Text);
            dataGridView1.DataSource = dv.ToTable();
        }
        // Aşağıdaki Kodlarda belirtilen koşullara göre textboxlar içerisindeki değerlerin uygun olup
        // olmadığını kontrol ettiriyoruz. hata var ise error provider ile hata verdiriyoruz.
        private void FormulaName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(FormulaName.Text))
            {
                state = true;
               
                errorProvider1.SetError(FormulaName, "Lütfen Alanı Boş Bırakmayınız!");
            }
            else if (ControlClass.IsHaveNumeric(FormulaName.Text))
            {
                state = true;
          
                errorProvider1.SetError(FormulaName, "Bu Alana Yalnızca Alfabetik Değer Girilebilir!");
            }
            else { errorProvider1.SetError(FormulaName, null);}
        }

        private void FormulTypeText_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(FormulTypeText.Text))
            {
                state = true;
     
                errorProvider1.SetError(FormulTypeText, "Lütfen Alanı Boş Bırakmayınız!");
            }
            else if (ControlClass.IsHaveNumeric(FormulTypeText.Text))
            {
                state = true;

                errorProvider1.SetError(FormulTypeText, "Bu Alana Yalnızca Alfabetik Değer Girilebilir!");
            }
            else { errorProvider1.SetError(FormulTypeText, null);}
        }

        private void PaintNameText_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(PaintNameText.Text))
            {
                state = true;
         
                errorProvider1.SetError(PaintNameText, "Lütfen Alanı Boş Bırakmayınız!");
            }

            else if (!Regex.IsMatch(PaintNameText.Text, @"^[a-zA-Z0-9-.\s]+$"))
            {
                state = true;
                errorProvider1.SetError(PaintNameText, "Geçersiz Karakter Girişi!");
            }
            else {  errorProvider1.SetError(PaintNameText, null);  }
        }

        private void HardenerText_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(HardenerText.Text))
            {
                state = true;
            
                errorProvider1.SetError(HardenerText, "Lütfen Alanı Boş Bırakmayınız!");
            }
            else if (!Regex.IsMatch(HardenerText.Text, @"^[a-zA-Z0-9-.\s]+$"))
            {
                state = true;
                errorProvider1.SetError(HardenerText, "Geçersiz Karakter Girişi!");
            }

            else { errorProvider1.SetError(HardenerText, null);}
        }

        private void ThinnerText_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(ThinnerText.Text))
            {
                state = true;
            
                errorProvider1.SetError(ThinnerText, "Lütfen Alanı Boş Bırakmayınız!");
            }
            else if (!Regex.IsMatch(ThinnerText.Text, @"^[a-zA-Z0-9-.\s]+$"))
            {
                state = true;
                errorProvider1.SetError(ThinnerText, "Geçersiz Karakter Girişi!");
            }

            else { errorProvider1.SetError(ThinnerText, null);}
        }

        private void FormulaID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(FormulaID.Text))
            {
                state = true;
                errorProvider1.SetError(FormulaID, "Lütfen Alanı Boş Bırakmayınız!");
            }
            else if (!ControlClass.IsNumeric(FormulaID.Text))
            {
                state = true;

                errorProvider1.SetError(CText, "Bu Alana Yalnızca Sayısal Değer Girilebilir!");
            }
            else if (Convert.ToInt32(FormulaID.Text) > 32767)
            {
                state = true;

                errorProvider1.SetError(FormulaID, "Bu Alana Yalnızca 32767 Değerinden Küçük Değerler Girilebilir!");
            }
            else { errorProvider1.SetError(FormulaID, null); }
        }

        private void AText_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(AText.Text.Replace("%", "").Replace(".","").Replace("_","")))
            {
                state = true;

                errorProvider1.SetError(AText, "Lütfen Alanı Boş Bırakmayınız!");
            }
            else if (!ControlClass.IsNumeric(AText.Text.Replace("%", "")))
            {
                state = true;

                errorProvider1.SetError(AText, "Bu Alana Yalnızca Sayısal Değer Girilebilir!");
            }
            else if (Convert.ToDouble(AText.Text.Replace("%", "")) > 100)
            {
                state = true;

                errorProvider1.SetError(AText, "Girilen Değer 100'ü Geçemez!");
            }
            else { errorProvider1.SetError(AText, null); }
        }

        private void BText_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(BText.Text.Replace("%", "").Replace(".","").Replace("_", "")))
            {
                state = true;

                errorProvider1.SetError(BText, "Lütfen Alanı Boş Bırakmayınız!");
            }
            else if (!ControlClass.IsNumeric(BText.Text.Replace("%", "")))
            {
                state = true;

                errorProvider1.SetError(BText, "Bu Alana Yalnızca Sayısal Değer Girilebilir!");
            }
            else if (Convert.ToDouble(BText.Text.Replace("%", "")) > 100)
            {
                state = true;

                errorProvider1.SetError(BText, "Girilen Değer 100'ü Geçemez!");
            }
            else { errorProvider1.SetError(BText, null); }
        }

        private void CText_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(CText.Text.Replace("%", "").Replace(".","").Replace("_", "")))
            {
                state = true;

                errorProvider1.SetError(CText, "Lütfen Alanı Boş Bırakmayınız!");
            }
            else if (!ControlClass.IsNumeric(CText.Text.Replace("%", "")))
            {
                state = true;

                errorProvider1.SetError(CText, "Bu Alana Yalnızca Sayısal Değer Girilebilir!");
            }
            else if (Convert.ToDouble(CText.Text.Replace("%", "")) > 100)
            {
                state = true;

                errorProvider1.SetError(CText, "Girilen Değer 100'ü Geçemez!");
            }
            else { errorProvider1.SetError(CText, null); }
        }

        private void PaintQrText_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(PaintQrText.Text))
            {
                state = true;

                errorProvider1.SetError(PaintQrText, "Lütfen Alanı Boş Bırakmayınız!");
            }
            else if (!Regex.IsMatch(PaintQrText.Text, @"^[a-zA-Z0-9]+$"))
            {
                state = true;
                errorProvider1.SetError(PaintQrText, "Geçersiz Karakter Girişi!");
            }

            else { errorProvider1.SetError(PaintQrText, null); }
        }

        private void HardenerQrText_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(HardenerQrText.Text))
            {
                state = true;

                errorProvider1.SetError(HardenerQrText, "Lütfen Alanı Boş Bırakmayınız!");
            }
            else if (!Regex.IsMatch(HardenerQrText.Text, @"^[a-zA-Z0-9]+$"))
            {
                state = true;
                errorProvider1.SetError(HardenerQrText, "Geçersiz Karakter Girişi!");
            }

            else { errorProvider1.SetError(HardenerQrText, null); }
        }

        private void ThinnerQrText_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ThinnerQrText.Text))
            {
                state = true;
                errorProvider1.SetError(ThinnerQrText, "Lütfen Alanı Boş Bırakmayınız!");
            }
            else if (!Regex.IsMatch(ThinnerQrText.Text, @"^[a-zA-Z0-9]+$"))
            {
                state = true;
                errorProvider1.SetError(ThinnerQrText, "Geçersiz Karakter Girişi!");
            }

            else { errorProvider1.SetError(ThinnerQrText, null); }
        }
    }
}
    


