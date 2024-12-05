using ProyectoFinal.Formularios.FormulariosDeGraficas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void Gráficas_Load(object sender, EventArgs e)
        {

        }
    }
}
