using GestionDeStock.Business.Interfaces;
using GestionDeStock.Data;
using GestionDeStock.Data.Implements;
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
        public ComprasController(ICompraBusiness compraBusiness, IProductoRepository productoRepository)
        {
            _compraBusiness = compraBusiness;
            _productoRepository = productoRepository;
        }
        public IActionResult IndexCompras(int pageNumber, string textoBusqueda/*, string currenteFilter*/)
        {
            var listaCompras = _compraBusiness.GetAllCompras();
            ViewData["TextoBusqueda"] = textoBusqueda; // para settar texto d busqueda desde la vista

            int cantidadRegistros = 4;
            if (!String.IsNullOrEmpty(textoBusqueda))
            {
                var listFiltrada = listaCompras.Where(x => x.Producto.Nombre.ToUpper().Contains(textoBusqueda.ToUpper()) || x.Usuario.Nombre.ToUpper().Contains(textoBusqueda.ToUpper()));
                var comprasPaginada1 = ListaPaginada<Compra>.CrearLista(listFiltrada, pageNumber, cantidadRegistros);
                return View(comprasPaginada1);

            }
            var comprasPaginada = ListaPaginada<Compra>.CrearLista(listaCompras, pageNumber, cantidadRegistros);
            return View(comprasPaginada);

        }

        public IActionResult RegistrarCompra()
        {
            var productos = _productoRepository.GetAll();

            // Mapear la lista de productos a SelectListItems para la lista desplegable
            ViewBag.Productos = new SelectList(productos, "ProductoId", "Nombre");

            return View();
        }
        [HttpPost]
        public IActionResult RegistrarCompra([Bind("Fecha,ProductoId,Cantidad,UsuarioId")] Compra compra)
        {
            var fechaActual = DateTime.Now;
            if (compra.Fecha > fechaActual.AddHours(1)) // 1 hora para que no impida la dif de segundos
            {
                ViewBag.Alert = "Lo sentimos, No se pueden cargar fechas futuras";
                return View("RegistrarCompra");
            }
            else if (compra.Fecha < fechaActual.AddDays(-7))
            {
                ViewBag.Alert = "Lo sentimos, No se pueden cargar fechas menores a 7 dias.";
                return View("RegistrarCompra");
            }
            try
            {
                if (ModelState.IsValid)
                {
                    _compraBusiness.RegistrarCompra(compra);
                    return RedirectToAction(nameof(IndexCompras)); // redirecciona a index compras
                }
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "Unable to save changes. " +
                    "Try again, and if the problem persists " +
                    "see your system administrator.");
            }
            return View(compra);


        }
    }

}
