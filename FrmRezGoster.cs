using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace TatilRez
{
    public partial class FrmRezGoster : Form
    {
        public FrmRezGoster()
        {
            InitializeComponent();
        }
        int SecilenRezId;
        public void VeriGetir()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tblRezBilgileri", Datacon.baglanti());
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void FrmRezGoster_Load(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            SecilenRezId = Convert.ToInt16(dataGridView1.Rows[secilen].Cells[0].Value);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            SecilenRezId = Convert.ToInt16(dataGridView1.Rows[secilen].Cells[0].Value);
        }
        Iptal _iptal = new Iptal();
        private void btnRezIptal_Click(object sender, EventArgs e)
        {
            
            _iptal.RezIptal(SecilenRezId);
            VeriGetir();
        }

        private void btnUlasimIptal_Click(object sender, EventArgs e)
        {
            DialogResult diaRes=MessageBox.Show("Ulaşım iptal ediliyor Konaklamayıda iptal etmek ister misiniz", "Rezervasyon", MessageBoxButtons.YesNo);
            if(diaRes==DialogResult.Yes) _iptal.RezIptal(SecilenRezId);
            else _iptal.UlasimIptal(SecilenRezId);
            VeriGetir();
        }

        private void btnKonaklamaIptal_Click(object sender, EventArgs e)
        {
            DialogResult diaRes = MessageBox.Show("Konaklama iptal ediliyor Ulaşımıda iptal etmek ister misiniz", "Rezervasyon", MessageBoxButtons.YesNo);
            if (diaRes == DialogResult.Yes) _iptal.RezIptal(SecilenRezId);
            else _iptal.KonaklamaIptal(SecilenRezId);

            VeriGetir();
        }

      
    }
}
