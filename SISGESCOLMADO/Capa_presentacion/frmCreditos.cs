using System;
using System.Windows.Forms;
using SISGESCOLMADO.Capa_negocios;
using SISGESCOLMADO.Capa_datos;

namespace SISGESCOLMADO.Capa_presentacion
{
    public partial class frmCreditos : Form
    {
        public frmCreditos()
        {
            InitializeComponent();
        }

        private void frmCreditos_Load(object sender, EventArgs e)
        {
            CargarCreditos();
        }

        // Carga creditos DataGridView
        private void CargarCreditos()
        {
            CreditoDT creditoDT = new CreditoDT();
            creditoDT.ActualizarEstadosVencidos(); // actualiza estados antes de mostrar
            dgvCreditos.DataSource = creditoDT.ConsultarTodos();
        }

        // Boton alertas deudas vencidas
        private void btnVerAlertas_Click(object sender, EventArgs e)
        {
            GestorAlertas gestor = new GestorAlertas();
            var vencidos = gestor.ObtenerCreditosVencidos();

            if (vencidos.Count > 0)
            {
                MessageBox.Show($"Hay {vencidos.Count} crédito(s) vencido(s).", "Alerta de Deudas");
            }
            else
            {
                MessageBox.Show("No hay créditos vencidos.", "Alerta de Deudas");
            }
        }

        // Boton abono
        private void btnAbonar_Click(object sender, EventArgs e)
        {
            try
            {
                int idCredito = int.Parse(txtIdCredito.Text);
                decimal montoAbonado = decimal.Parse(txtMontoAbonado.Text);
                decimal montoPendienteActual = decimal.Parse(txtMontoPendiente.Text);

                GestorVentas gestor = new GestorVentas();
                string resultado = gestor.abonarDeuda(idCredito, montoAbonado, montoPendienteActual);

                MessageBox.Show(resultado);
                CargarCreditos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Click DataGridView para cargar datos en textbox
        private void dgvCreditos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvCreditos.Rows[e.RowIndex];
                txtIdCredito.Text = fila.Cells["IdCredito"].Value.ToString();
                txtMontoPendiente.Text = fila.Cells["MontoPendiente"].Value.ToString();
            }
        }
    }
}