using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1.views
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producto form = new Producto();
            form.MdiParent = this;
            form.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
