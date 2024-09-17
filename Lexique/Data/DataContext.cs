using Microsoft.EntityFrameworkCore;

namespace Lexique.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
           : base(options)
        {
        }

        public DbSet<Lexique> Lexiques { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lexique>().ToTable("lexique", schema: "lexique");
        }
    }
}
