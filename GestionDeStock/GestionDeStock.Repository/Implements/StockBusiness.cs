using GestionDeStock.Business.Interfaces;
using GestionDeStock.Data.Implements;
using GestionDeStock.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Business.Implements
{
    public class StockBusiness : IStockBusiness
    {
        private readonly IVentaRepository _ventaRepository;
        private readonly ICompraRepository _compraRepository;
        private readonly IProductoRepository _productoRepository;

        public StockBusiness( IVentaRepository ventaRepository, ICompraRepository compraRepository
            , IProductoRepository productoRepository)
        {
            _ventaRepository = ventaRepository;
            _compraRepository = compraRepository;
            _productoRepository = productoRepository;
        }

        public int ObtenerStockDeProducto(int productoId)
        {
            var ventaProducto = _ventaRepository.GetAllVentas().Where(x => x.ProductoId == productoId);
            //var ventaProducto = _ventaRepository.GetAll().FirstOrDefault(x => x.Producto.Nombre == producto.Nombre);
            var compraProducto = _compraRepository.GetAllCompras().Where(x => x.ProductoId == productoId);

            var compraCantidad = compraProducto.Sum(x => x.Cantidad); 
            var ventaCantidad = ventaProducto.Sum(x => x.Cantidad);
            return compraCantidad - ventaCantidad;

        }
        public void ActualizarEstadoProducto(int productoId)
        {
            var stockActual = ObtenerStockDeProducto(productoId);
            var producto = _productoRepository.GetById(productoId);
            if (producto != null)
            {
                if (stockActual <= 0)
                {
                    _productoRepository.DeshabilitarProducto(producto);
                }
                _productoRepository.HabilitarProducto(producto);

            }
        }
    }
}
