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
using System.Configuration;



namespace KutuphaneOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string cs = @"Server=.\SQLEXPRESS;Database=KutuphaneDB;Trusted_Connection=True;";

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT KullaniciID, Rol FROM KULLANICI WHERE KullaniciAdi=@k AND Sifre=@s", con);

                cmd.Parameters.AddWithValue("@k", txtKullaniciAdi.Text);
                cmd.Parameters.AddWithValue("@s", txtSifre.Text);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Giriş başarılı");
                    FrmMainMenu frm = new FrmMainMenu();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                }
            }


        }
    }
}
