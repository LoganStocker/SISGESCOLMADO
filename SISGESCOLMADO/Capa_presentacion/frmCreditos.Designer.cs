namespace SISGESCOLMADO.Capa_presentacion
{
    partial class frmCreditos
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
            dgvCreditos = new DataGridView();
            txtMontoAbonado = new TextBox();
            txtIdCredito = new TextBox();
            txtMontoPendiente = new TextBox();
            btnAbonar = new Button();
            btnVerAlertas = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCreditos).BeginInit();
            SuspendLayout();
            // 
            // dgvCreditos
            // 
            dgvCreditos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCreditos.Location = new Point(12, 250);
            dgvCreditos.Name = "dgvCreditos";
            dgvCreditos.RowHeadersWidth = 51;
            dgvCreditos.Size = new Size(745, 188);
            dgvCreditos.TabIndex = 0;
            // 
            // txtMontoAbonado
            // 
            txtMontoAbonado.Location = new Point(435, 55);
            txtMontoAbonado.Name = "txtMontoAbonado";
            txtMontoAbonado.Size = new Size(125, 27);
            txtMontoAbonado.TabIndex = 1;
            // 
            // txtIdCredito
            // 
            txtIdCredito.Location = new Point(48, 55);
            txtIdCredito.Name = "txtIdCredito";
            txtIdCredito.Size = new Size(125, 27);
            txtIdCredito.TabIndex = 2;
            txtIdCredito.ReadOnly = true;
            // 
            // txtMontoPendiente
            // 
            txtMontoPendiente.Location = new Point(234, 55);
            txtMontoPendiente.Name = "txtMontoPendiente";
            txtMontoPendiente.Size = new Size(125, 27);
            txtMontoPendiente.TabIndex = 3;
            txtMontoPendiente.ReadOnly = true;
            // 
            // btnAbonar
            // 
            btnAbonar.Location = new Point(163, 140);
            btnAbonar.Name = "btnAbonar";
            btnAbonar.Size = new Size(94, 29);
            btnAbonar.TabIndex = 4;
            btnAbonar.Text = "Abonar";
            btnAbonar.UseVisualStyleBackColor = true;
            // 
            // btnVerAlertas
            // 
            btnVerAlertas.Location = new Point(291, 140);
            btnVerAlertas.Name = "btnVerAlertas";
            btnVerAlertas.Size = new Size(94, 29);
            btnVerAlertas.TabIndex = 5;
            btnVerAlertas.Text = "Alertas ver";
            btnVerAlertas.UseVisualStyleBackColor = true;
            btnVerAlertas.Click += btnVerAlertas_Click;
            // 
            // frmCreditos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVerAlertas);
            Controls.Add(btnAbonar);
            Controls.Add(txtMontoPendiente);
            Controls.Add(txtIdCredito);
            Controls.Add(txtMontoAbonado);
            Controls.Add(dgvCreditos);
            Name = "frmCreditos";
            Text = "frmCreditos";
            ((System.ComponentModel.ISupportInitialize)dgvCreditos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCreditos;
        private TextBox txtMontoAbonado;
        private TextBox txtIdCredito;
        private TextBox txtMontoPendiente;
        private Button btnAbonar;
        private Button btnVerAlertas;
    }
}