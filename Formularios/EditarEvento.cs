using ProyectoFinal.Clases;
using ProyectoFinal.Servicios;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace ProyectoFinal.Formularios
{
    public partial class EditarEvento : MetroFramework.Forms.MetroForm
    {
        private Eventos eventoOriginal;

        public EditarEvento(Eventos evento)
        {
            InitializeComponent();
            eventoOriginal = evento;
            CargarDatosEnControles();
        }

        private void CargarDatosEnControles()
        {
            txtNombreEvento.Text = eventoOriginal.NombreEvento;
            txtDescripcion.Text = eventoOriginal.Descripción;
            txtCategoria.Text = eventoOriginal.Categoría;
            mtxtFechaEvento.Text = eventoOriginal.Fecha.ToString("dd/MM/yyyy");
            txtTipoPublico.Text = eventoOriginal.TipoPúblico;
            txtCuposDisp.Text = eventoOriginal.CuposDisp.ToString();
            mtxtHInicio.Text = $"{eventoOriginal.HoraInicio:00}:00";
            mtxtHFin.Text = $"{eventoOriginal.HoraFin:00}:00";
            cmbImagen.SelectedItem = eventoOriginal.ImagenSeleccionada;

        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario())
            {
                return;
            }

            // Actualizar los datos del evento
            eventoOriginal.NombreEvento = txtNombreEvento.Text;
            eventoOriginal.Descripción = txtDescripcion.Text;
            eventoOriginal.Categoría = txtCategoria.Text;
            eventoOriginal.Fecha = DateTime.ParseExact(mtxtFechaEvento.Text, "dd/MM/yyyy", null);
            eventoOriginal.TipoPúblico = txtTipoPublico.Text;
            eventoOriginal.CuposDisp = int.Parse(txtCuposDisp.Text);
            eventoOriginal.HoraInicio = int.Parse(mtxtHInicio.Text.Split(':')[0]);
            eventoOriginal.HoraFin = int.Parse(mtxtHFin.Text.Split(':')[0]);
            eventoOriginal.ImagenSeleccionada = cmbImagen.SelectedItem?.ToString();

            // Guardar los cambios
            Funciones.ActualizarEvento(eventoOriginal);

            MessageBox.Show("Cambios guardados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private bool ValidarFormulario()
        {
            // Validaciones similares al formulario de agregar evento
            return true; // Implementar las validaciones necesarias
        }

        private void EditarEvento_Load(object sender, EventArgs e)
        {
            CargarImagenes(cmbImagen);
            CargarDatosEnControles();               // Luego asignar el valor seleccionado
        }

        public void CargarImagenes(ComboBox comboBox)
        {
            string rutaCarpeta = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Imagenes");

            if (!Directory.Exists(rutaCarpeta))
            {
                MessageBox.Show("No se encontró la carpeta de imágenes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            comboBox.Items.Clear();

            string[] archivosImagen = Directory.GetFiles(rutaCarpeta, "*.*")
                                        .Where(f => f.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                                                   f.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                                                   f.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                                                   f.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase))
                                        .ToArray();

            foreach (string archivo in archivosImagen)
            {
                comboBox.Items.Add(Path.GetFileName(archivo)); // Agrega solo el nombre del archivo
                Console.WriteLine($"Imagen en ComboBox: {Path.GetFileName(archivo)}"); // Log para depuración
            }

            if (comboBox.Items.Count > 0)
            {
                comboBox.SelectedIndex = 0;
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
        private void cmbImagen_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtiene el nombre del archivo seleccionado en el ComboBox
            string nombreImagen = cmbImagen.SelectedItem.ToString();

            // Ruta completa de la imagen seleccionada en la carpeta "Imagenes"
            string rutaImagen = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Imagenes", nombreImagen);

            // Muestra la ruta completa en un MessageBox
            MessageBox.Show($"Ruta completa de la imagen seleccionada:\n{rutaImagen}",
                            "Ruta de la imagen",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            // Verifica si la imagen existe
            if (File.Exists(rutaImagen))
            {
                // Carga la imagen en el PictureBox
                using (var stream = new FileStream(rutaImagen, FileMode.Open, FileAccess.Read))
                {
                    pictureBox.Image = Image.FromStream(stream);
                }
            }
            else
            {
                // Si no existe la imagen, muestra un mensaje o una imagen por defecto
                MessageBox.Show("No se pudo cargar la imagen porque no existe.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void pbInicio_Click(object sender, EventArgs e)
        {
            ModificarEvento modificarEvento = new ModificarEvento();
            modificarEvento.Show();
            this.Close();
        }

        private void lblAgregarEvento_Click(object sender, EventArgs e)
        {

        }
    }
}