using System;

namespace TestingInterfaces
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("Migration started at " + DateTime.Now);

            //details of migration 

            _logger.LogInfo("Migration finished at " + DateTime.Now);
        }
    }
}
