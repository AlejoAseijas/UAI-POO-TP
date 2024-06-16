using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1.models;

namespace TP1.services
{
    public class VentaService:AbmOperation<Dictionary<Cliente, Venta>>
    {
        public static Dictionary<Cliente, Venta> VENTAS = new Dictionary<Cliente, Venta>();

        public void Alta(Dictionary<Cliente, Venta> obj)
        {
        }

        public void Baja(Dictionary<Cliente, Venta> obj)
        {
        }

        public void Modificar(Dictionary<Cliente, Venta> obj1, Dictionary<Cliente, Venta> obj2)
        {
        }
    }
}
