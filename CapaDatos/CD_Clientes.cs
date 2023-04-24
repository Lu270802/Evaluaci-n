using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidades;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Clientes
    {
        CD_Conexion conexion = new CD_Conexion();
        DataTable tabla = new DataTable();  
        SqlCommand comando = new SqlCommand();
        SqlDataReader leer;
        public bool repetido;
        

        public DataTable MostrarClie()// se crea un metodo de mostrar cliente para el tema de facturacion
        {
            tabla.Clear();
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarClie"; // se llama el procedimiento almacenado 
            comando.CommandType = CommandType.StoredProcedure;
            leer= comando.ExecuteReader();  
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void Insertar(CE_Clientes clientes)// se crea el metodo de insertar un cliente
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_INSERTARCLIENT";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Docu", clientes.Docu);
            comando.Parameters.AddWithValue("@Nombre", clientes.Nombre);
            comando.Parameters.AddWithValue("@Direccion", clientes.Direccion);
            comando.Parameters.AddWithValue("@Tel", clientes.Tel);
            comando.Parameters.AddWithValue("@Corr", clientes.Correo);
            comando.ExecuteNonQuery();
          
            conexion.CerrarConexion();
         
        }
        public bool DocR(CE_Clientes clientes )// para que me cambie el estado en un texto cuando el cliente ya este 
        {
            try
            { 


                comando.Parameters.Clear();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "DocRep";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Doc", clientes.Docu);
                leer = comando.ExecuteReader();
                
                if (leer.Read())/// se la da condición a leer
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

                conexion.CerrarConexion();// que cierre la conexion 
            }
        }
        
        public DataTable FiltrarC(CE_Clientes clientes)// se crea un metodo para que me muestre un solo cliente
        {
            tabla.Clear();
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "FiltrarC";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Doc", clientes.Docu);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
        public void ModificarC(CE_Clientes clientes )/// se crea el metodo para modificar un cliente 
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_ACTUALCLIENT";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Docu",clientes.Docu);
            comando.Parameters.AddWithValue("@Nombre",clientes.Nombre);
            comando.Parameters.AddWithValue("@Direccion",clientes.Direccion);
            comando.Parameters.AddWithValue("@Tel",clientes.Tel);
            comando.Parameters.AddWithValue("@Corr",clientes.Correo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }
        public void Eliminar(CE_Clientes clientes)// se crea el metodo de elimiar
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_ELIMINARCLIENT";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Docu", clientes.Docu);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }




    }
}
