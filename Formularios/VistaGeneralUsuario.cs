using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal;
using ProyectoFinal.Clases;
using ProyectoFinal.Servicios;
using System.IO;

namespace ProyectoFinal.Formularios
{
    public partial class VistaGeneralUsuario : MetroFramework.Forms.MetroForm
    {
        public VistaGeneralUsuario()
        {
            InitializeComponent();
        }

        private void VistaGeneralUsuario_Load(object sender, EventArgs e)
        {
            List<Eventos> eventos = Funciones.CargarEventos();

            // Limpiar cualquier fila existente
            dgvEventos.Rows.Clear();

            if (eventos != null && eventos.Count > 0)
            {
                // Agregar los eventos al DataGridView
                foreach (var evento in eventos)
                {
                    // Suponiendo que la primera columna en el DataGridView es para el ID del evento
                    dgvEventos.Rows.Add(evento.NombreEvento, evento.Descripción, evento.Fecha.ToString("dd/MM/yyyy"));
                }
            }
            else
            {
                MessageBox.Show("No se encontraron eventos en el archivo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            InicioSesiónUsuario inicioSesiónUsuario = new InicioSesiónUsuario();
            inicioSesiónUsuario.Show();
            this.Close();
           

        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            FuncionesUsuario.MostrarDetallesEvento(dgvEventos);
        }


        private void pbMensajes_Click(object sender, EventArgs e)
        {
            MensajesUsuario mensajesUsuario = new MensajesUsuario();
            mensajesUsuario.Show();
            this.Close();
        }

        private bool menuExpandido = false;
        private void btnToggleMenu_Click(object sender, EventArgs e)
        {
            FuncionesVarias.ToggleMenu(guna2PanelMenu, menuExpandido);
            menuExpandido = !menuExpandido; // Cambiar el estado del menú

        }

        private void dgvEventos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
