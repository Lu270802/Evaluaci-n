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
    public class CN_Clientes
    {
        CD_Clientes oCD_Clientes = new CD_Clientes();
        CD_Productos oCD_Productos = new CD_Productos();
        public bool DocRe;
        public DataTable MostrarClien()// se llama el metodo de mostrar cliente 
        {
            DataTable dt = new DataTable();
            dt = oCD_Clientes.MostrarClie();
            return dt;
        }
        public DataTable MostrarP()// se crea un metodo llamado mostrar p
        {
            DataTable dt = new DataTable();
            dt = oCD_Productos.MostrarP(); // se llama el metodo de la capa de datos productos 
            return dt;
        }
        public void Insertar(CE_Clientes clientes)
        {
            oCD_Clientes.Insertar(clientes);
        }
        public bool DocR(CE_Clientes clientes)// se ponen las condiciones para que las podamos pasar a la capa de presentacion
        {
            oCD_Clientes.DocR(clientes);
            if (oCD_Clientes.repetido == true)
            {
                DocRe = true;
                return DocRe;
            }
            else
            {
                DocRe = false;
                return DocRe;
            }
        }
      public DataTable FiltrarC(CE_Clientes clientes )// se crea el metodo de filtrar
      { 
            DataTable dt = new DataTable();
            dt = oCD_Clientes.FiltrarC(clientes);
            return dt;
      }
        public void ModificarC(CE_Clientes clientes) // metodo de modificar un cliente
        {
            oCD_Clientes.ModificarC(clientes);
        }

        public void Eliminar(CE_Clientes clientes) // se llama el metodo de eliminar 
        {
            oCD_Clientes.Eliminar(clientes);
        }
        

    }
}
