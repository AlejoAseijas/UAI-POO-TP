using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.models
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }

        public Cliente() { }
        public Cliente(string Nombre, string Apellido, string DNI) 
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.DNI = DNI;
        }

        public override string ToString()
        {
            return this.Nombre + "-" + this.Apellido + "-" + this.DNI;
        }

        public override bool Equals(object obj)
        {
            bool status = false;

            if (obj is Cliente)
            {
                Cliente cliente = (Cliente)obj;
                status = this.Nombre.Equals(cliente.Nombre) && this.Apellido.Equals(cliente.Apellido) && this.DNI.Equals(cliente.DNI); 
            }

            return status;
        }

    }
}
