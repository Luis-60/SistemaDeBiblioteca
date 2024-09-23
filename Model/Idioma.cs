using AulaAEDB01.Windows.Helper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaAEDB01.Windows.Model
{
    public class Idioma
    {
        //public int CodigoI { get; set; }
        private int _CodigoI;
        private string _NomeI;

        public int CodigoI { get { return _CodigoI; } set { _CodigoI = value; } }
        //public string? NomeI { get; set; }
        //public string NomeI { get { return _NomeI; } set { _NomeI = value; }
        public string NomeI
        {
            get => _NomeI;
            set => _NomeI = value.Replace("'", "");
        }
        public static List<Idioma> ListarTodos()
        {
            // return (from p in DataHelper.ListaIdioma select p).ToList();
            using (var oCn = DataHelper.Conexao())
            {
                List<Idioma> Retorno = new List<Idioma>();
                string SQL = "select * from Idioma";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Idioma oIdioma = new Idioma();
                    oIdioma.CodigoI = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oIdioma.NomeI = oDr.GetString(oDr.GetOrdinal("Nome"));
                    Retorno.Add(oIdioma);
                }
                oDr.Close();
                return Retorno;
            }

            //    SqlConnection ocn = DataHelper.Conexao();


            //ocn.Close();
        }
        public static Idioma? Seleciona(int CodigoI)
        {
            using (var oCn = DataHelper.Conexao())
            {
                Idioma? Retorno = null;
                string SQL = $"select id, Nome from Idioma where id={CodigoI}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Retorno = new Idioma();
                    Retorno.CodigoI = oDr.GetInt32(oDr.GetOrdinal("id"));
                    Retorno.NomeI = oDr.GetString(oDr.GetOrdinal("Nome"));

                }
                oDr.Close();
                return Retorno;
            }
            //return (from p in DataHelper.ListaIdioma where p.CodigoI == CodigoI select p).FirstOrDefault();
        }
        public static void IncluirIdiomaStatico(Idioma oIdioma)
        {
            Idioma? oIdiomaSelecionado = Idioma.Seleciona(oIdioma.CodigoI);
            if (oIdiomaSelecionado != null)
            {
                throw new Exception($"O código informado está sendo utilizado no idioma {oIdiomaSelecionado.NomeI}");
            }
            else
            {
                DataHelper.ListaIdioma.Add(oIdioma);
            }
        }

        public void Incluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"insert into Idioma values('{this.NomeI.Replace("'", "")}')";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
            //Idioma? oIdiomaSelecionado = Idioma.Seleciona(this.CodigoI);
            //if (oIdiomaSelecionado != null)
            //{
            //    throw new Exception($"O código informado está sendo utilizado no gênero {oIdiomaSelecionado.NomeI}");
            //}
            //else
            //{
            //    DataHelper.ListaIdioma.Add(this);
            //}
        }
        public static void Alterar(Idioma oIdioma)
        {

            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"update Idioma set Nome='{oIdioma.NomeI.Replace("'", "")}' where id={oIdioma.CodigoI}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
            //Idioma? IdiomaColecao = Seleciona(oIdioma.CodigoI);
            //if (IdiomaColecao == null)
            //{
            //    throw new Exception("O objeto informado não existe mais no contexto.");
            //}
            //else
            //{
            //    //IdiomaColecao.CodigoI = oIdioma.CodigoI;
            //    IdiomaColecao.NomeI = oIdioma.NomeI;
            //}
        }
        public void Excluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"Delete from Idioma where id={this.CodigoI}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
            //DataHelper.ListaIdioma.Remove(this);
        }

    }
}