using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Business.Interfaces
{
    public interface IVentaBusiness
    {
        int RegistrarVenta(Venta venta);
        Venta GetVentaById(int id);
        IEnumerable<Venta> GetAllVentas();
    }
}
