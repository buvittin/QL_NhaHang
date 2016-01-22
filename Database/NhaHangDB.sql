USE [master]
GO
/****** Object:  Database [NhaHangDB]    Script Date: 01/22/2016 8:22:00 AM ******/
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
/****** Object:  Table [dbo].[Ban]    Script Date: 01/22/2016 8:22:01 AM ******/
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
/****** Object:  Table [dbo].[ChiTietDatMon]    Script Date: 01/22/2016 8:22:01 AM ******/
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
/****** Object:  Table [dbo].[ChiTietNhapXuat]    Script Date: 01/22/2016 8:22:01 AM ******/
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
/****** Object:  Table [dbo].[CongThucMon]    Script Date: 01/22/2016 8:22:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CongThucMon](
	[MaMon] [int] NOT NULL,
	[MaNguyenLieu] [int] NOT NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_ChiTietCongThuc] PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC,
	[MaNguyenLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiBan]    Script Date: 01/22/2016 8:22:01 AM ******/
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
/****** Object:  Table [dbo].[LoaiNguyenLieu]    Script Date: 01/22/2016 8:22:01 AM ******/
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
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 01/22/2016 8:22:01 AM ******/
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
/****** Object:  Table [dbo].[LoaiTaiKhoan]    Script Date: 01/22/2016 8:22:01 AM ******/
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
/****** Object:  Table [dbo].[Luong]    Script Date: 01/22/2016 8:22:01 AM ******/
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
/****** Object:  Table [dbo].[Menu]    Script Date: 01/22/2016 8:22:01 AM ******/
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
/****** Object:  Table [dbo].[Mon]    Script Date: 01/22/2016 8:22:01 AM ******/
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
/****** Object:  Table [dbo].[NguyenLieu]    Script Date: 01/22/2016 8:22:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguyenLieu](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenNguyenLieu] [nvarchar](50) NULL,
	[DonViTinh] [nchar](10) NULL,
	[MaLoai] [int] NULL,
 CONSTRAINT [PK_NguyenLieu] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 01/22/2016 8:22:01 AM ******/
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
/****** Object:  Table [dbo].[NhanVien]    Script Date: 01/22/2016 8:22:01 AM ******/
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
/****** Object:  Table [dbo].[PhanCa]    Script Date: 01/22/2016 8:22:01 AM ******/
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
/****** Object:  Table [dbo].[PhieuDatMon]    Script Date: 01/22/2016 8:22:01 AM ******/
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
 CONSTRAINT [PK_PhieuDatMon] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 01/22/2016 8:22:01 AM ******/
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
/****** Object:  Table [dbo].[XuatNhapKho]    Script Date: 01/22/2016 8:22:01 AM ******/
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
SET IDENTITY_INSERT [dbo].[LoaiBan] ON 

INSERT [dbo].[LoaiBan] ([ID], [TenLoaiBan]) VALUES (1, N'Bàn Thường')
INSERT [dbo].[LoaiBan] ([ID], [TenLoaiBan]) VALUES (2, N'Bàn V.I.P')
SET IDENTITY_INSERT [dbo].[LoaiBan] OFF
SET IDENTITY_INSERT [dbo].[LoaiNguyenLieu] ON 

INSERT [dbo].[LoaiNguyenLieu] ([ID], [TenLoai]) VALUES (1, N'Cá - Hải sản')
INSERT [dbo].[LoaiNguyenLieu] ([ID], [TenLoai]) VALUES (2, N'Rau - Củ - Quả')
INSERT [dbo].[LoaiNguyenLieu] ([ID], [TenLoai]) VALUES (3, N'Thịt')
INSERT [dbo].[LoaiNguyenLieu] ([ID], [TenLoai]) VALUES (4, N'Bia')
INSERT [dbo].[LoaiNguyenLieu] ([ID], [TenLoai]) VALUES (5, N'Nước giải khát')
INSERT [dbo].[LoaiNguyenLieu] ([ID], [TenLoai]) VALUES (6, N'Gia vị')
INSERT [dbo].[LoaiNguyenLieu] ([ID], [TenLoai]) VALUES (7, N'Khác')
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
ALTER TABLE [dbo].[Menu]  WITH CHECK ADD  CONSTRAINT [FK_Menu_Mon] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[Mon] ([ID])
GO
ALTER TABLE [dbo].[Menu] CHECK CONSTRAINT [FK_Menu_Mon]
GO
ALTER TABLE [dbo].[Menu]  WITH CHECK ADD  CONSTRAINT [FK_Menu_NguyenLieu] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[NguyenLieu] ([ID])
GO
ALTER TABLE [dbo].[Menu] CHECK CONSTRAINT [FK_Menu_NguyenLieu]
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
ALTER TABLE [dbo].[PhieuDatMon]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDatMon_TaiKhoan] FOREIGN KEY([ID])
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
USE [master]
GO
ALTER DATABASE [NhaHangDB] SET  READ_WRITE 
GO
