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
        private static readonly ProductoService productoServiceInstance = new ProductoService();

        private ProductoService()
        {
        }

        public static ProductoService ObtenerInstancia()
        {
            return productoServiceInstance;
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

        public bool DisminuirStock(Inventario inventario, int qty)
        {
            Inventario inventarioEncontrado = PRODUCTOS.Find(p => p.Equals(inventario));
            bool status = false;

            if (inventarioEncontrado != null) 
            {
                int stockProducto = inventarioEncontrado.Stock;
                if (stockProducto - qty < 0)
                {
                    MessageBox.Show("No hay stock suficiente");
                }
                else
                {
                    inventarioEncontrado.Stock -= qty;
                    status = true;
                }
            }
            return status;
        }
    
    }
}
