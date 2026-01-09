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
    public partial class FrmKitapTeslimİşlemleri : Form
    {
        string cs = @"Data Source=.\SQLEXPRESS;Initial Catalog=KutuphaneDB;Integrated Security=True;TrustServerCertificate=True";
        public FrmKitapTeslimİşlemleri()
        {
            InitializeComponent();
        }

        private void FrmKitapTeslimİşlemleri_Load(object sender, EventArgs e)
        {
            AktifListeyiGetir();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            AktifListeyiGetir();
        }
        void AktifListeyiGetir()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string sorgu = @"SELECT o.OduncID, (u.Ad + ' ' + u.Soyad) AS UyeAdSoyad, k.KitapAdi, o.OduncTarihi, o.SonTeslimTarihi 
                 FROM ODUNC o 
                 JOIN KITAP k ON o.KitapID = k.KitapID 
                 JOIN UYE u ON o.UyeID = u.UyeID 
                 WHERE o.IadeTarihi IS NULL AND k.KitapAdi LIKE @arama";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, con);
                da.SelectCommand.Parameters.AddWithValue("@arama", "%" + txtAra.Text + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAktifOduncler.DataSource = dt;
            }
        }

        private void dgvAktifOduncler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAktifOduncler.CurrentRow != null)
            {

                lblKitapAd.Text = "Seçili Kitap: " + dgvAktifOduncler.CurrentRow.Cells["KitapAdi"].Value.ToString();
                lblOduncTarihi.Text = "Ödünç Tarihi: " + dgvAktifOduncler.CurrentRow.Cells["OduncTarihi"].Value.ToString();
                lblSonTeslimTarihi.Text = dgvAktifOduncler.CurrentRow.Cells["SonTeslimTarihi"].Value.ToString();

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnTeslimAl_Click(object sender, EventArgs e)
        {
            if (dgvAktifOduncler.CurrentRow == null) return;

            int oduncID = Convert.ToInt32(dgvAktifOduncler.CurrentRow.Cells["OduncID"].Value);
            DateTime bugun = DateTime.Now;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("sp_KitapTeslimAl", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@OduncID", oduncID);
                cmd.Parameters.AddWithValue("@TeslimTarihi", bugun);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kitap iade alındı ve stok güncellendi!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
            AktifListeyiGetir(); 
        }

        private void dgvAktifOduncler_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAktifOduncler.CurrentRow != null)
            {
                lblKitapAd.Text = "Seçili Kitap: " + dgvAktifOduncler.CurrentRow.Cells["KitapAdi"].Value.ToString();
                lblOduncTarihi.Text = "Ödünç Tarihi: " + dgvAktifOduncler.CurrentRow.Cells["OduncTarihi"].Value.ToString();
                lblUyeAd.Text = "Seçili Üye: " + dgvAktifOduncler.CurrentRow.Cells["UyeAdSoyad"].Value.ToString();
                lblSonTeslimTarihi.Text = dgvAktifOduncler.CurrentRow.Cells["SonTeslimTarihi"].Value.ToString();
            }
        }
        private void lblKitapAd_Click(object sender, EventArgs e)
        {
            lblKitapAd.Text = "Kitap: " + dgvAktifOduncler.CurrentRow.Cells["KitapAdi"].Value.ToString();
        }

        private void lblUyeAd_Click(object sender, EventArgs e)
        {
            lblUyeAd.Text = "Seçili Üye: " + dgvAktifOduncler.CurrentRow.Cells["UyeAdSoyad"].Value.ToString();
        }
    }
}
