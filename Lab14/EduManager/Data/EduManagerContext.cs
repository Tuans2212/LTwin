using Microsoft.EntityFrameworkCore;
using EduManager.Models;

namespace EduManager.Data
{
    public class EduManagerContext : DbContext
    {
        public DbSet<MonHoc> MonHocs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string ketNoi = @"Data Source=DESKTOP-LLS5J07\SQLEXPRESS;Initial Catalog=EduManagerDB;Integrated Security=True;TrustServerCertificate=True";
                optionsBuilder.UseSqlServer(ketNoi);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MonHoc>(entity =>
            {
                entity.ToTable("MONHOC");
                entity.HasKey(m => m.MaMonHoc);

                entity.Property(m => m.MaMonHoc)
                    .HasMaxLength(10)
                    .IsRequired();

                entity.Property(m => m.TenMonHoc)
                    .HasMaxLength(100)
                    .IsRequired();

                entity.Property(m => m.SoTinChi)
                    .IsRequired();

                entity.Property(m => m.TrangThai)
                    .HasDefaultValue(true);
            });
        }
    }
}
