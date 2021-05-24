﻿using System;
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
    public class DepartamentoDAL
    {
        public Departamento getById(int pId)
        {
            Departamento departamento = null;
            string ConnectionString = ConfigurationManager.ConnectionStrings["CCBD"].ConnectionString;
            using (SqlConnection con = new SqlConnection(ConnectionString))
                try
                {

                    SqlCommand command = new SqlCommand("get_DepartamentoById", con);
                    command.Parameters.Add(new SqlParameter("@Id", pId));
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    departamento = new Departamento();
                    while (reader.Read())
                    {
                        departamento.id = Convert.ToInt32(reader[0]);
                        departamento.nombre = Convert.ToString(reader[1]);
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
            return departamento;
        }
        public List<Departamento> getAll()
        {
            List<Departamento> lsDepartamento = null;
            string ConnectionString = ConfigurationManager.ConnectionStrings["CCBD"].ConnectionString;
            using (SqlConnection con = new SqlConnection(ConnectionString))
                try
               {
                lsDepartamento = new List<Departamento>();

                SqlCommand command = new SqlCommand("get_Departamentos", con);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                {
                    Departamento departamento = new Departamento();
                    departamento.id = Convert.ToInt32(reader[0]);
                    departamento.nombre = Convert.ToString(reader[1]);
                    lsDepartamento.Add(departamento);
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
            return lsDepartamento;
        }
        public void save(Departamento pDepartamento)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["CCBD"].ConnectionString;
            using (SqlConnection con = new SqlConnection(ConnectionString))
                try
            {
                //conn = new Connection().getConnection();
                SqlCommand command = new SqlCommand("save_Departamento", con);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@nombre", pDepartamento.nombre);
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

        public void edit(Departamento pDepartamento)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["CCBD"].ConnectionString;
            using (SqlConnection con = new SqlConnection(ConnectionString))
                try
                {
                    //conn = new Connection().getConnection();
                    SqlCommand command = new SqlCommand("update_Departamento", con);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", pDepartamento.id);
                    command.Parameters.AddWithValue("@nombre", pDepartamento.nombre);
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
                    SqlCommand command = new SqlCommand("delete_Departamento", con);
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