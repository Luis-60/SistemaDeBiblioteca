using AulaAEDB01.Windows.Helper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaAEDB01.Windows.Model
{

    public class AutorLivro
    {
        private int _CodigoA;
        private int _CodigoL;

        public int CodigoA { get { return _CodigoA; } set { _CodigoA = value; } }
        public int CodigoL { get { return _CodigoL; } set { _CodigoL = value; } }

        public static List<AutorLivro> ListarTodos()
        {
            using (var oCn = DataHelper.Conexao())
            {
                List<AutorLivro> Retorno = new List<AutorLivro>();
                string SQL = "select * from AutorLivro";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    AutorLivro oAutorLivro = new AutorLivro();
                    oAutorLivro.CodigoA = oDr.GetInt32(oDr.GetOrdinal("idAutor"));
                    oAutorLivro.CodigoL = oDr.GetInt32(oDr.GetOrdinal("idLivro"));
                    Retorno.Add(oAutorLivro);
                }
                oDr.Close();
                return Retorno;
            }
        }
        public void Incluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"insert into idAutor, idLivro values({this.CodigoA}, {this.CodigoL})"; 
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }

        }
    }
}