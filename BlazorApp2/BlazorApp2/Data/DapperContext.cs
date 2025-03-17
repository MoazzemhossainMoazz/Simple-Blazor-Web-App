using Microsoft.Data.SqlClient;
using System.Data;

namespace BlazorApp2.Data
{
    public class DapperContext
    {
        private string _connectionString;

        public DapperContext(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public IDbConnection CreateConnection()
            => new SqlConnection(_connectionString);
    }
}
