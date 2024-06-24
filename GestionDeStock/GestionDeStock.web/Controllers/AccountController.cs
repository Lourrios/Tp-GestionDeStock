using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using GestionDeStock.web.Models;
using GestionDeStock.Business.Interfaces;
using GestionDeStock.Business.Implements;

namespace GestionDeStock.web.Controllers
{

    public class AccountController : Controller
    {
        private readonly ILoginUsuario _loginUsuario;
        private readonly IUsuarioBusiness _usuarioBusiness;

        public AccountController(ILoginUsuario loginUsuario, IUsuarioBusiness usuarioBusiness)
        {
            _loginUsuario = loginUsuario;
            _usuarioBusiness = usuarioBusiness;
        }
        // Acción para cerrar sesión
        public IActionResult CerrarSesion()
        {
            // Eliminar la sesión del usuario
            HttpContext.Session.Remove("UsuarioModel");

            // Opción adicional para limpiar todas las sesiones
            // HttpContext.Session.Clear();

            // Redirigir al login
            return RedirectToAction("Login", "Account");
        }

        public IActionResult LogIn()
        {
            if (TempData["SuccessMessage"] != null)
            {
                ViewBag.SuccessMessage = TempData["SuccessMessage"];
            }
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            
            //if (ModelState.IsValid)
            //{
                var result = _loginUsuario.VerificarUsuario(model.User, model.Password);
                var usuarioDB = _usuarioBusiness.GetUsuarioByNombre(model.User);
                if (result == 1)
                {
                    HttpContext.Session.SetObject("UsuarioModel", usuarioDB);
                    return RedirectToAction("Index", "Home"); // Redirigir al inicio después del login exitoso
                }else if (result == 2)
                {
                    ModelState.AddModelError(string.Empty, "Contraseña incorrecta");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "El usuario no existe");

                }


            //}
            return View(model); // Devolver la vista de login con el modelo para mostrar los errores
        }

        public IActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registro(RegistroViewModel model)
        {

            if (ModelState.IsValid)
            {
                if(model.Password == model.SecondPassword)
                {
                    var usuario = new Usuario()
                    {
                        Nombre = model.User,
                    };
                    var result = _loginUsuario.RegistrarUsuario(usuario, model.Password);

                    if (result)
                    {
                        TempData["SuccessMessage"] = "Registro exitoso, ya puede iniciar sesión";
                        // Redirigir al inicio de sesión después de un registro exitoso
                        return RedirectToAction("LogIn", "Account");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "El nombre de usuario ya está en uso");
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Las contraseñas no coinciden");
                }
                


            }
            return View(model); // Devolver la vista de login con el modelo para mostrar los errores
        }



    }
}

