using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace KC_FACTURACION_ELECTRONICA.BbContext
{
    public class DatalakeContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public DatalakeContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("SqlConnection");
        }

        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}
