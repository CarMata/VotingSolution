using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using VotingWebApplication.EN;

namespace VotingWebApplication.DAL
{
    public class UsuarioDAL
    {

        public List<Usuario> getAll()
        {
            List<Usuario> lstUsuario = null;
            SqlConnection conn = null;
            try
            {
                conn = new Connection().getConnection();
                SqlCommand command = new SqlCommand("get_usuarios", conn);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();
                lstUsuario = new List<Usuario>();
                while (reader.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.id = Convert.ToInt32(reader[0]);
                    usuario.usuario = Convert.ToString(reader[1]);
                    usuario.password = Convert.ToString(reader[2]);
                    usuario.fecha_creacion = Convert.ToDateTime(reader[3]);
                    usuario.correo = Convert.ToString(reader[4]);
                    usuario.id_registroNacional = Convert.ToInt32(reader[5]);
                    usuario.id_role = Convert.ToInt32(reader[6]);
                    lstUsuario.Add(usuario);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally {
                conn.Close();
            }
            return lstUsuario;
        }

        public void create(Usuario pUsuario)
        {
            SqlConnection conn = null;
            try
            {
                conn = new Connection().getConnection();
                SqlCommand command = new SqlCommand("insert_usuario", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@usuario", pUsuario.usuario);
                command.Parameters.AddWithValue("@password", pUsuario.password);
                command.Parameters.AddWithValue("@correo", pUsuario.correo);
                command.Parameters.AddWithValue("@fecha_creacion", DateTime.Now);
                command.Parameters.AddWithValue("@id_registro_nacional", pUsuario.id_registroNacional);
                command.Parameters.AddWithValue("@id_role", pUsuario.id_role);
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally {
                conn.Close();
            }
        }

        public RegistroNacional validarDui(String pNumeroDui) {
            RegistroNacional registroNacional = null;
            SqlConnection conn = null;
            try
            {
                conn = new Connection().getConnection();
                SqlCommand command = new SqlCommand("validar_dui", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@numero_dui", pNumeroDui!=null? pNumeroDui:"");
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    registroNacional = new RegistroNacional();
                    registroNacional.id = Convert.ToInt32(reader[0]);
                    registroNacional.nombre = Convert.ToString(reader[1]);
                    registroNacional.primer_apellido = Convert.ToString(reader[2]);
                    registroNacional.segundo_apellido = Convert.ToString(reader[3]);
                    registroNacional.fecha_nacimiento = Convert.ToDateTime(reader[4]);
                    registroNacional.numero_dui = Convert.ToString(reader[5]);
                    registroNacional.genero = Convert.ToChar(reader[6]);
                    registroNacional.ocupacion = Convert.ToString(reader[7]);
                    registroNacional.direccion = Convert.ToString(reader[8]);
                    registroNacional.nacionalidad = Convert.ToString(reader[9]);
                    registroNacional.id_municipio = Convert.ToInt32(reader[11]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                conn.Close();
            }
            return registroNacional;
        }




    }
}