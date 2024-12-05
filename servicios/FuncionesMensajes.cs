using ProyectoFinal.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Servicios
{
    public static class FuncionesMensajes
    {
        public static void CargarMensajes(DataGridView dgvMensajesAdmin)
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


        // Función para actualizar el estado de un evento
        public static void ActualizarEstadoEvento(string nombreEvento, int nuevoEstado, string estadoMensaje)
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
            }
            else
            {
                throw new Exception("Evento no encontrado.");
            }
        }
    }
}
