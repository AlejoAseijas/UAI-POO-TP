using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1.Exceptions;
using TP1.helpers;
using TP1.models;
using TP1.services;

namespace TP1.views
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }
        private VentaService ventaService = VentaService.ObtenerInstancia();

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refreshDataSource()
        {
            this.dataGridViewProductos.DataSource = null;
            this.dataGridViewProductos.DataSource = ProductoService.ObtenerInstancia().items;
            this.dataGridViewProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            this.dataGridViewClientes.DataSource = null;    
            this.dataGridViewClientes.DataSource = ClienteService.ObtenerInstancia().items;
            this.dataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            refreshDataSource();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)this.dataGridViewClientes.CurrentRow.DataBoundItem;
            Inventario inventario = (Inventario)this.dataGridViewProductos.CurrentRow.DataBoundItem;
            int qty = Convert.ToInt32(this.txtQty.Text);

            if(cliente != null && inventario != null) 
            {
                ventaService.Alta(new Dictionary<Cliente, Inventario>{{ cliente, inventario } }, qty);
            }

            refreshDataSource();
            FormHelper.clearTextBoxAndRadioButtons(this);
        }

    }
}
