using System;
using System;
using System.Windows.Forms;

namespace SISGESCOLMADO.Capa_presentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            if (usuario == "lg" && contrasena == "0602")
            {
                frmPrincipal principal = new frmPrincipal();
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de acceso");
            }
        }
    }
}
