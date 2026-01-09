namespace KutuphaneOtomasyonu
{
    partial class FrmKitapYonetimi
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
            this.lblAlan = new System.Windows.Forms.Label();
            this.lblAlanName = new System.Windows.Forms.Label();
            this.lblKitapAdi = new System.Windows.Forms.Label();
            this.lblYazar = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblYayınEvi = new System.Windows.Forms.Label();
            this.lblBasımYılı = new System.Windows.Forms.Label();
            this.lblToplamAdet = new System.Windows.Forms.Label();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.txtYayinevi = new System.Windows.Forms.TextBox();
            this.txtBasimYili = new System.Windows.Forms.TextBox();
            this.txtToplamAdet = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dgvKitaplar = new System.Windows.Forms.DataGridView();
            this.lblKitapAra = new System.Windows.Forms.Label();
            this.txtKitapAra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAlan
            // 
            this.lblAlan.AutoSize = true;
            this.lblAlan.Location = new System.Drawing.Point(114, 9);
            this.lblAlan.Name = "lblAlan";
            this.lblAlan.Size = new System.Drawing.Size(34, 16);
            this.lblAlan.TabIndex = 0;
            this.lblAlan.Text = "Alan";
            this.lblAlan.Click += new System.EventHandler(this.lblAlan_Click);
            // 
            // lblAlanName
            // 
            this.lblAlanName.AutoSize = true;
            this.lblAlanName.Location = new System.Drawing.Point(253, 9);
            this.lblAlanName.Name = "lblAlanName";
            this.lblAlanName.Size = new System.Drawing.Size(44, 16);
            this.lblAlanName.TabIndex = 1;
            this.lblAlanName.Text = "Name";
            // 
            // lblKitapAdi
            // 
            this.lblKitapAdi.AutoSize = true;
            this.lblKitapAdi.Location = new System.Drawing.Point(117, 45);
            this.lblKitapAdi.Name = "lblKitapAdi";
            this.lblKitapAdi.Size = new System.Drawing.Size(60, 16);
            this.lblKitapAdi.TabIndex = 3;
            this.lblKitapAdi.Text = "Kitap Adı";
            // 
            // lblYazar
            // 
            this.lblYazar.AutoSize = true;
            this.lblYazar.Location = new System.Drawing.Point(117, 83);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(42, 16);
            this.lblYazar.TabIndex = 4;
            this.lblYazar.Text = "Yazar";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(114, 125);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(57, 16);
            this.lblKategori.TabIndex = 5;
            this.lblKategori.Text = "Kategori";
            // 
            // lblYayınEvi
            // 
            this.lblYayınEvi.AutoSize = true;
            this.lblYayınEvi.Location = new System.Drawing.Point(114, 168);
            this.lblYayınEvi.Name = "lblYayınEvi";
            this.lblYayınEvi.Size = new System.Drawing.Size(63, 16);
            this.lblYayınEvi.TabIndex = 6;
            this.lblYayınEvi.Text = "Yayın Evi";
            // 
            // lblBasımYılı
            // 
            this.lblBasımYılı.AutoSize = true;
            this.lblBasımYılı.Location = new System.Drawing.Point(111, 212);
            this.lblBasımYılı.Name = "lblBasımYılı";
            this.lblBasımYılı.Size = new System.Drawing.Size(62, 16);
            this.lblBasımYılı.TabIndex = 7;
            this.lblBasımYılı.Text = "Yayın Yılı";
            // 
            // lblToplamAdet
            // 
            this.lblToplamAdet.AutoSize = true;
            this.lblToplamAdet.Location = new System.Drawing.Point(114, 256);
            this.lblToplamAdet.Name = "lblToplamAdet";
            this.lblToplamAdet.Size = new System.Drawing.Size(85, 16);
            this.lblToplamAdet.TabIndex = 8;
            this.lblToplamAdet.Text = "Toplam Adet";
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(241, 42);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(121, 22);
            this.txtKitapAdi.TabIndex = 9;
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(241, 83);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(121, 22);
            this.txtYazar.TabIndex = 10;
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(241, 117);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(121, 24);
            this.cmbKategori.TabIndex = 11;
            // 
            // txtYayinevi
            // 
            this.txtYayinevi.Location = new System.Drawing.Point(241, 162);
            this.txtYayinevi.Name = "txtYayinevi";
            this.txtYayinevi.Size = new System.Drawing.Size(121, 22);
            this.txtYayinevi.TabIndex = 12;
            // 
            // txtBasimYili
            // 
            this.txtBasimYili.Location = new System.Drawing.Point(241, 206);
            this.txtBasimYili.MaxLength = 4;
            this.txtBasimYili.Name = "txtBasimYili";
            this.txtBasimYili.Size = new System.Drawing.Size(121, 22);
            this.txtBasimYili.TabIndex = 13;
            // 
            // txtToplamAdet
            // 
            this.txtToplamAdet.Location = new System.Drawing.Point(241, 250);
            this.txtToplamAdet.MaxLength = 5;
            this.txtToplamAdet.Name = "txtToplamAdet";
            this.txtToplamAdet.Size = new System.Drawing.Size(121, 22);
            this.txtToplamAdet.TabIndex = 14;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(573, 57);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 15;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(573, 101);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGüncelle.TabIndex = 16;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(573, 148);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 17;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dgvKitaplar
            // 
            this.dgvKitaplar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitaplar.Location = new System.Drawing.Point(0, 296);
            this.dgvKitaplar.Name = "dgvKitaplar";
            this.dgvKitaplar.RowHeadersWidth = 51;
            this.dgvKitaplar.RowTemplate.Height = 24;
            this.dgvKitaplar.Size = new System.Drawing.Size(800, 154);
            this.dgvKitaplar.TabIndex = 18;
            this.dgvKitaplar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKitaplar_CellClick);
            // 
            // lblKitapAra
            // 
            this.lblKitapAra.AutoSize = true;
            this.lblKitapAra.Location = new System.Drawing.Point(484, 212);
            this.lblKitapAra.Name = "lblKitapAra";
            this.lblKitapAra.Size = new System.Drawing.Size(61, 16);
            this.lblKitapAra.TabIndex = 19;
            this.lblKitapAra.Text = "Kitap Ara";
            // 
            // txtKitapAra
            // 
            this.txtKitapAra.Location = new System.Drawing.Point(573, 212);
            this.txtKitapAra.Name = "txtKitapAra";
            this.txtKitapAra.Size = new System.Drawing.Size(196, 22);
            this.txtKitapAra.TabIndex = 20;
            this.txtKitapAra.TextChanged += new System.EventHandler(this.txtKitapAra_TextChanged);
            // 
            // FrmKitapYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKitapAra);
            this.Controls.Add(this.lblKitapAra);
            this.Controls.Add(this.dgvKitaplar);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtToplamAdet);
            this.Controls.Add(this.txtBasimYili);
            this.Controls.Add(this.txtYayinevi);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.lblToplamAdet);
            this.Controls.Add(this.lblBasımYılı);
            this.Controls.Add(this.lblYayınEvi);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.lblYazar);
            this.Controls.Add(this.lblKitapAdi);
            this.Controls.Add(this.lblAlanName);
            this.Controls.Add(this.lblAlan);
            this.Name = "FrmKitapYonetimi";
            this.Text = "Kitap Yönetimi";
            this.Load += new System.EventHandler(this.FrmKitapYonetimi_Load);
            this.Click += new System.EventHandler(this.FrmKitapYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlan;
        private System.Windows.Forms.Label lblAlanName;
        private System.Windows.Forms.Label lblKitapAdi;
        private System.Windows.Forms.Label lblYazar;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblYayınEvi;
        private System.Windows.Forms.Label lblBasımYılı;
        private System.Windows.Forms.Label lblToplamAdet;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.TextBox txtYayinevi;
        private System.Windows.Forms.TextBox txtBasimYili;
        private System.Windows.Forms.TextBox txtToplamAdet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dgvKitaplar;
        private System.Windows.Forms.Label lblKitapAra;
        private System.Windows.Forms.TextBox txtKitapAra;
    }
}