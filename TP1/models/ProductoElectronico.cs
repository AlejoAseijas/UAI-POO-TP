using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.models
{
    public class ProductoElectronico : Producto
    {
        public string Consumo { get; set; }

        public ProductoElectronico(string categoria, string subcategoria, string nombre, string consumo, Inventario inventario) : base(categoria, subcategoria, nombre, inventario)
        {
            this.Consumo = consumo;
        }

        public override string ToString()
        {
            return base.ToString() + "-" + this.Consumo;
        }

        public override float getDescuento()
        {
            return this.Inventario.PrecioVenta - 5000;
        }
    }
}
