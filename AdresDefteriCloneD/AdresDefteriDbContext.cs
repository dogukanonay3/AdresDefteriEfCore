using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdresDefteriCloneD
{
    internal class AdresDefteriDbContext : DbContext
    {
        public DbSet<Musteri> Musteri { get; set; }
        public DbSet<Personel> Personel { get; set; }
        public DbSet<Paydas> Paydas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-OR82PAL\\SQLEXPRESS01;Database=AdresDefteri;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personel>()
                .Property(s => s.Id)
                .UseIdentityColumn();

            modelBuilder.Entity<Paydas>()
               .Property(s => s.Id)
               .UseIdentityColumn();

            modelBuilder.Entity<Musteri>()
               .Property(s => s.Id)
               .UseIdentityColumn();

        }


    }
}
