using Language_Learning_App.DB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language_Learning_App.DB
{
    public class Context : DbContext
    {
        public DbSet<Translation> Translations { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Session> Sessions { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Context;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Translation>().HasData(
                new Translation { ID=1, WordToTranslate = "Hello", WordTranslation = "Cześć", Language = Language.Polish },
                new Translation { ID = 2, WordToTranslate ="Car", WordTranslation="Samochód", Language=Language.Polish},
                new Translation { ID = 3, WordToTranslate ="Castle", WordTranslation="Zamek", Language=Language.Polish});

            modelBuilder.Entity<User>().HasData(
                new User { ID=1, Name="Jessie"});
        }
    }
}
