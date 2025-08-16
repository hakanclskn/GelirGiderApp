using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class GelirGiderfrm : Form
    {
        public GelirGiderfrm()
        {
            InitializeComponent();
        }

        private void GelirGiderfrm_Load(object sender, EventArgs e)
        {
            dgwListele.Columns.Clear();
            dgwListele.Columns.Add("TC", "TC");
            dgwListele.Columns.Add("AdiSoyadi", "İsim Soyisim");
            dgwListele.Columns.Add("Tutar", "Tutar");
            dgwListele.Columns.Add("Tur", "Tur");
            dgwListele.Columns.Add("Aciklama", "Açıklama");
            dgwListele.Columns.Add("Tarih", "Tarih");
            dgwListele.Columns.Add("Bakiye", "Bakiye");


            try
            {
                using (SqlConnection con = new SqlConnection(
                    "Server=.\\SQLEXPRESS;Database=GelirGiderApp;Trusted_Connection=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    string sql = "SELECT Id, AdiSoyadi FROM Musteriler ORDER BY AdiSoyadi";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            cmbMusteri.Items.Clear();
                            while (reader.Read())
                            {
                                cmbMusteri.Items.Add(reader["AdiSoyadi"].ToString());
                            }
                        }
                    }
                }

                if (cmbMusteri.Items.Count > 0)
                    cmbMusteri.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteriler listelenirken hata oluştu: " + ex.Message);
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            if (cmbMusteri.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir müşteri seçin!");
                return;
            }

            string secilenMusteri = cmbMusteri.SelectedItem.ToString();

            try
            {
                using (SqlConnection con = new SqlConnection(
                    "Server=.\\SQLEXPRESS;Database=GelirGiderApp;Trusted_Connection=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    string sql = @"
                SELECT m.TC, m.AdiSoyadi, o.Tutar, 'Gelir' AS Tur, o.Aciklama, o.OdemeTarihi AS Tarih
                FROM Odeme o
                INNER JOIN Musteriler m ON o.MusteriID = m.Id
                WHERE m.AdiSoyadi = @AdiSoyadi

                UNION ALL

                SELECT m.TC, m.AdiSoyadi, g.Tutar, 'Gider' AS Tur, '' AS Aciklama, g.OdemeTarihi AS Tarih
                FROM Giderler g
                INNER JOIN Musteriler m ON g.MusteriID = m.Id
                WHERE m.AdiSoyadi = @AdiSoyadi
                ORDER BY Tarih";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@AdiSoyadi", secilenMusteri);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            dgwListele.Rows.Clear();
                            decimal bakiye = 0;

                            while (reader.Read())
                            {
                                decimal tutar = Convert.ToDecimal(reader["Tutar"]);
                                string tur = reader["Tur"].ToString();

                                if (tur == "Gelir") bakiye += tutar;
                                else bakiye -= tutar;

                                dgwListele.Rows.Add(
                                    reader["TC"],
                                    reader["AdiSoyadi"],
                                    tutar,
                                    tur,
                                    reader["Aciklama"],
                                    reader["Tarih"],
                                    bakiye
                                );
                            }

                            if (dgwListele.Rows.Count == 0)
                                MessageBox.Show("Seçilen müşteri için kayıt bulunamadı.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıtlar listelenirken hata oluştu: " + ex.Message);
            }
        }


        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
