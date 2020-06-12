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
    public class accesoDatosConsulta
    {
        SqlConnection cnx;
        Consulta cs = new Consulta();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Consulta> listaConsulta = null;

        public int insertarConsulta(Consulta cs)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Consul", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@IdConsulta", "");
                cm.Parameters.AddWithValue("@Fecha", cs.Fecha);
                cm.Parameters.AddWithValue("@Hora", cs.Hora);
                cm.Parameters.AddWithValue("@Sintoma", cs.Sintoma);
                cm.Parameters.AddWithValue("@Diagnostico", cs.Diagnostico);
                cm.Parameters.AddWithValue("@IdExpediente", cs.IdExpediente);
                cm.Parameters.AddWithValue("@IdMedico", cs.IdMedico);

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

        public List<Consulta> listarConsulta()
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Consul", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@IdConsulta", "");
                cm.Parameters.AddWithValue("@Fecha", "");
                cm.Parameters.AddWithValue("@Hora", "");
                cm.Parameters.AddWithValue("@Sintoma", "");
                cm.Parameters.AddWithValue("@Diagnostico", "");
                cm.Parameters.AddWithValue("@IdExpediente", "");
                cm.Parameters.AddWithValue("@IdMedico", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaConsulta = new List<Consulta>();

                while (dr.Read())
                {
                    Consulta cs = new Consulta();
                    cs.IdConsulta = Convert.ToInt32(dr["IdConsulta"].ToString());
                    cs.Fecha = Convert.ToDateTime(dr["Fecha"].ToString());
                    cs.Hora= Convert.ToDateTime(dr["Hora"].ToString());
                    cs.Sintoma = dr["Sintoma"].ToString();
                    cs.Diagnostico = dr["Diagnostico"].ToString();
                    cs.IdExpediente = Convert.ToInt32(dr["IdExpediente"].ToString());
                    cs.IdMedico = Convert.ToInt32(dr["IdMedico"].ToString());
                    listaConsulta.Add(cs);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaConsulta = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaConsulta;
        }

        public int eliminarConsulta(int IdCons)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Consul", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@IdConsulta", IdCons);
                cm.Parameters.AddWithValue("@Fecha", "");
                cm.Parameters.AddWithValue("@Hora", "");
                cm.Parameters.AddWithValue("@Sintoma", "");
                cm.Parameters.AddWithValue("@Diagnostico", "");
                cm.Parameters.AddWithValue("@IdExpediente", "");
                cm.Parameters.AddWithValue("@IdMedico", "");

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
    }
}
