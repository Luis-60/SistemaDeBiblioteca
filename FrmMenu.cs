using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaAEDB01.Windows
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void MnuSair_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void MnuGenero_Click(object sender, EventArgs e)
        {
            FrmGenero oFrmGenero = new FrmGenero(MnuGenero, MnSGenero);
            oFrmGenero.MdiParent = this;
            MnuGenero.Enabled = false;
            MnSGenero.Enabled = false;
            oFrmGenero.Show();
        }

        private void MnSGenero_Click(object sender, EventArgs e)
        {
            MnuGenero_Click(sender, e);
        }

        private void MnuAula01_Click(object sender, EventArgs e)
        {
            FrmAula01 oFrmAula01 = new FrmAula01();
            oFrmAula01.MdiParent = this;
            oFrmAula01.Show();
        }

        private void MnuAutor_Click(object sender, EventArgs e)
        {
            FrmAutor oFrmAutor = new FrmAutor(MnuAutor, MnSAutor);
            oFrmAutor.MdiParent = this;
            MnuAutor.Enabled = false;
            MnSAutor.Enabled = false;
            oFrmAutor.Show();
        }
        private void MnSAutor_Click(object sender, EventArgs e)
        {
            MnuAutor_Click(sender, e);
        }

    }
}
