namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnİslem = new Button();
            txtGelir = new TextBox();
            txtGider = new TextBox();
            txtSoyİsim = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtİsim = new TextBox();
            txtTC = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            TC = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Tutar = new DataGridViewTextBoxColumn();
            GelirGider = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnİslem
            // 
            btnİslem.Location = new Point(174, 220);
            btnİslem.Name = "btnİslem";
            btnİslem.Size = new Size(94, 29);
            btnİslem.TabIndex = 0;
            btnİslem.Text = "İslemYap";
            btnİslem.UseVisualStyleBackColor = true;
            // 
            // txtGelir
            // 
            txtGelir.Location = new Point(143, 125);
            txtGelir.Name = "txtGelir";
            txtGelir.Size = new Size(125, 27);
            txtGelir.TabIndex = 1;
            // 
            // txtGider
            // 
            txtGider.Location = new Point(143, 167);
            txtGider.Name = "txtGider";
            txtGider.Size = new Size(125, 27);
            txtGider.TabIndex = 2;
            // 
            // txtSoyİsim
            // 
            txtSoyİsim.Location = new Point(144, 92);
            txtSoyİsim.Name = "txtSoyİsim";
            txtSoyİsim.Size = new Size(125, 27);
            txtSoyİsim.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 125);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 4;
            label1.Text = "Gelir";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 167);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 4;
            label2.Text = "Gider";
            // 
            // txtİsim
            // 
            txtİsim.Location = new Point(144, 59);
            txtİsim.Name = "txtİsim";
            txtİsim.Size = new Size(125, 27);
            txtİsim.TabIndex = 3;
            // 
            // txtTC
            // 
            txtTC.Location = new Point(144, 26);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(125, 27);
            txtTC.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 59);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 5;
            label3.Text = "İsim";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 92);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 5;
            label4.Text = "Soyİsim";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(72, 26);
            label5.Name = "label5";
            label5.Size = new Size(25, 20);
            label5.TabIndex = 5;
            label5.Text = "TC";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TC, Column1, Column2, Column4, Column3, Column5, Column6, Tutar, GelirGider });
            dataGridView1.Location = new Point(301, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(768, 335);
            dataGridView1.TabIndex = 6;
            // 
            // TC
            // 
            TC.FillWeight = 50F;
            TC.HeaderText = "TC";
            TC.MinimumWidth = 6;
            TC.Name = "TC";
            // 
            // Column1
            // 
            Column1.HeaderText = "İsim Soyİsim";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Bakiye";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 75;
            // 
            // Column4
            // 
            Column4.HeaderText = "Gider";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 60;
            // 
            // Column3
            // 
            Column3.HeaderText = "Gelir";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 60;
            // 
            // Column5
            // 
            Column5.HeaderText = "Müsteri Detayi";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 75;
            // 
            // Column6
            // 
            Column6.HeaderText = "Tarih";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // Tutar
            // 
            Tutar.HeaderText = "GelirGider";
            Tutar.MinimumWidth = 6;
            Tutar.Name = "Tutar";
            Tutar.Width = 85;
            // 
            // GelirGider
            // 
            GelirGider.HeaderText = "Tutar";
            GelirGider.MinimumWidth = 6;
            GelirGider.Name = "GelirGider";
            GelirGider.Width = 60;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 568);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTC);
            Controls.Add(txtİsim);
            Controls.Add(txtSoyİsim);
            Controls.Add(txtGider);
            Controls.Add(txtGelir);
            Controls.Add(btnİslem);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnİslem;
        private TextBox txtGelir;
        private TextBox txtGider;
        private TextBox txtSoyİsim;
        private Label label1;
        private Label label2;
        private TextBox txtİsim;
        private TextBox txtTC;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn TC;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Tutar;
        private DataGridViewTextBoxColumn GelirGider;
    }
}
