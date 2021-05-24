using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using VotingWebApplication.EN;

namespace VotingWebApplication.DAL
{
    public class TipoEleccionDAL
    {
        public TipoEleccion getById(int pId)
        {
            TipoEleccion eleccion = null;
            string ConnectionString = ConfigurationManager.ConnectionStrings["CCBD"].ConnectionString;
            using (SqlConnection con = new SqlConnection(ConnectionString))
                try
                {

                    SqlCommand command = new SqlCommand("get_TipoEleccionById", con);
                    command.Parameters.Add(new SqlParameter("@Id", pId));
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    eleccion = new TipoEleccion();
                    while (reader.Read())
                    {
                        eleccion.id = Convert.ToInt32(reader[0]);
                        eleccion.nombre = Convert.ToString(reader[1]);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    con.Close();
                }
            return eleccion;
        }
        public List<TipoEleccion> getAll()
        {
            List<TipoEleccion> lsEleccion = null;
            string ConnectionString = ConfigurationManager.ConnectionStrings["CCBD"].ConnectionString;
            using (SqlConnection con = new SqlConnection(ConnectionString))
                try
                {
                    lsEleccion = new List<TipoEleccion>();

                    SqlCommand command = new SqlCommand("get_TipoEleccion", con);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        TipoEleccion eleccion = new TipoEleccion();
                        eleccion.id = Convert.ToInt32(reader[0]);
                        eleccion.nombre = Convert.ToString(reader[1]);
                        lsEleccion.Add(eleccion);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    con.Close();
                }
            return lsEleccion;
        }
        public void save(TipoEleccion pEleccion)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["CCBD"].ConnectionString;
            using (SqlConnection con = new SqlConnection(ConnectionString))
                try
                {
                    //conn = new Connection().getConnection();
                    SqlCommand command = new SqlCommand("save_TipoEleccion", con);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@nombre", pEleccion.nombre);
                    con.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    con.Close();
                }

        }

        public void edit(TipoEleccion pEleccion)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["CCBD"].ConnectionString;
            using (SqlConnection con = new SqlConnection(ConnectionString))
                try
                {
                    //conn = new Connection().getConnection();
                    SqlCommand command = new SqlCommand("update_TipoEleccion", con);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", pEleccion.id);
                    command.Parameters.AddWithValue("@nombre", pEleccion.nombre);
                    con.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    con.Close();
                }

        }

        public void delete(int pId)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["CCBD"].ConnectionString;
            using (SqlConnection con = new SqlConnection(ConnectionString))
                try
                {
                    //conn = new Connection().getConnection();
                    SqlCommand command = new SqlCommand("delete_TipoEleccion", con);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", pId);
                    con.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    con.Close();
                }

        }
    }
}