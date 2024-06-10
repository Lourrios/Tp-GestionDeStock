using GestionDeStock.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Data.Implements
{
    public class UsuarioRespository : Repository<Usuario> , IUsuarioRepository
    {
        public UsuarioRespository(GestionDeStockContext context): base(context) { }
    }
}
