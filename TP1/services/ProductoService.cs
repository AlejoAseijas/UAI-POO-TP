using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1.models;

namespace TP1.services
{
    public class ProductoService
    {
        public ProductoService()
        {
        }

        public void Alta(models.Producto producto, ListBox listBox)
        {
            listBox.Items.Add(producto);
        }

        public void Baja(models.Producto producto, ListBox listBox)
        {
            listBox.Items.Remove(producto);
        }

        public void Modificar(models.Producto productoModificar, models.Producto nuevo, ListBox listBox)
        { 
            this.Baja(productoModificar, listBox);
            this.Alta(nuevo, listBox);
        }
    
    }
}
