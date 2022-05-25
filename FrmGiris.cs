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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        private Form aktifForm;
        private Button gecerliBtn;

        private void YeniFormAc(Form yeniForm, object Btnsender)
        {
            if (aktifForm != null)
            {
                aktifForm.Close();
            }
            aktifForm = yeniForm;
            yeniForm.TopLevel = false;
            yeniForm.FormBorderStyle = FormBorderStyle.None;
            yeniForm.Dock = DockStyle.Fill;
            this.panelFill.Controls.Add(yeniForm);
            this.panelFill.Tag = yeniForm;
            yeniForm.BringToFront();
            yeniForm.Show();

        }
   
    

    

        private void button1_Click_1(object sender, EventArgs e)
        {
            YeniFormAc(new frmRez(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YeniFormAc(new FrmRezGoster(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            YeniFormAc(new FrmRapor(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
