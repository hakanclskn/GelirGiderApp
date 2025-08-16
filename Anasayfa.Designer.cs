namespace WinFormsApp1
{
    partial class Anasayfa
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
            btnMusteriListele = new Button();
            btnMusteriEkle = new Button();
            btnBakiyeSiralama = new Button();
            btnOdemeEkle = new Button();
            btnGiderEkle = new Button();
            SuspendLayout();
            // 
            // btnMusteriListele
            // 
            btnMusteriListele.Location = new Point(334, 100);
            btnMusteriListele.Name = "btnMusteriListele";
            btnMusteriListele.Size = new Size(221, 50);
            btnMusteriListele.TabIndex = 0;
            btnMusteriListele.Text = "Müsteri Listele";
            btnMusteriListele.UseVisualStyleBackColor = true;
            btnMusteriListele.Click += btnMusteriListele_Click;
            // 
            // btnMusteriEkle
            // 
            btnMusteriEkle.Location = new Point(334, 35);
            btnMusteriEkle.Name = "btnMusteriEkle";
            btnMusteriEkle.Size = new Size(221, 50);
            btnMusteriEkle.TabIndex = 1;
            btnMusteriEkle.Text = "Müsteri Ekle";
            btnMusteriEkle.UseVisualStyleBackColor = true;
            btnMusteriEkle.Click += btnMusteriEkle_Click;
            // 
            // btnBakiyeSiralama
            // 
            btnBakiyeSiralama.Location = new Point(334, 295);
            btnBakiyeSiralama.Name = "btnBakiyeSiralama";
            btnBakiyeSiralama.Size = new Size(221, 50);
            btnBakiyeSiralama.TabIndex = 1;
            btnBakiyeSiralama.Text = "Bakiye Siralama";
            btnBakiyeSiralama.UseVisualStyleBackColor = true;
            btnBakiyeSiralama.Click += btnBakiyeSiralama_Click;
            // 
            // btnOdemeEkle
            // 
            btnOdemeEkle.Location = new Point(334, 165);
            btnOdemeEkle.Name = "btnOdemeEkle";
            btnOdemeEkle.Size = new Size(221, 50);
            btnOdemeEkle.TabIndex = 2;
            btnOdemeEkle.Text = "Gelir Ekle";
            btnOdemeEkle.UseVisualStyleBackColor = true;
            btnOdemeEkle.Click += btnOdemeEkle_Click;
            // 
            // btnGiderEkle
            // 
            btnGiderEkle.Location = new Point(334, 230);
            btnGiderEkle.Name = "btnGiderEkle";
            btnGiderEkle.Size = new Size(221, 50);
            btnGiderEkle.TabIndex = 2;
            btnGiderEkle.Text = "Gider Ekle";
            btnGiderEkle.UseVisualStyleBackColor = true;
            btnGiderEkle.Click += btnGiderEkle_Click;
            // 
            // Anasayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.images__2_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(989, 450);
            Controls.Add(btnGiderEkle);
            Controls.Add(btnOdemeEkle);
            Controls.Add(btnBakiyeSiralama);
            Controls.Add(btnMusteriEkle);
            Controls.Add(btnMusteriListele);
            Name = "Anasayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnaSayfa";
            Load += Anasayfa_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnMusteriListele;
        private Button btnMusteriEkle;
        private Button btnBakiyeSiralama;
        private Button btnOdemeEkle;
        private Button btnGiderEkle;
    }
}