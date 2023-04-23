using System;

namespace DbHandling
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString)
            : base(connectionString)
        {
            
        }

        public override void Open()
        {
            Console.Write($"Connecting to SQL server with connection string: {ConnectionString}");
            Console.WriteLine($" | Connection instance: {ConnectionId}");
        }

        public override void Close()
        {
            Console.WriteLine($"Closing connection with SQL server.\nClosed connection with instance Id: {ConnectionId}");
        }
    }
}