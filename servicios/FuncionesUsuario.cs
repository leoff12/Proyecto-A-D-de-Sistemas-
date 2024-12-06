using ProyectoFinal.Clases;
using ProyectoFinal.Formularios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Servicios
{
    public static class FuncionesUsuario
    {
        public static void MostrarDetallesEvento(DataGridView dgvEventos)
        {
            try
            {
                if (dgvEventos.SelectedRows.Count > 0)
                {
                    var valorCelda = dgvEventos.SelectedRows[0].Cells[0].Value;
                    if (valorCelda == null)
                    {
                        MessageBox.Show("El evento seleccionado no tiene un nombre válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string nombreEvento = valorCelda.ToString();
                    List<Eventos> eventos = Funciones.CargarEventos();
                    Eventos eventoSeleccionado = eventos.FirstOrDefault(evento => evento.NombreEvento == nombreEvento);

                    if (eventoSeleccionado != null)
                    {
                        DetalleEventoForm detalleForm = new DetalleEventoForm
                        {
                            EventoSeleccionado = eventoSeleccionado,
                            nombreEvento = eventoSeleccionado.NombreEvento,
                            descripcionEvento = eventoSeleccionado.Descripción,
                            categoriaEvento = eventoSeleccionado.Categoría,
                            fechaEvento = eventoSeleccionado.Fecha.ToString("dd/MM/yyyy"),
                            cuposDispEvento = eventoSeleccionado.CuposDisp.ToString(),
                            horaInicioEvento = $"{eventoSeleccionado.HoraInicio:00}:00",
                            horaFinEvento = $"{eventoSeleccionado.HoraFin:00}:00"
                        };

                        if (!string.IsNullOrEmpty(eventoSeleccionado.ImagenSeleccionada))
                        {
                            string rutaImagen = Path.Combine(
                           AppDomain.CurrentDomain.BaseDirectory,
                           "Imagenes",
                           eventoSeleccionado.ImagenSeleccionada
                           );

                            if (File.Exists(rutaImagen))
                            {
                                try
                                {
                                    detalleForm.imagenEvento = Image.FromFile(rutaImagen);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    detalleForm.imagenEvento = null;
                                }
                            }
                            else
                            {
                                detalleForm.imagenEvento = null;
                                MessageBox.Show($"La imagen no se encuentra en la ruta: {rutaImagen}", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            detalleForm.imagenEvento = null;
                        }

                        detalleForm.estadoPagoEvento = eventoSeleccionado.TipoDeEvento.ToUpper();
                        detalleForm.estadoPagoFillColor = eventoSeleccionado.TipoDeEvento.ToUpper() == "PAGA" ? Color.Red : Color.Green;
                        detalleForm.estadoPagoColorTexto = Color.White;

                        detalleForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Evento no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un evento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error al intentar mostrar el evento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
