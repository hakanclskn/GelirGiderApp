namespace WinFormsApp1
{
    partial class OdemeEkle
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
            lblToplamTutar = new Label();
            label3 = new Label();
            label1 = new Label();
            cmbMusteri = new ComboBox();
            dtpOdemeTarihi = new DateTimePicker();
            nudTutar = new NumericUpDown();
            Tutar = new Label();
            btnKaydet = new Button();
            lblDurum = new Label();
            dgwMusteriCek = new DataGridView();
            label2 = new Label();
            dtpBaslangic = new DateTimePicker();
            label4 = new Label();
            dtpBitis = new DateTimePicker();
            btnListele = new Button();
            btnCikis = new Button();
            ((System.ComponentModel.ISupportInitialize)nudTutar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwMusteriCek).BeginInit();
            SuspendLayout();
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblToplamTutar.Location = new Point(77, 584);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(0, 25);
            lblToplamTutar.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 293);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 10;
            label3.Text = "Müşteri Seçimi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 245);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 12;
            label1.Text = "Ödeme Tarihi";
            // 
            // cmbMusteri
            // 
            cmbMusteri.FormattingEnabled = true;
            cmbMusteri.Location = new Point(129, 290);
            cmbMusteri.Name = "cmbMusteri";
            cmbMusteri.Size = new Size(151, 28);
            cmbMusteri.TabIndex = 9;
            // 
            // dtpOdemeTarihi
            // 
            dtpOdemeTarihi.Location = new Point(127, 245);
            dtpOdemeTarihi.Name = "dtpOdemeTarihi";
            dtpOdemeTarihi.Size = new Size(250, 27);
            dtpOdemeTarihi.TabIndex = 8;
            // 
            // nudTutar
            // 
            nudTutar.Location = new Point(127, 334);
            nudTutar.Name = "nudTutar";
            nudTutar.Size = new Size(150, 27);
            nudTutar.TabIndex = 15;
            // 
            // Tutar
            // 
            Tutar.AutoSize = true;
            Tutar.Location = new Point(66, 336);
            Tutar.Name = "Tutar";
            Tutar.Size = new Size(43, 20);
            Tutar.TabIndex = 16;
            Tutar.Text = "Tutar";
            // 
            // btnKaydet
            // 
            btnKaydet.BackgroundImage = Properties.Resources._0okey;
            btnKaydet.BackgroundImageLayout = ImageLayout.Stretch;
            btnKaydet.Location = new Point(127, 388);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 59);
            btnKaydet.TabIndex = 17;
            btnKaydet.TextAlign = ContentAlignment.MiddleRight;
            btnKaydet.UseVisualStyleBackColor = true;
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Location = new Point(77, 564);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(0, 20);
            lblDurum.TabIndex = 18;
            // 
            // dgwMusteriCek
            // 
            dgwMusteriCek.BackgroundColor = Color.White;
            dgwMusteriCek.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwMusteriCek.Location = new Point(404, 81);
            dgwMusteriCek.Name = "dgwMusteriCek";
            dgwMusteriCek.RowHeadersWidth = 51;
            dgwMusteriCek.Size = new Size(793, 332);
            dgwMusteriCek.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-2, 81);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 21;
            label2.Text = "Başlangıç Tarihi";
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Location = new Point(127, 81);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(250, 27);
            dtpBaslangic.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 123);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 23;
            label4.Text = "Bitiş Tarihi";
            // 
            // dtpBitis
            // 
            dtpBitis.Location = new Point(127, 123);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(250, 27);
            dtpBitis.TabIndex = 22;
            // 
            // btnListele
            // 
            btnListele.Location = new Point(127, 176);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(94, 29);
            btnListele.TabIndex = 24;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // btnCikis
            // 
            btnCikis.BackgroundImage = Properties.Resources._0cancel;
            btnCikis.BackgroundImageLayout = ImageLayout.Stretch;
            btnCikis.Location = new Point(251, 388);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(94, 59);
            btnCikis.TabIndex = 25;
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // OdemeEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pngtree_business_finance_account_accounting_background_photo_image_2786642;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1209, 661);
            Controls.Add(btnCikis);
            Controls.Add(btnListele);
            Controls.Add(label4);
            Controls.Add(dtpBitis);
            Controls.Add(label2);
            Controls.Add(dtpBaslangic);
            Controls.Add(dgwMusteriCek);
            Controls.Add(lblDurum);
            Controls.Add(btnKaydet);
            Controls.Add(Tutar);
            Controls.Add(nudTutar);
            Controls.Add(lblToplamTutar);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(cmbMusteri);
            Controls.Add(dtpOdemeTarihi);
            Name = "OdemeEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OdemeEkle";
            Load += OdemeEkle_Load;
            ((System.ComponentModel.ISupportInitialize)nudTutar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwMusteriCek).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblToplamTutar;
        private Label label3;
        private Label label1;
        private ComboBox cmbMusteri;
        private DateTimePicker dtpOdemeTarihi;
        private NumericUpDown nudTutar;
        private Label Tutar;
        private Button btnKaydet;
        private Label lblDurum;
        private DataGridView dgwMusteriCek;
        private Label label2;
        private DateTimePicker dtpBaslangic;
        private Label label4;
        private DateTimePicker dtpBitis;
        private Button btnListele;
        private Button btnCikis;
    }
}