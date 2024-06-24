using GestionDeStock;
using GestionDeStock.Business.Interfaces;
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
    public partial class Editar : Form
    {
        private readonly IProductoBusiness _productoBusiness;
        private Producto _producto;
        public Editar(IProductoBusiness productoBusiness)
        {
            InitializeComponent();
            _productoBusiness = productoBusiness;
        }

        public void SetProducto(Producto producto)
        {
            _producto = producto;
            txtProducto.Text = producto.Nombre;
            txtPrecio.Text = producto.Precio.ToString();
            checkBoxHabilitado.Checked = producto.Habilitado;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _producto.Nombre = txtProducto.Text;
            _producto.Precio = decimal.Parse(txtPrecio.Text);
            _producto.Habilitado = checkBoxHabilitado.Checked;

            _productoBusiness.UpdateProducto(_producto);

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
