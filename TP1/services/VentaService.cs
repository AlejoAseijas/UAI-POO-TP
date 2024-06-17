using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1.models;
using TP1.views;

namespace TP1.services
{
    public class VentaService:AbmOperation<Dictionary<Cliente, Inventario>>
    {
        public static Dictionary<Cliente, Venta> VENTAS = new Dictionary<Cliente, Venta>();
        private static readonly VentaService ventaServiceInstance = new VentaService();
        private ProductoService productoService = ProductoService.ObtenerInstancia();

        public VentaService()
        {
        }

        public static VentaService ObtenerInstancia()
        {
            return ventaServiceInstance;
        }

        public void Alta(Dictionary<Cliente, Inventario> obj)
        {
            Alta(obj, 1);
        }

        public void Alta(Dictionary<Cliente, Inventario> obj, int qty)
        {
            Cliente cliente = obj.Keys.FirstOrDefault();
            Inventario inventario = obj[cliente];
            
            bool statusProducto = productoService.DisminuirStock(inventario, qty);

            if (statusProducto)
            {
                if (VENTAS.ContainsKey(cliente))
                {
                    Venta ventaExistente = VENTAS[cliente];

                    VentaItem nuevoItem = new VentaItem
                    {
                        producto = inventario.Producto,
                        precioVenta = inventario.PrecioVenta * qty,
                        qty = qty
                    };

                    ventaExistente.ventaItems.Add(nuevoItem);

                    VENTAS[cliente] = ventaExistente;
                }
                else
                {

                    List<VentaItem> items = new List<VentaItem>
                {
                    new VentaItem() { producto = inventario.Producto, precioVenta = inventario.PrecioVenta * qty, qty = qty }
                };

                    VENTAS.Add(cliente, new Venta() { ventaItems = items });
                }
            }

        }

        public void Baja(Dictionary<Cliente, Inventario> obj)
        {
        }

        public void Modificar(Dictionary<Cliente, Inventario> obj1, Dictionary<Cliente, Inventario> obj2)
        {
        }

    }
}
