using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AulaAEDB01.Windows.Helper;
using Microsoft.Data.SqlClient;
namespace AulaAEDB01.Windows.Model
{
    public class Autor
    {
        private int _CodigoA;
        private string _NomeA;

        public int CodigoA { get { return _CodigoA; } set { _CodigoA = value; } }

        public string NomeA { get { return _NomeA; } set { _NomeA = value.Replace("'", ""); } }

            public static List<Autor> ListarTodos()
        {
                using (var oCn = DataHelper.Conexao())
                {
                    List<Autor> Retorno = new List<Autor>();
                    string SQL = "select id, Nome from Autor";
                    SqlCommand comando = new SqlCommand(SQL, oCn);
                    SqlDataReader oDr = comando.ExecuteReader();
                    while (oDr.Read())
                    {
                        Autor oAutor = new Autor();
                        oAutor.CodigoA = oDr.GetInt32(oDr.GetOrdinal("id"));
                        oAutor.NomeA = oDr.GetString(oDr.GetOrdinal("Nome"));
                        Retorno.Add(oAutor);
                    }
                    oDr.Close();
                    return Retorno;
                }
            }
        public static Autor? Seleciona(int CodigoA)
        {
            using (var oCn = DataHelper.Conexao())
            {
                Autor? Retorno = null;
                string SQL = $"select id, Nome from Autor where id={CodigoA}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Retorno = new Autor();
                    Retorno.CodigoA = oDr.GetInt32(oDr.GetOrdinal("id"));
                    Retorno.NomeA = oDr.GetString(oDr.GetOrdinal("Nome"));

                }
                oDr.Close();
                return Retorno;
            }
        }
        public static void IncluirAutorStatico(Autor oAutor)
        {
            Autor? oAutorSelecionado = Autor.Seleciona(oAutor.CodigoA);
            if (oAutorSelecionado != null)
            {
                throw new Exception($"O código informado está sendo usado no autor {oAutorSelecionado.NomeA}");
            }
            else
            {
                DataHelper.ListaAutor.Add(oAutor);
            }

        }
        public void IncluirA()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"insert into Autor values('{this.NomeA.Replace("'", "")}')";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }

        }
        public static void Alterar(Autor oAutor)
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"update Autor set Nome='{oAutor.NomeA.Replace("'", "")}' where id={oAutor.CodigoA}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }
        public void Excluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"Delete from Autor where id={this.CodigoA}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

    }
}
