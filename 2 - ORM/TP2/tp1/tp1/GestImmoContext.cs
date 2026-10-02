using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace tp1
{
    public class BloggingContext : DbContext
    {
        public DbSet<Bail> Baux { get; set; }
        public DbSet<Bien> Biens { get; set; }
        public DbSet<Locataire> Locataires { get; set; }
        public DbSet<Pret> Prets { get; set; }
        public DbSet<Intervention> Interventions { get; set; }
        public DbSet<Prestataire> Prestataires { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder
        optionsBuilder)
        =>
        optionsBuilder.UseNpgsql("Host=localhost;Database=gestImmo;Username=postgres;Password=postgres");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Habitable>().ToTable("Habitable");
            modelBuilder.Entity<Maison>().ToTable("Maison");
            modelBuilder.Entity<Box>().ToTable("Box");
            modelBuilder.Entity<Appartement>().ToTable("Appartment");
        }
    }
}

