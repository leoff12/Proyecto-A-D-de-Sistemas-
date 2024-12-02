using ProyectoFinal.Formularios;
using System;


namespace ProyectoFinal
{
    public partial class UniEventHub : MetroFramework.Forms.MetroForm
    {
        public UniEventHub()
        {
            InitializeComponent();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            //Instanciar el Formulario Inicio de sesión Usuario
            InicioSesiónUsuario inicioSesiónUsuario = new InicioSesiónUsuario();
            inicioSesiónUsuario.Show();
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            //Instanciar el formulario de Inicio de sesión administrador
            AdminLoginForm adminLoginForm = new AdminLoginForm();
            adminLoginForm.Show();
        }

        private void UniEventHub_Load(object sender, EventArgs e)
        {

        }
    }
}

