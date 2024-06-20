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
using GestionDeStock.Data.Implements;
using GestionDeStock.Data.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace GestionStock
{
    public partial class Form3 : Form
    {
        IStockBusiness _stockBusiness;
        IProductoRepository _repository;
        ICategoriaRepository _categoriaRepository;
        private DataTable tabla;
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
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Habilitado",
                DataPropertyName = "CategoriaId",
                Name = "Habilitado",
                DisplayIndex = 1
            });
        }


        public Form3(IProductoRepository repository, ICategoriaRepository categoria, IStockBusiness stockBusiness)
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
            dataGridView1.DataSource = lista.ToList();

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
                    Form4 frm = Program.ServiceProvider.GetRequiredService<Form4>();
                    frm.SetCategoriaActual(categoriaSeleccionada); // setea la propiedad categoria del sig form
                    frm.Show();
                    return;
                }
            }
            MessageBox.Show("Seleccione una categoría para administrar."); // muestra una box si no se selecciona una fila


        }
    }
}
