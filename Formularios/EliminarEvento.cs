using ProyectoFinal.Clases;
using ProyectoFinal.Servicios;
using System;
using System.Windows.Forms;

namespace ProyectoFinal.Formularios
{
    public partial class EliminarEvento : MetroFramework.Forms.MetroForm
    {
        private Eventos evento;

        public EliminarEvento(Eventos eventoSeleccionado)
        {
            InitializeComponent();
            evento = eventoSeleccionado;
            CargarDetalles();
        }

        private void CargarDetalles()
        {
            // Muestra los detalles del evento
            txtNombreEvento.Text = evento.NombreEvento;
            txtDescripcion.Text = evento.Descripción;
            txtCategoria.Text = evento.Categoría;
            mtxtFechaEvento.Text = evento.Fecha.ToString("dd/MM/yyyy");
            txtTipoPublico.Text = evento.TipoPúblico;
            txtCuposDisp.Text = evento.CuposDisp.ToString();
            mtxtHInicio.Text = $"{evento.HoraInicio:00}:00";
            mtxtHFin.Text = $"{evento.HoraFin:00}:00";

            // Deshabilita la edición
            txtNombreEvento.ReadOnly = true;
            txtDescripcion.ReadOnly = true;
            txtCategoria.ReadOnly = true;
            mtxtFechaEvento.ReadOnly = true;
            txtTipoPublico.ReadOnly = true;
            txtCuposDisp.ReadOnly = true;
            mtxtHInicio.ReadOnly = true;
            mtxtHFin.ReadOnly = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show("¿Estás seguro de que deseas eliminar este evento?",
                                               "Confirmar eliminación",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                Funciones.EliminarEvento(evento); // Llama a la función para eliminar
                MessageBox.Show("Evento eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
