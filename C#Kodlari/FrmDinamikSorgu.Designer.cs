namespace KutuphaneOtomasyonu
{
    partial class FrmDinamikSorgu
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
            this.lblKıtapAdı = new System.Windows.Forms.Label();
            this.lblYazarAdı = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.numMinYil = new System.Windows.Forms.NumericUpDown();
            this.chkSadeceMevcutlar = new System.Windows.Forms.CheckBox();
            this.cmbSirala = new System.Windows.Forms.ComboBox();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.dgvSonuclar = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblBasımYılıMin = new System.Windows.Forms.Label();
            this.lblSıralama = new System.Windows.Forms.Label();
            this.lblBasımYılıMax = new System.Windows.Forms.Label();
            this.numMaxYil = new System.Windows.Forms.NumericUpDown();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.btnPdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numMinYil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSonuclar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxYil)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKıtapAdı
            // 
            this.lblKıtapAdı.AutoSize = true;
            this.lblKıtapAdı.Location = new System.Drawing.Point(4, 39);
            this.lblKıtapAdı.Name = "lblKıtapAdı";
            this.lblKıtapAdı.Size = new System.Drawing.Size(63, 16);
            this.lblKıtapAdı.TabIndex = 0;
            this.lblKıtapAdı.Text = "Kitap Adı:";
            // 
            // lblYazarAdı
            // 
            this.lblYazarAdı.AutoSize = true;
            this.lblYazarAdı.Location = new System.Drawing.Point(244, 39);
            this.lblYazarAdı.Name = "lblYazarAdı";
            this.lblYazarAdı.Size = new System.Drawing.Size(68, 16);
            this.lblYazarAdı.TabIndex = 2;
            this.lblYazarAdı.Text = "Yazar Adı:";
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(586, 31);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(153, 24);
            this.cmbKategori.TabIndex = 4;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // numMinYil
            // 
            this.numMinYil.Location = new System.Drawing.Point(127, 93);
            this.numMinYil.Maximum = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            this.numMinYil.Minimum = new decimal(new int[] {
            1880,
            0,
            0,
            0});
            this.numMinYil.Name = "numMinYil";
            this.numMinYil.Size = new System.Drawing.Size(120, 22);
            this.numMinYil.TabIndex = 5;
            this.numMinYil.Value = new decimal(new int[] {
            1880,
            0,
            0,
            0});
            this.numMinYil.ValueChanged += new System.EventHandler(this.numMinYil_ValueChanged);
            // 
            // chkSadeceMevcutlar
            // 
            this.chkSadeceMevcutlar.AutoSize = true;
            this.chkSadeceMevcutlar.Location = new System.Drawing.Point(522, 144);
            this.chkSadeceMevcutlar.Name = "chkSadeceMevcutlar";
            this.chkSadeceMevcutlar.Size = new System.Drawing.Size(217, 20);
            this.chkSadeceMevcutlar.TabIndex = 6;
            this.chkSadeceMevcutlar.Text = "Sadece Mevcut Kitapları Göster";
            this.chkSadeceMevcutlar.UseVisualStyleBackColor = true;
            // 
            // cmbSirala
            // 
            this.cmbSirala.FormattingEnabled = true;
            this.cmbSirala.Items.AddRange(new object[] {
            "KitapAdi",
            "",
            "YazarAdi",
            "",
            "YayinYili"});
            this.cmbSirala.Location = new System.Drawing.Point(127, 140);
            this.cmbSirala.Name = "cmbSirala";
            this.cmbSirala.Size = new System.Drawing.Size(121, 24);
            this.cmbSirala.TabIndex = 7;
            // 
            // btnSorgula
            // 
            this.btnSorgula.Location = new System.Drawing.Point(34, 206);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(193, 55);
            this.btnSorgula.TabIndex = 8;
            this.btnSorgula.Text = "Filtrele ve Sorgula";
            this.btnSorgula.UseVisualStyleBackColor = true;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(277, 206);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(193, 55);
            this.btnExcel.TabIndex = 9;
            this.btnExcel.Text = "Excel Olarak İndir";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // dgvSonuclar
            // 
            this.dgvSonuclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSonuclar.Location = new System.Drawing.Point(1, 276);
            this.dgvSonuclar.Name = "dgvSonuclar";
            this.dgvSonuclar.RowHeadersWidth = 51;
            this.dgvSonuclar.RowTemplate.Height = 24;
            this.dgvSonuclar.Size = new System.Drawing.Size(796, 174);
            this.dgvSonuclar.TabIndex = 10;
            this.dgvSonuclar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSonuclar_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtYazar);
            this.groupBox1.Controls.Add(this.txtKitapAdi);
            this.groupBox1.Controls.Add(this.numMaxYil);
            this.groupBox1.Controls.Add(this.lblBasımYılıMax);
            this.groupBox1.Controls.Add(this.lblSıralama);
            this.groupBox1.Controls.Add(this.lblBasımYılıMin);
            this.groupBox1.Controls.Add(this.lblKategori);
            this.groupBox1.Controls.Add(this.cmbSirala);
            this.groupBox1.Controls.Add(this.lblKıtapAdı);
            this.groupBox1.Controls.Add(this.numMinYil);
            this.groupBox1.Controls.Add(this.chkSadeceMevcutlar);
            this.groupBox1.Controls.Add(this.cmbKategori);
            this.groupBox1.Controls.Add(this.lblYazarAdı);
            this.groupBox1.Location = new System.Drawing.Point(3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 192);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dinamik Arama Kriterleri";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(523, 39);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(60, 16);
            this.lblKategori.TabIndex = 10;
            this.lblKategori.Text = "Kategori:";
            // 
            // lblBasımYılıMin
            // 
            this.lblBasımYılıMin.AutoSize = true;
            this.lblBasımYılıMin.Location = new System.Drawing.Point(4, 95);
            this.lblBasımYılıMin.Name = "lblBasımYılıMin";
            this.lblBasımYılıMin.Size = new System.Drawing.Size(101, 16);
            this.lblBasımYılıMin.TabIndex = 11;
            this.lblBasımYılıMin.Text = "Basım Yılı (Min):";
            this.lblBasımYılıMin.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblSıralama
            // 
            this.lblSıralama.AutoSize = true;
            this.lblSıralama.Location = new System.Drawing.Point(4, 143);
            this.lblSıralama.Name = "lblSıralama";
            this.lblSıralama.Size = new System.Drawing.Size(100, 16);
            this.lblSıralama.TabIndex = 12;
            this.lblSıralama.Text = "Sıralama Kriteri:";
            // 
            // lblBasımYılıMax
            // 
            this.lblBasımYılıMax.AutoSize = true;
            this.lblBasımYılıMax.Location = new System.Drawing.Point(267, 95);
            this.lblBasımYılıMax.Name = "lblBasımYılıMax";
            this.lblBasımYılıMax.Size = new System.Drawing.Size(105, 16);
            this.lblBasımYılıMax.TabIndex = 13;
            this.lblBasımYılıMax.Text = "Basım Yılı (Max):";
            // 
            // numMaxYil
            // 
            this.numMaxYil.Location = new System.Drawing.Point(393, 95);
            this.numMaxYil.Maximum = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            this.numMaxYil.Minimum = new decimal(new int[] {
            1880,
            0,
            0,
            0});
            this.numMaxYil.Name = "numMaxYil";
            this.numMaxYil.Size = new System.Drawing.Size(120, 22);
            this.numMaxYil.TabIndex = 14;
            this.numMaxYil.Value = new decimal(new int[] {
            1880,
            0,
            0,
            0});
            this.numMaxYil.ValueChanged += new System.EventHandler(this.numMaxYil_ValueChanged);
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(73, 36);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(151, 22);
            this.txtKitapAdi.TabIndex = 15;
            this.txtKitapAdi.TextChanged += new System.EventHandler(this.txtkitapAdi_TextChanged);
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(318, 33);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(149, 22);
            this.txtYazar.TabIndex = 16;
            this.txtYazar.TextChanged += new System.EventHandler(this.txtYazar_TextChanged);
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(549, 206);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(193, 55);
            this.btnPdf.TabIndex = 12;
            this.btnPdf.Text = "PDF Olarak İndir";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // FrmDinamikSorgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSonuclar);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnSorgula);
            this.Name = "FrmDinamikSorgu";
            this.Text = "Dinamik Sorgu Ekranı";
            this.Load += new System.EventHandler(this.FrmDinamikSorgu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMinYil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSonuclar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxYil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblKıtapAdı;
        private System.Windows.Forms.Label lblYazarAdı;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.NumericUpDown numMinYil;
        private System.Windows.Forms.CheckBox chkSadeceMevcutlar;
        private System.Windows.Forms.ComboBox cmbSirala;
        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DataGridView dgvSonuclar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBasımYılıMin;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblSıralama;
        private System.Windows.Forms.NumericUpDown numMaxYil;
        private System.Windows.Forms.Label lblBasımYılıMax;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.Button btnPdf;
    }
}