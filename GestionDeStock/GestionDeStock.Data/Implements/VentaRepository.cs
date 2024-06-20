using GestionDeStock.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Data.Implements
{
    public class VentaRepository :  IVentaRepository
    { 
        private readonly GestionDeStockContext _stockContext;
        public VentaRepository(GestionDeStockContext context)  { 
            _stockContext = context;
        }
        public Venta GetById(int id) {
           return _stockContext.Ventas.Include(v => v.Producto).Include(v => v.Usuario).FirstOrDefault(v => v.VentaId == id);

        }
        public IEnumerable<Venta> GetAllVentas()
        {
            return _stockContext.Ventas.Include(v => v.Producto).Include(v => v.Usuario).OrderByDescending(x=> x.Fecha).ToList();
        }
        public void Add(Venta venta)
        {
            _stockContext.Ventas.Add(venta);
            _stockContext.SaveChanges();
        }
    }
}
