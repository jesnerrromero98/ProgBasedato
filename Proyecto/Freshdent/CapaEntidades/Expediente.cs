using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Expediente
    {
        public int IdExpediente { get; set; }
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public int Telefono_Celular { get; set; }
        public string Municipio { get; set; }
        public string Departamento { get; set; }
    }
}
