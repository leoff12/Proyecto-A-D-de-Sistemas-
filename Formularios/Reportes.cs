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

namespace ProyectoFinal.Formularios
{
    public partial class Reportes : Form
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
    }
}
