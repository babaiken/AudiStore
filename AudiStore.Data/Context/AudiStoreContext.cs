using System;
using System.IO;
using AudiStore.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AudiStore.Data
{
    public class AudiStoreContext : DbContext
    {
        public AudiStoreContext(
            DbContextOptions<AudiStoreContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = config.GetConnectionString("AudiStoreContext");
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Car> Car { get; set; }
    }
}