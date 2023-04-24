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
    public  class CN_Inventario
    {
        CD_Inventario oCD_Inventario = new CD_Inventario();

        public DataTable Mostrar()
        {
            DataTable dt = new DataTable();
            dt = oCD_Inventario.MostrarI();
            return dt;
        }
        //public DataTable Buscar(CE_Productos producto)
        //{
        //    DataTable dt = new DataTable();
        //    dt = oCD_Inventario.BuscarI(producto);
        //    return dt;
        //}

    }
}
