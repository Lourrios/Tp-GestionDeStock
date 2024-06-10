using GestionDeStock.Data;
using GestionDeStock.Data.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GestionDeStock.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoRepository _productoRepository;
        public ProductoController( IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        [HttpGet("ListaProductos")]
        public IEnumerable<Producto> GetProductos()
        {
            //return _stockContext.Productos.Include("Categoria").ToList();
            return _productoRepository.GetProductosConCategoria();

        }
        [HttpGet("ProductoById")]
        public Producto GetProducto(int id)
        {
            return _productoRepository.GetById(id);
        }
        [HttpPost("Agregar")]
        public void AddProducto(Producto producto)
        {
            _productoRepository.Add(producto);
        }
        [HttpDelete("Eliminar/{id}")]
        public void DeleteProducto(int id)
        {
            _productoRepository.DeleteById(id);
        }
        [HttpPut("Editar")]
        public void UpdateProducto(Producto producto)
        {
            _productoRepository.Update(producto);
        }

    }
}
