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

        public void Alta(models.Inventario inventario, ListBox listBox)
        {
            listBox.Items.Add(inventario);
        }

        public void Baja(models.Inventario inventario, ListBox listBox)
        {
            listBox.Items.Remove(inventario);
        }

        public void Modificar(models.Inventario inventarioModificar, models.Inventario nuevo, ListBox listBox)
        { 
            this.Baja(inventarioModificar, listBox);
            this.Alta(nuevo, listBox);
        }
    
    }
}
