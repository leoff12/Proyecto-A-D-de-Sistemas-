using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal;
using ProyectoFinal.Clases;
using ProyectoFinal.Servicios;
using System.IO;

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
            List<Eventos> eventos = Funciones.CargarEventos();

            // Limpiar cualquier fila existente
            dgvEventos.Rows.Clear();

            if (eventos != null && eventos.Count > 0)
            {
                // Agregar los eventos al DataGridView
                foreach (var evento in eventos)
                {
                    // Suponiendo que la primera columna en el DataGridView es para el ID del evento
                    dgvEventos.Rows.Add(evento.NombreEvento, evento.Descripción, evento.Fecha.ToString("dd/MM/yyyy"));
                }
            }
            else
            {
                MessageBox.Show("No se encontraron eventos en el archivo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtBuscarEvento_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            
            this.Close();
           

        }

        private void dgvEventos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEventos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            if (dgvEventos.SelectedRows.Count > 0) // Verificamos si se ha seleccionado una fila en el DataGridView
            {
                // Obtenemos el nombre del evento seleccionado en el DataGridView
                string nombreEvento = dgvEventos.SelectedRows[0].Cells[0].Value.ToString();

                // Cargamos los eventos desde el archivo o fuente de datos
                List<Eventos> eventos = Funciones.CargarEventos();

                // Buscamos el evento seleccionado a través del nombre del evento
                Eventos eventoSeleccionado = eventos.FirstOrDefault(evento => evento.NombreEvento == nombreEvento);

                // Si el evento existe, cargamos sus detalles en el formulario DetalleEventoForm
                if (eventoSeleccionado != null)
                {
                    DetalleEventoForm detalleForm = new DetalleEventoForm();
                    // Asignar los valores de los campos del evento seleccionado a las propiedades públicas
                    detalleForm.nombreEvento = eventoSeleccionado.NombreEvento;
                    detalleForm.descripcionEvento = eventoSeleccionado.Descripción;
                    detalleForm.categoriaEvento = eventoSeleccionado.Categoría;
                    detalleForm.fechaEvento = eventoSeleccionado.Fecha.ToString("dd/MM/yyyy");
                    detalleForm.cuposDispEvento = eventoSeleccionado.CuposDisp.ToString();
                    detalleForm.horaInicioEvento = $"{eventoSeleccionado.HoraInicio:00}:00";
                    detalleForm.horaFinEvento = $"{eventoSeleccionado.HoraFin:00}:00";

                    // Construir la ruta completa de la imagen
                    if (!string.IsNullOrEmpty(eventoSeleccionado.ImagenSeleccionada))
                    {
                        string rutaImagen = Path.Combine(
                            Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName,
                            "Imagenes",
                            eventoSeleccionado.ImagenSeleccionada
                        );

                        // Cargar la imagen del evento en el PictureBox si la ruta es válida
                        if (File.Exists(rutaImagen))
                        {
                            try
                            {
                                detalleForm.imagenEvento = Image.FromFile(rutaImagen);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                detalleForm.imagenEvento = null; // En caso de error, limpiar el PictureBox
                            }
                        }
                        else
                        {
                            detalleForm.imagenEvento = null; // Si no hay imagen seleccionada, dejar el PictureBox vacío
                            MessageBox.Show($"La imagen no se encuentra en la ruta: {rutaImagen}", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        detalleForm.imagenEvento = null;
                    }

                    // Configurar el estado del evento basado en el tipo de pago usando FillColor
                    detalleForm.estadoPagoEvento = eventoSeleccionado.TipoDeEvento.ToUpper(); // Asigna "PAGA" o "GRATUITO"
                    detalleForm.estadoPagoFillColor = eventoSeleccionado.TipoDeEvento.ToUpper() == "PAGA" ? Color.Red : Color.Green;
                    detalleForm.estadoPagoColorTexto = Color.White; // El color del texto será blanco

                    // Mostrar el formulario DetalleEventoForm
                    detalleForm.ShowDialog();
                }
                else
                {
                    // Si no se encuentra el evento, mostrar un mensaje de error
                    MessageBox.Show("Evento no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Si no se ha seleccionado ningún evento en el DataGridView
                MessageBox.Show("Por favor, seleccione un evento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
