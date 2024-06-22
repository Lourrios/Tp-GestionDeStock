using GestionDeStock.Business.Interfaces;
using GestionDeStock.Data;
using GestionDeStock.Data.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace GestionDeStock.web.Controllers
{
    public class ComprasController : Controller
    {
        private readonly ICompraBusiness _compraBusiness;
        private readonly IProductoRepository _productoRepository;
        private readonly UserManager<Usuario> _userManager;

        public ComprasController(UserManager<Usuario> userManager, IProductoRepository productoRepository, ICompraBusiness compraBusiness)
        {
            _userManager = userManager;
            _productoRepository = productoRepository;
            _compraBusiness = compraBusiness;
        }

        private async Task<Usuario> GetCurrentUserAsync()
        {
            return await _userManager.GetUserAsync(HttpContext.User);
        }

        [HttpGet]
        public IActionResult IndexCompras(int pageNumber = 1, string textoBusqueda = "")
        {
            var listaCompras = _compraBusiness.GetAllCompras();
            ViewData["TextoBusqueda"] = textoBusqueda;

            int cantidadRegistros = 3;

            if (!String.IsNullOrEmpty(textoBusqueda))
            {
                listaCompras = listaCompras.Where(x => x.Producto.Nombre.ToUpper().Contains(textoBusqueda.ToUpper()) || x.Usuario.Nombre.ToUpper().Contains(textoBusqueda.ToUpper())).ToList();
            }

            var comprasPaginada = ListaPaginada<Compra>.CrearLista(listaCompras, pageNumber, cantidadRegistros);
            return View(comprasPaginada);
        }

        [HttpGet]
        public IActionResult RegistrarCompra()
        {
            ViewBag.Productos = new SelectList(_productoRepository.GetAll(), "Id", "Nombre");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegistrarCompra([Bind("Fecha,ProductoId,Cantidad")] Compra compra)
        {
            var usuarioActual = await GetCurrentUserAsync();
            compra.UsuarioId = usuarioActual.UsuarioId;

            var fechaActual = DateTime.Now;
            if (compra.Fecha > fechaActual.AddHours(1))
            {
                ViewBag.Alert = "Lo sentimos, no se pueden cargar fechas futuras";
                ViewBag.Productos = new SelectList(_productoRepository.GetAll(), "Id", "Nombre");
                return View();
            }
            else if (compra.Fecha < fechaActual.AddDays(-7))
            {
                ViewBag.Alert = "Lo sentimos, no se pueden cargar fechas menores a 7 días.";
                ViewBag.Productos = new SelectList(_productoRepository.GetAll(), "Id", "Nombre");
                return View();
            }
            try
            {
                if (ModelState.IsValid)
                {
                    _compraBusiness.RegistrarCompra(compra);
                    return RedirectToAction(nameof(IndexCompras));
                }
            }
            catch (DbUpdateException)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            ViewBag.Productos = new SelectList(_productoRepository.GetAll(), "Id", "Nombre");
            return View(compra);
        }
    }

}
