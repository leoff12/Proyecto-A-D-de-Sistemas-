using Guna.UI2.WinForms;
using ProyectoFinal.Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Servicios
{
    internal class ValidarAcceso
    {
        //Función para verificar Administrador
        public static void ValidarUsuarioAdmin(string nombreUsuario, string contrasena, Guna2TextBox txtUserAdm, Guna2TextBox txtContraseñaAdm, Form currentForm)
        {
            // Verificar que ambos campos no estén vacíos
            if (string.IsNullOrEmpty(nombreUsuario))
            {
                MessageBox.Show("El usuario no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserAdm.Focus();
                return;
            }

            if (string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("La contraseña no puede estar vacia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseñaAdm.Focus();
                return;
            }

            // Validar credenciales
            if (nombreUsuario == "Santiago Mena" && contrasena == "1234")
            {
                FrmAdmin frmAdmin = new FrmAdmin();
                frmAdmin.Show();
                currentForm.Close();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas. Por favor, inténtelo nuevamente.", "Error de Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserAdm.Clear();
                txtContraseñaAdm.Clear();
                txtUserAdm.Focus();
            }
        }

        //Función para verificar Usuario

        public static void ValidarInicioSesionUsuario(
            string usuarioIngresado,
            string contraseñaIngresada,
            Guna2TextBox txtCIF,
            Guna2TextBox txtContraseña,
            Form currentForm)
        {
            const string CIF_VALIDO = "24011264";
            const string CONTRASENA_VALIDA = "1234";

            // Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(usuarioIngresado))
            {
                MessageBox.Show("El CIF no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCIF.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(contraseñaIngresada))
            {
                MessageBox.Show("La contraseña no puede estar vacia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Focus();
                return;
            }

            // Validación de longitud del CIF
            if (usuarioIngresado.Length != 8)
            {
                MessageBox.Show("El CIF debe tener exactamente 8 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCIF.Focus();
                return;
            }

            // Validación de credenciales
            if (usuarioIngresado == CIF_VALIDO && contraseñaIngresada == CONTRASENA_VALIDA)
            {
                VistaGeneralUsuario vistaGeneralUsuario = new VistaGeneralUsuario();
                vistaGeneralUsuario.Show();
                currentForm.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Por favor, inténtelo de nuevo.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCIF.Clear();
                txtContraseña.Clear();
                txtCIF.Focus();
            }
        }
    }

}

