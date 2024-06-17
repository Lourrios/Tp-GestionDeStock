using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using GestionDeStock.web.Models;

namespace GestionDeStock.web.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            // Validación básica (simulada)
            if (model.Username == "dario" && model.Password == "12345")
            {
                return RedirectToAction("Index", "Home"); // Redirigir al inicio después del login exitoso
            }

            ModelState.AddModelError(string.Empty, "Credenciales inválidas");
            return View(model);
        }
    }
}

