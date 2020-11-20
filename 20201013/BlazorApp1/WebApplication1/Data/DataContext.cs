using BlazorApp1.Pages.Tareas;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = tareas.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<TipoTarea> TipoTareas { get; set; }

    }
}
