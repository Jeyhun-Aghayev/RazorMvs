using Microsoft.EntityFrameworkCore;
using Razor.Models;

namespace Razor.Data
{
    public class RazorContext : DbContext
    {
        public RazorContext(DbContextOptions<RazorContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=localhost;database=Razor;Integrated Security=true;TrustServerCertificate=True;Trusted_connection=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .Property(m => m.Price)
                .HasColumnType("decimal(18,2)");
        }
    }
}
