using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void lblBaslık_Click(object sender, EventArgs e)
        {

        }

        private void btnUyeYonetimi_Click(object sender, EventArgs e)
        {
            FrmUyeYonetimi frm = new FrmUyeYonetimi();
            frm.ShowDialog();

        }

        private void btnKitapYonetimi_Click_1(object sender, EventArgs e)
        {
            FrmKitapYonetimi frm = new FrmKitapYonetimi();
            frm.Show();

        }
        private void btnKitapTeslimİşlemleri_Click(object sender, EventArgs e)
        {
            FrmKitapTeslimİşlemleri frm = new FrmKitapTeslimİşlemleri();
            frm.Show();
        }

        private void btnCezaGoruntuleme_Click(object sender, EventArgs e)
        {
            FrmCezaListesi frm = new FrmCezaListesi();
            frm.Show();
        }
        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            FrmRaporlar frm = new FrmRaporlar();
            frm.Show();
        }
        private void btnDinamikSorgu_Click(object sender, EventArgs e)
        {
            FrmDinamikSorgu frm = new FrmDinamikSorgu();
            frm.Show();
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDinamikSorgu_Click_1(object sender, EventArgs e)
        {
            FrmDinamikSorgu frm = new FrmDinamikSorgu();
            frm.Show();

        }

        private void btnOduncIslemleri_Click(object sender, EventArgs e)
        {
            FrmOduncIslemleri frm = new FrmOduncIslemleri();
            frm.Show();
        }

        private void btnKitapTeslimAl_Click_1(object sender, EventArgs e)
        {
            FrmKitapTeslimİşlemleri frm = new FrmKitapTeslimİşlemleri();
            frm.Show();
        }

        private void btnKitapTeslim_Click(object sender, EventArgs e)
        {
            FrmKitapTeslimİşlemleri frm = new FrmKitapTeslimİşlemleri();
            frm.Show(); 
        }

        private void btnCezaGoruntuleme_Click_1(object sender, EventArgs e)
        {
            FrmCezaListesi frm = new FrmCezaListesi();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void btnRaporlar_Click_1(object sender, EventArgs e)
        {
            FrmRaporlar frm = new FrmRaporlar();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void btnCikis_Click_1(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Programdan çıkmak istediğinize emin misiniz?",
                                           "Çıkış Onayı",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);

            if (secenek == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
