using System;
using System.Windows.Forms;
using SISGESCOLMADO.Capa_negocios;

namespace SISGESCOLMADO.Capa_presentacion
{
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        // Cargar productos en DataGridView
        private void CargarProductos()
        {
            GestorInventario gestor = new GestorInventario();
            dvgProductos.DataSource = gestor.ConsultarProductos();
        }

        // Boton Agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                decimal precio = decimal.Parse(txtPrecio.Text);
                int stock = int.Parse(txtStock.Text);
                string categoria = txtCategoria.Text;

                GestorInventario gestor = new GestorInventario();
                string resultado = gestor.InsertarProducto(nombre, precio, stock, categoria);

                MessageBox.Show(resultado);
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Boton Actualizar
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int idProducto = int.Parse(txtIdProducto.Text);
                string nombre = txtNombre.Text;
                decimal precio = decimal.Parse(txtPrecio.Text);
                int stock = int.Parse(txtStock.Text);
                string categoria = txtCategoria.Text;

                GestorInventario gestor = new GestorInventario();
                string resultado = gestor.ActualizarProducto(idProducto, nombre, precio, stock, categoria);

                MessageBox.Show(resultado);
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Boton Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int idProducto = int.Parse(txtIdProducto.Text);

                GestorInventario gestor = new GestorInventario();
                string resultado = gestor.EliminarProducto(idProducto);

                MessageBox.Show(resultado);
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // DataGridView para cargar los datos en los TextBox
        private void dvgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dvgProductos.Rows[e.RowIndex];
                txtIdProducto.Text = fila.Cells["IdProducto"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtPrecio.Text = fila.Cells["Precio"].Value.ToString();
                txtStock.Text = fila.Cells["Stock"].Value.ToString();
                txtCategoria.Text = fila.Cells["Categoria"].Value.ToString();
            }
        }
    }
}