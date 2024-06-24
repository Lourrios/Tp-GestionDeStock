using GestionDeStock.Business.Interfaces;
using GestionDeStock.Data;
using GestionDeStock.Data.Interfaces;
using GestionDeStock.web.Models;
using GestionDeStock.web.Permisos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace GestionDeStock.web.Controllers
{
    [ValidarSesion]
    public class VentasController : Controller
    {

        private readonly IVentaBusiness _ventaBusiness;
        private readonly IProductoRepository _productoRepository;

        public VentasController(IVentaBusiness ventaBusiness, IProductoRepository productoRepository)
        {
            _ventaBusiness = ventaBusiness;
            _productoRepository = productoRepository;
        }

        public IActionResult Index(int pageNumber = 1, string textoBusqueda = "")
        {
            var listaVentas = _ventaBusiness.GetAllVentas();
            // ordenar aquí
            // filtrar aquí
            ViewData["TextoBusqueda"] = textoBusqueda; // para settar texto d busqueda desde la vista

            int cantidadRegistros = 5;

            if (!String.IsNullOrEmpty(textoBusqueda))
            {
                var listFiltrada = listaVentas.Where(x => x.Producto.Nombre.ToUpper().Contains(textoBusqueda.ToUpper()));
                var ventasPaginadaFiltrada = ListaPaginada<Venta>.CrearLista(listFiltrada, pageNumber, cantidadRegistros);
                return View(ventasPaginadaFiltrada);

            }
            var ventasPaginada = ListaPaginada<Venta>.CrearLista(listaVentas, pageNumber, cantidadRegistros);
            return View(ventasPaginada);

        }
        // envia a form de registro
        public IActionResult FormVenta()
        {
            var productos = _productoRepository.GetAll();
            ViewBag.Productos = new SelectList(productos, "ProductoId", "Nombre");
            return View("AgregarVenta");
        }
        // metodo registrar
        [HttpPost]
        public IActionResult AgregarVenta([Bind("ProductoId,Cantidad,UsuarioId")] Venta venta)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var usuarioModel = HttpContext.Session.GetObject<Usuario>("UsuarioModel");
                    venta.UsuarioId = usuarioModel.UsuarioId;

                    var resutl = _ventaBusiness.RegistrarVenta(venta);
                    if (resutl != null)
                    {
                        if (resutl == 1)
                        {
                            ViewBag.Alert = "Lo sentimos, el producto no está habilitado o no existe.";
                        }
                        else if (resutl == 2)
                        {
                            ViewBag.Alert = "Lo sentimos, el producto no tiene suficiente stock.";
                        }
                        else
                        {
                            ViewBag.Alert = "Venta exitosa";
                            return RedirectToAction("Index"); // Redirecciona a index compras
                        }
                    }
                }
            }
            catch (DbUpdateException /* ex */)
            {
                ModelState.AddModelError("", "Unable to save changes. " +
                    "Try again, and if the problem persists " +
                    "see your system administrator.");
            }

            // Reestablecer el ViewBag.Productos para la vista en caso de error
            var productos = _productoRepository.GetAll();
            ViewBag.Productos = new SelectList(productos, "ProductoId", "Nombre");

            return View("AgregarVenta", venta);
        }

    }
}
