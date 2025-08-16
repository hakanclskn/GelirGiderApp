using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MusteriEkleme : Form
    {
        public MusteriEkleme()
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

        private void txtEkle_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtTC.Text) || string.IsNullOrWhiteSpace(txtAdSoyad.Text))
            {
                MessageBox.Show("Lütfen TC ve Ad Soyad alanlarını doldurunuz.");
                return;
            }

            try
            {
                var musteri = new Musteri
                {
                    TC = txtTC.Text.Trim(),
                    AdiSoyadi = txtAdSoyad.Text.Trim(),
                    Yasi = int.TryParse(txtYas.Text, out int yas) ? yas : 0,
                    Bakiye = decimal.TryParse(txtBakiye.Text, out decimal b) ? b : 0,
                    Meslek = txtMeslek.Text.Trim(),
                    Sehir = txtSehir.Text.Trim(),
                    Cinsiyet = cmbCinsiyet.SelectedItem?.ToString() ?? ""  // Burada seçilen cinsiyeti alıyoruz

                };

                string connStr = ConfigurationManager
                    .ConnectionStrings["Veritabani"].ConnectionString;

                string sql = @"INSERT INTO Musteriler 
            (TC, AdiSoyadi, Yasi, Bakiye, Meslek, Cinsiyet, Sehir)
            VALUES 
            (@TC, @AdiSoyadi, @Yasi, @Bakiye, @Meslek, @Cinsiyet, @Sehir);";

                using (var conn = new SqlConnection(connStr))
                {
                    conn.Execute(sql, musteri);
                }

                MessageBox.Show("Müşteri başarıyla eklendi.");

                // Form temizliği
                txtTC.Clear();
                txtAdSoyad.Clear();
                txtYas.Clear();
                cmbCinsiyet.SelectedIndex = -1;
                txtSehir.Clear();
                txtBakiye.Clear();
                txtMeslek.Clear();
                txtTC.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void MusteriEkleme_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.SelectedIndex = 0;
        }

        private void txtYas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDetay_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSil_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}