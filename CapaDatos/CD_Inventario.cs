using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Inventario
    {
        CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable Tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarI()
        {
            comando.Parameters.Clear();
            Tabla.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_BUSCARINVENTARIOS";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            Tabla.Load(leer);
            conexion.CerrarConexion();
            return Tabla;
        }

        //public DataTable BuscarI(CE_Productos productos)
        //{
        //    Tabla.Clear();
        //    comando.Parameters.Clear();
        //    comando.Connection = conexion.AbrirConexion();
        //    comando.CommandText = "SP_BUSCARINVENTARIO";
        //    comando.CommandType = CommandType.StoredProcedure;
        //    comando.Parameters.AddWithValue("@Prod", productos.Codigo);
        //    leer = comando.ExecuteReader();
        //    Tabla.Load(leer);
        //    conexion.CerrarConexion();
        //    return Tabla;

        //}
    }
}
