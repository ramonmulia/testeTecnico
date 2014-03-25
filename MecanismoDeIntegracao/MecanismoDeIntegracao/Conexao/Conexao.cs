using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace MecanismoDeIntegracao.Conexao
{
    public class Conexao
    {
        private string sConexao = ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString;
        private static Conexao instance;
        private SqlConnection conn;
 
        private Conexao()
        {
            this.conn = new SqlConnection(sConexao);
        }
 
   
        public static Conexao Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Conexao();
                }
                return instance;
            }
        }
 
        public SqlConnection Con
        {
            get
            {
                try
                {
                    if (this.conn.State != System.Data.ConnectionState.Open)
                    {
                        this.conn.ConnectionString = sConexao;
                        this.conn.Open();
                    }
                    return this.conn;
                }
                catch (Exception ex)
                {
                    if (this.conn.State == ConnectionState.Open)
                    {
                        this.conn.Close();
                    }
                    throw ex;
                }
            }
        }
    }
}