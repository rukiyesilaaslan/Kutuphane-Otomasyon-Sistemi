using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class FrmKitapYonetimi : Form
    {
        string cs = @"Server=.\SQLEXPRESS;Database=KutuphaneDB;Trusted_Connection=True;";
        public FrmKitapYonetimi()
        {
            InitializeComponent();
        }
        private void FrmKitapYonetimi_Load(object sender, EventArgs e)
        {
            KategorileriGetir();
            KitaplariGetir();
        }
        void KategorileriGetir()
        {
            try
            { 
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT KategoriID, KategoriAdi FROM KATEGORI", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbKategori.DisplayMember = "KategoriAdi";
                cmbKategori.ValueMember = "KategoriID";
                cmbKategori.DataSource = dt;

                cmbKategori.SelectedIndex = -1;
            }
        }
            catch (Exception ex)
            {
                MessageBox.Show("Kategori sayısı: " + cmbKategori.Items.Count);
            }
        }
        void KitaplariGetir()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    
                    SqlDataAdapter da = new SqlDataAdapter(
                     @"SELECT 
                k.KitapID, 
                k.KitapAdi, 
                k.Yazar, 
                kt.KategoriAdi, 
                k.YayinYili, -- SQL'deki adıyla YayinYili
                k.Yayinevi,  -- Şimdi SQL'e eklediğimiz sütun
                k.ToplamAdet, 
                k.MevcutAdet
              FROM KITAP k
              INNER JOIN KATEGORI kt ON k.KategoriID = kt.KategoriID", con);

                    DataTable dt = new DataTable();
                    da.Fill(dt); 
                    dgvKitaplar.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme Hatası: " + ex.Message);
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtKitapAdi.Text == "" || txtYazar.Text == "" || cmbKategori.SelectedIndex == -1)
            {
                MessageBox.Show("Kitap Adı, Yazar ve Kategori zorunludur.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    
                    SqlCommand cmd = new SqlCommand("sp_KitapEkle", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                   
                    cmd.Parameters.AddWithValue("@KitapAdi", txtKitapAdi.Text);
                    cmd.Parameters.AddWithValue("@Yazar", txtYazar.Text);
                    cmd.Parameters.AddWithValue("@YayinYili", txtBasimYili.Text);
                    cmd.Parameters.AddWithValue("@KategoriID", cmbKategori.SelectedValue);
                    cmd.Parameters.AddWithValue("@Yayinevi", txtYayinevi.Text);
                    cmd.Parameters.AddWithValue("@ToplamAdet", Convert.ToInt32(txtToplamAdet.Text));

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Kitap başarıyla eklendi.");
                KitaplariGetir(); 
                TextBoxTemizle(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
        private void dgvKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtKitapAdi.Text =
                dgvKitaplar.Rows[e.RowIndex].Cells["KitapAdi"].Value.ToString();

            txtYazar.Text =
                dgvKitaplar.Rows[e.RowIndex].Cells["Yazar"].Value.ToString();

            cmbKategori.Text =
                dgvKitaplar.Rows[e.RowIndex].Cells["KategoriAdi"].Value.ToString();

            txtYayinevi.Text =
                dgvKitaplar.Rows[e.RowIndex].Cells["Yayinevi"].Value.ToString();

            txtBasimYili.Text =
                dgvKitaplar.Rows[e.RowIndex].Cells["YayinYili"].Value.ToString();

            txtToplamAdet.Text =
                dgvKitaplar.Rows[e.RowIndex].Cells["ToplamAdet"].Value.ToString();
        }
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (dgvKitaplar.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellenecek kitabı seçin.");
                return;
            }

            int kitapID = Convert.ToInt32(dgvKitaplar.CurrentRow.Cells["KitapID"].Value);

            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    string query = @"UPDATE KITAP SET 
                             KitapAdi=@ad, 
                             Yazar=@yazar, 
                             KategoriID=@kat, 
                             YayinYili=@yil, 
                             Yayinevi=@yay, 
                             ToplamAdet=@toplam 
                             WHERE KitapID=@id";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@ad", txtKitapAdi.Text);
                    cmd.Parameters.AddWithValue("@yazar", txtYazar.Text);
                    cmd.Parameters.AddWithValue("@kat", cmbKategori.SelectedValue);
                    cmd.Parameters.AddWithValue("@yil", txtBasimYili.Text);
                    cmd.Parameters.AddWithValue("@yay", txtYayinevi.Text);
                    cmd.Parameters.AddWithValue("@toplam", txtToplamAdet.Text);
                    cmd.Parameters.AddWithValue("@id", kitapID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close(); 
                }

                MessageBox.Show("Kitap başarıyla güncellendi.");
                KitaplariGetir(); 
                TextBoxTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme Hatası: " + ex.Message);
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvKitaplar.CurrentRow == null)
            {
                MessageBox.Show("Satır seçili değil!"); 
                return;
            }

            int toplam = Convert.ToInt32(dgvKitaplar.CurrentRow.Cells["ToplamAdet"].Value);
            int mevcut = Convert.ToInt32(dgvKitaplar.CurrentRow.Cells["MevcutAdet"].Value);
            int kitapID = Convert.ToInt32(dgvKitaplar.CurrentRow.Cells["KitapID"].Value);

            if (mevcut < toplam)
            {
                MessageBox.Show("Kitap ödünçte olduğu için silinemez!");
                return;
            }

            MessageBox.Show("Silme aşamasına geçildi. ID: " + kitapID);

            if (MessageBox.Show("Kitabı silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(cs))
                    {
                        SqlCommand cmd = new SqlCommand("DELETE FROM KITAP WHERE KitapID=@id", con);
                        cmd.Parameters.AddWithValue("@id", kitapID);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kitap başarıyla silindi.");
                        KitaplariGetir();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message);
                }
            }
        }
        void TextBoxTemizle()
        {
            txtKitapAdi.Clear();
            txtYazar.Clear();
            txtYayinevi.Clear();
            txtBasimYili.Clear();
            txtToplamAdet.Clear();
            cmbKategori.SelectedIndex = -1;
        }
        
        private void lblAlan_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void txtKitapAra_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string sorgu = @"SELECT k.*, kt.KategoriAdi 
                         FROM KITAP k 
                         INNER JOIN KATEGORI kt ON k.KategoriID = kt.KategoriID
                         WHERE k.KitapAdi LIKE @ara 
                         OR k.Yazar LIKE @ara";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, con);
                da.SelectCommand.Parameters.AddWithValue("@ara", "%" + txtKitapAra.Text + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKitaplar.DataSource = dt;
            }
        }
    }
}
