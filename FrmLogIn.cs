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
using static System.Net.Mime.MediaTypeNames;

namespace AulaAEDB01.Windows
{
    public partial class FrmLogIn : Form
    {

        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {

        }
        private void Checar()
        {


            string usuario = TxtUser.Text;
            string senha = TxtSenha.Text;
            Usuario? usuarioEncontrado = Usuario.MetodoL(usuario);

            if (usuarioEncontrado != null && usuarioEncontrado.SenhaL == senha)
            {
                Usuario.UsuarioLogado = Usuario.MetodoL(usuario);
                this.Visible = false;
                FrmMenu menu = new FrmMenu();
                menu.Show();
            }

            else
            {
                MessageBox.Show("Usuário ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Checar();
        }

        private void TxtSenha_TextChanged(object sender, EventArgs e)
        {

        }
        private void FrmLogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}