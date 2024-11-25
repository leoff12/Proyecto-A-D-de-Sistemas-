using System;
using System.Collections.Generic;
using ProyectoFinal.Clases;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using ProyectoFinal.Formularios;
using System.Linq;

namespace ProyectoFinal.Servicios
{
    public static class Funciones
    {
        private const string Archivo = "Eventos.dat";

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
            string rutaArchivo = "ruta_donde_se_guardan_los_eventos.dat";
            List<Eventos> eventos = CargarEventos();

            // Elimina el evento de la lista
            eventos.RemoveAll(e => e.NombreEvento == evento.NombreEvento);

            // Guarda nuevamente la lista sin el evento eliminado
            GuardarEventos(eventos);
        }

        public static void GuardarEventos(List<Eventos> eventos)
        {
            string rutaArchivo = "ruta_donde_se_guardan_los_eventos.dat";

            using (StreamWriter writer = new StreamWriter(rutaArchivo, false))
            {
                foreach (var evento in eventos)
                {
                    writer.WriteLine($"{evento.NombreEvento}|{evento.Descripción}|{evento.Categoría}|{evento.Fecha:dd/MM/yyyy}|{evento.TipoPúblico}|{evento.CuposDisp}|{evento.HoraInicio}|{evento.HoraFin}");
                }
            }
        }

    }
}