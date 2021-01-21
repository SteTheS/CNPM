namespace QuanLyThuVien.DAL.Database
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QuanLyThuVienbd : DbContext
    {
        public QuanLyThuVienbd()
            : base("name=QuanLyThuVienbd")
        {
        }

        public virtual DbSet<DocGia> DocGias { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<phieumuonsach> phieumuonsaches { get; set; }
        public virtual DbSet<Sach> Saches { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DocGia>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<DocGia>()
                .Property(e => e.sdt)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DocGia>()
                .Property(e => e.cmnd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DocGia>()
                .HasMany(e => e.phieumuonsaches)
                .WithRequired(e => e.DocGia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.manhanvien)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.matkhau)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.sdt)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.cmnd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<phieumuonsach>()
                .Property(e => e.masach)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sach>()
                .Property(e => e.masach)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sach>()
                .Property(e => e.namxuatban)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sach>()
                .HasMany(e => e.phieumuonsaches)
                .WithRequired(e => e.Sach)
                .WillCascadeOnDelete(false);
        }
    }
}
