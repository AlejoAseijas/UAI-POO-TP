using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.models
{
    public class VentaItem
    {
        public Producto producto;
        public int qty;
        public float precioVenta;

        public override string ToString()
        {
            return producto.ToString() +"- $ "+ this.precioVenta+" - Unidades vendidas: " + this.qty;
        }
    }
}
