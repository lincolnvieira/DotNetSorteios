﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSorteios.Servicos.AcessoDados
{
    public class DAO
    {

        private static readonly string conexao = ConfigurationManager.AppSettings["CONNECTIONSTRING"];


        public bool Execute(string query, object parameters = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conexao))
                {
                    return Convert.ToBoolean(conn.Execute(query, parameters));
                }
            }
            catch (Exception ex)
            {
                //Handle the exception
                return default; //Or however you want to handle the return
            }
        }

        public bool ExecuteScalar(string query, object parameters = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conexao))
                {
                    return Convert.ToBoolean(conn.ExecuteScalar(query, parameters));
                }
            }
            catch (Exception ex)
            {
                //Handle the exception
                return default; //Or however you want to handle the return
            }
        }

        public DataTable ExecuteReader(string query, object parameters = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conexao))
                {
                    IDataReader reader = conn.ExecuteReader(query, parameters);

                    DataTable dttResultado = new DataTable();
                    dttResultado.Load(reader);

                    return dttResultado;
                }
            }
            catch (Exception ex)
            {
                //Handle the exception
                return default; //Or however you want to handle the return
            }
        }

        public T QueryFirst<T>(string query, object parameters = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conexao))
                {
                    return conn.QueryFirst<T>(query, parameters);
                }
            }
            catch (Exception ex)
            {
                //Handle the exception
                return default; //Or however you want to handle the return
            }
        }

        public T QueryFirstOrDefault<T>(string query, object parameters = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conexao))
                {
                    return conn.QueryFirstOrDefault<T>(query, parameters);
                }
            }
            catch (Exception ex)
            {
                //Handle the exception
                return default; //Or however you want to handle the return
            }
        }

        public T QuerySingle<T>(string query, object parameters = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conexao))
                {
                    return conn.QuerySingle<T>(query, parameters);
                }
            }
            catch (Exception ex)
            {
                //Handle the exception
                return default; //Or however you want to handle the return
            }
        }

        public T QuerySingleOrDefault<T>(string query, object parameters = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conexao))
                {
                    return conn.QuerySingleOrDefault<T>(query, parameters);
                }
            }
            catch (Exception ex)
            {
                //Handle the exception
                return default; //Or however you want to handle the return
            }
        }
    }
}
