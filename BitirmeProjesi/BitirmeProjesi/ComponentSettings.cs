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
    public partial class ComponentSettings : Form
    {
        public ComponentSettings()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection(Connections.conntext);
        DataTable Dt = new DataTable();
        DataSet Dts = new DataSet();
        DataSet Dts2 = new DataSet();
        bool state;
        //LoadData Methodu ile datagridview içerisine veritabanından verileri aktarıyoruz.
        private void LoadData()
        {
            try
            {
                if (Conn.State == ConnectionState.Broken)
                {
                    MessageBox.Show("Bağlantı Hatası Lütfen Sayfayı Yenileyiniz", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Dt.Clear();
                Dts.Clear();
                Dts2.Clear();
                string query = "select material as Materyal_id,s_text as Materyal_Ad,a.f_text as Astar,b.f_text as Sonkat from materials inner join formulas as a on materials.lining_f=a.f_id inner join formulas as b on materials.lastcoat_f = b.f_id";
                string query2 = "Select * From formulas";
                Conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, Conn);
                SqlDataAdapter dataAdapter2 = new SqlDataAdapter(query2, Conn);
                dataAdapter.Fill(Dt);
                dataAdapter2.Fill(Dts);
                dataAdapter2.Fill(Dts2);
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
        //cntrl Methodu ile TextBox içerisine geziyoruz ve istenmeyen bir değer var ise bizi 
        // error provider sayasinde uyarıyor
        private void cntrl()
        {
            MaterialNameText.Focus();
            MaterialidText.Focus();
            LinerCmbx.Focus();
            TopCoatCmbx.Focus();
            MaterialNameText.Focus();
        }

        private void ComponentSettings_Load(object sender, EventArgs e)
        {
       
            LoadData();
            // Datagridview'i Sadece okunabilir moda aldım ve Binding Source işlemlerini ayarladım
            dataGridView1.ReadOnly = true;
            MaterialidText.DataBindings.Add("Text", bindingSource1, "Materyal_id");
            MaterialNameText.DataBindings.Add("Text", bindingSource1, "Materyal_Ad");
            // Combobox içerisindeki değerleri dolduruyorum
            LinerCmbx.Items.Clear();
            TopCoatCmbx.Items.Clear();
            LinerCmbx.DataSource = Dts.Tables[0];
            LinerCmbx.DisplayMember = "f_text";
            LinerCmbx.ValueMember = "f_id";
            LinerCmbx.Text = "Lütfen Bir Renk Seçiniz.";
            TopCoatCmbx.DataSource = Dts2.Tables[0];
            TopCoatCmbx.DisplayMember = "f_text";
            TopCoatCmbx.ValueMember = "f_id";
            TopCoatCmbx.Text = "Lütfen Bir Renk Seçiniz.";
        }
       

        private void MaterialAdd_Click(object sender, EventArgs e)
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
                // validation kontrollerini state değişkeni ile kontrol ediyoruz
                if (state)
                {
                    MessageBox.Show("Lütfen Gerekli Alanlara Değerleri Doğru Girdiğinizden Emin Olunuz!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Conn.Open();
                // veri tabanına veri giriş işlemi yaptırıyoruz ve en sonda tabloyu yeniden doldurtuyoruz
                string Query = "INSERT INTO materials " +
                               "Values(@id,@name,@line,@top)";
                SqlCommand command = new SqlCommand(Query, Conn);
                command.Parameters.AddWithValue("@id", MaterialidText.Text);
                command.Parameters.AddWithValue("@name", MaterialNameText.Text);
                command.Parameters.AddWithValue("@line", LinerCmbx.SelectedValue.ToString());
                command.Parameters.AddWithValue("@top", TopCoatCmbx.SelectedValue.ToString());
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

        private void MaterialDelete_Click(object sender, EventArgs e)
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
                string Query = "DELETE FROM materials " +
                               "WHERE material = @id";
                SqlCommand command = new SqlCommand(Query, Conn);
                command.Parameters.AddWithValue("@id", MaterialidText.Text);
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

        private void MaterialUpdate_Click(object sender, EventArgs e)
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

                // validation kontrollerini state değişkeni ile kontrol ediyoruz
                if (state)
                {
                    MessageBox.Show("Lütfen Gerekli Alanlara Değerleri Doğru Girdiğinizden Emin Olunuz!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Conn.Open();

                // veri tabanına veri güncelleme işlemi yaptırıyoruz ve en sonda tabloyu yeniden doldurtuyoruz
                string Query = "Update materials SET " +
                               "s_text = @Name, lining_f= @LinerCmbx, lastcoat_f= @TopCoatCmbx " +
                               "WHERE material = @id";
                SqlCommand command = new SqlCommand(Query, Conn);
                command.Parameters.AddWithValue("@id", MaterialidText.Text);
                command.Parameters.AddWithValue("@Name", MaterialNameText.Text);
                command.Parameters.AddWithValue("@LinerCmbx", LinerCmbx.SelectedValue.ToString());
                command.Parameters.AddWithValue("@TopCoatCmbx", TopCoatCmbx.SelectedValue.ToString());
                command.ExecuteNonQuery();
                Conn.Close();
                LoadData();
                }
                catch (Exception ex)
                {
                // errorlog methodu ile programın pathinde bulunan text dosyasının içerisine 
                // programdaki hatanın detaylı ayrıntısını yazdırıyoruz
                Error.errorlog(ex, Application.StartupPath);
                MessageBox.Show("Güncelleme İşlemi Sırasında Hata Meydana Geldi!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Conn.Close();
                    return;
                }
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            // browsetext adlı textbox içerisine yazılan değeri veri tabanında aratıyoruz
            DataView dv = Dt.DefaultView;
            dv.RowFilter = string.Format("s_text like '%{0}%'", BrowseText.Text);
            dataGridView1.DataSource = dv.ToTable();
        }

        // Aşağıdaki Kodlarda belirtilen koşullara göre textboxlar içerisindeki değerlerin uygun olup
        // olmadığını kontrol ettiriyoruz. hata var ise error provider ile hata verdiriyoruz.
        private void MaterialidText_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(MaterialidText.Text))
            {
                state = true;
               
                errorProvider1.SetError(MaterialidText, "Lütfen Alanı Boş Bırakmayınız!");
            }
            else if(!Regex.IsMatch(MaterialidText.Text, @"^[a-zA-Z0-9-.\s]+$"))
            {
                state = true;
                errorProvider1.SetError(MaterialidText, "Geçersiz Karakter Girişi!");
            }
            else {  errorProvider1.SetError(MaterialidText, null); }
        }

        private void MaterialNameText_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(MaterialNameText.Text))
            {
                state = true;
       
                errorProvider1.SetError(MaterialNameText, "Lütfen Alanı Boş Bırakmayınız!");
            }
            else if (!Regex.IsMatch(MaterialNameText.Text, @"^[a-zA-Z0-9-.\s]+$"))
            {
                state = true;
                errorProvider1.SetError(MaterialNameText, "Geçersiz Karakter Girişi!");
            }
            else { errorProvider1.SetError(MaterialNameText, null); }
        }

        private void LinerCmbx_Validating(object sender, CancelEventArgs e)
        {
            if (LinerCmbx.SelectedIndex == -1)
            {
                state = true;
          
                errorProvider1.SetError(LinerCmbx, "Lütfen Alanı Boş Bırakmayınız!");
            }
            else { errorProvider1.SetError(LinerCmbx, null);  }
        }

        private void TopCoatCmbx_Validating(object sender, CancelEventArgs e)
        {
            if (TopCoatCmbx.SelectedIndex == -1)
            {
                state = true;

                errorProvider1.SetError(TopCoatCmbx, "Lütfen Alanı Boş Bırakmayınız!");
            }
            else { errorProvider1.SetError(TopCoatCmbx, null);  }
        }

     
   
    }
}
