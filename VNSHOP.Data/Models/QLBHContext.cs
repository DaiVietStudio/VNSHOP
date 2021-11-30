using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace VNSHOP.Data.Models
{
    public partial class QLBHContext : DbContext
    {
        public QLBHContext()
        {
        }

        public QLBHContext(DbContextOptions<QLBHContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChiTietPhieuBanHang> ChiTietPhieuBanHangs { get; set; }
        public virtual DbSet<ChiTietPhieuBaoGium> ChiTietPhieuBaoGia { get; set; }
        public virtual DbSet<ChiTietPhieuNhapKho> ChiTietPhieuNhapKhos { get; set; }
        public virtual DbSet<ChiTietPhieuNo> ChiTietPhieuNos { get; set; }
        public virtual DbSet<DonViTinh> DonViTinhs { get; set; }
        public virtual DbSet<DonViTinhSanPham> DonViTinhSanPhams { get; set; }
        public virtual DbSet<Huyen> Huyens { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<KhoHang> KhoHangs { get; set; }
        public virtual DbSet<KhoHangSanPham> KhoHangSanPhams { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhieuBanHang> PhieuBanHangs { get; set; }
        public virtual DbSet<PhieuBaoGium> PhieuBaoGia { get; set; }
        public virtual DbSet<PhieuNhapKho> PhieuNhapKhos { get; set; }
        public virtual DbSet<PhieuNo> PhieuNos { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<ThongTinDonVi> ThongTinDonVis { get; set; }
        public virtual DbSet<Tinh> Tinhs { get; set; }
        public virtual DbSet<Xa> Xas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-MMSE614\\SQLEXPRESS;Database=QLBH;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ChiTietPhieuBanHang>(entity =>
            {
                entity.ToTable("ChiTietPhieuBanHang");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DonViTinh).HasColumnType("text");

                entity.HasOne(d => d.PhieuNavigation)
                    .WithMany(p => p.ChiTietPhieuBanHangs)
                    .HasForeignKey(d => d.Phieu)
                    .HasConstraintName("FK_ChiTietPhieuBanHang_PhieuBanHang");

                entity.HasOne(d => d.SanPhamNavigation)
                    .WithMany(p => p.ChiTietPhieuBanHangs)
                    .HasForeignKey(d => d.SanPham)
                    .HasConstraintName("FK_ChiTietPhieuBanHang_SanPham");
            });

            modelBuilder.Entity<ChiTietPhieuBaoGium>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.SoLuong)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.HasOne(d => d.PhieuNavigation)
                    .WithMany(p => p.ChiTietPhieuBaoGia)
                    .HasForeignKey(d => d.Phieu)
                    .HasConstraintName("FK_ChiTietPhieuBaoGia_PhieuBaoGia");
            });

            modelBuilder.Entity<ChiTietPhieuNhapKho>(entity =>
            {
                entity.ToTable("ChiTietPhieuNhapKho");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.HasOne(d => d.PhieuNavigation)
                    .WithMany(p => p.ChiTietPhieuNhapKhos)
                    .HasForeignKey(d => d.Phieu)
                    .HasConstraintName("FK_ChiTietPhieuNhapKho_PhieuNhapKho");

                entity.HasOne(d => d.SanPhamNavigation)
                    .WithMany(p => p.ChiTietPhieuNhapKhos)
                    .HasForeignKey(d => d.SanPham)
                    .HasConstraintName("FK_ChiTietPhieuNhapKho_SanPham");
            });

            modelBuilder.Entity<ChiTietPhieuNo>(entity =>
            {
                entity.ToTable("ChiTietPhieuNo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DonViTinh).HasMaxLength(50);

                entity.Property(e => e.SanPham).HasMaxLength(1000);

                entity.HasOne(d => d.PhieuNavigation)
                    .WithMany(p => p.ChiTietPhieuNos)
                    .HasForeignKey(d => d.Phieu)
                    .HasConstraintName("FK_ChiTietPhieuNo_PhieuNo");
            });

            modelBuilder.Entity<DonViTinh>(entity =>
            {
                entity.ToTable("DonViTinh");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MoTa).HasMaxLength(50);

                entity.Property(e => e.TenDonVi).HasMaxLength(50);
            });

            modelBuilder.Entity<DonViTinhSanPham>(entity =>
            {
                entity.ToTable("DonViTinh_SanPham");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.HasOne(d => d.DonViTinhNavigation)
                    .WithMany(p => p.DonViTinhSanPhams)
                    .HasForeignKey(d => d.DonViTinh)
                    .HasConstraintName("FK_DonViTinh_SanPham_DonViTinh");

                entity.HasOne(d => d.SanPhamNavigation)
                    .WithMany(p => p.DonViTinhSanPhams)
                    .HasForeignKey(d => d.SanPham)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_DonViTinh_SanPham_SanPham1");
            });

            modelBuilder.Entity<Huyen>(entity =>
            {
                entity.ToTable("Huyen");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Ten).HasMaxLength(100);

                entity.HasOne(d => d.TinhNavigation)
                    .WithMany(p => p.Huyens)
                    .HasForeignKey(d => d.Tinh)
                    .HasConstraintName("FK_Huyen_Tinh");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.ToTable("KhachHang");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DiaChi).HasMaxLength(100);

                entity.Property(e => e.SoDienThoai)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TenKhachHang).HasMaxLength(1000);

                entity.HasOne(d => d.HuyenNavigation)
                    .WithMany(p => p.KhachHangs)
                    .HasForeignKey(d => d.Huyen)
                    .HasConstraintName("FK_KhachHang_Huyen");

                entity.HasOne(d => d.TinhNavigation)
                    .WithMany(p => p.KhachHangs)
                    .HasForeignKey(d => d.Tinh)
                    .HasConstraintName("FK_KhachHang_Tinh");

                entity.HasOne(d => d.XaNavigation)
                    .WithMany(p => p.KhachHangs)
                    .HasForeignKey(d => d.Xa)
                    .HasConstraintName("FK_KhachHang_Xa");
            });

            modelBuilder.Entity<KhoHang>(entity =>
            {
                entity.ToTable("KhoHang");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.TenKho).HasMaxLength(200);
            });

            modelBuilder.Entity<KhoHangSanPham>(entity =>
            {
                entity.ToTable("KhoHang_SanPham");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.HasOne(d => d.KhoHangNavigation)
                    .WithMany(p => p.KhoHangSanPhams)
                    .HasForeignKey(d => d.KhoHang)
                    .HasConstraintName("FK_KhoHang_SanPham_KhoHang");

                entity.HasOne(d => d.KhoHang1)
                    .WithMany(p => p.KhoHangSanPhams)
                    .HasForeignKey(d => d.KhoHang)
                    .HasConstraintName("FK_KhoHang_SanPham_SanPham");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.ToTable("NhanVien");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DiaChi).HasMaxLength(500);

                entity.Property(e => e.HoVaTen).HasMaxLength(1000);

                entity.Property(e => e.SoDienThoai)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<PhieuBanHang>(entity =>
            {
                entity.ToTable("PhieuBanHang");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MaSo).HasMaxLength(50);

                entity.Property(e => e.NgayNhap).HasColumnType("date");

                entity.HasOne(d => d.KhachHangNavigation)
                    .WithMany(p => p.PhieuBanHangs)
                    .HasForeignKey(d => d.KhachHang)
                    .HasConstraintName("FK_PhieuBanHang_KhachHang");
            });

            modelBuilder.Entity<PhieuBaoGium>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NgayNhap).HasColumnType("date");

                entity.HasOne(d => d.DonViBaoGiaNavigation)
                    .WithMany(p => p.PhieuBaoGia)
                    .HasForeignKey(d => d.DonViBaoGia)
                    .HasConstraintName("FK_PhieuBaoGia_KhachHang");
            });

            modelBuilder.Entity<PhieuNhapKho>(entity =>
            {
                entity.ToTable("PhieuNhapKho");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MaSo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NgayNhap).HasColumnType("date");

                entity.HasOne(d => d.NhapCungCapNavigation)
                    .WithMany(p => p.PhieuNhapKhos)
                    .HasForeignKey(d => d.NhapCungCap)
                    .HasConstraintName("FK_PhieuNhapKho_KhachHang");
            });

            modelBuilder.Entity<PhieuNo>(entity =>
            {
                entity.ToTable("PhieuNo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MaSo).HasMaxLength(50);

                entity.Property(e => e.NgayNhap).HasColumnType("date");

                entity.Property(e => e.NgayTra).HasColumnType("date");

                entity.HasOne(d => d.KhachHangNavigation)
                    .WithMany(p => p.PhieuNos)
                    .HasForeignKey(d => d.KhachHang)
                    .HasConstraintName("FK_PhieuNo_KhachHang");
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.ToTable("SanPham");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.HinhAnh).HasColumnType("image");

                entity.Property(e => e.MaSanPham).HasMaxLength(50);

                entity.Property(e => e.MoTa).HasMaxLength(100);

                entity.Property(e => e.NgayHetHan).HasColumnType("date");

                entity.Property(e => e.NgaySanXuat).HasColumnType("date");

                entity.Property(e => e.TenSanPham).HasMaxLength(1000);

                entity.Property(e => e.ThueVat).HasColumnName("ThueVAT");

                entity.HasOne(d => d.DonViTinhNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.DonViTinh)
                    .HasConstraintName("FK_SanPham_DonViTinh");
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.ToTable("TaiKhoan");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MatKhau).HasMaxLength(600);

                entity.Property(e => e.TenDangNhap).HasMaxLength(50);

                entity.HasOne(d => d.NhanVienNavigation)
                    .WithMany(p => p.TaiKhoans)
                    .HasForeignKey(d => d.NhanVien)
                    .HasConstraintName("FK_TaiKhoan_NhanVien");
            });

            modelBuilder.Entity<ThongTinDonVi>(entity =>
            {
                entity.ToTable("ThongTinDonVi");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DiaChi).HasMaxLength(1000);

                entity.Property(e => e.Email)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.KyTen).HasMaxLength(300);

                entity.Property(e => e.SoDienThoai)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.TenDonVi).HasMaxLength(100);

                entity.Property(e => e.Website)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Tinh>(entity =>
            {
                entity.ToTable("Tinh");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Ten).HasMaxLength(100);
            });

            modelBuilder.Entity<Xa>(entity =>
            {
                entity.ToTable("Xa");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ten).HasMaxLength(100);

                entity.HasOne(d => d.HuyenNavigation)
                    .WithMany(p => p.Xas)
                    .HasForeignKey(d => d.Huyen)
                    .HasConstraintName("FK_Xa_Huyen");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
