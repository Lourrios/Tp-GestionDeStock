using GestionDeStock;
using GestionDeStock.Business.Interfaces;
using GestionDeStock.Data.Interfaces;
using Microsoft.Extensions.DependencyInjection;
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
    public partial class Form4 : Form
    {
      
        private readonly IProductoBusiness _productoBusiness;
        private readonly IStockBusiness _stockBusiness;
        private readonly ICategoriaBusiness _categoriaBusiness;
        public Categoria CategoriaActual { get; set; }
        private DataTable tabla;
         

        //IProductoRepository _producto;
        // ICategoriaRepository _repository;
        public Form4(IProductoBusiness productoBusiness, IStockBusiness stockBusiness, ICategoriaBusiness categoriaBusiness)
        {
            InitializeComponent();
            _productoBusiness = productoBusiness;
            _stockBusiness = stockBusiness;
            _categoriaBusiness = categoriaBusiness;
            Iniciar();
            //_repository = repository;
            //_producto = producto;
           // Consultar();

        }

        public void SetCategoriaActual(Categoria categoria)
        {
            CategoriaActual = categoria;
            Consultar();
        }


        private void Iniciar()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Producto",
                DataPropertyName = "Producto",
                Name = "Producto",
                DisplayIndex = 0
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Categoria",
                DataPropertyName = "Categoria",
                Name = "Categoria",
                DisplayIndex = 1
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Precio",
                DataPropertyName = "Precio",
                Name = "Precio",
                DisplayIndex = 2
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Stock",
                DataPropertyName = "Stock",
                Name = "Stock",
                DisplayIndex = 3
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Habilitado",
                DataPropertyName = "Habilitado",
                Name = "Habilitado",
                DisplayIndex = 4
            });

            //tabla = new DataTable();
            //tabla.Columns.Add("Producto");
            //tabla.Columns.Add("Categoria");
            //tabla.Columns.Add("Precio");
            //tabla.Columns.Add("Stock");
            //tabla.Columns.Add("Habilitado");
            //dataGridView1.DataSource = tabla;
        }

        private void Consultar()
        {
            label2.Text = CategoriaActual.Nombre;
            {
                if (CategoriaActual.Productos == null )
                {
                    MessageBox.Show("No hay productos en esta Categoria");
                    return;
                }

                var productos = CategoriaActual.Productos.Select(item => new
                {
                    Producto = item.Nombre,
                    Categoria = CategoriaActual.Nombre,
                     Precio = item.Precio, // Asume que esta propiedad existe en Producto
                    Stock = _stockBusiness.ObtenerStockDeProducto(item.ProductoId),
                    item.Habilitado
                }).ToList();

                dataGridView1.DataSource = productos;
                //label2.Text = CategoriaActual.Nombre;
            }
        }


        //label2.Text = CategoriaActual.Nombre; // se utiliza la categoria como aatributo
        ////IEnumerable<Producto> lista = _productoBusiness.GetAllProductos();  
        //if (CategoriaActual.Productos is null)
        //{
        //    MessageBox.Show("No hay productos en esta Categoria");
        //}
        //IEnumerable<Producto> lista = CategoriaActual.Productos;


        //foreach (Producto item in lista)
        //{
        //    DataRow row = tabla.NewRow();
        //    row["Producto"] = item.Nombre;
        //    row["Categoria"] = this.CategoriaActual.Nombre;
        //    row["Stock"] = _stockBusiness.ObtenerStockDeProducto(item.ProductoId); // stock
        //                                                                           // row["Precio"] = item.Precio;
        //    row["Habilitado"] = item.Habilitado;

        //    tabla.Rows.Add(row);

    
        


private void bntAgregar_Click(object sender, EventArgs e)
        {
            using (var formAgregar = new Form7(_productoBusiness, _categoriaBusiness))
            {
                formAgregar.SetCategoriaActual(CategoriaActual);


                if(formAgregar.ShowDialog() == DialogResult.OK)
                {
                    Consultar();
                    //DataRow row = tabla.NewRow();
                    //row["Producto"] = agregar.Producto;
                    //row["Categoria"] = agregar.Categoria;
                    //row["Stock"] = agregar.Stock;

                    //tabla.Rows.Add (row);

                  
                }
                //Form7 form7 = Program.ServiceProvider.GetRequiredService<Form7>();

                //form7.Show();

            }

        }
    }
}
