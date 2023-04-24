using CapaEntidades;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Login : Form
        // se realizan las estancias de las clases 
    {
        CE_Usuarios usuario =new CE_Usuarios();
        CN_Usuarios oCN_Usuarios =new CN_Usuarios();
      

        
        public Login()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
             string  encriptar=CN_Validaciones.GetSHA256(txtContresena.Text); //se crea un variable de tipo string y  se guarda en encriptar lo  hay en txt
            usuario.Usuario=txtusuario.Text; // se guarda lo que se ha digitado en los textos en sus respetivas variables 
            usuario.Contrasena = encriptar;// se guarda la encriptacion en esa variable 
            oCN_Usuarios.IniciarSesion(usuario);// se llama el metodo de la capa de negocios 
            if(oCN_Usuarios.validar==true)
            {
                Items  Inicio=new Items();
                MessageBox.Show("Acceso concedido");// que nos imprima el mensaje si es correcto
                Hide();
                Inicio.Show();
            }
            else
            {
                MessageBox.Show("El usuario y la contraseña no son correctos");// imprime el error
            }

        }
       

        
        
    }
}
