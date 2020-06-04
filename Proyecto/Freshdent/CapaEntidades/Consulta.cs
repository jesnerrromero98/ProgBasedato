using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Consulta
    {
        public int IdConsulta { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public string Sintoma { get; set; }
        public string Diagnostico { get; set; }
        public int IdExpediente { get; set; }
        public int IdMedico { get; set; }
    }
}
