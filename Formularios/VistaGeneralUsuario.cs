﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal;

namespace ProyectoFinal.Formularios
{
    public partial class VistaGeneralUsuario : MetroFramework.Forms.MetroForm
    {
        public VistaGeneralUsuario()
        {
            InitializeComponent();
        }

        private void VistaGeneralUsuario_Load(object sender, EventArgs e)
        {

        }

        private void txtBuscarEvento_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            
            this.Close();
           

        }
    }
}
