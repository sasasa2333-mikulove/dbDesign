using MySql.Data.MySqlClient;
using System.Data;
using System.Threading.Tasks;

namespace dbDesign
{
    public static class DataAccessHelper
    {
        private static readonly string connectionString = "Server=127.0.0.1;Port=3306;Database=202303_lyz_mis;Uid=root;Pwd=root;Charset=utf8mb4;";
        public static DataTable GetDataTable(string sql, params MySqlParameter[] parameters)
        {
            try
            {
                using var connection = new MySqlConnection(connectionString);
                using var command = new MySqlCommand(sql, connection);
                if (parameters?.Length > 0)
                {
                    command.Parameters.AddRange(parameters);
                }

                using var adapter = new MySqlDataAdapter(command);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (MySqlException ex)
            {
                throw new System.Exception("Database query error: " + ex.Message, ex);
            }
        }

        public static async Task<int> ExecuteNonQueryAsync(string sql, MySqlParameter[] parameters, CommandType commandType = CommandType.Text)
        {
            try
            {
                using var connection = new MySqlConnection(connectionString);
                await connection.OpenAsync();

                using var command = new MySqlCommand(sql, connection);
                command.CommandType = commandType;
                if (parameters?.Length > 0)
                {
                    command.Parameters.AddRange(parameters);
                }

                return await command.ExecuteNonQueryAsync();
            }
            catch (MySqlException ex)
            {
                throw new System.Exception("Database operation error: " + ex.Message, ex);
            }
        }

        public static async Task<object> ExecuteScalarAsync(string sql, params MySqlParameter[] parameters)
        {
            try
            {
                using var connection = new MySqlConnection(connectionString);
                await connection.OpenAsync();

                using var command = new MySqlCommand(sql, connection);
                if (parameters?.Length > 0)
                {
                    command.Parameters.AddRange(parameters);
                }

                return await command.ExecuteScalarAsync();
            }
            catch (MySqlException ex)
            {
                throw new System.Exception("Database scalar query error: " + ex.Message, ex);
            }
        }

        public static async Task<DataTable> GetDataTableAsync(string sql, params MySqlParameter[] parameters)
        {
            try
            {
                var dataTable = new DataTable();
                using var connection = new MySqlConnection(connectionString);
                await connection.OpenAsync();

                using var command = new MySqlCommand(sql, connection);
                if (parameters?.Length > 0)
                {
                    command.Parameters.AddRange(parameters);
                }

                using var reader = await command.ExecuteReaderAsync();

                dataTable.Load(reader);

                return dataTable;
            }
            catch (MySqlException ex)
            {
                throw new Exception("数据库异步查询失败: " + ex.Message, ex);
            }
        }
    }
}