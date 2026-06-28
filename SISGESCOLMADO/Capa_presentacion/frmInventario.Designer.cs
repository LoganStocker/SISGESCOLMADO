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
            txtIdProducto.Size = new Size(125, 27);
            txtIdProducto.TabIndex = 3;
            txtIdProducto.ReadOnly = true;
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
            // frmInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}