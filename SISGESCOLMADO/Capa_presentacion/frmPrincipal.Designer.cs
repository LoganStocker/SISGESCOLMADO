namespace SISGESCOLMADO.Capa_presentacion
{
    partial class frmPrincipal
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
            btnInventario = new Button();
            btnVentas = new Button();
            btnCreditos = new Button();
            btnReportes = new Button();
            SuspendLayout();
            // 
            // btnInventario
            // 
            btnInventario.Location = new Point(73, 79);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(94, 29);
            btnInventario.TabIndex = 0;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = true;
            // 
            // btnVentas
            // 
            btnVentas.Location = new Point(192, 79);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(94, 29);
            btnVentas.TabIndex = 1;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            // 
            // btnCreditos
            // 
            btnCreditos.Location = new Point(317, 79);
            btnCreditos.Name = "btnCreditos";
            btnCreditos.Size = new Size(94, 29);
            btnCreditos.TabIndex = 2;
            btnCreditos.Text = "Creditos";
            btnCreditos.UseVisualStyleBackColor = true;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(431, 79);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(94, 29);
            btnReportes.TabIndex = 3;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReportes);
            Controls.Add(btnCreditos);
            Controls.Add(btnVentas);
            Controls.Add(btnInventario);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnInventario;
        private Button btnVentas;
        private Button btnCreditos;
        private Button btnReportes;
    }
}