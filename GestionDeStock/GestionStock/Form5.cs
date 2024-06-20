using GestionDeStock.Data.Implements;
using GestionDeStock;
using GestionDeStock.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStock
{
    public partial class Form5 : Form
    {
        IVentaRepository _ventaRepository;
        private DataTable tabla;
        public Form5(IVentaRepository ventaRepository)
        {
            InitializeComponent();
            Iniciar();
            _ventaRepository = ventaRepository;
            Consultar();
        }

        private void Iniciar()
        {

            tabla = new DataTable();
            tabla.Columns.Add("Fecha");
            tabla.Columns.Add("Producto");
            tabla.Columns.Add("Cantidad");
            tabla.Columns.Add("Usuario");
            dataGridView1.DataSource = tabla;
        }
        private void Consultar()
        {
            IEnumerable<Venta> lista = _ventaRepository.GetAllVentas();


            foreach (Venta item in lista)
            {
                DataRow row = tabla.NewRow();
                row["Fecha"] = item.Fecha;
                row["Producto"] = item.Producto.Nombre;
                row["Cantidad"] = item.Cantidad;
                row["Usuario"] = item.UsuarioId;


                tabla.Rows.Add(row);
            }
        }

    }
}
