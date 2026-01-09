namespace KutuphaneOtomasyonu
{
    partial class FrmCezaListesi
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
            this.dgvCezalar = new System.Windows.Forms.DataGridView();
            this.dtpBaşlangıc = new System.Windows.Forms.DateTimePicker();
            this.lblÜyeAra = new System.Windows.Forms.Label();
            this.lblBaşlangıçTarihi = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpBitiş = new System.Windows.Forms.DateTimePicker();
            this.lblBitişTarihi = new System.Windows.Forms.Label();
            this.txtUyeAra = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblToplamBorc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCezalar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCezalar
            // 
            this.dgvCezalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCezalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCezalar.Location = new System.Drawing.Point(-3, 144);
            this.dgvCezalar.Name = "dgvCezalar";
            this.dgvCezalar.RowHeadersWidth = 51;
            this.dgvCezalar.RowTemplate.Height = 24;
            this.dgvCezalar.Size = new System.Drawing.Size(798, 257);
            this.dgvCezalar.TabIndex = 1;
            this.dgvCezalar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCezalar_CellContentClick);
            // 
            // dtpBaşlangıc
            // 
            this.dtpBaşlangıc.Location = new System.Drawing.Point(477, 36);
            this.dtpBaşlangıc.Name = "dtpBaşlangıc";
            this.dtpBaşlangıc.Size = new System.Drawing.Size(200, 22);
            this.dtpBaşlangıc.TabIndex = 2;
            this.dtpBaşlangıc.ValueChanged += new System.EventHandler(this.dtpBaşlangıc_ValueChanged);
            // 
            // lblÜyeAra
            // 
            this.lblÜyeAra.AutoSize = true;
            this.lblÜyeAra.Location = new System.Drawing.Point(6, 36);
            this.lblÜyeAra.Name = "lblÜyeAra";
            this.lblÜyeAra.Size = new System.Drawing.Size(105, 16);
            this.lblÜyeAra.TabIndex = 3;
            this.lblÜyeAra.Text = "Üye Adı/Soyadı:";
            this.lblÜyeAra.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblBaşlangıçTarihi
            // 
            this.lblBaşlangıçTarihi.AutoSize = true;
            this.lblBaşlangıçTarihi.Location = new System.Drawing.Point(346, 33);
            this.lblBaşlangıçTarihi.Name = "lblBaşlangıçTarihi";
            this.lblBaşlangıçTarihi.Size = new System.Drawing.Size(107, 16);
            this.lblBaşlangıçTarihi.TabIndex = 4;
            this.lblBaşlangıçTarihi.Text = "Başlangıç Tarihi:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpBitiş);
            this.groupBox1.Controls.Add(this.lblBitişTarihi);
            this.groupBox1.Controls.Add(this.txtUyeAra);
            this.groupBox1.Controls.Add(this.dtpBaşlangıc);
            this.groupBox1.Controls.Add(this.lblBaşlangıçTarihi);
            this.groupBox1.Controls.Add(this.lblÜyeAra);
            this.groupBox1.Location = new System.Drawing.Point(-3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 134);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtreleme Seçenekleri";
            // 
            // dtpBitiş
            // 
            this.dtpBitiş.Location = new System.Drawing.Point(477, 83);
            this.dtpBitiş.Name = "dtpBitiş";
            this.dtpBitiş.Size = new System.Drawing.Size(200, 22);
            this.dtpBitiş.TabIndex = 6;
            this.dtpBitiş.ValueChanged += new System.EventHandler(this.dtpBitiş_ValueChanged);
            // 
            // lblBitişTarihi
            // 
            this.lblBitişTarihi.AutoSize = true;
            this.lblBitişTarihi.Location = new System.Drawing.Point(346, 89);
            this.lblBitişTarihi.Name = "lblBitişTarihi";
            this.lblBitişTarihi.Size = new System.Drawing.Size(72, 16);
            this.lblBitişTarihi.TabIndex = 5;
            this.lblBitişTarihi.Text = "Bitiş Tarihi:";
            // 
            // txtUyeAra
            // 
            this.txtUyeAra.Location = new System.Drawing.Point(161, 33);
            this.txtUyeAra.Name = "txtUyeAra";
            this.txtUyeAra.Size = new System.Drawing.Size(100, 22);
            this.txtUyeAra.TabIndex = 4;
            this.txtUyeAra.TextChanged += new System.EventHandler(this.txtUyeAra_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblToplamBorc);
            this.groupBox2.Location = new System.Drawing.Point(-3, 395);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(798, 54);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // lblToplamBorc
            // 
            this.lblToplamBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamBorc.ForeColor = System.Drawing.Color.Red;
            this.lblToplamBorc.Location = new System.Drawing.Point(376, 9);
            this.lblToplamBorc.Name = "lblToplamBorc";
            this.lblToplamBorc.Size = new System.Drawing.Size(301, 37);
            this.lblToplamBorc.TabIndex = 0;
            this.lblToplamBorc.Text = "Toplam Borç: - TL";
            this.lblToplamBorc.Click += new System.EventHandler(this.lblToplamBorc_Click);
            // 
            // FrmCezaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCezalar);
            this.Name = "FrmCezaListesi";
            this.Text = "Ceza Görüntüleme Ekranı";
            this.Load += new System.EventHandler(this.FrmCezaListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCezalar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCezalar;
        private System.Windows.Forms.DateTimePicker dtpBaşlangıc;
        private System.Windows.Forms.Label lblÜyeAra;
        private System.Windows.Forms.Label lblBaşlangıçTarihi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpBitiş;
        private System.Windows.Forms.Label lblBitişTarihi;
        private System.Windows.Forms.TextBox txtUyeAra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblToplamBorc;
    }
}