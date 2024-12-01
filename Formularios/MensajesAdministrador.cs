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

namespace ProyectoFinal.Formularios
{
    public partial class MensajesAdministrador : Form
    {
        

        public MensajesAdministrador()
        {
            InitializeComponent();
        }
        private void CargarMensajes()
        {
            // Cargar los mensajes desde la fuente de datos
            List<Mensajes> mensajes = Funciones.CargarMensajes();

            // Limpiar las filas y las columnas antes de volver a asignar el DataSource
            dgvMensajesAdmin.Rows.Clear();
            dgvMensajesAdmin.Columns.Clear();

            // Verificar que hay mensajes disponibles
            if (mensajes != null && mensajes.Count > 0)
            {
                // Agregar las columnas necesarias
                dgvMensajesAdmin.Columns.Add("NombreEvento", "Nombre del Evento");
                dgvMensajesAdmin.Columns.Add("FechaEvento", "Fecha del Evento");
                dgvMensajesAdmin.Columns.Add("FechaEnvio", "Fecha de Envío del Mensaje");
                dgvMensajesAdmin.Columns.Add("Estado", "Estado");

                // Agregar los datos de los mensajes al DataGridView
                foreach (var mensaje in mensajes)
                {
                    
                    dgvMensajesAdmin.Rows.Add(
                        mensaje.NombreMensaje,  // Nombre del Evento
                        mensaje.FechaMensaje.ToString("dd/MM/yyyy"),  // Fecha del Evento
                        mensaje.FechaEnvio.ToString("dd/MM/yyyy HH:mm"),  // Fecha de Envío del Mensaje
                        mensaje.Estado  // Estado
                    );
                }
            }
            else
            {
                MessageBox.Show("No se encontraron mensajes en el archivo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void MensajesAdministrador_Load(object sender, EventArgs e)
        {
            CargarMensajes();
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
                ActualizarEstadoEvento(nombreEvento, 2, "Aprobada"); // EstadoReservación = 2 (Aprobada)
                
            }
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            if (dgvMensajesAdmin.SelectedRows.Count > 0)
            {
                string nombreEvento = dgvMensajesAdmin.SelectedRows[0].Cells[0].Value.ToString();
                ActualizarEstadoEvento(nombreEvento, 3, "Rechazada"); // EstadoReservación = 3 (Rechazada)
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvMensajesAdmin.SelectedRows.Count > 0)
            {
                string nombreEvento = dgvMensajesAdmin.SelectedRows[0].Cells[0].Value.ToString();
                ActualizarEstadoEvento(nombreEvento, 1, "En espera"); // EstadoReservación = 1 (En espera)
                
            }
        }

        private void ActualizarEstadoEvento(string nombreEvento, int nuevoEstado, string estadoMensaje)
        {
            List<Eventos> eventosList = Funciones.CargarEventos();
            Eventos evento = eventosList.FirstOrDefault(e => e.NombreEvento == nombreEvento);

            if (evento != null)
            {
                evento.EstadoReservación = nuevoEstado;
                Funciones.ActualizarEvento(evento);

                // Actualizar el mensaje correspondiente
                List<Mensajes> mensajes = Funciones.CargarMensajes();
                Mensajes mensaje = mensajes.FirstOrDefault(m => m.NombreMensaje == nombreEvento);
                if (mensaje != null)
                {
                    mensaje.Estado = estadoMensaje;
                    Funciones.GuardarMensajes(mensajes);
                }
                CargarMensajes();
            }
            else
            {
                MessageBox.Show("Evento no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
