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
    public partial class FrmOduncIslemleri : Form
    {
        string cs = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=KutuphaneDB;Integrated Security=True";
        public FrmOduncIslemleri()
        {
            InitializeComponent();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void UyeleriGetir()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT UyeID, Ad, Soyad, TCNo FROM UYE", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUyeler.DataSource = dt;
                dgvUyeler.Columns["UyeID"].Visible = false;
            }
        }

        private void KitaplariGetir()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT KitapID, KitapAdi, Yazar, MevcutAdet FROM KITAP", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKitaplar.DataSource = dt;
                dgvKitaplar.Columns["KitapID"].Visible = false;
            }
        }

        private void FrmOduncIslemleri_Load(object sender, EventArgs e)
        {
            UyeleriGetir();
            KitaplariGetir();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvKitaplar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKitaplar.CurrentRow != null)
            {
                string stok = dgvKitaplar.CurrentRow.Cells["MevcutAdet"].Value.ToString();
                lblStok.Text = "Mevcut Stok: " + stok;
            }
        }

        private void dgvUyeler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUyeler.CurrentRow != null)
            {
                int uyeID = Convert.ToInt32(dgvUyeler.CurrentRow.Cells["UyeID"].Value);
                AktifOduncleriGetir(uyeID);
            }
        }
        private void AktifOduncleriGetir(int uyeID)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string sorgu = @"SELECT o.OduncID, k.KitapAdi, o.OduncTarihi, o.SonTeslimTarihi 
                         FROM ODUNC o 
                         JOIN KITAP k ON o.KitapID = k.KitapID 
                         WHERE o.UyeID = @id AND o.IadeTarihi IS NULL";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, con);
                da.SelectCommand.Parameters.AddWithValue("@id", uyeID);
                DataTable dt = new DataTable();

                try
                {
                    da.Fill(dt);
                    dgvAktifOduncler.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sütun İsim Hatası: " + ex.Message);
                }
            }
        }
        private void txtUyeAra_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string sorgu = "SELECT UyeID, Ad, Soyad FROM UYE WHERE Ad LIKE @p1 OR Soyad LIKE @p1";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, con);
                da.SelectCommand.Parameters.AddWithValue("@p1", "%" + txtUyeAra.Text + "%");
                DataTable dt = new DataTable();
                da.Fill(dt); 
                dgvUyeler.DataSource = dt;
            }
        }

        private void txtKitapAra_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string sorgu = "SELECT KitapID, KitapAdi, Yazar, MevcutAdet FROM KITAP WHERE KitapAdi LIKE @p1 OR Yazar LIKE @p1";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, con);
                da.SelectCommand.Parameters.AddWithValue("@p1", "%" + txtKitapAra.Text + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKitaplar.DataSource = dt;
            }
        }
        private void btnOduncVer_Click(object sender, EventArgs e)
        {
            if (dgvUyeler.CurrentRow == null || dgvKitaplar.CurrentRow == null)
            {
                MessageBox.Show("Lütfen önce bir üye ve bir kitap seçin!");
                return;
            }

            int uyeID = Convert.ToInt32(dgvUyeler.CurrentRow.Cells["UyeID"].Value);
            int kitapID = Convert.ToInt32(dgvKitaplar.CurrentRow.Cells["KitapID"].Value);
            int kullaniciID = 1; 

            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand("sp_YeniOduncVer", con);
                    cmd.CommandType = CommandType.StoredProcedure; 

                    cmd.Parameters.AddWithValue("@UyeID", uyeID);
                    cmd.Parameters.AddWithValue("@KitapID", kitapID);
                    cmd.Parameters.AddWithValue("@IslemYapanKullaniciID", kullaniciID);
                    con.Open();
                    cmd.ExecuteNonQuery(); 

                    MessageBox.Show("Kitap başarıyla ödünç verildi.");

                    KitaplariGetir();
                    AktifOduncleriGetir(uyeID);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "İşlem Reddedildi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dgvKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKitaplar.CurrentRow != null)
            {
                string stok = dgvKitaplar.CurrentRow.Cells["MevcutAdet"].Value.ToString();
                lblStok.Text = "Mevcut Stok: " + stok;
            }
        }

        private void dgvAktifOduncler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblÜyeAra_Click(object sender, EventArgs e)
        {

        }

        private void lblStok_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvKitaplar_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            lblStok.Text = dgvKitaplar.CurrentRow.Cells["MevcutAdet"].Value.ToString();
        }

        private void lblUyeAra_Click(object sender, EventArgs e)
        {

        }

        private void dgvUyeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUyeler.CurrentRow != null)
            {
                int seciliUyeID = Convert.ToInt32(dgvUyeler.CurrentRow.Cells["UyeID"].Value);

                AktifOduncleriGetir(seciliUyeID);
            }
        }
    }
}
