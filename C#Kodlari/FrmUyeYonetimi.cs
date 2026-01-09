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


namespace KutuphaneOtomasyonu
{
    public partial class FrmUyeYonetimi : Form
    {
        string cs = @"Server=.\SQLEXPRESS;Database=KutuphaneDB;Trusted_Connection=True;";

        public FrmUyeYonetimi()
        {
            InitializeComponent();
        }

        private void FrmUyeYonetimi_Load(object sender, EventArgs e)
        {
            UyeleriGetir();

        }

        private void dgvUyeler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtSoyad.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Ad, Soyad ve Email alanları zorunludur.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand(
                        @"INSERT INTO UYE 
                  (Ad, Soyad, TCNo, Telefon, Email, ToplamBorc)
                  VALUES 
                  (@ad, @soyad, @tc, @tel, @mail, @borc)", con);

                    cmd.Parameters.AddWithValue("@ad", txtAd.Text);
                    cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                    cmd.Parameters.AddWithValue("@tc", txtTCNo.Text);
                    cmd.Parameters.AddWithValue("@tel", txtTelefon.Text);
                    cmd.Parameters.AddWithValue("@mail", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@borc", 0);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }


                MessageBox.Show("Yeni üye başarıyla eklendi.");
                UyeleriGetir();     
                TextBoxTemizle();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "SQL Hatası");
            }

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (dgvUyeler.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellenecek üyeyi seçiniz.");
                return;
            }

            if (txtAd.Text == "" || txtSoyad.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Ad, Soyad ve Email alanları zorunludur.");
                return;
            }

            int uyeID = Convert.ToInt32(
                dgvUyeler.CurrentRow.Cells["UyeID"].Value);

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(
                    @"UPDATE UYE
              SET Ad = @ad,
                  Soyad = @soyad,
                  TCNo = @tc,
                  Telefon = @tel,
                  Email = @mail
              WHERE UyeID = @id", con);

                cmd.Parameters.AddWithValue("@ad", txtAd.Text);
                cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                cmd.Parameters.AddWithValue("@tc", txtTCNo.Text);
                cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = txtTelefon.Text;
                cmd.Parameters.AddWithValue("@mail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@id", uyeID);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Üye bilgileri güncellendi.");
            UyeleriGetir();
            TextBoxTemizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvUyeler.CurrentRow == null) return;

            decimal toplamBorc = Convert.ToDecimal(dgvUyeler.CurrentRow.Cells["ToplamBorc"].Value);
            if (toplamBorc > 0)
            {
                MessageBox.Show("Üyenin borcu bulunmaktadır. Borç ödenmeden üye silinemez!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    int uyeID = Convert.ToInt32(dgvUyeler.CurrentRow.Cells["UyeID"].Value);
                    SqlCommand cmd = new SqlCommand("DELETE FROM UYE WHERE UyeID=@id", con);
                    cmd.Parameters.AddWithValue("@id", uyeID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Üye başarıyla silindi.");
                    UyeleriGetir(); 
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Üyenin aktif ödüncü olduğu için silinemez.", "Silme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtTCNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        void UyeleriGetir()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string sorgu = @"SELECT UyeID, Ad, Soyad, TCNo, Telefon, Email, 
                         ISNULL((SELECT SUM(CezaTutari) FROM CEZA WHERE UyeID = UYE.UyeID), 0) AS ToplamBorc 
                         FROM UYE";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUyeler.DataSource = dt;


                dgvUyeler.Columns["ToplamBorc"].DefaultCellStyle.Format = "C2";
            }
        }
        void TextBoxTemizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtTCNo.Clear(); 
            txtTelefon.Clear();
            txtEmail.Clear();
        }
        private void lblAd_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void lblTelefon_Click(object sender, EventArgs e)
        {
        }
        private void lblEmail_Click(object sender, EventArgs e)
        {
        }
        private void txtAd_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
        }

        private void dgvUyeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtAd.Text = dgvUyeler.Rows[e.RowIndex].Cells["Ad"].Value.ToString();
                txtSoyad.Text = dgvUyeler.Rows[e.RowIndex].Cells["Soyad"].Value.ToString();
                txtTCNo.Text = dgvUyeler.Rows[e.RowIndex].Cells["TCNo"].Value.ToString();
                txtTelefon.Text = dgvUyeler.Rows[e.RowIndex].Cells["Telefon"].Value.ToString();
                txtEmail.Text = dgvUyeler.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            }
        }

        private void txtUyeAra_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string sorgu = @"SELECT UyeID, Ad, Soyad, TCNo, Telefon, Email, 
                         ISNULL((SELECT SUM(CezaTutari) FROM CEZA WHERE UyeID = UYE.UyeID), 0) AS ToplamBorc 
                         FROM UYE 
                         WHERE Ad LIKE @arama OR Soyad LIKE @arama OR Email LIKE @arama";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, con);
                da.SelectCommand.Parameters.AddWithValue("@arama", "%" + txtUyeAra.Text + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUyeler.DataSource = dt;
            }
        }

        private void btnUyeOzet_Click(object sender, EventArgs e)
        {
            if (dgvUyeler.CurrentRow == null)
            {
                MessageBox.Show("Lütfen önce listeden bir üye seçin!");
                return;
            }


            int seciliUyeID = Convert.ToInt32(dgvUyeler.CurrentRow.Cells["UyeID"].Value);

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("sp_UyeOzetRapor", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UyeID", seciliUyeID);

                try
                {
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        string ad = dr["Ad"].ToString();
                        string soyad = dr["Soyad"].ToString();
                        string toplamKitap = dr["ToplamAldigiKitapSayisi"].ToString();
                        string eldekiKitap = dr["IadeEdilmemisKitapSayisi"].ToString();
                        decimal ceza = Convert.ToDecimal(dr["ToplamCezaTutari"]);


                        string mesaj = $"--- {ad} {soyad} Özet Raporu ---\n\n" +
                                       $"Toplam Aldığı Kitap: {toplamKitap}\n" +
                                       $"Şu An Elindeki Kitap: {eldekiKitap}\n" +
                                       $"Toplam Ceza Borcu: {ceza.ToString("C2")}";

                        MessageBox.Show(mesaj, "Üye Durum Özeti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Rapor çekilirken hata oluştu: " + ex.Message);
                }
            }
        }
        }
    }
