USE [master]
GO
/****** Object:  Database [QLHS]    Script Date: 4/19/2023 1:00:27 PM ******/
CREATE DATABASE [QLHS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLHS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\QLHS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLHS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\QLHS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QLHS] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLHS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLHS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLHS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLHS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLHS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLHS] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLHS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLHS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLHS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLHS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLHS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLHS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLHS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLHS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLHS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLHS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLHS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLHS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLHS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLHS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLHS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLHS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLHS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLHS] SET RECOVERY FULL 
GO
ALTER DATABASE [QLHS] SET  MULTI_USER 
GO
ALTER DATABASE [QLHS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLHS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLHS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLHS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLHS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLHS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLHS', N'ON'
GO
ALTER DATABASE [QLHS] SET QUERY_STORE = ON
GO
ALTER DATABASE [QLHS] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QLHS]
GO
/****** Object:  Table [dbo].[Diem]    Script Date: 4/19/2023 1:00:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diem](
	[MaDiem] [int] NOT NULL,
	[DiemSo] [float] NULL,
	[MaHS] [int] NULL,
	[MaMon] [int] NULL,
	[MaLoaiDiem] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDiem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 4/19/2023 1:00:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoVien](
	[MaGV] [int] NOT NULL,
	[HoGV] [varchar](50) NULL,
	[TenGV] [varchar](50) NULL,
	[NgaySinh] [date] NULL,
	[QueQuan] [varchar](50) NULL,
	[SoDT] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HocSinh]    Script Date: 4/19/2023 1:00:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocSinh](
	[MaHS] [int] NOT NULL,
	[Ho] [varchar](50) NULL,
	[Ten] [varchar](50) NULL,
	[GioiTinh] [varchar](10) NULL,
	[NgaySinh] [date] NULL,
	[MaLop] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiDiem]    Script Date: 4/19/2023 1:00:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiDiem](
	[MaLoaiDiem] [int] NOT NULL,
	[Ten] [varchar](50) NULL,
	[HeSo] [float] NULL,
	[MoTa] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiDiem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 4/19/2023 1:00:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[MaLop] [int] NOT NULL,
	[TenLop] [varchar](50) NULL,
	[MaGV] [int] NULL,
	[NamHoc] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mon]    Script Date: 4/19/2023 1:00:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mon](
	[MaMon] [int] NOT NULL,
	[TenMon] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Diem] ([MaDiem], [DiemSo], [MaHS], [MaMon], [MaLoaiDiem]) VALUES (1, 9, 1, 1, 1)
INSERT [dbo].[Diem] ([MaDiem], [DiemSo], [MaHS], [MaMon], [MaLoaiDiem]) VALUES (2, 8.5, 5, 2, 1)
INSERT [dbo].[Diem] ([MaDiem], [DiemSo], [MaHS], [MaMon], [MaLoaiDiem]) VALUES (3, 9.5, 1, 3, 1)
INSERT [dbo].[Diem] ([MaDiem], [DiemSo], [MaHS], [MaMon], [MaLoaiDiem]) VALUES (4, 7, 6, 4, 1)
INSERT [dbo].[Diem] ([MaDiem], [DiemSo], [MaHS], [MaMon], [MaLoaiDiem]) VALUES (5, 8, 1, 5, 1)
INSERT [dbo].[Diem] ([MaDiem], [DiemSo], [MaHS], [MaMon], [MaLoaiDiem]) VALUES (6, 9, 2, 1, 1)
INSERT [dbo].[Diem] ([MaDiem], [DiemSo], [MaHS], [MaMon], [MaLoaiDiem]) VALUES (7, 8.5, 2, 2, 1)
INSERT [dbo].[Diem] ([MaDiem], [DiemSo], [MaHS], [MaMon], [MaLoaiDiem]) VALUES (8, 9.5, 7, 3, 1)
INSERT [dbo].[Diem] ([MaDiem], [DiemSo], [MaHS], [MaMon], [MaLoaiDiem]) VALUES (9, 7, 2, 4, 1)
INSERT [dbo].[Diem] ([MaDiem], [DiemSo], [MaHS], [MaMon], [MaLoaiDiem]) VALUES (10, 8, 2, 5, 1)
INSERT [dbo].[Diem] ([MaDiem], [DiemSo], [MaHS], [MaMon], [MaLoaiDiem]) VALUES (11, 9, 8, 1, 1)
INSERT [dbo].[Diem] ([MaDiem], [DiemSo], [MaHS], [MaMon], [MaLoaiDiem]) VALUES (12, 8.5, 3, 2, 1)
INSERT [dbo].[Diem] ([MaDiem], [DiemSo], [MaHS], [MaMon], [MaLoaiDiem]) VALUES (13, 9.5, 3, 3, 1)
INSERT [dbo].[Diem] ([MaDiem], [DiemSo], [MaHS], [MaMon], [MaLoaiDiem]) VALUES (14, 7, 3, 4, 1)
INSERT [dbo].[Diem] ([MaDiem], [DiemSo], [MaHS], [MaMon], [MaLoaiDiem]) VALUES (15, 8, 9, 5, 1)
INSERT [dbo].[Diem] ([MaDiem], [DiemSo], [MaHS], [MaMon], [MaLoaiDiem]) VALUES (16, 9, 4, 1, 1)
INSERT [dbo].[Diem] ([MaDiem], [DiemSo], [MaHS], [MaMon], [MaLoaiDiem]) VALUES (17, 8.5, 4, 2, 1)
INSERT [dbo].[Diem] ([MaDiem], [DiemSo], [MaHS], [MaMon], [MaLoaiDiem]) VALUES (18, 9.5, 10, 3, 1)
INSERT [dbo].[Diem] ([MaDiem], [DiemSo], [MaHS], [MaMon], [MaLoaiDiem]) VALUES (19, 7, 10, 4, 1)
INSERT [dbo].[Diem] ([MaDiem], [DiemSo], [MaHS], [MaMon], [MaLoaiDiem]) VALUES (20, 8, 4, 5, 1)
INSERT [dbo].[Diem] ([MaDiem], [DiemSo], [MaHS], [MaMon], [MaLoaiDiem]) VALUES (100, 7, 4, 1, 1)
GO
INSERT [dbo].[GiaoVien] ([MaGV], [HoGV], [TenGV], [NgaySinh], [QueQuan], [SoDT]) VALUES (1, N'Nguyễn Văn', N'Lộc', CAST(N'1980-05-12' AS Date), N'Hà Nội', N'0987654321')
INSERT [dbo].[GiaoVien] ([MaGV], [HoGV], [TenGV], [NgaySinh], [QueQuan], [SoDT]) VALUES (2, N'Trần Thị Kim', N'Tuyền', CAST(N'1982-02-28' AS Date), N'Hải Phòng', N'0123456789')
INSERT [dbo].[GiaoVien] ([MaGV], [HoGV], [TenGV], [NgaySinh], [QueQuan], [SoDT]) VALUES (3, N'Lê Quốc', N'Cường', CAST(N'1985-09-15' AS Date), N'Hà Tĩnh', N'0909090909')
INSERT [dbo].[GiaoVien] ([MaGV], [HoGV], [TenGV], [NgaySinh], [QueQuan], [SoDT]) VALUES (4, N'Phạm', N'Hồng D', CAST(N'1987-11-02' AS Date), N'Hưng Yên', N'0912345678')
INSERT [dbo].[GiaoVien] ([MaGV], [HoGV], [TenGV], [NgaySinh], [QueQuan], [SoDT]) VALUES (5, N'Vũ', N'Thị E', CAST(N'1983-04-22' AS Date), N'Nam Định', N'0987123456')
INSERT [dbo].[GiaoVien] ([MaGV], [HoGV], [TenGV], [NgaySinh], [QueQuan], [SoDT]) VALUES (6, N'Nguyễn', N'Đình F', CAST(N'1984-08-10' AS Date), N'Bắc Ninh', N'0905123456')
INSERT [dbo].[GiaoVien] ([MaGV], [HoGV], [TenGV], [NgaySinh], [QueQuan], [SoDT]) VALUES (7, N'Trần', N'Thị G', CAST(N'1981-03-25' AS Date), N'Thanh Hóa', N'0123456789')
INSERT [dbo].[GiaoVien] ([MaGV], [HoGV], [TenGV], [NgaySinh], [QueQuan], [SoDT]) VALUES (8, N'Lê', N'Quang H', CAST(N'1979-06-11' AS Date), N'Nghệ An', N'0912345678')
INSERT [dbo].[GiaoVien] ([MaGV], [HoGV], [TenGV], [NgaySinh], [QueQuan], [SoDT]) VALUES (9, N'Phạm', N'Hồng I', CAST(N'1986-10-18' AS Date), N'Hải Dương', N'0987123456')
INSERT [dbo].[GiaoVien] ([MaGV], [HoGV], [TenGV], [NgaySinh], [QueQuan], [SoDT]) VALUES (10, N'Vũ', N'Thị K', CAST(N'1982-12-27' AS Date), N'Hà Nội', N'0905123456')
INSERT [dbo].[GiaoVien] ([MaGV], [HoGV], [TenGV], [NgaySinh], [QueQuan], [SoDT]) VALUES (11, N'Nguyễn', N'Văn Dũng', CAST(N'1980-05-12' AS Date), N'Hà Nội', N'0987654321')
INSERT [dbo].[GiaoVien] ([MaGV], [HoGV], [TenGV], [NgaySinh], [QueQuan], [SoDT]) VALUES (13, N'Nguyen Minh', N'Hieu', CAST(N'2002-06-22' AS Date), N'Phu Yen', N'032165423')
GO
INSERT [dbo].[HocSinh] ([MaHS], [Ho], [Ten], [GioiTinh], [NgaySinh], [MaLop]) VALUES (1, N'Phạm Thị', N' Hà', N'Nữ', CAST(N'2006-01-02' AS Date), 1)
INSERT [dbo].[HocSinh] ([MaHS], [Ho], [Ten], [GioiTinh], [NgaySinh], [MaLop]) VALUES (2, N'Nguyễn Văn', N' Ba', N'Nam', CAST(N'2006-02-03' AS Date), 2)
INSERT [dbo].[HocSinh] ([MaHS], [Ho], [Ten], [GioiTinh], [NgaySinh], [MaLop]) VALUES (3, N'Trần Thị', N' Cà', N'Nữ', CAST(N'2005-03-04' AS Date), 3)
INSERT [dbo].[HocSinh] ([MaHS], [Ho], [Ten], [GioiTinh], [NgaySinh], [MaLop]) VALUES (4, N'Lê Quang', N' Đạt', N'Nam', CAST(N'2006-04-05' AS Date), 4)
INSERT [dbo].[HocSinh] ([MaHS], [Ho], [Ten], [GioiTinh], [NgaySinh], [MaLop]) VALUES (5, N'Phạm Thị', N' Em', N'Nữ', CAST(N'2006-05-06' AS Date), 5)
INSERT [dbo].[HocSinh] ([MaHS], [Ho], [Ten], [GioiTinh], [NgaySinh], [MaLop]) VALUES (6, N'Vũ Thị', N' Nhi', N'Nữ', CAST(N'2007-06-07' AS Date), 6)
INSERT [dbo].[HocSinh] ([MaHS], [Ho], [Ten], [GioiTinh], [NgaySinh], [MaLop]) VALUES (7, N'Nguyễn Văn', N' Đạt', N'Nam', CAST(N'2007-07-08' AS Date), 7)
INSERT [dbo].[HocSinh] ([MaHS], [Ho], [Ten], [GioiTinh], [NgaySinh], [MaLop]) VALUES (8, N'Trần Thị', N' Hạnh', N'Nữ', CAST(N'2005-08-09' AS Date), 8)
INSERT [dbo].[HocSinh] ([MaHS], [Ho], [Ten], [GioiTinh], [NgaySinh], [MaLop]) VALUES (9, N'Lê Quốc', N' Hải', N'Nam', CAST(N'2006-09-10' AS Date), 9)
INSERT [dbo].[HocSinh] ([MaHS], [Ho], [Ten], [GioiTinh], [NgaySinh], [MaLop]) VALUES (10, N'Phạm Hồng', N' Khang', N'Nam', CAST(N'2007-10-11' AS Date), 10)
INSERT [dbo].[HocSinh] ([MaHS], [Ho], [Ten], [GioiTinh], [NgaySinh], [MaLop]) VALUES (11, N'Phạm Thị', N' Hải', N'Nữ', CAST(N'2006-01-02' AS Date), 3)
INSERT [dbo].[HocSinh] ([MaHS], [Ho], [Ten], [GioiTinh], [NgaySinh], [MaLop]) VALUES (12, N'Phạm Thị', N' Hà', N'Nữ', CAST(N'2006-01-04' AS Date), 7)
GO
INSERT [dbo].[LoaiDiem] ([MaLoaiDiem], [Ten], [HeSo], [MoTa]) VALUES (1, N'Điểm miệng', 1, N'Điểm kiểm tra của giáo viên')
INSERT [dbo].[LoaiDiem] ([MaLoaiDiem], [Ten], [HeSo], [MoTa]) VALUES (3, N'Điểm 1 tiết', 2, N'Điểm kiểm tra của giáo viên')
INSERT [dbo].[LoaiDiem] ([MaLoaiDiem], [Ten], [HeSo], [MoTa]) VALUES (4, N'Điểm Cuối kỳ', 3, N'Điểm kiểm tra cuối kỳ')
INSERT [dbo].[LoaiDiem] ([MaLoaiDiem], [Ten], [HeSo], [MoTa]) VALUES (5, N'Điểm test', 2, N'Test điểm')
INSERT [dbo].[LoaiDiem] ([MaLoaiDiem], [Ten], [HeSo], [MoTa]) VALUES (6, N'update', 9, N'vsdv')
GO
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaGV], [NamHoc]) VALUES (1, N'Lớp 1A', 1, N'2022-2023')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaGV], [NamHoc]) VALUES (2, N'Lớp 1B', 2, N'2022-2023')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaGV], [NamHoc]) VALUES (3, N'Lớp 2A', 3, N'2022-2023')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaGV], [NamHoc]) VALUES (4, N'Lớp 2B', 4, N'2022-2023')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaGV], [NamHoc]) VALUES (5, N'Lớp 3A', 5, N'2022-2023')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaGV], [NamHoc]) VALUES (6, N'Lớp 3B', 6, N'2022-2023')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaGV], [NamHoc]) VALUES (7, N'Lớp 4A', 7, N'2022-2023')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaGV], [NamHoc]) VALUES (8, N'Lớp 4B', 8, N'2022-2023')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaGV], [NamHoc]) VALUES (9, N'Lớp 5A', 9, N'2022-2023')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaGV], [NamHoc]) VALUES (10, N'Lớp 5B', 10, N'2022-2023')
GO
INSERT [dbo].[Mon] ([MaMon], [TenMon]) VALUES (1, N'Toán')
INSERT [dbo].[Mon] ([MaMon], [TenMon]) VALUES (2, N'Văn')
INSERT [dbo].[Mon] ([MaMon], [TenMon]) VALUES (3, N'Anh')
INSERT [dbo].[Mon] ([MaMon], [TenMon]) VALUES (4, N'Lý')
INSERT [dbo].[Mon] ([MaMon], [TenMon]) VALUES (5, N'Hóa')
INSERT [dbo].[Mon] ([MaMon], [TenMon]) VALUES (6, N'Sử')
INSERT [dbo].[Mon] ([MaMon], [TenMon]) VALUES (7, N'Địa')
INSERT [dbo].[Mon] ([MaMon], [TenMon]) VALUES (8, N'GDCD')
INSERT [dbo].[Mon] ([MaMon], [TenMon]) VALUES (9, N'Công nghệ')
INSERT [dbo].[Mon] ([MaMon], [TenMon]) VALUES (10, N'Tin học')
INSERT [dbo].[Mon] ([MaMon], [TenMon]) VALUES (12, N'')
GO
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD FOREIGN KEY([MaHS])
REFERENCES [dbo].[HocSinh] ([MaHS])
GO
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD FOREIGN KEY([MaLoaiDiem])
REFERENCES [dbo].[LoaiDiem] ([MaLoaiDiem])
GO
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD FOREIGN KEY([MaMon])
REFERENCES [dbo].[Mon] ([MaMon])
GO
ALTER TABLE [dbo].[HocSinh]  WITH CHECK ADD FOREIGN KEY([MaLop])
REFERENCES [dbo].[Lop] ([MaLop])
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD FOREIGN KEY([MaGV])
REFERENCES [dbo].[GiaoVien] ([MaGV])
GO
USE [master]
GO
ALTER DATABASE [QLHS] SET  READ_WRITE 
GO
