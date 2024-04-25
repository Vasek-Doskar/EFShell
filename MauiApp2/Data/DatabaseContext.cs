using MauiApp2.Model;
using Microsoft.EntityFrameworkCore;

namespace MauiApp2.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() => Database.EnsureCreated();

        /// <summary>
        /// Tabulka se zvířátky :)
        /// </summary>
        public DbSet<Zvire> Zvirata { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Database.db");
        }
    }
}
