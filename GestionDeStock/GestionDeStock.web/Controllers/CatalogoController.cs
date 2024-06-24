using GestionDeStock.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GestionDeStock.web.Controllers
{
    public class CatalogoController : Controller
    {
        private readonly ICategoriaBusiness _categoriaBusiness;

        public CatalogoController(ICategoriaBusiness categoriaBusiness)
        {
            _categoriaBusiness = categoriaBusiness;
        }

        public IActionResult IndexCatalogo()
        {
            var listaCategorias= _categoriaBusiness.GetAllCategorias();
            return View(listaCategorias);
        }
    }
}
