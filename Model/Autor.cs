using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AulaAEDB01.Windows.Helper;
namespace AulaAEDB01.Windows.Model
{
    public class Autor
    {
        private int _CodigoA;
        private string _NomeA;

        public int CodigoA { get { return _CodigoA; } set { _CodigoA = value; } }

        public string NomeA { get { return _NomeA; } set { _NomeA = value.Replace("'", ""); } }

        public static List<Autor> ListarTodos()
        {
            return (from p in DataHelper.ListaAutor select p).ToList();
        }
        public static Autor? Seleciona(int CodigoA)
        {
            return (from p in DataHelper.ListaAutor where p.CodigoA == CodigoA select p).FirstOrDefault();
        }
        public static void IncluirGeneroStaticoA(Autor oAutor)
        {
            Autor? oAutorSelecionado = Autor.Seleciona(oAutor.CodigoA);
            if (oAutorSelecionado != null)
            {
                throw new Exception($"O código informado está sendo usado no autor {oAutorSelecionado.NomeA}");
            }
            else
            {
                DataHelper.ListaAutor.Add(oAutor);
            }

        }
        public void IncluirA()
        {
            Autor? oAutorSelecionado = Autor.Seleciona(this.CodigoA);
            if(oAutorSelecionado != null)
            {
                throw new Exception($"O código informado está sendo utilizado no gênero {oAutorSelecionado.NomeA}");
            }
            else
            {
                DataHelper.ListaAutor.Add(this);
            }

        }
        public static void Alterar(Autor oAutor)
        {
            Autor? AutorColecao = Seleciona(oAutor.CodigoA);
            if (AutorColecao == null)
            {
                throw new Exception("O objeto informado não existe mais no contexto.");
            }
            else
            {
                //AutorColecao.CodigoA = oAutor.CodigoA;
                AutorColecao.NomeA = oAutor.NomeA;
            }
        }
        public void Excluir()
        {
            DataHelper.ListaAutor.Remove(this);
        }

    }
}
