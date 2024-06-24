using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Entities.Paginacion
{
    public class CompraPagina : PaginaBase
    {
        public List<Compra> Compras { get; set; }

        public CompraPagina() : base()
        {
        }

        public CompraPagina(List<Compra> compras, int paginaIndice, int paginaTamanio , string? 
            textoBusqueda, int? totalPaginas  ) : base (paginaIndice,paginaTamanio,textoBusqueda,totalPaginas)
        {
            Compras.AddRange(compras); // agregar al final la lista que viene
        }

    }
}
