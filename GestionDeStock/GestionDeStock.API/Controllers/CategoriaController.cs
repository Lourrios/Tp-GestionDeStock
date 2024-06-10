using GestionDeStock.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GestionDeStock.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly GestionDeStockContext _stockContext;
        public CategoriaController(GestionDeStockContext gestionDeStockContext)
        {
            _stockContext = gestionDeStockContext;
        }

        [HttpGet]
        public IEnumerable<Categoria> GetCategorias()
        {
            return _stockContext.Categorias.ToList();
        }
    }
}
