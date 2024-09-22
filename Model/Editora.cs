using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AulaAEDB01.Windows.Helper;
using Microsoft.Data.SqlClient;
namespace AulaAEDB01.Windows.Model
{
    public class Editora
    {
        private int _CodigoE;
        private string _NomeE;

        public int CodigoE { get { return _CodigoE; } set { _CodigoE = value; } }

        public string NomeE { get { return _NomeE; } set { _NomeE = value.Replace("'", ""); } }

        public static List<Editora> ListarTodos()
        {
            using (var oCn = DataHelper.Conexao())
            {
                List<Editora> Retorno = new List<Editora>();
                string SQL = "select id, Nome from Editora";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Editora oEditora = new Editora();
                    oEditora.CodigoE = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oEditora.NomeE = oDr.GetString(oDr.GetOrdinal("Nome"));
                    Retorno.Add(oEditora);
                }
                oDr.Close();
                return Retorno;
            }
        }
        public static Editora? Seleciona(int CodigoE)
        {
            using (var oCn = DataHelper.Conexao())
            {
                Editora? Retorno = null;
                string SQL = $"select id, Nome from Editora where id={CodigoE}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Retorno = new Editora();
                    Retorno.CodigoE = oDr.GetInt32(oDr.GetOrdinal("id"));
                    Retorno.NomeE = oDr.GetString(oDr.GetOrdinal("Nome"));

                }
                oDr.Close();
                return Retorno;
            }
        }
        public static void IncluirEditoraStatico(Editora oEditora)
        {
            Editora? oEditoraSelecionado = Editora.Seleciona(oEditora.CodigoE);
            if (oEditoraSelecionado != null)
            {
                throw new Exception($"O código informado está sendo usado na editora {oEditoraSelecionado.NomeE}");
            }
            else
            {
                DataHelper.ListaEditora.Add(oEditora);
            }

        }
        public void IncluirE()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"insert into Editora values('{this.NomeE.Replace("'", "")}')";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }

        }
        public static void Alterar(Editora oEditora)
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"update Editora set Nome='{oEditora.NomeE.Replace("'", "")}' where id={oEditora.CodigoE}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }
        public void Excluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"Delete from Editora where id={this.CodigoE}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

    }
}
