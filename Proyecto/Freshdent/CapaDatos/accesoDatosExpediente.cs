﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaEntidades;
using System.Data;

namespace CapaDatos
{
    public class accesoDatosExpediente
    {
        SqlConnection cnx;
        Expediente e = new Expediente();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Expediente> listaExpediente = null;

        public int insertarExpediente (Expediente ex)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Expedient", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@IdExpediente", "");
                cm.Parameters.AddWithValue("@Cedula", ex.Cedula);
                cm.Parameters.AddWithValue("@Nombres", ex.Nombres);
                cm.Parameters.AddWithValue("@Apellidos", ex.Apellidos);
                cm.Parameters.AddWithValue("@Fecha_Nacimiento", ex.Fecha_Nacimiento);
                cm.Parameters.AddWithValue("@Telefono_Celular", ex.Telefono_Celular);
                cm.Parameters.AddWithValue("@Municipio", ex.Municipio);
                cm.Parameters.AddWithValue("@Departamento", ex.Departamento);

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

        public List<Expediente> listarExpediente()
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Expedient", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@IdExpediente", "");
                cm.Parameters.AddWithValue("@Cedula", "");
                cm.Parameters.AddWithValue("@Nombres", "");
                cm.Parameters.AddWithValue("@Apellidos", "");
                cm.Parameters.AddWithValue("@Fecha_Nacimiento", "");
                cm.Parameters.AddWithValue("@Telefono_Celular", "");
                cm.Parameters.AddWithValue("@Municipio", "");
                cm.Parameters.AddWithValue("@Departamento", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaExpediente = new List<Expediente>();

                while (dr.Read())
                {
                    Expediente ex = new Expediente();
                    ex.IdExpediente = Convert.ToInt32(dr["IdExpediente"].ToString());
                    ex.Cedula = dr["Cedula"].ToString();
                    ex.Nombres = dr["Nombres"].ToString();
                    ex.Apellidos = dr["Apellidos"].ToString();
                    ex.Fecha_Nacimiento =dr["Fecha_Nacimiento"].ToString();
                    ex.Telefono_Celular = Convert.ToInt32(dr["Telefono_Celular"].ToString());
                    ex.Municipio = dr["Municipio"].ToString();
                    ex.Departamento = dr["Departamento"].ToString();
                    listaExpediente.Add(ex);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaExpediente = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaExpediente;
        }

        public int eliminarExpediente (int IdExped)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Expedient", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@IdExpediente",IdExped);
                cm.Parameters.AddWithValue("@Cedula", "");
                cm.Parameters.AddWithValue("@Nombres", "");
                cm.Parameters.AddWithValue("@Apellidos", "");
                cm.Parameters.AddWithValue("@Fecha_Nacimiento", "");
                cm.Parameters.AddWithValue("@Telefono_Celular", "");
                cm.Parameters.AddWithValue("@Municipio", "");
                cm.Parameters.AddWithValue("@Departamento", "");

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

        public int editarExpediente (Expediente ex)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Expedient", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@IdExpediente", ex.IdExpediente);
                cm.Parameters.AddWithValue("@Cedula", ex.Cedula);
                cm.Parameters.AddWithValue("@Nombres", ex.Nombres);
                cm.Parameters.AddWithValue("@Apellidos",ex.Apellidos);
                cm.Parameters.AddWithValue("@Fecha_Nacimiento", ex.Fecha_Nacimiento);
                cm.Parameters.AddWithValue("@Telefono_Celular", ex.Telefono_Celular);
                cm.Parameters.AddWithValue("@Municipio", ex.Municipio);
                cm.Parameters.AddWithValue("@Departamento", ex.Departamento);

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

        public List<Expediente> buscarExpediente(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Expedient", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@IdExpediente", "");
                cm.Parameters.AddWithValue("@Cedula", "");
                 cm.Parameters.AddWithValue("@Nombres",dato);
                cm.Parameters.AddWithValue("@Apellidos", "");
                cm.Parameters.AddWithValue("@Fecha_Nacimiento", "");
                cm.Parameters.AddWithValue("@Telefono_Celular", "");
                cm.Parameters.AddWithValue("@Municipio", "");
                cm.Parameters.AddWithValue("@Departamento", dato);

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaExpediente = new List<Expediente>();

                while (dr.Read())
                {
                    Expediente ex = new Expediente();
                    ex.IdExpediente = Convert.ToInt32(dr["IdExpediente"].ToString());
                    ex.Cedula = dr["Cedula"].ToString();
                    ex.Nombres = dr["Nombres"].ToString();
                    ex.Apellidos = dr["Apellidos"].ToString();
                    ex.Fecha_Nacimiento =dr["Fecha_Nacimiento"].ToString();
                    ex.Telefono_Celular = Convert.ToInt32(dr["Telefono_Celular"].ToString());
                    ex.Municipio = dr["Municipio"].ToString();
                    ex.Departamento = dr["Departamento"].ToString();
                    listaExpediente.Add(ex);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaExpediente = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaExpediente;
        }
    }
}
