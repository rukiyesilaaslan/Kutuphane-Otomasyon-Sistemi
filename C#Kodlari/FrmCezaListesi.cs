using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class FrmCezaListesi : Form
    {
        string cs = @"Data Source=.\SQLEXPRESS;Initial Catalog=KutuphaneDB;Integrated Security=True;TrustServerCertificate=True";
        public FrmCezaListesi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmCezaListesi_Load(object sender, EventArgs e)
        {
            dtpBaşlangıc.Value = DateTime.Now.AddMonths(-1); 
            dtpBitiş.Value = DateTime.Now;
            CezalariListele();
        }

        private void txtUyeAra_TextChanged(object sender, EventArgs e)
        {
            CezalariListele();
        }

        private void dtpBaşlangıc_ValueChanged(object sender, EventArgs e)
        {
            CezalariListele();
        }

        private void dtpBitiş_ValueChanged(object sender, EventArgs e)
        {
            CezalariListele();
        }

        private void dgvCezalar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCezalar.CurrentRow != null)
            {
                string detay = dgvCezalar.CurrentRow.Cells["Açıklama"].Value.ToString();
                MessageBox.Show("Ceza Detayı: " + detay, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void CezalariListele()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    string sorgu = @"SELECT c.CezaID, (u.Ad + ' ' + u.Soyad) AS Üye, 
                             c.CezaTutari AS CezaMiktari, 
                             c.Aciklama AS Açıklama, o.IadeTarihi AS [Teslim Tarihi]
                             FROM CEZA c 
                             JOIN UYE u ON c.UyeID = u.UyeID 
                             JOIN ODUNC o ON c.OduncID = o.OduncID
                             WHERE (u.Ad LIKE @uye OR u.Soyad LIKE @uye) 
                             AND o.IadeTarihi BETWEEN @bas AND @bit";

                    SqlCommand cmd = new SqlCommand(sorgu, con);
                    cmd.Parameters.AddWithValue("@uye", "%" + txtUyeAra.Text + "%");
                    cmd.Parameters.AddWithValue("@bas", dtpBaşlangıc.Value.Date);
                    cmd.Parameters.AddWithValue("@bit", dtpBitiş.Value.Date);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvCezalar.DataSource = dt;

                    decimal toplam = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        toplam += Convert.ToDecimal(row["CezaMiktari"]);
                    }

                    lblToplamBorc.Text = "Toplam Borç: " + toplam.ToString("C2");
                    lblToplamBorc.ForeColor = toplam > 0 ? Color.Red : Color.Green;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblToplamBorc_Click(object sender, EventArgs e)
        {

        }
    }
}

