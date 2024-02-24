namespace ProjectAllocation.API.Configurations
{
    public class DatabaseProvider
    {
        private readonly IConfiguration _configuration;

        public DatabaseProvider(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetConnectionString()
        {
            var usernameDatabase = Environment.GetEnvironmentVariable("DATABASE_USERNAME");
            var passwordDatabase = Environment.GetEnvironmentVariable("DATABASE_PASSWORD");

            var connString = _configuration.GetConnectionString("DatabasePostgres")
                .Replace("{DATABASE_USERNAME}", usernameDatabase)
                .Replace("{DATABASE_PASSWORD}", passwordDatabase);
            Console.WriteLine(connString);
            return connString;
        }
    }
}
