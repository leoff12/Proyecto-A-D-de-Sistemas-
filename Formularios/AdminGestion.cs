using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.Formularios;
using ProyectoFinal.Servicios;


namespace ProyectoFinal.Formularios
{
    public partial class FrmAdmin : MetroFramework.Forms.MetroForm
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AgregarEvento agregarEvento = new AgregarEvento();

            agregarEvento.Show();

            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ModificarEvento modificarEvento = new ModificarEvento();
            modificarEvento.Show();
            this.Close();
        }

        private void btnCerrarSesiónAdmin_Click(object sender, EventArgs e)
        {
            AdminLoginForm adminLoginForm = new AdminLoginForm();
            adminLoginForm.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            BuscarEliminar buscaEliminar = new BuscarEliminar();   
            buscaEliminar.Show();
            this.Close();
        }

        private bool menuExpandido = false; // Indica si el menú está expandido
       
        private void btnToggleMenu_Click(object sender, EventArgs e)
        {
            FuncionesVarias.ToggleMenu(guna2PanelMenu, menuExpandido);
            menuExpandido = !menuExpandido; // Cambiar el estado del menú
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FrmAdmin frmAdmin = new FrmAdmin();
            frmAdmin.Show();
            this.Close();
            
        }

        private void pbMensajesAdmin_Click(object sender, EventArgs e)
        {
            MensajesAdministrador mensajesAdministrador = new MensajesAdministrador();
            mensajesAdministrador.Show();
            this.Close();
        }

        private void guna2PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timerMenuAnimacion_Tick(object sender, EventArgs e)
        {

        }

        private void pbGraficas_Click(object sender, EventArgs e)
        {
            Gráficas gráficas = new Gráficas();
            gráficas.Show();
            this.Close();
        }

        private void pbReportes_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.Show();
            this.Close();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.Show();
            this.Close();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
