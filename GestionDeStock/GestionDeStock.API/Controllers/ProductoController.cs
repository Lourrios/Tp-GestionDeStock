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

            return _productoBusiness.GetAllProductos();

        }
        [HttpGet("ProductoById")]
        public IActionResult GetProducto(int idProducto)
        {
            var producto = _productoBusiness.GetProductoById(idProducto);
            if (producto != null)
            {
                return Ok(new { ProductoId = idProducto,  Nombre = producto.Nombre , Categoria = producto.Categoria, Habilitado= producto.Habilitado});

            }
            return NotFound("Producto inexistente");
        }

        [HttpGet("{idProducto:int}/stock")]
        public IActionResult ObtenerStock(int idProducto)
        {
            var stock = _stockBusiness.ObtenerStockDeProducto(idProducto);
            var producto = _productoBusiness.GetProductoById(idProducto);
            if (producto != null)
            {
                return Ok(new { ProductoId = idProducto, Stock = stock, Nombre = producto.Nombre });

            }
            return NotFound("Producto inexistente");
        }

       
       
       

    }
}
