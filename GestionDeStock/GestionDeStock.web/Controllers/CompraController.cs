using Microsoft.AspNetCore.Mvc;

namespace GestionDeStock.web.Controllers
{
    public class CompraController : Controller
    {

        public IActionResult Compras()
        {
            return View();
        }

    }
}
