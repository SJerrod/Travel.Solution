using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.Design;

namespace TravelClient.Models
{
    public class TravelClientContextTravelClient : IDesignTimeDbContextFactory<TravelClientContext>
    {
        TravelClientContext IDesignTimeDbContextFactory<TravelClientContext>.CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<TravelClientContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            builder.UseMySql(connectionString);

            return new TravelClientContext(builder.Options);
        }
    }
}