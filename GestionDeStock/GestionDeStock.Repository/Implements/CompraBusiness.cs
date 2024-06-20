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

        public int RegistrarCompra(Compra compra)
        {
            var productoCompra = _productoRepository.GetById(compra.ProductoId);
            if (productoCompra == null )
            {
                return 1;
            }
            _compraRepository.Add(compra);
            _productoRepository.HabilitarProducto(productoCompra);
            return 0;
        }

        public IEnumerable<Compra> GetAllCompras()
        {
            return _compraRepository.GetAllCompras();
        }

        public Compra GetCompraById(int id)
        {
           return _compraRepository.GetById(id);
        }

        //public (IEnumerable<Compra>,int) GetComprasPaginado(int paginaIndex, int paginaTamanio, string textoBusqueda)
        //{
        //    return _compraRepository.GetComprasPaginado(paginaIndex, paginaTamanio, textoBusqueda);
        //}
    }
}
