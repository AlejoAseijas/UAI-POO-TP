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

        #endregion

        #region Constructores
        public Inventario(int stock, long costo, long venta) { 
            this.Stock = stock;
            this.PrecioCosto = costo;
            this.PrecioVenta = venta;
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            return this.Stock + "-" + this.PrecioCosto + "-" + this.PrecioVenta;
        }
        #endregion
    }
}
