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
using GestionDeStock.Data;

namespace GestionStock
{
    public partial class compras : Form
    {
        private ICompraRepository _compraRepository;
        private int _currentPageIndex;
        private int _pageSize;
        private ListaPaginada<Compra> _currentPage;
        //private DataTable tabla;

        public compras(ICompraRepository compraRepository)
        {
            InitializeComponent();

            _compraRepository = compraRepository;
            _currentPageIndex = 1;
            _pageSize = 2;
            Iniciar();
            Consultar(_currentPageIndex);

        }

        private void Iniciar()
        {
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Fecha",
                DataPropertyName = "Fecha",
                Name = "Fecha",
                DisplayIndex = 0
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Producto",
                DataPropertyName = "Producto",
                Name = "Producto",
                DisplayIndex = 1
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Cantidad",
                DataPropertyName = "Cantidad",
                Name = "Cantidad",
                DisplayIndex = 2
            });

            // tabla = new DataTable();
            // //tabla.Columns.Add("CompraId");
            // tabla.Columns.Add("Fecha");
            // tabla.Columns.Add("Producto");
            // tabla.Columns.Add("Cantidad");
            //// tabla.Columns.Add("Usuario");
            // dataGridView1.DataSource = tabla;
        }
        private void Consultar(int pageIndex)
        {
            IEnumerable<Compra> lista = _compraRepository.GetAllCompras();
            _currentPage = ListaPaginada<Compra>.CrearLista(lista, pageIndex, _pageSize);

            var compras = _currentPage.Select(item => new
            {
                Fecha = item.Fecha,
                Producto = item.Producto.Nombre,
                Cantidad = item.Cantidad
            }).ToList();

            dataGridView1.DataSource = compras;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (_currentPage.HasPreviousPage)
            {
                _currentPageIndex--;
                Consultar(_currentPageIndex);
            }

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (_currentPage.HasNextPage)
            {
                _currentPageIndex++;
                Consultar(_currentPageIndex);
            }
        }
    }
}


