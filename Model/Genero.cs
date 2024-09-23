using AulaAEDB01.Windows.Helper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaAEDB01.Windows.Model
{
    public class Genero
    {
        //public int Codigo { get; set; }
        private int _Codigo;
        private string _Nome;

        public int Codigo { get { return _Codigo; } set { _Codigo = value; } }
        //public string? Nome { get; set; }
        //public string Nome { get { return _Nome; } set { _Nome = value; }
        public string Nome
        {
            get => _Nome;
            set => _Nome = value.Replace("'", "");
        }
        public static List<Genero> ListarTodos()
        {
            // return (from p in DataHelper.ListaGenero select p).ToList();
            using (var oCn = DataHelper.Conexao())
            {
                List<Genero> Retorno = new List<Genero>();
                string SQL = "select * from Genero";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Genero oGenero = new Genero();
                    oGenero.Codigo = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oGenero.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    Retorno.Add(oGenero);
                }
                oDr.Close();
                return Retorno;
            }

            //    SqlConnection ocn = DataHelper.Conexao();
            

            //ocn.Close();
        }
        public static Genero? Seleciona(int Codigo)
        {
            using (var oCn = DataHelper.Conexao())
            {
                Genero? Retorno = null;
                string SQL = $"select id, Nome from Genero where id={Codigo}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Retorno = new Genero();
                    Retorno.Codigo = oDr.GetInt32(oDr.GetOrdinal("id"));
                    Retorno.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    
                }
                oDr.Close();
                return Retorno;
            }
            //return (from p in DataHelper.ListaGenero where p.Codigo == Codigo select p).FirstOrDefault();
        }
        public static void IncluirGeneroStatico(Genero oGenero)
        {
            Genero? oGeneroSelecionado = Genero.Seleciona(oGenero.Codigo);
            if (oGeneroSelecionado != null)
            {
                throw new Exception($"O código informado está sendo utilizado no gênero {oGeneroSelecionado.Nome}");
            }
            else
            {
                DataHelper.ListaGenero.Add(oGenero);
            }
        }

        public void Incluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"insert into Genero values('{this.Nome.Replace("'", "")}')";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
            //Genero? oGeneroSelecionado = Genero.Seleciona(this.Codigo);
            //if (oGeneroSelecionado != null)
            //{
            //    throw new Exception($"O código informado está sendo utilizado no gênero {oGeneroSelecionado.Nome}");
            //}
            //else
            //{
            //    DataHelper.ListaGenero.Add(this);
            //}
        }
        public static void Alterar(Genero oGenero)
        {

            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"update Genero set Nome='{oGenero.Nome.Replace("'", "")}' where id={oGenero.Codigo}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
            //Genero? GeneroColecao = Seleciona(oGenero.Codigo);
            //if (GeneroColecao == null)
            //{
            //    throw new Exception("O objeto informado não existe mais no contexto.");
            //}
            //else
            //{
            //    //GeneroColecao.Codigo = oGenero.Codigo;
            //    GeneroColecao.Nome = oGenero.Nome;
            //}
        }
        public void Excluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"Delete from Genero where id={this.Codigo}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
            //DataHelper.ListaGenero.Remove(this);
        }

    }
}
