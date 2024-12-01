using ProyectoFinal.Clases;
using ProyectoFinal.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Formularios
{
    public partial class MensajesUsuario : Form
    {
        DetalleEventoForm detalleEventoForm = new DetalleEventoForm();
        public MensajesUsuario()
        {
            InitializeComponent();
        }
        private void CargarMensajes()
        {
            List<Mensajes> mensajes = Funciones.CargarMensajes();
            dgvMensajesUsuario.Rows.Clear(); // Limpiar el DataGridView antes de agregar los mensajes

            foreach (var mensaje in mensajes)
            {
                dgvMensajesUsuario.Rows.Add(mensaje.NombreMensaje, mensaje.FechaMensaje, mensaje.FechaEnvio, mensaje.Estado);
            }
        }
        private void MensajesUsuario_Load(object sender, EventArgs e)
        {
            CargarMensajes();
        }

        private void btnEliminarMensaje_Click(object sender, EventArgs e)
        {

            if (dgvMensajesUsuario.SelectedRows.Count > 0)
            {
                string nombreMensaje = dgvMensajesUsuario.SelectedRows[0].Cells[0].Value.ToString(); // Obtener el nombre del mensaje
                List<Mensajes> mensajes = Funciones.CargarMensajes();
                Mensajes mensajeSeleccionado = mensajes.FirstOrDefault(m => m.NombreMensaje == nombreMensaje);

                if (mensajeSeleccionado != null)
                {
                    Funciones.EliminarMensaje(mensajeSeleccionado);
                    CargarMensajes();
                    MessageBox.Show("Mensaje eliminado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El mensaje seleccionado no fue encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un mensaje para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pbMensajesRegresarUser_Click(object sender, EventArgs e)
        {
            VistaGeneralUsuario vistaGeneralUsuario = new VistaGeneralUsuario();
            vistaGeneralUsuario.Show();
            this.Close();
        }
    }
}
