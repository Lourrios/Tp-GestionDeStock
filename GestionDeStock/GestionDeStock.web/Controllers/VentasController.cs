using Microsoft.AspNetCore.Mvc;

namespace GestionDeStock.web.Controllers
{
    public class VentasController : Controller
    {

        public IActionResult IndexVentas()
        {
            return View();
        }

    }
}
