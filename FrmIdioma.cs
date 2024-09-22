using AulaAEDB01.Windows.Model;
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
    public partial class FrmIdioma : Form
    {
        ToolStripMenuItem _mnu;
        ToolStripMenuItem _mnu2;

        private bool Incluir = true;

        public FrmIdioma(ToolStripMenuItem mnu, ToolStripMenuItem mnu2)
        {
            InitializeComponent();
            _mnu = mnu;
            _mnu2 = mnu2;
        }
        private void CarregaGrid()
        {
            GrdItensI.AutoGenerateColumns = false;
            GrdItensI.DataSource = Idioma.ListarTodos();

        }
        private void FrmIdioma_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void FrmIdioma_FormClosed(object sender, FormClosedEventArgs e)
        {
            //((FrmMenu)this.MdiParent).MnuIdioma.Enabled = true;
            //((FrmMenu)this.MdiParent).MnSIdioma.Enabled = true;
            _mnu.Enabled = true;
            _mnu2.Enabled = true;
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "";
        }

        private void FrmIdioma_Activated(object sender, EventArgs e)
        {
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "Cadastro de Idioma";
        }

        private void BtnFecharI_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidaControles()
        {
            int CodigoI;
            //if (TxtCodigoI.Text.Trim() == "")
            //{
            //    MessageBox.Show("O campo código é de preenchimento obrigatório.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    TxtCodigoI.Focus();
            //    return false;
            //}
            if (TxtNomeI.Text.Trim() == "")
            {
                MessageBox.Show("O campo Nome é de preenchimento obrigatório.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCodigoI.Focus();
                return false;
            }

            //else if (int.TryParse(TxtCodigoI.Text, out CodigoI) == false)
            //{
            //    MessageBox.Show("O campo código não é numérico.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    TxtCodigoI.Focus();
            //    return false;
            //}
            return true;
        }
        private void LimpaControles()
        {
            TxtCodigoI.Text = "";
            TxtNomeI.Text = "";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnSalvarI_Click(object sender, EventArgs e)
        {
            if (Incluir)
            {
                //Incluir um gênero na Lista
                if (ValidaControles())
                {

                    Idioma oIdioma = new Idioma
                    {
                        //CodigoI = int.Parse(TxtCodigoI.Text),
                        NomeI = TxtNomeI.Text

                    };

                    // Idioma.IncluirIdiomaStatico(oIdioma);
                    try
                    {
                        oIdioma.Incluir();
                        CarregaGrid();
                        LimpaControles();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao incluir o idioma: {ex.Message}", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtCodigoI.Focus();
                    }

                }
            }
            else
            {
                // Altera o Gênero selecionado.

                Idioma oIdioma = new Idioma
                {
                    CodigoI = int.Parse(TxtCodigoI.Text),
                    NomeI = TxtNomeI.Text

                };
                try
                {

                    Idioma.Alterar(oIdioma);
                    CarregaGrid();
                    LimpaControles();
                    Incluir = true;
                    TxtCodigoI.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Um erro ocorreu ao alterar o idioma: {ex.Message}", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtCodigoI.Focus();
                }
            }

        }

        private void GrdItensI_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdItensI.Rows[e.RowIndex].DataBoundItem != null)
            {
                //BUSCA O OBJETO DE DADO DA LINHA SELECIONADA
                Idioma objSelecionado = (Idioma)GrdItensI.Rows[e.RowIndex].DataBoundItem;

                //VERIFICA SE CLICOU NO BOTÃO ALTERAR OU EXCLUIR.
                if (GrdItensI.Columns[e.ColumnIndex].Name == "BtnAlterarI")
                {
                    //Clicou no botão alterar.
                    TxtCodigoI.Text = objSelecionado.CodigoI.ToString();
                    TxtNomeI.Text = objSelecionado.NomeI;
                    TxtCodigoI.Enabled = false;
                    TxtNomeI.Focus();
                    Incluir = false;
                }
                else if (GrdItensI.Columns[e.ColumnIndex].Name == "BtnExcluirI")
                {
                    //Clicou no botão excluir.
                    if (MessageBox.Show("Confirme a exclusão.", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        objSelecionado.Excluir();
                        CarregaGrid();
                    }
                }
            }
        }

        private void LblNomeI_Click(object sender, EventArgs e)
        {

        }
    }
}
