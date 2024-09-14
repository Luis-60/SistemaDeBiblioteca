using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AulaAEDB01.Windows.Interfaces;
using AulaAEDB01.Windows.Model;
namespace AulaAEDB01.Windows.Interfaces
{
    public interface IRepositorioEditora
    {
        Editora Incluir(Editora editora);
        void Alterar(Editora editora);
        void Excluri(Editora editora);
        void Excluir(int id);
        List<Editora> SelecionarTodos();
        Editora SelecionarChaves(int id);
    }
}
