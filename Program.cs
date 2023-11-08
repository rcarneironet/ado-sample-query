using Microsoft.Data.SqlClient;

namespace SampleQuery
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            var conn = new SqlConnectionStringBuilder("Data Source=ec2-18-117-195-\\SQLEXPRESS;Initial Catalog=costmanagement;Integrated Security=True;TrustServerCertificate=true")
            {
                Pooling = true,
                MinPoolSize = 1,
                MaxPoolSize = 256,
                PoolBlockingPeriod = PoolBlockingPeriod.Auto,
            };

            List<Task> tasks = new()
            {
                Task.Run(async () =>
            {
                await Execute_Command_1(conn);
            }),
                Task.Run(async () =>
                {
                    await Execute_Command_2(conn);
                }),

                Task.Run(async () =>
                {
                    await Execute_Command_3(conn);
                }),

                Task.Run(async () =>
                {
                    await Execute_Command_4(conn);
                })
            };

            Task.WhenAll(tasks);
            Console.WriteLine("All tasks completed!");
        }

        public static async Task Execute_Command_1(SqlConnectionStringBuilder connectionString)
        {
            using var conn = new SqlConnection(connectionString.ConnectionString);
            using var cmd = conn.CreateCommand();

            try
            {
                await conn.OpenAsync().ConfigureAwait(false);
                cmd.CommandText = "SELECT 1";
                var result = cmd.ExecuteScalarAsync();
            }
            finally
            {
                await conn.CloseAsync();
            }
        }

        public static async Task Execute_Command_2(SqlConnectionStringBuilder connectionString)
        {
            using var conn = new SqlConnection(connectionString.ConnectionString);
            using var cmd = conn.CreateCommand();

            try
            {
                await conn.OpenAsync().ConfigureAwait(false);
                cmd.CommandText = "SELECT 1";
                var result = cmd.ExecuteScalarAsync();
            }
            finally
            {
                await conn.CloseAsync();
            }
        }

        public static async Task Execute_Command_3(SqlConnectionStringBuilder connectionString)
        {
            using var conn = new SqlConnection(connectionString.ConnectionString);
            using var cmd = conn.CreateCommand();

            try
            {
                await conn.OpenAsync().ConfigureAwait(false);
                cmd.CommandText = "SELECT 1";
                var result = cmd.ExecuteScalarAsync();
            }
            finally
            {
                await conn.CloseAsync();
            }
        }

        public static async Task Execute_Command_4(SqlConnectionStringBuilder connectionString)
        {
            using var conn = new SqlConnection(connectionString.ConnectionString);
            using var cmd = conn.CreateCommand();

            try
            {
                await conn.OpenAsync().ConfigureAwait(false);
                cmd.CommandText = "SELECT 1";
                var result = cmd.ExecuteScalarAsync();
            }
            finally
            {
                await conn.CloseAsync();
            }
        }

    }
}