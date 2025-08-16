namespace WinFormsApp1
{
    partial class GiderEkle
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
            btnListele = new Button();
            label4 = new Label();
            dtpBitis = new DateTimePicker();
            label2 = new Label();
            dtpBaslangic = new DateTimePicker();
            dgwMusteriCek = new DataGridView();
            lblDurum = new Label();
            Tutar = new Label();
            nudTutar = new NumericUpDown();
            lblToplamTutar = new Label();
            label3 = new Label();
            label1 = new Label();
            cmbMusteri = new ComboBox();
            dtpGiderTarihi = new DateTimePicker();
            btnCikis = new Button();
            btnOnayla = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwMusteriCek).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTutar).BeginInit();
            SuspendLayout();
            // 
            // btnListele
            // 
            btnListele.Location = new Point(137, 118);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(94, 29);
            btnListele.TabIndex = 39;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 65);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 38;
            label4.Text = "Bitiş Tarihi";
            // 
            // dtpBitis
            // 
            dtpBitis.Location = new Point(137, 65);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(250, 27);
            dtpBitis.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 23);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 36;
            label2.Text = "Başlangıç Tarihi";
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Location = new Point(137, 23);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(250, 27);
            dtpBaslangic.TabIndex = 35;
            // 
            // dgwMusteriCek
            // 
            dgwMusteriCek.BackgroundColor = Color.White;
            dgwMusteriCek.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwMusteriCek.Location = new Point(414, 23);
            dgwMusteriCek.Name = "dgwMusteriCek";
            dgwMusteriCek.RowHeadersWidth = 51;
            dgwMusteriCek.Size = new Size(793, 332);
            dgwMusteriCek.TabIndex = 34;
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Location = new Point(87, 506);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(0, 20);
            lblDurum.TabIndex = 33;
            // 
            // Tutar
            // 
            Tutar.AutoSize = true;
            Tutar.Location = new Point(76, 278);
            Tutar.Name = "Tutar";
            Tutar.Size = new Size(43, 20);
            Tutar.TabIndex = 31;
            Tutar.Text = "Tutar";
            // 
            // nudTutar
            // 
            nudTutar.Location = new Point(137, 276);
            nudTutar.Name = "nudTutar";
            nudTutar.Size = new Size(150, 27);
            nudTutar.TabIndex = 30;
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblToplamTutar.Location = new Point(87, 526);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(22, 25);
            lblToplamTutar.TabIndex = 29;
            lblToplamTutar.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 235);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 27;
            label3.Text = "Müşteri Seçimi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 187);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 28;
            label1.Text = "Gider Tarihi";
            // 
            // cmbMusteri
            // 
            cmbMusteri.FormattingEnabled = true;
            cmbMusteri.Location = new Point(139, 232);
            cmbMusteri.Name = "cmbMusteri";
            cmbMusteri.Size = new Size(151, 28);
            cmbMusteri.TabIndex = 26;
            // 
            // dtpGiderTarihi
            // 
            dtpGiderTarihi.Location = new Point(137, 187);
            dtpGiderTarihi.Name = "dtpGiderTarihi";
            dtpGiderTarihi.Size = new Size(250, 27);
            dtpGiderTarihi.TabIndex = 25;
            // 
            // btnCikis
            // 
            btnCikis.BackgroundImage = Properties.Resources._0cancel;
            btnCikis.BackgroundImageLayout = ImageLayout.Stretch;
            btnCikis.Location = new Point(261, 339);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(94, 59);
            btnCikis.TabIndex = 41;
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click_1;
            // 
            // btnOnayla
            // 
            btnOnayla.BackgroundImage = Properties.Resources._0okey;
            btnOnayla.BackgroundImageLayout = ImageLayout.Stretch;
            btnOnayla.Location = new Point(137, 339);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(94, 59);
            btnOnayla.TabIndex = 40;
            btnOnayla.TextAlign = ContentAlignment.MiddleRight;
            btnOnayla.UseVisualStyleBackColor = true;
            // 
            // GiderEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pngtree_original_font_accounting_background_design_image_529231;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1236, 620);
            Controls.Add(btnCikis);
            Controls.Add(btnOnayla);
            Controls.Add(btnListele);
            Controls.Add(label4);
            Controls.Add(dtpBitis);
            Controls.Add(label2);
            Controls.Add(dtpBaslangic);
            Controls.Add(dgwMusteriCek);
            Controls.Add(lblDurum);
            Controls.Add(Tutar);
            Controls.Add(nudTutar);
            Controls.Add(lblToplamTutar);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(cmbMusteri);
            Controls.Add(dtpGiderTarihi);
            Name = "GiderEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GiderEkle";
            Load += GiderEkle_Load;
            ((System.ComponentModel.ISupportInitialize)dgwMusteriCek).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTutar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListele;
        private Label label4;
        private DateTimePicker dtpBitis;
        private Label label2;
        private DateTimePicker dtpBaslangic;
        private DataGridView dgwMusteriCek;
        private Label lblDurum;
        private Label Tutar;
        private NumericUpDown nudTutar;
        private Label lblToplamTutar;
        private Label label3;
        private Label label1;
        private ComboBox cmbMusteri;
        private DateTimePicker dtpGiderTarihi;
        private Button btnCikis;
        private Button btnOnayla;
    }
}