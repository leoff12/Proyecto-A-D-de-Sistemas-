using ProyectoFinal.Clases;
using ProyectoFinal.Servicios;
using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
namespace ProyectoFinal.Formularios
{
    public partial class EliminarEvento : MetroFramework.Forms.MetroForm
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
            // Asegurarse de que el tipo de evento esté en la lista del ComboBox
            if (!cmbTipoDeEventoElim.Items.Contains(eventoSeleccionado.TipoDeEvento) && !cmbCategoriaElim.Items.Contains(eventoSeleccionado.TipoDeEvento))
            {
                cmbTipoDeEventoElim.Items.Add(eventoSeleccionado.TipoDeEvento);
                cmbCategoriaElim.Items.Add(eventoSeleccionado.Categoría);
            }

            cmbTipoDeEventoElim.Text = eventoSeleccionado.TipoDeEvento;
            cmbTipoDeEventoElim.Enabled = false; // Deshabilita la opción de cambio
            txtNombreEvento.Text = eventoSeleccionado.NombreEvento;
            txtDescripcion.Text = eventoSeleccionado.Descripción;
            mtxtFechaEvento.Text = eventoSeleccionado.Fecha.ToString("dd/MM/yyyy");
            cmbCategoriaElim.Text = eventoSeleccionado.Categoría;
            cmbCategoriaElim.Enabled = false; // Deshabilita la opción de cambio
            txtCuposDisp.Text = eventoSeleccionado.CuposDisp.ToString();
            mtxtHInicio.Text = $"{eventoSeleccionado.HoraInicio:00}:00";
            mtxtHFin.Text = $"{eventoSeleccionado.HoraFin:00}:00";
            chkAccesibleElim.Checked = eventoSeleccionado.Accesible;

            // Deshabilita la edición
            txtNombreEvento.ReadOnly = true;
            txtDescripcion.ReadOnly = true;
            cmbTipoDeEventoElim.DropDownStyle = ComboBoxStyle.DropDownList;
            mtxtFechaEvento.ReadOnly = true;
            cmbCategoriaElim.DropDownStyle = ComboBoxStyle.DropDownList;
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


        private void EliminarEvento_Load(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbImagen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblImagen_Click(object sender, EventArgs e)
        {

        }

        private void pbMensajesAdmin_Click(object sender, EventArgs e)
        {
            MensajesAdministrador mensajesAdministrador = new MensajesAdministrador();
            mensajesAdministrador.Show();
            this.Close();
        }

        private void btnCerrarSesiónAdmin_Click(object sender, EventArgs e)
        {
            AdminLoginForm adminLoginForm = new AdminLoginForm();
            adminLoginForm.Show();
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
                guna2PanelMenu.Width = 187; // Expandir el ancho del panel
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
    }   }
}
