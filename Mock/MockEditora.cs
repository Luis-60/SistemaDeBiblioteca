using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AulaAEDB01.Windows.Helper;
using AulaAEDB01.Windows.Model;

namespace AulaAEDB01.Windows.Mock
{
    internal class MockEditora
    {
        public static void CarregaEditora()
        {
            List<Editora> oListaE = new List<Editora>();

            for (int i = 0; i < 10; i++)
            {
                Editora oEditora = new Editora
                {
                    CodigoE = i,
                    NomeE = $"Editora {i}"
                };
                oListaE.Add(oEditora);

            }
            DataHelper.ListaEditora = oListaE;
        }

    }
}
