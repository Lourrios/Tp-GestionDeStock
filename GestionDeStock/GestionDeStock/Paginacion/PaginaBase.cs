using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Entities.Paginacion
{
    public abstract class PaginaBase
    {
        public int PaginaIndice { get; set; }
        public int PaginaTamanio { get; set; }
        public string? TextoBusqueda { get; set; }
        public int? TotalPaginas { get;set; }

        protected PaginaBase()
        {
        }

        protected PaginaBase(int paginaIndice, int paginaTamanio, string? textoBusqueda, int? totalPaginas)
        {
            PaginaIndice = paginaIndice;
            PaginaTamanio = paginaTamanio;
            TextoBusqueda = textoBusqueda;
            TotalPaginas = totalPaginas;
        }
    }
    
}
