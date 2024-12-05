using Guna.UI2.WinForms;
using ProyectoFinal.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Servicios
{
    public static class DatosEnControlesCargar
    {
        // Método para cargar los datos en los controles del formulario EditarEvento
        public static void CargarDatosEnControles(ComboBox cmbTipoDeEventoMod, ComboBox cmbCategoriaMod, TextBox txtNombreEvento, 
                                                  Guna2TextBox txtDescripcion, ComboBox cmbTipoDeEvento, MaskedTextBox mtxtFechaEvento, 
                                                  Guna2ComboBox cmbCategoria, Guna2TextBox txtCuposDisp, MaskedTextBox mtxtHInicio, 
                                                  MaskedTextBox mtxtHFin, ComboBox cmbImagen, CheckBox chkAccesibleMod, Eventos eventoOriginal)
        {
            // Validación y carga de valores para cmbTipoDeEventoMod
            if (cmbTipoDeEventoMod.Items.Count == 0)
            {
                cmbTipoDeEventoMod.Items.Add("PAGA");
                cmbTipoDeEventoMod.Items.Add("GRATUITO");
            }

            // Validación y carga de valores para cmbCategoriaMod
            if (cmbCategoriaMod.Items.Count == 0)
            {
                cmbCategoriaMod.Items.Add("Deportes");
                cmbCategoriaMod.Items.Add("Cultura");
                cmbCategoriaMod.Items.Add("Educación");
            }

            // Asigna los valores a los controles desde el objeto eventoOriginal
            txtNombreEvento.Text = eventoOriginal.NombreEvento;
            txtDescripcion.Text = eventoOriginal.Descripción;
            cmbTipoDeEventoMod.SelectedItem = eventoOriginal.TipoDeEvento;
            mtxtFechaEvento.Text = eventoOriginal.Fecha.ToString("dd/MM/yyyy");
            cmbCategoriaMod.SelectedItem = eventoOriginal.Categoría;
            txtCuposDisp.Text = eventoOriginal.CuposDisp.ToString();
            mtxtHInicio.Text = $"{eventoOriginal.HoraInicio:00}:00";
            mtxtHFin.Text = $"{eventoOriginal.HoraFin:00}:00";
            cmbImagen.SelectedItem = eventoOriginal.ImagenSeleccionada;
            chkAccesibleMod.Checked = eventoOriginal.Accesible;
        }
    }
}
