using System.Configuration;
using HomeLog.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeLog.Data
{
    public class HomeLogContext : DbContext
    {
        public DbSet<Kategori> Kategoriler => Set<Kategori>();
        public DbSet<Cihaz> Cihazlar => Set<Cihaz>();
        public DbSet<BakimKaydi> BakimKayitlari => Set<BakimKaydi>();

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var cs = ConfigurationManager.ConnectionStrings["HomeLogDb"].ConnectionString;
            options.UseSqlServer(cs);
        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ElektrikliCihaz>();
            mb.Entity<Mobilya>();
            mb.Entity<BakimKaydi>().Property(b => b.Ucret).HasPrecision(10, 2);
            mb.Entity<Kategori>().HasData(
                new Kategori { KategoriID = 1, KategoriAdi = "Beyaz Eşya" },
                new Kategori { KategoriID = 2, KategoriAdi = "Elektronik" },
                new Kategori { KategoriID = 3, KategoriAdi = "Mobilya" });
        }
    }
}