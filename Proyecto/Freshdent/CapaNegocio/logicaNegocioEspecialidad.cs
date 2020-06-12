﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class logicaNegocioEspecialidad
    {
        accesoDatosEspecialidad adEs = new accesoDatosEspecialidad();

        public int insertarEspecialidad(Especialidad es)
        {
            return adEs.insertarEspecialidad(es);
        }
        public List<Especialidad> listarEspecialidad()
        {
            return adEs.listarEspecialidad();
        }
        public int eliminarEspecialidad(int IdEspec)
        {
            return adEs.eliminarEspecialidad(IdEspec);
        }
        public int editarEspecialidad(Especialidad es)
        {
            return adEs.editarEspecialidad(es);
        }
        public List<Especialidad> buscarEspecialidad(string dato)
        {
            return adEs.buscarEspecialidad(dato);
        }
    }
}
