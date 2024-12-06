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
    public partial class EventosPorCategoria : MetroFramework.Forms.MetroForm
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

                if (listaDeEventos == null || listaDeEventos.Count == 0)
                {
                    MessageBox.Show("No hay eventos disponibles para generar el reporte.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Configurar el ReportViewer
                string rutaReporte = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reportes", "EventosPorCategoria.rdlc");

                if (!File.Exists(rutaReporte))
                {
                    MessageBox.Show($"No se encontró el archivo del reporte en la ruta: {rutaReporte}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                reportViewer1.LocalReport.ReportPath = rutaReporte;
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

        bool menuExpandido = false;

        private void btnToggleMenu_Click_1(object sender, EventArgs e)
        {
            FuncionesVarias.ToggleMenu(guna2PanelMenu, menuExpandido);
            menuExpandido = !menuExpandido; // Cambiar el estado del menú
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

