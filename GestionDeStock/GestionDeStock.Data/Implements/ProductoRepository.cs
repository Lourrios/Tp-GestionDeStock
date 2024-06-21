using GestionDeStock.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Data.Implements
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly GestionDeStockContext _stockContext;
        public ProductoRepository(GestionDeStockContext gestionDeStockContext) 
        {
            _stockContext = gestionDeStockContext;
        }

        public int Add(Producto producto)
        {
            if (!_stockContext.Productos.Any(x => x.Nombre.ToUpper() == producto.Nombre.ToUpper()))
            {
                _stockContext.Productos.Add(producto);
                _stockContext.SaveChanges();
                return 0;
            }
            return 1;
            
        }

        public IEnumerable<Producto> GetAll()
        {

            return _stockContext.Productos.Include("Categoria").ToList();
        }
        public Producto GetById(int id) { // verificar 
            return _stockContext.Productos.Where(p => p.ProductoId == id)
                      .Include(p => p.Categoria)
                      .FirstOrDefault();
        }

        // Deshabilitar un producto
        public void DeshabilitarProducto(Producto producto)
        {
            _stockContext.Productos.Attach(producto);
            producto.Habilitado = false;
            _stockContext.Productos.Entry(producto).State = EntityState.Modified;
            _stockContext.SaveChanges(); // confirma cambios
        }

        public void HabilitarProducto(Producto producto)
        {
            _stockContext.Productos.Attach(producto);
            producto.Habilitado = true;
            _stockContext.Productos.Entry(producto).State = EntityState.Modified;
            _stockContext.SaveChanges(); // confirma cambios
        }

        public void Update(Producto producto)
        {
            _stockContext.Productos.Update(producto);
            _stockContext.SaveChanges();

        }

        
       
    }
}
