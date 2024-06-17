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

        private ProductoService productoService = ProductoService.ObtenerInstancia();

        private void button1_Click(object sender, EventArgs e)
        {
            models.Inventario producto = getProductoFromUI();
            if (producto != null)
            {
                productoService.Alta(producto);
                MessageBox.Show($"El id del producto es {producto.Producto.GenerarCodigo()}");
            }
            FormHelper.clearTextBoxAndRadioButtons(this);
            refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.groupBox3.Enabled = false;
            this.comboBox2.DataSource = null;
            this.comboBox2.DataSource = Enum.GetValues(typeof(TipoDeProducto));
            refresh();
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
            models.Inventario inventario = FormHelper.getProductoFromListBox(this.listBox1);

            if (inventario != null)
            {
                this.txtCategoria.Text = inventario.Producto.Categoria;
                this.txtSubCategoria.Text = inventario.Producto.SubCategoria;
                this.txtProducto.Text = inventario.Producto.Nombre;

                this.txtStock.Text = inventario.Stock.ToString();
                this.txtPrecioVenta.Text = inventario.PrecioVenta.ToString();
                this.txtPrecioCosto.Text = inventario.PrecioCosto.ToString();

                this.txtProvedor.Text = inventario.Producto.Provedor.Nombre;

                if (inventario.Producto is models.ProductoElectronico) {
                    models.ProductoElectronico electronico = (models.ProductoElectronico)inventario.Producto;
                    this.comboBox2.SelectedItem = TipoDeProducto.ELECTRONICO;
                    this.comboBox1.SelectedItem = electronico.Consumo;
                } else
                {
                    models.ProductoAlimenticio alimenticio = (models.ProductoAlimenticio)inventario.Producto;
                    this.comboBox2.SelectedItem = TipoDeProducto.ALIMENTICIO;
                    this.dateTimePicker1.Value = alimenticio.FechaDeVencimiento;
                }
            }
        }

        private models.Inventario getProductoFromUI()
        {
            models.Producto producto = null;

            #region Datos Producto
            string categoria = this.txtCategoria.Text;
            string subCategoria = this.txtSubCategoria.Text;
            string nombreProducto = this.txtProducto.Text;
            #endregion

            Inventario inventario = null;
            #region Datos Inventario

            #endregion

            #region Provedor
            string nombreProvedor = this.txtProvedor.Text;
            Proveedor provedor = new Proveedor(nombreProvedor);

            #endregion

            #region Valido que radioButton esta checked para generar sus correspondiete Producto
            TipoDeProducto tipoDeProducto = (TipoDeProducto)this.comboBox2.SelectedItem;

            if (TipoDeProducto.ELECTRONICO.Equals(tipoDeProducto))
            {
                string consumo = this.comboBox1.SelectedItem.ToString();
                producto = new models.ProductoElectronico(categoria, subCategoria, nombreProducto, consumo);
            }

            if (TipoDeProducto.ALIMENTICIO.Equals(tipoDeProducto))
            {
                DateTime fecha = dateTimePicker1.Value;
                producto = new models.ProductoAlimenticio(categoria, subCategoria, nombreProducto, fecha);
            }
            #endregion

            producto.Provedor = provedor;

            try
            {
                int stock = Int32.Parse(this.txtStock.Text);
                long precioVenta = long.Parse(this.txtPrecioVenta.Text);
                long precioCosto = long.Parse(this.txtPrecioCosto.Text);

                inventario = new Inventario(stock, precioCosto, precioVenta, producto);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear inventario: {ex.Message}, No se puede crear el producto");
                return null;
            }


            return inventario;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            models.Inventario productoFromListBox = FormHelper.getProductoFromListBox(this.listBox1);
            models.Inventario productoUI = getProductoFromUI();

            if (productoUI != null)
            {
                productoService.Modificar(productoFromListBox, productoUI);

            }

            FormHelper.clearTextBoxAndRadioButtons(this);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            models.Inventario productoFromListBox = FormHelper.getProductoFromListBox(this.listBox1);
            productoService.Baja(productoFromListBox);
            FormHelper.clearTextBoxAndRadioButtons(this);
        }

        public void refresh() 
        {
            this.listBox1.DataSource = null;
            this.listBox1.DataSource = ProductoService.PRODUCTOS;
        }
    }
}
