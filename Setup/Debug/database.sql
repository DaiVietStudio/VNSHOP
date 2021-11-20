USE [master]
GO
/****** Object:  Database [QLBH]    Script Date: 17/11/2021 10:39:42 AM ******/
CREATE DATABASE [QLBH]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLBH', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QLBH.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLBH_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QLBH_log.ldf' , SIZE = 7616KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLBH] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLBH].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLBH] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLBH] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLBH] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLBH] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLBH] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLBH] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLBH] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLBH] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLBH] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLBH] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLBH] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLBH] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLBH] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLBH] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLBH] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLBH] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLBH] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLBH] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLBH] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLBH] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLBH] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLBH] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLBH] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLBH] SET  MULTI_USER 
GO
ALTER DATABASE [QLBH] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLBH] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLBH] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLBH] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLBH] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QLBH]
GO
/****** Object:  Table [dbo].[ChiTietPhieuBanHang]    Script Date: 17/11/2021 10:39:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuBanHang](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[Phieu] [bigint] NULL,
	[SanPham] [bigint] NULL,
	[SoLuong] [float] NULL,
	[GiaBan] [float] NULL,
	[GiamGia] [float] NULL,
	[DonViTinh] [text] NULL,
 CONSTRAINT [PK_ChiTietPhieuBanHang] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietPhieuBaoGia]    Script Date: 17/11/2021 10:39:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuBaoGia](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[Phieu] [bigint] NULL,
	[SanPham] [int] NULL,
	[Gia] [float] NULL,
	[SoLuong] [nchar](10) NULL,
 CONSTRAINT [PK_ChiTietPhieuBaoGia] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietPhieuNhapKho]    Script Date: 17/11/2021 10:39:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhapKho](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[Phieu] [bigint] NULL,
	[SanPham] [bigint] NULL,
	[SoLuong] [float] NULL,
	[DonGia] [float] NULL,
 CONSTRAINT [PK_ChiTietPhieuNhapKho] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietPhieuNo]    Script Date: 17/11/2021 10:39:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNo](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[Phieu] [bigint] NULL,
	[SanPham] [nvarchar](1000) NULL,
	[Gia] [float] NULL,
	[SoLuong] [float] NULL,
	[DonViTinh] [nvarchar](50) NULL,
 CONSTRAINT [PK_ChiTietPhieuNo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DonViTinh]    Script Date: 17/11/2021 10:39:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonViTinh](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[TenDonVi] [nvarchar](50) NULL,
	[MoTa] [nvarchar](50) NULL,
 CONSTRAINT [PK_DonViTinh] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DonViTinh_SanPham]    Script Date: 17/11/2021 10:39:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonViTinh_SanPham](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[DonViTinh] [bigint] NULL,
	[SanPham] [bigint] NULL,
	[GiaLe] [float] NULL,
	[GiaSi] [float] NULL,
 CONSTRAINT [PK_DonViTinh_SanPham] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Huyen]    Script Date: 17/11/2021 10:39:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Huyen](
	[id] [bigint] NOT NULL,
	[Ten] [nvarchar](100) NULL,
	[Tinh] [bigint] NULL,
 CONSTRAINT [PK_Huyen] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 17/11/2021 10:39:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[Loai] [int] NULL,
	[TenKhachHang] [nvarchar](1000) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[SoDienThoai] [nchar](10) NULL,
	[Tinh] [bigint] NULL,
	[Huyen] [bigint] NULL,
	[Xa] [bigint] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhoHang]    Script Date: 17/11/2021 10:39:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhoHang](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[TenKho] [nvarchar](200) NULL,
 CONSTRAINT [PK_KhoHang] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhoHang_SanPham]    Script Date: 17/11/2021 10:39:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhoHang_SanPham](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[KhoHang] [bigint] NULL,
	[SanPham] [bigint] NULL,
	[SoLuong] [float] NULL,
 CONSTRAINT [PK_KhoHang_SanPham] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 17/11/2021 10:39:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[HoVaTen] [nvarchar](1000) NULL,
	[GioiTinh] [int] NULL,
	[DiaChi] [nvarchar](500) NULL,
	[SoDienThoai] [nchar](10) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuBanHang]    Script Date: 17/11/2021 10:39:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuBanHang](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[MaSo] [nvarchar](50) NULL,
	[NgayNhap] [date] NULL,
	[KhachHang] [bigint] NULL,
	[NhanVien] [bigint] NULL,
	[Loai] [int] NULL,
 CONSTRAINT [PK_PhieuBanHang] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuBaoGia]    Script Date: 17/11/2021 10:39:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuBaoGia](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[NgayNhap] [date] NULL,
	[DonViBaoGia] [bigint] NULL,
 CONSTRAINT [PK_PhieuBaoGia] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuNhapKho]    Script Date: 17/11/2021 10:39:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuNhapKho](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[MaSo] [varchar](50) NULL,
	[NgayNhap] [date] NULL,
	[TongTien] [float] NULL,
	[NhapCungCap] [bigint] NULL,
 CONSTRAINT [PK_PhieuNhapKho] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuNo]    Script Date: 17/11/2021 10:39:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNo](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[MaSo] [nvarchar](50) NULL,
	[NgayNhap] [date] NULL,
	[KhachHang] [bigint] NULL,
	[TinhTrang] [bit] NULL,
	[NgayTra] [date] NULL,
	[DaTra] [float] NULL,
	[ConNo] [float] NULL,
 CONSTRAINT [PK_PhieuNo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 17/11/2021 10:39:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[TenSanPham] [nvarchar](1000) NULL,
	[MaSanPham] [nvarchar](50) NULL,
	[MoTa] [nvarchar](100) NULL,
	[GiaNhap] [float] NULL,
	[GiaLe] [float] NULL,
	[DonViTinh] [bigint] NULL,
	[ThueVAT] [float] NULL,
	[KichHoat] [bit] NULL,
	[HinhAnh] [image] NULL,
	[QuanLyTonKho] [bigint] NULL,
	[NgaySanXuat] [date] NULL,
	[NgayHetHan] [date] NULL,
	[GiaSi] [float] NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 17/11/2021 10:39:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[TenDangNhap] [nvarchar](50) NULL,
	[MatKhau] [nvarchar](600) NULL,
	[NhanVien] [bigint] NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThongTinDonVi]    Script Date: 17/11/2021 10:39:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTinDonVi](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TenDonVi] [nvarchar](100) NULL,
	[DiaChi] [nvarchar](1000) NULL,
	[SoDienThoai] [nchar](50) NULL,
	[Email] [nchar](10) NULL,
	[Website] [nchar](10) NULL,
	[KyTen] [nvarchar](300) NULL,
 CONSTRAINT [PK_ThongTinDonVi] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tinh]    Script Date: 17/11/2021 10:39:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tinh](
	[id] [bigint] NOT NULL,
	[Ten] [nvarchar](100) NULL,
 CONSTRAINT [PK_Tinh] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Xa]    Script Date: 17/11/2021 10:39:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Xa](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](100) NULL,
	[Huyen] [bigint] NULL,
 CONSTRAINT [PK_Xa] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[ChiTietPhieuBanHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuBanHang_PhieuBanHang] FOREIGN KEY([Phieu])
REFERENCES [dbo].[PhieuBanHang] ([id])
GO
ALTER TABLE [dbo].[ChiTietPhieuBanHang] CHECK CONSTRAINT [FK_ChiTietPhieuBanHang_PhieuBanHang]
GO
ALTER TABLE [dbo].[ChiTietPhieuBanHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuBanHang_SanPham] FOREIGN KEY([SanPham])
REFERENCES [dbo].[SanPham] ([id])
GO
ALTER TABLE [dbo].[ChiTietPhieuBanHang] CHECK CONSTRAINT [FK_ChiTietPhieuBanHang_SanPham]
GO
ALTER TABLE [dbo].[ChiTietPhieuBaoGia]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuBaoGia_PhieuBaoGia] FOREIGN KEY([Phieu])
REFERENCES [dbo].[PhieuBaoGia] ([id])
GO
ALTER TABLE [dbo].[ChiTietPhieuBaoGia] CHECK CONSTRAINT [FK_ChiTietPhieuBaoGia_PhieuBaoGia]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhapKho]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhapKho_PhieuNhapKho] FOREIGN KEY([Phieu])
REFERENCES [dbo].[PhieuNhapKho] ([id])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhapKho] CHECK CONSTRAINT [FK_ChiTietPhieuNhapKho_PhieuNhapKho]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhapKho]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhapKho_SanPham] FOREIGN KEY([SanPham])
REFERENCES [dbo].[SanPham] ([id])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhapKho] CHECK CONSTRAINT [FK_ChiTietPhieuNhapKho_SanPham]
GO
ALTER TABLE [dbo].[ChiTietPhieuNo]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNo_PhieuNo] FOREIGN KEY([Phieu])
REFERENCES [dbo].[PhieuNo] ([id])
GO
ALTER TABLE [dbo].[ChiTietPhieuNo] CHECK CONSTRAINT [FK_ChiTietPhieuNo_PhieuNo]
GO
ALTER TABLE [dbo].[DonViTinh_SanPham]  WITH CHECK ADD  CONSTRAINT [FK_DonViTinh_SanPham_DonViTinh] FOREIGN KEY([DonViTinh])
REFERENCES [dbo].[DonViTinh] ([id])
GO
ALTER TABLE [dbo].[DonViTinh_SanPham] CHECK CONSTRAINT [FK_DonViTinh_SanPham_DonViTinh]
GO
ALTER TABLE [dbo].[DonViTinh_SanPham]  WITH CHECK ADD  CONSTRAINT [FK_DonViTinh_SanPham_SanPham1] FOREIGN KEY([SanPham])
REFERENCES [dbo].[SanPham] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DonViTinh_SanPham] CHECK CONSTRAINT [FK_DonViTinh_SanPham_SanPham1]
GO
ALTER TABLE [dbo].[Huyen]  WITH CHECK ADD  CONSTRAINT [FK_Huyen_Tinh] FOREIGN KEY([Tinh])
REFERENCES [dbo].[Tinh] ([id])
GO
ALTER TABLE [dbo].[Huyen] CHECK CONSTRAINT [FK_Huyen_Tinh]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_Huyen] FOREIGN KEY([Huyen])
REFERENCES [dbo].[Huyen] ([id])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_Huyen]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_Tinh] FOREIGN KEY([Tinh])
REFERENCES [dbo].[Tinh] ([id])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_Tinh]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_Xa] FOREIGN KEY([Xa])
REFERENCES [dbo].[Xa] ([id])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_Xa]
GO
ALTER TABLE [dbo].[KhoHang_SanPham]  WITH CHECK ADD  CONSTRAINT [FK_KhoHang_SanPham_KhoHang] FOREIGN KEY([KhoHang])
REFERENCES [dbo].[KhoHang] ([id])
GO
ALTER TABLE [dbo].[KhoHang_SanPham] CHECK CONSTRAINT [FK_KhoHang_SanPham_KhoHang]
GO
ALTER TABLE [dbo].[KhoHang_SanPham]  WITH CHECK ADD  CONSTRAINT [FK_KhoHang_SanPham_SanPham] FOREIGN KEY([KhoHang])
REFERENCES [dbo].[SanPham] ([id])
GO
ALTER TABLE [dbo].[KhoHang_SanPham] CHECK CONSTRAINT [FK_KhoHang_SanPham_SanPham]
GO
ALTER TABLE [dbo].[PhieuBanHang]  WITH CHECK ADD  CONSTRAINT [FK_PhieuBanHang_KhachHang] FOREIGN KEY([KhachHang])
REFERENCES [dbo].[KhachHang] ([id])
GO
ALTER TABLE [dbo].[PhieuBanHang] CHECK CONSTRAINT [FK_PhieuBanHang_KhachHang]
GO
ALTER TABLE [dbo].[PhieuBaoGia]  WITH CHECK ADD  CONSTRAINT [FK_PhieuBaoGia_KhachHang] FOREIGN KEY([DonViBaoGia])
REFERENCES [dbo].[KhachHang] ([id])
GO
ALTER TABLE [dbo].[PhieuBaoGia] CHECK CONSTRAINT [FK_PhieuBaoGia_KhachHang]
GO
ALTER TABLE [dbo].[PhieuNhapKho]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhapKho_KhachHang] FOREIGN KEY([NhapCungCap])
REFERENCES [dbo].[KhachHang] ([id])
GO
ALTER TABLE [dbo].[PhieuNhapKho] CHECK CONSTRAINT [FK_PhieuNhapKho_KhachHang]
GO
ALTER TABLE [dbo].[PhieuNo]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNo_KhachHang] FOREIGN KEY([KhachHang])
REFERENCES [dbo].[KhachHang] ([id])
GO
ALTER TABLE [dbo].[PhieuNo] CHECK CONSTRAINT [FK_PhieuNo_KhachHang]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_DonViTinh] FOREIGN KEY([DonViTinh])
REFERENCES [dbo].[DonViTinh] ([id])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_DonViTinh]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_NhanVien] FOREIGN KEY([NhanVien])
REFERENCES [dbo].[NhanVien] ([id])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_NhanVien]
GO
ALTER TABLE [dbo].[Xa]  WITH CHECK ADD  CONSTRAINT [FK_Xa_Huyen] FOREIGN KEY([Huyen])
REFERENCES [dbo].[Huyen] ([id])
GO
ALTER TABLE [dbo].[Xa] CHECK CONSTRAINT [FK_Xa_Huyen]
GO
USE [master]
GO
ALTER DATABASE [QLBH] SET  READ_WRITE 
GO
