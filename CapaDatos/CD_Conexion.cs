using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDatos
{
    public  class CD_Conexion
    {
        private SqlConnection conexion =new SqlConnection("Server=DESKTOP-N6BHBBT\\LUIS; Database=NaturVida; Integrated Security=true");// se crea la conexion 

        public SqlConnection AbrirConexion() // se abre la conexion
        {
            if(conexion.State== ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }
        public SqlConnection CerrarConexion()// se cierra la conexion 
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }
    }
}
