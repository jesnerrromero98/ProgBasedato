using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Cita
    {
        public int IdCita { get; set; }
        public DateTime FechaCita { get; set; }
        public DateTime HoraDisponible { get; set; }
        public int Precio { get; set; }
        public string Tipo { get; set; }
        public int IdExpediente { get; set; }
        public int IdMedico { get; set; }
    }
}
