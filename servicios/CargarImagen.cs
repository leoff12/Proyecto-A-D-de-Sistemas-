using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace ProyectoFinal.Servicios
{
    internal class CargarImagen
    {
        // Método para cargar imágenes en un ComboBox
        public void CargarImagenes(ComboBox comboBox)
        {
            // Obtiene la ruta completa al directorio de imágenes dentro del proyecto
            string rutaCarpeta = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Imagenes");

            // Verifica si la carpeta existe
            if (!Directory.Exists(rutaCarpeta))
            {
                MessageBox.Show("No se encontró la carpeta de imágenes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Limpia los elementos previos en el ComboBox
            comboBox.Items.Clear();

            // Obtiene todos los archivos de imagen de la carpeta
            string[] archivosImagen = Directory.GetFiles(rutaCarpeta, "*.*")
                                    .Where(f => f.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                                               f.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                                               f.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                                               f.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase))
                                    .ToArray();

            // Carga los nombres de los archivos al ComboBox
            foreach (string archivo in archivosImagen)
            {
                comboBox.Items.Add(Path.GetFileName(archivo)); // Agrega solo el nombre del archivo
            }

            if (comboBox.Items.Count > 0)
            {
                comboBox.SelectedIndex = 0; // Selecciona el primer elemento por defecto
            }
        }

        //Cargar imagen en el pictureBox

        public static void CargarImagenEnPictureBox(string nombreImagen, PictureBox pictureBox)
        {
            // Validación de parámetros
            if (string.IsNullOrEmpty(nombreImagen))
            {
                MessageBox.Show("El nombre de la imagen no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (pictureBox == null)
            {
                MessageBox.Show("El control PictureBox no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Construcción de la ruta completa usando el directorio base
                string rutaImagen = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Imagenes", nombreImagen);

                // Verificar si el archivo de la imagen existe
                if (File.Exists(rutaImagen))
                {
                    // Cargar la imagen en el PictureBox
                    pictureBox.Image = Image.FromFile(rutaImagen);
                }
                else
                {
                    // Si no se encuentra la imagen, mostrar mensaje de error
                    pictureBox.Image = null;  // Limpiar el PictureBox
                    MessageBox.Show($"La imagen '{nombreImagen}' no se encuentra en la ruta especificada.", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones generales
                pictureBox.Image = null;  // Limpiar el PictureBox
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}