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

        public ProductoElectronico(string categoria, string subcategoria, string nombre, string consumo) : base(categoria, subcategoria, nombre)
        {
            this.Consumo = consumo;
        }

        public override string ToString()
        {
            return base.ToString() + "-" + this.Consumo;
        }

        public override string GenerarCodigo()
        {
            return this.GetHashCode().ToString();
        }

        public override bool Equals(object obj)
        {
            bool status = false;

            if (obj is ProductoElectronico)
            {
                ProductoElectronico productoElectronico = (ProductoElectronico)obj;
                status = base.Equals(obj) && this.Consumo == productoElectronico.Consumo;
            }

            return status;
        }
    }
}
