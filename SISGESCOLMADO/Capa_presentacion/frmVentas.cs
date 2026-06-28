using System;
using System.Windows.Forms;
using SISGESCOLMADO.Capa_negocios;

namespace SISGESCOLMADO.Capa_presentacion
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                int idProducto = int.Parse(txtIdProducto.Text);
                int cantidad = int.Parse(txtCantidad.Text);
                decimal total = decimal.Parse(txtTotal.Text);
                string tipoVenta = cboTipoVenta.SelectedItem.ToString();

                Transaccion transaccion;
                int? idClienteParaVenta = null;

                if (tipoVenta == "Contado")
                {
                    // Clase hija concreta: VentaContado
                    transaccion = new VentaContado(idProducto, cantidad, total);
                }
                else // Fiado
                {
                    // Constructor parametrizado completo de Cliente
                    Cliente cliente = new Cliente(txtNombreCliente.Text, true);
                    string resultadoCliente = cliente.GuardarCliente();

                    DateTime fechaVencimiento = dtpFechaVencimiento.Value;

                    // Clase hija concreta: VentaFiado
                    transaccion = new VentaFiado(idProducto, cantidad, total, cliente.IdCliente, fechaVencimiento);
                    idClienteParaVenta = cliente.IdCliente;
                }

                // Polimorfismo: referencia de tipo base (Transaccion) invoca el método sobreescrito
                string mensajePago = transaccion.ProcesarPago();
                string mensajeFinal = transaccion.FinalizarTransaccion();

                // Método normal de GestorVentas: registra la venta en la base de datos
                GestorVentas gestor = new GestorVentas();
                string resultadoVenta = gestor.registrarVenta(idClienteParaVenta, idProducto, cantidad, total, tipoVenta);

                MessageBox.Show(mensajePago + "\n" + mensajeFinal + "\n" + resultadoVenta, "Resultado de la Venta");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cboTipoVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool esFiado = cboTipoVenta.SelectedItem != null && cboTipoVenta.SelectedItem.ToString() == "Fiado";
            txtNombreCliente.Visible = esFiado;
            dtpFechaVencimiento.Visible = esFiado;
        }
    }
}
