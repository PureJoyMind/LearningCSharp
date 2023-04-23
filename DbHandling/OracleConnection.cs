using System;

namespace DbHandling
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
            : base(connectionString)
        {

        }

        public override void Open()
        {
            Console.Write($"Connecting to Oracle server with connection string: {ConnectionString}");
            Console.WriteLine($" | Connection instance: {ConnectionId}");
        }

        public override void Close()
        {
            Console.WriteLine($"Closing connection with Oracle server.\nClosed connection with instance Id: {ConnectionId}");
        }
    }
}