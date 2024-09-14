using AulaAEDB01.Windows.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
namespace AulaAEDB01.Windows.Helper
{
    public static class DataHelper
    {
       public static List<Genero> ListaGenero { get; set; }
        
       public static List<Autor> ListaAutor { get; set; } 

        public static SqlConnection Conexao()
        {
            string strconnection = "Data Source=DESKTOP-O2PE7K5\\SQLEXPRESS;Initial Catalog=Livraria;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            SqlConnection oCn = new SqlConnection(strconnection);
            oCn.Open();
            return oCn;
        }
    }
}
