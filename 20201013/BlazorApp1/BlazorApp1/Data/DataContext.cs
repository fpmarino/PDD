using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            modelBuilder.Entity<Usuarios>().ToTable("Usuario");
            modelBuilder.Entity<Tareas>().ToTable("Tarea");
            modelBuilder.Entity<Recursos>().ToTable("Recurso");
            modelBuilder.Entity<Detalles>().ToTable("Detalle");
        }

        public DbSet<Usuarios> Usuario { get; set; }
        public DbSet<Tareas> Tarea { get; set; }
        public DbSet<Recursos> Recurso { get; set; }
        public DbSet<Detalles> Detalle { get; set; }
    }
}
