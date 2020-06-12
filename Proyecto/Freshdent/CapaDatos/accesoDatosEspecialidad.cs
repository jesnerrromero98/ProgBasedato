using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaEntidades;
using System.Data;

namespace CapaDatos
{
    public class accesoDatosEspecialidad
    {
        SqlConnection cnx;
        Especialidad es = new Especialidad();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Especialidad> listaEspecialidad = null;

        public int insertarEspecialidad(Especialidad es)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Especialid", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@IdEspecialidad", "");
                cm.Parameters.AddWithValue("@NombreEspecialidad", es.NombreEspecialidad);
                cm.Parameters.AddWithValue("@DescpEspecialidad", es.DescpEspecialidad);

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            {
                cm.Connection.Close();
            }
            return indicador;
        }

        public List<Especialidad> listarEspecialidad()
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Especialid", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@IdEspecialidad", "");
                cm.Parameters.AddWithValue("@NombreEspecialidad", "");
                cm.Parameters.AddWithValue("@DescpEspecialidad", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaEspecialidad = new List<Especialidad>();

                while (dr.Read())
                {
                    Especialidad es = new Especialidad();
                    es.IdEspecialidad = Convert.ToInt32(dr["IdEspecialidad"].ToString());
                    es.NombreEspecialidad = dr["NombreEspecialidad"].ToString();
                    es.DescpEspecialidad = dr["DescpEspecialidad"].ToString();
                    listaEspecialidad.Add(es);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaEspecialidad = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaEspecialidad;
        }

        public int eliminarEspecialidad(int IdEspec)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Especialid", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@IdEspecialidad", IdEspec);
                cm.Parameters.AddWithValue("@NombreEspecialidad", "");
                cm.Parameters.AddWithValue("@DescpEspecialidad", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            {
                cm.Connection.Close();
            }
            return indicador;
        }

        public int editarEspecialidad(Especialidad es)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Especialid", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@IdEspecialidad", es.IdEspecialidad);
                cm.Parameters.AddWithValue("@NombreEspecialidad", es.NombreEspecialidad);
                cm.Parameters.AddWithValue("@DescpEspecialidad", es.DescpEspecialidad);

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            {
                cm.Connection.Close();
            }
            return indicador;
        }

        public List<Especialidad> buscarEspecialidad(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Especialid", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@IdEspecialidad", "");
                cm.Parameters.AddWithValue("@NombreEspecialidad", dato);
                cm.Parameters.AddWithValue("@DescpEspecialidad", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaEspecialidad = new List<Especialidad>();

                while (dr.Read())
                {
                    Especialidad es = new Especialidad();
                    es.IdEspecialidad = Convert.ToInt32(dr["IdEspecialidad"].ToString());
                    es.NombreEspecialidad = dr["NombreEspecialidad"].ToString();
                    es.DescpEspecialidad = dr["DescpEspecialidad"].ToString();
                    listaEspecialidad.Add(es);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaEspecialidad = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaEspecialidad;
        }
    }
}
