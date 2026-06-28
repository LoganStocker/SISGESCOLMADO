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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
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
            txtIdCredito.ReadOnly = true;
            txtIdCredito.Size = new Size(125, 27);
            txtIdCredito.TabIndex = 2;
            // 
            // txtMontoPendiente
            // 
            txtMontoPendiente.Location = new Point(234, 55);
            txtMontoPendiente.Name = "txtMontoPendiente";
            txtMontoPendiente.ReadOnly = true;
            txtMontoPendiente.Size = new Size(125, 27);
            txtMontoPendiente.TabIndex = 3;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 20);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 6;
            label1.Text = "IDCREDITO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(234, 20);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 7;
            label2.Text = "MONTOPENDIENTE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(435, 20);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 8;
            label3.Text = "MONTOABONADO";
            // 
            // frmCreditos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Label label3;
    }
}