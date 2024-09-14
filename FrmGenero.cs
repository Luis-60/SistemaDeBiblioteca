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
    public partial class FrmGenero : Form
    {
        ToolStripMenuItem _mnu;
        ToolStripMenuItem _mnu2;

        private bool Incluir = true;

        public FrmGenero(ToolStripMenuItem mnu, ToolStripMenuItem mnu2)
        {
            InitializeComponent();
            _mnu = mnu;
            _mnu2 = mnu2;
        }
        private void CarregaGrid()
        {
            GrdItens.AutoGenerateColumns = false;
            GrdItens.DataSource = Genero.ListarTodos();

        }
        private void FrmGenero_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void FrmGenero_FormClosed(object sender, FormClosedEventArgs e)
        {
            //((FrmMenu)this.MdiParent).MnuGenero.Enabled = true;
            //((FrmMenu)this.MdiParent).MnSGenero.Enabled = true;
            _mnu.Enabled = true;
            _mnu2.Enabled = true;
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "";
        }

        private void FrmGenero_Activated(object sender, EventArgs e)
        {
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "Cadastro de Gêneros";
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidaControles()
        {
            int Codigo;
            //if (TxtCodigo.Text.Trim() == "")
            //{
            //    MessageBox.Show("O campo código é de preenchimento obrigatório.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    TxtCodigo.Focus();
            //    return false;
            //}
            if (TxtNome.Text.Trim() == "")
            {
                MessageBox.Show("O campo nome é de preenchimento obrigatório.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCodigo.Focus();
                return false;
            }

            //else if (int.TryParse(TxtCodigo.Text, out Codigo) == false)
            //{
            //    MessageBox.Show("O campo código não é numérico.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    TxtCodigo.Focus();
            //    return false;
            //}
            return true;
        }
        private void LimpaControles()
        {
            TxtCodigo.Text = "";
            TxtNome.Text = "";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (Incluir)
            {
                //Incluir um gênero na Lista
                if (ValidaControles())
                {

                    Genero oGenero = new Genero
                    {
                        //Codigo = int.Parse(TxtCodigo.Text),
                        Nome = TxtNome.Text

                    };

                    // Genero.IncluirGeneroStatico(oGenero);
                    try
                    {
                        oGenero.Incluir();
                        CarregaGrid();
                        LimpaControles();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao incluir o gênero: {ex.Message}", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtCodigo.Focus();
                    }

                }
            }
            else
            {
                // Altera o Gênero selecionado.

                Genero oGenero = new Genero
                {
                    Codigo = int.Parse(TxtCodigo.Text),
                    Nome = TxtNome.Text

                };
                try
                {

                    Genero.Alterar(oGenero);
                    CarregaGrid();
                    LimpaControles();
                    Incluir = true;
                    TxtCodigo.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Um erro ocorreu ao alterar o gênero: {ex.Message}", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtCodigo.Focus();
                }
            }

        }

        private void GrdItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdItens.Rows[e.RowIndex].DataBoundItem != null)
            {
                //BUSCA O OBJETO DE DADO DA LINHA SELECIONADA
                Genero objSelecionado = (Genero)GrdItens.Rows[e.RowIndex].DataBoundItem;

                //VERIFICA SE CLICOU NO BOTÃO ALTERAR OU EXCLUIR.
                if (GrdItens.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {
                    //Clicou no botão alterar.
                    TxtCodigo.Text = objSelecionado.Codigo.ToString();
                    TxtNome.Text = objSelecionado.Nome;
                    TxtCodigo.Enabled = false;
                    TxtNome.Focus();
                    Incluir = false;
                }
                else if (GrdItens.Columns[e.ColumnIndex].Name == "BtnExcluir")
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

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
