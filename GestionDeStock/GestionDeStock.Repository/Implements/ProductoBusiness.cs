using GestionDeStock.Business.Interfaces;
using GestionDeStock.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Business.Implements
{
    
    public class ProductoBusiness : IProductoBusiness
    {
        private readonly IProductoRepository _productoRepository;
        private readonly IStockBusiness _stockBusiness;

        public ProductoBusiness(IProductoRepository productoRepository, IStockBusiness stockBusiness)
        {
            _stockBusiness = stockBusiness;
            _productoRepository = productoRepository;
        }

        // Alta
        public int AddProducto(Producto producto)
        {
            return _productoRepository.Add(producto);
        }

        // Baja/Cancelacion de producto

        public void DeshabilitarProducto(int id)
        {
            var productoEncontrado = _productoRepository.GetById(id);
            _productoRepository.DeshabilitarProducto(productoEncontrado);
        }

        // Modificacion
        public void UpdateProducto (Producto producto) { 
            _productoRepository.Update(producto);
        }
        //Lectura
        public Producto GetProductoById(int id)
        {
           return _productoRepository.GetById(id);
        }
        
        public IEnumerable<Producto> GetAllProductos()
        {
            return _productoRepository.GetAll();
        }

        
    }
}
