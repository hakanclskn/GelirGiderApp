using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class BakiyeSiralama : Form
    {
        public BakiyeSiralama()
        {
            InitializeComponent();
        }

        private void BakiyeSiralama_Load(object sender, EventArgs e)
        {


            // Formun başlangıç konumu ortada olsun
            this.StartPosition = FormStartPosition.CenterScreen;

            // Form sabit olsun, boyutu değiştirilemesin
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            // Minimize ve Maximize kapalı
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.Visible = true;
            this.TopMost = true;

            try
            {
                using (SqlConnection con = new SqlConnection(
                    "Server=.\\SQLEXPRESS;Database=GelirGiderApp;Trusted_Connection=True;TrustServerCertificate=True"))
                {
                    con.Open();

                    // Tüm müşterileri bakiye sırasına göre listele
                    string sql = @"
                        SELECT Id, TC, AdiSoyadi, Yasi, Cinsiyet, Sehir, Bakiye
                        FROM Musteriler
                        ORDER BY Bakiye DESC";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dgwMusteriListesi.Rows.Clear();

                        while (reader.Read())
                        {
                            dgwMusteriListesi.Rows.Add(
                                reader["TC"].ToString(),
                                reader["AdiSoyadi"].ToString(),
                                reader["Yasi"].ToString(),
                                reader["Cinsiyet"].ToString(),
                                reader["Sehir"].ToString(),
                                reader["Bakiye"].ToString()
                            );
                        }
                    }

                    // En çok bakiyesi olan müşteri
                    using (SqlCommand cmdMax = new SqlCommand(
                        "SELECT TOP 1 AdiSoyadi, Bakiye FROM Musteriler ORDER BY Bakiye DESC", con))
                    using (SqlDataReader readerMax = cmdMax.ExecuteReader())
                    {
                        if (readerMax.Read())
                        {
                            lblEnCokBakiye.Text = $"{readerMax["AdiSoyadi"]} = {readerMax["Bakiye"]} ₺";
                        }
                    }

                    // En az bakiyesi olan müşteri
                    using (SqlCommand cmdMin = new SqlCommand(
                        "SELECT TOP 1 AdiSoyadi, Bakiye FROM Musteriler ORDER BY Bakiye ASC", con))
                    using (SqlDataReader readerMin = cmdMin.ExecuteReader())
                    {
                        if (readerMin.Read())
                        {
                            lblEnAzBakiye.Text = $"{readerMin["AdiSoyadi"]} = {readerMin["Bakiye"]} ₺";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteri listelenirken hata oluştu: " + ex.Message);
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
