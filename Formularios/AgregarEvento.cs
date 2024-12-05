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
            if (cmbImagen.SelectedItem != null)
            {
                string nombreImagen = cmbImagen.SelectedItem.ToString();
                cargarImagen.CargarImagenEnPictureBox(nombreImagen, pictureBox); // Llama al método de CargarImagen
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
            // Llamar a la función ValidarFormulario desde FuncionesAgregarEvento
            if (!ValidarFormularios.ValidarFormulario(cmbImagen, txtNombreEvento, txtDescripcion, cmbTipoDeEvento,
                                                          mtxtFechaEvento, cmbCategoria, txtCuposDisp, mtxtHInicio, mtxtHFin))
            {
                return; // Si no pasa la validación, no procede
            }

            // Crear el nuevo evento después de validar los datos
            Eventos nuevoEvento = new Eventos
            {
                NombreEvento = txtNombreEvento.Text,
                Descripción = txtDescripcion.Text,
                TipoDeEvento = cmbTipoDeEvento.Text,
                Fecha = DateTime.ParseExact(mtxtFechaEvento.Text, "dd/MM/yyyy", null),
                Categoría = cmbCategoria.Text,
                CuposDisp = int.Parse(txtCuposDisp.Text),
                HoraInicio = int.Parse(mtxtHInicio.Text.Split(':')[0]),
                HoraFin = int.Parse(mtxtHFin.Text.Split(':')[0]),
                ImagenSeleccionada = cmbImagen.SelectedItem?.ToString(),
                Accesible = chkAccesible.Checked,
                EstadoReservación = 0,
            };

            // Guardar el evento
            Funciones.AgregarEvento(nuevoEvento);
            MessageBox.Show("Evento guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void pbMensajesAdmin(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MensajesAdministrador mensajesAdministrador = new MensajesAdministrador();
            mensajesAdministrador.Show();
            this.Close();
        }

        bool menuExpandido = false;
        private void btnToggleMenu_Click_1(object sender, EventArgs e)
        {
            FuncionesVarias.ToggleMenu(guna2PanelMenu, menuExpandido);
            menuExpandido = !menuExpandido; // Cambiar el estado del menú
        }
    }
    
}
