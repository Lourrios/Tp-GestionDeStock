using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Data.Interfaces
{
    public interface IProductoRepository : IRepository<Producto>
    {
        // agregar metodos especificos 

        public IEnumerable<Producto> GetProductosConCategoria();
        
    }
}
