using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Business.Interfaces
{
    public interface ICompraBusiness
    {
        int RegistrarCompra(Compra compra);
        Compra GetCompraById(int id);

        IEnumerable<Compra> GetAllCompras();
        //(IEnumerable<Compra>,int) GetComprasPaginado(int paginaIndex, int paginaTamanio, string textoBusqueda);
    }
}
