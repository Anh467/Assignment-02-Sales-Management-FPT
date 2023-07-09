using System.Data.SqlClient;
using System.IO;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
namespace DataAccess
{
    public class BaseDAL
    {
        public SaleDataProvider dataProvider { get; set; } = null;
        public SqlConnection connection= null;
        public BaseDAL()
        {
            var connectionString = GetConnectionString();
            dataProvider = new SaleDataProvider(connectionString);
        }
        public string GetConnectionString() {
            string connectionString;
            IConfiguration config = new ConfigurationBuilder()
                                    .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile("appsettings.json", true, true)
                                    .Build();
            connectionString = config["ConnectionString:MyStockDB"];
            return connectionString;
        }
        public void closeConnection() => dataProvider.CloseConnection(connection);
    }
}
