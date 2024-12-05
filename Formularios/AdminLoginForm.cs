using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.Formularios;
using ProyectoFinal.Servicios;

namespace ProyectoFinal.Formularios
{
    public partial class AdminLoginForm : MetroFramework.Forms.MetroForm
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

            // Llamar a la función ValidarUsuarioAdmin desde ValidarAcceso
            ValidarAcceso.ValidarUsuarioAdmin(nombreUsuario, contrasena, txtUserAdm, txtContraseñaAdm, this);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void chkMostrarContraseñaAdm_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarContraseñaAdm.Checked)
            {
                txtContraseñaAdm.PasswordChar = '\0'; // Mostrar la contraseña
            }
            else
            {
                txtContraseñaAdm.PasswordChar = '*'; // Ocultar la contraseña
            }
        }
        private void AdminLoginForm_Load(object sender, EventArgs e)
        {
            

        }
    }
}

