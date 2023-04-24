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
        private SqlConnection conexion =new SqlConnection("Server=sql8005.site4now.net; Database=db_a98302_luis2708; User ID=db_a98302_luis2708_admin;Password=Luis270802; Trusted_Connection=false;MultipleActiveResultSets=true");// se crea la conexion 

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
