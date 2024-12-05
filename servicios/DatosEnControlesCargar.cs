using Guna.UI2.WinForms;
using ProyectoFinal.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.Clases;


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

        public static void CargarDetalles(Eventos eventoSeleccionado, ComboBox cmbTipoDeEventoElim, ComboBox cmbCategoriaElim, TextBox txtNombreEvento, Guna2TextBox txtDescripcion, MaskedTextBox mtxtFechaEvento, Guna2TextBox txtCuposDisp, MaskedTextBox mtxtHInicio, MaskedTextBox mtxtHFin, CheckBox chkAccesibleElim, ComboBox cmbImagen, PictureBox pbImagen)
        {
            // Asegurarse de que el tipo de evento esté en la lista del ComboBox
            if (!cmbTipoDeEventoElim.Items.Contains(eventoSeleccionado.TipoDeEvento) && !cmbCategoriaElim.Items.Contains(eventoSeleccionado.TipoDeEvento))
            {
                cmbTipoDeEventoElim.Items.Add(eventoSeleccionado.TipoDeEvento);
                cmbCategoriaElim.Items.Add(eventoSeleccionado.Categoría);
            }

            // Cargar los datos en los controles
            cmbTipoDeEventoElim.Text = eventoSeleccionado.TipoDeEvento;
            cmbTipoDeEventoElim.Enabled = false; // Deshabilita la opción de cambio
            txtNombreEvento.Text = eventoSeleccionado.NombreEvento;
            txtDescripcion.Text = eventoSeleccionado.Descripción;
            mtxtFechaEvento.Text = eventoSeleccionado.Fecha.ToString("dd/MM/yyyy");
            cmbCategoriaElim.Text = eventoSeleccionado.Categoría;
            cmbCategoriaElim.Enabled = false; // Deshabilita la opción de cambio
            txtCuposDisp.Text = eventoSeleccionado.CuposDisp.ToString();
            mtxtHInicio.Text = $"{eventoSeleccionado.HoraInicio:00}:00";
            mtxtHFin.Text = $"{eventoSeleccionado.HoraFin:00}:00";
            chkAccesibleElim.Checked = eventoSeleccionado.Accesible;

            // Deshabilitar la edición de los controles
            txtNombreEvento.ReadOnly = true;
            txtDescripcion.ReadOnly = true;
            cmbTipoDeEventoElim.DropDownStyle = ComboBoxStyle.DropDownList;
            mtxtFechaEvento.ReadOnly = true;
            cmbCategoriaElim.DropDownStyle = ComboBoxStyle.DropDownList;
            txtCuposDisp.ReadOnly = true;
            mtxtHInicio.ReadOnly = true;
            mtxtHFin.ReadOnly = true;

            // Cargar la imagen en el ComboBox y el PictureBox
            cmbImagen.Items.Clear();
            if (!string.IsNullOrEmpty(eventoSeleccionado.ImagenSeleccionada))
            {
                cmbImagen.Items.Add(eventoSeleccionado.ImagenSeleccionada);
                cmbImagen.SelectedIndex = 0; // Selecciona automáticamente la imagen del evento
                CargarImagen.CargarImagenEnPictureBox(eventoSeleccionado.ImagenSeleccionada, pbImagen);
            }
        }
    }
}
