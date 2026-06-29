namespace SISGESCOLMADO.Capa_presentacion
{
    partial class frmVentas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtNombreCliente = new TextBox();
            txtTotal = new TextBox();
            txtCantidad = new TextBox();
            txtIdProducto = new TextBox();
            cboTipoVenta = new ComboBox();
            dtpFechaVencimiento = new DateTimePicker();
            btnRegistrar = new Button();
            dvgProductos = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dvgProductos).BeginInit();
            SuspendLayout();

            // txtNombreCliente
            txtNombreCliente.Location = new Point(472, 76);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(125, 27);
            txtNombreCliente.TabIndex = 0;
            txtNombreCliente.Visible = false;

            // txtTotal
            txtTotal.Location = new Point(319, 76);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 1;

            // txtCantidad
            txtCantidad.Location = new Point(166, 76);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 27);
            txtCantidad.TabIndex = 2;
            txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);

            // txtIdProducto
            txtIdProducto.Location = new Point(16, 76);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.ReadOnly = true;
            txtIdProducto.Size = new Size(125, 27);
            txtIdProducto.TabIndex = 3;
            txtIdProducto.TextChanged += new System.EventHandler(this.txtIdProducto_TextChanged);

            // cboTipoVenta
            cboTipoVenta.FormattingEnabled = true;
            cboTipoVenta.Items.AddRange(new object[] { "Contado", "Fiado" });
            cboTipoVenta.Location = new Point(16, 179);
            cboTipoVenta.Name = "cboTipoVenta";
            cboTipoVenta.Size = new Size(151, 28);
            cboTipoVenta.TabIndex = 4;
            cboTipoVenta.SelectedIndexChanged += new System.EventHandler(this.cboTipoVenta_SelectedIndexChanged);

            // dtpFechaVencimiento
            dtpFechaVencimiento.Location = new Point(194, 177);
            dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            dtpFechaVencimiento.Size = new Size(250, 27);
            dtpFechaVencimiento.TabIndex = 5;
            dtpFechaVencimiento.Visible = false;

            // btnRegistrar
            btnRegistrar.Location = new Point(16, 246);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);

            // dvgProductos
            dvgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgProductos.Location = new Point(16, 300);
            dvgProductos.Name = "dvgProductos";
            dvgProductos.RowHeadersWidth = 51;
            dvgProductos.Size = new Size(747, 120);
            dvgProductos.TabIndex = 7;
            dvgProductos.CellClick += new DataGridViewCellEventHandler(this.dvgProductos_CellClick);

            // label1
            label1.AutoSize = true;
            label1.Location = new Point(16, 41);
            label1.Name = "label1";
            label1.TabIndex = 8;
            label1.Text = "IDPRODUCTO";

            // label2
            label2.AutoSize = true;
            label2.Location = new Point(166, 41);
            label2.Name = "label2";
            label2.TabIndex = 9;
            label2.Text = "CANTIDAD";

            // label3
            label3.AutoSize = true;
            label3.Location = new Point(319, 41);
            label3.Name = "label3";
            label3.TabIndex = 10;
            label3.Text = "TOTAL";

            // label4
            label4.AutoSize = true;
            label4.Location = new Point(472, 41);
            label4.Name = "label4";
            label4.TabIndex = 11;
            label4.Text = "NOMBRECLIENTE";

            // label5
            label5.AutoSize = true;
            label5.Location = new Point(16, 141);
            label5.Name = "label5";
            label5.TabIndex = 12;
            label5.Text = "TIPOVENTA";

            // label6
            label6.AutoSize = true;
            label6.Location = new Point(194, 141);
            label6.Name = "label6";
            label6.TabIndex = 13;
            label6.Text = "FECHADEVENCIMIENTO";

            // frmVentas
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dvgProductos);
            Controls.Add(btnRegistrar);
            Controls.Add(dtpFechaVencimiento);
            Controls.Add(cboTipoVenta);
            Controls.Add(txtIdProducto);
            Controls.Add(txtCantidad);
            Controls.Add(txtTotal);
            Controls.Add(txtNombreCliente);
            Name = "frmVentas";
            Text = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)dvgProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtNombreCliente;
        private TextBox txtTotal;
        private TextBox txtCantidad;
        private TextBox txtIdProducto;
        private ComboBox cboTipoVenta;
        private DateTimePicker dtpFechaVencimiento;
        private Button btnRegistrar;
        private DataGridView dvgProductos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}