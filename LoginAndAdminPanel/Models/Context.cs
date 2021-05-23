using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginAndAdminPanel.Models
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-HGL39QT; database=DbSchollAdmin; integrated security=true;");
        }

        //default value true ataması - onmodelcreating ile yapılır
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Category>()
        //        .Property(b => b.Status)
        //        .HasDefaultValue(true);
        //}

        public DbSet<Kurucu> Kurucus { get; set; }//büyük ve çoğul
        public DbSet<Okul> Okuls { get; set; }
        public DbSet<Mudur> Mudurs { get; set; }
        public DbSet<Ogretmen> Ogretmens { get; set; }
        public DbSet<Ogrenci> Ogrencis { get; set; }
    }
}
