using Microsoft.AspNetCore.Mvc;

namespace GestionDeStock.web.Models
{
    public class Venta
    {
        public int VentaId { get; set; }
        public DateTime Fecha { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public int UsuarioId { get; set; }
    }
}
