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
    public partial class FrmEditora : Form
    {
        ToolStripMenuItem _mnu;
        ToolStripMenuItem _mnu2;

        private bool Incluir = true;

        public FrmEditora(ToolStripMenuItem mnu, ToolStripMenuItem mnu2)
        {
            InitializeComponent();
            _mnu = mnu;
            _mnu2 = mnu2;
        }

        private void CarregaGrid()
        {
            GrdItensE.AutoGenerateColumns = false;
            GrdItensE.DataSource = Editora.ListarTodos();
        }

        private void FrmEditora_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void FrmEditora_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mnu.Enabled = true;
            _mnu2.Enabled = true;
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "";
        }

        private void FrmEditora_Activated(object sender, EventArgs e)
        {
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "Cadastro de Editoras";
        }

        private void BtnFecharE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidaControles()
        {
            //int CodigoE;
            if (TxtNomeE.Text.Trim() == "")
            {
                MessageBox.Show("O campo nome é de preenchimento obrigatório.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCodigoE.Focus();
                return false;
            }
            return true;
        }

        private void LimpaControles()
        {
            TxtCodigoE.Text = "";
            TxtNomeE.Text = "";
        }

        private void BtnSalvarE_Click(object sender, EventArgs e)
        {
            if (Incluir)
            {
                // Incluir uma editora na Lista
                if (ValidaControles())
                {
                    Editora oEditora = new Editora
                    {
                        NomeE = TxtNomeE.Text
                    };

                    try
                    {
                        oEditora.IncluirE();
                        CarregaGrid();
                        LimpaControles();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao incluir a editora: {ex.Message}", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtCodigoE.Focus();
                    }
                }
            }
            else
            {
                // Altera a Editora selecionada.
                Editora oEditora = new Editora
                {
                    CodigoE = int.Parse(TxtCodigoE.Text),
                    NomeE = TxtNomeE.Text
                };
                try
                {
                    Editora.Alterar(oEditora);
                    CarregaGrid();
                    LimpaControles();
                    Incluir = true;
                    TxtCodigoE.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Um erro ocorreu ao alterar a editora: {ex.Message}", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtCodigoE.Focus();
                }
            }
        }

        private void GrdItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdItensE.Rows[e.RowIndex].DataBoundItem != null)
            {
                // BUSCA O OBJETO DE DADO DA LINHA SELECIONADA
                Editora objSelecionado = (Editora)GrdItensE.Rows[e.RowIndex].DataBoundItem;

                // VERIFICA SE CLICOU NO BOTÃO ALTERAR OU EXCLUIR.
                if (GrdItensE.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {
                    // Clicou no botão alterar.
                    TxtCodigoE.Text = objSelecionado.CodigoE.ToString();
                    TxtNomeE.Text = objSelecionado.NomeE;
                    TxtCodigoE.Enabled = false;
                    TxtNomeE.Focus();
                    Incluir = false;
                }
                else if (GrdItensE.Columns[e.ColumnIndex].Name == "BtnExcluir")
                {
                    // Clicou no botão excluir.
                    if (MessageBox.Show("Confirme a exclusão.", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        objSelecionado.Excluir();
                        CarregaGrid();
                    }
                }
            }
        }

        
    }
}