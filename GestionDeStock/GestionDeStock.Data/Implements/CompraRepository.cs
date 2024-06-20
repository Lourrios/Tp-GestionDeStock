using GestionDeStock.Data.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Data.Implements
{
    public class CompraRespository :  ICompraRepository
    {
        private readonly GestionDeStockContext _stockContext;
        public CompraRespository(GestionDeStockContext context) {
            _stockContext = context;        
        }

        public void Add(Compra compra)
        {
            _stockContext.Add(compra);
            _stockContext.SaveChanges();
        }
        public Compra GetById(int id)
        {
            //return _stockContext.Compras.Where(comp => comp.CompraId == id)
            //    .Include(x=> x.Usuario).Include(x=> x.Producto).FirstOrDefault();

            return _stockContext.Compras.Include(c => c.Producto).Include(c => c.Usuario).FirstOrDefault(c => c.CompraId == id);
        }

        public IEnumerable<Compra> GetAllCompras()
        {
            return _stockContext.Compras.Include(c => c.Producto).Include(c => c.Usuario).OrderByDescending(x => x.Fecha).ToList();
           
        }
    }
}
