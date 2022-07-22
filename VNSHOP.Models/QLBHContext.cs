using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace VNSHOP.Models
{
    public partial class QLBHContext : DbContext
    {
        public QLBHContext()
            : base("name=QLBHContext")
        {
        }

        public virtual DbSet<ChiTietPhieuBanHang> ChiTietPhieuBanHangs { get; set; }
        public virtual DbSet<ChiTietPhieuBaoGia> ChiTietPhieuBaoGias { get; set; }
        public virtual DbSet<ChiTietPhieuNhapKho> ChiTietPhieuNhapKhoes { get; set; }
        public virtual DbSet<ChiTietPhieuNo> ChiTietPhieuNoes { get; set; }
        public virtual DbSet<DonViTinh> DonViTinhs { get; set; }
        public virtual DbSet<DonViTinh_SanPham> DonViTinh_SanPham { get; set; }
        public virtual DbSet<Huyen> Huyens { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<KhoHang> KhoHangs { get; set; }
        public virtual DbSet<KhoHang_SanPham> KhoHang_SanPham { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhieuBanHang> PhieuBanHangs { get; set; }
        public virtual DbSet<PhieuBaoGia> PhieuBaoGias { get; set; }
        public virtual DbSet<PhieuNhapKho> PhieuNhapKhoes { get; set; }
        public virtual DbSet<PhieuNo> PhieuNoes { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<ThongTinDonVi> ThongTinDonVis { get; set; }
        public virtual DbSet<Tinh> Tinhs { get; set; }
        public virtual DbSet<Xa> Xas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietPhieuBanHang>()
                .Property(e => e.DonViTinh)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietPhieuBaoGia>()
                .Property(e => e.SoLuong)
                .IsFixedLength();

            modelBuilder.Entity<DonViTinh>()
                .HasMany(e => e.DonViTinh_SanPham)
                .WithOptional(e => e.DonViTinh1)
                .HasForeignKey(e => e.DonViTinh);

            modelBuilder.Entity<DonViTinh>()
                .HasMany(e => e.SanPhams)
                .WithOptional(e => e.DonViTinh1)
                .HasForeignKey(e => e.DonViTinh);

            modelBuilder.Entity<Huyen>()
                .HasMany(e => e.KhachHangs)
                .WithOptional(e => e.Huyen1)
                .HasForeignKey(e => e.Huyen);

            modelBuilder.Entity<Huyen>()
                .HasMany(e => e.Xas)
                .WithOptional(e => e.Huyen1)
                .HasForeignKey(e => e.Huyen);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SoDienThoai)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.PhieuBanHangs)
                .WithOptional(e => e.KhachHang1)
                .HasForeignKey(e => e.KhachHang);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.PhieuBaoGias)
                .WithOptional(e => e.KhachHang)
                .HasForeignKey(e => e.DonViBaoGia);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.PhieuNhapKhoes)
                .WithOptional(e => e.KhachHang)
                .HasForeignKey(e => e.NhapCungCap);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.PhieuNoes)
                .WithOptional(e => e.KhachHang1)
                .HasForeignKey(e => e.KhachHang);

            modelBuilder.Entity<KhoHang>()
                .HasMany(e => e.KhoHang_SanPham)
                .WithOptional(e => e.KhoHang1)
                .HasForeignKey(e => e.KhoHang);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SoDienThoai)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.TaiKhoans)
                .WithOptional(e => e.NhanVien1)
                .HasForeignKey(e => e.NhanVien);

            modelBuilder.Entity<PhieuBanHang>()
                .HasMany(e => e.ChiTietPhieuBanHangs)
                .WithOptional(e => e.PhieuBanHang)
                .HasForeignKey(e => e.Phieu);

            modelBuilder.Entity<PhieuBaoGia>()
                .HasMany(e => e.ChiTietPhieuBaoGias)
                .WithOptional(e => e.PhieuBaoGia)
                .HasForeignKey(e => e.Phieu);

            modelBuilder.Entity<PhieuNhapKho>()
                .Property(e => e.MaSo)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuNhapKho>()
                .HasMany(e => e.ChiTietPhieuNhapKhoes)
                .WithOptional(e => e.PhieuNhapKho)
                .HasForeignKey(e => e.Phieu);

            modelBuilder.Entity<PhieuNo>()
                .HasMany(e => e.ChiTietPhieuNoes)
                .WithOptional(e => e.PhieuNo)
                .HasForeignKey(e => e.Phieu);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.ChiTietPhieuBanHangs)
                .WithOptional(e => e.SanPham1)
                .HasForeignKey(e => e.SanPham);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.ChiTietPhieuNhapKhoes)
                .WithOptional(e => e.SanPham1)
                .HasForeignKey(e => e.SanPham);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.DonViTinh_SanPham)
                .WithOptional(e => e.SanPham1)
                .HasForeignKey(e => e.SanPham)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.KhoHang_SanPham)
                .WithOptional(e => e.SanPham1)
                .HasForeignKey(e => e.KhoHang);

            modelBuilder.Entity<ThongTinDonVi>()
                .Property(e => e.SoDienThoai)
                .IsFixedLength();

            modelBuilder.Entity<ThongTinDonVi>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<ThongTinDonVi>()
                .Property(e => e.Website)
                .IsFixedLength();

            modelBuilder.Entity<Tinh>()
                .HasMany(e => e.Huyens)
                .WithOptional(e => e.Tinh1)
                .HasForeignKey(e => e.Tinh);

            modelBuilder.Entity<Tinh>()
                .HasMany(e => e.KhachHangs)
                .WithOptional(e => e.Tinh1)
                .HasForeignKey(e => e.Tinh);

            modelBuilder.Entity<Xa>()
                .HasMany(e => e.KhachHangs)
                .WithOptional(e => e.Xa1)
                .HasForeignKey(e => e.Xa);
        }
    }
}
