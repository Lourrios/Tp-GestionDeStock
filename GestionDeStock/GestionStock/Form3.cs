using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionDeStock;
using GestionDeStock.Business.Interfaces;
using GestionDeStock.Data;
using GestionDeStock.Data.Implements;
using GestionDeStock.Data.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace GestionStock
{
    public partial class categorias : Form
    {
        IStockBusiness _stockBusiness;
        IProductoRepository _repository;
        ICategoriaRepository _categoriaRepository;
        private DataTable tabla;
        private int _pageIndex = 1;
        private int _pageSize = 2;
        private ListaPaginada<Categoria> _paginador;

        private void Iniciar()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Categoria",
                DataPropertyName = "Nombre",
                Name = "Categoria",
                DisplayIndex = 0
            });
            //dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            //{
            //    HeaderText = "Habilitado",
            //    DataPropertyName = "CategoriaId",
            //    Name = "Habilitado",
            //    DisplayIndex = 1
            //});
        }


        public categorias(IProductoRepository repository, ICategoriaRepository categoria, IStockBusiness stockBusiness)
        {
            InitializeComponent();

            _repository = repository;
            _categoriaRepository = categoria;
            _stockBusiness = stockBusiness;
            Iniciar();
            Consultar();

        }
        private void Consultar()
        {
            IEnumerable<Categoria> lista = _categoriaRepository.GetAll();
            _paginador = ListaPaginada<Categoria>.CrearLista(lista, _pageIndex, _pageSize);
            dataGridView1.DataSource = _paginador;



            // Actualiza los botones y la etiqueta de la página
            btnAtras.Enabled = _paginador.HasPreviousPage;
            btnSiguiente.Enabled = _paginador.HasNextPage;
            labelPagina.Text = $"Página {_pageIndex} de {_paginador.TotalPages}";


            //IEnumerable<Categoria> lista = _categoriaRepository.GetAll();


            //foreach (Categoria item in lista)
            //{

            //    DataRow row = tabla.NewRow();
            //    row["Categoria"] = item.Nombre;
            //    row["Habilitado"] = item.CategoriaId;


            //    tabla.Rows.Add(row);

        }


        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // verifica que se seleccione una fila
            {
                var selectedRow = dataGridView1.SelectedRows[0];

                // Obtener el objeto asociado a la fila seleccionada
                var selectedObject = (Categoria)selectedRow.DataBoundItem;

                // Acceder a las propiedades del objeto
                int id = selectedObject.CategoriaId;
                var categoriaSeleccionada = _categoriaRepository.GetById(id);

                if (categoriaSeleccionada is not null)
                {
                    Productos_por_Categoria frm = Program.ServiceProvider.GetRequiredService<Productos_por_Categoria>();
                    frm.SetCategoriaActual(categoriaSeleccionada); // setea la propiedad categoria del sig form
                    frm.Show();
                    return;
                }
            }
            MessageBox.Show("Seleccione una categoría para administrar."); // muestra una box si no se selecciona una fila


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (this._pageIndex > 1)
            {
                this._pageIndex--;
                //dataGridView1.Rows.Clear();
                Consultar();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (this._pageIndex < _paginador.TotalPages)
            {
                this._pageIndex++;
                //dataGridView1.Rows.Clear();
                Consultar();
            }
        }
    }
}
