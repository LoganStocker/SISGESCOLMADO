using System;
using System.Data;
using System.Windows.Forms;
using SISGESCOLMADO.Capa_datos;
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
            CargarVentas();
        }

        private void CargarVentas()
        {
            VentaDT ventaDT = new VentaDT();
            dgvVentas.DataSource = ventaDT.ConsultarTodas();
        }

        private void btnGenerarCorte_Click(object sender, EventArgs e)
        {
            try
            {
                VentaDT ventaDT = new VentaDT();
                DataTable tabla = ventaDT.ConsultarTodas();

                decimal totalContado = 0;
                decimal totalFiado = 0;
                int cantidadTransacciones = tabla.Rows.Count;

                foreach (DataRow fila in tabla.Rows)
                {
                    if (fila["TipoVenta"].ToString() == "Contado")
                        totalContado += Convert.ToDecimal(fila["Total"]);
                    else
                        totalFiado += Convert.ToDecimal(fila["Total"]);
                }

                //constructor completoCorteCaja
                CorteCaja corte = new CorteCaja(totalContado, totalFiado, cantidadTransacciones);

                // Mostrar el resumen 
                string resumen = corte.GenerarResumen();
                MessageBox.Show(resumen, "Corte de Caja del Día");

                // Forzar el destructor para que realice
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