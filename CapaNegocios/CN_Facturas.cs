using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios

{
    public class CN_Facturas

    {

        CD_Facturas oCD_Facturas = new CD_Facturas();
       
        public void AggFac(CE_Facturas facturas)// se creaun metodo de agg fac
        {
            oCD_Facturas.AgregarFactura(facturas); // se llama al metodo de la capa datos 
        }

        public void AggDf(CE_FacturaD factura)// se creae el metodo de agg detalle factura 
        {
            oCD_Facturas.AggDetalleFac(factura);
        }

        public DataTable Mostrarultimo()// se crea el metodo de mostrar el ultimo numero 
        {
            DataTable dt = new DataTable();
            dt = oCD_Facturas.MostrarU();
            return dt;
        }
        public string  UltmimoId()// se crea el metodo 
        {
           string id = oCD_Facturas.UltmimoId();
            return id;
        }
    }
}
