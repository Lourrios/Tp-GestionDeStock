using GestionDeStock.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Data.Implements
{
    public class CategoriaRespository : Repository<Categoria> , ICategoriaRepository
    {
        public CategoriaRespository(GestionDeStockContext context): base(context) { }
    }
}
