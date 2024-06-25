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
        public List<models.Inventario> items { get; set; }
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
            items.Add(inventario);
        }

        public void Baja(models.Inventario inventario)
        {
            items.Remove(inventario);
        }

        public void Modificar(models.Inventario inventarioModificar, models.Inventario nuevo)
        { 
            List<Inventario> modificado = new List<Inventario>();

            foreach(Inventario item in items)
            {
                if (inventarioModificar.Equals(item))
                {
                    modificado.Add(nuevo);
                }
                else
                {
                    modificado.Add(item);
                }
            }

            items = modificado;
        }

        public bool DisminuirStock(Inventario inventario, int qty)
        {
            Inventario inventarioEncontrado = items.Find(p => p.Equals(inventario));
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

        public List<Inventario> GetProductoAlimenticios()
        {
            return items.Where(Inventario => Inventario.Producto is ProductoAlimenticio).ToList();
        }

        public List<Inventario> GetProductoElectronicos()
        {
            return items.Where(Inventario => Inventario.Producto is ProductoElectronico).ToList();
        }

    }
}
