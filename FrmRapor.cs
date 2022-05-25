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
    public partial class FrmRapor : Form
    {
        public FrmRapor()
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
        private void FrmRapor_Load(object sender, EventArgs e)
        {
            VeriGetir();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            SecilenRezId = Convert.ToInt16(dataGridView1.Rows[secilen].Cells[0].Value);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            SecilenRezId = Convert.ToInt16(dataGridView1.Rows[secilen].Cells[0].Value);
        }

        private void btnRaporAl_Click(object sender, EventArgs e)
        {

            
            if (rbtnXML.Checked)
            {
                RaporDirector director = new RaporDirector();
                var builder = new XmlRapor();
                director.GenereteProduct(builder, SecilenRezId);
                var model = builder.GetModel();
                MessageBox.Show(model.RaporlamaTipi);
            }
            if (rbtnHTML.Checked)
            {
                RaporDirector director = new RaporDirector();
                var builder = new HtmlRapor();
                director.GenereteProduct(builder, SecilenRezId);
                var model = builder.GetModel();
                MessageBox.Show(model.RaporlamaTipi);
            }
            if (rbtnJSON.Checked)
            {
                RaporDirector director = new RaporDirector();
                var builder = new JsonRapor();
                director.GenereteProduct(builder, SecilenRezId);
                var model = builder.GetModel();
                MessageBox.Show(model.RaporlamaTipi);
            }
            
        }
    }
}
