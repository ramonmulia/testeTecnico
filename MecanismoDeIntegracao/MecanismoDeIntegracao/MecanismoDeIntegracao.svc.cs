using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MecanismoDeIntegracao
{

    public class Servico : ICliente
    {

        public bool AtualizarDados(Cliente cliente)
        {
            int retorno = 0; 
            try
            {
                Conexao.Conexao conn = Conexao.Conexao.Instance;
                string update = "UPDATE TbCliente SET datanascimento = @datanascimento, telefonecelular = @telefonecelular WHERE cliente_Id = @cliente_id";
                SqlCommand comm = new SqlCommand(update,conn.Con);
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@datanascimento",cliente.DataNascimento);
                comm.Parameters.AddWithValue("@telefonecelular", cliente.TelefoneCelular);
                comm.Parameters.AddWithValue("@cliente_id", cliente.Cliente_id);

                retorno = comm.ExecuteNonQuery();
                conn.Con.Close();

                if (retorno != 0)
                    return true;
                else
                    return false;

            }
            catch(Exception e)
            {
                return false;
            }
        }

        public List<Cliente> RetornaClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            try
            {
                Conexao.Conexao conn = Conexao.Conexao.Instance;
                string query = "SELECT * FROM TbCliente";
                SqlCommand comm = new SqlCommand(query, conn.Con);
                comm.CommandType = CommandType.Text;
                SqlDataReader r = comm.ExecuteReader();

                while(r.Read()){
                    Cliente c = new Cliente();
                    c.Cliente_id = Convert.ToInt32(r[0]);
                    c.Nome = Convert.ToString(r[1]);
                    c.TelefoneResidencial = Convert.ToString(r[2]);
                    c.Endereco = Convert.ToString(r[3]);
                    c.DataNascimento = r[4] is DBNull ? DateTime.MinValue : Convert.ToDateTime(r[4]);
                    c.TelefoneCelular = r[5] == null ? string.Empty : Convert.ToString(r[5]);
 
                    listaClientes.Add(c);
                }

                conn.Con.Close();

                return listaClientes;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
