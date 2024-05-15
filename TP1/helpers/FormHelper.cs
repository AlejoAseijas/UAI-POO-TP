using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1.models;
using TP1.services;

namespace TP1.helpers
{
    public class FormHelper
    {

        public static void clearTextBoxAndRadioButtons(Control control) 
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = null;
                } else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedItem = null;
                }
                else if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }

                if (c.HasChildren)
                {
                    clearTextBoxAndRadioButtons(c);
                }
            }
        }

        public static models.Inventario getProductoFromListBox(ListBox listBox)
        {
            models.Inventario inventario = (models.Inventario)listBox.SelectedItem;
            


            return inventario;

        }

    }
}
