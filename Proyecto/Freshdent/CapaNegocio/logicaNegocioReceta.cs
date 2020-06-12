using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class logicaNegocioReceta
    {
        accesoDatosReceta adR = new accesoDatosReceta();

        public int insertarReceta(Receta rc)
        {
            return adR.insertarReceta(rc);
        }
        public List<Receta> listarReceta()
        {
            return adR.listarReceta();
        }
        public int eliminarReceta(int IdRec)
        {
            return adR.eliminarReceta(IdRec);
        }
    }
}
