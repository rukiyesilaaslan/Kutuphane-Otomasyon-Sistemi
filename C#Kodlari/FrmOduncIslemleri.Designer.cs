namespace KutuphaneOtomasyonu
{
    partial class FrmOduncIslemleri
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvKitaplar = new System.Windows.Forms.DataGridView();
            this.txtKitapAra = new System.Windows.Forms.TextBox();
            this.lblKitapAra = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOduncVer = new System.Windows.Forms.Button();
            this.lblStok = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvUyeler = new System.Windows.Forms.DataGridView();
            this.txtUyeAra = new System.Windows.Forms.TextBox();
            this.lblUyeAra = new System.Windows.Forms.Label();
            this.lblAktifOdunc = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvAktifOduncler = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUyeler)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktifOduncler)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.97849F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.02151F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 337F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-3, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 290F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(802, 290);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvKitaplar);
            this.panel1.Controls.Add(this.txtKitapAra);
            this.panel1.Controls.Add(this.lblKitapAra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(468, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 284);
            this.panel1.TabIndex = 0;
            // 
            // dgvKitaplar
            // 
            this.dgvKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitaplar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvKitaplar.Location = new System.Drawing.Point(0, 89);
            this.dgvKitaplar.Name = "dgvKitaplar";
            this.dgvKitaplar.ReadOnly = true;
            this.dgvKitaplar.RowHeadersWidth = 51;
            this.dgvKitaplar.RowTemplate.Height = 24;
            this.dgvKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKitaplar.Size = new System.Drawing.Size(331, 195);
            this.dgvKitaplar.TabIndex = 2;
            this.dgvKitaplar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKitaplar_CellClick_1);
            // 
            // txtKitapAra
            // 
            this.txtKitapAra.Location = new System.Drawing.Point(150, 47);
            this.txtKitapAra.Name = "txtKitapAra";
            this.txtKitapAra.Size = new System.Drawing.Size(191, 22);
            this.txtKitapAra.TabIndex = 1;
            this.txtKitapAra.TextChanged += new System.EventHandler(this.txtKitapAra_TextChanged);
            // 
            // lblKitapAra
            // 
            this.lblKitapAra.AutoSize = true;
            this.lblKitapAra.Location = new System.Drawing.Point(13, 47);
            this.lblKitapAra.Name = "lblKitapAra";
            this.lblKitapAra.Size = new System.Drawing.Size(131, 16);
            this.lblKitapAra.TabIndex = 0;
            this.lblKitapAra.Text = "Kitap Ara (Ad/Yazar):";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOduncVer);
            this.panel2.Controls.Add(this.lblStok);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(347, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(115, 284);
            this.panel2.TabIndex = 1;
            // 
            // btnOduncVer
            // 
            this.btnOduncVer.Location = new System.Drawing.Point(23, 89);
            this.btnOduncVer.Name = "btnOduncVer";
            this.btnOduncVer.Size = new System.Drawing.Size(75, 67);
            this.btnOduncVer.TabIndex = 1;
            this.btnOduncVer.Text = "ÖDÜNÇ VER";
            this.btnOduncVer.UseVisualStyleBackColor = true;
            this.btnOduncVer.Click += new System.EventHandler(this.btnOduncVer_Click);
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Location = new System.Drawing.Point(3, 50);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(90, 16);
            this.lblStok.TabIndex = 0;
            this.lblStok.Text = "Mevcut Stok: -";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvUyeler);
            this.panel3.Controls.Add(this.txtUyeAra);
            this.panel3.Controls.Add(this.lblUyeAra);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(338, 284);
            this.panel3.TabIndex = 2;
            // 
            // dgvUyeler
            // 
            this.dgvUyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUyeler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvUyeler.Location = new System.Drawing.Point(0, 89);
            this.dgvUyeler.Name = "dgvUyeler";
            this.dgvUyeler.ReadOnly = true;
            this.dgvUyeler.RowHeadersWidth = 51;
            this.dgvUyeler.RowTemplate.Height = 24;
            this.dgvUyeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUyeler.Size = new System.Drawing.Size(338, 195);
            this.dgvUyeler.TabIndex = 2;
            this.dgvUyeler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUyeler_CellClick);
            // 
            // txtUyeAra
            // 
            this.txtUyeAra.Location = new System.Drawing.Point(134, 47);
            this.txtUyeAra.Name = "txtUyeAra";
            this.txtUyeAra.Size = new System.Drawing.Size(201, 22);
            this.txtUyeAra.TabIndex = 1;
            this.txtUyeAra.TextChanged += new System.EventHandler(this.txtUyeAra_TextChanged);
            // 
            // lblUyeAra
            // 
            this.lblUyeAra.AutoSize = true;
            this.lblUyeAra.Location = new System.Drawing.Point(3, 50);
            this.lblUyeAra.Name = "lblUyeAra";
            this.lblUyeAra.Size = new System.Drawing.Size(131, 16);
            this.lblUyeAra.TabIndex = 0;
            this.lblUyeAra.Text = "Üye Ara (Ad/Soyad):";
            this.lblUyeAra.Click += new System.EventHandler(this.lblUyeAra_Click);
            // 
            // lblAktifOdunc
            // 
            this.lblAktifOdunc.AutoSize = true;
            this.lblAktifOdunc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAktifOdunc.Location = new System.Drawing.Point(0, 0);
            this.lblAktifOdunc.Name = "lblAktifOdunc";
            this.lblAktifOdunc.Size = new System.Drawing.Size(173, 16);
            this.lblAktifOdunc.TabIndex = 3;
            this.lblAktifOdunc.Text = "Seçili Üyenin Aktif Ödünçleri";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 293);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(799, 178);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblAktifOdunc);
            this.panel4.Controls.Add(this.dgvAktifOduncler);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(793, 161);
            this.panel4.TabIndex = 0;
            // 
            // dgvAktifOduncler
            // 
            this.dgvAktifOduncler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAktifOduncler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAktifOduncler.Location = new System.Drawing.Point(0, 0);
            this.dgvAktifOduncler.Name = "dgvAktifOduncler";
            this.dgvAktifOduncler.ReadOnly = true;
            this.dgvAktifOduncler.RowHeadersWidth = 51;
            this.dgvAktifOduncler.RowTemplate.Height = 24;
            this.dgvAktifOduncler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAktifOduncler.Size = new System.Drawing.Size(793, 161);
            this.dgvAktifOduncler.TabIndex = 5;
            // 
            // FrmOduncIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmOduncIslemleri";
            this.Text = "Ödunç İslemleri";
            this.Load += new System.EventHandler(this.FrmOduncIslemleri_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUyeler)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktifOduncler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtKitapAra;
        private System.Windows.Forms.Label lblKitapAra;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOduncVer;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvUyeler;
        private System.Windows.Forms.TextBox txtUyeAra;
        private System.Windows.Forms.Label lblUyeAra;
        private System.Windows.Forms.DataGridView dgvKitaplar;
        private System.Windows.Forms.Label lblAktifOdunc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvAktifOduncler;
        private System.Windows.Forms.Panel panel4;
    }
}