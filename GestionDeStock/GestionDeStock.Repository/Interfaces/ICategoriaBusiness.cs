using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Business.Interfaces
{
    public interface ICategoriaBusiness
    {
        Categoria GetCategoriaById(int id);
        IEnumerable<Categoria> GetAllCategorias();
        void AddCategoria(Categoria categoria);
    }
}
