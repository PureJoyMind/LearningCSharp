using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbMigration
{
    internal partial class Program 
    {
        static void Main(string[] args)
        {
            var migrator = new DbMigrator(new ConsoleLog());
            migrator.Migrate();

            var fMigrate = new DbMigrator(new FileLog("E:\\log.txt"));
            fMigrate.Migrate();


        }
    }
}
