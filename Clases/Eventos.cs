using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace ProyectoFinal.Clases
{
    [Serializable]
    public class Eventos
    {
        public int ID { get; set; }
        public string NombreEvento { get; set; }
        public string Descripción { get; set; }
        public string Categoría { get; set; }
        public DateTime Fecha { get; set; } // Cambiado a DateTime
        public string TipoPúblico { get; set; }
        public int CuposDisp { get; set; }
        public int HoraInicio { get; set; }
        public int HoraFin { get; set; }
        public string ImagenSeleccionada { get; set; }
    }
}
