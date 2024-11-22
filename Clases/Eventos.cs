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
        public string NombreEvento { get; set; }

        public string Descripción { get; set; }

        public int HoraInicio { get; set; }

        public int HoraFin { get; set; }

        public int Fecha { get; set; }

        public int CuposDisp { get; set; }

        public int CuposOcup { get; set; }

        public string Categoría { get; set; }

        public string TipoPúblico { get; set; }

        public string ImagenSeleccionada { get; set; }

    }
}
