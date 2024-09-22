using AulaAEDB01.Windows.Helper;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AulaAEDB01.Windows
{
    public partial class FrmLivro : Form
    {
        ToolStripMenuItem _mnu;
        ToolStripMenuItem _mnu2;

        private bool Incluir = true;

        public FrmLivro(ToolStripMenuItem mnu, ToolStripMenuItem mnu2)
        {
            InitializeComponent();
            _mnu = mnu;
            _mnu2 = mnu2;
        }


        private void CarregaGrid()
        {
            GrdItensL.AutoGenerateColumns = false;
            GrdItensL.DataSource = Livro.ListarTodos();

        }
        private void FrmLivro_Load(object sender, EventArgs e)
        {
            CarregaGrid();
            
            CboEditora.DataSource = Model.Editora.ListarTodos();
            CboEditora.ValueMember = "CodigoE";
            CboEditora.DisplayMember = "NomeE";
            CboIdioma.DataSource = Model.Idioma.ListarTodos();
            CboIdioma.ValueMember = "CodigoI";
            CboIdioma.DisplayMember = "NomeI";
            CboAutor.DataSource = Model.Autor.ListarTodos();
            CboAutor.ValueMember = "CodigoA";
            CboAutor.DisplayMember = "NomeA";
            CboGenero.DataSource = Model.Genero.ListarTodos();
            CboGenero.ValueMember = "Codigo";
            CboGenero.DisplayMember = "Nome";
        }

        private void FrmLivro_FormClosed(object sender, FormClosedEventArgs e)
        {
            //((FrmMenu)this.MdiParent).MnuIdioma.Enabled = true;
            //((FrmMenu)this.MdiParent).MnSIdioma.Enabled = true;
            _mnu.Enabled = true;
            _mnu2.Enabled = true;
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "";
        }

        private void FrmLivro_Activated(object sender, EventArgs e)
        {
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "Cadastro de Livro";
        }

        private void BtnFecharL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidaControles()
        {
            int CodigoL;
            //if (TxtCodigoI.Text.Trim() == "")
            //{
            //    MessageBox.Show("O campo código é de preenchimento obrigatório.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    TxtCodigoI.Focus();
            //    return false;
            //}
            if (TxtNomeL.Text.Trim() == "")
            {
                MessageBox.Show("O campo Nome é de preenchimento obrigatório.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCodigoL.Focus();
                return false;
            }

            if (TxtEdicao.Text.Trim() == "")
            {
                MessageBox.Show("O campo Edição é de preenchimento obrigatório.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtEdicao.Focus();
                return false;
            }

            if (TxtISBN.Text.Trim() == "")
            {
                MessageBox.Show("O campo ISBN é de preenchimento obrigatório.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtISBN.Focus();
                return false;
            }

            if (TxtPag.Text.Trim() == "")
            {
                MessageBox.Show("O campo Quantidade de Páginas é de preenchimento obrigatório.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            TxtNomeL.Text = "";
            TxtISBN.Text = "";
            TxtPag.Text = "";
            TxtEdicao.Text = "";
        }

        private void BtnSalvarL_Click(object sender, EventArgs e)
        {
            if (Incluir)
            {
                //Incluir um livro na Lista
                if (ValidaControles())
                {

                    Livro oLivro = new Livro
                    {
                        //CodigoI = int.Parse(TxtCodigoI.Text),
                        NomeL = TxtNomeL.Text,
                        Descricao = TxtDescricao.Text,
                        QtdPag = int.Parse(TxtPag.Text),
                        Edicao = TxtEdicao.Text,
                        ISBN = int.Parse(TxtPag.Text)

                    };

                    // Idioma.IncluirIdiomaStatico(oIdioma);
                    try
                    {
                        oLivro.Incluir();
                        CarregaGrid();
                        LimpaControles();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao incluir o livro: {ex.Message}", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtCodigoL.Focus();
                    }

                }
            }
            else
            {
                // Altera o Livro selecionado.

                Livro oLivro = new Livro
                {
                    CodigoL = int.Parse(TxtCodigoL.Text),
                    NomeL = TxtNomeL.Text


                };
                try
                {

                    Livro.Alterar(oLivro);
                    CarregaGrid();
                    LimpaControles();
                    Incluir = true;
                    TxtCodigoL.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Um erro ocorreu ao alterar o livro: {ex.Message}", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtCodigoL.Focus();
                }
            }

        }

        private void GrdItensL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdItensL.Rows[e.RowIndex].DataBoundItem != null)
            {
                //BUSCA O OBJETO DE DADO DA LINHA SELECIONADA
                Livro objSelecionado = (Livro)GrdItensL.Rows[e.RowIndex].DataBoundItem;

                //VERIFICA SE CLICOU NO BOTÃO ALTERAR OU EXCLUIR.
                if (GrdItensL.Columns[e.ColumnIndex].Name == "BtnAlterarL")
                {
                    //Clicou no botão alterar.
                    TxtCodigoL.Text = objSelecionado.CodigoL.ToString();
                    TxtNomeL.Text = objSelecionado.NomeL;
                    TxtCodigoL.Enabled = false;
                    TxtNomeL.Focus();
                    Incluir = false;
                }
                else if (GrdItensL.Columns[e.ColumnIndex].Name == "BtnExcluirI")
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

        private void CboEditora_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
   
