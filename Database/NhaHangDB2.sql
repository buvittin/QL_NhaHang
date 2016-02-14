USE [master]
GO
/****** Object:  Database [NhaHangDB]    Script Date: 02/14/2016 3:59:49 PM ******/
CREATE DATABASE [NhaHangDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'NhaHangDB', FILENAME = N'F:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\NhaHangDB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'NhaHangDB_log', FILENAME = N'F:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\NhaHangDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [NhaHangDB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [NhaHangDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [NhaHangDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [NhaHangDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [NhaHangDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [NhaHangDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [NhaHangDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [NhaHangDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [NhaHangDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [NhaHangDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [NhaHangDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [NhaHangDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [NhaHangDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [NhaHangDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [NhaHangDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [NhaHangDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [NhaHangDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [NhaHangDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [NhaHangDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [NhaHangDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [NhaHangDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [NhaHangDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [NhaHangDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [NhaHangDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [NhaHangDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [NhaHangDB] SET  MULTI_USER 
GO
ALTER DATABASE [NhaHangDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [NhaHangDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [NhaHangDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [NhaHangDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [NhaHangDB] SET DELAYED_DURABILITY = DISABLED 
GO
USE [NhaHangDB]
GO
/****** Object:  Table [dbo].[Ban]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ban](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Loaiban] [int] NULL,
 CONSTRAINT [PK_Ban] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietDatMon]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDatMon](
	[MaMon] [int] NOT NULL,
	[MaPhieu] [int] NOT NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_ChiTietDatMon] PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC,
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietNhapXuat]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietNhapXuat](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaPhieu] [int] NULL,
	[MaNguyenLieu] [int] NULL,
	[DonViTinh] [nchar](10) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
	[GhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK_ChiTietNhapXuat] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CongThucMon]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CongThucMon](
	[MaMon] [int] NOT NULL,
	[MaNguyenLieu] [int] NOT NULL,
	[SoLuong] [float] NULL,
 CONSTRAINT [PK_ChiTietCongThuc] PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC,
	[MaNguyenLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiBan]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiBan](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiBan] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiBan] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiNguyenLieu]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiNguyenLieu](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](100) NULL,
 CONSTRAINT [PK_LoaiNguyenLieu] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiSanPham] [nvarchar](100) NULL,
 CONSTRAINT [PK_LoaiMon] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiTaiKhoan]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiTaiKhoan](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiTaiKhoan] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiTaiKhoan] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Luong]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Luong](
	[ID] [int] NOT NULL,
	[NgayVaoLam] [date] NULL,
	[LuongThang] [int] NULL,
	[LuongNgay] [int] NULL,
	[LuongGio] [int] NULL,
	[GhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK_BangLuong] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Menu]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaSanPham] [int] NOT NULL,
	[HinhAnh] [nvarchar](100) NULL,
	[DonGia] [int] NULL,
	[LoaiSanPham] [int] NULL,
 CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Mon]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mon](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenMon] [nvarchar](100) NULL,
 CONSTRAINT [PK_Mon_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NguyenLieu]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguyenLieu](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenNguyenLieu] [nvarchar](50) NULL,
	[DonViTinh] [nchar](10) NULL,
	[MaLoai] [int] NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_NguyenLieu] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenNhaCungCap] [nvarchar](100) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [nchar](15) NULL,
	[GhiChu] [nvarchar](200) NULL,
	[DaXoa] [bit] NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[GioiTinh] [bit] NULL,
	[NgaySinh] [date] NULL,
	[CMND] [nchar](15) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[SoDienThoai] [nchar](15) NULL,
	[DaXoa] [bit] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhanCa]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanCa](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ngay] [date] NULL,
	[MaNhanVien] [int] NULL,
	[Ca1] [bit] NULL,
	[Ca2] [bit] NULL,
	[Ca3] [bit] NULL,
	[Ca4] [bit] NULL,
 CONSTRAINT [PK_PhanCa] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuDatMon]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuDatMon](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaNhanVien] [int] NULL,
	[MaBan] [int] NULL,
	[TenKhachHang] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[ThoiGian] [datetime] NULL,
	[DaThanhToan] [bit] NULL CONSTRAINT [DF_PhieuDatMon_DaThanhToan]  DEFAULT ((0)),
	[TongTien] [int] NULL,
 CONSTRAINT [PK_PhieuDatMon] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenTaiKhoan] [nvarchar](50) NULL,
	[MatKhau] [nvarchar](50) NULL,
	[LoaiTaiKhoan] [int] NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[XuatNhapKho]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[XuatNhapKho](
	[ID] [int] NOT NULL,
	[LoaiPhieu] [bit] NULL,
	[Ngay] [date] NULL,
	[NguoiXuat] [int] NULL,
	[GhiChu] [nvarchar](100) NULL,
	[NhaCungCap] [int] NULL,
 CONSTRAINT [PK_XuatNhapKho] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Ban] ON 

INSERT [dbo].[Ban] ([ID], [Loaiban]) VALUES (1, 1)
INSERT [dbo].[Ban] ([ID], [Loaiban]) VALUES (2, 1)
INSERT [dbo].[Ban] ([ID], [Loaiban]) VALUES (3, 1)
INSERT [dbo].[Ban] ([ID], [Loaiban]) VALUES (4, 1)
INSERT [dbo].[Ban] ([ID], [Loaiban]) VALUES (5, 1)
INSERT [dbo].[Ban] ([ID], [Loaiban]) VALUES (6, 1)
INSERT [dbo].[Ban] ([ID], [Loaiban]) VALUES (7, 1)
INSERT [dbo].[Ban] ([ID], [Loaiban]) VALUES (8, 1)
INSERT [dbo].[Ban] ([ID], [Loaiban]) VALUES (9, 1)
INSERT [dbo].[Ban] ([ID], [Loaiban]) VALUES (10, 1)
INSERT [dbo].[Ban] ([ID], [Loaiban]) VALUES (11, 1)
INSERT [dbo].[Ban] ([ID], [Loaiban]) VALUES (12, 1)
INSERT [dbo].[Ban] ([ID], [Loaiban]) VALUES (13, 1)
INSERT [dbo].[Ban] ([ID], [Loaiban]) VALUES (14, 1)
INSERT [dbo].[Ban] ([ID], [Loaiban]) VALUES (15, 2)
INSERT [dbo].[Ban] ([ID], [Loaiban]) VALUES (16, 2)
INSERT [dbo].[Ban] ([ID], [Loaiban]) VALUES (17, 2)
INSERT [dbo].[Ban] ([ID], [Loaiban]) VALUES (18, 2)
INSERT [dbo].[Ban] ([ID], [Loaiban]) VALUES (19, 2)
INSERT [dbo].[Ban] ([ID], [Loaiban]) VALUES (20, 2)
INSERT [dbo].[Ban] ([ID], [Loaiban]) VALUES (21, 2)
INSERT [dbo].[Ban] ([ID], [Loaiban]) VALUES (22, 2)
INSERT [dbo].[Ban] ([ID], [Loaiban]) VALUES (23, 2)
INSERT [dbo].[Ban] ([ID], [Loaiban]) VALUES (24, 2)
INSERT [dbo].[Ban] ([ID], [Loaiban]) VALUES (25, 2)
INSERT [dbo].[Ban] ([ID], [Loaiban]) VALUES (26, 2)
INSERT [dbo].[Ban] ([ID], [Loaiban]) VALUES (27, 1)
INSERT [dbo].[Ban] ([ID], [Loaiban]) VALUES (28, 2)
SET IDENTITY_INSERT [dbo].[Ban] OFF
INSERT [dbo].[ChiTietDatMon] ([MaMon], [MaPhieu], [SoLuong]) VALUES (7, 15, 22)
INSERT [dbo].[ChiTietDatMon] ([MaMon], [MaPhieu], [SoLuong]) VALUES (7, 53, 5)
INSERT [dbo].[ChiTietDatMon] ([MaMon], [MaPhieu], [SoLuong]) VALUES (7, 56, 5)
INSERT [dbo].[ChiTietDatMon] ([MaMon], [MaPhieu], [SoLuong]) VALUES (7, 57, 5)
INSERT [dbo].[ChiTietDatMon] ([MaMon], [MaPhieu], [SoLuong]) VALUES (7, 59, 5)
INSERT [dbo].[ChiTietDatMon] ([MaMon], [MaPhieu], [SoLuong]) VALUES (12, 15, 21)
INSERT [dbo].[ChiTietDatMon] ([MaMon], [MaPhieu], [SoLuong]) VALUES (12, 51, 3)
INSERT [dbo].[ChiTietDatMon] ([MaMon], [MaPhieu], [SoLuong]) VALUES (12, 54, 5)
INSERT [dbo].[ChiTietDatMon] ([MaMon], [MaPhieu], [SoLuong]) VALUES (12, 60, 5)
INSERT [dbo].[ChiTietDatMon] ([MaMon], [MaPhieu], [SoLuong]) VALUES (13, 58, 88)
INSERT [dbo].[ChiTietDatMon] ([MaMon], [MaPhieu], [SoLuong]) VALUES (20, 55, 2)
INSERT [dbo].[ChiTietDatMon] ([MaMon], [MaPhieu], [SoLuong]) VALUES (20, 57, 3)
INSERT [dbo].[ChiTietDatMon] ([MaMon], [MaPhieu], [SoLuong]) VALUES (27, 15, 11)
INSERT [dbo].[CongThucMon] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (1, 13, 2)
INSERT [dbo].[CongThucMon] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (1, 14, 0.5)
INSERT [dbo].[CongThucMon] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (1, 39, 0.5)
INSERT [dbo].[CongThucMon] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (1, 40, 0.5)
INSERT [dbo].[CongThucMon] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (1, 41, 0.5)
INSERT [dbo].[CongThucMon] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (2, 13, 2)
INSERT [dbo].[CongThucMon] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (2, 14, 2)
INSERT [dbo].[CongThucMon] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (2, 15, 3)
SET IDENTITY_INSERT [dbo].[LoaiBan] ON 

INSERT [dbo].[LoaiBan] ([ID], [TenLoaiBan]) VALUES (1, N'Bàn Thường')
INSERT [dbo].[LoaiBan] ([ID], [TenLoaiBan]) VALUES (2, N'Bàn V.I.P')
SET IDENTITY_INSERT [dbo].[LoaiBan] OFF
SET IDENTITY_INSERT [dbo].[LoaiNguyenLieu] ON 

INSERT [dbo].[LoaiNguyenLieu] ([ID], [TenLoai]) VALUES (1, N'Cá - Hải sản')
INSERT [dbo].[LoaiNguyenLieu] ([ID], [TenLoai]) VALUES (2, N'Rau - Củ - Quả')
INSERT [dbo].[LoaiNguyenLieu] ([ID], [TenLoai]) VALUES (3, N'Thịt')
INSERT [dbo].[LoaiNguyenLieu] ([ID], [TenLoai]) VALUES (4, N'Bia - Nước giải khát')
INSERT [dbo].[LoaiNguyenLieu] ([ID], [TenLoai]) VALUES (5, N'Gia vị')
INSERT [dbo].[LoaiNguyenLieu] ([ID], [TenLoai]) VALUES (6, N'Khác')
SET IDENTITY_INSERT [dbo].[LoaiNguyenLieu] OFF
SET IDENTITY_INSERT [dbo].[LoaiSanPham] ON 

INSERT [dbo].[LoaiSanPham] ([ID], [TenLoaiSanPham]) VALUES (1, N'Khai Vị')
INSERT [dbo].[LoaiSanPham] ([ID], [TenLoaiSanPham]) VALUES (2, N'Xalat')
INSERT [dbo].[LoaiSanPham] ([ID], [TenLoaiSanPham]) VALUES (3, N'Gỏi')
INSERT [dbo].[LoaiSanPham] ([ID], [TenLoaiSanPham]) VALUES (4, N'Món nướng')
INSERT [dbo].[LoaiSanPham] ([ID], [TenLoaiSanPham]) VALUES (5, N'Mì - Cơm')
INSERT [dbo].[LoaiSanPham] ([ID], [TenLoaiSanPham]) VALUES (6, N'Hải sản')
INSERT [dbo].[LoaiSanPham] ([ID], [TenLoaiSanPham]) VALUES (7, N'Bia - nước giải khát')
INSERT [dbo].[LoaiSanPham] ([ID], [TenLoaiSanPham]) VALUES (8, N'Khác')
SET IDENTITY_INSERT [dbo].[LoaiSanPham] OFF
SET IDENTITY_INSERT [dbo].[LoaiTaiKhoan] ON 

INSERT [dbo].[LoaiTaiKhoan] ([ID], [TenLoaiTaiKhoan]) VALUES (1, N'Thu ngân')
INSERT [dbo].[LoaiTaiKhoan] ([ID], [TenLoaiTaiKhoan]) VALUES (2, N'Kế Toán')
INSERT [dbo].[LoaiTaiKhoan] ([ID], [TenLoaiTaiKhoan]) VALUES (3, N'Quản lý')
SET IDENTITY_INSERT [dbo].[LoaiTaiKhoan] OFF
SET IDENTITY_INSERT [dbo].[Menu] ON 

INSERT [dbo].[Menu] ([ID], [MaSanPham], [HinhAnh], [DonGia], [LoaiSanPham]) VALUES (7, 1, N'20160213100316.png', 10000, 1)
INSERT [dbo].[Menu] ([ID], [MaSanPham], [HinhAnh], [DonGia], [LoaiSanPham]) VALUES (12, 2, NULL, 10000, 1)
INSERT [dbo].[Menu] ([ID], [MaSanPham], [HinhAnh], [DonGia], [LoaiSanPham]) VALUES (13, 3, NULL, 10000, 1)
INSERT [dbo].[Menu] ([ID], [MaSanPham], [HinhAnh], [DonGia], [LoaiSanPham]) VALUES (14, 4, NULL, 10000, 1)
INSERT [dbo].[Menu] ([ID], [MaSanPham], [HinhAnh], [DonGia], [LoaiSanPham]) VALUES (15, 5, NULL, 10000, 1)
INSERT [dbo].[Menu] ([ID], [MaSanPham], [HinhAnh], [DonGia], [LoaiSanPham]) VALUES (16, 6, NULL, 10000, 1)
INSERT [dbo].[Menu] ([ID], [MaSanPham], [HinhAnh], [DonGia], [LoaiSanPham]) VALUES (17, 7, N'', 100000, 1)
INSERT [dbo].[Menu] ([ID], [MaSanPham], [HinhAnh], [DonGia], [LoaiSanPham]) VALUES (18, 8, NULL, 10000, 1)
INSERT [dbo].[Menu] ([ID], [MaSanPham], [HinhAnh], [DonGia], [LoaiSanPham]) VALUES (19, 9, NULL, 10000, 1)
INSERT [dbo].[Menu] ([ID], [MaSanPham], [HinhAnh], [DonGia], [LoaiSanPham]) VALUES (20, 10, NULL, 10000, 1)
INSERT [dbo].[Menu] ([ID], [MaSanPham], [HinhAnh], [DonGia], [LoaiSanPham]) VALUES (27, 1, NULL, 12000, 7)
INSERT [dbo].[Menu] ([ID], [MaSanPham], [HinhAnh], [DonGia], [LoaiSanPham]) VALUES (30, 2, NULL, 12000, 7)
INSERT [dbo].[Menu] ([ID], [MaSanPham], [HinhAnh], [DonGia], [LoaiSanPham]) VALUES (31, 3, NULL, 12000, 7)
INSERT [dbo].[Menu] ([ID], [MaSanPham], [HinhAnh], [DonGia], [LoaiSanPham]) VALUES (32, 4, NULL, 12000, 7)
INSERT [dbo].[Menu] ([ID], [MaSanPham], [HinhAnh], [DonGia], [LoaiSanPham]) VALUES (33, 5, NULL, 12000, 7)
INSERT [dbo].[Menu] ([ID], [MaSanPham], [HinhAnh], [DonGia], [LoaiSanPham]) VALUES (34, 6, NULL, 12000, 7)
INSERT [dbo].[Menu] ([ID], [MaSanPham], [HinhAnh], [DonGia], [LoaiSanPham]) VALUES (35, 7, NULL, 12000, 7)
INSERT [dbo].[Menu] ([ID], [MaSanPham], [HinhAnh], [DonGia], [LoaiSanPham]) VALUES (36, 8, NULL, 12000, 7)
INSERT [dbo].[Menu] ([ID], [MaSanPham], [HinhAnh], [DonGia], [LoaiSanPham]) VALUES (37, 9, NULL, 12000, 7)
INSERT [dbo].[Menu] ([ID], [MaSanPham], [HinhAnh], [DonGia], [LoaiSanPham]) VALUES (39, 10, NULL, 12000, 7)
INSERT [dbo].[Menu] ([ID], [MaSanPham], [HinhAnh], [DonGia], [LoaiSanPham]) VALUES (45, 11, NULL, 12000, 7)
INSERT [dbo].[Menu] ([ID], [MaSanPham], [HinhAnh], [DonGia], [LoaiSanPham]) VALUES (46, 12, NULL, 12000, 7)
INSERT [dbo].[Menu] ([ID], [MaSanPham], [HinhAnh], [DonGia], [LoaiSanPham]) VALUES (47, 11, N'', 1555, 1)
INSERT [dbo].[Menu] ([ID], [MaSanPham], [HinhAnh], [DonGia], [LoaiSanPham]) VALUES (48, 44, N'', 1666, 7)
SET IDENTITY_INSERT [dbo].[Menu] OFF
SET IDENTITY_INSERT [dbo].[Mon] ON 

INSERT [dbo].[Mon] ([ID], [TenMon]) VALUES (1, N'Kim chi')
INSERT [dbo].[Mon] ([ID], [TenMon]) VALUES (2, N'Đậu phộng rang muối')
INSERT [dbo].[Mon] ([ID], [TenMon]) VALUES (3, N'Hạt sen rang muối')
INSERT [dbo].[Mon] ([ID], [TenMon]) VALUES (4, N'Khổ qua chà bông')
INSERT [dbo].[Mon] ([ID], [TenMon]) VALUES (5, N'Đậu hủ chiên')
INSERT [dbo].[Mon] ([ID], [TenMon]) VALUES (6, N'Khoai tây chiên')
INSERT [dbo].[Mon] ([ID], [TenMon]) VALUES (7, N'Mực một nắng')
INSERT [dbo].[Mon] ([ID], [TenMon]) VALUES (8, N'Xúc xích GoldMalt')
INSERT [dbo].[Mon] ([ID], [TenMon]) VALUES (9, N'Thịt nguội xông khói')
INSERT [dbo].[Mon] ([ID], [TenMon]) VALUES (10, N'Khô cá lóc nướng')
INSERT [dbo].[Mon] ([ID], [TenMon]) VALUES (11, N'Hạt dưa')
SET IDENTITY_INSERT [dbo].[Mon] OFF
SET IDENTITY_INSERT [dbo].[NguyenLieu] ON 

INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (1, N'Coca Cola', N'Chai      ', 4, NULL)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (2, N'Trà xanh không độ', N'Chai      ', 4, NULL)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (3, N'Pesi', N'Chai      ', 4, NULL)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (4, N'NumberOne', N'Chai      ', 4, NULL)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (5, N'AQuafina', N'Chai      ', 4, NULL)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (6, N'Trà Ô Long', N'Chai      ', 4, NULL)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (7, N'Dr.Thanh', N'Chai      ', 4, NULL)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (8, N'C2', N'Chai      ', 4, NULL)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (9, N'String', N'Chai      ', 4, NULL)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (10, N'Summurai', N'Chai      ', 4, NULL)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (11, N'Fanta Cam', N'Chai      ', 4, NULL)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (12, N'Sprite', N'Chai      ', 4, NULL)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (13, N'Cải', N'Kg        ', 2, 100)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (14, N'Ớt', N'Kg        ', 2, 10)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (15, N'Hành', N'Kg        ', 2, 10)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (17, N'Xà Lách', N'Kg        ', 2, 100)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (18, N'Đậu hũ', N'Kg        ', 2, 100)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (19, N'Ngò', N'Kg        ', 2, 10)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (20, N'Dền', N'Kg        ', 2, 10)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (21, N'Bò ngót', N'Kg        ', 2, 10)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (22, NULL, N'Kg        ', 1, NULL)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (23, NULL, N'Kg        ', 1, NULL)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (24, NULL, N'Kg        ', 1, NULL)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (25, NULL, N'Kg        ', 1, NULL)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (26, NULL, N'Kg        ', 1, NULL)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (27, NULL, N'Kg        ', 1, NULL)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (28, NULL, N'Kg        ', 1, NULL)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (29, NULL, N'Kg        ', 1, NULL)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (30, NULL, N'Kg        ', 1, NULL)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (31, NULL, N'Kg        ', 1, NULL)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (32, NULL, N'Kg        ', 1, NULL)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (33, NULL, N'Kg        ', 1, NULL)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (34, NULL, N'Kg        ', 3, NULL)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (35, NULL, N'Kg        ', 3, NULL)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (36, NULL, N'Kg        ', 3, NULL)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (37, NULL, N'Kg        ', 3, NULL)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (38, N'Tiêu', N'Kg        ', 5, 10)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (39, N'Bột ngọt', N'Kg        ', 5, 10)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (40, N'Muối', N'Kg        ', 5, 30)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (41, N'Đường', N'Kg        ', 5, 10)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (42, N'Dầu ăn', N'Lít       ', 5, 30)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DonViTinh], [MaLoai], [SoLuong]) VALUES (44, N'Tiger', N'Lon       ', 4, 60)
SET IDENTITY_INSERT [dbo].[NguyenLieu] OFF
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([ID], [HoTen], [GioiTinh], [NgaySinh], [CMND], [DiaChi], [SoDienThoai], [DaXoa]) VALUES (1, N'chua biet ', 1, CAST(N'1992-01-01' AS Date), N'2222222        ', N'', NULL, 0)
INSERT [dbo].[NhanVien] ([ID], [HoTen], [GioiTinh], [NgaySinh], [CMND], [DiaChi], [SoDienThoai], [DaXoa]) VALUES (2, N'ádsd', 1, CAST(N'1992-01-01' AS Date), NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
SET IDENTITY_INSERT [dbo].[PhieuDatMon] ON 

INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (15, 1, 1, N'sad', N'ád', CAST(N'2016-01-02 00:00:00.000' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (16, 1, 8, N'R', N'a', CAST(N'2016-02-03 16:41:54.043' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (17, 1, 4, N'a', N'a', CAST(N'2016-02-03 16:42:51.070' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (18, 1, 8, N'Ryan', N'asdasd', CAST(N'2016-02-03 16:45:54.950' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (19, 1, 1, N'', N'', CAST(N'2016-02-05 16:34:36.393' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (20, 1, 2, N'', N'', CAST(N'2016-02-05 17:10:05.187' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (22, 1, 1, N'', N'', CAST(N'2016-02-06 06:07:03.267' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (23, 1, 1, N'', N'', CAST(N'2016-02-06 06:14:40.180' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (24, 1, 1, N'', N'', CAST(N'2016-02-06 06:27:45.073' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (25, 1, 1, N'', N'', CAST(N'2016-02-06 06:47:02.607' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (26, 1, 1, N'', N'', CAST(N'2016-02-06 07:13:06.883' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (27, 1, 1, N'', N'', CAST(N'2016-02-06 09:04:41.640' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (28, 1, 1, N'', N'', CAST(N'2016-02-06 10:05:05.260' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (29, 1, 1, N'', N'', CAST(N'2016-02-06 10:07:34.813' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (30, 1, 1, N'', N'', CAST(N'2016-02-06 10:08:24.283' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (31, 1, 2, N'', N'', CAST(N'2016-02-06 10:32:25.623' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (32, 1, 1, N'', N'', CAST(N'2016-02-06 10:37:42.330' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (33, 1, 1, N'', N'', CAST(N'2016-02-06 10:43:55.257' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (34, 1, 1, N'', N'', CAST(N'2016-02-06 10:44:47.597' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (35, 1, 1, N'', N'', CAST(N'2016-02-06 11:09:18.827' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (36, 1, 1, N'', N'', CAST(N'2016-02-06 11:11:57.850' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (37, 1, 4, N'', N'', CAST(N'2016-02-06 11:13:49.280' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (38, 1, 1, N'', N'', CAST(N'2016-02-06 11:16:24.653' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (39, 1, 4, N'', N'', CAST(N'2016-02-06 11:16:40.380' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (40, 1, 1, N'', N'', CAST(N'2016-02-06 11:46:30.433' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (41, 1, 4, N'', N'', CAST(N'2016-02-06 11:46:58.463' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (42, 1, 1, N'', N'', CAST(N'2016-02-06 11:48:03.540' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (43, 1, 2, N'', N'', CAST(N'2016-02-06 11:48:12.143' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (44, 1, 2, N'', N'', CAST(N'2016-02-06 11:49:05.807' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (45, 1, 1, N'', N'', CAST(N'2016-02-06 14:57:33.633' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (46, 1, 2, N'', N'', CAST(N'2016-02-06 14:57:42.860' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (47, 1, 1, N'', N'', CAST(N'2016-02-06 15:04:54.740' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (48, 1, 3, N'', N'', CAST(N'2016-02-06 15:05:10.170' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (49, 1, 4, N'', N'', CAST(N'2016-02-06 15:05:31.477' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (50, 1, 1, N'', N'', CAST(N'2016-02-06 15:23:45.943' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (51, 1, 1, N'', N'', CAST(N'2016-02-06 20:18:16.793' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (52, 1, 1, N'', N'', CAST(N'2016-02-06 20:30:40.307' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (53, 1, 1, N'', N'', CAST(N'2016-02-06 20:33:13.130' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (54, 1, 1, N'', N'', CAST(N'2016-02-06 20:34:52.520' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (55, 1, 1, N'', N'', CAST(N'2016-02-06 21:35:44.703' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (56, 1, 1, N'', N'', CAST(N'2016-02-06 22:09:12.717' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (57, 1, 1, N'', N'', CAST(N'2016-02-06 22:11:56.447' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (58, 1, 1, N'', N'', CAST(N'2016-02-07 11:05:56.313' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (59, 1, 1, N'', N'', CAST(N'2016-02-08 16:14:16.710' AS DateTime), 0, 50000)
INSERT [dbo].[PhieuDatMon] ([ID], [MaNhanVien], [MaBan], [TenKhachHang], [DiaChi], [ThoiGian], [DaThanhToan], [TongTien]) VALUES (60, 1, 1, N'', N'', CAST(N'2016-02-08 16:15:57.737' AS DateTime), 0, 50000)
SET IDENTITY_INSERT [dbo].[PhieuDatMon] OFF
SET IDENTITY_INSERT [dbo].[TaiKhoan] ON 

INSERT [dbo].[TaiKhoan] ([ID], [TenTaiKhoan], [MatKhau], [LoaiTaiKhoan]) VALUES (1, N'buvitin', N'123', 1)
SET IDENTITY_INSERT [dbo].[TaiKhoan] OFF
ALTER TABLE [dbo].[Ban]  WITH CHECK ADD  CONSTRAINT [FK_Ban_LoaiBan] FOREIGN KEY([Loaiban])
REFERENCES [dbo].[LoaiBan] ([ID])
GO
ALTER TABLE [dbo].[Ban] CHECK CONSTRAINT [FK_Ban_LoaiBan]
GO
ALTER TABLE [dbo].[ChiTietDatMon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDatMon_Menu] FOREIGN KEY([MaMon])
REFERENCES [dbo].[Menu] ([ID])
GO
ALTER TABLE [dbo].[ChiTietDatMon] CHECK CONSTRAINT [FK_ChiTietDatMon_Menu]
GO
ALTER TABLE [dbo].[ChiTietDatMon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDatMon_PhieuDatMon] FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[PhieuDatMon] ([ID])
GO
ALTER TABLE [dbo].[ChiTietDatMon] CHECK CONSTRAINT [FK_ChiTietDatMon_PhieuDatMon]
GO
ALTER TABLE [dbo].[ChiTietNhapXuat]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietNhapXuat_NguyenLieu] FOREIGN KEY([MaNguyenLieu])
REFERENCES [dbo].[NguyenLieu] ([ID])
GO
ALTER TABLE [dbo].[ChiTietNhapXuat] CHECK CONSTRAINT [FK_ChiTietNhapXuat_NguyenLieu]
GO
ALTER TABLE [dbo].[ChiTietNhapXuat]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietNhapXuat_XuatNhapKho] FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[XuatNhapKho] ([ID])
GO
ALTER TABLE [dbo].[ChiTietNhapXuat] CHECK CONSTRAINT [FK_ChiTietNhapXuat_XuatNhapKho]
GO
ALTER TABLE [dbo].[CongThucMon]  WITH CHECK ADD  CONSTRAINT [FK_CongThucMon_Mon] FOREIGN KEY([MaMon])
REFERENCES [dbo].[Mon] ([ID])
GO
ALTER TABLE [dbo].[CongThucMon] CHECK CONSTRAINT [FK_CongThucMon_Mon]
GO
ALTER TABLE [dbo].[CongThucMon]  WITH CHECK ADD  CONSTRAINT [FK_CongThucMon_NguyenLieu] FOREIGN KEY([MaNguyenLieu])
REFERENCES [dbo].[NguyenLieu] ([ID])
GO
ALTER TABLE [dbo].[CongThucMon] CHECK CONSTRAINT [FK_CongThucMon_NguyenLieu]
GO
ALTER TABLE [dbo].[Luong]  WITH CHECK ADD  CONSTRAINT [FK_Luong_NhanVien] FOREIGN KEY([ID])
REFERENCES [dbo].[NhanVien] ([ID])
GO
ALTER TABLE [dbo].[Luong] CHECK CONSTRAINT [FK_Luong_NhanVien]
GO
ALTER TABLE [dbo].[Menu]  WITH CHECK ADD  CONSTRAINT [FK_Menu_LoaiSanPham] FOREIGN KEY([LoaiSanPham])
REFERENCES [dbo].[LoaiSanPham] ([ID])
GO
ALTER TABLE [dbo].[Menu] CHECK CONSTRAINT [FK_Menu_LoaiSanPham]
GO
ALTER TABLE [dbo].[Menu]  WITH NOCHECK ADD  CONSTRAINT [FK_Menu_Mon] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[Mon] ([ID])
GO
ALTER TABLE [dbo].[Menu] NOCHECK CONSTRAINT [FK_Menu_Mon]
GO
ALTER TABLE [dbo].[NguyenLieu]  WITH CHECK ADD  CONSTRAINT [FK_NguyenLieu_LoaiNguyenLieu] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiNguyenLieu] ([ID])
GO
ALTER TABLE [dbo].[NguyenLieu] CHECK CONSTRAINT [FK_NguyenLieu_LoaiNguyenLieu]
GO
ALTER TABLE [dbo].[PhanCa]  WITH CHECK ADD  CONSTRAINT [FK_PhanCa_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([ID])
GO
ALTER TABLE [dbo].[PhanCa] CHECK CONSTRAINT [FK_PhanCa_NhanVien]
GO
ALTER TABLE [dbo].[PhieuDatMon]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDatMon_Ban] FOREIGN KEY([MaBan])
REFERENCES [dbo].[Ban] ([ID])
GO
ALTER TABLE [dbo].[PhieuDatMon] CHECK CONSTRAINT [FK_PhieuDatMon_Ban]
GO
ALTER TABLE [dbo].[PhieuDatMon]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDatMon_TaiKhoan] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[TaiKhoan] ([ID])
GO
ALTER TABLE [dbo].[PhieuDatMon] CHECK CONSTRAINT [FK_PhieuDatMon_TaiKhoan]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_LoaiTaiKhoan] FOREIGN KEY([LoaiTaiKhoan])
REFERENCES [dbo].[LoaiTaiKhoan] ([ID])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_LoaiTaiKhoan]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_NhanVien] FOREIGN KEY([ID])
REFERENCES [dbo].[NhanVien] ([ID])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_NhanVien]
GO
ALTER TABLE [dbo].[XuatNhapKho]  WITH CHECK ADD  CONSTRAINT [FK_XuatNhapKho_NhaCungCap] FOREIGN KEY([NhaCungCap])
REFERENCES [dbo].[NhaCungCap] ([ID])
GO
ALTER TABLE [dbo].[XuatNhapKho] CHECK CONSTRAINT [FK_XuatNhapKho_NhaCungCap]
GO
/****** Object:  StoredProcedure [dbo].[sp_CapNhapLoaiBan]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_CapNhapLoaiBan]
@MaBan int,
@MaLoai int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Ban
	SET Loaiban = @MaLoai
	WHERE ID = @MaBan
END

GO
/****** Object:  StoredProcedure [dbo].[sp_CapNhapSLMonGoi]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_CapNhapSLMonGoi]
@MaPhieu int,
@MaMon int,
@SoLuong int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    UPDATE ChiTietDatMon
	SET SoLuong = @SoLuong
	WHERE MaPhieu = @MaPhieu AND MaMon = @MaMon

END

GO
/****** Object:  StoredProcedure [dbo].[sp_CapNhapTTMon]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_CapNhapTTMon]
@ID int,
@DonGia int,
@HinhAnh nvarchar(100),
@MaLoaiSP int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	UPDATE Menu
	SET DonGia = @DonGia,
		HinhAnh = @HinhAnh,
		LoaiSanPham = @MaLoaiSP
	WHERE ID = @ID
END

GO
/****** Object:  StoredProcedure [dbo].[sp_CongThucMon]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_CongThucMon]
@MaMon int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT c.MaNguyenLieu, n.TenNguyenLieu, n.DonViTinh, c.SoLuong
	FROM CongThucMon c JOIN NguyenLieu n ON c.MaNguyenLieu = n.ID
	WHERE c.MaMon = @MaMon
END

GO
/****** Object:  StoredProcedure [dbo].[sp_DangNhap]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_DangNhap]
@TaiKhoan nvarchar(50),
@MatKhau nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT t.ID, t.LoaiTaiKhoan, l.TenLoaiTaiKhoan
	FROM TaiKhoan t JOIN LoaiTaiKhoan l ON t.LoaiTaiKhoan = l.ID
	WHERE t.TenTaiKhoan = @TaiKhoan AND t.MatKhau = @MatKhau
END

GO
/****** Object:  StoredProcedure [dbo].[sp_DoanhThuNam]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_DoanhThuNam]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT CONVERT(NVARCHAR(4), p.ThoiGian, 120) [Year], SUM(p.TongTien) [TongTien]
	FROM PhieuDatMon p 
	GROUP BY CONVERT(NVARCHAR(4), p.ThoiGian, 120)
	ORDER BY [Year]
END

GO
/****** Object:  StoredProcedure [dbo].[sp_DoanhThuThang]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_DoanhThuThang]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT CONVERT(NVARCHAR(7), p.ThoiGian, 120) [Month], SUM(p.TongTien) [TongTien]
	FROM PhieuDatMon p 
	WHERE YEAR(p.ThoiGian) = YEAR(getdate())
	GROUP BY CONVERT(NVARCHAR(7), p.ThoiGian, 120)
	ORDER BY [Month]
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DoanhThuTuan]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_DoanhThuTuan]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 'week ' + cast(datepart(wk, p.ThoiGian) as varchar(2)) Week, SUM(p.TongTien) [TongTien]
	FROM PhieuDatMon p 
	WHERE MONTH(p.ThoiGian) = MONTH(getdate())
	GROUP BY datepart(wk, p.ThoiGian)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_DSMon]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_DSMon]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	FROM Mon 
END

GO
/****** Object:  StoredProcedure [dbo].[sp_DSMonChuaCo]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_DSMonChuaCo]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	FROM Mon m
	WHERE m.ID NOT IN
					(
						SELECT mn.MaSanPham
						FROM Menu mn
						WHERE mn.LoaiSanPham != 7 AND mn.LoaiSanPham != 8
					)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_DSThucUongChuaCo]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_DSThucUongChuaCo]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT n.ID, n.TenNguyenLieu
	FROM NguyenLieu n
	WHERE n.MaLoai = 4 AND n.ID NOT IN
					(
						SELECT mn.MaSanPham
						FROM Menu mn
						WHERE mn.LoaiSanPham = 7
					)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_GoiMon]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GoiMon]
@MaPhieu int,
@MaMon int,
@SoLuong int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT ChiTietDatMon(MaPhieu, MaMon, SoLuong) VALUES(@MaPhieu, @MaMon, @SoLuong)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_LayDanhSachBan]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_LayDanhSachBan]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT b.ID, b.Loaiban, l.TenLoaiBan 
	FROM Ban b JOIN LoaiBan l ON b.Loaiban = l.ID
END

GO
/****** Object:  StoredProcedure [dbo].[sp_LayDSLoaiSanPham]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_LayDSLoaiSanPham]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	FROM LoaiSanPham
END

GO
/****** Object:  StoredProcedure [dbo].[sp_LayDSMonHoaDon]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_LayDSMonHoaDon]
@MaPhieu int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT m.TenMon, mn.DonGia, c.SoLuong
	FROM Menu mn, Mon m, ChiTietDatMon c
	WHERE mn.LoaiSanPham != 7 AND mn.MaSanPham = m.ID AND c.MaPhieu = @MaPhieu AND c.MaMon = mn.ID
	UNION ALL
	SELECT n.TenNguyenLieu AS 'TenMon', mn.DonGia, c.SoLuong
	FROM Menu mn, NguyenLieu n, ChiTietDatMon c
	WHERE mn.LoaiSanPham = 7 AND mn.MaSanPham = n.ID AND c.MaPhieu = @MaPhieu AND c.MaMon = mn.ID
END

GO
/****** Object:  StoredProcedure [dbo].[sp_LayDSNgLieu]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_LayDSNgLieu]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT n.ID, n.TenNguyenLieu, n.DonViTinh
	FROM NguyenLieu n
END

GO
/****** Object:  StoredProcedure [dbo].[sp_LayDSThucDon]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_LayDSThucDon]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT mn.ID, mn.HinhAnh, mn.DonGia, m.TenMon, l.ID, l.TenLoaiSanPham
	FROM Menu mn JOIN Mon m ON mn.MaSanPham = m.ID 
				 JOIN LoaiSanPham l ON mn.LoaiSanPham = l.ID
	WHERE l.ID != 7
	UNION ALL
	SELECT mn.ID, mn.HinhAnh, mn.DonGia, n.TenNguyenLieu, l.ID, l.TenLoaiSanPham
	FROM Menu mn JOIN NguyenLieu n ON mn.MaSanPham = n.ID 
				 JOIN LoaiSanPham l ON mn.LoaiSanPham = l.ID
	WHERE l.ID = 7
END

GO
/****** Object:  StoredProcedure [dbo].[sp_MoBan]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_MoBan]
@MaNhanVien int,
@MaBan int,
@TenKhachHang nvarchar(50),
@DiaChi nvarchar(100),
@ThoiGian Datetime,
@TongTien int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT PhieuDatMon(MaNhanVien, MaBan, TenKhachHang, DiaChi, ThoiGian, TongTien) 
	VALUES (@MaNhanVien, @MaBan, @TenKhachHang, @DiaChi, @ThoiGian, @TongTien)

	SELECT p.ID
	FROM PhieuDatMon p
	WHERE p.MaBan = @MaBan AND p.ThoiGian = @ThoiGian  
END

GO
/****** Object:  StoredProcedure [dbo].[sp_ThemBan]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_ThemBan]
@MaLoai int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT Ban(Loaiban) VALUES(@MaLoai)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_ThemMenu]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_ThemMenu]
@MaSanPham int,
@HinhAnh nvarchar(100),
@DonGia int,
@LoaiSanPham int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT Menu(MaSanPham, HinhAnh, DonGia, LoaiSanPham) VALUES (@MaSanPham, @HinhAnh, @DonGia, @LoaiSanPham)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_ThemMon]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_ThemMon]
@TenMon nvarchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT Mon(TenMon) VALUES (@TenMon)

	SELECT MAX(m.ID)
	FROM Mon m
	WHERE m.TenMon = @TenMon
END

GO
/****** Object:  StoredProcedure [dbo].[sp_ThemNLMon]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_ThemNLMon]
@MaMon int,
@MaNguyenLieu int,
@SoLuong float

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT CongThucMon(MaMon, MaNguyenLieu, SoLuong) VALUES(@MaMon, @MaNguyenLieu, @SoLuong)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_XoaCongThucMon]    Script Date: 02/14/2016 3:59:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_XoaCongThucMon] 
@MaMon int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DELETE FROM CongThucMon
	WHERE MaMon = @MaMon
END

GO
USE [master]
GO
ALTER DATABASE [NhaHangDB] SET  READ_WRITE 
GO
