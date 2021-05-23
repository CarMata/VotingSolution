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
    public class PartidoDAL
    {
        public List<Partido> getAll()
        {
            List<Partido> lsPartido = null;
            string ConnectionString = ConfigurationManager.ConnectionStrings["CCBD"].ConnectionString;
            using (SqlConnection con = new SqlConnection(ConnectionString))
                try
                {
                    lsPartido = new List<Partido>();

                    SqlCommand command = new SqlCommand("get_Partidos", con);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Partido partido = new Partido();
                        partido.id = Convert.ToInt32(reader[0]);
                        partido.nombre = Convert.ToString(reader[1]);
                        partido.foto = (byte[])reader["Imagen"];
                        lsPartido.Add(partido);
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
            return lsPartido;
        }
        public void save(Partido pPartido)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["CCBD"].ConnectionString;
            using (SqlConnection con = new SqlConnection(ConnectionString))
                try
                {
                    //conn = new Connection().getConnection();
                    SqlCommand command = new SqlCommand("save_Partido", con);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@nombre", pPartido.nombre);
                    command.Parameters.AddWithValue("@foto", pPartido.foto);
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