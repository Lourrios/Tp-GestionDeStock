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
    public class ComprasController : Controller
    {
        private readonly ICompraBusiness _compraBusiness;
        private readonly IProductoRepository _productoRepository;
        public ComprasController(ICompraBusiness compraBusiness, IProductoRepository productoRepository)
        {
            _compraBusiness = compraBusiness;
            _productoRepository = productoRepository;
        }
        public IActionResult IndexCompras(int pageNumber = 1, string textoBusqueda = "")
        {
            var listaCompras = _compraBusiness.GetAllCompras();
            ViewData["TextoBusqueda"] = textoBusqueda; // para settar texto d busqueda desde la vista

            int cantidadRegistros = 5;
            if (!String.IsNullOrEmpty(textoBusqueda))
            {
                var listFiltrada = listaCompras.Where(x => x.Producto.Nombre.ToUpper().Contains(textoBusqueda.ToUpper()));
                var comprasPaginada1 = ListaPaginada<Compra>.CrearLista(listFiltrada, pageNumber, cantidadRegistros);
                return View(comprasPaginada1);

            }
            var comprasPaginada = ListaPaginada<Compra>.CrearLista(listaCompras, pageNumber, cantidadRegistros);
            return View(comprasPaginada);

        }

        public IActionResult RegistrarCompra()
        {
            var productos = _productoRepository.GetAll();
            var listaProducto = productos.ToList();

            // Mapear la lista de productos a SelectListItems para la lista desplegable
            var productosList = new SelectList(listaProducto, "ProductoId", "Nombre");
            ViewBag.Productos = productosList;
            return View("RegistrarCompra");
        }
        [HttpPost]
        public IActionResult RegistrarCompra([Bind("Fecha,ProductoId,Cantidad")] Compra compra)
        {
            var usuarioModel = HttpContext.Session.GetObject<Usuario>("UsuarioModel");
            compra.UsuarioId = usuarioModel.UsuarioId;
            var fechaActual = DateTime.Now;

            if (compra.Fecha > fechaActual.AddHours(1)) // 1 hora para que no impida la dif de segundos
            {
                ViewBag.Alert = "Lo sentimos, No se pueden cargar fechas futuras";

            }
            else if (compra.Fecha < fechaActual.AddDays(-7))
            {
                ViewBag.Alert = "Lo sentimos, No se pueden cargar fechas menores a 7 dias.";
            }
            else
            {
                if (ModelState.IsValid)
                {
                    var resultCompra = _compraBusiness.RegistrarCompra(compra);
                    if (resultCompra == 0)
                    {
                        return RedirectToAction(nameof(IndexCompras)); // redirecciona a index compras
                    }
                    else
                    {
                        ViewBag.Alert = "Error al cargar la compra";
                    }
                    
                }
            }


            var productos = _productoRepository.GetAll();
            ViewBag.Productos = new SelectList(productos, "ProductoId", "Nombre");

            return View("RegistrarCompra", compra);
        }
    }

}
