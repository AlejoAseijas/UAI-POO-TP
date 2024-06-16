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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refreshDataSource()
        {
            this.dataGridView2.DataSource = null;
            this.dataGridView2.DataSource = ProductoService.PRODUCTOS;
            this.dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            this.dataGridViewClientes.DataSource = null;
            this.dataGridViewClientes.DataSource = ClienteService.CLIENTES;
            this.dataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            refreshDataSource();
        }

    }
}
