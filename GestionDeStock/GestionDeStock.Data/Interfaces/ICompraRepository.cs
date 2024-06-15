using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Data.Interfaces
{
    public interface ICompraRepository 
    {
        // agregar metodos espeficos
        Compra GetById(int id);
        IEnumerable<Compra> GetAllCompras();
        void Add(Compra compra);
    }
}
