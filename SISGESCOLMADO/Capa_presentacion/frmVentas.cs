using System;
using System.Windows.Forms;
using SISGESCOLMADO.Capa_negocios;
using System.Data;

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
                    // Clase hija VentaContado
                    transaccion = new VentaContado(idProducto, cantidad, total);
                }
                else // Fiado
                {
                    // Constructor completo 
                    Cliente cliente = new Cliente(txtNombreCliente.Text, true);
                    string resultadoCliente = cliente.GuardarCliente();
                    if (cliente.IdCliente == 0)
                    {
                        MessageBox.Show("No se pudo guardar el cliente: " + resultadoCliente);
                        return;
                    }

                    DateTime fechaVencimiento = dtpFechaVencimiento.Value;

                    // Clase hija VentaFiado
                    transaccion = new VentaFiado(idProducto, cantidad, total, cliente.IdCliente, fechaVencimiento);
                    idClienteParaVenta = cliente.IdCliente;
                }

                // Polimorfismo referencia de tipo base Transaccion invoca metodo sobreescrito
                string mensajePago = transaccion.ProcesarPago();
                string mensajeFinal = transaccion.FinalizarTransaccion();

                // Metodo normal de GestorVentas
                GestorVentas gestor = new GestorVentas();
                string resultadoVenta = gestor.registrarVenta(idClienteParaVenta, idProducto, cantidad, total, tipoVenta);

                MessageBox.Show(mensajePago + "\n" + mensajeFinal + "\n" + resultadoVenta, "Resultado de la Venta");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        // Recalcula el total cuando cambia la cantidad
        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        // Recalcula el total cuando cambia el producto
        private void txtIdProducto_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        // Muestra u oculta campos según el tipo de venta seleccionado
        private void cboTipoVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool esFiado = cboTipoVenta.SelectedItem != null && cboTipoVenta.SelectedItem.ToString() == "Fiado";
            txtNombreCliente.Visible = esFiado;
            dtpFechaVencimiento.Visible = esFiado;
        }

        // Calcula el total multiplicando precio del producto por cantidad
        private void CalcularTotal()
        {
            try
            {
                if (txtIdProducto.Text != "" && txtCantidad.Text != "")
                {
                    int idProducto = int.Parse(txtIdProducto.Text);
                    int cantidad = int.Parse(txtCantidad.Text);

                    // Obtiene el precio desde Capa Negocios
                    GestorInventario gestor = new GestorInventario();
                    decimal precio = gestor.ObtenerPrecioProducto(idProducto);
                    txtTotal.Text = (precio * cantidad).ToString();
                }
            }
            catch { }
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            // Carga productos en el DataGridView 
            GestorInventario gestor = new GestorInventario();
            dvgProductos.DataSource = gestor.ConsultarProductos();
        }

        private void dvgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Al hacer click llena el ID automaticamente
                DataGridViewRow fila = dvgProductos.Rows[e.RowIndex];
                txtIdProducto.Text = fila.Cells["IdProducto"].Value.ToString();
            }
        }
    }
}