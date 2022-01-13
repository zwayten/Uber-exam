using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

using GP.Domain.Entities;
using GP.Data.Configurations;
using System.Linq;

namespace GP.Data
{
    public class ExamenContext : DbContext
    {
        public ExamenContext()
        {
            Database.EnsureCreated();
        }

        public ExamenContext(DbContextOptions<ExamenContext> options) : base(options)
        {

        }

     
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new VoitureConfiguration());

            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(p => p.GetProperties()).Where(p => p.ClrType == typeof(string)))
            {
                property.SetMaxLength(150);
            }


        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             optionsBuilder.UseLazyLoadingProxies()
                .UseSqlServer(@"Server=localhost;Database=uber;Trusted_Connection=True;");
        }
   
        public DbSet<Chauffeur> Chauffeurs { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Voiture> voitures { get; set; }



    }
}
