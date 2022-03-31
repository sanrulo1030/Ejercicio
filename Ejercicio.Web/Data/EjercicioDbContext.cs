using Ejercicio.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Ejercicio.Web.Data
{
    public class EjercicioDbContext:DbContext
    {
        public EjercicioDbContext(DbContextOptions<EjercicioDbContext> options) : base(options)
        {

        }

        public DbSet<Barrio> Barrios { get; set; }

        public DbSet<Alumno> Alumnos { get; set; }

        public DbSet<Municipio> Municipios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Barrio>()
                 .HasIndex(t => t.Name)
                 .IsUnique();

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Alumno>()
                 .HasIndex(t => t.Nombres)
                 .IsUnique();

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Municipio>()
                 .HasIndex(t => t.Name)
                 .IsUnique();



        }
    }
}
