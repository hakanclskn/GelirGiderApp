using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class OdemeEkle : Form
    {
        private string connectionString = @"Server=.\SQLEXPRESS;Database=GelirGiderApp;Trusted_Connection=True;TrustServerCertificate=True;";

        public OdemeEkle()
        {
            InitializeComponent();
            btnKaydet.Click += btnKaydet_Click;
        }

        private void OdemeEkle_Load(object sender, EventArgs e)
        {
            // NumericUpDown ayarları
            nudTutar.Minimum = 0;
            nudTutar.Maximum = 1000000;  // İhtiyaca göre artırabilirsin
            nudTutar.DecimalPlaces = 2;   // Virgüllü değer girişi için
            nudTutar.Increment = 1;       // Artış miktarı

            // Formun başlangıç konumu ortada olsun
            this.StartPosition = FormStartPosition.CenterScreen;

            // Form sabit olsun, boyutu değiştirilemesin
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            // Minimize ve Maximize kapalı
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.Visible = true;
            this.TopMost = true;

            MusteriListele();
            OdemeleriListele();
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

        private void OdemeleriListele(DateTime? baslangic = null, DateTime? bitis = null)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    string sql = @"
                SELECT g.OdemeID, m.AdiSoyadi AS MusteriAdi, g.Tutar, g.OdemeTarihi
                FROM Odeme g
                INNER JOIN Musteriler m ON g.MusteriID = m.Id
                WHERE (@Baslangic IS NULL OR g.OdemeTarihi >= @Baslangic)
                  AND (@Bitis IS NULL OR g.OdemeTarihi <= @Bitis)
                ORDER BY g.OdemeTarihi DESC";

                    var odemeler = conn.Query(sql, new { Baslangic = baslangic, Bitis = bitis }).ToList();
                    dgwMusteriCek.DataSource = odemeler;

                    // Toplam tutarı hesapla
                    decimal toplam = odemeler.Sum(x => (decimal)x.Tutar);
                    lblToplamTutar.Text = "Toplam Tutar: " + toplam.ToString("C"); // Para birimi formatı
                }

                dgwMusteriCek.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                if (dgwMusteriCek.Columns["OdemeID"] != null)
                    dgwMusteriCek.Columns["OdemeID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ödeme listelenirken hata oluştu: " + ex.Message);
            }
        }



        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbMusteri.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir müşteri seçin!");
                return;
            }

            decimal tutar = nudTutar.Value;

            var odeme = new
            {
                MusteriID = (int)cmbMusteri.SelectedValue,
                Tutar = tutar,
                OdemeTarihi = dtpOdemeTarihi.Value.Date
            };

            string sql = @"INSERT INTO Odeme (MusteriID, Tutar, OdemeTarihi) 
                           VALUES (@MusteriID, @Tutar, @OdemeTarihi)";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Execute(sql, odeme);
                }

                lblDurum.Text = "✅ Ödeme başarıyla eklendi.";
                lblDurum.ForeColor = Color.Green;

                nudTutar.Value = 0;
                dtpOdemeTarihi.Value = DateTime.Today;

                // Listeyi yenile
                OdemeleriListele();
            }
            catch (Exception ex)
            {
                lblDurum.Text = "❌ Hata: " + ex.Message;
                lblDurum.ForeColor = Color.Red;
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            // Tarih filtrelerini uygula
            DateTime baslangic = dtpBaslangic.Value.Date;
            DateTime bitis = dtpBitis.Value.Date;

            OdemeleriListele(baslangic, bitis);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
