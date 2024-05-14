using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1.models;

namespace TP1.helpers
{
    public class Mock
    {
        public static void setMockProductos(ListBox listBox)
        {
            Inventario inventario1 = new Inventario(10, 100, 200);
            Inventario inventario2 = new Inventario(5, 150, 250);
            Inventario inventario3 = new Inventario(20, 80, 150);
            Inventario inventario4 = new Inventario(15, 120, 220);

            Proveedor provedor1 = new Proveedor { Nombre = "Proveedor 1" };
            Proveedor provedor2 = new Proveedor { Nombre = "Proveedor 2" };

            ProductoElectronico electronico1 = new ProductoElectronico("Electrónico", "Subcategoría 1", "Producto 1", "ALTO", inventario1) { Provedor = provedor1 };
            ProductoElectronico electronico2 = new ProductoElectronico("Electrónico", "Subcategoría 2", "Producto 2", "MEDIO", inventario2) { Provedor = provedor2 };

            ProductoAlimenticio alimenticio1 = new ProductoAlimenticio("Alimenticio", "Subcategoría 1", "Producto 3", DateTime.Now.AddDays(30), inventario3) { Provedor = provedor1 };
            ProductoAlimenticio alimenticio2 = new ProductoAlimenticio("Alimenticio", "Subcategoría 2", "Producto 4", DateTime.Now.AddDays(60), inventario4) { Provedor = provedor2 };

            List<models.Producto> productos = new List<models.Producto> { electronico1, electronico2, alimenticio1, alimenticio2 };

            foreach(models.Producto producto in productos)
            {
                listBox.Items.Add(producto);
            }

        }
    }
}
