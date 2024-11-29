using ProyectoFinal.Clases;
using ProyectoFinal.Servicios;
using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
namespace ProyectoFinal.Formularios
{
    public partial class EliminarEvento : Form
    {
        private Eventos eventoSeleccionado; // Cambiado el nombre del campo para evitar ambigüedad


        public EliminarEvento(Eventos eventoS)
        {
            InitializeComponent();
            eventoSeleccionado = eventoS;
            CargarDetalles();
        }

        private void CargarDetalles()
        {
            // Muestra los detalles del evento
            txtNombreEvento.Text = eventoSeleccionado.NombreEvento;
            txtDescripcion.Text = eventoSeleccionado.Descripción;
            txtCategoria.Text = eventoSeleccionado.Categoría;
            mtxtFechaEvento.Text = eventoSeleccionado.Fecha.ToString("dd/MM/yyyy");
            txtTipoPublico.Text = eventoSeleccionado.TipoPúblico;
            txtCuposDisp.Text = eventoSeleccionado.CuposDisp.ToString();
            mtxtHInicio.Text = $"{eventoSeleccionado.HoraInicio:00}:00";
            mtxtHFin.Text = $"{eventoSeleccionado.HoraFin:00}:00";

            // Deshabilita la edición
            txtNombreEvento.ReadOnly = true;
            txtDescripcion.ReadOnly = true;
            txtCategoria.ReadOnly = true;
            mtxtFechaEvento.ReadOnly = true;
            txtTipoPublico.ReadOnly = true;
            txtCuposDisp.ReadOnly = true;
            mtxtHInicio.ReadOnly = true;
            mtxtHFin.ReadOnly = true;

            // Carga la dirección de la imagen en el ComboBox y la imagen en el PictureBox
            cmbImagen.Items.Clear();
            if (!string.IsNullOrEmpty(eventoSeleccionado.ImagenSeleccionada))
            {
                cmbImagen.Items.Add(eventoSeleccionado.ImagenSeleccionada);
                cmbImagen.SelectedIndex = 0; // Selecciona automáticamente la imagen del evento
                CargarImagen(eventoSeleccionado.ImagenSeleccionada);
            }

        }

        private void CargarImagen(string nombreImagen)
        {
            try
            {
                // Construcción de la ruta completa usando el directorio actual
                string rutaImagen = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Imagenes", nombreImagen);

                MessageBox.Show($"Ruta completa construida: {rutaImagen}"); // Para verificar la ruta

                if (File.Exists(rutaImagen))
                {
                    using (FileStream stream = new FileStream(rutaImagen, FileMode.Open, FileAccess.Read))
                    {
                        pbImagen.Image = Image.FromStream(stream); // Carga la imagen desde el stream
                    }
                }
                else
                {
                    pbImagen.Image = null;
                    MessageBox.Show($"La imagen no se encontró en la ruta especificada: {rutaImagen}", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                pbImagen.Image = null;
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show("¿Estás seguro de que deseas eliminar este evento?",
                                               "Confirmar eliminación",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                Funciones.EliminarEvento(eventoSeleccionado); // Uso del campo correcto
                MessageBox.Show("Evento eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BuscarEliminar buscarEliminar = new BuscarEliminar();
                buscarEliminar.Show();
                this.Close();
            }
        }

        private void pbInicio_Click(object sender, EventArgs e)
        {
            BuscarEliminar buscarEliminar = new BuscarEliminar();
            buscarEliminar.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbImagen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
