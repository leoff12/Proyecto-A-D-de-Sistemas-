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
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoFinal.Formularios.FormulariosDeGraficas
{
    public partial class MayorTipoEvento : MetroFramework.Forms.MetroForm
    {
        public MayorTipoEvento()
        {
            InitializeComponent();
        }

        private void chartCategorias_Click(object sender, EventArgs e)
        {

        }

        private void MayorTipoEvento_Load(object sender, EventArgs e)
        {
            try
            {
                List<Eventos> eventos = Funciones.CargarEventos();

                if (eventos.Count == 0)
                {
                    MessageBox.Show("No hay eventos cargados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Agrupar por tipo de evento y contar
                var tipos = eventos.GroupBy(a => a.TipoDeEvento)
                                   .Select(g => new { Tipo = g.Key, Cantidad = g.Count() })
                                   .OrderByDescending(t => t.Cantidad);

                chartTipoEvento.Series.Clear();
                Series serie = new Series("Tipos")
                {
                    ChartType = SeriesChartType.Column
                };

                listBoxTipos.Items.Clear();
                foreach (var tipo in tipos)
                {
                    serie.Points.AddXY(tipo.Tipo, tipo.Cantidad);
                    listBoxTipos.Items.Add($"{tipo.Tipo}: {tipo.Cantidad} evento(s)");
                }

                chartTipoEvento.Series.Add(serie);
                chartTipoEvento.Titles.Clear();
                chartTipoEvento.Titles.Add("Eventos por Tipo");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la gráfica: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbMayorTipoEvento_Click(object sender, EventArgs e)
        {
            Gráficas gráficas = new Gráficas();
            gráficas.Show();
            this.Close();
        }

        private void tpDetalles_Click(object sender, EventArgs e)
        {

        }

        bool menuExpandido = false;
        private void btnToggleMenu_Click_1(object sender, EventArgs e)
        {
            FuncionesVarias.ToggleMenu(guna2PanelMenu, menuExpandido);
            menuExpandido = !menuExpandido; // Cambiar el estado del menú
        }

        private void pbMensajesAdmin(object sender, EventArgs e)
        {
            MensajesAdministrador mensajesAdministrador = new MensajesAdministrador();
            mensajesAdministrador.Show();
            this.Close();
        }

        private void pbMensajes_Click(object sender, EventArgs e)
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

    }
}
