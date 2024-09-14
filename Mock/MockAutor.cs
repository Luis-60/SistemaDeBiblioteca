using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AulaAEDB01.Windows.Helper;
using AulaAEDB01.Windows.Model;

namespace AulaAEDB01.Windows.Mock
{
    internal class MockAutor
    {
        public static void CarregaAutor()
        {
            List<Autor> oListaA = new List<Autor>();

            for (int i = 0; i < 10; i++)
            {
                //Autor oAutor = new Autor();
                //oAutor.CodigoA = i;
                //oAutor.NomeA = $"Autor {i}"; i.ToString();
                //oListaA.Add(oAutor);
                Autor oAutor = new Autor
                {
                    CodigoA = i,
                    NomeA = $"Autor {i}"
                };
                oListaA.Add(oAutor);

            }
            DataHelper.ListaAutor = oListaA;
        }

    }
}
