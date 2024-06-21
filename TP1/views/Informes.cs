using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1.models;
using TP1.services;

namespace TP1.views
{
    public partial class Informes : Form
    {
        public Informes()
        {
            InitializeComponent();
        }

        private ProductoService productoService = ProductoService.ObtenerInstancia();
        private VentaService ventaService = VentaService.ObtenerInstancia();
        private ClienteService clienteService = ClienteService.ObtenerInstancia();


        private void Informes_Load(object sender, EventArgs e)
        {
            this.lblProductos.Text = productoService.items.Count().ToString();
            this.lblProductosAlimenticios.Text = productoService.GetProductoAlimenticios().Count().ToString();
            this.lblProductosElectronico.Text = productoService.GetProductoElectronicos().Count().ToString();
            this.lblFacturado.Text = ventaService.ObtenerTotalFacturado().ToString();
            this.lblClientes.Text = clienteService.items.Count().ToString();
        }
    }
}
