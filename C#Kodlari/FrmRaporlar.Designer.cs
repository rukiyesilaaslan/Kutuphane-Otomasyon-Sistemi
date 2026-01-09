namespace KutuphaneOtomasyonu
{
    partial class FrmRaporlar
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dtpBas = new System.Windows.Forms.DateTimePicker();
            this.dtpBit = new System.Windows.Forms.DateTimePicker();
            this.cmbUyeSecimi = new System.Windows.Forms.ComboBox();
            this.btnRapor1 = new System.Windows.Forms.Button();
            this.dgvRapor1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGecikenler = new System.Windows.Forms.Button();
            this.dgvGecikenler = new System.Windows.Forms.DataGridView();
            this.btnEnCokOkunanlar = new System.Windows.Forms.Button();
            this.dgvİstatistik = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGecikenler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvİstatistik)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 434);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgvRapor1);
            this.tabPage1.Controls.Add(this.btnRapor1);
            this.tabPage1.Controls.Add(this.cmbUyeSecimi);
            this.tabPage1.Controls.Add(this.dtpBit);
            this.tabPage1.Controls.Add(this.dtpBas);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 405);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dgvGecikenler);
            this.tabPage2.Controls.Add(this.btnGecikenler);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 405);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.dgvİstatistik);
            this.tabPage3.Controls.Add(this.btnEnCokOkunanlar);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(780, 405);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dtpBas
            // 
            this.dtpBas.Location = new System.Drawing.Point(161, 38);
            this.dtpBas.Name = "dtpBas";
            this.dtpBas.Size = new System.Drawing.Size(200, 22);
            this.dtpBas.TabIndex = 0;
            // 
            // dtpBit
            // 
            this.dtpBit.Location = new System.Drawing.Point(161, 74);
            this.dtpBit.Name = "dtpBit";
            this.dtpBit.Size = new System.Drawing.Size(200, 22);
            this.dtpBit.TabIndex = 1;
            // 
            // cmbUyeSecimi
            // 
            this.cmbUyeSecimi.FormattingEnabled = true;
            this.cmbUyeSecimi.Location = new System.Drawing.Point(514, 26);
            this.cmbUyeSecimi.Name = "cmbUyeSecimi";
            this.cmbUyeSecimi.Size = new System.Drawing.Size(238, 24);
            this.cmbUyeSecimi.TabIndex = 2;
            // 
            // btnRapor1
            // 
            this.btnRapor1.Location = new System.Drawing.Point(538, 354);
            this.btnRapor1.Name = "btnRapor1";
            this.btnRapor1.Size = new System.Drawing.Size(214, 34);
            this.btnRapor1.TabIndex = 3;
            this.btnRapor1.Text = "Ödünç Raporu Oluştur";
            this.btnRapor1.UseVisualStyleBackColor = true;
            this.btnRapor1.Click += new System.EventHandler(this.btnRapor1_Click);
            // 
            // dgvRapor1
            // 
            this.dgvRapor1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRapor1.Location = new System.Drawing.Point(6, 112);
            this.dgvRapor1.Name = "dgvRapor1";
            this.dgvRapor1.ReadOnly = true;
            this.dgvRapor1.RowHeadersWidth = 51;
            this.dgvRapor1.RowTemplate.Height = 24;
            this.dgvRapor1.Size = new System.Drawing.Size(768, 236);
            this.dgvRapor1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Başlangıç Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bitiş Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Üye Seçimi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tarih Aralığı Ödünç Raporu";
            // 
            // btnGecikenler
            // 
            this.btnGecikenler.Location = new System.Drawing.Point(507, 332);
            this.btnGecikenler.Name = "btnGecikenler";
            this.btnGecikenler.Size = new System.Drawing.Size(221, 55);
            this.btnGecikenler.TabIndex = 0;
            this.btnGecikenler.Text = "Geciken Kitapları Listele";
            this.btnGecikenler.UseVisualStyleBackColor = true;
            this.btnGecikenler.Click += new System.EventHandler(this.btnGecikenler_Click);
            // 
            // dgvGecikenler
            // 
            this.dgvGecikenler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGecikenler.Location = new System.Drawing.Point(21, 45);
            this.dgvGecikenler.Name = "dgvGecikenler";
            this.dgvGecikenler.ReadOnly = true;
            this.dgvGecikenler.RowHeadersWidth = 51;
            this.dgvGecikenler.RowTemplate.Height = 24;
            this.dgvGecikenler.Size = new System.Drawing.Size(753, 281);
            this.dgvGecikenler.TabIndex = 1;
            this.dgvGecikenler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnEnCokOkunanlar
            // 
            this.btnEnCokOkunanlar.Location = new System.Drawing.Point(543, 332);
            this.btnEnCokOkunanlar.Name = "btnEnCokOkunanlar";
            this.btnEnCokOkunanlar.Size = new System.Drawing.Size(182, 54);
            this.btnEnCokOkunanlar.TabIndex = 0;
            this.btnEnCokOkunanlar.Text = "İstatistikleri Getir";
            this.btnEnCokOkunanlar.UseVisualStyleBackColor = true;
            this.btnEnCokOkunanlar.Click += new System.EventHandler(this.btnEnCokOkunanlar_Click);
            // 
            // dgvİstatistik
            // 
            this.dgvİstatistik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvİstatistik.Location = new System.Drawing.Point(21, 51);
            this.dgvİstatistik.Name = "dgvİstatistik";
            this.dgvİstatistik.ReadOnly = true;
            this.dgvİstatistik.RowHeadersWidth = 51;
            this.dgvİstatistik.RowTemplate.Height = 24;
            this.dgvİstatistik.Size = new System.Drawing.Size(735, 264);
            this.dgvİstatistik.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "En Çok Ödünç Alınan Kitaplar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Geciken Kitaplar Raporu";
            // 
            // FrmRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmRaporlar";
            this.Text = "Raporlar";
            this.Load += new System.EventHandler(this.FrmRaporlar_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGecikenler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvİstatistik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker dtpBit;
        private System.Windows.Forms.DateTimePicker dtpBas;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvRapor1;
        private System.Windows.Forms.Button btnRapor1;
        private System.Windows.Forms.ComboBox cmbUyeSecimi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvGecikenler;
        private System.Windows.Forms.Button btnGecikenler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvİstatistik;
        private System.Windows.Forms.Button btnEnCokOkunanlar;
    }
}