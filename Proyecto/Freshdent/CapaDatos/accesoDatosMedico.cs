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
    public class accesoDatosMedico
    {
        SqlConnection cnx;
        Medico md = new Medico();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Medico> listaMedico = null;

        public int insertarMedico(Medico md)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Medic", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@IdMedico", "");
                cm.Parameters.AddWithValue("@NombreMedico", md.NombreMedico);
                cm.Parameters.AddWithValue("@Telefono_Celular", md.Telefono_Celular);
                cm.Parameters.AddWithValue("@IdEspecialidad", md.IdEspecialidad);

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

        public List<Medico> listarMedico()
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Medic", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@IdMedico", "");
                cm.Parameters.AddWithValue("@NombreMedico", "");
                cm.Parameters.AddWithValue("@Telefono_Celular", "");
                cm.Parameters.AddWithValue("@IdEspecialidad", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaMedico = new List<Medico>();

                while (dr.Read())
                {
                    Medico md = new Medico();
                    md.IdMedico = Convert.ToInt32(dr["IdMedico"].ToString());
                    md.NombreMedico = dr["NombreMedico"].ToString();
                    md.Telefono_Celular = Convert.ToInt32(dr["Telefono_Celular"].ToString());
                    md.IdEspecialidad = Convert.ToInt32(dr["IdEspecialidad"].ToString());
                    listaMedico.Add(md);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaMedico = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaMedico;
        }

        public int eliminarMedico(int IdMedic)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Medic", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@IdMedico", IdMedic);
                cm.Parameters.AddWithValue("@NombreMedico", "");
                cm.Parameters.AddWithValue("@Telefono_Celular", "");
                cm.Parameters.AddWithValue("@IdEspecialidad", "");

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

        public int editarMedico(Medico md)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Medic", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@IdMedico", md.IdMedico);
                cm.Parameters.AddWithValue("@NombreMedico", md.NombreMedico);
                cm.Parameters.AddWithValue("@Telefono_Celular", md.Telefono_Celular);
                cm.Parameters.AddWithValue("@IdEspecialidad", md.IdEspecialidad);

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

        public List<Medico> buscarMedico(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Medic", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@IdMedico", "");
                cm.Parameters.AddWithValue("@NombreMedico", dato);
                cm.Parameters.AddWithValue("@Telefono_Celular", "");
                cm.Parameters.AddWithValue("@IdEspecialidad", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaMedico = new List<Medico>();

                while (dr.Read())
                {
                    Medico md = new Medico();
                    md.IdMedico = Convert.ToInt32(dr["IdMedico"].ToString());
                    md.NombreMedico = dr["NombreMedico"].ToString();
                    md.Telefono_Celular = Convert.ToInt32(dr["Telefono_Celular"].ToString());
                    md.IdEspecialidad = Convert.ToInt32(dr["IdEspecialidad"].ToString());
                    listaMedico.Add(md);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaMedico = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaMedico;
        }
    }
}
