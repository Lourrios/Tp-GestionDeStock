using GestionDeStock.Business.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GestionDeStock.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginUsuario _loginUsuario;
        public LoginController(ILoginUsuario login) {
             _loginUsuario = login;
        }
        [HttpPost("registrarUsuario/{password}")]
        public bool RegistrarUsuario([FromBody]Usuario user, string password)
        {
           return _loginUsuario.RegistrarUsuario(user, password);

        }
        [HttpGet("validarUsuario/{userName}/{password}")]
        public int ValidarUsuario(string userName, string password)
        {
            return _loginUsuario.VerificarUsuario(userName, password);
        }
    }
}
