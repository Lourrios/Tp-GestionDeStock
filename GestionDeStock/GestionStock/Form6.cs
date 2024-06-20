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
    public partial class Form6 : Form
    {
        private ICompraRepository _compraRepository;
        private DataTable tabla;
        public Form6(ICompraRepository compraRepository)
        {
            InitializeComponent();
            Iniciar();
            _compraRepository = compraRepository;   
            Consultar();
        }

        private void Iniciar()
        {

            tabla = new DataTable();
            //tabla.Columns.Add("CompraId");
            tabla.Columns.Add("Fecha");
            tabla.Columns.Add("Producto");
            tabla.Columns.Add("Cantidad");
           // tabla.Columns.Add("Usuario");
            dataGridView1.DataSource = tabla;
        }
        private void Consultar()
        {
            IEnumerable<Compra> lista = _compraRepository.GetAllCompras();


            foreach (Compra item in lista)
            {
                DataRow row = tabla.NewRow();
               // row["CompraId"] = item.Cantidad;
                row["Fecha"] = item.Fecha;
                row["Producto"] = item.Producto.Nombre;
                row["Cantidad"] = item.Cantidad;
                //row["Usuario"] = item.UsuarioId;


                tabla.Rows.Add(row);
            }
        }
    }
}

