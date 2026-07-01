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
            btnInventario.BackColor = SystemColors.AppWorkspace;
            btnInventario.Location = new Point(73, 63);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(135, 45);
            btnInventario.TabIndex = 0;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = false;
            btnInventario.Click += btnInventario_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = SystemColors.AppWorkspace;
            btnVentas.Location = new Point(253, 63);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(127, 45);
            btnVentas.TabIndex = 1;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnCreditos
            // 
            btnCreditos.BackColor = SystemColors.AppWorkspace;
            btnCreditos.Location = new Point(447, 63);
            btnCreditos.Name = "btnCreditos";
            btnCreditos.Size = new Size(132, 45);
            btnCreditos.TabIndex = 2;
            btnCreditos.Text = "Creditos";
            btnCreditos.UseVisualStyleBackColor = false;
            btnCreditos.Click += btnCreditos_Click;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = SystemColors.AppWorkspace;
            btnReportes.Location = new Point(625, 63);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(130, 45);
            btnReportes.TabIndex = 3;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
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