using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class logicaNegocioMedico
    {
        accesoDatosMedico adM = new accesoDatosMedico();

        public int insertarMedico(Medico md)
        {
            return adM.insertarMedico (md);
        }
        public List<Medico> listarMedico()
        {
            return adM.listarMedico();
        }
        public int eliminarMedico(int IdMedic)
        {
            return adM.eliminarMedico(IdMedic);
        }
        public int editarMedico(Medico md)
        {
            return adM.editarMedico(md);
        }
        public List<Medico> buscarMedico(string dato)
        {
            return adM.buscarMedico(dato);
        }
    }
}
