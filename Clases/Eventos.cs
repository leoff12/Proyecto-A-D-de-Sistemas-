using System;


namespace ProyectoFinal.Clases
{
    [Serializable]
    public class Eventos
    {
        public int ID { get; set; }
        public string NombreEvento { get; set; }
        public string Descripción { get; set; }
        public string TipoDeEvento { get; set; }
        public DateTime Fecha { get; set; } // Cambiado a DateTime
        public string Categoría { get; set; }
        public int CuposDisp { get; set; }
        public int HoraInicio { get; set; }
        public int HoraFin { get; set; }
        public string ImagenSeleccionada { get; set; }
        public bool Accesible { get; set; }
        public int EstadoReservación { get; set; } // 0 = Base, 1 = En espera, 2 = Aprobada, 3 = Rechazada
    }
}
