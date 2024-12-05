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
            // Llamar a la función estática CargarDetalles de la clase DatosEnControlesCargar
            DatosEnControlesCargar.CargarDetalles(eventoSeleccionado, cmbTipoDeEventoElim, cmbCategoriaElim, txtNombreEvento, txtDescripcion, mtxtFechaEvento, txtCuposDisp, mtxtHInicio, mtxtHFin, chkAccesibleElim, cmbImagen, pbImagen);
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

        private bool menuExpandido = false;

        private void btnToggleMenu_Click(object sender, EventArgs e)
        {
            FuncionesVarias.ToggleMenu(guna2PanelMenu, menuExpandido);
            menuExpandido = !menuExpandido; // Cambiar el estado del menú
        } 
    }

}
