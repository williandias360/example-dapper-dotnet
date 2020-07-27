using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Dapper;
using System.Collections.Generic;
namespace ApiIndicadores
{
    public class IndicadoresDAO
    {
        private IConfiguration _config;

        public IndicadoresDAO(IConfiguration config)
        {
            _config = config;
        }

        public Indicador Obter(string codigoIndicador)
        {
            using (SqlConnection conexao = new SqlConnection(
                _config.GetConnectionString("BaseIndicadores")))
            {
                return conexao.QueryFirstOrDefault<Indicador>(
                    "SELECT Sigla, NomeIndicador, UltimaAtualizacao, Valor " +
                    "FROM dbo.Indicadores " +
                    "WHERE Sigla = @CodigoIndicador",
                    new { CodigoIndicador = codigoIndicador });
            }
        }

        public IEnumerable<Indicador> Listar()
        {
            using (SqlConnection conexao = new SqlConnection(
                _config.GetConnectionString("BaseIndicadores")))
            {
                return conexao.Query<Indicador>("SELECT * FROM dbo.Indicadores");
            }
        }

        public void Inserir(Indicador indicador)
        {
            using (SqlConnection conexao = new SqlConnection(_config.GetConnectionString("BaseIndicadores")))
            {

            }
        }
    }
}