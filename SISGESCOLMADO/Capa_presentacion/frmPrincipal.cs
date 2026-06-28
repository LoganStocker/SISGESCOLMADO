using System;
using System.Windows.Forms;

namespace SISGESCOLMADO.Capa_presentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            frmInventario inventario = new frmInventario();
            inventario.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmVentas ventas = new frmVentas();
            ventas.Show();
        }

        private void btnCreditos_Click(object sender, EventArgs e)
        {
            frmCreditos creditos = new frmCreditos();
            creditos.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            frmReportes reportes = new frmReportes();
            reportes.Show();
        }
    }
}
