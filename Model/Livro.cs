using AulaAEDB01.Windows.Helper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaAEDB01.Windows.Model
{
    public class Livro
    {
        //public int CodigoI { get; set; }
        private int _CodigoL;
        private string _NomeL;
        private string _Descricao;
        private int _QtdPag;
        private int _ISBN;
        private string _Edicao;
        
        public int CodigoL { get { return _CodigoL; } set { _CodigoL = value; } }
        //public string? NomeI { get; set; }
        //public string NomeI { get { return _NomeI; } set { _NomeI = value; }
        public string NomeL
        {
            get => _NomeL;
            set => _NomeL = value.Replace("'", "");
        }
        public string Descricao
        {
            get => _Descricao;
            set => _Descricao = value.Replace("'", "");
        }
        public int ISBN { get { return _ISBN; } set { _ISBN = value; } }

        public int QtdPag { get { return _QtdPag; } set { _QtdPag = value; } }

        public string Edicao
        {
            get => _Edicao;
            set => _Edicao = value.Replace("'", "");
        }
        public static List<Livro> ListarTodos()
        {
            // return (from p in DataHelper.ListaIdioma select p).ToList();
            using (var oCn = DataHelper.Conexao())
            {
                List<Livro> Retorno = new List<Livro>();
                string SQL = "select id, ISBN, Nome, Descricao, Edicao, QtdPaginas from Livro";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Livro oLivro = new Livro();
                    oLivro.CodigoL = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oLivro.ISBN = oDr.GetInt32(oDr.GetOrdinal("ISBN"));
                    oLivro.NomeL = oDr.GetString(oDr.GetOrdinal("Nome"));
                    oLivro.Descricao = oDr.GetString(oDr.GetOrdinal("Descricao"));
                    oLivro.Edicao = oDr.GetString(oDr.GetOrdinal("Edicao"));
                    oLivro.QtdPag = oDr.GetInt32(oDr.GetOrdinal("QtdPaginas"));
                    Retorno.Add(oLivro);
                }
                oDr.Close();
                return Retorno;
            }
        }
        public static Livro? Seleciona(int CodigoL)
        {
            using (var oCn = DataHelper.Conexao())
            {
                Livro? Retorno = null;
                string SQL = $"select id, Nome from Livro where id={CodigoL}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Retorno = new Livro();
                    Retorno.CodigoL = oDr.GetInt32(oDr.GetOrdinal("id"));
                    Retorno.NomeL = oDr.GetString(oDr.GetOrdinal("Nome"));
                    Retorno.ISBN = oDr.GetInt32(oDr.GetOrdinal("ISBN"));
                    Retorno.NomeL = oDr.GetString(oDr.GetOrdinal("Nome"));
                    Retorno.Descricao = oDr.GetString(oDr.GetOrdinal("Descricao"));
                    Retorno.Edicao = oDr.GetString(oDr.GetOrdinal("Edicao"));
                    Retorno.QtdPag = oDr.GetInt32(oDr.GetOrdinal("QtdPaginas")); 
                    
                }
                oDr.Close();
                return Retorno;
            }
            //return (from p in DataHelper.ListaIdioma where p.CodigoI == CodigoI select p).FirstOrDefault();
        }
        public static void IncluirLivroStatico(Livro oLivro)
        {
            Livro? oLivroSelecionado = Livro.Seleciona(oLivro.CodigoL);
            if (oLivroSelecionado != null)
            {
                throw new Exception($"O código informado está sendo utilizado no livro {oLivroSelecionado.NomeL}");
            }
            else
            {
                DataHelper.ListaLivro.Add(oLivro);
            }
        }

        public void Incluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string selectSQL = "SELECT l.id, e.id, a.id, i.id, g.id " +
                       "FROM Livro l " +
                       "JOIN AutorLivro al ON l.id = al.idLivro" +
                       "JOIN Autor a ON a.id = al.idAutor" +
                       "JOIN Editora e ON l.idEditora = e.id " +
                       "JOIN Genero g ON l.idGenero = g.id " +
                       "JOIN Idioma i ON l.idIdioma = i.id ";

                SqlCommand selectCommand = new SqlCommand(selectSQL, oCn);
                selectCommand.ExecuteNonQuery();

                string insertSQL = "INSERT INTO Livro (Nome, ISBN, Descricao, Edicao, QtdPaginas) " +
                                   "VALUES (@NomeL, @ISBN, @Descricao, @Edicao, @QtdPag)" +
                                   "INSERT INTO AutorLivro(idLivro, idAutor) " +
                                   "VALUES (SCOPE_IDENTITY(), @idAutor";
                                   
                                   ;

                SqlCommand insertCommand = new SqlCommand(insertSQL, oCn);
                insertCommand.Parameters.AddWithValue("@NomeL", this.NomeL.Replace("'", ""));
                insertCommand.Parameters.AddWithValue("@ISBN", this.ISBN);
                insertCommand.Parameters.AddWithValue("@Descricao", this.Descricao.Replace("'", ""));
                insertCommand.Parameters.AddWithValue("@Edicao", this.Edicao.Replace("'", ""));
                insertCommand.Parameters.AddWithValue("@QtdPag", this.QtdPag);
                insertCommand.ExecuteNonQuery();
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
        public static void Alterar(Livro oLivro)
        {

            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"update Livro set Nome='{oLivro.NomeL.Replace("'", "")}' where id={oLivro.CodigoL}";
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
                string SQL = $"Delete from Livro where id={this.CodigoL}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
            //DataHelper.ListaIdioma.Remove(this);
        }

    }
}
    