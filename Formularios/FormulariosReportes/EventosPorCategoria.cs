using Microsoft.Reporting.WinForms;
using ProyectoFinal.Clases;
using ProyectoFinal.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Formularios.FormulariosReportes
{
    public partial class EventosPorCategoria : Form
    {
        public EventosPorCategoria()
        {
            InitializeComponent();
        }

        private void EventosPorCategoria_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargar los eventos desde el archivo binario
                List<Eventos> listaDeEventos = Funciones.CargarEventos();

                // Configurar el ReportViewer
                reportViewer1.LocalReport.ReportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reportes", "EventosPorCategoria.rdlc");
                reportViewer1.LocalReport.DataSources.Clear();

                // Crear el origen de datos
                ReportDataSource rds = new ReportDataSource("EventosDataSet", listaDeEventos);
                reportViewer1.LocalReport.DataSources.Add(rds);

                // Refrescar el ReportViewer para mostrar el informe
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el informe: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbRegresarReporteCategoria_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.Show();
            this.Close();
        }
    }
}
