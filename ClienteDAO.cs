using System;
using System.Data.SqlClient;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;

namespace ApiIndicadores
{
    public class ClienteDAO
    {
        private IConfiguration _config;
        private string ConnectionString;

        public ClienteDAO(IConfiguration config)
        {
            _config = config;
            ConnectionString = _config.GetConnectionString("BaseIndicadores");
        }

        public void Inserir(Cliente cliente)
        {
            using (SqlConnection conexao = new SqlConnection(ConnectionString))
            {
                cliente.DataCriacao = DateTime.Now;
                var codigo = conexao.Insert<Cliente>(cliente);
                cliente.CodigoCliente = codigo;
            }
        }
    }
}