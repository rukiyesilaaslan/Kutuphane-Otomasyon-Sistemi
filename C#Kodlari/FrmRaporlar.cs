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
    public partial class FrmRaporlar : Form
    {
        string cs = @"Data Source=.\SQLEXPRESS;Initial Catalog=KutuphaneDB;Integrated Security=True;TrustServerCertificate=True";
        public FrmRaporlar()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FrmRaporlar_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT UyeID, Ad + ' ' + Soyad AS AdSoyad FROM UYE", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbUyeSecimi.DataSource = dt;
                cmbUyeSecimi.DisplayMember = "AdSoyad";
                cmbUyeSecimi.ValueMember = "UyeID";
                cmbUyeSecimi.SelectedIndex = -1; 
            }
        }

        private void btnRapor1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string sorgu = @"SELECT u.Ad + ' ' + u.Soyad AS Üye, k.KitapAdi, o.OduncTarihi, o.SonTeslimTarihi,
                         CASE WHEN o.IadeTarihi IS NULL THEN 'Teslim Edilmedi' ELSE 'Teslim Edildi' END AS Durum
                         FROM ODUNC o
                         JOIN UYE u ON o.UyeID = u.UyeID
                         JOIN KITAP k ON o.KitapID = k.KitapID
                         WHERE o.OduncTarihi BETWEEN @bas AND @bit";

                if (cmbUyeSecimi.SelectedValue != null)
                    sorgu += " AND o.UyeID = @uyeID";

                SqlCommand cmd = new SqlCommand(sorgu, con);
                cmd.Parameters.AddWithValue("@bas", dtpBas.Value.Date);
                cmd.Parameters.AddWithValue("@bit", dtpBit.Value.Date);
                if (cmbUyeSecimi.SelectedValue != null)
                    cmd.Parameters.AddWithValue("@uyeID", cmbUyeSecimi.SelectedValue);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRapor1.DataSource = dt;
            }
        }

        private void btnGecikenler_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string sorgu = @"SELECT u.Ad + ' ' + u.Soyad AS Üye, k.KitapAdi, o.OduncTarihi, o.SonTeslimTarihi,
                         DATEDIFF(DAY, o.SonTeslimTarihi, GETDATE()) AS GecikmeGunu
                         FROM ODUNC o
                         JOIN UYE u ON o.UyeID = u.UyeID
                         JOIN KITAP k ON o.KitapID = k.KitapID
                         WHERE o.IadeTarihi IS NULL AND o.SonTeslimTarihi < GETDATE()";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvGecikenler.DataSource = dt;
            }
        }

        private void btnEnCokOkunanlar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string sorgu = @"SELECT TOP 10 k.KitapAdi, COUNT(o.OduncID) AS [Ödünç Sayısı]
                         FROM ODUNC o
                         JOIN KITAP k ON o.KitapID = k.KitapID
                         GROUP BY k.KitapAdi
                         ORDER BY [Ödünç Sayısı] DESC";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvİstatistik.DataSource = dt;
            }
        }
    }
    }
