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
    internal class MockUsuario
    {
        public static void CarregaUsuario()
        {
            List<Usuario> oLista = new List<Usuario>();

            for (int i = 0; i < 10; i++)
            {
                //Idioma oIdioma = new Idioma();
                //oIdioma.Codigo = i;
                //oIdioma.Nome = $"Gênero {i}"; i.ToString();
                //oLista.Add(oIdioma);
                Usuario oUsuario = new Usuario
                {
                    CodigoU = i,
                    NomeU = $"Usuario {i}"
                };
                oLista.Add(oUsuario);
            }

            DataHelper.ListaUsuario = oLista;
        }
    }
}
