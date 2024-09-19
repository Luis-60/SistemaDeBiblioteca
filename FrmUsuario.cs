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
    public partial class FrmUsuario : Form
    {
        ToolStripMenuItem _mnu;
        ToolStripMenuItem _mnu2;

        private bool Incluir = true;

        public FrmUsuario(ToolStripMenuItem mnu, ToolStripMenuItem mnu2)
        {
            InitializeComponent();
            _mnu = mnu;
            _mnu2 = mnu2;
        }

        private void GrdItensI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
