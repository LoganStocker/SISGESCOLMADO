using System;
using System.Windows.Forms;
using SISGESCOLMADO.Capa_datos;

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

        // Cargar todos los productos en el DataGridView
        private void CargarProductos()
        {
            ProductoDT productoDT = new ProductoDT();
            dvgProductos.DataSource = productoDT.ConsultarTodos();
        }

        // Botón Agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                decimal precio = decimal.Parse(txtPrecio.Text);
                int stock = int.Parse(txtStock.Text);
                string categoria = txtCategoria.Text;

                ProductoDT productoDT = new ProductoDT();
                productoDT.Insertar(nombre, precio, stock, categoria);

                MessageBox.Show("Producto agregado correctamente.");
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Botón Actualizar
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int idProducto = int.Parse(txtIdProducto.Text);
                string nombre = txtNombre.Text;
                decimal precio = decimal.Parse(txtPrecio.Text);
                int stock = int.Parse(txtStock.Text);
                string categoria = txtCategoria.Text;

                ProductoDT productoDT = new ProductoDT();
                productoDT.Actualizar(idProducto, nombre, precio, stock, categoria);

                MessageBox.Show("Producto actualizado correctamente.");
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Botón Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int idProducto = int.Parse(txtIdProducto.Text);

                ProductoDT productoDT = new ProductoDT();
                productoDT.Eliminar(idProducto);

                MessageBox.Show("Producto eliminado correctamente.");
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Click en una fila del DataGridView, para cargar los datos en los TextBox
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