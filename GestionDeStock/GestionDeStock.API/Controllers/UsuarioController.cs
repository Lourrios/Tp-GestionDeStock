using GestionDeStock.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionDeStock.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly GestionDeStockContext _stockContext;

        public UsuarioController(GestionDeStockContext stockContext)
        {
            _stockContext = stockContext;
        }

        [HttpGet]
        public IEnumerable<Usuario> GetUsuarios()
        {
            return _stockContext.Usuarios.ToList();
        }
    }
}
