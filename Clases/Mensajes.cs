using System;

namespace ProyectoFinal.Clases
{
    [Serializable]
    public class Mensajes
    {
        public int IDMensaje { get; set; }
        public string NombreMensaje { get; set; }
        public DateTime FechaMensaje { get; set; }
        public DateTime FechaEnvio { get; set; }
        public string Estado { get; set; } // Aprobada, Rechazada, En espera de contestación
    }
}
