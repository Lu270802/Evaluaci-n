using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaDatos
{
    public  class CD_Usuarios
    {
        CD_Conexion conexion = new CD_Conexion();
        DataTable tabla = new DataTable();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();
        public bool validar;
        public bool repetido;

        public bool IniciarSesion(CE_Usuarios usuario)// se crea bool ya que nos va a retornar un booleano
        {
            try
            {
                comando.Parameters.Clear();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "ValidacionCO";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Usuario", usuario.Usuario);// toma lo que va a guardar en las variables con entidades
                comando.Parameters.AddWithValue("@Contrasena", usuario.Contrasena);
                leer = comando.ExecuteReader();
                if (leer.Read())// si hay mas de un registro con esos datos es true
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
            finally { conexion.CerrarConexion(); }// se tiene que meter en el finally de lo contrario el proceso no se cierra
        }

        public void Insertar(CE_Usuarios usuario)// se crea el metodo de insertar
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "AGGVENDEDOR";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Cod",usuario.Codigo);
            comando.Parameters.AddWithValue("@Usuario",usuario.Usuario);
            comando.Parameters.AddWithValue("@Contraseña",usuario.Contrasena);
            comando.Parameters.AddWithValue("@Nombre",usuario.Nombre);
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();

        }
        public bool VendedorR(CE_Usuarios usuario)// se crea el metodo para que nos diga si un vendedor ya esta registrado
        {
            try
            {
                comando.Parameters.Clear();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "VendedorR";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Codigo", usuario.Codigo);
                leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    repetido = true;
                    return repetido;
                }
                else
                {
                    repetido = false;
                    return repetido;

                }
            }
            finally
            {

                conexion.CerrarConexion();
            }

        }
        public DataTable Mostrar()// se crea el metodo de mostrar todos los vendedores
        {
            tabla.Clear();
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarVendedores"; // se llama el procedimiento almacenado 
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public DataTable FiltrarV(CE_Usuarios usuario)// se crea el metodo de filtrar los vendedores 
        {
            tabla.Clear();
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "FiltrarVendedor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Codigo",usuario.Codigo);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void ModificarV(CE_Usuarios usuario)//creamos el metodod de modficar vendedor
        {
             comando.Connection = conexion.AbrirConexion();
             comando.CommandText = "ACTUALIZARVENDE";
             comando.CommandType = CommandType.StoredProcedure;
             comando.Parameters.AddWithValue("@Codigo", usuario.Codigo);
             comando.Parameters.AddWithValue("@Nombre", usuario.Nombre);
             comando.Parameters.AddWithValue("@Contraseña",usuario.Contrasena);
             comando.Parameters.AddWithValue("@Usuario", usuario.Usuario);
             comando.ExecuteNonQuery();
             comando.Parameters.Clear();
             conexion.CerrarConexion();
         
        }
        public void EliminarV(CE_Usuarios usuario)// Metodo para eliminar 
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarV";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Codigo",  usuario.Codigo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

    }
}
