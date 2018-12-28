using System.IO;
using Ease.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Ease.API
{
    public class ContextFactory : IDesignTimeDbContextFactory<EaseContext>
    {
        public EaseContext CreateDbContext()
        {
            return CreateDbContext(null);
        }

        public EaseContext CreateDbContext(string[] args)
        {
            var builderConfiguration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("config.json");
            var configuration = builderConfiguration.Build();
            var connectionString = configuration.GetConnectionString("EaseDB");

            var builder = new DbContextOptionsBuilder<EaseContext>();
            builder.UseSqlServer(connectionString);

            return new EaseContext(builder.Options);
        }
    }
}