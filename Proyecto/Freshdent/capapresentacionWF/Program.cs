using CapaPresentacionConsulta;
using CapaPresentacionEspecialidad;
using CapaPresentacionExpediente;
using CapaPresentacionMedico;
using CapaPresentacionReceta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capapresentacionWF
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           //Application.Run(new fExpediente());
            //Application.Run(new Form1());
            //   Application.Run(new fReceta());
           // Application.Run(new fMedico());
            // Application.Run(new fConsulta());
            //Application.Run(new fEspecialidad());
            Application.Run(new Login());

        }
    }
}
