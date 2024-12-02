using ProyectoFinal.Clases;
using ProyectoFinal.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
        }
    }
}

