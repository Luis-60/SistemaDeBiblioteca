using AulaAEDB01.Windows.Control;
using AulaAEDB01.Windows.Helper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaAEDB01.Windows.Model
{
    public class Tipo
    {
        private int _CodigoT;
        private string _TipoU;

        public int CodigoT { get { return _CodigoT; } set { _CodigoT = value; } }
        public string TipoU { get { return _TipoU; } set { _TipoU = value.Replace("'", ""); } }



        public static List<Tipo> ListarTodos()
        {
            using (var oCn = DataHelper.Conexao())
            {
                List<Tipo> Retornar = new List<Tipo>();
                String Tipo = "select * from Tipo";
                SqlCommand Tipoatt = new SqlCommand(Tipo, oCn);
                SqlDataReader oTr = Tipoatt.ExecuteReader();
                while (oTr.Read())
                {
                    Tipo oTipo = new Tipo();
                    oTipo.CodigoT = oTr.GetInt32(oTr.GetOrdinal("id"));
                    oTipo.TipoU = oTr.GetString(oTr.GetOrdinal("Tipo"));
                    Retornar.Add(oTipo);

                }
                oTr.Close();
                return Retornar;

            }
        }

        public Tipo? Seleciona(int CodigoU)
        {
            using (var oCn = DataHelper.Conexao())
            {
                Tipo? Retornar = null;
                string Tipo = $"select id, Nome, Email, Senha from Usuario where id={CodigoU}";
                SqlCommand Tipoatt = new SqlCommand(Tipo, oCn);
                SqlDataReader oTr = Tipoatt.ExecuteReader();
                while (oTr.Read())
                {
                    Retornar = new Tipo();
                    Retornar.CodigoT = oTr.GetInt32(oTr.GetOrdinal("id"));
                    Retornar.TipoU = oTr.GetString(oTr.GetOrdinal("Tipo"));


                }
                oTr.Close();
                return Retornar;
            }
        }





    }

}