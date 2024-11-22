using System;
using System.Collections.Generic;
using ProyectoFinal.Clases;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace ProyectoFinal.Servicios
{
    public static class Funciones
    {
        private const string Archivo = "Eventos.dat";

        public static void AgregarEvento(Eventos evento)
        {
            try
            {
                // Verificar si el archivo ya existe
                List<Eventos> eventosList = new List<Eventos>();

                if (File.Exists(Archivo))
                {
                    using (FileStream fs = new FileStream(Archivo, FileMode.Open, FileAccess.Read))
                    {
                        if (fs.Length > 0) // Asegurarse de que el archivo no esté vacío
                        {
                            BinaryFormatter formatter = new BinaryFormatter();
                            eventosList = (List<Eventos>)formatter.Deserialize(fs);
                        }
                    }
                }

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

    }
}