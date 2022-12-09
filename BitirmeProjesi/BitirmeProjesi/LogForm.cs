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
using Excel = Microsoft.Office.Interop.Excel;
using ErrorLog;


namespace BitirmeProjesi
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection(Connections.conntext);
        DataTable Dt = new DataTable();
        private void LogForm_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.ReadOnly = true;
                // veri tabanı bağlantısının kopup kopmadğını kontrol ediyoruz.
                if (Conn.State == ConnectionState.Broken)
                {
                    MessageBox.Show("Bağlantı Hatası Lütfen Bağlantıyı Kontrol Ediniz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Dt.Clear();
                //datagridview içerisine veritabanından verileri aktarıyoruz.
                string query = "select l.date As Tarih,"
+"(Select u.us_name + ' ' + u.us_surname As Personel From users As u Where u.us_id = l.us_id) As Personel,"
+"(Select m.material + ' - ' + m.s_text from materials As m where m.material = l.material ) As Parça," 
+"(Select f_text from formulas as f where f.f_id = l.f_id) As Formül," 
+"(Select f.p_text from formulas as f where f.f_id = l.f_id) As Boya," 
+"(Select f.h_text from formulas as f where f.f_id = l.f_id) As Sertleştici," 
+"(Select f.t_text from formulas as f where f.f_id = l.f_id) As Tiner," 
+"l.prdorder As 'İş Emri',"
+"(Select t.ty_text from type as t where t.ty_id = l.ty_id) As Tip,"
+"(Select s.stg_text from stages as s where s.stg_id = l.stg_id) As Aşama," 
+"l.calc_paint As 'Hesaplanan Boya'," 
+"l.calc_hardener As 'Hesaplanan Serleştirici'," 
+"l.calc_thinner As 'Hesaplanan Tiner'," 
+"l.calc_total As 'Hesaplanan Toplam Karışım'," 
+"l.real_paint As 'Tartılan Boya'," 
+"l.real_hardener As 'Tartılan Serleştirici'," 
+"l.real_thinner As 'Tartılan Tiner',"
+"l.real_total As 'Tartılan Toplam Karışım'," 
+"CASE" 
+"        WHEN l.issuccess = 0"

+"        Then 'İşlem İptal Edildi.'"

+"        Else 'İşlem Tamamlandı.'"

+"        End as 'Başarılı mı ?'"
+"from log As l; ";
                Conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, Conn);
                dataAdapter.Fill(Dt);
                dataGridView1.DataSource = Dt;
                Conn.Close();
            }
            catch (Exception ex)
            {
                // errorlog methodu ile programın pathinde bulunan text dosyasının içerisine 
                // programdaki hatanın detaylı ayrıntısını yazdırıyoruz
                Conn.Close();
                Error.errorlog(ex, Application.StartupPath);
                return;
            }

        }
        // Datagridview içerisindeki verileri excel dosyası halinde depolayıp istediğimiz bir yere
        // Kaydetmemizi sağliyoruz
        private void ExcelBtn_Click(object sender, EventArgs e)
        {
            
            Excel.Application App = new Excel.Application();
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = App.Workbooks.Add(misValue);

            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            xlWorkSheet.Cells[1, 1] = "Tarih";
            xlWorkSheet.Cells[1, 2] = "Personel No";
            xlWorkSheet.Cells[1, 3] = "Materyal";
            xlWorkSheet.Cells[1, 4] = "Formul İd";
            xlWorkSheet.Cells[1, 5] = "Onay Numarası";
            xlWorkSheet.Cells[1, 6] = "Tip id";
            xlWorkSheet.Cells[1, 7] = "Aşama id";
            xlWorkSheet.Cells[1, 8] = "Hesaplanan Boya";
            xlWorkSheet.Cells[1, 9] = "Hesaplanan Sertleştirici";
            xlWorkSheet.Cells[1, 10] = "Hesaplanan Toplam";
            xlWorkSheet.Cells[1, 11] = "Gerçek Boya";
            xlWorkSheet.Cells[1, 12] = "Gerçek Sertleştirici";
            xlWorkSheet.Cells[1, 13] = "Gerçek Toplam";
            xlWorkSheet.Cells[1, 14] = "Gerçek Toplam";
            xlWorkSheet.Cells[1, 15] = "Başarılı mı";

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int a = 0; a < dataGridView1.Columns.Count; a++)
                {
                    xlWorkSheet.Cells[i + 2, a + 1] = dataGridView1.Rows[i].Cells[a].Value;
                }
            }
            saveFileDialog1.Title = "Select File.";
            saveFileDialog1.Filter = "Excel Sheet (*.xls)|*.xls|All Files(*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                xlWorkBook.SaveAs(saveFileDialog1.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            }
        }
    }
}
