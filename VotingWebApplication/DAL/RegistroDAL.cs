using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using VotingWebApplication.EN;

namespace VotingWebApplication.DAL
{
    public class RegistroDAL
    {
        public List<RegistroNacional> getAll()
        {
            List<RegistroNacional> lsRegistros = null;
            SqlConnection conn = null;
            try
            {
                conn = new Connection().getConnection();
                lsRegistros = new List<RegistroNacional>();

                SqlCommand command = new SqlCommand("get_registros", conn);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    RegistroNacional registro = new RegistroNacional();
                    registro.id = Convert.ToInt32(reader[0]);
                    registro.nombre = Convert.ToString(reader[1]);
                    registro.primer_apellido = Convert.ToString(reader[2]);
                    registro.segundo_apellido = Convert.ToString(reader[3]);
                    registro.fecha_nacimiento = Convert.ToDateTime(reader[4]);
                    registro.numero_dui = Convert.ToString(reader[5]);
                    registro.genero = Convert.ToChar(reader[6]);
                    registro.ocupacion = Convert.ToString(reader[7]);
                    registro.direccion = Convert.ToString(reader[8]);
                    registro.nacionalidad = Convert.ToString(reader[9]);
                    registro.id_municipio = Convert.ToInt32(reader[11]);
                    lsRegistros.Add(registro);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return lsRegistros;
        }


        public void deleteById(int pId)
        {
            SqlConnection conn = null;
            try
            {
                conn = new Connection().getConnection();
                SqlCommand command = new SqlCommand("delete_registroNacional", conn);
                command.Parameters.Add(new SqlParameter("@Id", pId));
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        public void save(RegistroNacional pRegistro)
        {
            SqlConnection conn = null;
                try
                {
                    conn = new Connection().getConnection();
                    SqlCommand command = new SqlCommand("save_registroNacional", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@nombre", pRegistro.nombre);
                    command.Parameters.AddWithValue("@primer_apellido", pRegistro.primer_apellido);
                    command.Parameters.AddWithValue("@segundo_apellido", pRegistro.segundo_apellido);
                    command.Parameters.AddWithValue("@fecha_nacimiento", null);
                    command.Parameters.AddWithValue("@numero_dui", pRegistro.numero_dui);
                    command.Parameters.AddWithValue("@genero", pRegistro.genero);
                    command.Parameters.AddWithValue("@ocupacion", pRegistro.ocupacion);
                    command.Parameters.AddWithValue("@nacionalidad", pRegistro.nacionalidad);
                    command.Parameters.AddWithValue("@direccion", pRegistro.direccion);
                    command.Parameters.AddWithValue("@foto", null);
                    command.Parameters.AddWithValue("@id_municipio", pRegistro.id_municipio);
                conn.Open();
                command.ExecuteNonQuery();
            }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    conn.Close();
                }

            }

        public void update(RegistroNacional pRegistro)
        {
            SqlConnection conn = null;
                try
                {
                    conn = new Connection().getConnection();
                    SqlCommand command = new SqlCommand("update_registroNacional", conn);
                    command.Parameters.Add(new SqlParameter("@id", pRegistro.id));
                    command.Parameters.Add(new SqlParameter("@nombre", pRegistro.nombre));
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    conn.Close();
                }

            }


        public RegistroNacional getById(int pId)
        {
            SqlConnection conn = null;
            RegistroNacional registro = new RegistroNacional();
            try
                {
                    conn = new Connection().getConnection();
                    SqlCommand command = new SqlCommand("get_registroNacional", conn);
                    command.Parameters.Add(new SqlParameter("@Id", pId));
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                    registro.id = Convert.ToInt32(reader[0]);
                    registro.nombre = Convert.ToString(reader[1]);
                    registro.primer_apellido = Convert.ToString(reader[2]);
                    registro.segundo_apellido = Convert.ToString(reader[3]);
                    registro.fecha_nacimiento = Convert.ToDateTime(reader[4]);
                    registro.numero_dui = Convert.ToString(reader[5]);
                    registro.genero = Convert.ToChar(reader[6]);
                    registro.ocupacion = Convert.ToString(reader[7]);
                    registro.direccion = Convert.ToString(reader[8]);
                    registro.nacionalidad = Convert.ToString(reader[9]);
                    registro.foto = (byte[])reader["Imagen"];
                    registro.id_municipio = Convert.ToInt32(reader[11]);
                }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error de proceso: "+e.Message);
                }
                finally
                {
                    conn.Close();
                }
                return registro;
        }
    }
}