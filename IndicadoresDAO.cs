using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Dapper;
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

        // public IEnumerable<Indicador> Listar()
        // {

        // }
    }
}