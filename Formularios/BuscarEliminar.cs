﻿using ProyectoFinal.Clases;
using ProyectoFinal.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoFinal.Formularios
{
    public partial class BuscarEliminar : MetroFramework.Forms.MetroForm
    {
        private List<Eventos> eventos;

        public BuscarEliminar()
        {
            InitializeComponent();
            this.Load += BuscarEliminar_Load;
        }

        private void BuscarEliminar_Load(object sender, EventArgs e)
        {
            eventos = Funciones.CargarEventos();
            CargarComboBox();
        }

        private void CargarComboBox()
        {
            cmbEventos.Items.Clear();
            foreach (var evento in eventos)
            {
                cmbEventos.Items.Add(evento.NombreEvento);
            }
        }

        private void cmbEventos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEventos.SelectedIndex >= 0)
            {
                txtBuscar.Text = cmbEventos.SelectedItem.ToString();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text.Trim().ToLower();
            var resultado = eventos.FirstOrDefault(ev => ev.NombreEvento.ToLower().Contains(busqueda));

            if (resultado != null)
            {
                // Abre el formulario de eliminación
                var formularioEliminar = new EliminarEvento(resultado);
                formularioEliminar.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Evento no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pbInicio_Click(object sender, EventArgs e)
        {
            FrmAdmin frmAdmin = new FrmAdmin();
            frmAdmin.Show();
            this.Close();
        }

        private void pbMensajes_Click(object sender, EventArgs e)
        {
            MensajesAdministrador mensajesAdministrador = new MensajesAdministrador();
            mensajesAdministrador.Show();
            this.Close();
        }

        private void btnCerrarSesiónAdmin_Click(object sender, EventArgs e)
        {
            AdminLoginForm adminLoginForm = new AdminLoginForm();
            adminLoginForm.Show();
            this.Close();
        }

        private bool menuExpandido = false;

        private void btnToggleMenu_Click(object sender, EventArgs e)
        {
            FuncionesVarias.ToggleMenu(guna2PanelMenu, menuExpandido);
            menuExpandido = !menuExpandido; // Cambiar el estado del menú
        }
    }
    
}

