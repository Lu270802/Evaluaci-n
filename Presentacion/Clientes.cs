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
    public partial class Clientes : Form
    {
        CN_Clientes oCN_Clientes =new CN_Clientes();
        CE_Clientes clientes = new CE_Clientes();
        CN_Validaciones oCN_Validaciones = new CN_Validaciones();


        public Clientes()
        {
            InitializeComponent();
            MostrarC();
        }

        private void btnGuardar_Click(object sender, EventArgs e)// boton que pertence al item de agg cleinte
        {
            if(txtDocumento.Text=="" || txtNombre.Text==""
                ||txtNombre.Text==" "||txtDireccion.Text==""||txtDireccion.Text==" "
                ||txtTelefono.Text==""||txtTelefono.Text==" "||txtCorreo.Text==""||
                txtCorreo.Text==" ")// que me valide que  ninguno de los campos este vacio ni digite espacios
            {
                MessageBox.Show("Todos los campos deben ser digitados ", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                clientes.Docu = Convert.ToInt32(txtDocumento.Text);
                clientes.Nombre = txtNombre.Text;
                clientes.Direccion = txtDireccion.Text;
                clientes.Tel = txtTelefono.Text;
                clientes.Correo = txtCorreo.Text;
                clientes.Correo = txtCorreo.Text;
                oCN_Clientes.Insertar(clientes);
                MessageBox.Show("Cliente agregado correctamente ");
                limpiar();
            }

        }
        #region
        private void limpiar()
        {
            txtDocumento.Clear();
            txtDireccion.Clear();
            txtCorreo.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtDocumento.Focus();
        }
        private void LimpiarC()
        {
            txtCoC.Clear();
            txtDiC.Clear();
            txtNC.Clear();
            txtDocC.Clear();
            txtTeC.Clear();
        }


        #endregion

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)//item cliente
        {
            oCN_Validaciones.SoloNum(e);
        }

        private void txtDocumento_TextChanged(object sender, EventArgs e) //item cliente
        {
            try
            {
                if(txtDocumento.Text=="")
                {
                    MessageBox.Show("El campo no puede estar vacio", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    clientes.Docu = Convert.ToInt32(txtDocumento.Text);
                    oCN_Clientes.DocR(clientes);
                    if(oCN_Clientes.DocRe==true)
                    {
                        lblDoc.Text="El cliente ya se encuentra registrado ";
                    }
                    else
                    {
                        lblDoc.Text = "";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ha superado el limite", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        // boton de item consultar cliente/
        private void btnMostar_Click(object sender, EventArgs e)// se llama al metodo para que me mustre todos los clientes 
        {
            DgvConsulta.DataSource = oCN_Clientes.MostrarClien();
        }

        private void MostrarC()// creo el metodo para que me cargue en el combo los clientes 
        {
            cmbConsulta.DataSource = oCN_Clientes.MostrarClien();
            cmbConsulta.ValueMember = "Documento";
            cmbConsulta.DisplayMember = "Nombre";
        }

      

        private void btnFiltrar_Click(object sender, EventArgs e)// que al seleciionar nos traiga la informacion de ese cliente 
        {
            
            clientes.Docu = Convert.ToInt32(cmbConsulta.SelectedValue.ToString());
            DgvConsulta.DataSource= oCN_Clientes.FiltrarC(clientes);//llamamos el meotod de filtrar
            
            
        }

        private void tbCCliente_Enter(object sender, EventArgs e)
        {
            MostrarC();
        }
        // boton que pertenece al item de modificar cliente

        private void tbMoCliente_Enter(object sender, EventArgs e)
        {
          MostrarCC() ;// nos carga en el comboBox
        }
        private void MostrarCC()// para que me mustre en el comboBox de cambio 
        {
            cmbCambio.DataSource = oCN_Clientes.MostrarClien();
            cmbCambio.ValueMember = "Documento";
            cmbCambio.DisplayMember = "Nombre";
        }

        private void cmbCambio_SelectedIndexChanged(object sender, EventArgs e) // para que al seleccionar un item me lo traiga en los textbox
        {
            DataRowView dt = cmbCambio.SelectedItem as DataRowView; // que se guarde en una variable la informacion del item seleccionado 
            if (dt!= null)
            {
                DataRow dts = dt.Row;
                txtDocC.Text = dts["Documento"].ToString();// que nos traiga y lo ponga en los textBox
                txtNC.Text = dts["Nombre"].ToString();
                txtTeC.Text = dts["Telefono"].ToString();
                txtDiC.Text = dts["Direccion"].ToString();
                txtCoC.Text = dts["Correo"].ToString();
            }

        }

        private void btnCambio_Click(object sender, EventArgs e)
        {
            clientes.Docu = Convert.ToInt32(txtDocC.Text);// que me tome lo que hay en los text box
            clientes.Nombre = txtNC.Text;
            clientes.Tel = txtTeC.Text;
            clientes.Direccion = txtDiC.Text;
            clientes.Correo = txtCoC.Text;
            oCN_Clientes.ModificarC(clientes);// llamo al metodo
            MessageBox.Show("Se edito correctamente");
            LimpiarC();
            MostrarC();
        }
        // boton que pertenece el metodo de eliminar 

        private void Eliminar()// se crea el metodo para que me cargue el comboBox de eliminar
        {
            CmbEliminar.DataSource = oCN_Clientes.MostrarClien();
            CmbEliminar.ValueMember = "Documento";
            CmbEliminar.DisplayMember = "Nombre";

        }

        private void tbElCliente_Enter(object sender, EventArgs e)
        {
            Eliminar();// que me muestre el comboBox de eliminar 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (CmbEliminar.SelectedIndex >= 1)// si la seleccion del prodccuto  es igual o mayor a uno 
            {
                DialogResult resultado = MessageBox.Show("Seguro que desea eliminar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);//pregunta lo siguiente 
                if (resultado == DialogResult.Yes)// depende de lo que seleccione el usuario 
                {
                    clientes.Docu = Convert.ToInt32(CmbEliminar.SelectedValue.ToString());// que tome el id del comboBox y lo guarde en la variable para poder realizar el procedimiento 
                    oCN_Clientes.Eliminar(clientes);// se llama el metodo de eliminar de la capa negocios 
                    MessageBox.Show("Se Elimino correctamente ");
                    MostrarC();

                }

            }
            else
            {
                MessageBox.Show("Error"); // si no el error
            }
        }

       
    }
}
