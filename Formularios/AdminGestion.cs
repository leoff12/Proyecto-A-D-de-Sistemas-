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



namespace ProyectoFinal.Formularios
{
    public partial class FrmAdmin : MetroFramework.Forms.MetroForm
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pbMensajes_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool menuExpandido = true;


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AgregarEvento agregarEvento = new AgregarEvento();

            agregarEvento.Show();

            this.Close();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {

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
                guna2PanelMenu.Width = 100; // Expandir el ancho del panel
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

        private void pbInicio_Click(object sender, EventArgs e)
        {

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
    }
}
