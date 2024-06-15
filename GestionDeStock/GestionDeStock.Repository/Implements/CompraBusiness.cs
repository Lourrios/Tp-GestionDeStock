using GestionDeStock.Business.Interfaces;
using GestionDeStock.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Business.Implements
{
    public class CompraBusiness : ICompraBusiness
    {
        private readonly ICompraRepository _compraRepository;
        private readonly IProductoRepository _productoRepository;

        public CompraBusiness(ICompraRepository compraRepository, 
            IProductoRepository productoRepository)
        {
            _compraRepository = compraRepository;
            _productoRepository = productoRepository;
        }

        public void RegistrarCompra(Compra compra)
        {
            var productoCompra = _productoRepository.GetById(compra.ProductoId);
            if (productoCompra == null )
            {
                throw new InvalidOperationException("Producto no válido");
            }
            _compraRepository.Add(compra);
            _productoRepository.HabilitarProducto(productoCompra);
        }

        public IEnumerable<Compra> GetAllCompras()
        {
            return _compraRepository.GetAllCompras();
        }

        public Compra GetCompraById(int id)
        {
           return _compraRepository.GetById(id);
        }
    }
}
