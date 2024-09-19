using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AulaAEDB01.Windows.Model;
using AulaAEDB01.Windows.Mock;

namespace AulaAEDB01.Windows
{

    public partial class FrmAutor : Form
    {
        ToolStripMenuItem _mnuA;
        ToolStripMenuItem _mnu2A;

        private bool IncluirA = true;
        public FrmAutor(ToolStripMenuItem mnuA, ToolStripMenuItem mnu2A)
        {
            InitializeComponent();
            _mnuA = mnuA;
            _mnu2A = mnu2A;
        }

        private void CarregaGrid()
        {
            GrdItensA.AutoGenerateColumns = false;
            GrdItensA.DataSource = Autor.ListarTodos();
        }
        private void FrmAutor_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }


        private void BtnFecharA_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void FrmAutor_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            //((FrmMenu)this.MdiParent).MnuGenero.Enabled = true;
            //((FrmMenu)this.MdiParent).MnSGenero.Enabled = true;
            _mnuA.Enabled = true;
            _mnu2A.Enabled = true;
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "";
        }

        private void FrmAutor_Activated_1(object sender, EventArgs e)
        {
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "Cadastro de Autor";
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
            if (TxtNomeA.Text.Trim() == "")
            {
                MessageBox.Show("O campo nome é de preenchimento obrigatório.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCodigoA.Focus();
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
        private void LimpaControlesA()
        {
            TxtNomeA.Text = "";
            TxtCodigoA.Text = "";
        }



        private void btnSalvarA_Click(object sender, EventArgs e)
        {
            if (IncluirA)
            {
                //Incluir um gênero na Lista
                if (ValidaControles())
                {

                    Autor oAutor = new Autor
                    {
                        //Codigo = int.Parse(TxtCodigo.Text),
                        NomeA = TxtNomeA.Text

                    };

                    // Genero.IncluirGeneroStatico(oGenero);
                    try
                    {
                        oAutor.IncluirA();
                        CarregaGrid();
                        LimpaControlesA();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao incluir o autor: {ex.Message}", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtCodigoA.Focus();
                    }

                }
            }
            else
            {
                //Altera o Autor Selecionado

                Autor oAutor = new Autor
                {
                    CodigoA = int.Parse(TxtCodigoA.Text),
                    NomeA = TxtNomeA.Text

                };
                try
                {

                    Autor.Alterar(oAutor);
                    CarregaGrid();
                    LimpaControlesA();
                    IncluirA = true;
                    TxtCodigoA.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Um erro ocorreu ao alterar o Autor: {ex.Message}", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtCodigoA.Focus();
                }

                
            }
        }
        private void GrdItensA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdItensA.Rows[e.RowIndex].DataBoundItem != null)
            {
                Autor objSelecionadoA = (Autor)GrdItensA.Rows[e.RowIndex].DataBoundItem;

                if (GrdItensA.Columns[e.ColumnIndex].Name == "BtnAlterarA")
                {
                    //Clicou no botão Alterar
                    TxtCodigoA.Text = objSelecionadoA.CodigoA.ToString();
                    TxtNomeA.Text = objSelecionadoA.NomeA;
                    TxtCodigoA.Enabled = false;
                    TxtNomeA.Focus();
                    IncluirA = false;
                }
                else if (GrdItensA.Columns[e.ColumnIndex].Name == "BtnExcluirA")
                {
                    //Clicou no botão excluir.
                    if (MessageBox.Show("Confirme a exclusão.", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        objSelecionadoA.Excluir();
                        CarregaGrid();
                    }
                }
            }
        }

    }
}



        