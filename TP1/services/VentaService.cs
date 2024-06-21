using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1.models;
using TP1.views;

namespace TP1.services
{
    public class VentaService
    {
        public static Dictionary<Cliente, Venta> VENTAS = new Dictionary<Cliente, Venta>();
        private static readonly VentaService ventaServiceInstance = new VentaService();
        private ProductoService productoService = ProductoService.ObtenerInstancia();

        private VentaService()
        {
        }

        public static VentaService ObtenerInstancia()
        {
            return ventaServiceInstance;
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

        public float ObtenerTotalFacturado()
        {
            return VENTAS
                .Values
                .SelectMany(venta => venta.ventaItems)
                .Sum(venta => venta.precioVenta);
        }
    }
}
