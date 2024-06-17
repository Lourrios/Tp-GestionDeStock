using GestionDeStock.web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GestionDeStock.web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("LogIn", "Account");
            }

            return View();
        }

        public IActionResult Ventas()
        {
            return View();
        }
        public IActionResult Compras()
        {
            return View();
        }
        public IActionResult Stock()
        {
            return View();
        }

        public IActionResult AgregarVenta()
        {
            return View();
        }

        public IActionResult AgregarCompra()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
