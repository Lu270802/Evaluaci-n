using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e) // que cuando seleccione un item del menustrip
        {
            Productos Productos = new Productos(); // se insatncia que para poder llamarlo 
            this.plContenedor.Controls.Clear(); // que  me limpie lo que hay en el panel
            Productos.TopLevel = false;
            Productos.Dock= DockStyle.Fill; // se ajuste al panel 
            this.plContenedor.Controls.Add(Productos);
            Productos.Show(); // que se abra el formulario
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)// se realiza el mismo proceso de que con el de productos
        {
            factura Factura = new factura();
            this.plContenedor.Controls.Clear();
            Factura.TopLevel = false;
            Factura.Dock = DockStyle.Fill;
            this.plContenedor.Controls.Add(Factura);
            Factura.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();// para cerrar la aplicacion ya que se deshabilitaron los bordes 
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            this.plContenedor.Controls.Clear();
            cliente.TopLevel = false;
            cliente.Dock=DockStyle.Fill;
            this.plContenedor.Controls.Add(cliente);
            cliente.Show();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vendedores vendedores = new Vendedores();
            this.plContenedor.Controls.Clear();
            vendedores.TopLevel = false;
            vendedores.Dock = DockStyle.Fill;
            this.plContenedor.Controls.Add(vendedores);
            vendedores.Show();
        }

        private void invetariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario inventario = new Inventario();
            this.plContenedor.Controls.Clear();
            inventario.TopLevel = false;
            inventario.Dock = DockStyle.Fill;
            this.plContenedor.Controls.Add(inventario);
            inventario.Show();
        }
    }
}
