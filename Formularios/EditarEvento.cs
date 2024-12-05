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
        private CargarImagen cargarImagen = new CargarImagen();

        private Eventos eventoOriginal;

        public EditarEvento(Eventos evento)
        {
            InitializeComponent();
            eventoOriginal = evento;
            this.Load += EditarEvento_Load; // Vincula el evento Load al método
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            // Llamar a la función ValidarFormulario desde FuncionesAgregarEvento
            if (!ValidarFormularios.ValidarFormulario(cmbImagen, txtNombreEvento, txtDescripcion, cmbTipoDeEventoMod,
                                                          mtxtFechaEvento, cmbCategoriaMod, txtCuposDisp, mtxtHInicio, mtxtHFin))
            {
                return; // Si no pasa la validación, no procede
            }

            // Actualizar los datos del evento
            eventoOriginal.NombreEvento = txtNombreEvento.Text;
            eventoOriginal.Descripción = txtDescripcion.Text;
            eventoOriginal.TipoDeEvento = cmbTipoDeEventoMod.SelectedItem?.ToString();
            eventoOriginal.Fecha = DateTime.ParseExact(mtxtFechaEvento.Text, "dd/MM/yyyy", null);
            eventoOriginal.Categoría = cmbCategoriaMod.SelectedItem?.ToString();
            eventoOriginal.CuposDisp = int.Parse(txtCuposDisp.Text);
            eventoOriginal.HoraInicio = int.Parse(mtxtHInicio.Text.Split(':')[0]);
            eventoOriginal.HoraFin = int.Parse(mtxtHFin.Text.Split(':')[0]);
            eventoOriginal.ImagenSeleccionada = cmbImagen.SelectedItem?.ToString();
            eventoOriginal.Accesible = chkAccesibleMod.Checked;

            // Guardar los cambios
            Funciones.ActualizarEvento(eventoOriginal);

            MessageBox.Show("Cambios guardados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void EditarEvento_Load(object sender, EventArgs e)
        {
            // Llamar al método de carga de imágenes
            cargarImagen.CargarImagenes(cmbImagen); // Carga las imágenes al ComboBox
            // Llamar a la función de cargar datos en los controles
            DatosEnControlesCargar.CargarDatosEnControles(cmbTipoDeEventoMod, cmbCategoriaMod, txtNombreEvento,
                                                          txtDescripcion, cmbTipoDeEventoMod, mtxtFechaEvento,
                                                          cmbCategoriaMod, txtCuposDisp, mtxtHInicio, mtxtHFin,
                                                          cmbImagen, chkAccesibleMod, eventoOriginal);
        }

       

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
        private void cmbImagen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbImagen.SelectedItem != null)
            {
                string nombreImagen = cmbImagen.SelectedItem.ToString();
                CargarImagen.CargarImagenEnPictureBox(nombreImagen, pictureBox); // Cargar la imagen en el PictureBox
            }
        }

        private void pbInicio_Click(object sender, EventArgs e)
        {
            ModificarEvento modificarEvento = new ModificarEvento();
            modificarEvento.Show();
            this.Close();
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

        private bool menuExpandido = false;

        private void btnToggleMenu_Click(object sender, EventArgs e)
        {
            FuncionesVarias.ToggleMenu(guna2PanelMenu, menuExpandido);
            menuExpandido = !menuExpandido; // Cambiar el estado del menú
        }
    }
}