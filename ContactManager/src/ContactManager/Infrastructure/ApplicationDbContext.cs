using ContactManager.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ContactManager.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        private readonly string connectionString;

        public DbSet<Contact> Contacts { get; set; }

        public ApplicationDbContext()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();
            connectionString = configuration.GetConnectionString("DefaultConnection") ?? string.Empty;
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentNullException(nameof(connectionString), "Connection string cannot be null.");
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(connectionString);
        }
    }
}
