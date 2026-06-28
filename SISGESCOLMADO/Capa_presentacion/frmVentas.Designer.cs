namespace SISGESCOLMADO.Capa_presentacion
{
    partial class frmVentas
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
            txtNombreCliente = new TextBox();
            txtTotal = new TextBox();
            txtCantidad = new TextBox();
            txtIdProducto = new TextBox();
            cboTipoVenta = new ComboBox();
            dtpFechaVencimiento = new DateTimePicker();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(472, 76);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(125, 27);
            txtNombreCliente.TabIndex = 0;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(319, 76);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 1;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(166, 76);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 27);
            txtCantidad.TabIndex = 2;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(16, 76);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(125, 27);
            txtIdProducto.TabIndex = 3;
            // 
            // cboTipoVenta
            // 
            cboTipoVenta.FormattingEnabled = true;
            cboTipoVenta.Location = new Point(16, 133);
            cboTipoVenta.Name = "cboTipoVenta";
            cboTipoVenta.Size = new Size(151, 28);
            cboTipoVenta.TabIndex = 4;
            // 
            // dtpFechaVencimiento
            // 
            dtpFechaVencimiento.Location = new Point(194, 134);
            dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            dtpFechaVencimiento.Size = new Size(250, 27);
            dtpFechaVencimiento.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(26, 191);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Agregar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegistrar);
            Controls.Add(dtpFechaVencimiento);
            Controls.Add(cboTipoVenta);
            Controls.Add(txtIdProducto);
            Controls.Add(txtCantidad);
            Controls.Add(txtTotal);
            Controls.Add(txtNombreCliente);
            Name = "frmVentas";
            Text = "frmVentas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreCliente;
        private TextBox txtTotal;
        private TextBox txtCantidad;
        private TextBox txtIdProducto;
        private ComboBox cboTipoVenta;
        private DateTimePicker dtpFechaVencimiento;
        private Button btnRegistrar;
    }
}