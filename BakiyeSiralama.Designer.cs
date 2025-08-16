namespace WinFormsApp1
{
    partial class BakiyeSiralama
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
            lblEnAzBakiye = new Label();
            label2 = new Label();
            lblEnCokBakiye = new Label();
            label1 = new Label();
            dgwMusteriListesi = new DataGridView();
            TC = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Adres = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            btnCikis = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwMusteriListesi).BeginInit();
            SuspendLayout();
            // 
            // lblEnAzBakiye
            // 
            lblEnAzBakiye.AutoSize = true;
            lblEnAzBakiye.Location = new Point(251, 93);
            lblEnAzBakiye.Name = "lblEnAzBakiye";
            lblEnAzBakiye.Size = new Size(0, 20);
            lblEnAzBakiye.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 93);
            label2.Name = "label2";
            label2.Size = new Size(191, 20);
            label2.TabIndex = 17;
            label2.Text = "En Az Bakiyesi Olan Müsteri";
            // 
            // lblEnCokBakiye
            // 
            lblEnCokBakiye.AutoSize = true;
            lblEnCokBakiye.Location = new Point(251, 58);
            lblEnCokBakiye.Name = "lblEnCokBakiye";
            lblEnCokBakiye.Size = new Size(0, 20);
            lblEnCokBakiye.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 58);
            label1.Name = "label1";
            label1.Size = new Size(199, 20);
            label1.TabIndex = 19;
            label1.Text = "En Cok Bakiyesi Olan Müsteri";
            // 
            // dgwMusteriListesi
            // 
            dgwMusteriListesi.AllowUserToOrderColumns = true;
            dgwMusteriListesi.BackgroundColor = Color.White;
            dgwMusteriListesi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwMusteriListesi.Columns.AddRange(new DataGridViewColumn[] { TC, Column1, Column3, Column4, Adres, Column2 });
            dgwMusteriListesi.Location = new Point(59, 142);
            dgwMusteriListesi.Name = "dgwMusteriListesi";
            dgwMusteriListesi.RowHeadersWidth = 51;
            dgwMusteriListesi.Size = new Size(692, 425);
            dgwMusteriListesi.TabIndex = 15;
            // 
            // TC
            // 
            TC.FillWeight = 50F;
            TC.HeaderText = "TC";
            TC.MinimumWidth = 6;
            TC.Name = "TC";
            TC.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "Ad Soyad";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 130;
            // 
            // Column3
            // 
            Column3.HeaderText = "Yas";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 45;
            // 
            // Column4
            // 
            Column4.HeaderText = "Cinsiyet";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 65;
            // 
            // Adres
            // 
            Adres.HeaderText = "Adres";
            Adres.MinimumWidth = 6;
            Adres.Name = "Adres";
            Adres.Width = 120;
            // 
            // Column2
            // 
            Column2.HeaderText = "Bakiye";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // btnCikis
            // 
            btnCikis.BackgroundImage = Properties.Resources._0cancel1;
            btnCikis.BackgroundImageLayout = ImageLayout.Stretch;
            btnCikis.Location = new Point(779, 479);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(94, 88);
            btnCikis.TabIndex = 20;
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // BakiyeSiralama
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pngtree_original_font_accounting_background_design_image_529231;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1159, 626);
            Controls.Add(btnCikis);
            Controls.Add(lblEnAzBakiye);
            Controls.Add(label2);
            Controls.Add(lblEnCokBakiye);
            Controls.Add(label1);
            Controls.Add(dgwMusteriListesi);
            Name = "BakiyeSiralama";
            Text = "BakiyeSiralama";
            Load += BakiyeSiralama_Load;
            ((System.ComponentModel.ISupportInitialize)dgwMusteriListesi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEnAzBakiye;
        private Label label2;
        private Label lblEnCokBakiye;
        private Label label1;
        private DataGridView dgwMusteriListesi;
        private DataGridViewTextBoxColumn TC;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Adres;
        private DataGridViewTextBoxColumn Column2;
        private Button btnCikis;
    }
}