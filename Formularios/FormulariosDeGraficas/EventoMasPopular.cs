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
    public partial class EventoMasPopular : MetroFramework.Forms.MetroForm
    {
        public EventoMasPopular()
        {
            InitializeComponent();
        }

        private void chartCategorias_Click(object sender, EventArgs e)
        {

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

                // Personalización de etiquetas en la gráfica
                serie.Label = "#VALY"; // Muestra la cantidad de eventos dentro de cada campo
                serie.LegendText = "#VALX"; // Muestra la categoría en la leyenda
                serie["PieLabelStyle"] = "Inside"; // Coloca las etiquetas dentro del gráfico
                serie["PieLineColor"] = "Transparent"; // Elimina las líneas de las etiquetas

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
    }
}
