namespace WinFormsApp1
{
    partial class FrmOdemeGoruntuleme
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
            dtpBaslangic = new DateTimePicker();
            dtpBitis = new DateTimePicker();
            cmbMusteri = new ComboBox();
            btnListele = new Button();
            dgvOdemeler = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblToplamTutar = new Label();
            label4 = new Label();
            btnTemizle = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOdemeler).BeginInit();
            SuspendLayout();
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Location = new Point(140, 60);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(250, 27);
            dtpBaslangic.TabIndex = 0;
            // 
            // dtpBitis
            // 
            dtpBitis.Location = new Point(140, 109);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(250, 27);
            dtpBitis.TabIndex = 0;
            // 
            // cmbMusteri
            // 
            cmbMusteri.FormattingEnabled = true;
            cmbMusteri.Location = new Point(140, 156);
            cmbMusteri.Name = "cmbMusteri";
            cmbMusteri.Size = new Size(151, 28);
            cmbMusteri.TabIndex = 1;
            // 
            // btnListele
            // 
            btnListele.Location = new Point(108, 256);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(114, 48);
            btnListele.TabIndex = 2;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            // 
            // dgvOdemeler
            // 
            dgvOdemeler.BackgroundColor = Color.White;
            dgvOdemeler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOdemeler.Location = new Point(425, 60);
            dgvOdemeler.Name = "dgvOdemeler";
            dgvOdemeler.RowHeadersWidth = 51;
            dgvOdemeler.Size = new Size(724, 303);
            dgvOdemeler.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 60);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 4;
            label1.Text = "Başlangıç Tarihi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 109);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 4;
            label2.Text = "Bitiş Tarihi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 159);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 4;
            label3.Text = "Müşteri Seçimi";
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblToplamTutar.Location = new Point(140, 201);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(0, 25);
            lblToplamTutar.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 201);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 6;
            label4.Text = "Toplam Tutar: ";
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(238, 256);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(111, 48);
            btnTemizle.TabIndex = 7;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // FrmOdemeGoruntuleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 628);
            Controls.Add(btnTemizle);
            Controls.Add(label4);
            Controls.Add(lblToplamTutar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvOdemeler);
            Controls.Add(btnListele);
            Controls.Add(cmbMusteri);
            Controls.Add(dtpBitis);
            Controls.Add(dtpBaslangic);
            Name = "FrmOdemeGoruntuleme";
            Text = "FrmOdemeGoruntuleme";
            Load += FrmOdemeGoruntuleme_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOdemeler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpBaslangic;
        private DateTimePicker dtpBitis;
        private ComboBox cmbMusteri;
        private Button btnListele;
        private DataGridView dgvOdemeler;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblToplamTutar;
        private Label label4;
        private Button btnTemizle;
    }
}