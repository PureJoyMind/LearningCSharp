using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sql1 = new SqlConnection("testSql1");
            var or1 = new OracleConnection("testOr1");

            var command = new DbCommand(sql1, "Do DB Work!");
            command.Execute();
            Console.WriteLine("\n\n");

            var command2 = new DbCommand(or1, "Oracle DB Work!");
            command2.Execute();
        }
    }
}
