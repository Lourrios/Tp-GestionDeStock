using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Data.Interfaces
{
    public interface IProductoRepository 
    {
        // agregar metodos especificos 

        IEnumerable<Producto> GetAll();
        Producto GetById(int id);
        int Add(Producto producto); 
        void DeshabilitarProducto(Producto producto);
        public void HabilitarProducto(Producto producto);
        void Update(Producto producto);


    }
}
