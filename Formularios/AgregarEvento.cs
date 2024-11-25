using ProyectoFinal.Servicios;
using ProyectoFinal.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ProyectoFinal.Clases;

namespace ProyectoFinal.Formularios
{
    public partial class AgregarEvento : MetroFramework.Forms.MetroForm
    {
        private CargarImagen cargarImagen = new CargarImagen();

        public AgregarEvento()
        {
            InitializeComponent();
            this.Load += AgregarEvento_Load; // Vincula el evento Load al método
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbImagen_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtiene el nombre del archivo seleccionado en el ComboBox
            string nombreImagen = cmbImagen.SelectedItem.ToString();

            // Ruta completa de la imagen seleccionada en la carpeta "Imagenes"
            string rutaImagen = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Imagenes", nombreImagen);

            // Verifica si la imagen existe
            if (File.Exists(rutaImagen))
            {
                // Carga la imagen en el PictureBox
                pictureBox.Image = Image.FromFile(rutaImagen);
            }
            else
            {
                // Si no existe la imagen, muestra un mensaje o una imagen por defecto
                MessageBox.Show("No se pudo cargar la imagen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        private void AgregarEvento_Load(object sender, EventArgs e)
        {

            // Llamar al método de carga de imágenes
            cargarImagen.CargarImagenes(cmbImagen);
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void pbInicio_Click(object sender, EventArgs e)
        {
            FrmAdmin frmAdmin = new FrmAdmin();
            frmAdmin.Show();
            this.Close();
        }

        private void btnGuardarEvento_Click(object sender, EventArgs e)
        {
            // Validar los campos del formulario
            if (!ValidarFormulario())
            {
                return;
            }

            // Crear el nuevo evento después de validar los datos
            Eventos nuevoEvento = new Eventos
            {
                NombreEvento = txtNombreEvento.Text,
                Descripción = txtDescripcion.Text,
                Categoría = txtCategoria.Text,
                Fecha = int.Parse(mtxtFechaEvento.Text),
                TipoPúblico = txtTipoPublico.Text,
                CuposDisp = int.Parse(txtCuposDisp.Text),
                HoraInicio = int.Parse(mtxtHInicio.Text),
                HoraFin = int.Parse(mtxtHFin.Text),
                ImagenSeleccionada = cmbImagen.SelectedItem?.ToString()
            };

            // Llamar al método agregarEvento de la clase Funciones para guardar el evento
            Funciones.AgregarEvento(nuevoEvento);

            MessageBox.Show("Evento guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Método para validar el formulario
        private bool ValidarFormulario()
        {
            // Verificar campos vacíos
            if (string.IsNullOrWhiteSpace(txtNombreEvento.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                string.IsNullOrWhiteSpace(mtxtFechaEvento.Text) ||
                string.IsNullOrWhiteSpace(txtTipoPublico.Text) ||
                string.IsNullOrWhiteSpace(txtCuposDisp.Text) ||
                string.IsNullOrWhiteSpace(mtxtHInicio.Text) ||
                string.IsNullOrWhiteSpace(mtxtHFin.Text) ||
                cmbImagen.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar que Fecha sea un número entero
            if (!int.TryParse(mtxtFechaEvento.Text, out int fecha) || fecha <= 0)
            {
                MessageBox.Show("La fecha debe ser un número entero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar que CuposDisponibles sea un número entero positivo
            if (!int.TryParse(txtCuposDisp.Text, out int cuposDisp) || cuposDisp <= 0)
            {
                MessageBox.Show("Los cupos disponibles deben ser un número entero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar que HoraInicio y HoraFin sean números enteros y que HoraInicio < HoraFin
            if (!int.TryParse(mtxtHInicio.Text, out int horaInicio) || !int.TryParse(mtxtHFin.Text, out int horaFin))
            {
                MessageBox.Show("Las horas de inicio y fin deben ser números enteros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (horaInicio >= horaFin)
            {
                MessageBox.Show("La hora de inicio debe ser menor que la hora de fin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar que se seleccionó una imagen
            if (cmbImagen.SelectedItem == null || string.IsNullOrWhiteSpace(cmbImagen.SelectedItem.ToString()))
            {
                MessageBox.Show("Por favor, seleccione una imagen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Si todas las validaciones pasan
            return true;
        }

        private void txtCuposDisp_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números y la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Cancela el evento
            }
        }
    }
}
