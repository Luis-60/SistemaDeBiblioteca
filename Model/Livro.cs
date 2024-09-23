using AulaAEDB01.Windows.Helper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace AulaAEDB01.Windows.Model
{
    public class Livro
    {
        private int _CodigoL;
        private int _CodigoE;
        private int _Codigo;
        private int _CodigoI;
        private string _NomeL;
        private string _Descricao;
        private int _QtdPag;
        private string _ISBN;
        private int _Edicao;
        private int _CodigoA;

        // Novas propriedades para os nomes
        private string _NomeEditora;
        private string _NomeIdioma;
        private string _NomeGenero;
        private string _NomeAutor;


        public int CodigoL { get { return _CodigoL; } set { _CodigoL = value; } }
        public int CodigoI { get { return _CodigoI; } set { _CodigoI = value; } }
        public int CodigoE { get { return _CodigoE; } set { _CodigoE = value; } }
        public int Codigo { get { return _Codigo; } set { _Codigo = value; } }
        public int idAutor { get { return _CodigoA; } set { _CodigoA = value; } }
        public string NomeAutor { get => _NomeAutor ; set => _NomeAutor = value.Replace("'", ""); }
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
        public string ISBN
        {
            get => _ISBN;
            set => _ISBN = value.Replace("'", "");
        }
        public int QtdPag { get { return _QtdPag; } set { _QtdPag = value; } }
        public int Edicao { get { return _Edicao; } set { _Edicao = value; } }

        // Propriedades para os nomes
        public string NomeEditora { get { return _NomeEditora; } set { _NomeEditora = value; } }
        public string NomeIdioma { get { return _NomeIdioma; } set { _NomeIdioma = value; } }
        public string NomeGenero { get { return _NomeGenero; } set { _NomeGenero = value; } }

        public static List<Livro> ListarTodos()
        {
            using (var oCn = DataHelper.Conexao())
            {
                List<Livro> Retorno = new List<Livro>();
                string SQL = @"
                    SELECT 
                        L.id AS CodigoL,
                        L.Nome AS NomeL,
                        L.ISBN,
                        L.Descricao,
                        L.Edicao,
                        L.QtdPaginas,
                        E.Nome AS NomeEditora,
                        I.Nome AS NomeIdioma,
                        G.Nome AS NomeGenero,
                        A.Nome AS NomeAutor
                       
                    FROM 
                        Livro L
                    JOIN 
                        Editora E ON L.idEditora = E.id
                    JOIN 
                        Idioma I ON L.idIdioma = I.id
                    JOIN 
                        Genero G ON L.idGenero = G.id
                    JOIN
                        AutorLivro AL ON L.id = AL.idLivro
                    JOIN 
                        Autor A ON A.id = AL.idAutor ";

                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    Livro oLivro = new Livro
                    {
                        CodigoL = oDr.GetInt32(oDr.GetOrdinal("CodigoL")),
                        NomeL = oDr.GetString(oDr.GetOrdinal("NomeL")),
                        ISBN = oDr.GetString(oDr.GetOrdinal("ISBN")),
                        Descricao = oDr.GetString(oDr.GetOrdinal("Descricao")),
                        Edicao = oDr.GetInt32(oDr.GetOrdinal("Edicao")),
                        QtdPag = oDr.GetInt32(oDr.GetOrdinal("QtdPaginas")),
                        NomeEditora = oDr["NomeEditora"].ToString(),
                        NomeIdioma = oDr["NomeIdioma"].ToString(),
                        NomeGenero = oDr["NomeGenero"].ToString(),
                        NomeAutor = oDr.GetString(oDr.GetOrdinal("NomeAutor"))
                    };

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
                string SQL = $"SELECT * FROM Livro WHERE id={CodigoL}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    Retorno = new Livro
                    {
                        CodigoL = oDr.GetInt32(oDr.GetOrdinal("id")),
                        CodigoI = oDr.GetInt32(oDr.GetOrdinal("idIdioma")),
                        CodigoE = oDr.GetInt32(oDr.GetOrdinal("idEditora")),
                        Codigo = oDr.GetInt32(oDr.GetOrdinal("idGenero")),
                        NomeL = oDr.GetString(oDr.GetOrdinal("Nome")),
                        ISBN = oDr.GetString(oDr.GetOrdinal("ISBN")),
                        Descricao = oDr.GetString(oDr.GetOrdinal("Descricao")),
                        Edicao = oDr.GetInt32(oDr.GetOrdinal("Edicao")),
                        QtdPag = oDr.GetInt32(oDr.GetOrdinal("QtdPaginas"))
                    };
                }
                oDr.Close();
                return Retorno;
            }
        }

        public void Incluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string insertSQL = @"
                    INSERT INTO Livro (idIdioma, idGenero, idEditora, Nome, ISBN, Descricao, Edicao, QtdPaginas)
                    OUTPUT INSERTED.id  
                    VALUES (@CodigoI, @Codigo, @CodigoE, @NomeL, @ISBN, @Descricao, @Edicao, @QtdPag);";

                SqlCommand insertCommand = new SqlCommand(insertSQL, oCn);
                insertCommand.Parameters.AddWithValue("@CodigoI", this.CodigoI);
                insertCommand.Parameters.AddWithValue("@Codigo", this.Codigo);
                insertCommand.Parameters.AddWithValue("@CodigoE", this.CodigoE);
                insertCommand.Parameters.AddWithValue("@NomeL", this.NomeL.Replace("'", ""));
                insertCommand.Parameters.AddWithValue("@ISBN", this.ISBN);
                insertCommand.Parameters.AddWithValue("@Descricao", this.Descricao.Replace("'", ""));
                insertCommand.Parameters.AddWithValue("@Edicao", this.Edicao);
                insertCommand.Parameters.AddWithValue("@QtdPag", this.QtdPag);

                int idLivro = (int)insertCommand.ExecuteScalar();

                if (idLivro > 0)
                {
                    InserirAutorLivro(idLivro, idAutor, oCn);
                }
            }
        }

        private void InserirAutorLivro(int idLivro, int idAutor, SqlConnection oCn)
        {
            string insertAutorLivroSQL = @"
                INSERT INTO AutorLivro (idAutor, idLivro)
                VALUES (@idAutor, @idLivro);";

            SqlCommand insertCommand = new SqlCommand(insertAutorLivroSQL, oCn);
            insertCommand.Parameters.AddWithValue("@idAutor", idAutor);
            insertCommand.Parameters.AddWithValue("@idLivro", idLivro);
            insertCommand.ExecuteNonQuery();
        }

        public static void Alterar(Livro oLivro)
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $@"
                    UPDATE Livro 
                    SET 
                        Nome='{oLivro.NomeL.Replace("'", "")}', 
                        ISBN='{oLivro.ISBN.Replace("'", "")}', 
                        Descricao='{oLivro.Descricao.Replace("'", "")}', 
                        QtdPaginas={oLivro.QtdPag}, 
                        Edicao={oLivro.Edicao} 
                    WHERE 
                        id={oLivro.CodigoL}";

                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

        public void Excluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"DELETE FROM Livro WHERE id={this.CodigoL}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }
    }
}
