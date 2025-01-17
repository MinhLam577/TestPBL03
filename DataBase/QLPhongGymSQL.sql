USE [QLPhongGym]
GO
/****** Object:  Table [dbo].[CaLamViec]    Script Date: 6/3/2023 11:15:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CaLamViec](
	[IDCa] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[GioBatDau] [time](7) NULL,
	[GioKetThuc] [time](7) NULL,
 CONSTRAINT [PK_CaLamViec] PRIMARY KEY CLUSTERED 
(
	[IDCa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DangKiGoiTap]    Script Date: 6/3/2023 11:15:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangKiGoiTap](
	[IDDK] [int] IDENTITY(1,1) NOT NULL,
	[IDKH] [int] NULL,
	[IDGT] [int] NULL,
	[Description] [nvarchar](max) NULL,
	[NgayDangKiGT] [date] NULL,
	[NgayKetThucGT] [date] NULL,
	[NgayKetThucBaoLuu] [date] NULL,
	[SoNgayConLai] [int] NULL,
	[BaoLuu] [bit] NULL,
 CONSTRAINT [PK_DangKiKhachHang] PRIMARY KEY CLUSTERED 
(
	[IDDK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GoiTap]    Script Date: 6/3/2023 11:15:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GoiTap](
	[IDGT] [int] IDENTITY(1,1) NOT NULL,
	[NameGT] [nvarchar](100) NULL,
	[Price] [float] NULL,
	[ThoiHanTapTheoThang] [int] NULL,
 CONSTRAINT [PK_GoiTap] PRIMARY KEY CLUSTERED 
(
	[IDGT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 6/3/2023 11:15:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[IDHD] [int] IDENTITY(1,1) NOT NULL,
	[IDKH] [int] NOT NULL,
	[IDGT] [int] NULL,
	[IDLT] [int] NULL,
	[NgayThanhToan] [date] NULL,
	[Price] [float] NULL,
 CONSTRAINT [PK_HoaDon_1] PRIMARY KEY CLUSTERED 
(
	[IDHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichLamViecTrongTuan]    Script Date: 6/3/2023 11:15:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichLamViecTrongTuan](
	[IDLLV] [int] IDENTITY(1,1) NOT NULL,
	[IDHLV] [int] NULL,
	[IDCa] [int] NULL,
	[NgayBatDau] [date] NULL,
	[NgayKetThuc] [date] NULL,
	[NgayLam] [date] NULL,
 CONSTRAINT [PK_LichLamViecHLV] PRIMARY KEY CLUSTERED 
(
	[IDLLV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichThueHLV]    Script Date: 6/3/2023 11:15:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichThueHLV](
	[IDLT] [int] IDENTITY(1,1) NOT NULL,
	[IDHLV] [int] NOT NULL,
	[IDCa] [int] NULL,
	[NgayThue] [date] NULL,
	[IDKH] [int] NOT NULL,
 CONSTRAINT [PK_LichThueHLV] PRIMARY KEY CLUSTERED 
(
	[IDLT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhanQuyen]    Script Date: 6/3/2023 11:15:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanQuyen](
	[IDQuyen] [int] IDENTITY(1,1) NOT NULL,
	[TenQuyen] [varchar](50) NULL,
 CONSTRAINT [PK_PhanQuyen] PRIMARY KEY CLUSTERED 
(
	[IDQuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThietBi]    Script Date: 6/3/2023 11:15:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThietBi](
	[IDTB] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Image] [varchar](max) NULL,
	[SoLuong] [int] NULL,
	[SoLuongHong] [int] NULL,
	[NhaCungCap] [nvarchar](max) NULL,
	[MoTa] [nvarchar](max) NULL,
	[Price] [float] NULL,
	[NamSX] [date] NULL,
 CONSTRAINT [PK_ThietBi] PRIMARY KEY CLUSTERED 
(
	[IDTB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TK]    Script Date: 6/3/2023 11:15:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TK](
	[TenTK] [varchar](50) NOT NULL,
	[IDUser] [int] NULL,
	[MatkhauTK] [varchar](max) NULL,
	[IDQuyen] [int] NOT NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_TK] PRIMARY KEY CLUSTERED 
(
	[TenTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 6/3/2023 11:15:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[IDUsers] [int] IDENTITY(100000,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[DateBorn] [date] NULL,
	[Sex] [bit] NULL,
	[CCCD] [varchar](12) NULL,
	[Image] [varchar](max) NULL,
	[Gmail] [varchar](max) NULL,
	[Sdt] [varchar](10) NULL,
	[Address] [nvarchar](max) NULL,
	[BangCap] [nvarchar](max) NULL,
	[NamKinhNghiem] [int] NULL,
	[Type] [nvarchar](max) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[IDUsers] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CaLamViec] ON 

INSERT [dbo].[CaLamViec] ([IDCa], [Name], [GioBatDau], [GioKetThuc]) VALUES (1, N'1', CAST(N'06:30:00' AS Time), CAST(N'11:30:00' AS Time))
INSERT [dbo].[CaLamViec] ([IDCa], [Name], [GioBatDau], [GioKetThuc]) VALUES (2, N'2', CAST(N'12:30:00' AS Time), CAST(N'17:30:00' AS Time))
INSERT [dbo].[CaLamViec] ([IDCa], [Name], [GioBatDau], [GioKetThuc]) VALUES (3, N'3', CAST(N'18:30:00' AS Time), CAST(N'20:30:00' AS Time))
SET IDENTITY_INSERT [dbo].[CaLamViec] OFF
GO
SET IDENTITY_INSERT [dbo].[DangKiGoiTap] ON 

INSERT [dbo].[DangKiGoiTap] ([IDDK], [IDKH], [IDGT], [Description], [NgayDangKiGT], [NgayKetThucGT], [NgayKetThucBaoLuu], [SoNgayConLai], [BaoLuu]) VALUES (2, 100002, 1, N'Tập luyện để đẹp trai, có nhiều đứa yêu', CAST(N'2023-04-16' AS Date), CAST(N'2023-05-18' AS Date), NULL, NULL, 0)
INSERT [dbo].[DangKiGoiTap] ([IDDK], [IDKH], [IDGT], [Description], [NgayDangKiGT], [NgayKetThucGT], [NgayKetThucBaoLuu], [SoNgayConLai], [BaoLuu]) VALUES (3, 100009, 1, N'- Tình hình sức khỏe: Tôi sức khỏe ổn định, điện nước đầy đủ, có thể tập 3 - 5 ngày 1 tuần
- Mục đích tập luyện: Đẹp trai, khoai to, 6 múi, nhiều người yêu', CAST(N'2023-04-16' AS Date), CAST(N'2023-05-16' AS Date), NULL, NULL, 0)
INSERT [dbo].[DangKiGoiTap] ([IDDK], [IDKH], [IDGT], [Description], [NgayDangKiGT], [NgayKetThucGT], [NgayKetThucBaoLuu], [SoNgayConLai], [BaoLuu]) VALUES (5, 100011, 1, N'', CAST(N'2023-04-17' AS Date), CAST(N'2023-05-17' AS Date), NULL, NULL, 0)
INSERT [dbo].[DangKiGoiTap] ([IDDK], [IDKH], [IDGT], [Description], [NgayDangKiGT], [NgayKetThucGT], [NgayKetThucBaoLuu], [SoNgayConLai], [BaoLuu]) VALUES (7, 100016, 1, N'', CAST(N'2023-04-17' AS Date), CAST(N'2023-05-17' AS Date), NULL, NULL, 0)
INSERT [dbo].[DangKiGoiTap] ([IDDK], [IDKH], [IDGT], [Description], [NgayDangKiGT], [NgayKetThucGT], [NgayKetThucBaoLuu], [SoNgayConLai], [BaoLuu]) VALUES (8, 100003, 1, N'', CAST(N'2023-04-19' AS Date), CAST(N'2023-05-19' AS Date), NULL, NULL, 0)
INSERT [dbo].[DangKiGoiTap] ([IDDK], [IDKH], [IDGT], [Description], [NgayDangKiGT], [NgayKetThucGT], [NgayKetThucBaoLuu], [SoNgayConLai], [BaoLuu]) VALUES (11, 100003, 2, N'Đẹp gái, quyến rũ, đảm đang', CAST(N'2023-05-22' AS Date), CAST(N'2023-11-22' AS Date), NULL, NULL, 0)
INSERT [dbo].[DangKiGoiTap] ([IDDK], [IDKH], [IDGT], [Description], [NgayDangKiGT], [NgayKetThucGT], [NgayKetThucBaoLuu], [SoNgayConLai], [BaoLuu]) VALUES (12, 100016, 3, N'- Mục tiêu đạt được 6 múi trong vòng 1 năm
- Sức khỏe tốt, nhịp tim, huyết áp ổn định phù hợp tập nặng
', CAST(N'2023-05-22' AS Date), CAST(N'2024-05-22' AS Date), NULL, NULL, 0)
INSERT [dbo].[DangKiGoiTap] ([IDDK], [IDKH], [IDGT], [Description], [NgayDangKiGT], [NgayKetThucGT], [NgayKetThucBaoLuu], [SoNgayConLai], [BaoLuu]) VALUES (14, 100009, 1, N'', CAST(N'2023-05-22' AS Date), CAST(N'2023-06-22' AS Date), NULL, NULL, 0)
INSERT [dbo].[DangKiGoiTap] ([IDDK], [IDKH], [IDGT], [Description], [NgayDangKiGT], [NgayKetThucGT], [NgayKetThucBaoLuu], [SoNgayConLai], [BaoLuu]) VALUES (16, 100016, 1, NULL, CAST(N'2023-02-01' AS Date), CAST(N'2023-03-01' AS Date), NULL, NULL, 0)
INSERT [dbo].[DangKiGoiTap] ([IDDK], [IDKH], [IDGT], [Description], [NgayDangKiGT], [NgayKetThucGT], [NgayKetThucBaoLuu], [SoNgayConLai], [BaoLuu]) VALUES (17, 100011, 1, NULL, CAST(N'2023-01-01' AS Date), CAST(N'2023-02-01' AS Date), NULL, NULL, 0)
INSERT [dbo].[DangKiGoiTap] ([IDDK], [IDKH], [IDGT], [Description], [NgayDangKiGT], [NgayKetThucGT], [NgayKetThucBaoLuu], [SoNgayConLai], [BaoLuu]) VALUES (18, 100009, 1, NULL, CAST(N'2023-01-03' AS Date), CAST(N'2023-02-03' AS Date), NULL, NULL, 0)
INSERT [dbo].[DangKiGoiTap] ([IDDK], [IDKH], [IDGT], [Description], [NgayDangKiGT], [NgayKetThucGT], [NgayKetThucBaoLuu], [SoNgayConLai], [BaoLuu]) VALUES (19, 100003, 1, NULL, CAST(N'2023-01-02' AS Date), CAST(N'2023-02-02' AS Date), NULL, NULL, 0)
INSERT [dbo].[DangKiGoiTap] ([IDDK], [IDKH], [IDGT], [Description], [NgayDangKiGT], [NgayKetThucGT], [NgayKetThucBaoLuu], [SoNgayConLai], [BaoLuu]) VALUES (20, 100002, 1, NULL, CAST(N'2023-02-01' AS Date), CAST(N'2023-03-01' AS Date), NULL, NULL, 0)
INSERT [dbo].[DangKiGoiTap] ([IDDK], [IDKH], [IDGT], [Description], [NgayDangKiGT], [NgayKetThucGT], [NgayKetThucBaoLuu], [SoNgayConLai], [BaoLuu]) VALUES (21, 100002, 1, NULL, CAST(N'2023-02-19' AS Date), CAST(N'2023-03-19' AS Date), NULL, NULL, 0)
INSERT [dbo].[DangKiGoiTap] ([IDDK], [IDKH], [IDGT], [Description], [NgayDangKiGT], [NgayKetThucGT], [NgayKetThucBaoLuu], [SoNgayConLai], [BaoLuu]) VALUES (22, 100009, 1, NULL, CAST(N'2023-02-20' AS Date), CAST(N'2023-02-20' AS Date), NULL, NULL, 0)
INSERT [dbo].[DangKiGoiTap] ([IDDK], [IDKH], [IDGT], [Description], [NgayDangKiGT], [NgayKetThucGT], [NgayKetThucBaoLuu], [SoNgayConLai], [BaoLuu]) VALUES (23, 100011, 1, N'', CAST(N'2023-05-24' AS Date), CAST(N'2023-06-24' AS Date), NULL, NULL, 0)
INSERT [dbo].[DangKiGoiTap] ([IDDK], [IDKH], [IDGT], [Description], [NgayDangKiGT], [NgayKetThucGT], [NgayKetThucBaoLuu], [SoNgayConLai], [BaoLuu]) VALUES (24, 100002, 2, N'', CAST(N'2023-05-24' AS Date), CAST(N'2023-11-24' AS Date), NULL, NULL, 0)
INSERT [dbo].[DangKiGoiTap] ([IDDK], [IDKH], [IDGT], [Description], [NgayDangKiGT], [NgayKetThucGT], [NgayKetThucBaoLuu], [SoNgayConLai], [BaoLuu]) VALUES (25, 101019, 3, N'', CAST(N'2023-05-24' AS Date), CAST(N'2024-05-24' AS Date), NULL, NULL, 0)
INSERT [dbo].[DangKiGoiTap] ([IDDK], [IDKH], [IDGT], [Description], [NgayDangKiGT], [NgayKetThucGT], [NgayKetThucBaoLuu], [SoNgayConLai], [BaoLuu]) VALUES (26, 101019, 5, N'', CAST(N'2023-05-25' AS Date), CAST(N'2023-07-25' AS Date), NULL, NULL, 0)
INSERT [dbo].[DangKiGoiTap] ([IDDK], [IDKH], [IDGT], [Description], [NgayDangKiGT], [NgayKetThucGT], [NgayKetThucBaoLuu], [SoNgayConLai], [BaoLuu]) VALUES (1024, 102019, 1, N'', CAST(N'2023-06-02' AS Date), CAST(N'2023-07-02' AS Date), NULL, NULL, 0)
INSERT [dbo].[DangKiGoiTap] ([IDDK], [IDKH], [IDGT], [Description], [NgayDangKiGT], [NgayKetThucGT], [NgayKetThucBaoLuu], [SoNgayConLai], [BaoLuu]) VALUES (1028, 102023, 2, N'', CAST(N'2023-06-03' AS Date), CAST(N'2023-12-03' AS Date), NULL, NULL, 0)
INSERT [dbo].[DangKiGoiTap] ([IDDK], [IDKH], [IDGT], [Description], [NgayDangKiGT], [NgayKetThucGT], [NgayKetThucBaoLuu], [SoNgayConLai], [BaoLuu]) VALUES (1029, 102027, 7, N'', CAST(N'2023-06-03' AS Date), CAST(N'2023-07-03' AS Date), NULL, NULL, 0)
INSERT [dbo].[DangKiGoiTap] ([IDDK], [IDKH], [IDGT], [Description], [NgayDangKiGT], [NgayKetThucGT], [NgayKetThucBaoLuu], [SoNgayConLai], [BaoLuu]) VALUES (1030, 102028, 4, N'', CAST(N'2023-06-03' AS Date), CAST(N'2025-06-03' AS Date), NULL, NULL, 0)
INSERT [dbo].[DangKiGoiTap] ([IDDK], [IDKH], [IDGT], [Description], [NgayDangKiGT], [NgayKetThucGT], [NgayKetThucBaoLuu], [SoNgayConLai], [BaoLuu]) VALUES (1031, 102029, 1, N'', CAST(N'2023-06-03' AS Date), CAST(N'2023-07-03' AS Date), NULL, NULL, 0)
INSERT [dbo].[DangKiGoiTap] ([IDDK], [IDKH], [IDGT], [Description], [NgayDangKiGT], [NgayKetThucGT], [NgayKetThucBaoLuu], [SoNgayConLai], [BaoLuu]) VALUES (1032, 102030, 1, N'', CAST(N'2023-06-03' AS Date), CAST(N'2023-07-03' AS Date), NULL, NULL, 0)
INSERT [dbo].[DangKiGoiTap] ([IDDK], [IDKH], [IDGT], [Description], [NgayDangKiGT], [NgayKetThucGT], [NgayKetThucBaoLuu], [SoNgayConLai], [BaoLuu]) VALUES (1033, 102031, 1, N'', CAST(N'2023-06-03' AS Date), CAST(N'2023-07-03' AS Date), NULL, NULL, 0)
INSERT [dbo].[DangKiGoiTap] ([IDDK], [IDKH], [IDGT], [Description], [NgayDangKiGT], [NgayKetThucGT], [NgayKetThucBaoLuu], [SoNgayConLai], [BaoLuu]) VALUES (1034, 102032, 1, N'Xinh gái, dễ thường, hòa đồng, đảm đang, tốt bụng, kiên trì và điện nước đầy đủ', CAST(N'2023-06-03' AS Date), CAST(N'2023-07-03' AS Date), NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[DangKiGoiTap] OFF
GO
SET IDENTITY_INSERT [dbo].[GoiTap] ON 

INSERT [dbo].[GoiTap] ([IDGT], [NameGT], [Price], [ThoiHanTapTheoThang]) VALUES (1, N'Yoga', 300000, 1)
INSERT [dbo].[GoiTap] ([IDGT], [NameGT], [Price], [ThoiHanTapTheoThang]) VALUES (2, N'6 múi trong 6 tháng', 1300000, 6)
INSERT [dbo].[GoiTap] ([IDGT], [NameGT], [Price], [ThoiHanTapTheoThang]) VALUES (3, N'Tập cùng Minh đẹp trai', 2300000, 12)
INSERT [dbo].[GoiTap] ([IDGT], [NameGT], [Price], [ThoiHanTapTheoThang]) VALUES (4, N'Tập cùng các em gái kèm "dịch vụ" đặc biệt', 4000000, 24)
INSERT [dbo].[GoiTap] ([IDGT], [NameGT], [Price], [ThoiHanTapTheoThang]) VALUES (5, N'Cơ ngực đẹp sau 2 tháng', 600000, 2)
INSERT [dbo].[GoiTap] ([IDGT], [NameGT], [Price], [ThoiHanTapTheoThang]) VALUES (6, N'Cardio', 400000, 1)
INSERT [dbo].[GoiTap] ([IDGT], [NameGT], [Price], [ThoiHanTapTheoThang]) VALUES (7, N'Hit cường độ cao', 450000, 1)
SET IDENTITY_INSERT [dbo].[GoiTap] OFF
GO
SET IDENTITY_INSERT [dbo].[HoaDon] ON 

INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [IDGT], [IDLT], [NgayThanhToan], [Price]) VALUES (1008, 100002, 1, NULL, CAST(N'2023-05-22' AS Date), 300000)
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [IDGT], [IDLT], [NgayThanhToan], [Price]) VALUES (1009, 100002, 1, NULL, CAST(N'2023-05-22' AS Date), 300000)
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [IDGT], [IDLT], [NgayThanhToan], [Price]) VALUES (1010, 100003, 2, NULL, CAST(N'2023-05-22' AS Date), 1300000)
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [IDGT], [IDLT], [NgayThanhToan], [Price]) VALUES (1011, 100016, 3, NULL, CAST(N'2023-05-22' AS Date), 2300000)
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [IDGT], [IDLT], [NgayThanhToan], [Price]) VALUES (1012, 100011, 2, NULL, CAST(N'2023-05-22' AS Date), 1300000)
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [IDGT], [IDLT], [NgayThanhToan], [Price]) VALUES (1013, 100009, 1, NULL, CAST(N'2023-05-22' AS Date), 300000)
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [IDGT], [IDLT], [NgayThanhToan], [Price]) VALUES (1014, 100002, 3, NULL, CAST(N'2023-01-21' AS Date), 300000)
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [IDGT], [IDLT], [NgayThanhToan], [Price]) VALUES (1015, 100003, 2, NULL, CAST(N'2023-01-24' AS Date), 1300000)
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [IDGT], [IDLT], [NgayThanhToan], [Price]) VALUES (1016, 100016, 3, NULL, CAST(N'2023-02-12' AS Date), 2300000)
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [IDGT], [IDLT], [NgayThanhToan], [Price]) VALUES (1017, 100011, 2, NULL, CAST(N'2023-03-01' AS Date), 1300000)
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [IDGT], [IDLT], [NgayThanhToan], [Price]) VALUES (1018, 100009, 1, NULL, CAST(N'2023-04-02' AS Date), 300000)
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [IDGT], [IDLT], [NgayThanhToan], [Price]) VALUES (1019, 100016, 4, NULL, CAST(N'2023-04-02' AS Date), 4000000)
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [IDGT], [IDLT], [NgayThanhToan], [Price]) VALUES (1020, 100016, 3, NULL, CAST(N'2023-02-15' AS Date), 2300000)
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [IDGT], [IDLT], [NgayThanhToan], [Price]) VALUES (1021, 100011, 1, NULL, CAST(N'2023-05-24' AS Date), 300000)
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [IDGT], [IDLT], [NgayThanhToan], [Price]) VALUES (1022, 100002, 2, NULL, CAST(N'2023-05-24' AS Date), 1300000)
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [IDGT], [IDLT], [NgayThanhToan], [Price]) VALUES (1023, 101019, 3, NULL, CAST(N'2023-05-24' AS Date), 2300000)
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [IDGT], [IDLT], [NgayThanhToan], [Price]) VALUES (1024, 101019, 5, NULL, CAST(N'2023-05-25' AS Date), 600000)
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [IDGT], [IDLT], [NgayThanhToan], [Price]) VALUES (1025, 100016, 1, NULL, CAST(N'2023-05-25' AS Date), 300000)
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [IDGT], [IDLT], [NgayThanhToan], [Price]) VALUES (1026, 100009, 1, NULL, CAST(N'2023-05-25' AS Date), 300000)
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [IDGT], [IDLT], [NgayThanhToan], [Price]) VALUES (2022, 102019, 1, NULL, CAST(N'2023-06-02' AS Date), 300000)
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [IDGT], [IDLT], [NgayThanhToan], [Price]) VALUES (2023, 100011, 1, NULL, CAST(N'2023-06-02' AS Date), 300000)
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [IDGT], [IDLT], [NgayThanhToan], [Price]) VALUES (2024, 100002, 2, NULL, CAST(N'2023-06-02' AS Date), 1300000)
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [IDGT], [IDLT], [NgayThanhToan], [Price]) VALUES (2025, 100003, 2, NULL, CAST(N'2023-06-02' AS Date), 1300000)
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [IDGT], [IDLT], [NgayThanhToan], [Price]) VALUES (2026, 102023, 2, NULL, CAST(N'2023-06-03' AS Date), 1300000)
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [IDGT], [IDLT], [NgayThanhToan], [Price]) VALUES (2027, 102027, 7, NULL, CAST(N'2023-06-03' AS Date), 450000)
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [IDGT], [IDLT], [NgayThanhToan], [Price]) VALUES (2028, 102028, 4, NULL, CAST(N'2023-06-03' AS Date), 4000000)
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [IDGT], [IDLT], [NgayThanhToan], [Price]) VALUES (2029, 102029, 1, NULL, CAST(N'2023-06-03' AS Date), 300000)
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [IDGT], [IDLT], [NgayThanhToan], [Price]) VALUES (2030, 102030, 1, NULL, CAST(N'2023-06-03' AS Date), 300000)
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [IDGT], [IDLT], [NgayThanhToan], [Price]) VALUES (2031, 102031, 1, NULL, CAST(N'2023-06-03' AS Date), 300000)
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [IDGT], [IDLT], [NgayThanhToan], [Price]) VALUES (2032, 102032, 1, NULL, CAST(N'2023-06-03' AS Date), 300000)
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
GO
SET IDENTITY_INSERT [dbo].[LichLamViecTrongTuan] ON 

INSERT [dbo].[LichLamViecTrongTuan] ([IDLLV], [IDHLV], [IDCa], [NgayBatDau], [NgayKetThuc], [NgayLam]) VALUES (1, 101017, 1, CAST(N'2023-06-01' AS Date), CAST(N'2023-06-07' AS Date), CAST(N'2023-06-01' AS Date))
INSERT [dbo].[LichLamViecTrongTuan] ([IDLLV], [IDHLV], [IDCa], [NgayBatDau], [NgayKetThuc], [NgayLam]) VALUES (3, 101017, 2, CAST(N'2023-06-01' AS Date), CAST(N'2023-06-07' AS Date), CAST(N'2023-06-01' AS Date))
SET IDENTITY_INSERT [dbo].[LichLamViecTrongTuan] OFF
GO
SET IDENTITY_INSERT [dbo].[LichThueHLV] ON 

INSERT [dbo].[LichThueHLV] ([IDLT], [IDHLV], [IDCa], [NgayThue], [IDKH]) VALUES (1, 101017, 1, CAST(N'2023-06-03' AS Date), 100002)
INSERT [dbo].[LichThueHLV] ([IDLT], [IDHLV], [IDCa], [NgayThue], [IDKH]) VALUES (7, 101017, 1, CAST(N'2023-06-03' AS Date), 100011)
INSERT [dbo].[LichThueHLV] ([IDLT], [IDHLV], [IDCa], [NgayThue], [IDKH]) VALUES (14, 101017, 1, CAST(N'2023-06-03' AS Date), 100016)
INSERT [dbo].[LichThueHLV] ([IDLT], [IDHLV], [IDCa], [NgayThue], [IDKH]) VALUES (6, 101017, 2, CAST(N'2023-06-03' AS Date), 100003)
INSERT [dbo].[LichThueHLV] ([IDLT], [IDHLV], [IDCa], [NgayThue], [IDKH]) VALUES (15, 101017, 2, CAST(N'2023-06-03' AS Date), 100009)
INSERT [dbo].[LichThueHLV] ([IDLT], [IDHLV], [IDCa], [NgayThue], [IDKH]) VALUES (2, 101018, 2, CAST(N'2023-06-03' AS Date), 100003)
INSERT [dbo].[LichThueHLV] ([IDLT], [IDHLV], [IDCa], [NgayThue], [IDKH]) VALUES (11, 101018, 3, CAST(N'2023-06-03' AS Date), 100009)
SET IDENTITY_INSERT [dbo].[LichThueHLV] OFF
GO
SET IDENTITY_INSERT [dbo].[PhanQuyen] ON 

INSERT [dbo].[PhanQuyen] ([IDQuyen], [TenQuyen]) VALUES (1, N'Admin')
INSERT [dbo].[PhanQuyen] ([IDQuyen], [TenQuyen]) VALUES (2, N'HLV')
SET IDENTITY_INSERT [dbo].[PhanQuyen] OFF
GO
SET IDENTITY_INSERT [dbo].[ThietBi] ON 

INSERT [dbo].[ThietBi] ([IDTB], [Name], [Image], [SoLuong], [SoLuongHong], [NhaCungCap], [MoTa], [Price], [NamSX]) VALUES (3, N'MCB-01', N'maychaybo.jpg', 4, 1, N'NCC1', N'máy chạy bộ đa năng phiên bản 1.0', 2000000, CAST(N'2023-04-02' AS Date))
INSERT [dbo].[ThietBi] ([IDTB], [Name], [Image], [SoLuong], [SoLuongHong], [NhaCungCap], [MoTa], [Price], [NamSX]) VALUES (5, N'MTCN-0001', N'may-tap-co-nguc.jpg', 3, 1, N'NCC1', N'máy chạy bộ đa năng', 12321312, CAST(N'2020-04-14' AS Date))
INSERT [dbo].[ThietBi] ([IDTB], [Name], [Image], [SoLuong], [SoLuongHong], [NhaCungCap], [MoTa], [Price], [NamSX]) VALUES (8, N'MCB-02', N'maychaybo.jpg', 3, 1, N'NC2', N'Máy chạy bộ đa năng', 2000000, CAST(N'1999-06-03' AS Date))
INSERT [dbo].[ThietBi] ([IDTB], [Name], [Image], [SoLuong], [SoLuongHong], [NhaCungCap], [MoTa], [Price], [NamSX]) VALUES (9, N'MCB-03', N'maychaybo.jpg', 5, 3, N'NCC4', N'Máy chạy bộ phiên bản 3.0', 1500000, CAST(N'1999-06-03' AS Date))
INSERT [dbo].[ThietBi] ([IDTB], [Name], [Image], [SoLuong], [SoLuongHong], [NhaCungCap], [MoTa], [Price], [NamSX]) VALUES (10, N'MTCN-03', N'may-tap-co-nguc.jpg', 3, 1, N'NCC2', N'Máy tập cơ ngực phiên bản 3.0', 1750000, CAST(N'2020-06-03' AS Date))
INSERT [dbo].[ThietBi] ([IDTB], [Name], [Image], [SoLuong], [SoLuongHong], [NhaCungCap], [MoTa], [Price], [NamSX]) VALUES (11, N'MTCD-01', N'may-tap-co-dap-dui-45-do.jpg', 2, 1, N'NCC3', N'Máy tập cơ đùi', 3000000, CAST(N'1999-06-03' AS Date))
SET IDENTITY_INSERT [dbo].[ThietBi] OFF
GO
INSERT [dbo].[TK] ([TenTK], [IDUser], [MatkhauTK], [IDQuyen], [TrangThai]) VALUES (N'HLV2', 101017, N'mCo7qGhtjQe8i1oFCviErA==', 2, 1)
INSERT [dbo].[TK] ([TenTK], [IDUser], [MatkhauTK], [IDQuyen], [TrangThai]) VALUES (N'HLV3', 102020, N'7SmIP6CuGhGNE96jBo/S7Q==', 2, 1)
INSERT [dbo].[TK] ([TenTK], [IDUser], [MatkhauTK], [IDQuyen], [TrangThai]) VALUES (N'HLV4', 102021, N'cVml/33tTYFFXrAR1a87OA==', 2, 1)
INSERT [dbo].[TK] ([TenTK], [IDUser], [MatkhauTK], [IDQuyen], [TrangThai]) VALUES (N'HLVGIRL', 102022, N'ZCAbTSVejYgFqRXBzrsWEQ==', 2, 1)
INSERT [dbo].[TK] ([TenTK], [IDUser], [MatkhauTK], [IDQuyen], [TrangThai]) VALUES (N'minh1234', 101018, N'6GFXYbVfFG0wnYO/pFhYZw==', 2, 0)
INSERT [dbo].[TK] ([TenTK], [IDUser], [MatkhauTK], [IDQuyen], [TrangThai]) VALUES (N'Minhbeta2003', 100000, N'7SmIP6CuGhGNE96jBo/S7Q==', 1, 1)
INSERT [dbo].[TK] ([TenTK], [IDUser], [MatkhauTK], [IDQuyen], [TrangThai]) VALUES (N'RanDomGirl', 102024, N'7SmIP6CuGhGNE96jBo/S7Q==', 2, 0)
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([IDUsers], [Name], [DateBorn], [Sex], [CCCD], [Image], [Gmail], [Sdt], [Address], [BangCap], [NamKinhNghiem], [Type]) VALUES (100000, N'Minh Legend', CAST(N'1999-04-04' AS Date), 1, N'231232131231', N'David.jpg', N'minh32405@gmail.com', N'2131232132', N'312321', NULL, NULL, N'Admin')
INSERT [dbo].[Users] ([IDUsers], [Name], [DateBorn], [Sex], [CCCD], [Image], [Gmail], [Sdt], [Address], [BangCap], [NamKinhNghiem], [Type]) VALUES (100002, N'Johnson', CAST(N'2000-04-04' AS Date), 1, N'313213123312', N'Johson.jpg', N'minh324312@gmail.com', N'1232321232', N'Address3', NULL, NULL, N'KH')
INSERT [dbo].[Users] ([IDUsers], [Name], [DateBorn], [Sex], [CCCD], [Image], [Gmail], [Sdt], [Address], [BangCap], [NamKinhNghiem], [Type]) VALUES (100003, N'Saharah', CAST(N'1998-04-18' AS Date), 0, N'', N'Sahra.jpg', N'shahara123@gmail.com', N'1232321313', N'19 Châu Tinh Trì', NULL, NULL, N'KH')
INSERT [dbo].[Users] ([IDUsers], [Name], [DateBorn], [Sex], [CCCD], [Image], [Gmail], [Sdt], [Address], [BangCap], [NamKinhNghiem], [Type]) VALUES (100009, N'David', CAST(N'2005-04-15' AS Date), 1, N'123123213213', N'David.jpg', N'test12345@gmail.com', N'1232132132', N'123 phan dinh phung', NULL, NULL, N'KH')
INSERT [dbo].[Users] ([IDUsers], [Name], [DateBorn], [Sex], [CCCD], [Image], [Gmail], [Sdt], [Address], [BangCap], [NamKinhNghiem], [Type]) VALUES (100011, N'Jessica', CAST(N'1999-04-15' AS Date), 0, N'', N'69558140_533089953897894_5645885650491146240_n.jpg', N'', N'1232132321', N'Address 123', NULL, NULL, N'KH')
INSERT [dbo].[Users] ([IDUsers], [Name], [DateBorn], [Sex], [CCCD], [Image], [Gmail], [Sdt], [Address], [BangCap], [NamKinhNghiem], [Type]) VALUES (100016, N'Minh Soái Ca', CAST(N'1999-04-16' AS Date), 1, N'123213123211', N'Minh.jpg', N'minhcute2134@gmail.com', N'1232132133', N'123 ca chep', NULL, NULL, N'KH')
INSERT [dbo].[Users] ([IDUsers], [Name], [DateBorn], [Sex], [CCCD], [Image], [Gmail], [Sdt], [Address], [BangCap], [NamKinhNghiem], [Type]) VALUES (101017, N'Nguyễn Văn A', CAST(N'1989-05-15' AS Date), 1, N'123123112131', N'HLV_C.jpg', N'minh32405@gmail.com', N'3121123231', N'789 Trường Chinh', N'Xuất sắc', 5, N'HLV')
INSERT [dbo].[Users] ([IDUsers], [Name], [DateBorn], [Sex], [CCCD], [Image], [Gmail], [Sdt], [Address], [BangCap], [NamKinhNghiem], [Type]) VALUES (101018, N'Nguyễn Văn B', CAST(N'1999-02-12' AS Date), 1, N'123112324441', N'HLV_E.jpg', N'duynghia0705@gmail.com', N'3312311232', N'91 lê nổ', N'Xuất sắc', 4, N'HLV')
INSERT [dbo].[Users] ([IDUsers], [Name], [DateBorn], [Sex], [CCCD], [Image], [Gmail], [Sdt], [Address], [BangCap], [NamKinhNghiem], [Type]) VALUES (101019, N'Nhân pro max', CAST(N'2000-05-24' AS Date), 1, N'', NULL, N'', N'1231211321', N'Address 1231', NULL, NULL, N'KH')
INSERT [dbo].[Users] ([IDUsers], [Name], [DateBorn], [Sex], [CCCD], [Image], [Gmail], [Sdt], [Address], [BangCap], [NamKinhNghiem], [Type]) VALUES (102019, N'Minh Nguyệt', CAST(N'1999-05-02' AS Date), 0, N'123123111322', N'Nguyet.jpg', N'', N'1232333111', N'Address13231', NULL, NULL, N'KH')
INSERT [dbo].[Users] ([IDUsers], [Name], [DateBorn], [Sex], [CCCD], [Image], [Gmail], [Sdt], [Address], [BangCap], [NamKinhNghiem], [Type]) VALUES (102020, N'Nguyễn Văn C', CAST(N'2000-10-03' AS Date), 1, N'123441112322', N'HLV_AAA.jpg', N'minhduclam598@gmail.com', N'1232313111', N'AddressABC', N'Xuất sắc', NULL, N'HLV')
INSERT [dbo].[Users] ([IDUsers], [Name], [DateBorn], [Sex], [CCCD], [Image], [Gmail], [Sdt], [Address], [BangCap], [NamKinhNghiem], [Type]) VALUES (102021, N'Nguyễn Văn D', CAST(N'1999-02-03' AS Date), 1, N'133110012332', N'HLV_AA.jpg', N'HLV123001@gmail.com', N'1211112222', N'Address A', N'Giỏi', NULL, N'HLV')
INSERT [dbo].[Users] ([IDUsers], [Name], [DateBorn], [Sex], [CCCD], [Image], [Gmail], [Sdt], [Address], [BangCap], [NamKinhNghiem], [Type]) VALUES (102022, N'Nguyễn Văn D', CAST(N'1987-06-03' AS Date), 0, N'111112233311', N'HLVN.jpg', N'vuilachinh@gmail.com', N'1231133333', N'AddressC', N'Trung Bình', NULL, N'HLV')
INSERT [dbo].[Users] ([IDUsers], [Name], [DateBorn], [Sex], [CCCD], [Image], [Gmail], [Sdt], [Address], [BangCap], [NamKinhNghiem], [Type]) VALUES (102023, N'Smith', CAST(N'1999-06-03' AS Date), 1, N'', N'Smith.jpg', N'', N'1231211234', N'AddressCBD', NULL, NULL, N'KH')
INSERT [dbo].[Users] ([IDUsers], [Name], [DateBorn], [Sex], [CCCD], [Image], [Gmail], [Sdt], [Address], [BangCap], [NamKinhNghiem], [Type]) VALUES (102024, N'RandomGirl', CAST(N'1999-06-03' AS Date), 0, N'133312312241', N'HLV_GirlXinh1.jpg', N'randomgirl1234@gmail.com', N'1231231212', N'Address111', N'Giỏi', NULL, N'HLV')
INSERT [dbo].[Users] ([IDUsers], [Name], [DateBorn], [Sex], [CCCD], [Image], [Gmail], [Sdt], [Address], [BangCap], [NamKinhNghiem], [Type]) VALUES (102025, N'TechnologyGirl', CAST(N'1988-06-03' AS Date), 0, N'123244412111', N'KH5.jpg', N'technology123@gmail.com', N'1232112324', N'123 Phan Châu Trinh', N'Xuất sắc', NULL, N'HLV')
INSERT [dbo].[Users] ([IDUsers], [Name], [DateBorn], [Sex], [CCCD], [Image], [Gmail], [Sdt], [Address], [BangCap], [NamKinhNghiem], [Type]) VALUES (102026, N'Amelia', CAST(N'1988-06-03' AS Date), 0, N'123444100000', N'KH2.jpg', N'Amelia1234@gmail.com', N'1231244441', N'Aleska 123', N'Trung Bình', NULL, N'HLV')
INSERT [dbo].[Users] ([IDUsers], [Name], [DateBorn], [Sex], [CCCD], [Image], [Gmail], [Sdt], [Address], [BangCap], [NamKinhNghiem], [Type]) VALUES (102027, N'CustomerA', CAST(N'2000-06-03' AS Date), 1, N'', N'KH1.jpg', N'', N'1211122231', N'Address12344', NULL, NULL, N'KH')
INSERT [dbo].[Users] ([IDUsers], [Name], [DateBorn], [Sex], [CCCD], [Image], [Gmail], [Sdt], [Address], [BangCap], [NamKinhNghiem], [Type]) VALUES (102028, N'CustomerB', CAST(N'1997-06-03' AS Date), 1, N'', N'KH4.jpg', N'', N'1233333111', N'Address0001', NULL, NULL, N'KH')
INSERT [dbo].[Users] ([IDUsers], [Name], [DateBorn], [Sex], [CCCD], [Image], [Gmail], [Sdt], [Address], [BangCap], [NamKinhNghiem], [Type]) VALUES (102029, N'CustomerC', CAST(N'1999-06-03' AS Date), 0, N'', N'KH3.jpg', N'', N'8848482123', N'Address002', NULL, NULL, N'KH')
INSERT [dbo].[Users] ([IDUsers], [Name], [DateBorn], [Sex], [CCCD], [Image], [Gmail], [Sdt], [Address], [BangCap], [NamKinhNghiem], [Type]) VALUES (102030, N'CustomerD', CAST(N'1999-06-03' AS Date), 0, N'', N'HLV_DD.jpg', N'', N'0003123448', N'Address004', NULL, NULL, N'KH')
INSERT [dbo].[Users] ([IDUsers], [Name], [DateBorn], [Sex], [CCCD], [Image], [Gmail], [Sdt], [Address], [BangCap], [NamKinhNghiem], [Type]) VALUES (102031, N'CustomerE', CAST(N'1999-06-03' AS Date), 0, N'', N'HLV_Girl1.jpg', N'', N'8421327777', N'Address006', NULL, NULL, N'KH')
INSERT [dbo].[Users] ([IDUsers], [Name], [DateBorn], [Sex], [CCCD], [Image], [Gmail], [Sdt], [Address], [BangCap], [NamKinhNghiem], [Type]) VALUES (102032, N'CustomerF', CAST(N'1996-06-03' AS Date), 0, N'', N'HLV_Girl3.jpg', N'', N'1233100000', N'Address00001', NULL, NULL, N'KH')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
/****** Object:  Index [DKGT_UK]    Script Date: 6/3/2023 11:15:11 PM ******/
ALTER TABLE [dbo].[DangKiGoiTap] ADD  CONSTRAINT [DKGT_UK] UNIQUE NONCLUSTERED 
(
	[IDKH] ASC,
	[IDGT] ASC,
	[NgayDangKiGT] ASC,
	[NgayKetThucGT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [LLV_UK]    Script Date: 6/3/2023 11:15:11 PM ******/
ALTER TABLE [dbo].[LichLamViecTrongTuan] ADD  CONSTRAINT [LLV_UK] UNIQUE NONCLUSTERED 
(
	[IDHLV] ASC,
	[IDCa] ASC,
	[NgayLam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UK_LichThueHLV]    Script Date: 6/3/2023 11:15:11 PM ******/
ALTER TABLE [dbo].[LichThueHLV] ADD  CONSTRAINT [UK_LichThueHLV] UNIQUE NONCLUSTERED 
(
	[IDHLV] ASC,
	[IDCa] ASC,
	[NgayThue] ASC,
	[IDKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DangKiGoiTap]  WITH CHECK ADD  CONSTRAINT [FK_DangKiGoiTap_GoiTap] FOREIGN KEY([IDGT])
REFERENCES [dbo].[GoiTap] ([IDGT])
GO
ALTER TABLE [dbo].[DangKiGoiTap] CHECK CONSTRAINT [FK_DangKiGoiTap_GoiTap]
GO
ALTER TABLE [dbo].[DangKiGoiTap]  WITH CHECK ADD  CONSTRAINT [FK_DangKiGoiTap_Users] FOREIGN KEY([IDKH])
REFERENCES [dbo].[Users] ([IDUsers])
GO
ALTER TABLE [dbo].[DangKiGoiTap] CHECK CONSTRAINT [FK_DangKiGoiTap_Users]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_GoiTap] FOREIGN KEY([IDGT])
REFERENCES [dbo].[GoiTap] ([IDGT])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_GoiTap]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_LichThueHLV] FOREIGN KEY([IDLT])
REFERENCES [dbo].[LichThueHLV] ([IDLT])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_LichThueHLV]
GO
ALTER TABLE [dbo].[LichLamViecTrongTuan]  WITH CHECK ADD  CONSTRAINT [FK_LichLamViecTrongTuan_CaLamViec] FOREIGN KEY([IDCa])
REFERENCES [dbo].[CaLamViec] ([IDCa])
GO
ALTER TABLE [dbo].[LichLamViecTrongTuan] CHECK CONSTRAINT [FK_LichLamViecTrongTuan_CaLamViec]
GO
ALTER TABLE [dbo].[LichLamViecTrongTuan]  WITH CHECK ADD  CONSTRAINT [FK_LichLamViecTrongTuan_Users] FOREIGN KEY([IDHLV])
REFERENCES [dbo].[Users] ([IDUsers])
GO
ALTER TABLE [dbo].[LichLamViecTrongTuan] CHECK CONSTRAINT [FK_LichLamViecTrongTuan_Users]
GO
ALTER TABLE [dbo].[LichThueHLV]  WITH CHECK ADD  CONSTRAINT [FK_LichThueHLV_Users] FOREIGN KEY([IDHLV])
REFERENCES [dbo].[Users] ([IDUsers])
GO
ALTER TABLE [dbo].[LichThueHLV] CHECK CONSTRAINT [FK_LichThueHLV_Users]
GO
ALTER TABLE [dbo].[LichThueHLV]  WITH CHECK ADD  CONSTRAINT [FK_LichThueHLV_Users1] FOREIGN KEY([IDKH])
REFERENCES [dbo].[Users] ([IDUsers])
GO
ALTER TABLE [dbo].[LichThueHLV] CHECK CONSTRAINT [FK_LichThueHLV_Users1]
GO
ALTER TABLE [dbo].[TK]  WITH CHECK ADD  CONSTRAINT [FK_TK_PhanQuyen] FOREIGN KEY([IDQuyen])
REFERENCES [dbo].[PhanQuyen] ([IDQuyen])
GO
ALTER TABLE [dbo].[TK] CHECK CONSTRAINT [FK_TK_PhanQuyen]
GO
ALTER TABLE [dbo].[TK]  WITH CHECK ADD  CONSTRAINT [FK_TK_Users] FOREIGN KEY([IDUser])
REFERENCES [dbo].[Users] ([IDUsers])
GO
ALTER TABLE [dbo].[TK] CHECK CONSTRAINT [FK_TK_Users]
GO
/****** Object:  StoredProcedure [dbo].[CatNhatIdentity]    Script Date: 6/3/2023 11:15:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CatNhatIdentity]
@TBName varchar(MAX)
as
dbcc checkident (@TBName, reseed, 0)
GO
/****** Object:  StoredProcedure [dbo].[FindUKByName]    Script Date: 6/3/2023 11:15:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[FindUKByName]
@name varchar(MAX)
as
select CCU.CONSTRAINT_NAME, CCU.COLUMN_NAME
from INFORMATION_SCHEMA.TABLE_CONSTRAINTS as TCons
inner join INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE as CCU
    on      TCons.CONSTRAINT_CATALOG = CCU.CONSTRAINT_CATALOG
        and TCons.CONSTRAINT_SCHEMA = CCU.CONSTRAINT_SCHEMA
        and TCons.CONSTRAINT_NAME = CCU.CONSTRAINT_NAME
where      TCons.CONSTRAINT_TYPE = 'UNIQUE'
      and  TCons.TABLE_NAME = @name
GO
