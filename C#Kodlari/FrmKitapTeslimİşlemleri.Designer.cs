namespace KutuphaneOtomasyonu
{
    partial class FrmKitapTeslimİşlemleri
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
            this.lblÜyeKitapAra = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.dgvAktifOduncler = new System.Windows.Forms.DataGridView();
            this.lblUyeAd = new System.Windows.Forms.Label();
            this.lblKitapAd = new System.Windows.Forms.Label();
            this.lblOduncTarihi = new System.Windows.Forms.Label();
            this.lblSonTeslimTarihi = new System.Windows.Forms.Label();
            this.btnTeslimAl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktifOduncler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblÜyeKitapAra
            // 
            this.lblÜyeKitapAra.AutoSize = true;
            this.lblÜyeKitapAra.Location = new System.Drawing.Point(63, 13);
            this.lblÜyeKitapAra.Name = "lblÜyeKitapAra";
            this.lblÜyeKitapAra.Size = new System.Drawing.Size(90, 16);
            this.lblÜyeKitapAra.TabIndex = 0;
            this.lblÜyeKitapAra.Text = "Üye/Kitap Ara";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(177, 13);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(208, 22);
            this.txtAra.TabIndex = 1;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // dgvAktifOduncler
            // 
            this.dgvAktifOduncler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAktifOduncler.Location = new System.Drawing.Point(22, 72);
            this.dgvAktifOduncler.Name = "dgvAktifOduncler";
            this.dgvAktifOduncler.RowHeadersWidth = 51;
            this.dgvAktifOduncler.RowTemplate.Height = 24;
            this.dgvAktifOduncler.Size = new System.Drawing.Size(580, 338);
            this.dgvAktifOduncler.TabIndex = 2;
            this.dgvAktifOduncler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAktifOduncler_CellClick_1);
            // 
            // lblUyeAd
            // 
            this.lblUyeAd.AutoSize = true;
            this.lblUyeAd.Location = new System.Drawing.Point(608, 101);
            this.lblUyeAd.Name = "lblUyeAd";
            this.lblUyeAd.Size = new System.Drawing.Size(78, 16);
            this.lblUyeAd.TabIndex = 3;
            this.lblUyeAd.Text = "Seçili Üye: -";
            this.lblUyeAd.Click += new System.EventHandler(this.lblUyeAd_Click);
            // 
            // lblKitapAd
            // 
            this.lblKitapAd.AutoSize = true;
            this.lblKitapAd.Location = new System.Drawing.Point(608, 142);
            this.lblKitapAd.Name = "lblKitapAd";
            this.lblKitapAd.Size = new System.Drawing.Size(83, 16);
            this.lblKitapAd.TabIndex = 4;
            this.lblKitapAd.Text = "Seçili Kitap: -";
            this.lblKitapAd.Click += new System.EventHandler(this.lblKitapAd_Click);
            // 
            // lblOduncTarihi
            // 
            this.lblOduncTarihi.AutoSize = true;
            this.lblOduncTarihi.Location = new System.Drawing.Point(608, 187);
            this.lblOduncTarihi.Name = "lblOduncTarihi";
            this.lblOduncTarihi.Size = new System.Drawing.Size(93, 16);
            this.lblOduncTarihi.TabIndex = 5;
            this.lblOduncTarihi.Text = "Ödünç Tarihi: -";
            // 
            // lblSonTeslimTarihi
            // 
            this.lblSonTeslimTarihi.AutoSize = true;
            this.lblSonTeslimTarihi.Location = new System.Drawing.Point(608, 224);
            this.lblSonTeslimTarihi.Name = "lblSonTeslimTarihi";
            this.lblSonTeslimTarihi.Size = new System.Drawing.Size(119, 16);
            this.lblSonTeslimTarihi.TabIndex = 6;
            this.lblSonTeslimTarihi.Text = "Son TeslimTarihi: -";
            this.lblSonTeslimTarihi.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnTeslimAl
            // 
            this.btnTeslimAl.Location = new System.Drawing.Point(652, 333);
            this.btnTeslimAl.Name = "btnTeslimAl";
            this.btnTeslimAl.Size = new System.Drawing.Size(88, 34);
            this.btnTeslimAl.TabIndex = 7;
            this.btnTeslimAl.Text = "Teslim Al";
            this.btnTeslimAl.UseVisualStyleBackColor = true;
            this.btnTeslimAl.Click += new System.EventHandler(this.btnTeslimAl_Click);
            // 
            // FrmKitapTeslimİşlemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTeslimAl);
            this.Controls.Add(this.lblSonTeslimTarihi);
            this.Controls.Add(this.lblOduncTarihi);
            this.Controls.Add(this.lblKitapAd);
            this.Controls.Add(this.lblUyeAd);
            this.Controls.Add(this.dgvAktifOduncler);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lblÜyeKitapAra);
            this.Name = "FrmKitapTeslimİşlemleri";
            this.Text = "Kitap Teslim İşlemleri";
            this.Load += new System.EventHandler(this.FrmKitapTeslimİşlemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktifOduncler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblÜyeKitapAra;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.DataGridView dgvAktifOduncler;
        private System.Windows.Forms.Label lblUyeAd;
        private System.Windows.Forms.Label lblKitapAd;
        private System.Windows.Forms.Label lblOduncTarihi;
        private System.Windows.Forms.Label lblSonTeslimTarihi;
        private System.Windows.Forms.Button btnTeslimAl;
    }
}