using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaDatos
{
    public class InicioSesion
    {
        SqlConnection cnx;
        Inicio cs = new Inicio();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Inicio> listaInicio = null;

        public int insertarinicio(Inicio In)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Consul", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@UserID", "");
                cm.Parameters.AddWithValue("@LoginName", In.LoginName);
                cm.Parameters.AddWithValue("@Password", In.Password);
           
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

        public Inicio iniciarSesion(string usuario, string contaseña)
        {
            cnx = cn.conectar();
            cm = new SqlCommand("Us", cnx);
            cm.Parameters.AddWithValue("@b", 4);
            cm.Parameters.AddWithValue("@LoginName", $"{usuario}");
            cm.Parameters.AddWithValue("@Password", $"{contaseña}");
            cm.Parameters.AddWithValue("@UserID", "");

            cm.CommandType = CommandType.StoredProcedure;
            cnx.Open();
            dr = cm.ExecuteReader();
            if (dr.Read() && dr.HasRows)
            {
                return new Inicio()
                {
                    LoginName = dr["LoginName"].ToString(),
                    Password = dr["Password"].ToString(),
                    UserID = Convert.ToInt32(dr["UserID"].ToString())
                };
            }
            else
            {
                throw new Exception("Usuario no encontrado.");
            }
            
        }

        public List<Inicio> listarInicio()
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Us", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@LoginName", "");
                cm.Parameters.AddWithValue("@Password", "");
                cm.Parameters.AddWithValue("@UserID", "");
            

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaInicio = new List<Inicio>();

                while (dr.Read())
                {
                    Inicio cs = new Inicio();
                    cs.UserID= Convert.ToInt32(dr["UserID"].ToString());
                    cs.LoginName = dr["LoginName"].ToString();
                    cs.Password = dr["Password"].ToString();
                
                    listaInicio.Add(cs);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaInicio = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaInicio;
        }
    }

}
