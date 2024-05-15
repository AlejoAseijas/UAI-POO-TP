using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.models
{
    public class Inventario
    {
        #region Propiedades
        public int Stock { get; set; }
        public long PrecioCosto { get; set; }
        public long PrecioVenta { get; set; }
        //Relacion 1 a 1. Cada producto tiene asociado un inventario y a su vez esto es una composicion
        public Producto Producto { get; set; }

        #endregion

        #region Constructores
        public Inventario()
        {
            
        }

        public Inventario(int stock, long costo, long venta, Producto producto) { 
            this.Stock = stock;
            this.PrecioCosto = costo;
            this.PrecioVenta = venta;
            this.Producto = producto;
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            return this.Stock + "-" + this.PrecioCosto + "-" + this.PrecioVenta + this.Producto;
        }
        #endregion
    }
}
