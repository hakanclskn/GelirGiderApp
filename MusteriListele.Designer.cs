namespace WinFormsApp1
{
    partial class MusteriListele
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
            btnİptal = new Button();
            btnGüncelle = new Button();
            cmbCinsiyet = new ComboBox();
            txtSehir = new TextBox();
            txtBakiye = new TextBox();
            txtYas = new TextBox();
            txtAdSoyad = new TextBox();
            txtTC = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            txtTcAra = new TextBox();
            btnSil = new Button();
            lvMusteriler = new ListView();
            label7 = new Label();
            txtMeslek = new TextBox();
            btnAra = new Button();
            SuspendLayout();
            // 
            // btnİptal
            // 
            btnİptal.BackgroundImage = Properties.Resources._0cancel1;
            btnİptal.BackgroundImageLayout = ImageLayout.Stretch;
            btnİptal.Location = new Point(191, 401);
            btnİptal.Name = "btnİptal";
            btnİptal.Size = new Size(103, 100);
            btnİptal.TabIndex = 24;
            btnİptal.UseVisualStyleBackColor = true;
            btnİptal.Click += txtİptal_Click;
            // 
            // btnGüncelle
            // 
            btnGüncelle.BackgroundImage = Properties.Resources.güncelle_icon;
            btnGüncelle.BackgroundImageLayout = ImageLayout.Stretch;
            btnGüncelle.Location = new Point(78, 401);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(103, 100);
            btnGüncelle.TabIndex = 25;
            btnGüncelle.UseVisualStyleBackColor = true;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // cmbCinsiyet
            // 
            cmbCinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCinsiyet.FormattingEnabled = true;
            cmbCinsiyet.Items.AddRange(new object[] { "Erkek", "Kadın" });
            cmbCinsiyet.Location = new Point(139, 225);
            cmbCinsiyet.Name = "cmbCinsiyet";
            cmbCinsiyet.Size = new Size(155, 28);
            cmbCinsiyet.TabIndex = 23;
            // 
            // txtSehir
            // 
            txtSehir.Location = new Point(139, 259);
            txtSehir.Name = "txtSehir";
            txtSehir.Size = new Size(155, 27);
            txtSehir.TabIndex = 18;
            // 
            // txtBakiye
            // 
            txtBakiye.Location = new Point(139, 292);
            txtBakiye.Name = "txtBakiye";
            txtBakiye.Size = new Size(155, 27);
            txtBakiye.TabIndex = 19;
            // 
            // txtYas
            // 
            txtYas.Location = new Point(139, 192);
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(155, 27);
            txtYas.TabIndex = 20;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(139, 159);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(155, 27);
            txtAdSoyad.TabIndex = 21;
            // 
            // txtTC
            // 
            txtTC.Location = new Point(139, 124);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(155, 27);
            txtTC.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(71, 299);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 27;
            label6.Text = "Bakiye";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 259);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 28;
            label5.Text = "Şehir";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 228);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 29;
            label4.Text = "Cinsiyet";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 192);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 30;
            label3.Text = "Yas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 162);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 31;
            label2.Text = "AdSoyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 124);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 32;
            label1.Text = "TC";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(336, 26);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 32;
            label8.Text = "TC Ara";
            // 
            // txtTcAra
            // 
            txtTcAra.Location = new Point(407, 23);
            txtTcAra.Name = "txtTcAra";
            txtTcAra.Size = new Size(155, 27);
            txtTcAra.TabIndex = 22;
            // 
            // btnSil
            // 
            btnSil.BackgroundImage = Properties.Resources.delete_icon1;
            btnSil.BackgroundImageLayout = ImageLayout.Stretch;
            btnSil.Location = new Point(936, 440);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(111, 100);
            btnSil.TabIndex = 25;
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // lvMusteriler
            // 
            lvMusteriler.FullRowSelect = true;
            lvMusteriler.GridLines = true;
            lvMusteriler.Location = new Point(314, 80);
            lvMusteriler.Name = "lvMusteriler";
            lvMusteriler.Size = new Size(804, 342);
            lvMusteriler.TabIndex = 33;
            lvMusteriler.UseCompatibleStateImageBehavior = false;
            lvMusteriler.View = View.Details;
            lvMusteriler.SelectedIndexChanged += lvMusteriler_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(68, 325);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 35;
            label7.Text = "Meslek";
            // 
            // txtMeslek
            // 
            txtMeslek.Location = new Point(140, 325);
            txtMeslek.Name = "txtMeslek";
            txtMeslek.Size = new Size(155, 27);
            txtMeslek.TabIndex = 34;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(593, 23);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(94, 29);
            btnAra.TabIndex = 36;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // MusteriListele
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pngtree_business_finance_account_accounting_background_photo_image_2786642;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1143, 624);
            Controls.Add(btnAra);
            Controls.Add(label7);
            Controls.Add(txtMeslek);
            Controls.Add(lvMusteriler);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(btnİptal);
            Controls.Add(btnSil);
            Controls.Add(btnGüncelle);
            Controls.Add(cmbCinsiyet);
            Controls.Add(txtSehir);
            Controls.Add(txtBakiye);
            Controls.Add(txtYas);
            Controls.Add(txtAdSoyad);
            Controls.Add(txtTcAra);
            Controls.Add(txtTC);
            Name = "MusteriListele";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MüsteriListele";
            Load += MusteriListele_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnİptal;
        private Button btnGüncelle;
        private ComboBox cmbCinsiyet;
        private TextBox txtSehir;
        private TextBox txtBakiye;
        private TextBox txtYas;
        private TextBox txtAdSoyad;
        private TextBox txtTC;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private TextBox txtTcAra;
        private Button btnSil;
        private ListView lvMusteriler;
        private Label label7;
        private TextBox txtMeslek;
        private Button btnAra;
    }
}