using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class GiderEkle : Form
    {
        private string connectionString = @"Server=.\SQLEXPRESS;Database=GelirGiderApp;Trusted_Connection=True;TrustServerCertificate=True;";

        public GiderEkle()
        {
            InitializeComponent();
            btnOnayla.Click += btnOnayla_Click;
            btnListele.Click += btnListele_Click;

            // Formun başlangıç konumu ortada olsun
            this.StartPosition = FormStartPosition.CenterScreen;

            // Form sabit olsun, boyutu değiştirilemesin
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            // Minimize ve Maximize kapalı
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            
        }

        private void GiderEkle_Load(object sender, EventArgs e)
        {
            // NumericUpDown ayarları
            nudTutar.Minimum = 0;
            nudTutar.Maximum = 1000000;  // İhtiyaca göre artırabilirsin
            nudTutar.DecimalPlaces = 2;   // Virgüllü değer girişi için
            nudTutar.Increment = 1;       // Artış miktarı

            MusteriListele();
            GiderleriListele();
        }

        private void MusteriListele()
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    var musteriler = conn.Query("SELECT Id, AdiSoyadi FROM Musteriler").ToList();
                    cmbMusteri.DataSource = musteriler;
                    cmbMusteri.DisplayMember = "AdiSoyadi";
                    cmbMusteri.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteri listelenirken hata oluştu: " + ex.Message);
            }
        }

        private void GiderleriListele(int? musteriId = null, DateTime? baslangic = null, DateTime? bitis = null)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    string sql = @"
                        SELECT g.GiderID, m.AdiSoyadi AS MusteriAdi, g.Tutar, g.OdemeTarihi
                        FROM Giderler g
                        INNER JOIN Musteriler m ON g.MusteriID = m.Id
                        WHERE (@MusteriID IS NULL OR g.MusteriID = @MusteriID)
                        AND (@Baslangic IS NULL OR g.OdemeTarihi >= @Baslangic)
                        AND (@Bitis IS NULL OR g.OdemeTarihi <= @Bitis)
                        ORDER BY g.OdemeTarihi DESC";

                    var giderler = conn.Query(sql, new { MusteriID = musteriId, Baslangic = baslangic, Bitis = bitis }).ToList();
                    dgwMusteriCek.DataSource = giderler;

                    // Toplam tutarı hesapla
                    decimal toplam = giderler.Sum(x => (decimal)x.Tutar);
                    lblToplamTutar.Text = "Toplam Gider: " + toplam.ToString("N2");
                }

                dgwMusteriCek.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                if (dgwMusteriCek.Columns["GiderID"] != null)
                    dgwMusteriCek.Columns["GiderID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giderler listelenirken hata oluştu: " + ex.Message);
            }
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (cmbMusteri.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir müşteri seçin!");
                return;
            }

            var gider = new
            {
                MusteriID = (int)cmbMusteri.SelectedValue,
                Tutar = nudTutar.Value,
                OdemeTarihi = dtpGiderTarihi.Value.Date
            };

            string sql = @"INSERT INTO Giderler (MusteriID, Tutar, OdemeTarihi)
                           VALUES (@MusteriID, @Tutar, @OdemeTarihi)";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Execute(sql, gider);
                }

                lblDurum.Text = "✅ Gider başarıyla eklendi";
                lblDurum.ForeColor = Color.Green;

                nudTutar.Value = 0;
                dtpGiderTarihi.Value = DateTime.Today;

                // Listeyi yenile
                GiderleriListele();
            }
            catch (Exception ex)
            {
                lblDurum.Text = "❌ Hata: " + ex.Message;
                lblDurum.ForeColor = Color.Red;
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            int? musteriId = cmbMusteri.SelectedItem != null ? (int?)cmbMusteri.SelectedValue : null;
            DateTime? baslangic = dtpBaslangic.Value.Date;
            DateTime? bitis = dtpBitis.Value.Date;

            GiderleriListele(musteriId, baslangic, bitis);
        }

       /* private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       */
        private void btnCikis_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
