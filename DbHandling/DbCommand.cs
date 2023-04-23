using System;

namespace DbHandling
{
    public class DbCommand
    {
        public string Instruction { get; set; }

        public DbConnection Connection { get; set; }

        public DbCommand(DbConnection connection, string instruction)
        {
            Connection = connection ?? throw new ArgumentNullException(nameof(connection));

            if (string.IsNullOrEmpty(instruction))
            {
                throw new ArgumentNullException(instruction);
            }
            Instruction = instruction;
        }

        public bool Execute()
        {
            try
            {
                Connection.Open();
                Console.WriteLine($"Instruction complete: {Instruction}");
                Connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Command failed: ");
                Console.WriteLine(e.ToString());
                return false;
            }
            return true;
        }
    }
}