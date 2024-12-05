using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Servicios
{
    public static class ValidarFormularios
    {
        public static bool ValidarFormulario(ComboBox cmbImagen, TextBox txtNombreEvento, Guna2TextBox txtDescripcion, ComboBox cmbTipoDeEvento,
                                             MaskedTextBox mtxtFechaEvento, ComboBox cmbCategoria, Guna2TextBox txtCuposDisp, MaskedTextBox mtxtHInicio, MaskedTextBox mtxtHFin)
        {
            // Verificar campos vacíos
            if (string.IsNullOrWhiteSpace(txtNombreEvento.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(cmbTipoDeEvento.Text) ||
                string.IsNullOrWhiteSpace(mtxtFechaEvento.Text) ||
                string.IsNullOrWhiteSpace(cmbCategoria.Text) ||
                string.IsNullOrWhiteSpace(txtCuposDisp.Text) ||
                string.IsNullOrWhiteSpace(mtxtHInicio.Text) ||
                string.IsNullOrWhiteSpace(mtxtHFin.Text) ||
                cmbImagen.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar formato y valor de la fecha
            if (!DateTime.TryParseExact(mtxtFechaEvento.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fechaEvento))
            {
                MessageBox.Show("La fecha debe tener un formato válido (dd/MM/yyyy).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar que la fecha del evento no sea menor que la actual
            if (fechaEvento < DateTime.Now.Date)
            {
                MessageBox.Show("La fecha del evento no puede ser menor que la fecha actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar que CuposDisponibles sea un número entero positivo
            if (!int.TryParse(txtCuposDisp.Text, out int cuposDisp) || cuposDisp <= 0)
            {
                MessageBox.Show("Los cupos disponibles deben ser un número entero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar formato de la hora
            if (!mtxtHInicio.MaskCompleted || !mtxtHFin.MaskCompleted)
            {
                MessageBox.Show("Las horas deben tener el formato HH:mm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string[] horaInicioParts = mtxtHInicio.Text.Split(':');
            string[] horaFinParts = mtxtHFin.Text.Split(':');

            if (horaInicioParts.Length == 2 && horaFinParts.Length == 2)
            {
                int horaInicioInt = int.Parse(horaInicioParts[0]);
                int minutoInicioInt = int.Parse(horaInicioParts[1]);
                int horaFinInt = int.Parse(horaFinParts[0]);
                int minutoFinInt = int.Parse(horaFinParts[1]);

                // Verificar que la hora de inicio sea menor que la hora de fin
                if (horaInicioInt > horaFinInt || (horaInicioInt == horaFinInt && minutoInicioInt >= minutoFinInt))
                {
                    MessageBox.Show("La hora de inicio debe ser menor que la hora de fin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            // Validar que se seleccionó una imagen
            if (cmbImagen.SelectedItem == null || string.IsNullOrWhiteSpace(cmbImagen.SelectedItem.ToString()))
            {
                MessageBox.Show("Por favor, seleccione una imagen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Si todas las validaciones pasan
            return true;
        }
    }
}
 