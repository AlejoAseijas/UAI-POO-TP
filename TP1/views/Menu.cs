using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1.helpers;

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
            manageMdi(new Producto());
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Mock.setMockData();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageMdi(new Ventas());
        }

        private void manageMdi(Form form)
        {
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageMdi(new Clientes());
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageMdi(new Informes());
        }
    }
}
