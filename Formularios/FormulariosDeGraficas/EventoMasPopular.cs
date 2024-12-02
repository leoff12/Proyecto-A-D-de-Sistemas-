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
    public partial class EventoMasPopular : MetroFramework.Forms.MetroForm
    {
        public EventoMasPopular()
        {
            InitializeComponent();
        }

        private void EventoMasPopular_Load(object sender, EventArgs e)
        {
            try
            {
                List<Eventos> eventos = Funciones.CargarEventos();

                if (eventos.Count == 0)
                {
                    MessageBox.Show("No hay eventos cargados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Agrupar por categoría y contar
                var categorias = eventos.GroupBy(a => a.Categoría)
                                        .Select(g => new { Categoría = g.Key, Cantidad = g.Count() })
                                        .OrderByDescending(c => c.Cantidad);

                chartCategorias.Series.Clear();
                Series serie = new Series("Categorías")
                {
                    ChartType = SeriesChartType.Pie
                };

                listBoxCategorias.Items.Clear();
                foreach (var categoria in categorias)
                {
                    serie.Points.AddXY(categoria.Categoría, categoria.Cantidad);
                    listBoxCategorias.Items.Add($"{categoria.Categoría}: {categoria.Cantidad} evento(s)");
                }

                chartCategorias.Series.Add(serie);
                chartCategorias.Titles.Clear();
                chartCategorias.Titles.Add("Eventos por Categoría");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la gráfica: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbRegresarEventoMasPopular_Click(object sender, EventArgs e)
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

