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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }




        private void bntproductos_Click(object sender, EventArgs e)
        {
            var form3 = Program.ServiceProvider.GetRequiredService<categorias>();

            form3.Show();
        }

        private void bntVentas_Click(object sender, EventArgs e)
        {
            ventas form5 = Program.ServiceProvider.GetRequiredService<ventas>();
            form5.Show();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncompras_Click(object sender, EventArgs e)
        {
            compras form6 = Program.ServiceProvider.GetRequiredService<compras>();
            form6.Show();
        }
    }
}
