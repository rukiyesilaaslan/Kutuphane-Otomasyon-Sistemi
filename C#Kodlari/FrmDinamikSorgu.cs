using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class FrmDinamikSorgu : Form
    {
        string cs = @"Data Source=.\SQLEXPRESS;Initial Catalog=KutuphaneDB;Integrated Security=True;TrustServerCertificate=True";
        public FrmDinamikSorgu()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmDinamikSorgu_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT KategoriID, KategoriAdi FROM KATEGORI", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbKategori.DataSource = dt;
                cmbKategori.DisplayMember = "KategoriAdi";
                cmbKategori.ValueMember = "KategoriID";
                cmbKategori.SelectedIndex = -1; 
            }
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT KitapID, KitapAdi, Yazar, YayinYili, MevcutAdet FROM KITAP WHERE 1=1";

            using (SqlCommand cmd = new SqlCommand())
            {
                if (!string.IsNullOrWhiteSpace(txtKitapAdi.Text))
                {
                    sorgu += " AND KitapAdi LIKE @kitap";
                    cmd.Parameters.AddWithValue("@kitap", "%" + txtKitapAdi.Text + "%");
                }

                if (!string.IsNullOrWhiteSpace(txtYazar.Text))
                {
                    sorgu += " AND Yazar LIKE @yazar";
                    cmd.Parameters.AddWithValue("@yazar", "%" + txtYazar.Text + "%");
                }

                if (cmbKategori.SelectedIndex != -1)
                {
                    sorgu += " AND KategoriID = @katID";
                    cmd.Parameters.AddWithValue("@katID", cmbKategori.SelectedValue);
                }

                if (numMinYil.Value > 0)
                {
                    sorgu += " AND YayinYili >= @minYil";
                    cmd.Parameters.AddWithValue("@minYil", numMinYil.Value);
                }
                if (numMaxYil.Value > 0)
                {
                    sorgu += " AND YayinYili <= @maxYil";
                    cmd.Parameters.AddWithValue("@maxYil", numMaxYil.Value);
                }

                if (chkSadeceMevcutlar.Checked)
                {
                    sorgu += " AND MevcutAdet > 0";
                }

                if (cmbSirala.SelectedIndex != -1)
                {
                    sorgu += " ORDER BY " + cmbSirala.Text;
                }

                using (SqlConnection con = new SqlConnection(cs))
                {
                    cmd.CommandText = sorgu;
                    cmd.Connection = con;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvSonuclar.DataSource = dt;
                }
            }
            }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "CSV Dosyası|*.csv";
            if (save.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(save.FileName, false, Encoding.UTF8))
                {
                    sw.WriteLine("Kitap ID;Kitap Adi;Yazar;YayinYili;Stok");
                    foreach (DataGridViewRow row in dgvSonuclar.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            sw.WriteLine($"{row.Cells[0].Value};{row.Cells[1].Value};{row.Cells[2].Value};{row.Cells[3].Value};{row.Cells[4].Value}");
                        }
                    }
                }
                MessageBox.Show("Excel raporu hazır!");
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PDF Dosyası|*.pdf"; 
            save.FileName = "Kitap_Raporu.pdf";

            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string htmlContent = "<html><body style='font-family:Arial;'><h2>Kitap Raporu</h2><table border='1' width='100%'>" +
                                         "<tr><th>Kitap Adı</th><th>Yazar</th><th>Yayın Yılı</th></tr>";

                    foreach (DataGridViewRow row in dgvSonuclar.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            htmlContent += $"<tr><td>{row.Cells["KitapAdi"].Value}</td>" +
                                           $"<td>{row.Cells["Yazar"].Value}</td>" +
                                           $"<td>{row.Cells["YayinYili"].Value}</td></tr>";
                        }
                    }
                    htmlContent += "</table></body></html>";

                    WebBrowser wb = new WebBrowser();
                    wb.DocumentText = htmlContent;
                    wb.DocumentCompleted += (s, ev) =>
                    {
                        wb.Print();
                        MessageBox.Show("PDF oluşturma işlemi başlatıldı. Lütfen 'Microsoft Print to PDF' seçeneğiyle kaydedin.");
                    };
                }
                catch (Exception ex)
                {
                    MessageBox.Show("PDF oluşturulurken bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void txtkitapAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtYazar_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numMinYil_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numMaxYil_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvSonuclar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
