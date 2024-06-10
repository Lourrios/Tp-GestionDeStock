using GestionDeStock.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Data.Implements
{
    public class CompraRespository : Repository<Compra> , ICompraRepository
    {
        public CompraRespository(GestionDeStockContext context): base(context) { }
    }
}
