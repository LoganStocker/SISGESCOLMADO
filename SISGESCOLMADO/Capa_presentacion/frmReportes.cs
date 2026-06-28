using System;
using System.Windows.Forms;
using SISGESCOLMADO.Capa_negocios;

namespace SISGESCOLMADO.Capa_presentacion
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            // Carga ventas abrir el formulario
            CargarVentas();
        }

        // Consulta y muestra ventas DataGridView
        private void CargarVentas()
        {
            GestorVentas gestor = new GestorVentas();
            dgvVentas.DataSource = gestor.ConsultarVentas();
        }

        private void btnGenerarCorte_Click(object sender, EventArgs e)
        {
            try
            {
                // Genera el corte de caja 
                CorteCaja corte = CorteCaja.GenerarDesdeVentas();

                // Muestra el resumen 
                MessageBox.Show(corte.GenerarResumen(), "Corte de Caja del Día");

                // Fuerza el destructor ~CorteCaja
                corte = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}