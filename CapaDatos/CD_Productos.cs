using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace CapaDatos
{
    public class CD_Productos
    {

        CD_Conexion conexion = new CD_Conexion();
        DataTable tabla = new DataTable();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();
        public bool repetido;

       
        public void InsertarP(CE_Productos productos)// se crea el metodo de insertar producto 
        {
            comando.Parameters.Clear();
            comando.Connection=conexion.AbrirConexion();
            comando.CommandText = "SP_INSERTARPRODUCT";
            comando.CommandType= CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Codigo",productos.Codigo);
            comando.Parameters.AddWithValue("@Descri",productos.Descri);
            comando.Parameters.AddWithValue("@ValUnd",productos.ValUnd);
            comando.Parameters.AddWithValue("@Cantida",productos.Cantida);
            comando.ExecuteNonQuery ();
            conexion.CerrarConexion() ;
        }
        public DataTable MostrarP()// se crea el metodo de mostrar productos 
        {
            tabla.Clear();
            comando.Parameters.Clear();
            comando.Connection= conexion.AbrirConexion();
            comando.CommandText = "mostrarP";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion .CerrarConexion() ;
            return tabla;
        }
        public DataTable Filtrar(CE_Productos productos)// se crea el metodo de filtrar prodcuts
        {
            tabla.Clear();
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarU";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Codigo", productos.Codigo);
            leer= comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public  void ModificarP (CE_Productos productos)// se crea el metodo de modificar p
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_ACTUALIZARPROD";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@CodNew",productos.Codigo);
            comando.Parameters.AddWithValue("@Descri",productos.Descri);
            comando.Parameters.AddWithValue("@ValUnd",productos.ValUnd);
            comando.Parameters.AddWithValue("@Cant",productos.Cantida);
            comando.Parameters.AddWithValue("@Cod",productos.Codigo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void EliminarP(CE_Productos productos)// se crea el metodo de elimninar p
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_ELIMINARPROD";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Cod",productos.Codigo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public bool IdRepetido(CE_Productos productos)// se crea el metodo de buscar un id repetido
        {
            try
            {
                comando.Parameters.Clear();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "IdRep";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Codigo", productos.Codigo);
                leer=comando.ExecuteReader();
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


    }
}
