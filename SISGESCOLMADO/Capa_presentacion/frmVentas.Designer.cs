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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
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
            txtTotal.ReadOnly = true;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(166, 76);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 27);
            txtCantidad.TabIndex = 2;
            txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(16, 76);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(125, 27);
            txtIdProducto.TabIndex = 3;
            txtIdProducto.TextChanged += new System.EventHandler(this.txtIdProducto_TextChanged);
            // 
            // cboTipoVenta
            // 
            cboTipoVenta.FormattingEnabled = true;
            cboTipoVenta.Location = new Point(16, 179);
            cboTipoVenta.Name = "cboTipoVenta";
            cboTipoVenta.Size = new Size(151, 28);
            cboTipoVenta.TabIndex = 4;
            // 
            // dtpFechaVencimiento
            // 
            dtpFechaVencimiento.Location = new Point(194, 177);
            dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            dtpFechaVencimiento.Size = new Size(250, 27);
            dtpFechaVencimiento.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(16, 246);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Agregar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 41);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 7;
            label1.Text = "IDPRODUCTO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 41);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 8;
            label2.Text = "CANTIDAD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(319, 41);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 9;
            label3.Text = "TOTAL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(472, 41);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 10;
            label4.Text = "NOMBRECLIENTE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 141);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 11;
            label5.Text = "TIPOVENTA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(194, 141);
            label6.Name = "label6";
            label6.Size = new Size(168, 20);
            label6.TabIndex = 12;
            label6.Text = "FECHADEVENCIMIENTO";
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}