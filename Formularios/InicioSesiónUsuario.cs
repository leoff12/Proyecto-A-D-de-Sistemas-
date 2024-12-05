using ProyectoFinal.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Formularios
{
    public partial class InicioSesiónUsuario : MetroFramework.Forms.MetroForm
    {
        private const string CIF_VALIDO = "admin";
        private const string CONTRASENA_VALIDA = "1234";
        public InicioSesiónUsuario()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = txtCIF.Text.Trim();
            string contraseñaIngresada = txtContraseña.Text.Trim();

            ValidarAcceso.ValidarInicioSesionUsuario(usuarioIngresado, contraseñaIngresada, txtCIF, txtContraseña, this);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void chkMostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarContraseña.Checked)
            {
                txtContraseña.PasswordChar = '\0'; // Mostrar la contraseña
            }
            else
            {
                txtContraseña.PasswordChar = '*'; // Ocultar la contraseña
            }
        }

    }
}

