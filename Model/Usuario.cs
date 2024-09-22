using AulaAEDB01.Windows.Helper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaAEDB01.Windows.Model
{
    public class Usuario
    {
        private int _CodigoU;
        private string _NomeU;
        private string _EmailU;
        private string _SenhaU;
        private string _TipoU;

        public int CodigoU { get { return _CodigoU; } set { _CodigoU = value; } }

        public string NomeU { get { return _NomeU; } set { _NomeU = value.Replace("'", ""); } }
        public string EmailU { get { return _EmailU; } set { _EmailU = value.Replace("'", ""); } }
        public string TipoU { get { return _TipoU; } set { _TipoU = value.Replace("'", ""); } }
        public string SenhaU { get { return _SenhaU; } set { _SenhaU = value.Replace("'", ""); } }


        public static List<Usuario> ListarTodos()
        {
            using (var oCn = DataHelper.Conexao())
            {
                List<Usuario> Retorno = new List<Usuario>();
                string SQL = "select id, Nome, Email, Tipo, Senha from Usuario";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Usuario oUsuario = new Usuario();
                    oUsuario.CodigoU = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oUsuario.NomeU = oDr.GetString(oDr.GetOrdinal("Nome"));
                    oUsuario.TipoU = oDr.GetString(oDr.GetOrdinal("Tipo"));
                    oUsuario.EmailU = oDr.GetString(oDr.GetOrdinal("Email"));
                    oUsuario._SenhaU = oDr.GetString(oDr.GetOrdinal("Senha"));

                    Retorno.Add(oUsuario);
                }


                oDr.Close();
                return Retorno;
            }
        }
        public static Usuario? Seleciona(int CodigoU)
        {
            using (var oCn = DataHelper.Conexao())
            {
                Usuario? Retorno = null;
                string SQL = $"select id, Nome, Email, Tipo, Senha from Usuario where id={CodigoU}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Retorno = new Usuario();
                    Retorno.CodigoU = oDr.GetInt32(oDr.GetOrdinal("id"));
                    Retorno.NomeU = oDr.GetString(oDr.GetOrdinal("Nome"));
                    Retorno.EmailU = oDr.GetString(oDr.GetOrdinal("Email"));
                    Retorno.TipoU = oDr.GetString(oDr.GetOrdinal("Tipo"));
                    Retorno.SenhaU = oDr.GetString(oDr.GetOrdinal("Senha"));

                }
                oDr.Close();
                return Retorno;
            }
        }
        public static void IncluirUsuarioStatico(Usuario oUsuario)
        {
            Usuario? oUsuarioSelecionado = Usuario.Seleciona(oUsuario.CodigoU);
            if (oUsuarioSelecionado != null)
            {
                throw new Exception($"O código informado está sendo usado no Usuario {oUsuarioSelecionado.NomeU}");
            }
            else
            {
                DataHelper.ListaUsuario.Add(oUsuario);
            }

        }
        public void IncluirU()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"insert into Usuario values('{this.NomeU.Replace("'", "")}', '{this.EmailU.Replace("'", "")}', '{this.TipoU.Replace("'", "")}', '{this.SenhaU.Replace("'", "")}')";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }

        }
        public static void AlterarU(Usuario oUsuario)
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"update Usuario set Nome='{oUsuario.NomeU.Replace("'", "")}', Email='{oUsuario.EmailU.Replace("'", "")}', Tipo='{oUsuario.TipoU.Replace("'", "")}', Senha='{oUsuario.SenhaU.Replace("'", "")}' where id={oUsuario.CodigoU}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }
        public void ExcluirU()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"Delete from Usuario where id={this.CodigoU}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }
    }
}