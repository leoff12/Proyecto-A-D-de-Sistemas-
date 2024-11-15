using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Windows.Forms;
using ProyectoFinal.Formularios;

namespace ProyectoFinal.Formularios
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            // Obtener los valores ingresados por el usuario
            string nombreUsuario = txtUserAdm.Text.Trim();
            string contrasena = txtContraseñaAdm.Text.Trim();

            // Verificar que ambos campos no estén vacíos
            if (string.IsNullOrEmpty(nombreUsuario))
            {
                MessageBox.Show("Por favor, ingrese el Nombre de Usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserAdm.Focus();
                return;
            }

            if (string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor, ingrese la Contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseñaAdm.Focus();
                return;
            }

            // Validar credenciales
            if (nombreUsuario == "Santiago Mena" && contrasena == "1234")
            {
                MessageBox.Show("Bienvenido, Santiago Mena", "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abrir el formulario principal
                FrmAdmin frmAdmin = new FrmAdmin();
                frmAdmin.Show();
                this.Hide(); // Ocultar este formulario
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas. Por favor, inténtelo nuevamente.", "Error de Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserAdm.Clear();
                txtContraseñaAdm.Clear();
                txtUserAdm.Focus();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            // Código para cerrar la aplicación o regresar a otro formulario
            Application.Exit();
        }
    }
}

