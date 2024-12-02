﻿using ProyectoFinal.Clases;
using ProyectoFinal.Servicios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

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
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            InicioSesiónUsuario inicioSesiónUsuario = new InicioSesiónUsuario();
            inicioSesiónUsuario.Show();
            this.Close();


        }
        private void btnExaminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEventos.SelectedRows.Count > 0) // Verificamos si se ha seleccionado una fila en el DataGridView
                {
                    // Verificamos si el valor de la primera celda de la fila seleccionada no es null
                    var valorCelda = dgvEventos.SelectedRows[0].Cells[0].Value;
                    if (valorCelda == null)
                    {
                        MessageBox.Show("El evento seleccionado no tiene un nombre válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Detenemos la ejecución si el valor es null
                    }

                    // Obtenemos el nombre del evento seleccionado en el DataGridView
                    string nombreEvento = valorCelda.ToString();

                    // Cargamos los eventos desde el archivo o fuente de datos
                    List<Eventos> eventos = Funciones.CargarEventos();

                    // Buscamos el evento seleccionado a través del nombre del evento
                    Eventos eventoSeleccionado = eventos.FirstOrDefault(evento => evento.NombreEvento == nombreEvento);

                    // Si el evento existe, cargamos sus detalles en el formulario DetalleEventoForm
                    if (eventoSeleccionado != null)
                    {
                        DetalleEventoForm detalleForm = new DetalleEventoForm
                        {
                            EventoSeleccionado = eventoSeleccionado // Asigna el evento seleccionado
                        };

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
            catch (Exception ex)
            {
                // Captura de cualquier error inesperado y muestra un mensaje
                MessageBox.Show($"Se produjo un error al intentar mostrar el evento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void pbMensajes_Click(object sender, EventArgs e)
        {
            MensajesUsuario mensajesUsuario = new MensajesUsuario();
            mensajesUsuario.Show();
            this.Close();
        }

        private bool menuExpandido = true;
        private void btnToggleMenu_Click(object sender, EventArgs e)
        {
            if (menuExpandido)
            {
                guna2PanelMenu.Width = 40; // Reducir el ancho del panel
                menuExpandido = false;

                // Ocultar texto de los botones
                foreach (Control control in guna2PanelMenu.Controls)
                {
                    if (control is Guna.UI2.WinForms.Guna2Button button)
                    {
                        button.Text = ""; // Ocultar el texto
                        button.ImageAlign = HorizontalAlignment.Center; // Centrar los íconos
                    }
                }
            }
            else
            {
                guna2PanelMenu.Width = 187; // Expandir el ancho del panel
                menuExpandido = true;

                // Restaurar texto de los botones
                foreach (Control control in guna2PanelMenu.Controls)
                {
                    if (control is Guna.UI2.WinForms.Guna2Button button)
                    {
                        button.Text = button.Tag.ToString(); // Recuperar texto del botón desde su Tag
                        button.ImageAlign = HorizontalAlignment.Left; // Restaurar la alineación de los íconos
                    }
                }
            }

        }
    }
}
