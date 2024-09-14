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
    internal class MockGenero
    {
        public static void CarregaGenero()
        {
            List<Genero> oLista = new List<Genero>();

            for(int i = 0; i < 10; i++)
            {
                //Genero oGenero = new Genero();
                //oGenero.Codigo = i;
                //oGenero.Nome = $"Gênero {i}"; i.ToString();
                //oLista.Add(oGenero);
                Genero oGenero = new Genero
                {
                    Codigo = i,
                    Nome = $"Gênero {i}"
                };
                oLista.Add(oGenero);
            }

            DataHelper.ListaGenero = oLista;
        }
    }
}
