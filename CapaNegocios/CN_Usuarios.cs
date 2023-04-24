using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class CN_Usuarios
    {
        CD_Usuarios oCD_Usuarios = new CD_Usuarios();
        public bool validar;// Se crea la variable bool que es para meter el procedimiento de el inicar sesion en capa productos 
        public bool VendedorR;

        public bool IniciarSesion(CE_Usuarios usuario)// se crea el metodo 
        {
            oCD_Usuarios.IniciarSesion(usuario);
            if (oCD_Usuarios.validar == true)// se crean las condiciones para que nos pueda retornar 
            {
                validar = true;
                return validar;
            }
            else
            {
                validar = false;
                return validar;
            }
        }
        public void Insertar(CE_Usuarios usuario)// se crea el metodo de insertar en esta capa
        {
            oCD_Usuarios.Insertar(usuario);// se llama el metodo de la capa datos
        }
        public bool VendedorRe(CE_Usuarios usuario)// se crea el metodo 
        {
            oCD_Usuarios.VendedorR(usuario);// se llama el metodo de la capa datos 
            if (oCD_Usuarios.repetido == true)// se la dan las condiciones
            {
                VendedorR = true;
                return VendedorR;
            }
            else
            {
                VendedorR = false;
                return VendedorR;
            }
        }
        public DataTable Mostrar()// se crea metodo para mostrar todos los clientes
        {
            DataTable dt = new DataTable();
            dt = oCD_Usuarios.Mostrar();
            return dt;
        }
        public DataTable Filtrar(CE_Usuarios usuario)// se crea metodo para filtrar un vendedor
        {
            DataTable dt = new DataTable();
            dt = oCD_Usuarios.FiltrarV(usuario);
            return dt;
        }
        public void Modificar (CE_Usuarios usuario)// metodo para modificar el vendedor
        {
            oCD_Usuarios.ModificarV(usuario);
        }
        public void Eliminar(CE_Usuarios usuario)//metodo para elminar
        {
            oCD_Usuarios.EliminarV(usuario);// se llama el de la capa datos 
        }
    }
}
