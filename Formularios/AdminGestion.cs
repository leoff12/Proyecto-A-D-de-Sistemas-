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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AgregarEvento agregarEvento = new AgregarEvento();

            agregarEvento.Show();

            this.Close();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
