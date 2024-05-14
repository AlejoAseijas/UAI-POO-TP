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
using TP1.models;
using TP1.services;

namespace TP1.views
{
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }

        private ProductoService productoService = new ProductoService();

        private void button1_Click(object sender, EventArgs e)
        {
            models.Producto producto = getProductoFromUI();
            if (producto != null)
            {
                productoService.Alta(producto, this.listBox1);
            }
            FormHelper.clearTextBoxAndRadioButtons(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.groupBox3.Enabled = false;
            Mock.setMockProductos(this.listBox1);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.groupBox3.Enabled = true;
            this.comboBox1.Enabled = true;
            this.dateTimePicker1.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.groupBox3.Enabled = true;
            this.comboBox1.Enabled = false;
            this.dateTimePicker1.Enabled = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            models.Producto producto = FormHelper.getProductoFromListBox(this.listBox1);

         if (producto != null)
            {
                this.txtCategoria.Text = producto.Categoria;
                this.txtSubCategoria.Text = producto.SubCategoria;
                this.txtProducto.Text = producto.Nombre;

                this.txtStock.Text = producto.Inventario.Stock.ToString();
                this.txtPrecioVenta.Text = producto.Inventario.PrecioVenta.ToString();
                this.txtPrecioCosto.Text = producto.Inventario.PrecioCosto.ToString();

                this.txtProvedor.Text = producto.Provedor.Nombre;

                if (producto is models.ProductoElectronico) {
                    models.ProductoElectronico electronico = (models.ProductoElectronico) producto;
                    this.radioButton1.Checked = true;
                    this.comboBox1.SelectedItem = electronico.Consumo;
                } else
                {
                    models.ProductoAlimenticio alimenticio = (models.ProductoAlimenticio)producto;
                    this.radioButton2.Checked = true;
                    this.dateTimePicker1.Value = alimenticio.FechaDeVencimiento;
                }
            }
        }

        private models.Producto getProductoFromUI()
        {
            models.Producto producto = null;

            #region Datos Producto
            string categoria = this.txtCategoria.Text;
            string subCategoria = this.txtSubCategoria.Text;
            string nombreProducto = this.txtProducto.Text;
            #endregion

            Inventario inventario = null;
            #region Datos Inventario
            try
            {
                int stock = Int32.Parse(this.txtStock.Text);
                long precioVenta = long.Parse(this.txtPrecioVenta.Text);
                long precioCosto = long.Parse(this.txtPrecioCosto.Text);

                inventario = new Inventario(stock, precioCosto, precioVenta);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear inventario: {ex.Message}, No se puede crear el producto");
                return null;
            }

            #endregion

            #region Provedor
            string nombreProvedor = this.txtProvedor.Text;
            Proveedor provedor = new Proveedor(nombreProvedor);

            #endregion

            #region Valido que radioButton esta checked para generar sus correspondiete Producto
            if (this.radioButton1.Checked)
            {
                string consumo = this.comboBox1.SelectedItem.ToString();
                producto = new models.ProductoElectronico(categoria, subCategoria, nombreProducto, consumo, inventario);
            }

            if (this.radioButton2.Checked)
            {
                DateTime fecha = dateTimePicker1.Value;
                producto = new models.ProductoAlimenticio(categoria, subCategoria, nombreProducto, fecha, inventario);
            }
            #endregion

            producto.Provedor = provedor;

            return producto;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            models.Producto productoFromListBox = FormHelper.getProductoFromListBox(this.listBox1);
            models.Producto productoUI = getProductoFromUI();
            if (productoUI != null)
            {
                productoService.Modificar(productoFromListBox, productoUI, this.listBox1);

            }
            FormHelper.clearTextBoxAndRadioButtons(this);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            models.Producto productoFromListBox = FormHelper.getProductoFromListBox(this.listBox1);
            productoService.Baja(productoFromListBox, this.listBox1);
            FormHelper.clearTextBoxAndRadioButtons(this);
        }
    }
}
