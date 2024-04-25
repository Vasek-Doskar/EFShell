using MauiApp2.Model;
using Microsoft.EntityFrameworkCore;

namespace MauiApp2.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() => Database.EnsureCreated();

        /// <summary>
        /// Tabulka se psi :)
        /// </summary>
        public DbSet<Pes> Psi { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Database.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pes>().HasData(
                new Pes("Caesar", 13,1),
                new Pes("Bertík",30,2)
                );
        }

    }
}
