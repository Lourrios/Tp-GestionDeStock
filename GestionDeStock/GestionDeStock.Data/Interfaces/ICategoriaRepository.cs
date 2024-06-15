using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Data.Interfaces
{
    public interface ICategoriaRepository 
    {
        // agregar metodos espeficos

        Categoria GetById(int id);
        IEnumerable<Categoria> GetAll();
        void Add(Categoria categoria);
    }
}
