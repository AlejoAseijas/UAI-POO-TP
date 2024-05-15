using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.models
{
    public class ProductoAlimenticio : Producto
    {
        //Propiedad solo lectura
        public DateTime FechaDeVencimiento { get; private set; }
        public ProductoAlimenticio(string categoria, string subcategoria, string nombre, DateTime fechaDeVencimiento) : base(categoria, subcategoria, nombre)
        {
            this.FechaDeVencimiento = fechaDeVencimiento;
            base.PorcentajeDescuento = 30;
        }

        public override string ToString()
        {
            return base.ToString() + "-" + this.FechaDeVencimiento;
        }

        public override float getDescuento()
        {
            return  100;
        }
    }
}
