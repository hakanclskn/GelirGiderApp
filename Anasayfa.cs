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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
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

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            MusteriEkleme musteriEkleme = new MusteriEkleme();
            musteriEkleme.ShowDialog();
        }

        private void btnMusteriListele_Click(object sender, EventArgs e)
        {
            MusteriListele musteriListele = new MusteriListele();
            musteriListele.ShowDialog();
        }



        private void btnBakiyeSiralama_Click(object sender, EventArgs e)
        {
            BakiyeSiralama bakiyesirala = new BakiyeSiralama();
            bakiyesirala.ShowDialog();
        }



        private void btnOdemeGoruntuleme_Click(object sender, EventArgs e)
        {
            FrmOdemeGoruntuleme frmOdemeGoruntuleme = new FrmOdemeGoruntuleme();
            frmOdemeGoruntuleme.ShowDialog();
        }

        private void btnOdemeEkle_Click(object sender, EventArgs e)
        {
            using (var odemeEkle = new OdemeEkle())
            {
                odemeEkle.ShowDialog();
            }
        }


        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }

        private void btnGelirGider_Click(object sender, EventArgs e)
        {
            
            
            GelirGiderfrm gelirGiderfrm = new GelirGiderfrm();
            gelirGiderfrm.ShowDialog();
        }

        private void btnGiderEkle_Click(object sender, EventArgs e)
        {
            GiderEkle giderEkle = new GiderEkle();
            giderEkle.ShowDialog();
        }
    }
}
