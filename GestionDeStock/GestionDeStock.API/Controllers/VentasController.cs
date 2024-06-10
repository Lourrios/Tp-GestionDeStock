using GestionDeStock.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GestionDeStock.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentasController : ControllerBase
    {
        private  readonly GestionDeStockContext _stockContext;

        public VentasController(GestionDeStockContext stockContext)
        {
            _stockContext = stockContext;
        }

        [HttpGet]
        public IEnumerable<Venta> GetVentas()
        {
            return _stockContext.Ventas.Include("Producto").ToList();
        }
    }
}
