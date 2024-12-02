using ProyectoFinal.Formularios.FormulariosDeGraficas;
using System;
using System.Windows.Forms;

namespace ProyectoFinal.Formularios
{
    public partial class Gráficas : MetroFramework.Forms.MetroForm
    {
        public Gráficas()
        {
            InitializeComponent();
        }

        private void pbMensajesRegresarUser_Click(object sender, EventArgs e)
        {
            FrmAdmin frmAdmin = new FrmAdmin();
            frmAdmin.Show();
            this.Close();
        }

        private void btnEventoMasPupular_Click(object sender, EventArgs e)
        {
            EventoMasPopular eventoMasPopular = new EventoMasPopular();
            eventoMasPopular.Show();
            this.Close();
        }

        private void btnMayorTipoEvento_Click(object sender, EventArgs e)
        {
            MayorTipoEvento mayorTipoEvento = new MayorTipoEvento();
            mayorTipoEvento.Show();
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
