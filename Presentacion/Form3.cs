using CapaEntidades;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Presentacion
{
    public partial class Productos : Form
    {
        // se estancia ce_producto,cn_productos,cn_validaciones 
        CE_Productos producto = new CE_Productos();
        CN_Productos oCN_productos= new CN_Productos();
        CN_Validaciones oCN_Validaciones= new CN_Validaciones();
      

        public Productos()
        {
            InitializeComponent();
            Mostrarp(); // que al cargar nos muestre 
        }

      

        private void btnGuardar_Click(object sender, EventArgs e)// este boton pertence al item de agregar producto
        {

            if (txtDescripcion.Text == "" || txtDescripcion.Text == " " || txtCantidad.Text == "" || txtCodigo.Text == "" || txtValor.Text == "") 
            {
                MessageBox.Show("Todos los campos deben ser digitados ");
            }
            else
            {
                    producto.Codigo = Convert.ToInt32(txtCodigo.Text);// que vaya guardando en sus respectivas variables lo que hay en las cjas de text y relizar conversiones si es necesario 
                    producto.Descri = txtDescripcion.Text;
                    producto.ValUnd = Convert.ToInt32(txtValor.Text);
                    producto.Cantida = Convert.ToInt32(txtCantidad.Text);
                    oCN_productos.InsertarP(producto);// despues que lea se llama al metodo de insertar de la capa negocios 
                    MessageBox.Show(" Producto agregado correctamente ");
                    limpiar();
                                                            
            }

        }
        #region
        private void limpiar()
        {
            txtCantidad.Clear();
            txtValor.Clear();
            txtDescripcion.Clear();
            txtCodigo.Clear();
            txtCodigo.Focus();
        }
        private void LimpiarP()
        {
            txtC.Clear();
            txtCa.Clear();
            txtV.Clear();
            txtD.Clear();
            
        }

        #endregion
        private void Mostrarp()// se crea un metdo para resumir codigo en el load 
        {
            CmbBuscar.DataSource = oCN_productos.Mostrarp(); // que lea lo de la tabla y eso es igual al metodo
            CmbBuscar.ValueMember = "Codigo"; // llamamos el codigo que es la llave primaria 
            CmbBuscar.DisplayMember = "Descripción";// esto es lo que se va a ver en el comboBox

        }
        private void MostrarC() // se crea metodo para Mostrarproducto pero en el actualizar producto 
        {
            CmbCambio.DataSource = oCN_productos.Mostrarp();// se llama el metodo de la capa negocios productos , este metodo se usa en varias consultas 
            CmbCambio.ValueMember = "Codigo";
            CmbCambio.DisplayMember = "Descripción";

        }

        private void tbConsultar_Enter(object sender, EventArgs e)// que cuando cambie de pestañas me cargue en el combo la informacion previa
        {
            Mostrarp();// se vul¿elve a llamar el metodo
        }

        private void btnConsultar_Click(object sender, EventArgs e)// este es para que me filtre un producto en especifio en el item consultar 
        {

            producto.Codigo = Convert.ToInt32(CmbBuscar.SelectedValue.ToString());// que del producto selecciona me guarde el codigo que es la llave primaria, lo conviertaa entero puesto que deber ir por defecto en string y lo guarde el codigo de producto 
            DgvProductos.DataSource= oCN_productos.FiltrarP(producto);// en el data creado me busque ese mismo id y este proceso es el realizado en capa negocios
            
        }


        private void btnMostrar_Click(object sender, EventArgs e) // este boton me traer todos los producto al data
        {
            DgvProductos.DataSource=oCN_productos.Mostrarp();// se llama el metodo de la capa negocios 
        }

        private void tbModificar_Enter(object sender, EventArgs e)// al cambiar al item de actualizar lo priemro que haga es mostrar el metodo
        {
            MostrarC();// carga el combo box con la descripcion de cada producto 
        }

        private void CmbCambio_SelectedIndexChanged(object sender, EventArgs e) // combobox que pertence al item de Actualizar producto 
        {
            DataRowView info = CmbCambio.SelectedItem as DataRowView;// que se guarde en una variable la informacion del item seleccionado 
            if(info!=null)
            {
                DataRow inf = info.Row;
                txtC.Text = inf["Codigo"].ToString();// que nos traiga lo que estan en las filas y lo pongan en los text box 
                txtD.Text = inf["Descripción"].ToString();
                txtCa.Text = inf["Cantidad"].ToString();
                txtV.Text = inf["Valor_Unidad"].ToString();
            }
            
        }

        private void btnCambios_Click(object sender, EventArgs e) // este boton pertence al item de actualizar producto 
        {
            producto.Codigo = Convert.ToInt32(txtC.Text); // que nos guarde en las variables  lo que se arreglo en los textbox
            producto.Descri = txtD.Text;
            producto.ValUnd = Convert.ToInt32(txtV.Text);// se convierte si es necesario 
            producto.Cantida = Convert.ToInt32(txtCa.Text);
            oCN_productos.ModificarP(producto);// se llama al metodo 
            MessageBox.Show("Se edito correctamente ");
            LimpiarP();
            Mostrarp();
            
        }
        private void MostrarPe()// para que me muestre los productos pero en el item de eliminar
        {
            CmbEliminar.DataSource = oCN_productos.Mostrarp();// que me cargu el combo box con el metodo 
            CmbEliminar.ValueMember = "Codigo";
            CmbEliminar.DisplayMember = "Descripción";

        }

       

        private void btnEliminar_Click(object sender, EventArgs e)// que al darle eliminar 
        {
            if(CmbEliminar.SelectedIndex>=1)// si la seleccion del prodccuto  es igual o mayor a uno 
            {
                DialogResult resultado = MessageBox.Show("Seguro que desea eliminar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);//pregunta lo siguiente 
                if (resultado == DialogResult.Yes)// depende de lo que seleccione el usuario 
                {
                    producto.Codigo = Convert.ToInt32(CmbEliminar.SelectedValue.ToString());// que tome el id del comboBox y lo guarde en la variable para poder realizar el procedimiento 
                    oCN_productos.EliminarP(producto);// se llama el metodo de eliminar de la capa negocios 
                    MessageBox.Show("Se Elimino correctamente ");
                    Mostrarp();

                }

            }
            else
            {
                MessageBox.Show("Error"); // si no el error
            }
        }

        private void tabControl1_Enter(object sender, EventArgs e)// qu al darle click me cargue el comboBox 
        {
            MostrarPe();
        }


        private void txtValor_KeyPress(object sender, KeyPressEventArgs e) // se realiza las validaciones en todos los textos correspondientes 
        {
            oCN_Validaciones.SoloNum(e);// se llama el metodo de l capa negocios el keypress sirve para que al presionar una letra el realize la validacion 
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            oCN_Validaciones.SoloNum(e);
        }

        private void txtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            oCN_Validaciones.SoloNum(e);
        }

        private void txtV_KeyPress(object sender, KeyPressEventArgs e)
        {
            oCN_Validaciones.SoloNum(e);
        }

        private void txtCa_KeyPress(object sender, KeyPressEventArgs e)
        {
            oCN_Validaciones.SoloNum(e);
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            oCN_Validaciones.SoloNum(e);
            
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)// validacion para que me diga si el codigo del producto esta repetido 
        {
           
            try
            {
                if (txtCodigo.Text == "")
                {
                    MessageBox.Show("El campor no puede estar vacio ");
                }
                else
                {
                    producto.Codigo = Convert.ToInt32(txtCodigo.Text);
                    oCN_productos.IdRepetido(producto);

                    if (oCN_productos.Idrepetido == true)
                    {
                        lblRepetido.Text = "El codigo ya existe ";
                    }
                    else
                    {
                        lblRepetido.Text = "";
                    }

                }

            }
            catch
            {
                MessageBox.Show("Ha superado el limite");
            }
        }

       

        
    }
}
