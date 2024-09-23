using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AulaAEDB01.Windows.Control;
using AulaAEDB01.Windows.Model;

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
        private void CarregaGrid()
        {
            GrdItensU.AutoGenerateColumns = false;
            GrdItensU.DataSource = Usuario.ListarTodos();

        }
        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            CarregaGrid();
            CboTipo.DataSource = Model.Tipo.ListarTodos();
            CboTipo.ValueMember = "CodigoT";
            CboTipo.DisplayMember = "TipoU";

        }

        private void FrmUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            //((FrmMenu)this.MdiParent).MnuUsuario.Enabled = true;
            //((FrmMenu)this.MdiParent).MnSUsuario.Enabled = true;
            _mnu.Enabled = true;
            _mnu2.Enabled = true;
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "";
        }

        private void FrmUsuario_Activated(object sender, EventArgs e)
        {
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "Cadastro de Usuarios";
        }

        private void BtnFecharU_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidaControles()
        {
            int CodigoU;
            //if (TxtCodigoU.Text.Trim() == "")
            //{
            //    MessageBox.Show("O campo código é de preenchimento obrigatório.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    TxtCodigoU.Focus();
            //    return false;
            //}
            if (TxtNomeU.Text.Trim() == "")
            {
                MessageBox.Show("O campo NomeU é de preenchimento obrigatório.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCodigoU.Focus();
                return false;
            }

            //else if (int.TryParse(TxtCodigoU.Text, out CodigoU) == false)
            //{
            //    MessageBox.Show("O campo código não é numérico.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    TxtCodigoU.Focus();
            //    return false;
            //}
            return true;
        }
        private void LimpaControles()
        {
            TxtCodigoU.Text = "";
            TxtNomeU.Text = "";
            TxtEmail.Text = "";
            TxtSenha.Text = "";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnSalvarU_Click(object sender, EventArgs e)
        {
            if (Incluir)
            {
                //Incluir um Usuario na Lista
                if (ValidaControles())
                {

                    Usuario oUsuario = new Usuario
                    {
                        //CodigoU = int.Parse(TxtCodigoU.Text),
                        NomeU = TxtNomeU.Text,
                        EmailU = TxtEmail.Text,
                        TipoU = CboTipo.Text,
                        SenhaU = TxtSenha.Text,


                    };

                    // Usuario.IncluirUsuarioStatico(oUsuario);
                    try
                    {
                        oUsuario.IncluirU();
                        CarregaGrid();
                        LimpaControles();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao incluir o Usuario: {ex.Message}", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtCodigoU.Focus();
                    }

                }
            }
            else
            {
                // Altera o Usuario selecionado.

                Usuario oUsuario = new Usuario
                {
                    CodigoU = int.Parse(TxtCodigoU.Text),
                    NomeU = TxtNomeU.Text,
                    EmailU = TxtEmail.Text,
                    TipoU = CboTipo.Text,
                    SenhaU = TxtSenha.Text


                };
                try
                {

                    Usuario.AlterarU(oUsuario);
                    CarregaGrid();
                    LimpaControles();
                    Incluir = true;
                    TxtCodigoU.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Um erro ocorreu ao alterar o Usuario: {ex.Message}", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtCodigoU.Focus();
                }
            }

        }

        private void GrdItensU_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdItensU.Rows[e.RowIndex].DataBoundItem != null)
            {
                //BUSCA O OBJETO DE DADO DA LINHA SELECIONADA
                Usuario objSelecionado = (Usuario)GrdItensU.Rows[e.RowIndex].DataBoundItem;

                //VERIFICA SE CLICOU NO BOTÃO ALTERAR OU EXCLUIR.
                if (GrdItensU.Columns[e.ColumnIndex].Name == "BtnAlterarU")
                {
                    //Clicou no botão alterar.
                    TxtCodigoU.Text = objSelecionado.CodigoU.ToString();
                    TxtNomeU.Text = objSelecionado.NomeU;
                    TxtEmail.Text = objSelecionado.EmailU;
                    TxtSenha.Text = objSelecionado.SenhaU;
                    TxtCodigoU.Enabled = false;
                    TxtNomeU.Focus();
                    Incluir = false;
                }
                else if (GrdItensU.Columns[e.ColumnIndex].Name == "BtnExcluirU")
                {
                    //Clicou no botão excluir.
                    if (MessageBox.Show("Confirme a exclusão.", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        objSelecionado.ExcluirU();
                        CarregaGrid();
                    }
                }
            }
        }

        private void GrdItensU_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}