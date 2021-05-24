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
    public class MunicipioDAL
    {
        public Municipio getById(int pId)
        {
            Municipio municipio = null;
            string ConnectionString = ConfigurationManager.ConnectionStrings["CCBD"].ConnectionString;
            using (SqlConnection con = new SqlConnection(ConnectionString))
                try
                {

                    SqlCommand command = new SqlCommand("get_MunicipioById", con);
                    command.Parameters.Add(new SqlParameter("@Id", pId));
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    municipio = new Municipio();
                    while (reader.Read())
                    {
                        municipio.id = Convert.ToInt32(reader[0]);
                        municipio.nombre = Convert.ToString(reader[1]);
                        municipio.idDepartamento = Convert.ToInt32(reader[2]);
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
            return municipio;
        }
        public List<Municipio> getAll()
        {
            List<Municipio> lsMunicipio = null;
            string ConnectionString = ConfigurationManager.ConnectionStrings["CCBD"].ConnectionString;
            using (SqlConnection con = new SqlConnection(ConnectionString))
                try
                {
                    lsMunicipio = new List<Municipio>();

                    SqlCommand command = new SqlCommand("get_Municipios", con);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Municipio municipio = new Municipio();
                        municipio.id = Convert.ToInt32(reader[0]);
                        municipio.nombre = Convert.ToString(reader[1]);
                        municipio.idDepartamento = Convert.ToInt32(reader[2]);
                        lsMunicipio.Add(municipio);
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
            return lsMunicipio;
        }
        public void save(Municipio pMunicipio)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["CCBD"].ConnectionString;
            using (SqlConnection con = new SqlConnection(ConnectionString))
                try
                {
                    //conn = new Connection().getConnection();
                    SqlCommand command = new SqlCommand("save_Municipio", con);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@nombre", pMunicipio.nombre);
                    command.Parameters.AddWithValue("@id_departamento", pMunicipio.idDepartamento);
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

        public void edit(Municipio pMunicipio)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["CCBD"].ConnectionString;
            using (SqlConnection con = new SqlConnection(ConnectionString))
                try
                {
                    //conn = new Connection().getConnection();
                    SqlCommand command = new SqlCommand("update_Municipio", con);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", pMunicipio.id);
                    command.Parameters.AddWithValue("@nombre", pMunicipio.nombre);
                    command.Parameters.AddWithValue("@id_departamento", pMunicipio.idDepartamento);
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
                    SqlCommand command = new SqlCommand("delete_Municipio", con);
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