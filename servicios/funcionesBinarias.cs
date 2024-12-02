using ProyectoFinal.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace ProyectoFinal.Servicios
{
    public static class Funciones
    {
        private const string Archivo = "Eventos.dat";
        private const string Archivo2 = "Mensajes.dat";

        //Funciones para los Eventos
        public static void AgregarEvento(Eventos evento)
        {
            try
            {
                List<Eventos> eventosList = new List<Eventos>();

                // Verificar si el archivo ya existe
                if (File.Exists(Archivo))
                {
                    using (FileStream fs = new FileStream(Archivo, FileMode.Open, FileAccess.Read))
                    {
                        if (fs.Length > 0)
                        {
                            BinaryFormatter formatter = new BinaryFormatter();
                            eventosList = (List<Eventos>)formatter.Deserialize(fs);
                        }
                    }
                }

                // Asignar un ID único al nuevo evento
                evento.ID = eventosList.Count > 0 ? eventosList.Max(e => e.ID) + 1 : 1;

                // Agregar el nuevo evento a la lista
                eventosList.Add(evento);

                // Guardar la lista actualizada de eventos
                using (FileStream fs = new FileStream(Archivo, FileMode.Create, FileAccess.Write))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, eventosList);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar el evento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para cargar eventos desde el archivo binario
        public static List<Eventos> CargarEventos()
        {
            List<Eventos> eventosList = new List<Eventos>();

            try
            {
                if (File.Exists(Archivo))
                {
                    using (FileStream fs = new FileStream(Archivo, FileMode.Open, FileAccess.Read))
                    {
                        if (fs.Length > 0)
                        {
                            BinaryFormatter formatter = new BinaryFormatter();
                            eventosList = (List<Eventos>)formatter.Deserialize(fs);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los eventos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return eventosList;
        }

        public static void ActualizarEvento(Eventos eventoModificado)
        {
            try
            {
                List<Eventos> eventosList = CargarEventos();

                // Buscar el evento por ID
                var eventoOriginal = eventosList.FirstOrDefault(e => e.ID == eventoModificado.ID);

                if (eventoOriginal != null)
                {
                    // Actualizar los datos
                    int index = eventosList.IndexOf(eventoOriginal);
                    eventosList[index] = eventoModificado;

                    // Guardar la lista actualizada
                    using (FileStream fs = new FileStream(Archivo, FileMode.Create, FileAccess.Write))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(fs, eventosList);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al actualizar el evento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void EliminarEvento(Eventos evento)
        {
            string rutaArchivo = "Eventos.dat";
            List<Eventos> eventos = CargarEventos();

            // Elimina el evento de la lista
            eventos.RemoveAll(e => e.ID == evento.ID);

            // Guarda nuevamente la lista sin el evento eliminado
            GuardarEventos(eventos);
        }

        public static void GuardarEventos(List<Eventos> eventos)
        {
            using (FileStream fs = new FileStream("Eventos.dat", FileMode.Create, FileAccess.Write))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, eventos);
            }
        }

        //Funciones para Mensajes

        public static void GuardarMensaje(Mensajes mensaje)
        {
            List<Mensajes> mensajes = CargarMensajes();

            // Asignar un ID único al nuevo mensaje
            mensaje.IDMensaje = mensajes.Count > 0 ? mensajes.Max(m => m.IDMensaje) + 1 : 1;

            mensajes.Add(mensaje);

            using (FileStream fs = new FileStream("Mensajes.dat", FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, mensajes);
            }
        }

        public static List<Mensajes> CargarMensajes()
        {
            if (File.Exists("Mensajes.dat"))
            {
                using (FileStream fs = new FileStream("Mensajes.dat", FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    return (List<Mensajes>)formatter.Deserialize(fs);
                }
            }
            return new List<Mensajes>();
        }
        public static void GuardarMensajes(List<Mensajes> mensajes)
        {
            try
            {
                using (FileStream fs = new FileStream("Mensajes.dat", FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, mensajes);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error al guardar los mensajes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SerializationException ex)
            {
                MessageBox.Show($"Error de serialización: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void EliminarMensaje(Mensajes mensaje)
        {
            try
            {
                string rutaArchivo = "Mensajes.dat";
                List<Mensajes> mensajes = CargarMensajes();

                // Elimina el mensaje de la lista utilizando el IDMensaje
                mensajes.RemoveAll(m => m.IDMensaje == mensaje.IDMensaje);

                // Guarda la lista actualizada de mensajes sin el mensaje eliminado
                GuardarMensajes(mensajes);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}