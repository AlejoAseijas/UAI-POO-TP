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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        ClienteService clienteService = ClienteService.ObtenerInstancia();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cliente cliente = getClienteFromUI();

            try
            {
                clienteService.Alta(cliente);
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            FormHelper.clearTextBoxAndRadioButtons(this);
            refreshDataSource();

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            refreshDataSource();
        }

        private void refreshDataSource()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = ClienteService.CLIENTES;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Cliente cliente = (Cliente)this.dataGridView1.CurrentRow.DataBoundItem;

            if( cliente != null ) 
            {
                this.txtNombreCliente.Text = cliente.Nombre;
                this.txtApellidoCliente.Text = cliente.Apellido;
                this.txtDniCliente.Text = cliente.DNI;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Cliente clienteAModificar = (Cliente)this.dataGridView1.CurrentRow.DataBoundItem;

            if (clienteAModificar != null)
            {
                Cliente clienteNuevosDatos = getClienteFromUI();
                clienteService.Modificar(clienteAModificar, clienteNuevosDatos);
                FormHelper.clearTextBoxAndRadioButtons(this);
            }
        }

        private Cliente getClienteFromUI()
        {
            Cliente cliente = new Cliente();

            cliente.Nombre = this.txtNombreCliente.Text;
            cliente.Apellido = this.txtApellidoCliente.Text;
            cliente.DNI = this.txtDniCliente.Text;

            return cliente;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente cliente = getClienteFromUI();
            clienteService.Baja(cliente);
            FormHelper.clearTextBoxAndRadioButtons(this);
            refreshDataSource();
        }
    }
}
