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

        [HttpGet("ListsGompras")]
        public IEnumerable<Compra> GetCompra()
        {
            return _compraRepository.GetAll();
            //return _stockContext.Compras.ToList();
        }
        [HttpGet("CompraById/{id}")]
        public Compra GetCOmpraById(int id)
        {
            return _compraRepository.GetById(id);
        }
        [HttpPost("Agregar")]
        public void AgregarCompra(Compra compra)
        {
            _compraRepository.Add(compra);
        }
        [HttpPut("Editar")]
        public void EditarCompra(Compra compra)
        {
            _compraRepository.Update(compra);
        }
        [HttpDelete ("Eliminar")]
        public void DeleteCompra(int id)
        {
            _compraRepository.DeleteById(id);
        }
    }
}
