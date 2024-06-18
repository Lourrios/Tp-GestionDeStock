using GestionDeStock.Data;
using GestionDeStock.Data.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GestionDeStock.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompraController : ControllerBase
    {
        private readonly ICompraRepository _compraRepository;
        public CompraController(ICompraRepository compraRepository)
        {
            _compraRepository = compraRepository;
        }

        [HttpGet("ListCompras")]
        public IEnumerable<Compra> GetCompra()
        {
            return _compraRepository.GetAllCompras();
            //return _stockContext.Compras.ToList();
        }
        [HttpGet("CompraById/{id}")]
        public Compra GetCompraById(int id)
        {
            return _compraRepository.GetById(id);
        }
        [HttpPost("Agregar")]
        public void AgregarCompra(Compra compra)
        {
            _compraRepository.Add(compra);
        }
        //[HttpPut("Editar")]
        //public void EditarCompra(Compra compra)
        //{
        //    _compraRepository.(compra);
        //}
        //[HttpDelete ("Eliminar")]
        //public void DeleteCompra(int id)
        //{
        //    _compraRepository.DeleteById(id);
        //}
    }
}
