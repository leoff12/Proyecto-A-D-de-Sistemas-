using ProyectoFinal.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.Servicios;

namespace ProyectoFinal.Formularios
{
    public partial class DetalleEventoForm : MetroFramework.Forms.MetroForm
    {
        public Eventos EventoSeleccionado { get; set; }
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
            ActualizarBotonReservar(EventoSeleccionado.EstadoReservación);
        }

        private void pbDetallesRegresar_Click(object sender, EventArgs e)
        {
            VistaGeneralUsuario vistaGeneralUsuario = new VistaGeneralUsuario();
            vistaGeneralUsuario.Show();
            this.Close();
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            try
            {
                if (EventoSeleccionado.Accesible)
                {
                    if (EventoSeleccionado.CuposDisp > 0)
                    {
                        EventoSeleccionado.CuposDisp--;
                        EventoSeleccionado.EstadoReservación = 2; // Aprobada
                        btnReservar.FillColor = Color.Green;
                        btnReservar.Text = "Aprobada";
                        Funciones.ActualizarEvento(EventoSeleccionado);
                    }
                    else
                    {
                        MessageBox.Show("No hay cupos disponibles.");
                    }
                }
                else
                {
                    EventoSeleccionado.EstadoReservación = 1; // En espera
                    btnReservar.FillColor = Color.Gray;
                    btnReservar.Text = "En espera";

                    Mensajes nuevoMensaje = new Mensajes
                    {
                        NombreMensaje = EventoSeleccionado.NombreEvento,
                        FechaMensaje = EventoSeleccionado.Fecha,
                        FechaEnvio = DateTime.Now,
                        Estado = "En espera de contestación"
                    };
                    Funciones.GuardarMensaje(nuevoMensaje);
                    Funciones.ActualizarEvento(EventoSeleccionado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnularReservacion_Click(object sender, EventArgs e)
        {
            
                if (EventoSeleccionado.EstadoReservación == 2 && !EventoSeleccionado.Accesible)
                {
                    // Restaurar un cupo disponible
                    EventoSeleccionado.CuposDisp++;
                    EventoSeleccionado.EstadoReservación = 0; // Estado "Reservar"

                    // Actualizar la lista de mensajes eliminando el mensaje relacionado con el evento
                    var mensajes = Funciones.CargarMensajes();
                    Mensajes mensajeRelacionado = mensajes.FirstOrDefault(m => m.NombreMensaje == EventoSeleccionado.NombreEvento);

                    if (mensajeRelacionado != null)
                    {
                        Funciones.EliminarMensaje(mensajeRelacionado);
                    }

                    // Actualizar el estado del botón de reservación y guardar cambios en el evento
                    ActualizarBotonReservar(EventoSeleccionado.EstadoReservación);
                    Funciones.ActualizarEvento(EventoSeleccionado);
                }
                if(EventoSeleccionado.EstadoReservación == 1)
                {
                    EventoSeleccionado.EstadoReservación = 0;
                    var mensajes = Funciones.CargarMensajes();
                    Mensajes mensajeRelacionado = mensajes.FirstOrDefault(m => m.NombreMensaje == EventoSeleccionado.NombreEvento);

                    if (mensajeRelacionado != null)
                    {
                        Funciones.EliminarMensaje(mensajeRelacionado);
                    }
                    // Actualizar el estado del botón de reservación y guardar cambios en el evento
                    ActualizarBotonReservar(EventoSeleccionado.EstadoReservación);
                    Funciones.ActualizarEvento(EventoSeleccionado);
                }
                if (EventoSeleccionado.EstadoReservación == 2 && EventoSeleccionado.Accesible)
                {
                    EventoSeleccionado.CuposDisp++;
                    EventoSeleccionado.EstadoReservación = 0;


                    // Actualizar el estado del botón de reservación y guardar cambios en el evento
                    ActualizarBotonReservar(EventoSeleccionado.EstadoReservación);
                    Funciones.ActualizarEvento(EventoSeleccionado);
                }
        }
        private void ActualizarBotonReservar(int estado)
        {
            switch (estado)
            {
                case 0:
                    btnReservar.FillColor = Color.Blue;
                    btnReservar.Text = "Reservar";
                    btnReservar.Enabled = true;
                    break;
                case 1:
                    btnReservar.FillColor = Color.Gray;
                    btnReservar.Text = "En espera";
                    btnReservar.Enabled = false;
                    break;
                case 2:
                    btnReservar.Text = "Aprobada";
                    btnReservar.Enabled = true;
                    btnReservar.FillColor = Color.Green;
                    btnReservar.ForeColor = Color.White;
                    break;
                case 3:
                    btnReservar.Text = "Rechazada";
                    btnReservar.Enabled = false;
                    btnReservar.FillColor = Color.Red;
                    btnReservar.ForeColor = Color.White;
                    break;
                case 4:
                    btnReservar.FillColor = Color.Gray;
                    btnReservar.Text = "En espera";
                    btnReservar.Enabled = false;
                    break;

            }
        }

        private void pbMensajes_Click(object sender, EventArgs e)
        {
            MensajesUsuario mensajesUsuario = new MensajesUsuario();
            mensajesUsuario.Show();
            this.Close();
        }

        private void btnCerrarSesiónAdmin_Click(object sender, EventArgs e)
        {
            InicioSesiónUsuario inicioSesiónUsuario = new InicioSesiónUsuario();
            inicioSesiónUsuario.Show();
            this.Close();
        }

        private bool menuExpandido = false;
        private void btnToggleMenu_Click(object sender, EventArgs e)
        {
            FuncionesVarias.ToggleMenu(guna2PanelMenu, menuExpandido);
            menuExpandido = !menuExpandido; // Cambiar el estado del menú
        }
    }
    
}
