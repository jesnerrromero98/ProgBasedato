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
    public class accesoDatosReceta
    {
        SqlConnection cnx;
        Receta rc = new Receta();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Receta> listaReceta = null;

        public int insertarReceta(Receta rc)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Recet", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@IdReceta", "");
                cm.Parameters.AddWithValue("@Nombre", rc.Nombre);
                cm.Parameters.AddWithValue("@Presentacion", rc.Presentacion);
                cm.Parameters.AddWithValue("@Cantidad", rc.Cantidad);
                cm.Parameters.AddWithValue("@Descripcion", rc.Descripcion);

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

        public List<Receta> listarReceta()
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Recet", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@IdReceta", "");
                cm.Parameters.AddWithValue("@Nombre", "");
                cm.Parameters.AddWithValue("@Presentacion", "");
                cm.Parameters.AddWithValue("@Cantidad", "");
                cm.Parameters.AddWithValue("@Descripcion", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaReceta = new List<Receta>();

                while (dr.Read())
                {
                    Receta rc = new Receta();
                    rc.IdReceta = Convert.ToInt32(dr["IdReceta"].ToString());
                    rc.Nombre = dr["Nombre"].ToString();
                    rc.Presentacion = dr["Presentacion"].ToString();
                    rc.Cantidad = Convert.ToInt32(dr["Cantidad"].ToString());
                    rc.Descripcion = dr["Descripcion"].ToString();
                    listaReceta.Add(rc);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaReceta = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaReceta;
        }

        public int eliminarReceta(int IdRec)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Recet", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@IdReceta", IdRec);
                cm.Parameters.AddWithValue("@Nombre", "");
                cm.Parameters.AddWithValue("@Presentacion", "");
                cm.Parameters.AddWithValue("@Cantidad", "");
                cm.Parameters.AddWithValue("@Descripcion", "");

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
