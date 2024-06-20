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
    public partial class Form7 : Form


    {
        ICategoriaBusiness _categoriaBusiness;
        IProductoBusiness _productoBusiness;

        public Categoria CategoriaA { get; set; }

        //public string Producto { get; private set; }
        //public string Categoria { get; private set; }
        //public int Stock { get; private set; }

        public Form7(IProductoBusiness productoBusiness, ICategoriaBusiness categoriaBusiness)
        {
            InitializeComponent();
            _productoBusiness = productoBusiness;
            _categoriaBusiness = categoriaBusiness;
            
                
        }

        private void Form7_Load(object sender, EventArgs e)
        {
           
        
        }

        private void Iniciar()
        {
            

            labalCategoria.Text = CategoriaA.Nombre;

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
            Close();






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

        private void txtStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void SetCategoriaActual(Categoria categoria)
        {
            CategoriaA = categoria;
            Iniciar();
            
        }
    }
}
