using CapaEntidades;
using CapaNegocios;
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
    public partial class Inventario : Form
    {
        CN_Inventario oCN_Inventario=new CN_Inventario();
        CE_Productos producto = new CE_Productos();
       

        public Inventario()
        {
            InitializeComponent();
           
        }
        //public void MostrarI()
        //{
        //    cmbBusqueda.DataSource = oCN_Inventario.Mostrar();
        //    cmbBusqueda.DisplayMember = "Descripción";
        //    cmbBusqueda.ValueMember = "Codigo";
           
        //}

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DgvConsulta.DataSource = oCN_Inventario.Mostrar();
        }


        private void Inventario_Load_1(object sender, EventArgs e)
        {
            DgvConsulta.DataSource = oCN_Inventario.Mostrar();
        }

        //private void btnFiltrar_Click_1(object sender, EventArgs e)
        //{
        //    producto.Codigo = Convert.ToInt32(cmbBusqueda.SelectedValue.ToString());
        //    DgvConsulta.DataSource = oCN_Inventario.Buscar(producto);
        //}
        public void ExportarExecl(DataGridView Dgvproducto)// se crea el metodo de exportar desde un datagridview
        {
            Microsoft.Office.Interop.Excel.Application Exportar = new Microsoft.Office.Interop.Excel.Application();// se instancia la referencia 
            Exportar.Application.Workbooks.Add(true);// se crea un libro de excel 
            int Icolumna = 0;// se inicia una vriable en 0 que es la de columna 
            foreach (DataGridViewColumn columns in Dgvproducto.Columns)// que me recorra las columnas del data 
            {
                Icolumna++;// que la columna vaya aumnetando 
                Exportar.Cells[1, Icolumna] = columns.Name;// que me traiga la celda y la añada, y estos van a ser los nombre de las filas 

            }
            int Ifila = 0;
            foreach (DataGridViewRow Fila in Dgvproducto.Rows)
            {
                Ifila++;
                Icolumna = 0;// se vuelve y se inicia desde cero 
                foreach (DataGridViewColumn columnas in Dgvproducto.Columns)
                {
                    Icolumna++;
                    Exportar.Cells[Ifila + 1, Icolumna] = Fila.Cells[columnas.Name].Value;
                }
            }
            Exportar.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportarExecl(DgvConsulta);
        }
    }
}
