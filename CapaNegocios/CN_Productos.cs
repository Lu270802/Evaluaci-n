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
    public class CN_Productos
    {
        CD_Productos oCD_Productos = new CD_Productos();
        public bool Idrepetido;


        public void InsertarP(CE_Productos productos)// se crea el metodo a cada metodo se llama la capa de entidades
        {
            oCD_Productos.InsertarP(productos);
        }
        public DataTable Mostrarp() // se crea el metodo de mostrar productos 
        {
            DataTable dt = new DataTable();
            dt = oCD_Productos.MostrarP();
            return dt;
        }
        public DataTable FiltrarP(CE_Productos productos)// se crea el metodo de filtrar
        {
            DataTable dt = new DataTable();
            dt = oCD_Productos.Filtrar(productos);
            return dt;
        }
        public void ModificarP(CE_Productos productos)
        {
            oCD_Productos.ModificarP(productos);
        }
        public void EliminarP(CE_Productos productos)
        {
            oCD_Productos.EliminarP(productos);
        }
        public bool IdRepetido(CE_Productos productos)
        {
            oCD_Productos.IdRepetido(productos);
            if (oCD_Productos.repetido == true)
            {
                Idrepetido = true;
                return Idrepetido;
            }
            else
            {
                Idrepetido = false;
                return Idrepetido;
            }
        }
 
    }
}
