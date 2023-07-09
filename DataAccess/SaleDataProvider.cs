using System.Data.SqlClient;
using System.IO;
using Microsoft.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;

namespace DataAccess
{
    public class SaleDataProvider
    {
        private string ConnectionString { get; set; }
        public SaleDataProvider(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public void CloseConnection(SqlConnection connection) => connection.Close();
        public SqlParameter CreateParameter(string name, int size, object value, DbType dbType,
            ParameterDirection direction= ParameterDirection.Input)
        {
            return new SqlParameter
            {
                DbType = dbType,
                ParameterName = name,
                Size = size,
                Value = value,
                Direction = direction,
            };
        }
        public IDataReader GetDataReader(String commandText, CommandType commandType,
            out SqlConnection connection, params SqlParameter[] parameters)
        {
            IDataReader reader = null;
            try
            {
                connection = new SqlConnection(ConnectionString);
                connection.Open();
                var command= new SqlCommand(commandText, connection);
                command.CommandType = commandType;
                if(parameters != null)
                {
                    foreach(var s in parameters)
                    {
                        command.Parameters.Add(s);
                    }
                }
                reader= command.ExecuteReader();
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return reader;
        }
        //delete update create
        public void DUC(String commandText, CommandType commandType,
            params SqlParameter[] parameters)
        {
            try
            {
                using var connection= new SqlConnection(ConnectionString);
                connection.Open();
                SqlCommand command= new SqlCommand(commandText, connection);
                command.CommandType= commandType;
                if (parameters != null)
                {
                    foreach (SqlParameter s in parameters)
                    {
                        command.Parameters.Add(s);
                    }
                }
                command.ExecuteNonQuery();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
