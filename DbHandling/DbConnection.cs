using System;

namespace DbHandling
{
    public abstract class DbConnection
    {
        protected static readonly Random random = new Random(DateTime.Now.Millisecond);
        protected string ConnectionString { get; set; }
        protected readonly TimeSpan Timeout = TimeSpan.FromSeconds(30);
        public int ConnectionId { get; private set; }

        protected DbConnection(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentNullException(nameof(connectionString));
            }
            if (connectionString.Contains(" "))
            {
                throw new ArgumentException("Invalid string.");
            }
            ConnectionString = connectionString;
            ConnectionId = random.Next(100000, 500000);
        }

        public abstract void Open();
        public abstract void Close();
    }
}