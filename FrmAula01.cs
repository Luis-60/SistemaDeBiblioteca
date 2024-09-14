namespace AulaAEDB01.Windows
{
    public partial class FrmAula01 : Form
    {
        public FrmAula01()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void BtnMensagem_Click(object sender, EventArgs e)
        {

            if (lblMensagem.Text.Trim() == "")
            {
                lblMensagem.Text = "Hello Word!";
                lblMensagem.BackColor = Color.Aqua;
            }

            else
            {
                lblMensagem.Text = "";
                lblMensagem.BackColor = Color.White;
            }

        }

        private void btnMudarCorFundoForm_Click(object sender, EventArgs e)
        {
            // this.BackColor = Color.White;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void FrmAula01_Activated(object sender, EventArgs e)
        {
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "Primeira maravilhosa aula";
        }

        private void FrmAula01_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "";
        }
    }
}
