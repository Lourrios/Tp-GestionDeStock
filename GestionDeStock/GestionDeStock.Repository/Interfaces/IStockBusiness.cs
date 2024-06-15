using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Business.Interfaces
{
    public interface IStockBusiness
    {
        public int ObtenerStockDeProducto(int productoId);
        public void ActualizarEstadoProducto(int productoId);
    }
}
