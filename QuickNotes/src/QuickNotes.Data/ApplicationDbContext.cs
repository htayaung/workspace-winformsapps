using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using QuickNotes.Core.Entities;

namespace QuickNotes.Data
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IConfiguration configuration;

        public DbSet<Note> Notes { get; set; }

        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options,
            IConfiguration configuration)
            : base(options)
        {
            this.configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection") ?? string.Empty;
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentNullException(nameof(connectionString), "Connection string cannot be null.");
            }

            optionsBuilder.UseSqlite(connectionString);
        }
    }
}
