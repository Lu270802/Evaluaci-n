using CapaEntidades;
using CapaNegocios;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class factura : Form

    {
        // se instancia lo que es necesario 
        CN_Clientes oCN_Clientes = new CN_Clientes();
        CN_Facturas oCN_Facturas = new CN_Facturas();
        DataTable dt = new DataTable();
        CE_Facturas facturas = new CE_Facturas();
        CE_FacturaD facturaD = new CE_FacturaD();
        int codvendedor = 1212;// se declara esta variable para que sea lo que va a tomar un columna de un dta 
        CN_Validaciones oCN_Validaciones = new CN_Validaciones();
        int to = 0;
        int id = 0;

        public factura()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)// se crean las columnas en el data par emepzar 
        {
            dt.Columns.Add("#Factura");
            dt.Columns.Add("Fecha");
            dt.Columns.Add("Cliente");
            dt.Columns.Add("Producto");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("CodVendedor");
            dt.Columns.Add("SubTotal");
            dt.Columns.Add("Valor_Unitario");
            DgvAgg.DataSource = dt;// se guardan el data los cambios 
            MostrarC();// que me cargue la informacion de ese comboBox 
            MostrarP();
            Ultimoid();
            
        }
        private void MostrarC() // que me muestre los clientes 
        {
            CmbCliente.DataSource = oCN_Clientes.MostrarClien();// se llama el metodo de la capa 
            CmbCliente.ValueMember = "Documento";
            CmbCliente.DisplayMember = "Nombre";
        }

        private void MostrarP()// que me mustre los productos
        {
            CmbP.DataSource = oCN_Clientes.MostrarP();
            CmbP.ValueMember = "Codigo";
            CmbP.DisplayMember = "Descripción";
        }

        private void BtnGP_Click(object sender, EventArgs e) // que al darle agg producto en el dta aun no a la base de datos 
        {

            DataRowView tabla = CmbP.SelectedItem as DataRowView; // que me traiga la informacion del item seleccionado en la variable tabla 
            int codvendedor = 1212;
            DataRow i = dt.NewRow();

            // que el txt de num factura sea el ultimo de la tabla deta fact agg 1 de mas esto con el proceso en negocios 
            i["#Factura"] = txtFactura.Text;// que guarde en las columnas lo que halla en los textbox 
            i["Fecha"] = DtmFecha.Text;
            i["Cliente"] = CmbCliente.SelectedValue;
            i["Producto"] = CmbP.SelectedValue;// que nos tome la llave primaria de los combo
            int cantidad = Convert.ToInt32(txtCant.Text);// se crea la variable para covertir cantidad a entero 
            i["Cantidad"] = cantidad;// la columna sea igual a la variable 
            i["CodVendedor"] = codvendedor;// se trae la variable de vendedro y ese va a ser = a la culmuna 
            int valor = Convert.ToInt32(tabla["Valor_Unidad"].ToString());// se crea la varible valor y que nos seleccione la fila " y la convierta a entero lo que hay en ese campo
            i["Valor_Unitario"] = valor; // que la columna sea igual a lo que esta almacenado
            i["SubTotal"] = cantidad * valor;// que esa coulman sea el resultado de una suma entre las vriables , para eso se conviertieron previamente ya que los strings no se pueden sumar 
            dt.Rows.Add(i);// que me añada eso al data grid 
            to += cantidad * valor;
            txtTotal.Text = to.ToString();
            txtTotal.Enabled = false;
            CmbCliente.Enabled = false;// que ya no se pueda cambiar el cliente hasta que se de terminar facura puesto que todo lo que se agregu sera de un mismo cliente 

        }

        private void btnTerminar_Click(object sender, EventArgs e)// terminar 
        {
            fact();// me traiga el proceso
            oCN_Facturas.AggFac(facturas);// se llama el metodo de agg factura 
            factd();
            MessageBox.Show("Factura Agregada con exito ");
            txtCant.Clear(); // limpie los text BOX 
            txtTotal.Clear();
            CmbCliente.Enabled = true;// que el combo box de cliente se habilite porque ya se creara un nueva facutura 
            Ultimoid();
            dt.Clear();
          
        }
        private void fact() // metodo de agregar a la tabla factura 
        {

            foreach (DataRow dr in dt.Rows)// que me lea lo que hay en las filas 
            {
                facturas.Fecha = Convert.ToDateTime(dr["Fecha"]);// que me guarde en las variables lo que esta en los campos y se realizan las respectivas conversiones 
                facturas.DoClient = Convert.ToInt32(dr["Cliente"]);
                facturas.Codigo_Vendedor = codvendedor;// el codigo del vendedor  va a ser el ya declarado
            }
        }
        private void factd()// meotodo para agg a la tabla detalle factura 
        {
            foreach (DataRow drs in dt.Rows)
            {

                facturaD.Numero_Factura = Convert.ToInt32(drs["#FACTURA"]);
                facturaD.Cod_p = Convert.ToInt32(drs["Producto"]);
                facturaD.Cant = Convert.ToInt32(drs["Cantidad"]);
                facturaD.ValUnidad = Convert.ToInt32(drs["Valor_Unitario"]);
                oCN_Facturas.AggDf(facturaD);// se llama el metodo

            }
        }




        private void txtCant_KeyPress(object sender, KeyPressEventArgs e)// se valida que solo se puedan digira numeros y nada mas 
        {
            oCN_Validaciones.SoloNum(e);
        }
        private void Ultimoid()// se crea el metodo de traer el ultimo numero
        {
            if (oCN_Facturas.UltmimoId() != " ")//condicion 
            {

                id = Convert.ToInt32(oCN_Facturas.UltmimoId()) + 1;/// si no no s va a traer el proceso 
                txtFactura.Text = id.ToString();
               

            }
            else
            {
                txtFactura.Text = 1.ToString();
            }

        }
       
       
        
        
    }
}
