using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.Formularios.FormulariosReportes;
using ProyectoFinal.Servicios;

namespace ProyectoFinal.Formularios
{
    public partial class Reportes : MetroFramework.Forms.MetroForm
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void pbRegresarReportes_Click(object sender, EventArgs e)
        {
            FrmAdmin frmAdmin = new FrmAdmin();
            frmAdmin.Show();
            this.Close();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            EventosPorCategoria eventosPorCategoria = new EventosPorCategoria();
            eventosPorCategoria.Show();
            this.Close();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {

        }

        bool menuExpandido = false;
        private void btnToggleMenu_Click_1(object sender, EventArgs e)
        {
            FuncionesVarias.ToggleMenu(guna2PanelMenu, menuExpandido);
            menuExpandido = !menuExpandido; // Cambiar el estado del menú
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            AdminLoginForm adminLoginForm = new AdminLoginForm();
            adminLoginForm.Show();
            this.Close();
        }

        private void pbMensajes_Click(object sender, EventArgs e)
        {
            MensajesAdministrador mensajesAdministrador = new MensajesAdministrador();
            mensajesAdministrador.Show();
            this.Close();
        }

    }
}
