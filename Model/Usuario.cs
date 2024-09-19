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

        public int CodigoU { get { return _CodigoU; } set { _CodigoU = value; } }

        public string NomeU { get { return _NomeU; } set { _NomeU = value.Replace("'", ""); } }
    }
}
