using Microsoft.AspNetCore.Mvc;

namespace GestionDeStock.web.Controllers
{
    public class VentaController : Controller
    {

        public IActionResult Ventas()
        {
            return View();
        }

    }
}
