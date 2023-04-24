using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CE_Facturas
    {
        // se realiza la respectiva asignacion de varibales conforme a los procesos  este es para el agg factura 
        
        public DateTime Fecha { get; set; }
        public int DoClient { get; set; }
        public int Codigo_Vendedor { get; set; }
       
    }
}
