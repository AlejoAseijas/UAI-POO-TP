using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1.models;

namespace TP1.services
{
    public class ProductoService:AbmOperation<models.Inventario>
    {
        public static List<Inventario> PRODUCTOS = new List<Inventario>();
        public ProductoService()
        {
        }

        public void Alta(models.Inventario inventario)
        {
            PRODUCTOS.Add(inventario);
        }

        public void Baja(models.Inventario inventario)
        {
            PRODUCTOS.Remove(inventario);
        }

        public void Modificar(models.Inventario inventarioModificar, models.Inventario nuevo)
        { 
            foreach(Inventario item in PRODUCTOS)
            {
                if (inventarioModificar.Equals(item))
                {
                    inventarioModificar = nuevo;
                }
            }
        }
    
    }
}
