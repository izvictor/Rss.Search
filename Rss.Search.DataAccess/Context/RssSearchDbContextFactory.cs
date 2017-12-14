using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Rss.Search.DataAccess.Context
{
    public class RssSearchDbContextFactory : IDesignTimeDbContextFactory<RssSearchDbContext>
    {
        public RssSearchDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<RssSearchDbContext>();
            var connectionString = configuration.GetConnectionString("RssSearchConnection");
            builder.UseSqlServer(connectionString);
            return new RssSearchDbContext(builder.Options);
        }

    }
}