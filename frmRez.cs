using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TatilRez
{
    public partial class frmRez : Form
    {
        public frmRez()
        {
            InitializeComponent();
        }
        int UlasimRBTN;
        int KonaklamaRBTN;
        private void button1_Click(object sender, EventArgs e)
        {

            if (UlasimRBTN == 0 && KonaklamaRBTN == 0)
            {
                SeyahatRez rz = new SeyahatRez(new UcakOtel());
                rz.TCKN = txtTcNo.Text;
                rz.MusteriAd = txtAd.Text;
                rz.MusteriSoyad = txtSoyad.Text;
                rz.Nereden=cmbxNereden.SelectedItem.ToString();
                rz.Nereye=cmbxNereye.SelectedItem.ToString();
                rz.DonusTarih = Convert.ToDateTime(DateTimeDonus.Text);
                rz.GidisTarih = Convert.ToDateTime(DateTimeGidis.Text);
               
                rz.RezYap(); MessageBox.Show(rz.mesaj);

            }
            else if (UlasimRBTN == 0 && KonaklamaRBTN == 1)
            {
                SeyahatRez rz = new SeyahatRez(new UcakCadir());
                rz.TCKN = txtTcNo.Text;
                rz.MusteriAd = txtAd.Text;
                rz.MusteriSoyad = txtSoyad.Text;
                rz.Nereden = cmbxNereden.SelectedItem.ToString();
                rz.Nereye = cmbxNereye.SelectedItem.ToString();
                rz.DonusTarih = Convert.ToDateTime(DateTimeDonus.Text);
                rz.GidisTarih = Convert.ToDateTime(DateTimeGidis.Text);

                rz.RezYap(); MessageBox.Show(rz.mesaj);
            }
            else if (UlasimRBTN == 1 && KonaklamaRBTN == 0)
            {
                SeyahatRez rz = new SeyahatRez(new OtobusOtel());
                rz.TCKN = txtTcNo.Text;
                rz.MusteriAd = txtAd.Text;
                rz.MusteriSoyad = txtSoyad.Text;
                rz.Nereden = cmbxNereden.SelectedItem.ToString();
                rz.Nereye = cmbxNereye.SelectedItem.ToString();
                rz.DonusTarih = Convert.ToDateTime(DateTimeDonus.Text);
                rz.GidisTarih = Convert.ToDateTime(DateTimeGidis.Text);

                rz.RezYap(); MessageBox.Show(rz.mesaj);
            }
            else if (UlasimRBTN == 1 && KonaklamaRBTN == 1)
            {
                SeyahatRez rz = new SeyahatRez(new OtobusCadir());
                rz.TCKN = txtTcNo.Text;
                rz.MusteriAd = txtAd.Text;
                rz.MusteriSoyad = txtSoyad.Text;
                rz.Nereden = cmbxNereden.SelectedItem.ToString();
                rz.Nereye = cmbxNereye.SelectedItem.ToString();
                rz.DonusTarih = Convert.ToDateTime(DateTimeDonus.Text);
                rz.GidisTarih = Convert.ToDateTime(DateTimeGidis.Text);

                rz.RezYap(); MessageBox.Show(rz.mesaj);
            }
        }

        private void rbtnCadir_CheckedChanged(object sender, EventArgs e)
        {
            KonaklamaRBTN = 1;
        }

        private void rbtnOtel_CheckedChanged(object sender, EventArgs e)
        {
            KonaklamaRBTN = 0;
        }

        private void rbtnOtobus_CheckedChanged(object sender, EventArgs e)
        {
            UlasimRBTN = 1;
        }

        private void rbtnUcak_CheckedChanged(object sender, EventArgs e)
        {
            UlasimRBTN = 0;
        }
    }
}
