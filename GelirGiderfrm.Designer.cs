namespace WinFormsApp1
{
    partial class GelirGiderfrm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dgwListele = new DataGridView();
            btnListele = new Button();
            btnİptal = new Button();
            label7 = new Label();
            dtpBitis = new DateTimePicker();
            label8 = new Label();
            dtpBaslangic = new DateTimePicker();
            label3 = new Label();
            cmbMusteri = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgwListele).BeginInit();
            SuspendLayout();
            // 
            // dgwListele
            // 
            dgwListele.AllowUserToOrderColumns = true;
            dgwListele.BackgroundColor = Color.White;
            dgwListele.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwListele.Location = new Point(347, 77);
            dgwListele.Name = "dgwListele";
            dgwListele.RowHeadersWidth = 51;
            dgwListele.Size = new Size(843, 398);
            dgwListele.TabIndex = 7;
            dgwListele.AutoGenerateColumns = true; // Önemli
            // 
            // btnListele
            // 
            btnListele.BackgroundImage = Properties.Resources._0okey;
            btnListele.BackgroundImageLayout = ImageLayout.Stretch;
            btnListele.Location = new Point(38, 377);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(124, 79);
            btnListele.TabIndex = 2;
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // btnİptal
            // 
            btnİptal.BackgroundImage = Properties.Resources._0cancel1;
            btnİptal.BackgroundImageLayout = ImageLayout.Stretch;
            btnİptal.Location = new Point(184, 377);
            btnİptal.Name = "btnİptal";
            btnİptal.Size = new Size(124, 79);
            btnİptal.TabIndex = 3;
            btnİptal.UseVisualStyleBackColor = true;
            btnİptal.Click += btnİptal_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 218);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 43;
            label7.Text = "Bitiş Tarihi";
            // 
            // dtpBitis
            // 
            dtpBitis.Location = new Point(132, 218);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(198, 27);
            dtpBitis.TabIndex = 42;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 176);
            label8.Name = "label8";
            label8.Size = new Size(111, 20);
            label8.TabIndex = 41;
            label8.Text = "Başlangıç Tarihi";
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Location = new Point(132, 176);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(198, 27);
            dtpBaslangic.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 264);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 46;
            label3.Text = "Müşteri Seçimi";
            // 
            // cmbMusteri
            // 
            cmbMusteri.FormattingEnabled = true;
            cmbMusteri.Location = new Point(134, 261);
            cmbMusteri.Name = "cmbMusteri";
            cmbMusteri.Size = new Size(151, 28);
            cmbMusteri.TabIndex = 45;
            // 
            // GelirGiderfrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pngtree_original_font_accounting_background_design_image_529231;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1202, 649);
            Controls.Add(label3);
            Controls.Add(cmbMusteri);
            Controls.Add(label7);
            Controls.Add(dtpBitis);
            Controls.Add(label8);
            Controls.Add(dtpBaslangic);
            Controls.Add(btnİptal);
            Controls.Add(btnListele);
            Controls.Add(dgwListele);
            Name = "GelirGiderfrm";
            Text = "GelirGiderfrm";
            Load += GelirGiderfrm_Load;
            ((System.ComponentModel.ISupportInitialize)dgwListele).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgwListele;
        private Button btnİptal;
        private Button btnListele;
        private Label label7;
        private DateTimePicker dtpBitis;
        private Label label8;
        private DateTimePicker dtpBaslangic;
        private Label label3;
        private ComboBox cmbMusteri;
    }
}
