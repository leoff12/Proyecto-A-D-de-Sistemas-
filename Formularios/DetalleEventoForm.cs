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
    public partial class DetalleEventoForm : MetroFramework.Forms.MetroForm
    {
        public DetalleEventoForm()
        {
            InitializeComponent();
        }
        public string nombreEvento
    {
        get { return lblNombreEvento.Text; }
        set { lblNombreEvento.Text = value; }
    }

    // Propiedad para el TextBox descripcionEvento
    public string descripcionEvento
    {
        get { return txtDescripcionEvento.Text; }
        set { txtDescripcionEvento.Text = value; }
    }

    // Propiedad para el TextBox categoriaEvento
    public string categoriaEvento
    {
        get { return txtCategoriaEvento.Text; }
        set { txtCategoriaEvento.Text = value; }
    }

    // Propiedad para el MaskedTextBox fechaEvento
    public string fechaEvento
    {
        get { return mtxFechaEvento.Text; }
        set { mtxFechaEvento.Text = value; }
    }

    // Propiedad para el TextBox cuposDispEvento
    public string cuposDispEvento
    {
        get { return txtCuposDispEvento.Text; }
        set { txtCuposDispEvento.Text = value; }
    }

    // Propiedad para el MaskedTextBox horaInicioEvento
    public string horaInicioEvento
    {
        get { return mtxHoraInicioEvento.Text; }
        set { mtxHoraInicioEvento.Text = value; }
    }

    // Propiedad para el MaskedTextBox horaFinEvento
    public string horaFinEvento
    {
        get { return mtxHoraFinEvento.Text; }
        set { mtxHoraFinEvento.Text = value; }
    }

    // Propiedad para el PictureBox de la imagen del evento
    public Image imagenEvento
    {
        get { return pbDetallesImagenEvento.Image; }
        set { pbDetallesImagenEvento.Image = value; }
    }

    // Propiedad para el TextBox estadoPagoEvento
    public string estadoPagoEvento
    {
        get { return txtEstadoPagoEvento.Text; }
        set { txtEstadoPagoEvento.Text = value; }
    }

        // Propiedad para cambiar el color de fondo de txtEstadoPagoEvento (PAGA o GRATUITO)
        public Color estadoPagoFillColor
        {
            get { return txtEstadoPagoEvento.FillColor; }
            set { txtEstadoPagoEvento.FillColor = value; }
        }

        public Color estadoPagoColorTexto
        {
            get { return txtEstadoPagoEvento.ForeColor; }
            set { txtEstadoPagoEvento.ForeColor = value; }
        }

        private void DetalleEventoForm_Load(object sender, EventArgs e)
        {

        }

        private void txtDetallesEvento_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvEventos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblCuposDispEvento_Click(object sender, EventArgs e)
        {

        }
    }
}
