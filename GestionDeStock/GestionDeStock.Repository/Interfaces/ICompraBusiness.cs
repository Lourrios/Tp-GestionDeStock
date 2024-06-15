using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Business.Interfaces
{
    public interface ICompraBusiness
    {
        void RegistrarCompra(Compra compra);
        Compra GetCompraById(int id);

        IEnumerable<Compra> GetAllCompras();
    }
}
