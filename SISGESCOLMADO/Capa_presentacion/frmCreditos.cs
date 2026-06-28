using System;
using System.Windows.Forms;
using SISGESCOLMADO.Capa_negocios;

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
            // Carga los creditos al abrir formulario
            CargarCreditos();
        }

        // Consulta y muestra todos los creditos en DataGridView
        private void CargarCreditos()
        {
            GestorVentas gestor = new GestorVentas();
            gestor.ActualizarEstadosVencidos();
            dgvCreditos.DataSource = gestor.ConsultarCreditos();
        }

        // Muestra alerta de creditos vencidos 
        private void btnVerAlertas_Click(object sender, EventArgs e)
        {
            GestorAlertas gestor = new GestorAlertas();
            var vencidos = gestor.ObtenerCreditosVencidos();

            if (vencidos.Count > 0)
                MessageBox.Show($"Hay {vencidos.Count} crédito(s) vencido(s).", "Alerta de Deudas");
            else
                MessageBox.Show("No hay créditos vencidos.", "Alerta de Deudas");
        }

        // Registra un abono a un credito 
        private void btnAbonar_Click(object sender, EventArgs e)
        {
            try
            {
                int idCredito = int.Parse(txtIdCredito.Text);
                decimal montoAbonado = decimal.Parse(txtMontoAbonado.Text);
                decimal montoPendienteActual = decimal.Parse(txtMontoPendiente.Text);

                // Método normal de GestorVentas
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

        // Al hacer click carga los datos en los TextBox
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