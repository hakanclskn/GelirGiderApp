using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FrmOdemeGoruntuleme : Form
    {
        private object odemeler;

        public FrmOdemeGoruntuleme()
        {
            // Formun başlangıç konumu ortada olsun
            this.StartPosition = FormStartPosition.CenterScreen;

            // Form sabit olsun, boyutu değiştirilemesin
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            // Minimize ve Maximize kapalı
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            InitializeComponent();
        }

        private void FrmOdemeGoruntuleme_Load(object sender, EventArgs e)
        {
            MusteriListele();
            btnTemizle_Click(null, null); // Filtreleri sıfırla
        }

        private void MusteriListele()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            var baslangic = dtpBaslangic.Value.Date;
            var bitis = dtpBitis.Value.Date;
            var musteriId = (int)cmbMusteri.SelectedValue;

            string query = @"SELECT OdemeTarihi, Tutar, Aciklama FROM Odeme  
                            WHERE MusteriID = @MusteriID AND OdemeTarihi BETWEEN @Baslangic AND @Bitis ORDER BY OdemeTarihi";

            using (var conn = new SqlConnection())
            {
                var odemeler = conn.Query<dynamic>(query, new { MusteriID = musteriId, Baslangic = baslangic, Bitis = bitis }).ToList();
                dgvOdemeler.DataSource = odemeler;

                // 🧮 Toplam Tutar Hesapla  
                decimal toplam = odemeler.Sum(x => (decimal)x.Tutar);
                lblToplamTutar.Text = $"Toplam: {toplam:C2}";
            }

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            // Tarih alanlarını bugüne sıfırla
            dtpBaslangic.Value = DateTime.Today;
            dtpBitis.Value = DateTime.Today;

            // ComboBox sıfırla (ilk müşteriyi seç)
            if (cmbMusteri.Items.Count > 0)
                cmbMusteri.SelectedIndex = 0;

            // DataGridView temizle
            dgvOdemeler.DataSource = null;

            // Toplam tutarı sıfırla
            lblToplamTutar.Text = "Toplam: 0 ₺";
        }
    }
}
