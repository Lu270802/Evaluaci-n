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

    public class CD_Facturas
    {
        // se insatncia las clases correspondientes  conexion,comando,leer,tabla 
        CD_Conexion conexion = new CD_Conexion();
        SqlCommand comando =new SqlCommand();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
     
       

        public void AgregarFactura(CE_Facturas facturas) // se crea el metodo de agg factura  este metodo depende de agg fact 
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_AGGFACT";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Fech",facturas.Fecha); // parametros que recibe el metodo 
            comando.Parameters.AddWithValue("@DoClient ",facturas.DoClient);
            comando.Parameters.AddWithValue("@CodVende",facturas.Codigo_Vendedor);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();// limpia los parametros 
            conexion.CerrarConexion();// se cierra la conexion 

        }
        public void AggDetalleFac(CE_FacturaD factura)// se crea el metodo de agg factura detalle  
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_AGGFACTDETA";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IDFac", factura.Numero_Factura);// se meciona el idfact ya que esta es una llave foranea
            comando.Parameters.AddWithValue("@CodProd", factura.Cod_p);
            comando.Parameters.AddWithValue("@Cant", factura.Cant);
            comando.Parameters.AddWithValue("@ValUnidad", factura.ValUnidad);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public DataTable MostrarU()// se crea un metodo para mostrar el ultimo numero de registro +1
        {
            tabla.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ultimo_num";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public string UltmimoId()// SE crea el metodo para que me traiga el ultimo id 
        {
            try
            {
                comando.Parameters.Clear();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "ultimo_num";
                comando.CommandType = CommandType.StoredProcedure;
                leer= comando.ExecuteReader();
                if(leer.Read()==true)
                {
                    string id = leer["IdFactu"].ToString(); //guardamos este proceso en una varibala de tipo string 
                    leer.Close();
                    return id;
                }
                else
                {
                    leer.Close();
                   return " ";// si no que nos devuelva un valor vacio 
                }

            }
            finally
            {
                conexion.CerrarConexion();
            }


        }
        





    }
}

