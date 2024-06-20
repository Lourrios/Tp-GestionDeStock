using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Business.Interfaces
{
    public interface IProductoBusiness
    {
        int AddProducto(Producto producto);
        void DeshabilitarProducto(int id);
        void UpdateProducto(Producto producto);

        Producto GetProductoById(int id);
        IEnumerable<Producto> GetAllProductos();
    }
}
