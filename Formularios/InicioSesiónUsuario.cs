﻿using System;
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
        private const string USUARIO_VALIDO = "admin";
        private const string CONTRASENA_VALIDA = "1234";
        public InicioSesiónUsuario()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = txtCIF.Text;
            string contraseñaIngresada = txtContraseña.Text;

            if (usuarioIngresado == USUARIO_VALIDO && contraseñaIngresada == CONTRASENA_VALIDA)
            {
                VistaGeneralUsuario vistaGeneralUsuario= new VistaGeneralUsuario();
                this.Hide(); // Oculta el formulario actual

                vistaGeneralUsuario.ShowDialog();

                this.Show();
            }
            else
            {
                // Credenciales incorrectas: muestra un mensaje de error
                MessageBox.Show("Usuario o contraseña incorrectos. Por favor, inténtelo de nuevo.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

