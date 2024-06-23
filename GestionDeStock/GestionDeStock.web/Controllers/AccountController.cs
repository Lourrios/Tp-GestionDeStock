using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using GestionDeStock.web.Models;
using GestionDeStock.Business.Interfaces;

namespace GestionDeStock.web.Controllers
{

    public class AccountController : Controller
    {
        private readonly ILoginUsuario _loginUsuario;

        public AccountController(ILoginUsuario loginUsuario)
        {
            _loginUsuario = loginUsuario;
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
            
            if (ModelState.IsValid)
            {
                var result = _loginUsuario.VerificarUsuario(model.User, model.Password);
                if (result == 1)
                {
                    
                    return RedirectToAction("Index", "Home"); // Redirigir al inicio después del login exitoso
                }else if (result == 2)
                {
                    ModelState.AddModelError(string.Empty, "Contraseña incorrecta");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "El usuario no existe");

                }


            }
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

