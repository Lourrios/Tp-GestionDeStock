using GestionDeStock.Business.Interfaces;
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
        

        private readonly IStockBusiness _stockBusiness;
        private readonly IProductoBusiness _productoBusiness;

        public ProductoController(IStockBusiness stockBusiness, IProductoBusiness productoBusiness)
        {
            _stockBusiness = stockBusiness;
            _productoBusiness = productoBusiness;
        }

        [HttpGet("ListaProductos")]
        public IEnumerable<Producto> GetProductos()
        {
            //return _stockContext.Productos.Include("Categoria").ToList();
            return _productoBusiness.GetAllProductos();

        }
        [HttpGet("ProductoById")]
        public Producto GetProducto(int id)
        {
            return _productoBusiness.GetProductoById(id);
        }

        [HttpGet("{idProducto:int}/stock")]
        public IActionResult ObtenerStock(int idProducto)
        {
            var stock = _stockBusiness.ObtenerStockDeProducto(idProducto);
            var producto = _productoBusiness.GetProductoById(idProducto);
            return Ok(new { ProductoId = idProducto, Stock = stock });
        }

        [HttpPost("Agregar")]
        public void AddProducto(Producto producto)
        {
            _productoBusiness.AddProducto(producto);
        }
       
        [HttpPut("Editar")]
        public void UpdateProducto(Producto producto)
        {
            _productoBusiness.UpdateProducto(producto);
        }

    }
}
