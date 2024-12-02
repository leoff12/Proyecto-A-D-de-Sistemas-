using ProyectoFinal.Clases;
using ProyectoFinal.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoFinal.Formularios
{
    public partial class MensajesUsuario : MetroFramework.Forms.MetroForm
    {
        DetalleEventoForm detalleEventoForm = new DetalleEventoForm();
        public MensajesUsuario()
        {
            InitializeComponent();
        }
        private void CargarMensajes()
        {
            List<Mensajes> mensajes = Funciones.CargarMensajes();
            dgvMensajesUsuario.Rows.Clear(); // Limpiar el DataGridView antes de agregar los mensajes

            foreach (var mensaje in mensajes)
            {
                dgvMensajesUsuario.Rows.Add(mensaje.NombreMensaje, mensaje.FechaMensaje, mensaje.FechaEnvio, mensaje.Estado);
            }
        }
        private void MensajesUsuario_Load(object sender, EventArgs e)
        {
            CargarMensajes();
        }

        private void btnEliminarMensaje_Click(object sender, EventArgs e)
        {

            if (dgvMensajesUsuario.SelectedRows.Count > 0)
            {
                string nombreMensaje = dgvMensajesUsuario.SelectedRows[0].Cells[0].Value.ToString(); // Obtener el nombre del mensaje
                List<Mensajes> mensajes = Funciones.CargarMensajes();
                Mensajes mensajeSeleccionado = mensajes.FirstOrDefault(m => m.NombreMensaje == nombreMensaje);

                if (mensajeSeleccionado != null)
                {
                    Funciones.EliminarMensaje(mensajeSeleccionado);
                    CargarMensajes();
                    MessageBox.Show("Mensaje eliminado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El mensaje seleccionado no fue encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un mensaje para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pbMensajesRegresarUser_Click(object sender, EventArgs e)
        {
            VistaGeneralUsuario vistaGeneralUsuario = new VistaGeneralUsuario();
            vistaGeneralUsuario.Show();
            this.Close();
        }

        private void btnCerrarSesiónAdmin_Click(object sender, EventArgs e)
        {
            VistaGeneralUsuario VistaGeneralUsuario = new VistaGeneralUsuario();
            VistaGeneralUsuario.Show();
            this.Close();
        }

        private bool menuExpandido = true;
        private void btnToggleMenu_Click(object sender, EventArgs e)
        {
            if (menuExpandido)
            {
                guna2PanelMenu.Width = 40; // Reducir el ancho del panel
                menuExpandido = false;

                // Ocultar texto de los botones
                foreach (Control control in guna2PanelMenu.Controls)
                {
                    if (control is Guna.UI2.WinForms.Guna2Button button)
                    {
                        button.Text = ""; // Ocultar el texto
                        button.ImageAlign = HorizontalAlignment.Center; // Centrar los íconos
                    }
                }
            }
            else
            {
                guna2PanelMenu.Width = 187; // Expandir el ancho del panel
                menuExpandido = true;

                // Restaurar texto de los botones
                foreach (Control control in guna2PanelMenu.Controls)
                {
                    if (control is Guna.UI2.WinForms.Guna2Button button)
                    {
                        button.Text = button.Tag.ToString(); // Recuperar texto del botón desde su Tag
                        button.ImageAlign = HorizontalAlignment.Left; // Restaurar la alineación de los íconos
                    }
                }
            }
        }
    }
}
