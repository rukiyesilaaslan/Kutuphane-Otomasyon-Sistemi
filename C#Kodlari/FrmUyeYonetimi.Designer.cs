namespace KutuphaneOtomasyonu
{
    partial class FrmUyeYonetimi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvUyeler = new System.Windows.Forms.DataGridView();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblTCNo = new System.Windows.Forms.Label();
            this.txtTCNo = new System.Windows.Forms.TextBox();
            this.lblUyeAra = new System.Windows.Forms.Label();
            this.txtUyeAra = new System.Windows.Forms.TextBox();
            this.btnUyeOzet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUyeler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUyeler
            // 
            this.dgvUyeler.AllowUserToAddRows = false;
            this.dgvUyeler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUyeler.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvUyeler.Location = new System.Drawing.Point(0, 0);
            this.dgvUyeler.MultiSelect = false;
            this.dgvUyeler.Name = "dgvUyeler";
            this.dgvUyeler.ReadOnly = true;
            this.dgvUyeler.RowHeadersWidth = 51;
            this.dgvUyeler.RowTemplate.Height = 24;
            this.dgvUyeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUyeler.Size = new System.Drawing.Size(800, 200);
            this.dgvUyeler.TabIndex = 0;
            this.dgvUyeler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUyeler_CellClick);
            this.dgvUyeler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUyeler_CellContentClick);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(47, 217);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(27, 16);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "Ad:";
            this.lblAd.Click += new System.EventHandler(this.lblAd_Click);
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(47, 248);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(50, 16);
            this.lblSoyad.TabIndex = 2;
            this.lblSoyad.Text = "Soyad:";
            this.lblSoyad.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(47, 321);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(56, 16);
            this.lblTelefon.TabIndex = 3;
            this.lblTelefon.Text = "Telefon:";
            this.lblTelefon.Click += new System.EventHandler(this.lblTelefon_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(47, 352);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(166, 211);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 5;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(166, 242);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtSoyad.TabIndex = 6;
            this.txtSoyad.TextChanged += new System.EventHandler(this.txtSoyad_TextChanged);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(166, 318);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 22);
            this.txtTelefon.TabIndex = 7;
            this.txtTelefon.TextChanged += new System.EventHandler(this.txtTelefon_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(166, 352);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(371, 217);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(110, 23);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Yeni Üye Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(371, 264);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(110, 23);
            this.btnGüncelle.TabIndex = 10;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(371, 314);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(110, 23);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblTCNo
            // 
            this.lblTCNo.AutoSize = true;
            this.lblTCNo.Location = new System.Drawing.Point(47, 283);
            this.lblTCNo.Name = "lblTCNo";
            this.lblTCNo.Size = new System.Drawing.Size(43, 16);
            this.lblTCNo.TabIndex = 12;
            this.lblTCNo.Text = "TCNo";
            // 
            // txtTCNo
            // 
            this.txtTCNo.Location = new System.Drawing.Point(166, 277);
            this.txtTCNo.MaxLength = 11;
            this.txtTCNo.Name = "txtTCNo";
            this.txtTCNo.Size = new System.Drawing.Size(100, 22);
            this.txtTCNo.TabIndex = 13;
            // 
            // lblUyeAra
            // 
            this.lblUyeAra.AutoSize = true;
            this.lblUyeAra.Location = new System.Drawing.Point(371, 358);
            this.lblUyeAra.Name = "lblUyeAra";
            this.lblUyeAra.Size = new System.Drawing.Size(59, 16);
            this.lblUyeAra.TabIndex = 14;
            this.lblUyeAra.Text = "Üye Ara:";
            // 
            // txtUyeAra
            // 
            this.txtUyeAra.Location = new System.Drawing.Point(436, 355);
            this.txtUyeAra.Name = "txtUyeAra";
            this.txtUyeAra.Size = new System.Drawing.Size(195, 22);
            this.txtUyeAra.TabIndex = 15;
            this.txtUyeAra.TextChanged += new System.EventHandler(this.txtUyeAra_TextChanged);
            // 
            // btnUyeOzet
            // 
            this.btnUyeOzet.Location = new System.Drawing.Point(386, 397);
            this.btnUyeOzet.Name = "btnUyeOzet";
            this.btnUyeOzet.Size = new System.Drawing.Size(156, 31);
            this.btnUyeOzet.TabIndex = 16;
            this.btnUyeOzet.Text = "Durum Özeti";
            this.btnUyeOzet.UseVisualStyleBackColor = true;
            this.btnUyeOzet.Click += new System.EventHandler(this.btnUyeOzet_Click);
            // 
            // FrmUyeYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUyeOzet);
            this.Controls.Add(this.txtUyeAra);
            this.Controls.Add(this.lblUyeAra);
            this.Controls.Add(this.txtTCNo);
            this.Controls.Add(this.lblTCNo);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.dgvUyeler);
            this.Name = "FrmUyeYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye Yönetimi";
            this.Load += new System.EventHandler(this.FrmUyeYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUyeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUyeler;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblTCNo;
        private System.Windows.Forms.TextBox txtTCNo;
        private System.Windows.Forms.Label lblUyeAra;
        private System.Windows.Forms.TextBox txtUyeAra;
        private System.Windows.Forms.Button btnUyeOzet;
    }
}