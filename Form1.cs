﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.Formularios;


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

        private void UniEventHub_Load_1(object sender, EventArgs e)
        {

        }
    }
}
       
