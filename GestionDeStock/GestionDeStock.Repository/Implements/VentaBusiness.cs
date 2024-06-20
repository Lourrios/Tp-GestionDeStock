using GestionDeStock.Business.Interfaces;
using GestionDeStock.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Business.Implements
{
    public class VentaBusiness : IVentaBusiness
    {
        private readonly IVentaRepository _ventaRepository;
        private readonly IProductoRepository _productoRepository;
        private readonly IStockBusiness _stockBusiness;

        public VentaBusiness(IVentaRepository ventaRepository, IProductoRepository productoRepository,
            IStockBusiness stockBusiness)
        {
            _ventaRepository = ventaRepository;
            _productoRepository = productoRepository;
            _stockBusiness = stockBusiness;
        }

        public int RegistrarVenta(Venta venta)
        {
            var productoVenta = _productoRepository.GetById(venta.ProductoId);
            if (productoVenta == null || productoVenta.Habilitado == false) // verifica producto existente y habilitado
            {
                return 1;
            }
            var stockProducto = _stockBusiness.ObtenerStockDeProducto(productoVenta.ProductoId);
            if (stockProducto < venta.Cantidad) // verifica stock suficiente
            {
                return 2;
            }
            venta.Fecha = DateTime.Now; // fecha actual
            _ventaRepository.Add(venta);
            _stockBusiness.ActualizarEstadoProducto(venta.ProductoId);
            return 0;
        }

        public IEnumerable<Venta> GetAllVentas()
        {
            return _ventaRepository.GetAllVentas();
        }

        public Venta GetVentaById(int id)
        {
            return _ventaRepository.GetById(0);
        }
    }
}
