using ListaCompras.Domain.Models.Database;
using MySql.Data.MySqlClient;

namespace ListaCompras.Data.DbConfig
{
    public class Configuration
    {
        public static MySqlConnection GetSqlConnection()
        {
            return new MySqlConnection(DbStaticDefaults.ConnectionString);
        }
    }
}
