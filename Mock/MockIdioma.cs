using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AulaAEDB01.Windows.Mock;
using AulaAEDB01.Windows.Helper;
using AulaAEDB01.Windows.Model;

namespace AulaAEDB01.Windows.Mock
{
    internal class MockIdioma
    {
        public static void CarregaIdioma()
        {
            List<Idioma> oLista = new List<Idioma>();

            for (int i = 0; i < 10; i++)
            {
                //Idioma oIdioma = new Idioma();
                //oIdioma.Codigo = i;
                //oIdioma.Nome = $"Gênero {i}"; i.ToString();
                //oLista.Add(oIdioma);
                Idioma oIdioma = new Idioma
                {
                    CodigoI = i,
                    NomeI = $"Idioma {i}"
                };
                oLista.Add(oIdioma);
            }

            DataHelper.ListaIdioma = oLista;
        }
    }
}
