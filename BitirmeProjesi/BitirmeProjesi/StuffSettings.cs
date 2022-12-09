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

namespace BitirmeProjesi
{
    public partial class StuffSettings : Form
    {

        public StuffSettings()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection(Connections.conntext);
        DataTable Dt = new DataTable();
        Controls ControlClass = new Controls();
        bool state;
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
                string query = "Select * From users";
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
        //cntrl Methodu ile TextBox içerisine geziyoruz ve istenmeyen bir değer var ise bizi 
        // error provider sayasinde uyarıyor
        private void cntrl()
        {
            Conn.Close();
            StuffNoText.Focus();
            StuffNameText.Focus();
            StuffLNameText.Focus();
            dataGridView1.Focus();
        }

        private void StuffSettings_Load(object sender, EventArgs e)
        {
            LoadData();
            // Datagridview'i Sadece okunabilir moda aldım ve Binding Source işlemlerini ayarladım
            dataGridView1.ReadOnly = true;
            StuffNoText.DataBindings.Add("Text", bindingSource1, "us_id");
            StuffNameText.DataBindings.Add("Text", bindingSource1,"us_name");
            StuffLNameText.DataBindings.Add("Text", bindingSource1, "us_surname");
            AdminChck.DataBindings.Add("Checked", bindingSource1, "us_perm");
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            //state validate kontrolleri için bize gerekli burada false yapıyoruz ki önceki değer 
            //etki etmesin
            state = false;
            //cntrl ile o anki state değerini ayarlıyoruz ki kontrol edebilelim
            cntrl();
            try
            {
                // veri tabanı bağlantısının kopup kopmadğını kontrol ediyoruz.
                if (Conn.State == ConnectionState.Broken){
                    MessageBox.Show("Bağlantı Hatası Lütfen Bağlantıyı Kontrol Ediniz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;}
                // validation kontrollerini state değişkeni ile kontrol ediyoruz
                if (state){
                    MessageBox.Show("Lütfen Gerekli Alanlara Değerleri Doğru Girdiğinizden Emin Olunuz!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;}
                Conn.Open();
                // veri tabanına veri giriş işlemi yaptırıyoruz ve en sonda tabloyu yeniden doldurtuyoruz
                string Query = "INSERT INTO users " +
                               "Values(@id,@name,@lname,@perm)";
                SqlCommand command = new SqlCommand(Query, Conn);
                command.Parameters.AddWithValue("@id", StuffNoText.Text);
                command.Parameters.AddWithValue("@name", StuffNameText.Text);
                command.Parameters.AddWithValue("@lname", StuffLNameText.Text);
                command.Parameters.AddWithValue("@perm", AdminChck.Checked);
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

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            // browsetext adlı textbox içerisine yazılan değeri veri tabanında aratıyoruz
            DataView dv = Dt.DefaultView;
            dv.RowFilter = string.Format("us_id like '%{0}%'", BrowseText.Text);
            dataGridView1.DataSource = dv.ToTable();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            //state validate kontrolleri için bize gerekli burada false yapıyoruz ki önceki değer 
            //etki etmesin
            state = false;
            //cntrl ile o anki state değerini ayarlıyoruz ki kontrol edebilelim
            cntrl();
            try
            {
                // veri tabanı bağlantısının kopup kopmadğını kontrol ediyoruz.
                if (Conn.State == ConnectionState.Broken)
                {
                    MessageBox.Show("Bağlantı Hatası Lütfen Bağlantıyı Kontrol Ediniz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // kullanıcıdan son bir kez daha onay alıyoruz
                if (MessageBox.Show("Silmek İstediğinize Emin Misiniz?","Mesaj",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                Conn.Open();
                // veri tabanına veri silme işlemi yaptırıyoruz ve en sonda tabloyu yeniden doldurtuyoruz
                string Query = "DELETE FROM users " +
                               "WHERE us_id = @id";
                SqlCommand command = new SqlCommand(Query, Conn);
                command.Parameters.AddWithValue("@id", StuffNoText.Text);
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

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            //state validate kontrolleri için bize gerekli burada false yapıyoruz ki önceki değer 
            //etki etmesin
            state = false;
            //cntrl ile o anki state değerini ayarlıyoruz ki kontrol edebilelim
            cntrl();
            try
            {
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
                string Query = "Update users SET " +
                               "us_name = @Name, us_surname= @LName, us_perm= @perm " +
                               "WHERE us_id = @id";
                SqlCommand command = new SqlCommand(Query, Conn);
                command.Parameters.AddWithValue("@id", StuffNoText.Text);
                command.Parameters.AddWithValue("@name", StuffNameText.Text);
                command.Parameters.AddWithValue("@lname", StuffLNameText.Text);
                command.Parameters.AddWithValue("@perm", AdminChck.Checked);
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
                MessageBox.Show("Güncelleme İşlemi Sırasında Hata Meydana Geldi!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
        }
        // Aşağıdaki Kodlarda belirtilen koşullara göre textboxlar içerisindeki değerlerin uygun olup
        // olmadığını kontrol ettiriyoruz. hata var ise error provider ile hata verdiriyoruz.
        private void StuffNoText_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(StuffNoText.Text)){
                state = true;

                errorProvider1.SetError(StuffNoText, "Lütfen Alanı Boş Bırakmayınız!");
            }
            else if (!(StuffNoText.Text.Length == 12)){
                state = true;
 
                errorProvider1.SetError(StuffNoText, "Bu Alana 12 Karakter Girilmek Zorundadır!");
            }
           
            else if(!ControlClass.IsNumeric(StuffNoText.Text)){
                state = true;

                errorProvider1.SetError(StuffNoText, "Bu Alana Yalnızca Sayısal Değer Girilebilir!");
            }
            else{ errorProvider1.SetError(StuffNoText, null); }
        }

        private void StuffNameText_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(StuffNameText.Text))
            {
                state = true;

                errorProvider1.SetError(StuffNameText, "Lütfen Alanı Boş Bırakmayınız!");
            }
            else if (ControlClass.IsHaveNumeric(StuffNameText.Text))
            {
                state = true;

                errorProvider1.SetError(StuffNameText, "Bu Alana Yalnızca Alfabetik Değer Girilebilir!");
            }
            else {  errorProvider1.SetError(StuffNameText, null);}
        }

        private void StuffLNameText_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(StuffLNameText.Text))
            {
                state = true;
   
                errorProvider1.SetError(StuffLNameText, "Lütfen Alanı Boş Bırakmayınız!");
            }
            else if (ControlClass.IsHaveNumeric(StuffLNameText.Text))
            {
                state = true;

                errorProvider1.SetError(StuffLNameText, "Bu Alana Yalnızca Alfabetik Değer Girilebilir!");
            }
            else { errorProvider1.SetError(StuffLNameText, null);}
        }

    }
}
