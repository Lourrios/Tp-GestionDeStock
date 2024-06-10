using GestionDeStock.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Data.Implements
{
    public class VentaRepository : Repository<Venta>, IVentaRepository
    { 
        public VentaRepository(GestionDeStockContext context) : base(context) { }
    }
}
