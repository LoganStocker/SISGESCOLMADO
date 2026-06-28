namespace SISGESCOLMADO.Capa_presentacion
{
    partial class frmInventario
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
            txtCategoria = new TextBox();
            txtStock = new TextBox();
            txtNombre = new TextBox();
            txtIdProducto = new TextBox();
            txtPrecio = new TextBox();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            dvgProductos = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dvgProductos).BeginInit();
            SuspendLayout();
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(598, 93);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(125, 27);
            txtCategoria.TabIndex = 0;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(456, 93);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(125, 27);
            txtStock.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(166, 93);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(16, 93);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.ReadOnly = true;
            txtIdProducto.Size = new Size(125, 27);
            txtIdProducto.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(316, 93);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 4;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(16, 178);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(130, 178);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(248, 178);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dvgProductos
            // 
            dvgProductos.AccessibleName = "";
            dvgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgProductos.Location = new Point(16, 239);
            dvgProductos.Name = "dvgProductos";
            dvgProductos.RowHeadersWidth = 51;
            dvgProductos.Size = new Size(747, 188);
            dvgProductos.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 61);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 9;
            label1.Text = "IDPRODUCTO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 61);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 10;
            label2.Text = "NOMBRE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(316, 61);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 11;
            label3.Text = "PRECIO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(456, 61);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 12;
            label4.Text = "STOCK";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(598, 61);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 13;
            label5.Text = "CATEGORIA";
            // 
            // frmInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dvgProductos);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(txtPrecio);
            Controls.Add(txtIdProducto);
            Controls.Add(txtNombre);
            Controls.Add(txtStock);
            Controls.Add(txtCategoria);
            Name = "frmInventario";
            Text = "frmInventario";
            ((System.ComponentModel.ISupportInitialize)dvgProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCategoria;
        private TextBox txtStock;
        private TextBox txtNombre;
        private TextBox txtIdProducto;
        private TextBox txtPrecio;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private DataGridView dvgProductos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}