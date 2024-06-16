using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.models
{
    public class Proveedor
    {
        public string Nombre { get; set; }

        public Proveedor() { }

        public Proveedor(string nombre)
        {
            this.Nombre = nombre;
        }

        public override string ToString()
        {
            return this.Nombre;
        }

        public override bool Equals(object obj)
        {
            bool status = false;
            
            if (obj is Proveedor)
            {
                Proveedor proveedor = (Proveedor)obj;
                status = this.Nombre == proveedor.Nombre;
            }
            
            return status;
        }
    }
}
