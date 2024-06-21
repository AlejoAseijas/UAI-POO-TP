namespace TP1.views
{
    partial class Informes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblProductos = new System.Windows.Forms.Label();
            this.lblProductosAlimenticios = new System.Windows.Forms.Label();
            this.lblProductosElectronico = new System.Windows.Forms.Label();
            this.lblFacturado = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total de productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total de productos Alimenticios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total de productos Electronicos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total facturado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total clientes";
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Location = new System.Drawing.Point(114, 9);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(0, 13);
            this.lblProductos.TabIndex = 5;
            // 
            // lblProductosAlimenticios
            // 
            this.lblProductosAlimenticios.AutoSize = true;
            this.lblProductosAlimenticios.Location = new System.Drawing.Point(172, 32);
            this.lblProductosAlimenticios.Name = "lblProductosAlimenticios";
            this.lblProductosAlimenticios.Size = new System.Drawing.Size(0, 13);
            this.lblProductosAlimenticios.TabIndex = 6;
            // 
            // lblProductosElectronico
            // 
            this.lblProductosElectronico.AutoSize = true;
            this.lblProductosElectronico.Location = new System.Drawing.Point(175, 56);
            this.lblProductosElectronico.Name = "lblProductosElectronico";
            this.lblProductosElectronico.Size = new System.Drawing.Size(0, 13);
            this.lblProductosElectronico.TabIndex = 7;
            // 
            // lblFacturado
            // 
            this.lblFacturado.AutoSize = true;
            this.lblFacturado.Location = new System.Drawing.Point(97, 82);
            this.lblFacturado.Name = "lblFacturado";
            this.lblFacturado.Size = new System.Drawing.Size(0, 13);
            this.lblFacturado.TabIndex = 8;
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Location = new System.Drawing.Point(88, 106);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(0, 13);
            this.lblClientes.TabIndex = 9;
            // 
            // Informes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 515);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.lblFacturado);
            this.Controls.Add(this.lblProductosElectronico);
            this.Controls.Add(this.lblProductosAlimenticios);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Informes";
            this.Text = "Informes";
            this.Load += new System.EventHandler(this.Informes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Label lblProductosAlimenticios;
        private System.Windows.Forms.Label lblProductosElectronico;
        private System.Windows.Forms.Label lblFacturado;
        private System.Windows.Forms.Label lblClientes;
    }
}