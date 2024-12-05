using ProyectoFinal.Clases;
using ProyectoFinal.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoFinal.Formularios
{
    public partial class ModificarEvento : MetroFramework.Forms.MetroForm
    {
        private List<Eventos> eventos;

        public ModificarEvento()
        {
            InitializeComponent();
            this.Load += ModificarEvento_Load;
        }

        private void ModificarEvento_Load(object sender, EventArgs e)
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text.Trim().ToLower();
            var resultado = eventos.FirstOrDefault(ev => ev.NombreEvento.ToLower().Contains(busqueda));

            if (resultado != null)
            {
                AbrirFormularioEdicion(resultado);
            }
            else
            {
                MessageBox.Show("Evento no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Este evento ya no es necesario para hacer la búsqueda, solo se usa para cargar el nombre en el TextBox
        private void cmbEventos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica si el índice seleccionado es válido
            if (cmbEventos.SelectedIndex < 0)
            {
                return; // Sale del método si no hay un elemento seleccionado válido
            }

            // Obtiene el nombre del evento seleccionado y lo coloca en el TextBox txtBuscar
            string eventoSeleccionado = cmbEventos.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(eventoSeleccionado))
            {
                txtBuscar.Text = eventoSeleccionado;  // Rellena el TextBox con el nombre del evento seleccionado
            }
        }

        private void AbrirFormularioEdicion(Eventos evento)
        {
            var formularioEdicion = new EditarEvento(evento);
            formularioEdicion.Show();

            this.Close();

            // Actualizar el ComboBox si se hicieron cambios
            CargarComboBox();
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

        private void guna2TileButton1_Click(object sender, EventArgs e)
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
