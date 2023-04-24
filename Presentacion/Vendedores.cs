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
    public partial class Vendedores : Form
    {
        CN_Usuarios oCN_Usuarios = new CN_Usuarios();
        CN_Validaciones Validaciones= new CN_Validaciones();
        CE_Usuarios usuario =new CE_Usuarios();

        public Vendedores()
        {
            InitializeComponent();
            
        }

        // boton que pertence al item  agg vendedor
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //ponemos la condición de que ninguno de los campos esten vacios
            if(txtCodigo.Text==""|| txtNombre.Text==""||txtNombre.Text==" "||txtUsuario.Text==""
                ||txtUsuario.Text== " "||txtContrasena.Text==""||txtContrasena.Text==" ")
            {
                MessageBox.Show("Todos los campos deben ser digitados ", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //creamos una varibale y llamamos el metodo de encriptar el campo y eso dentro de la variable
                string encriptar = CN_Validaciones.GetSHA256(txtContrasena.Text);
                usuario.Codigo = Convert.ToInt32(txtCodigo.Text);
                usuario.Contrasena = encriptar;
                usuario.Nombre = txtNombre.Text;
                usuario.Usuario=txtUsuario.Text;
                oCN_Usuarios.Insertar(usuario);
                MessageBox.Show("El vendedor agregado correctamente ");
                limpiar();
            }
        }
        #region
        private void limpiar()
        {
            txtNombre.Clear();
            txtUsuario.Clear();
            txtCodigo.Clear();
            txtContrasena.Clear();
            txtNombre.Focus();

        }
        private void LimpiarC()
        {
            txtNCambio.Clear();
            txtCoCambio.Clear();
            txtConCambio.Clear();
            txtUCambio.Clear();
        }
        #endregion

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigo.Text == "")
                {
                    MessageBox.Show("El campo no puede estar vacio", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    usuario.Codigo = Convert.ToInt32(txtCodigo.Text);
                    oCN_Usuarios.VendedorRe(usuario);
                    if (oCN_Usuarios.VendedorR == true)
                    {
                        lblVendedorR.Text = "El vendedor ya se encuentra registrado ";
                    }
                    else
                    {
                        lblVendedorR.Text = "";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ha superado el limite", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNum(e);
        }



        //boton que pertence al item de consultar vendedor

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            DgvConsulta.DataSource = oCN_Usuarios.Mostrar();
        }

        private void MostrarV()// creo el metodo para que me cargue en el combo los Vendedores
        {
            cmbConsultar.DataSource = oCN_Usuarios.Mostrar();
            cmbConsultar.ValueMember = "Codigo";
            cmbConsultar.DisplayMember = "Nombre";
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            usuario.Codigo = Convert.ToInt32(cmbConsultar.SelectedValue.ToString());
            DgvConsulta.DataSource = oCN_Usuarios.Filtrar(usuario);
            
        }

        private void tbConsultar_Enter(object sender, EventArgs e)// Que me muestre el comboBox con su infromacion
        {
            MostrarV();
        }

        // boton que pertenece al item de modificar vendedores 

        private void MostrarVC()// para que me mustre en el comboBox de cambio 
        {
            cmbCambio.DataSource = oCN_Usuarios.Mostrar();
            cmbCambio.ValueMember = "Codigo";
            cmbCambio.DisplayMember = "Nombre";
        }

        private void tbModificar_Enter(object sender, EventArgs e)//que me mustre el comboBox cargado
        {
            MostrarVC();
        }

        private void cmbCambio_SelectedIndexChanged(object sender, EventArgs e)//configuración del comboBox
        {
            DataRowView dt = cmbCambio.SelectedItem as DataRowView; // que se guarde en una variable la informacion del item seleccionado 
            if (dt != null)
            {
                DataRow dts = dt.Row;
                txtCoCambio.Text = dts["Codigo"].ToString();// que nos traiga y lo ponga en los textBox
                txtNCambio.Text = dts["Nombre"].ToString();
                txtUCambio.Text = dts["Usuario"].ToString();
               
            }
        }

        private void btnGuardarCambio_Click(object sender, EventArgs e)// coonfiguramos el boton de guardar
        {
            string encriptar = CN_Validaciones.GetSHA256(txtConCambio.Text);
            usuario.Codigo = Convert.ToInt32(txtCoCambio.Text);
            usuario.Contrasena = encriptar;
            usuario.Usuario = txtUCambio.Text;
            usuario.Nombre = txtNCambio.Text;
            oCN_Usuarios.Modificar(usuario);
            MessageBox.Show(" Se edito correctamente");
            LimpiarC();
            MostrarV();
           
        }
        // boton que pertenece al item de Eliminar Vendedores 

        private void Eliminar() //crreamos metodo para que nos cargue el comboBox
        {
            cmbEliminar.DataSource = oCN_Usuarios.Mostrar();
            cmbEliminar.ValueMember = "Codigo";
            cmbEliminar.DisplayMember = "Nombre";
        }

        private void tbEliminar_Enter(object sender, EventArgs e)  // que nos muestre el comboBox
        {
            Eliminar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)// metodo para eliminar 
        {
            if (cmbEliminar.SelectedIndex >= 1)// si la seleccion del prodccuto  es igual o mayor a uno 
            {
                DialogResult resultado = MessageBox.Show("Seguro que desea eliminar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);//pregunta lo siguiente 
                if (resultado == DialogResult.Yes)// depende de lo que seleccione el usuario 
                {
                    usuario.Codigo = Convert.ToInt32(cmbEliminar.SelectedValue.ToString());// que tome el id del comboBox y lo guarde en la variable para poder realizar el procedimiento 
                    oCN_Usuarios.Eliminar(usuario);// se llama el metodo de eliminar de la capa negocios 
                    MessageBox.Show("Se Elimino correctamente ");
                    MostrarV();

                }

            }
            else
            {
                MessageBox.Show("Error"); // si no el error
            }
        }
    }
}
