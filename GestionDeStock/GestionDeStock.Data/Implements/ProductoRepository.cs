using GestionDeStock.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Data.Implements
{
    public class ProductoRepository : Repository<Producto> , IProductoRepository
    {
        
        public ProductoRepository(GestionDeStockContext gestionDeStockContext) : base(gestionDeStockContext)
        {
        }

        public IEnumerable<Producto> GetProductosConCategoria()
        {

            return _stockContext.Productos.Include("Categoria").ToList();
        }
    }
}
