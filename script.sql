USE [tinhtiendien]
GO
/****** Object:  Table [dbo].[CTHOADON]    Script Date: 4/23/2021 5:20:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHOADON](
	[Mact] [int] IDENTITY(1,1) NOT NULL,
	[Mahd] [varchar](10) NOT NULL,
	[Dntt] [int] NOT NULL,
	[Dongia] [money] NOT NULL,
	[Ngaythanhlap] [datetime] NOT NULL,
	[Makh] [varchar](30) NOT NULL,
	[Tusokw][int] NOT NULL,
	[Densokw][int] NOT NULL,

PRIMARY KEY CLUSTERED 
(
	[Mact] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DIENKE]    Script Date: 4/23/2021 5:20:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DIENKE](
	[Madk] [varchar](8) NOT NULL,
	[Makh] [varchar](30) NOT NULL,
	[Ngaysx] [datetime] NOT NULL,
	[Ngaylap] [datetime] NOT NULL,
	[Mota] [nvarchar](100) NOT NULL,
	[Trangthai] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Madk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GIADIEN]    Script Date: 4/23/2021 5:20:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIADIEN](
	[Mabac] [int] IDENTITY(1,1) NOT NULL,
	[Tenbac] [nvarchar](255) NOT NULL,
	[Tusokw] [int] NOT NULL,
	[Densokw] [int] NOT NULL,
	[Dongia] [money] NOT NULL,
	[Ngaythanhlap] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Mabac] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 4/23/2021 5:20:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[Mahd] [varchar](10) NOT NULL,
	[Ky] [nvarchar](7) NOT NULL,
	[Tungay] [datetime] NOT NULL,
	[Denngay] [datetime] NOT NULL,
	[Chisodau] [int] NOT NULL,
	[Chisocuoi] [int] NOT NULL,
	[Tongthanhtien] [money] NOT NULL,
	[Ngaylaphd] [datetime] NOT NULL,
	[Tinhtrang] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Mahd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHANHHANG]    Script Date: 4/23/2021 5:20:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHANHHANG](
	[Makh] [varchar](30) NOT NULL,
	[Tenkh] [nvarchar](255) NOT NULL,
	[Diachi] [nvarchar](100) NOT NULL,
	[Dienthoai] [int] NOT NULL,
	[CMND] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Makh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CTHOADON]  WITH CHECK ADD  CONSTRAINT [FKCTHOADON592401] FOREIGN KEY([Mahd])
REFERENCES [dbo].[HOADON] ([Mahd])
GO
ALTER TABLE [dbo].[CTHOADON] CHECK CONSTRAINT [FKCTHOADON592401]
GO
ALTER TABLE [dbo].[CTHOADON]  WITH CHECK ADD  CONSTRAINT [FKCTHOADON717396] FOREIGN KEY([Makh])
REFERENCES [dbo].[KHANHHANG] ([Makh])
GO
ALTER TABLE [dbo].[CTHOADON] CHECK CONSTRAINT [FKCTHOADON717396]
GO
ALTER TABLE [dbo].[DIENKE]  WITH CHECK ADD  CONSTRAINT [FKDIENKE282020] FOREIGN KEY([Makh])
REFERENCES [dbo].[KHANHHANG] ([Makh])
GO
ALTER TABLE [dbo].[DIENKE] CHECK CONSTRAINT [FKDIENKE282020]
GO
