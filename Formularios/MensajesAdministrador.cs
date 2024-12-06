using ProyectoFinal.Clases;
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
using ProyectoFinal.Formularios;
using ProyectoFinal.Servicios;

namespace ProyectoFinal.Formularios
{
    public partial class MensajesAdministrador : MetroFramework.Forms.MetroForm
    {
        

        public MensajesAdministrador()
        {
            InitializeComponent();
        }

        private void MensajesAdministrador_Load(object sender, EventArgs e)
        {
            // Llamar a la función de cargar mensajes desde la clase FuncionesMensajes
            FuncionesMensajes.CargarMensajes(dgvMensajesAdmin);
        }

        private void CargarMensajes()
        {
            // Llamamos a la función CargarMensajes de FuncionesMensajes
            FuncionesMensajes.CargarMensajes(dgvMensajesAdmin);
        }

        private void btnEliminarMensaje_Click(object sender, EventArgs e)
        {

            if (dgvMensajesAdmin.SelectedRows.Count > 0)
            {
                string nombreMensaje = dgvMensajesAdmin.SelectedRows[0].Cells[0].Value.ToString(); // Obtener el nombre del mensaje
                List<Mensajes> mensajes = Funciones.CargarMensajes();
                Mensajes mensajeSeleccionado = mensajes.FirstOrDefault(m => m.NombreMensaje == nombreMensaje);

                if (mensajeSeleccionado != null)
                {
                    Funciones.EliminarMensaje(mensajeSeleccionado);
                    FuncionesMensajes.CargarMensajes(dgvMensajesAdmin); // Recargar los mensajes después de la eliminación
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

        private void pbMensajesRegresarAdmin_Click(object sender, EventArgs e)
        {
            FrmAdmin frmAdmin = new FrmAdmin();
            frmAdmin.Show();
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvMensajesAdmin.SelectedRows.Count > 0)
            {
                string nombreEvento = dgvMensajesAdmin.SelectedRows[0].Cells[0].Value.ToString();

                try
                {
                    // Llamar a la función de actualización de estado
                    FuncionesMensajes.ActualizarEstadoEvento(nombreEvento, 2, "Aprobada"); // EstadoReservación = 2 (Aprobada)
                    CargarMensajes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            if (dgvMensajesAdmin.SelectedRows.Count > 0)
            {
                string nombreEvento = dgvMensajesAdmin.SelectedRows[0].Cells[0].Value.ToString();

                try
                {
                    // Llamar a la función de actualización de estado
                    FuncionesMensajes.ActualizarEstadoEvento(nombreEvento, 3, "Rechazada"); // EstadoReservación = 3 (Rechazada)
                    CargarMensajes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /*var eventoOriginal = eventosList.FirstOrDefault(e => e.ID == eventoModificado.ID);

                if (eventoOriginal != null)
                {
                    // Actualizar los datos
                    int index = eventosList.IndexOf(eventoOriginal);
                    eventosList[index] = eventoModificado;*/

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvMensajesAdmin.SelectedRows.Count > 0)
            {
                string nombreEvento = dgvMensajesAdmin.SelectedRows[0].Cells[0].Value.ToString();

                try
                {
                    List<Eventos> eventos = new List<Eventos>();
                    eventos = Funciones.CargarEventos();
                    var eventoSeleccionado = eventos.FirstOrDefault(a => a.NombreEvento == nombreEvento);
                    if (eventoSeleccionado.EstadoReservación == 2)
                    {
                        // Llamar a la función de actualización de estado
                        FuncionesMensajes.ActualizarEstadoEvento(nombreEvento, 1, "En espera"); // EstadoReservación = 1 (En espera)
                    }
                    else
                    {
                        FuncionesMensajes.ActualizarEstadoEvento(nombreEvento, 4, "En espera"); 
                    }

                    CargarMensajes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private void dgvMensajesAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
