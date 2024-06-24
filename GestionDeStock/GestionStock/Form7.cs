using GestionDeStock.Business.Interfaces;
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
using GestionDeStock;
using GestionDeStock.Business.Implements;



namespace GestionStock
{
    public partial class agregar : Form


    {
        ICategoriaBusiness _categoriaBusiness;
        IProductoBusiness _productoBusiness;

        public Categoria CategoriaA;

        //public string Producto { get; private set; }
        //public string Categoria { get; private set; }
        //public int Stock { get; private set; }

        public agregar(IProductoBusiness productoBusiness, ICategoriaBusiness categoriaBusiness)
        {
            InitializeComponent();
            _productoBusiness = productoBusiness;
            _categoriaBusiness = categoriaBusiness;
            
                
        }
        public void SetCategoriaActual(Categoria categoria)
        {
            CategoriaA = categoria;
            Iniciar();

            //if (IsHandleCreated)
            //{

            //}

        }
        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void Iniciar()
        {

            if (labelCategoria == null)
            {
                MessageBox.Show("labelCategoria no está inicializado.");
                return;
            }
            if (CategoriaA != null)
            {
                labelCategoria.Text = CategoriaA.Nombre;
            }
            else
            {
                labelCategoria.Text = "Categoría no seleccionada";
            }
            


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProducto.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            //if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            //{
            //    MessageBox.Show("Por favor, introduce un precio válido.");
            //    return;
            //}

            GestionDeStock.Producto producto = new GestionDeStock.Producto
            {
                Nombre = txtProducto.Text,
                CategoriaId = CategoriaA.CategoriaId, // Asumiendo que tienes una propiedad CategoriaId
                Precio = Convert.ToDecimal(txtPrecio.Text),
                Habilitado = checbHabilitado.Checked
            };

            _productoBusiness.AddProducto(producto);

            DialogResult = DialogResult.OK;
            this.Close();






            //GestionDeStock.Producto producto = new GestionDeStock.Producto
            //{
            //    Nombre = txtProducto.Text,
            //    Categoria = (Categoria)cbCategoria.SelectedValue,
            //    Precio = decimal.Parse(txtPrecio.Text),
            //    Habilitado = checbHabilitado.Checked
            //};

            //_productoBusiness.AddProducto(producto);



            //DialogResult = DialogResult.OK;
            //Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

       
        
       
    }
}
