namespace WinFormsApp1
{
    partial class MusteriEkleme
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
            txtTC = new TextBox();
            txtAdSoyad = new TextBox();
            txtYas = new TextBox();
            txtMeslek = new TextBox();
            cmbCinsiyet = new ComboBox();
            txtEkle = new Button();
            txtSil = new Button();
            txtSehir = new TextBox();
            txtBakiye = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtTC
            // 
            txtTC.Location = new Point(143, 77);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(155, 27);
            txtTC.TabIndex = 1;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(143, 112);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(155, 27);
            txtAdSoyad.TabIndex = 2;
            // 
            // txtYas
            // 
            txtYas.Location = new Point(143, 145);
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(155, 27);
            txtYas.TabIndex = 3;
            txtYas.TextChanged += txtYas_TextChanged;
            // 
            // txtMeslek
            // 
            txtMeslek.Location = new Point(143, 282);
            txtMeslek.Multiline = true;
            txtMeslek.Name = "txtMeslek";
            txtMeslek.Size = new Size(155, 30);
            txtMeslek.TabIndex = 7;
            txtMeslek.TextChanged += txtDetay_TextChanged;
            // 
            // cmbCinsiyet
            // 
            cmbCinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCinsiyet.FormattingEnabled = true;
            cmbCinsiyet.Items.AddRange(new object[] { "Erkek", "Kadın" });
            cmbCinsiyet.Location = new Point(143, 178);
            cmbCinsiyet.Name = "cmbCinsiyet";
            cmbCinsiyet.Size = new Size(155, 28);
            cmbCinsiyet.TabIndex = 4;
            // 
            // txtEkle
            // 
            txtEkle.BackgroundImage = Properties.Resources.müsteri_ekle1;
            txtEkle.BackgroundImageLayout = ImageLayout.Stretch;
            txtEkle.Location = new Point(68, 335);
            txtEkle.Name = "txtEkle";
            txtEkle.Size = new Size(136, 102);
            txtEkle.TabIndex = 8;
            txtEkle.UseVisualStyleBackColor = true;
            txtEkle.Click += txtEkle_Click;
            // 
            // txtSil
            // 
            txtSil.BackgroundImage = Properties.Resources._0cancel1;
            txtSil.BackgroundImageLayout = ImageLayout.Stretch;
            txtSil.Location = new Point(213, 335);
            txtSil.Name = "txtSil";
            txtSil.Size = new Size(136, 102);
            txtSil.TabIndex = 9;
            txtSil.UseVisualStyleBackColor = true;
            txtSil.Click += txtSil_Click;
            // 
            // txtSehir
            // 
            txtSehir.Location = new Point(143, 212);
            txtSehir.Name = "txtSehir";
            txtSehir.Size = new Size(155, 27);
            txtSehir.TabIndex = 5;
            // 
            // txtBakiye
            // 
            txtBakiye.Location = new Point(143, 245);
            txtBakiye.Name = "txtBakiye";
            txtBakiye.Size = new Size(155, 27);
            txtBakiye.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 77);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 4;
            label1.Text = "TC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 112);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 4;
            label2.Text = "AdSoyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 145);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 4;
            label3.Text = "Yas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 181);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 4;
            label4.Text = "Cinsiyet";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(90, 212);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 4;
            label5.Text = "Şehir";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(85, 252);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 4;
            label6.Text = "Bakiye";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(85, 285);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 4;
            label7.Text = "Meslek";
            // 
            // MusteriEkleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pngtree_original_font_accounting_background_design_image_529231;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1178, 533);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSil);
            Controls.Add(txtEkle);
            Controls.Add(cmbCinsiyet);
            Controls.Add(txtMeslek);
            Controls.Add(txtSehir);
            Controls.Add(txtBakiye);
            Controls.Add(txtYas);
            Controls.Add(txtAdSoyad);
            Controls.Add(txtTC);
            Name = "MusteriEkleme";
            Text = "Müsteri Ekleme";
            Load += MusteriEkleme_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtTC;
        private TextBox txtAdSoyad;
        private TextBox txtYas;
        private TextBox txtMeslek;
        private ComboBox cmbCinsiyet;
        private Button txtEkle;
        private Button txtSil;
        private TextBox txtSehir;
        private TextBox txtBakiye;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}