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
                Fecha = DateTime.ParseExact(mtxtFechaEvento.Text, "dd/MM/yyyy", null),
                TipoPúblico = txtTipoPublico.Text,
                CuposDisp = int.Parse(txtCuposDisp.Text),
                HoraInicio = int.Parse(mtxtHInicio.Text.Split(':')[0]),  // Solo toma la hora
                HoraFin = int.Parse(mtxtHFin.Text.Split(':')[0]),        // Solo toma la hora
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

            // Validar que Fecha sea válida
            if (!DateTime.TryParseExact(mtxtFechaEvento.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fecha))
            {
                MessageBox.Show("La fecha debe tener un formato válido (dd/MM/yyyy).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar que CuposDisponibles sea un número entero positivo
            if (!int.TryParse(txtCuposDisp.Text, out int cuposDisp) || cuposDisp <= 0)
            {
                MessageBox.Show("Los cupos disponibles deben ser un número entero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Convertir las horas (HH:mm) a enteros
            if (!mtxtHInicio.MaskCompleted || !mtxtHFin.MaskCompleted)
            {
                MessageBox.Show("Las horas deben tener el formato HH:mm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string[] horaInicioParts = mtxtHInicio.Text.Split(':');
            string[] horaFinParts = mtxtHFin.Text.Split(':');

            if (horaInicioParts.Length == 2 && horaFinParts.Length == 2)
            {
                int horaInicioInt = int.Parse(horaInicioParts[0]);
                int minutoInicioInt = int.Parse(horaInicioParts[1]);
                int horaFinInt = int.Parse(horaFinParts[0]);
                int minutoFinInt = int.Parse(horaFinParts[1]);

                // Verificar que la hora de inicio sea menor que la hora de fin
                if (horaInicioInt > horaFinInt || (horaInicioInt == horaFinInt && minutoInicioInt >= minutoFinInt))
                {
                    MessageBox.Show("La hora de inicio debe ser menor que la hora de fin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
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

        private void mtxtFechaEvento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void pbInicioAdmin_Click(object sender, EventArgs e)
        {
            FrmAdmin frmAdmin = new FrmAdmin();
            frmAdmin.Show();
            this.Close();
        }

        private bool menuExpandido = true;
        private void btnToggleMenu_Click(object sender, EventArgs e)
        {
            if (menuExpandido)
            {
                guna2PanelMenu.Width = 40; // Reducir el ancho del panel
                menuExpandido = false;

                // Ocultar texto de los botones
                foreach (Control control in guna2PanelMenu.Controls)
                {
                    if (control is Guna.UI2.WinForms.Guna2Button button)
                    {
                        button.Text = ""; // Ocultar el texto
                        button.ImageAlign = HorizontalAlignment.Center; // Centrar los íconos
                    }
                }
            }
            else
            {
                guna2PanelMenu.Width = 100; // Expandir el ancho del panel
                menuExpandido = true;

                // Restaurar texto de los botones
                foreach (Control control in guna2PanelMenu.Controls)
                {
                    if (control is Guna.UI2.WinForms.Guna2Button button)
                    {
                        button.Text = button.Tag.ToString(); // Recuperar texto del botón desde su Tag
                        button.ImageAlign = HorizontalAlignment.Left; // Restaurar la alineación de los íconos
                    }
                }
            }
        }
    }
}
