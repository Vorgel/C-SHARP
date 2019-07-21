using System;

namespace TestingInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new ConsoleLogger());
            dbMigrator.Migrate();

            Console.ReadKey();
        }
    }
}
