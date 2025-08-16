using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MusteriListele : Form
    {
        private string connectionString = "Server=.\\SQLEXPRESS;Database=GelirGiderApp;Trusted_Connection=True;TrustServerCertificate=True;";

        public MusteriListele()
        {
            InitializeComponent();
        }

        private void MusteriListele_Load(object sender, EventArgs e)
        {
            // Formun başlangıç konumu ortada olsun
            this.StartPosition = FormStartPosition.CenterScreen;

            // Form sabit olsun, boyutu değiştirilemesin
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            // Minimize ve Maximize kapalı
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            cmbCinsiyet.SelectedIndex = 0;

            // ListView kolonlarını sadece bir kere ekle
            if (lvMusteriler.Columns.Count == 0)
            {
                lvMusteriler.Columns.Add("ID", 50);
                lvMusteriler.Columns.Add("TC", 100);
                lvMusteriler.Columns.Add("Ad Soyad", 120);
                lvMusteriler.Columns.Add("Yaş", 40);
                lvMusteriler.Columns.Add("Şehir", 120);
                lvMusteriler.Columns.Add("Cinsiyet", 70);
                lvMusteriler.Columns.Add("Bakiye", 150);
                lvMusteriler.Columns.Add("Meslek", 125);
            }

            MusterileriYukle();
        }

        private void MusterileriYukle(string tc = "")
        {
            try
            {
                lvMusteriler.BeginUpdate();
                lvMusteriler.Items.Clear();

                using (var conn = new SqlConnection(connectionString))
                {
                    string sql = "SELECT * FROM Musteriler WHERE 1=1";
                    DynamicParameters param = new DynamicParameters();

                    if (!string.IsNullOrEmpty(tc))
                    {
                        sql += " AND TC LIKE @TC";
                        param.Add("@TC", $"%{tc}%");
                    }
                    sql += " ORDER BY Id ASC";

                    var liste = conn.Query<Musteri>(sql, param).ToList();

                    foreach (var m in liste)
                    {
                        var item = new ListViewItem(m.Id.ToString());
                        item.SubItems.Add(m.TC);
                        item.SubItems.Add(m.AdiSoyadi);
                        item.SubItems.Add(m.Yasi.ToString());
                        item.SubItems.Add(m.Sehir);
                        item.SubItems.Add(m.Cinsiyet);
                        item.SubItems.Add(m.Bakiye.ToString("N2"));
                        item.SubItems.Add(m.Meslek);

                        lvMusteriler.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteriler listelenirken hata oluştu: " + ex.Message);
            }
            finally
            {
                lvMusteriler.EndUpdate();
            }
        }

        private void MusterileriYukle()
        {
            try
            {
                lvMusteriler.BeginUpdate();
                lvMusteriler.Items.Clear();

                using (var conn = new SqlConnection(connectionString))
                {
                    string sql = "SELECT * FROM Musteriler ORDER BY Id ASC";
                    var liste = conn.Query<Musteri>(sql).ToList();

                    foreach (var m in liste)
                    {
                        var item = new ListViewItem(m.Id.ToString());
                        item.SubItems.Add(m.TC);
                        item.SubItems.Add(m.AdiSoyadi);
                        item.SubItems.Add(m.Yasi.ToString());
                        item.SubItems.Add(m.Sehir);
                        item.SubItems.Add(m.Cinsiyet);
                        item.SubItems.Add(m.Bakiye.ToString("N2"));
                        item.SubItems.Add(m.Meslek);

                        lvMusteriler.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteriler listelenirken hata oluştu: " + ex.Message);
            }
            finally
            {
                lvMusteriler.EndUpdate();
            }
        }

        // İstersen yenileme için bir buton ekleyip aşağıdaki kodu bağlayabilirsin
        private void btnYenile_Click(object sender, EventArgs e)
        {
            MusterileriYukle();
        }

        private void lvMusteriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMusteriler.SelectedItems.Count > 0)
            {
                var item = lvMusteriler.SelectedItems[0];
                txtTC.Text = item.SubItems[1].Text;
                txtAdSoyad.Text = item.SubItems[2].Text;
                txtYas.Text = item.SubItems[3].Text;
                txtSehir.Text = item.SubItems[4].Text;
                cmbCinsiyet.Text = item.SubItems[5].Text;
                txtBakiye.Text = item.SubItems[6].Text;
                txtMeslek.Text = item.SubItems[7].Text;
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            MusterileriYukle(txtTcAra.Text);
        }

        private void txtİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Listele()
        {
            lvMusteriler.Items.Clear();

            using (var connection = new SqlConnection("Server=.\\SQLEXPRESS;Database=GelirGiderApp;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                connection.Open();

                string query = "SELECT TC, AdiSoyadi, Yasi, Cinsiyet, Sehir, Meslek, Bakiye FROM Musteriler";
                using (var command = new SqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["TC"].ToString());
                        item.SubItems.Add(reader["AdiSoyadi"].ToString());
                        item.SubItems.Add(reader["Yasi"].ToString());
                        item.SubItems.Add(reader["Cinsiyet"].ToString());
                        item.SubItems.Add(reader["Sehir"].ToString());
                        item.SubItems.Add(reader["Meslek"].ToString());
                        item.SubItems.Add(reader["Bakiye"].ToString());

                        lvMusteriler.Items.Add(item);
                    }
                }
            }
        }


        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (lvMusteriler.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen güncellenecek müşteriyi seçin.");
                return;
            }

            // TC'yi doğru SubItems indeksinden al ve trim et
            string tc = lvMusteriler.SelectedItems[0].SubItems[1].Text.Trim();

            // Yeni değerleri al
            string adiSoyadi = txtAdSoyad.Text.Trim();
            int yasi = int.TryParse(txtYas.Text, out int yas) ? yas : 0;
            string cinsiyet = cmbCinsiyet.Text.Trim();
            string sehir = txtSehir.Text.Trim();
            string meslek = txtMeslek.Text.Trim();
            decimal bakiye = decimal.TryParse(txtBakiye.Text, out decimal b) ? b : 0;

            string connectionString = "Server=.\\SQLEXPRESS;Database=GelirGiderApp;Trusted_Connection=True;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Önce TC ile eşleşen satır var mı kontrol et
                string kontrolSql = "SELECT COUNT(*) FROM Musteriler WHERE LTRIM(RTRIM(TC)) = @TC";
                using (SqlCommand kontrolCmd = new SqlCommand(kontrolSql, conn))
                {
                    kontrolCmd.Parameters.AddWithValue("@TC", tc);
                    int count = (int)kontrolCmd.ExecuteScalar();
                    if (count == 0)
                    {
                        MessageBox.Show("Veritabanında bu TC ile eşleşen müşteri bulunamadı!");
                        return;
                    }
                }

                // Güncelleme
                string sql = @"UPDATE Musteriler
                       SET AdiSoyadi = @AdiSoyadi,
                           Yasi = @Yasi,
                           Cinsiyet = @Cinsiyet,
                           Sehir = @Sehir,
                           Meslek = @Meslek,
                           Bakiye = @Bakiye
                       WHERE LTRIM(RTRIM(TC)) = @TC";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@AdiSoyadi", adiSoyadi);
                    cmd.Parameters.AddWithValue("@Yasi", yasi);
                    cmd.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
                    cmd.Parameters.AddWithValue("@Sehir", sehir);
                    cmd.Parameters.AddWithValue("@Meslek", meslek);
                    cmd.Parameters.AddWithValue("@Bakiye", bakiye);
                    cmd.Parameters.AddWithValue("@TC", tc);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Müşteri başarıyla güncellendi.");

                        // ListView'i güncelle
                        var selectedItem = lvMusteriler.SelectedItems[0];
                        selectedItem.SubItems[2].Text = adiSoyadi;
                        selectedItem.SubItems[3].Text = yasi.ToString();
                        selectedItem.SubItems[5].Text = cinsiyet;
                        selectedItem.SubItems[4].Text = sehir;
                        selectedItem.SubItems[7].Text = meslek;
                        selectedItem.SubItems[6].Text = bakiye.ToString("N2");

                        MusterileriYukle();
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme sırasında bir hata oluştu!");
                    }
                    MusterileriYukle();
                }
            }
        }





        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lvMusteriler.SelectedItems.Count > 0)
            {
                string tc = lvMusteriler.SelectedItems[0].SubItems[0].Text;

                using (var connection = new SqlConnection("Server=.\\SQLEXPRESS;Database=GelirGiderApp;Trusted_Connection=True;TrustServerCertificate=True;"))
                {
                    connection.Open();
                    string query = "DELETE FROM Musteriler WHERE TC = @tc";
                    using (var cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@tc", tc);
                        cmd.ExecuteNonQuery();
                    }
                }

                lvMusteriler.Items.Remove(lvMusteriler.SelectedItems[0]); // ListView’den de sil
            }
        }

    }
}
