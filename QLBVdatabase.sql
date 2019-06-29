USE [Quanlibenhvien_offical]
GO
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 6/29/2019 11:40:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUCVU](
	[IDchucvu] [varchar](20) NOT NULL,
	[tenchucvu] [nvarchar](100) NULL,
 CONSTRAINT [PK_CHUCVU] PRIMARY KEY CLUSTERED 
(
	[IDchucvu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 6/29/2019 11:40:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[IDnv] [varchar](20) NOT NULL,
	[Hodem] [nvarchar](30) NULL,
	[Ten] [nvarchar](20) NULL,
	[Gioitinh] [bit] NULL,
	[Sđt] [varchar](12) NULL,
	[Xaphuong] [nvarchar](50) NULL,
	[Quanhuyen] [nvarchar](50) NULL,
	[Tinhthanhpho] [nvarchar](50) NULL,
	[IDchucvu] [varchar](20) NULL,
	[Trinhdo] [nvarchar](30) NULL,
	[IDtk] [nchar](10) NULL,
	[IDkhoa] [varchar](20) NULL,
 CONSTRAINT [PK_BACSY] PRIMARY KEY CLUSTERED 
(
	[IDnv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[DANHSACHNHANVIENVIEW]    Script Date: 6/29/2019 11:40:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[DANHSACHNHANVIENVIEW]
AS
SELECT        dbo.NHANVIEN.IDnv, CONCAT_ws(' ', dbo.NHANVIEN.Hodem, dbo.NHANVIEN.Ten) AS hoten, dbo.CHUCVU.tenchucvu
FROM            dbo.NHANVIEN INNER JOIN
                         dbo.CHUCVU ON dbo.NHANVIEN.IDchucvu = dbo.CHUCVU.IDchucvu
GO
/****** Object:  Table [dbo].[BENHNHAN]    Script Date: 6/29/2019 11:40:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BENHNHAN](
	[IDbn] [varchar](20) NOT NULL,
	[hodem] [nvarchar](30) NULL,
	[Ten] [nvarchar](30) NULL,
	[gioitinh] [bit] NULL,
	[ngaysinh] [date] NULL,
	[Sdt] [varchar](15) NULL,
	[Xaphuong] [nvarchar](30) NULL,
	[Quanhuyen] [nvarchar](30) NULL,
	[Tinhthanhpho] [nvarchar](30) NULL,
	[Nghenghiep] [nvarchar](50) NULL,
	[CMTND] [varchar](15) NULL,
	[Giaykhaisinh] [varchar](20) NULL,
 CONSTRAINT [PK_BENHNHAN] PRIMARY KEY CLUSTERED 
(
	[IDbn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[search_hotenbn]    Script Date: 6/29/2019 11:40:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[search_hotenbn]
as
select BENHNHAN.IDbn ,CONCAT_WS('',hodem,Ten) as hovaten
from BENHNHAN
GO
/****** Object:  View [dbo].[TTnhanvien]    Script Date: 6/29/2019 11:40:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[TTnhanvien]
AS
SELECT        IDnv, CONCAT_ws(' ', Hodem, Ten) AS hoten, Chucvu
FROM            dbo.NHANVIEN
GO
/****** Object:  View [dbo].[bophan_data]    Script Date: 6/29/2019 11:40:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[bophan_data] as
 SELECT        Row_number() over (order by IDbp) AS STT, IDbp AS [Mã bộ phận], Tenbophan AS [Tên bộ phận], Ngaythanhlap AS [Ngày thành lập]
FROM            BOPHAN
GO
/****** Object:  Table [dbo].[BENHAN]    Script Date: 6/29/2019 11:40:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BENHAN](
	[IDba] [varchar](20) NOT NULL,
	[Ngaylap] [datetime] NULL,
	[Ngaybangiao] [datetime] NULL,
	[IDloaihinh] [varchar](20) NULL,
	[IDbn] [varchar](20) NOT NULL,
 CONSTRAINT [PK_BENHAN_1] PRIMARY KEY CLUSTERED 
(
	[IDba] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BENHNHANLAMVIEC]    Script Date: 6/29/2019 11:40:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BENHNHANLAMVIEC](
	[IDbnlv] [varchar](20) NOT NULL,
	[IDbn] [varchar](20) NOT NULL,
	[IDpb] [varchar](20) NULL,
	[IDba] [varchar](20) NULL,
	[ngaydk] [date] NOT NULL,
	[giodk] [time](7) NOT NULL,
	[STT] [int] NOT NULL,
	[IDtrangthai] [varchar](20) NULL,
	[IDnv] [varchar](20) NULL,
 CONSTRAINT [PK_PHIEUDANGKYKHAM] PRIMARY KEY CLUSTERED 
(
	[IDbnlv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BHYT]    Script Date: 6/29/2019 11:40:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BHYT](
	[IDbhyt] [varchar](20) NOT NULL,
	[Ngaycap] [date] NULL,
	[Ngayhethan] [date] NULL,
	[Csbd] [nvarchar](100) NULL,
	[IDtuyen] [varchar](20) NULL,
	[DTUT] [int] NULL,
	[IDbn] [varchar](20) NULL,
	[IDdt] [int] NULL,
 CONSTRAINT [PK_BHYT] PRIMARY KEY CLUSTERED 
(
	[IDbhyt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHITIETDONTHUOC]    Script Date: 6/29/2019 11:40:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETDONTHUOC](
	[IDdonthuoc] [varchar](20) NOT NULL,
	[IDthuoc] [varchar](20) NOT NULL,
	[DVM] [nvarchar](20) NULL,
	[Soluong] [int] NULL,
	[Lieudung] [nvarchar](50) NULL,
 CONSTRAINT [PK_CHITIETDONTHUOC] PRIMARY KEY CLUSTERED 
(
	[IDdonthuoc] ASC,
	[IDthuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DICHVU]    Script Date: 6/29/2019 11:40:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DICHVU](
	[IDdichvu] [varchar](20) NOT NULL,
	[TenDV] [nvarchar](50) NULL,
	[Maymoc] [nvarchar](50) NULL,
	[Giatien] [int] NULL,
 CONSTRAINT [PK_DICHVU] PRIMARY KEY CLUSTERED 
(
	[IDdichvu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DONTHUOC]    Script Date: 6/29/2019 11:40:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DONTHUOC](
	[IDdonthuoc] [varchar](20) NOT NULL,
	[Ngaylap] [date] NULL,
	[IDba] [varchar](20) NULL,
	[IDnv] [varchar](20) NULL,
	[Thanhtien] [int] NULL,
 CONSTRAINT [PK_DONTHUOC] PRIMARY KEY CLUSTERED 
(
	[IDdonthuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DTUT]    Script Date: 6/29/2019 11:40:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DTUT](
	[IDdt] [int] NOT NULL,
	[TenDT] [nvarchar](50) NULL,
	[phantramhuong] [int] NULL,
 CONSTRAINT [PK_DTUT] PRIMARY KEY CLUSTERED 
(
	[IDdt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GIAYCHUYENVIEN]    Script Date: 6/29/2019 11:40:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIAYCHUYENVIEN](
	[IDgcv] [varchar](20) NOT NULL,
	[IDbhyt] [varchar](20) NOT NULL,
	[Ngaycap] [date] NULL,
	[Chuandoan] [nvarchar](100) NULL,
	[lydochuyen] [nvarchar](100) NULL,
	[Noicap] [nvarchar](100) NULL,
	[Nguoicap] [nvarchar](50) NULL,
 CONSTRAINT [PK_GIAYCHUYENVIEN] PRIMARY KEY CLUSTERED 
(
	[IDgcv] ASC,
	[IDbhyt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHOA]    Script Date: 6/29/2019 11:40:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHOA](
	[IDkhoa] [varchar](20) NOT NULL,
	[Tenkhoa] [nvarchar](50) NULL,
	[IDtruongkhoa] [varchar](20) NULL,
	[Ngaythanhlap] [date] NULL,
 CONSTRAINT [PK_KHOA] PRIMARY KEY CLUSTERED 
(
	[IDkhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIHINHDIEUTRI]    Script Date: 6/29/2019 11:40:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIHINHDIEUTRI](
	[IDloaihinh] [varchar](20) NOT NULL,
	[tenloaihinh] [nvarchar](50) NULL,
 CONSTRAINT [PK_LOAIHINHDIEUTRI] PRIMARY KEY CLUSTERED 
(
	[IDloaihinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIPHIEUXETNGHIEM]    Script Date: 6/29/2019 11:40:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIPHIEUXETNGHIEM](
	[IDloai] [varchar](20) NOT NULL,
	[Tenloai] [nvarchar](100) NULL,
 CONSTRAINT [PK_LOAIPHIEUXETNGHIEM] PRIMARY KEY CLUSTERED 
(
	[IDloai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIENLAMVIEC]    Script Date: 6/29/2019 11:40:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIENLAMVIEC](
	[IDnvlv] [varchar](20) NOT NULL,
	[IDnv] [varchar](20) NOT NULL,
	[IDpb] [varchar](20) NOT NULL,
	[Thoigianbatdau] [date] NULL,
	[Thoigianketthuc] [date] NULL,
 CONSTRAINT [PK_NHANVIENLAMVIEC] PRIMARY KEY CLUSTERED 
(
	[IDnvlv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHANQUYEN]    Script Date: 6/29/2019 11:40:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHANQUYEN](
	[IDquyen] [varchar](20) NOT NULL,
	[Tenquyen] [nvarchar](50) NULL,
 CONSTRAINT [PK_PHANQUYEN] PRIMARY KEY CLUSTERED 
(
	[IDquyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUHENKHAMLAI]    Script Date: 6/29/2019 11:40:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUHENKHAMLAI](
	[IDphieuhen] [varchar](20) NOT NULL,
	[ngaylap] [date] NULL,
	[ngayhen] [date] NULL,
	[IDnv] [varchar](20) NULL,
	[IDba] [varchar](20) NULL,
 CONSTRAINT [PK_PHIEUHENKHAMLAI] PRIMARY KEY CLUSTERED 
(
	[IDphieuhen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUKHAMBENH]    Script Date: 6/29/2019 11:40:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUKHAMBENH](
	[IDpk] [varchar](20) NOT NULL,
	[Ngaylap] [date] NULL,
	[giolap] [time](6) NULL,
	[Nhiptim] [nvarchar](50) NULL,
	[Nhiptho] [nvarchar](50) NULL,
	[Huyetap] [nvarchar](50) NULL,
	[Nhietdo] [nvarchar](50) NULL,
	[Cacbophan] [nvarchar](50) NULL,
	[Tieusubenh] [nvarchar](100) NULL,
	[CLS] [bit] NULL,
	[ChuandoanCLS] [nchar](100) NULL,
	[Ketluan] [nvarchar](1000) NULL,
	[Xuly] [nvarchar](1000) NULL,
	[IDba] [varchar](20) NOT NULL,
	[IDnv] [varchar](20) NULL,
 CONSTRAINT [PK_PHIEUKHAMBENH] PRIMARY KEY CLUSTERED 
(
	[IDpk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUTHANHTOANXNKT]    Script Date: 6/29/2019 11:40:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUTHANHTOANXNKT](
	[IDpttxn] [varchar](20) NOT NULL,
	[IDdichvu] [varchar](20) NULL,
	[ngaylap] [date] NULL,
	[giolap] [time](6) NULL,
	[trangthaitt] [bit] NULL,
	[phantramgiam] [nvarchar](50) NULL,
	[IDnv] [varchar](20) NULL,
	[IDba] [varchar](20) NULL,
	[IDbnlv] [varchar](20) NULL,
	[IDnvthungan] [varchar](20) NULL,
	[trangthaiXN] [bit] NULL,
 CONSTRAINT [PK_PHIEUTHANHTOANXNKT] PRIMARY KEY CLUSTERED 
(
	[IDpttxn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUXETNGHIEM]    Script Date: 6/29/2019 11:40:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUXETNGHIEM](
	[IDpxn] [varchar](20) NOT NULL,
	[gan] [nvarchar](500) NULL,
	[mat] [nvarchar](500) NULL,
	[tuy] [nvarchar](500) NULL,
	[lach] [nvarchar](500) NULL,
	[hethongtietlieu] [nvarchar](500) NULL,
	[tuyentienliet] [nvarchar](500) NULL,
	[mota] [nvarchar](100) NULL,
	[ketluan] [nvarchar](50) NULL,
	[IDnv] [varchar](20) NULL,
	[thoigianlap] [datetime] NULL,
	[IDpb] [varchar](20) NULL,
	[IDloai] [varchar](20) NULL,
	[IDpttxn] [varchar](20) NOT NULL,
 CONSTRAINT [PK_PHIEUSIEUAM] PRIMARY KEY CLUSTERED 
(
	[IDpxn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHONGBAN]    Script Date: 6/29/2019 11:40:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONGBAN](
	[IDpb] [varchar](20) NOT NULL,
	[Tenpb] [nvarchar](30) NULL,
	[Diachi] [nvarchar](50) NULL,
	[Nhiemvu] [nvarchar](50) NULL,
	[IDpbCha] [varchar](20) NULL,
	[IDkhoa] [varchar](20) NULL,
 CONSTRAINT [PK_PHONGBAN] PRIMARY KEY CLUSTERED 
(
	[IDpb] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHONGBANDICHVU]    Script Date: 6/29/2019 11:40:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONGBANDICHVU](
	[IDpb] [varchar](20) NOT NULL,
	[IDdichvu] [varchar](20) NOT NULL,
	[ghichu] [nvarchar](50) NULL,
 CONSTRAINT [PK_PHONGBANDICHVU] PRIMARY KEY CLUSTERED 
(
	[IDpb] ASC,
	[IDdichvu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 6/29/2019 11:40:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[IDtk] [varchar](20) NOT NULL,
	[Tendn] [varchar](20) NULL,
	[Matkhau] [varchar](20) NULL,
	[IDnv] [varchar](20) NULL,
	[IDquyen] [varchar](20) NULL,
 CONSTRAINT [PK_TAIKHOAN] PRIMARY KEY CLUSTERED 
(
	[IDtk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THUOC]    Script Date: 6/29/2019 11:40:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THUOC](
	[IDthuoc] [varchar](20) NOT NULL,
	[Tenthuoc] [nvarchar](50) NULL,
	[Thanhphan] [nvarchar](100) NULL,
	[Luongdung] [nvarchar](50) NULL,
	[DVT] [nvarchar](20) NULL,
	[Dongia] [int] NULL,
	[Xuatxu] [nvarchar](30) NULL,
 CONSTRAINT [PK_THUOC] PRIMARY KEY CLUSTERED 
(
	[IDthuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TRANGTHAILAMVIEC]    Script Date: 6/29/2019 11:40:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRANGTHAILAMVIEC](
	[IDtrangthai] [varchar](20) NOT NULL,
	[tentrangthai] [nvarchar](50) NULL,
 CONSTRAINT [PK_TRANGTHAILAMVIEC] PRIMARY KEY CLUSTERED 
(
	[IDtrangthai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TUYENBHYT]    Script Date: 6/29/2019 11:40:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TUYENBHYT](
	[IDtuyen] [varchar](20) NOT NULL,
	[Tentuyen] [nvarchar](50) NULL,
 CONSTRAINT [PK_TUYENBHYT] PRIMARY KEY CLUSTERED 
(
	[IDtuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA07062019001', CAST(N'2019-06-07T13:37:00.190' AS DateTime), NULL, N'1', N'BN07062019000')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA13062019001', CAST(N'2019-06-13T01:18:12.647' AS DateTime), NULL, NULL, N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA13062019002', CAST(N'2019-06-13T01:19:28.100' AS DateTime), NULL, NULL, N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA13062019003', CAST(N'2019-06-13T08:51:29.837' AS DateTime), NULL, NULL, N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA13062019004', CAST(N'2019-06-13T09:44:55.433' AS DateTime), NULL, NULL, N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA13062019005', CAST(N'2019-06-13T09:49:33.917' AS DateTime), NULL, NULL, N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA13062019006', CAST(N'2019-06-13T09:53:08.170' AS DateTime), NULL, NULL, N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA13062019007', CAST(N'2019-06-13T09:57:40.693' AS DateTime), NULL, NULL, N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA13062019008', CAST(N'2019-06-13T10:00:23.147' AS DateTime), NULL, NULL, N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA13062019009', CAST(N'2019-06-13T10:01:09.263' AS DateTime), NULL, NULL, N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA13062019010', CAST(N'2019-06-13T10:05:03.593' AS DateTime), NULL, NULL, N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA13062019011', CAST(N'2019-06-13T10:12:59.447' AS DateTime), NULL, NULL, N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA13062019012', CAST(N'2019-06-13T10:15:34.067' AS DateTime), NULL, NULL, N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA13062019013', CAST(N'2019-06-13T10:21:04.750' AS DateTime), NULL, NULL, N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA13062019014', CAST(N'2019-06-13T10:36:54.020' AS DateTime), NULL, NULL, N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA13062019015', CAST(N'2019-06-13T10:54:57.593' AS DateTime), NULL, NULL, N'BN23052019000')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA13062019016', CAST(N'2019-06-13T11:01:22.410' AS DateTime), NULL, NULL, N'BN22052019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA13062019017', CAST(N'2019-06-13T12:00:48.467' AS DateTime), NULL, NULL, N'BN22052019002')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA13062019018', CAST(N'2019-06-13T12:02:24.280' AS DateTime), CAST(N'2019-06-13T12:04:03.927' AS DateTime), NULL, N'BN22052019002')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA13062019019', CAST(N'2019-06-13T12:06:40.287' AS DateTime), NULL, NULL, N'BN22052019002')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA13062019020', CAST(N'2019-06-13T12:08:17.983' AS DateTime), NULL, NULL, N'BN22052019002')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA13062019021', CAST(N'2019-06-13T12:10:24.167' AS DateTime), NULL, NULL, N'BN22052019002')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA13062019022', CAST(N'2019-06-13T13:12:59.597' AS DateTime), NULL, NULL, N'BN22052019002')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA13062019023', CAST(N'2019-06-13T23:39:56.410' AS DateTime), NULL, NULL, N'BN13062019000')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA13062019024', CAST(N'2019-06-13T23:55:32.780' AS DateTime), NULL, NULL, N'BN13062019000')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA13062019025', CAST(N'2019-06-13T23:58:34.617' AS DateTime), CAST(N'2019-06-13T23:58:57.280' AS DateTime), NULL, N'BN12052019003')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA14062019001', CAST(N'2019-06-14T00:10:14.733' AS DateTime), CAST(N'2019-06-14T00:11:43.437' AS DateTime), NULL, N'BN23052019000')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA14062019002', CAST(N'2019-06-14T00:12:59.037' AS DateTime), NULL, NULL, N'BN25052019000')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA14062019003', CAST(N'2019-06-14T00:27:21.143' AS DateTime), CAST(N'2019-06-14T00:44:53.030' AS DateTime), NULL, N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA14062019004', CAST(N'2019-06-14T01:50:03.230' AS DateTime), NULL, NULL, N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA14062019005', CAST(N'2019-06-14T01:54:44.107' AS DateTime), NULL, NULL, N'BN07062019000')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA14062019006', CAST(N'2019-06-14T10:15:21.323' AS DateTime), NULL, NULL, N'BN07062019000')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA19062019001', CAST(N'2019-06-19T14:42:14.910' AS DateTime), NULL, NULL, N'BN31052019000')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA19062019002', CAST(N'2019-06-19T15:57:17.460' AS DateTime), NULL, NULL, N'BN25052019000')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA19062019003', CAST(N'2019-06-19T16:00:08.740' AS DateTime), NULL, NULL, N'BN23052019000')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA20062019001', CAST(N'2019-06-20T07:26:08.660' AS DateTime), CAST(N'2019-06-20T07:38:12.390' AS DateTime), NULL, N'BN07062019000')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA20062019002', CAST(N'2019-06-20T07:38:20.087' AS DateTime), CAST(N'2019-06-20T07:38:43.213' AS DateTime), NULL, N'BN12052019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA20062019003', CAST(N'2019-06-20T07:43:09.647' AS DateTime), CAST(N'2019-06-20T07:43:23.480' AS DateTime), NULL, N'BN31052019000')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA20062019004', CAST(N'2019-06-20T07:45:19.630' AS DateTime), NULL, NULL, N'BN25052019000')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA20062019005', CAST(N'2019-06-20T07:50:53.573' AS DateTime), NULL, NULL, N'BN12052019003')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA20062019006', CAST(N'2019-06-20T10:08:26.523' AS DateTime), CAST(N'2019-06-20T10:09:21.197' AS DateTime), NULL, N'BN20062019000')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA20062019007', CAST(N'2019-06-20T10:15:19.337' AS DateTime), NULL, NULL, N'BN13062019002')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA20062019008', CAST(N'2019-06-20T12:44:03.707' AS DateTime), NULL, NULL, N'BN31052019000')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA20062019009', CAST(N'2019-06-20T12:54:49.817' AS DateTime), CAST(N'2019-06-20T13:16:16.563' AS DateTime), NULL, N'BN25052019000')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA20062019010', CAST(N'2019-06-20T13:57:22.823' AS DateTime), CAST(N'2019-06-20T13:58:18.267' AS DateTime), NULL, N'BN23052019000')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA20062019011', CAST(N'2019-06-20T15:26:52.397' AS DateTime), NULL, NULL, N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA20062019012', CAST(N'2019-06-20T15:33:11.340' AS DateTime), NULL, NULL, N'BN22052019006')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA20062019013', CAST(N'2019-06-20T16:01:57.107' AS DateTime), NULL, NULL, N'BN31052019000')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA20062019014', CAST(N'2019-06-20T16:11:29.883' AS DateTime), NULL, NULL, N'BN07062019000')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA21062019001', CAST(N'2019-06-21T09:30:22.997' AS DateTime), NULL, NULL, N'BN31052019000')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA23062019001', CAST(N'2019-06-23T22:36:42.387' AS DateTime), CAST(N'2019-06-23T13:58:18.267' AS DateTime), N'1', N'BN25052019000')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA23062019002', CAST(N'2019-06-23T23:35:04.120' AS DateTime), NULL, NULL, N'BN23052019000')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA28052019001', CAST(N'2019-05-28T23:05:15.787' AS DateTime), CAST(N'2019-05-29T00:49:33.853' AS DateTime), N'1', N'BN23052019000')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA28052019002', CAST(N'2019-05-28T23:06:17.683' AS DateTime), CAST(N'2019-05-28T23:06:31.227' AS DateTime), N'1', N'BN25052019000')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA28052019003', CAST(N'2019-05-28T23:06:49.597' AS DateTime), CAST(N'2019-05-28T23:07:08.430' AS DateTime), N'1', N'BN12052019004')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA28052019004', CAST(N'2019-05-28T23:10:47.303' AS DateTime), CAST(N'2019-05-29T00:50:07.530' AS DateTime), N'1', N'BN23052019000')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA28052019005', CAST(N'2019-05-28T23:18:57.257' AS DateTime), CAST(N'2019-05-28T23:19:13.460' AS DateTime), N'1', N'BN25052019000')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA28052019006', CAST(N'2019-05-28T23:20:00.023' AS DateTime), CAST(N'2019-05-28T23:20:18.303' AS DateTime), N'1', N'BN25052019000')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA29052019001', CAST(N'2019-05-29T12:19:19.750' AS DateTime), NULL, N'1', N'BN12052019004')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA29052019002', CAST(N'2019-05-29T12:21:29.577' AS DateTime), NULL, N'1', N'BN12052019004')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA29052019003', CAST(N'2019-05-29T14:25:57.620' AS DateTime), CAST(N'2019-05-29T14:26:52.653' AS DateTime), N'1', N'BN23052019000')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA29052019004', CAST(N'2019-05-29T14:29:27.930' AS DateTime), CAST(N'2019-05-29T14:31:11.257' AS DateTime), N'1', N'BN23052019000')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA29052019005', CAST(N'2019-05-29T14:30:17.300' AS DateTime), NULL, N'1', N'BN23052019000')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA29052019006', CAST(N'2019-05-29T14:42:14.087' AS DateTime), NULL, N'1', N'BN23052019000')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA29052019007', CAST(N'2019-05-29T15:38:24.173' AS DateTime), NULL, N'1', N'BN25052019000')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA29052019008', CAST(N'2019-05-29T17:37:06.687' AS DateTime), NULL, N'1', N'BN25052019000')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA29052019009', CAST(N'2019-05-29T17:41:25.917' AS DateTime), NULL, N'1', N'BN25052019000')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA29052019010', CAST(N'2019-05-29T19:07:05.223' AS DateTime), CAST(N'2019-05-30T02:01:15.163' AS DateTime), N'1', N'BN25052019000')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA30052019001', CAST(N'2019-05-30T01:42:31.673' AS DateTime), NULL, N'1', N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA30052019002', CAST(N'2019-05-30T02:01:32.167' AS DateTime), NULL, N'1', N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA30052019003', CAST(N'2019-05-30T03:03:21.277' AS DateTime), NULL, N'1', N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA30052019004', CAST(N'2019-05-30T03:03:53.603' AS DateTime), NULL, N'1', N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA30052019005', CAST(N'2019-05-30T03:07:53.483' AS DateTime), NULL, N'1', N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA30052019006', CAST(N'2019-05-30T03:12:14.507' AS DateTime), NULL, N'1', N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA30052019007', CAST(N'2019-05-30T15:11:42.627' AS DateTime), NULL, N'1', N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA30052019008', CAST(N'2019-05-30T15:28:39.000' AS DateTime), NULL, N'1', N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA30052019009', CAST(N'2019-05-30T15:30:57.007' AS DateTime), NULL, N'1', N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA30052019010', CAST(N'2019-05-30T15:33:01.053' AS DateTime), NULL, N'1', N'BN23052019000')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA30052019011', CAST(N'2019-05-30T15:34:24.647' AS DateTime), NULL, N'1', N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA30052019012', CAST(N'2019-05-30T15:35:50.577' AS DateTime), NULL, N'1', N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA30052019013', CAST(N'2019-05-30T15:37:32.723' AS DateTime), NULL, N'1', N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA30052019014', CAST(N'2019-05-30T15:40:48.913' AS DateTime), NULL, N'1', N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA30052019015', CAST(N'2019-05-30T15:42:28.197' AS DateTime), NULL, N'1', N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA30052019016', CAST(N'2019-05-30T15:46:50.453' AS DateTime), NULL, N'1', N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA30052019017', CAST(N'2019-05-30T15:51:57.340' AS DateTime), NULL, N'1', N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA30052019018', CAST(N'2019-05-30T15:54:04.393' AS DateTime), NULL, N'1', N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA30052019019', CAST(N'2019-05-30T15:56:57.560' AS DateTime), NULL, N'1', N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA30052019020', CAST(N'2019-05-30T15:59:29.770' AS DateTime), NULL, N'1', N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA30052019021', CAST(N'2019-05-30T16:31:13.920' AS DateTime), NULL, N'1', N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA30052019022', CAST(N'2019-05-30T17:26:55.733' AS DateTime), NULL, N'1', N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA30052019023', CAST(N'2019-05-30T17:29:18.753' AS DateTime), NULL, N'1', N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA30052019024', CAST(N'2019-05-30T17:31:51.333' AS DateTime), NULL, N'1', N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA30052019025', CAST(N'2019-05-30T17:34:04.870' AS DateTime), NULL, N'1', N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA30052019026', CAST(N'2019-05-30T17:36:00.527' AS DateTime), NULL, N'1', N'BN05102019001')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA31052019001', CAST(N'2019-05-31T08:56:24.307' AS DateTime), NULL, N'1', N'BN31052019000')
INSERT [dbo].[BENHAN] ([IDba], [Ngaylap], [Ngaybangiao], [IDloaihinh], [IDbn]) VALUES (N'BA31052019002', CAST(N'2019-05-31T09:06:29.580' AS DateTime), NULL, N'1', N'BN12052019004')
INSERT [dbo].[BENHNHAN] ([IDbn], [hodem], [Ten], [gioitinh], [ngaysinh], [Sdt], [Xaphuong], [Quanhuyen], [Tinhthanhpho], [Nghenghiep], [CMTND], [Giaykhaisinh]) VALUES (N'BN05102019001', N'Vũ Minh', N'Hiếu', 1, CAST(N'2000-09-04' AS Date), N'0132544545', N'Minh Tân', N'Kinh Môn', N'Hải Dương', N'Bộ Đội', N'148986566', N'')
INSERT [dbo].[BENHNHAN] ([IDbn], [hodem], [Ten], [gioitinh], [ngaysinh], [Sdt], [Xaphuong], [Quanhuyen], [Tinhthanhpho], [Nghenghiep], [CMTND], [Giaykhaisinh]) VALUES (N'BN07062019000', N'Phan Huy', N'Toàn', 1, CAST(N'1996-01-27' AS Date), N'0318250023', N'Thị trấn cổ lễ', N'Trực Ninh', N'Nam Định', N'Sinh Viên', N'036096002', N'')
INSERT [dbo].[BENHNHAN] ([IDbn], [hodem], [Ten], [gioitinh], [ngaysinh], [Sdt], [Xaphuong], [Quanhuyen], [Tinhthanhpho], [Nghenghiep], [CMTND], [Giaykhaisinh]) VALUES (N'BN12052019001', N'Vũ Minh', N'Sơn', 1, CAST(N'1997-09-04' AS Date), N'0211212122', N'Minh Tân', N'Kinh Môn', N'Hải Dương', N'Bộ Đội', N'142860969', N'')
INSERT [dbo].[BENHNHAN] ([IDbn], [hodem], [Ten], [gioitinh], [ngaysinh], [Sdt], [Xaphuong], [Quanhuyen], [Tinhthanhpho], [Nghenghiep], [CMTND], [Giaykhaisinh]) VALUES (N'BN12052019003', N'Vũ Hoàng', N'Lâm', 1, CAST(N'1997-09-04' AS Date), N'0232332322', N'Minh Tân', N'Kinh Môn', N'Hải Dương', N'Bộ Đội', N'142860969', N'')
INSERT [dbo].[BENHNHAN] ([IDbn], [hodem], [Ten], [gioitinh], [ngaysinh], [Sdt], [Xaphuong], [Quanhuyen], [Tinhthanhpho], [Nghenghiep], [CMTND], [Giaykhaisinh]) VALUES (N'BN12052019004', N'Vũ Hoàng', N'Lâm', 1, CAST(N'1997-09-04' AS Date), N'0123554554', N'Minh Tân', N'Kinh Môn', N'Hải Dương', N'Bộ Đội', N'142860969', N'')
INSERT [dbo].[BENHNHAN] ([IDbn], [hodem], [Ten], [gioitinh], [ngaysinh], [Sdt], [Xaphuong], [Quanhuyen], [Tinhthanhpho], [Nghenghiep], [CMTND], [Giaykhaisinh]) VALUES (N'BN12062019000', N'Đinh Thị', N'Mai', 0, CAST(N'1996-05-10' AS Date), N'0212154545', N'Hải Mai', N'Lĩnh Nam', N'Bắc Giang', N'Công chức', N'147665656', N'')
INSERT [dbo].[BENHNHAN] ([IDbn], [hodem], [Ten], [gioitinh], [ngaysinh], [Sdt], [Xaphuong], [Quanhuyen], [Tinhthanhpho], [Nghenghiep], [CMTND], [Giaykhaisinh]) VALUES (N'BN12062019001', N'Vũ Văn', N'Quýt', 1, CAST(N'1996-09-04' AS Date), N'0322323233', N'Ninh An', N'Sơn Tây ', N'Hà Nội', N'Sinh viên', N'148985655', N'')
INSERT [dbo].[BENHNHAN] ([IDbn], [hodem], [Ten], [gioitinh], [ngaysinh], [Sdt], [Xaphuong], [Quanhuyen], [Tinhthanhpho], [Nghenghiep], [CMTND], [Giaykhaisinh]) VALUES (N'BN12062019002', N'Nguyễn Thị', N' Xuân Nhật', 0, CAST(N'1998-01-27' AS Date), N'0321121216', N'Hải Phòng', N'Hải Phòng', N'Hải Phòng', N'Giáo viên', N'146656556', N'')
INSERT [dbo].[BENHNHAN] ([IDbn], [hodem], [Ten], [gioitinh], [ngaysinh], [Sdt], [Xaphuong], [Quanhuyen], [Tinhthanhpho], [Nghenghiep], [CMTND], [Giaykhaisinh]) VALUES (N'BN13062019000', N'Nguyễn Thị', N'Mai', 0, CAST(N'1997-05-24' AS Date), N'0321215484', N'Văn Giang', N'Hải Ninh', N'Hà Nội', N'Sinh Viên', N'147123673', N'')
INSERT [dbo].[BENHNHAN] ([IDbn], [hodem], [Ten], [gioitinh], [ngaysinh], [Sdt], [Xaphuong], [Quanhuyen], [Tinhthanhpho], [Nghenghiep], [CMTND], [Giaykhaisinh]) VALUES (N'BN13062019001', N'Vũ Văn', N'Minh', 1, CAST(N'1989-05-10' AS Date), N'0211212212', N'Minh Tân', N'Kinh Môn', N'Hải Dương', N'Kỹ sư tin học', N'142856344', N' ')
INSERT [dbo].[BENHNHAN] ([IDbn], [hodem], [Ten], [gioitinh], [ngaysinh], [Sdt], [Xaphuong], [Quanhuyen], [Tinhthanhpho], [Nghenghiep], [CMTND], [Giaykhaisinh]) VALUES (N'BN13062019002', N'Đinh Thị', N'Tý', 0, CAST(N'1990-05-10' AS Date), N'0321122115', N'Hải Giang', N'Ba Soi', N'Bắc Giang', N'Tự do', N'145454565', N' ')
INSERT [dbo].[BENHNHAN] ([IDbn], [hodem], [Ten], [gioitinh], [ngaysinh], [Sdt], [Xaphuong], [Quanhuyen], [Tinhthanhpho], [Nghenghiep], [CMTND], [Giaykhaisinh]) VALUES (N'BN20062019000', N'Nguyễn Khắc', N'Hoàng Anh', 1, CAST(N'1998-07-20' AS Date), N'0839773579', N'Ỷ La', N'Hà Đông', N'Hà Nội', N'Xe ôm', N'146655654', N' ')
INSERT [dbo].[BENHNHAN] ([IDbn], [hodem], [Ten], [gioitinh], [ngaysinh], [Sdt], [Xaphuong], [Quanhuyen], [Tinhthanhpho], [Nghenghiep], [CMTND], [Giaykhaisinh]) VALUES (N'BN22052019000', N'Vũ Văn', N'Thuận', 1, CAST(N'1997-09-04' AS Date), N'0454554555', N'Minh Hóa', N'Đồng Đăng', N'Bắc Ninh', N'Tự do', N'146565666', N'')
INSERT [dbo].[BENHNHAN] ([IDbn], [hodem], [Ten], [gioitinh], [ngaysinh], [Sdt], [Xaphuong], [Quanhuyen], [Tinhthanhpho], [Nghenghiep], [CMTND], [Giaykhaisinh]) VALUES (N'BN22052019001', N'Văn Tiến', N' Dũng', 1, CAST(N'1997-09-04' AS Date), N'0545454545', N'Minh Tân', N'Kinh Môn', N'Hải Dương', N'Bộ Đội', N'148563266', N'')
INSERT [dbo].[BENHNHAN] ([IDbn], [hodem], [Ten], [gioitinh], [ngaysinh], [Sdt], [Xaphuong], [Quanhuyen], [Tinhthanhpho], [Nghenghiep], [CMTND], [Giaykhaisinh]) VALUES (N'BN22052019002', N'Bùi Văn', N'Hưng', 1, CAST(N'2019-05-10' AS Date), N'0151212155', N'Minh Khai', N'Hà Đông', N'Hà Nội', N'Sinh viên', N'148455655', N'')
INSERT [dbo].[BENHNHAN] ([IDbn], [hodem], [Ten], [gioitinh], [ngaysinh], [Sdt], [Xaphuong], [Quanhuyen], [Tinhthanhpho], [Nghenghiep], [CMTND], [Giaykhaisinh]) VALUES (N'BN22052019003', N'Ninh Văn', N'Chiến', 1, CAST(N'2019-05-10' AS Date), N'0321323112', N'Đồng Đăng', N'Vĩnh Hòa', N'Quảng Ninh', N'Sinh Viên', N'142586364', N'')
INSERT [dbo].[BENHNHAN] ([IDbn], [hodem], [Ten], [gioitinh], [ngaysinh], [Sdt], [Xaphuong], [Quanhuyen], [Tinhthanhpho], [Nghenghiep], [CMTND], [Giaykhaisinh]) VALUES (N'BN22052019006', N'Nguyễn Thành', N'Hưng', 1, CAST(N'2019-05-10' AS Date), N'0231215555', N'Minh Khê', N'An Thuận', N'Lạng Sơn', N'Sinh Viên', N'145656566', N'')
INSERT [dbo].[BENHNHAN] ([IDbn], [hodem], [Ten], [gioitinh], [ngaysinh], [Sdt], [Xaphuong], [Quanhuyen], [Tinhthanhpho], [Nghenghiep], [CMTND], [Giaykhaisinh]) VALUES (N'BN23052019000', N'Nguyễn Thị', N' Minh Nghi', 0, CAST(N'1997-05-10' AS Date), N'0232323589', N'Hiệp Hòa', N'Kinh Môn', N'Hải Dương', N'Streamer', N'146265965', N'')
INSERT [dbo].[BENHNHAN] ([IDbn], [hodem], [Ten], [gioitinh], [ngaysinh], [Sdt], [Xaphuong], [Quanhuyen], [Tinhthanhpho], [Nghenghiep], [CMTND], [Giaykhaisinh]) VALUES (N'BN25052019000', N'Vương Sơn', N' Lâm', 1, CAST(N'2000-05-10' AS Date), N'0365154555', N'Minh Hòa ', N'Sơn La ', N'Playku', N'Tự do', N'148796789', N'')
INSERT [dbo].[BENHNHAN] ([IDbn], [hodem], [Ten], [gioitinh], [ngaysinh], [Sdt], [Xaphuong], [Quanhuyen], [Tinhthanhpho], [Nghenghiep], [CMTND], [Giaykhaisinh]) VALUES (N'BN31052019000', N'Vũ Văn', N' Hoa Vinh', 1, CAST(N'2000-05-10' AS Date), N'123456656', N'Láng Thượng', N'Đống đa', N'Hà Nội', N'Sinh viên', N'149898989', N'')
INSERT [dbo].[BENHNHANLAMVIEC] ([IDbnlv], [IDbn], [IDpb], [IDba], [ngaydk], [giodk], [STT], [IDtrangthai], [IDnv]) VALUES (N'BNLV20062019005', N'BN22052019006', N'PB037', N'BA20062019012', CAST(N'2019-06-20' AS Date), CAST(N'15:46:17' AS Time), 3, N'1', N'NV003')
INSERT [dbo].[BENHNHANLAMVIEC] ([IDbnlv], [IDbn], [IDpb], [IDba], [ngaydk], [giodk], [STT], [IDtrangthai], [IDnv]) VALUES (N'BNLV20062019006', N'BN22052019006', N'PB037', N'BA20062019012', CAST(N'2019-06-20' AS Date), CAST(N'15:48:15' AS Time), 4, N'1', N'NV003')
INSERT [dbo].[BENHNHANLAMVIEC] ([IDbnlv], [IDbn], [IDpb], [IDba], [ngaydk], [giodk], [STT], [IDtrangthai], [IDnv]) VALUES (N'BNLV20062019007', N'BN31052019000', N'PB022', N'BA20062019013', CAST(N'2019-06-20' AS Date), CAST(N'16:01:10' AS Time), 1, N'3', N'NV009')
INSERT [dbo].[BENHNHANLAMVIEC] ([IDbnlv], [IDbn], [IDpb], [IDba], [ngaydk], [giodk], [STT], [IDtrangthai], [IDnv]) VALUES (N'BNLV20062019008', N'BN31052019000', N'PB037', N'BA20062019013', CAST(N'2019-06-20' AS Date), CAST(N'16:04:46' AS Time), 5, N'1', N'NV003')
INSERT [dbo].[BENHNHANLAMVIEC] ([IDbnlv], [IDbn], [IDpb], [IDba], [ngaydk], [giodk], [STT], [IDtrangthai], [IDnv]) VALUES (N'BNLV20062019009', N'BN07062019000', N'PB022', N'BA20062019014', CAST(N'2019-06-20' AS Date), CAST(N'16:11:04' AS Time), 2, N'2', N'NV009')
INSERT [dbo].[BENHNHANLAMVIEC] ([IDbnlv], [IDbn], [IDpb], [IDba], [ngaydk], [giodk], [STT], [IDtrangthai], [IDnv]) VALUES (N'BNLV20062019010', N'BN12052019003', N'PB022', NULL, CAST(N'2019-06-20' AS Date), CAST(N'16:23:36' AS Time), 3, N'1', N'NV009')
INSERT [dbo].[BENHNHANLAMVIEC] ([IDbnlv], [IDbn], [IDpb], [IDba], [ngaydk], [giodk], [STT], [IDtrangthai], [IDnv]) VALUES (N'BNLV21062019001', N'BN31052019000', N'PB022', N'BA21062019001', CAST(N'2019-06-21' AS Date), CAST(N'09:29:26' AS Time), 1, N'3', N'NV009')
INSERT [dbo].[BENHNHANLAMVIEC] ([IDbnlv], [IDbn], [IDpb], [IDba], [ngaydk], [giodk], [STT], [IDtrangthai], [IDnv]) VALUES (N'BNLV23062019001', N'BN25052019000', N'PB022', N'BA23062019001', CAST(N'2019-06-23' AS Date), CAST(N'22:36:01' AS Time), 1, N'3', N'NV009')
INSERT [dbo].[BENHNHANLAMVIEC] ([IDbnlv], [IDbn], [IDpb], [IDba], [ngaydk], [giodk], [STT], [IDtrangthai], [IDnv]) VALUES (N'BNLV23062019002', N'BN23052019000', N'PB022', N'BA23062019002', CAST(N'2019-06-23' AS Date), CAST(N'23:34:40' AS Time), 2, N'3', N'NV009')
INSERT [dbo].[BENHNHANLAMVIEC] ([IDbnlv], [IDbn], [IDpb], [IDba], [ngaydk], [giodk], [STT], [IDtrangthai], [IDnv]) VALUES (N'BNLV23062019003', N'BN23052019000', N'PB037', N'BA23062019002', CAST(N'2019-06-23' AS Date), CAST(N'23:37:32' AS Time), 1, N'1', N'NV003')
INSERT [dbo].[BHYT] ([IDbhyt], [Ngaycap], [Ngayhethan], [Csbd], [IDtuyen], [DTUT], [IDbn], [IDdt]) VALUES (N'112233', CAST(N'2015-01-01' AS Date), CAST(N'2020-01-01' AS Date), N'Bệnh viện 108888888', N'T003', 1, N'BN05102019001', 1)
INSERT [dbo].[BHYT] ([IDbhyt], [Ngaycap], [Ngayhethan], [Csbd], [IDtuyen], [DTUT], [IDbn], [IDdt]) VALUES (N'312231312312323', CAST(N'2015-01-21' AS Date), CAST(N'2016-01-01' AS Date), N'312231312312323', N'T003', 2, N'BN05102019001', 1)
INSERT [dbo].[BHYT] ([IDbhyt], [Ngaycap], [Ngayhethan], [Csbd], [IDtuyen], [DTUT], [IDbn], [IDdt]) VALUES (N'a', CAST(N'2019-06-11' AS Date), CAST(N'2019-06-11' AS Date), N'a', N'T002', NULL, N'BN05102019001', 2)
INSERT [dbo].[BHYT] ([IDbhyt], [Ngaycap], [Ngayhethan], [Csbd], [IDtuyen], [DTUT], [IDbn], [IDdt]) VALUES (N'ád', CAST(N'2019-01-30' AS Date), CAST(N'2019-12-30' AS Date), N'ád', N'T003', 3, N'BN23052019000', 1)
INSERT [dbo].[BHYT] ([IDbhyt], [Ngaycap], [Ngayhethan], [Csbd], [IDtuyen], [DTUT], [IDbn], [IDdt]) VALUES (N'ádasdasd213quequeque', CAST(N'2019-06-20' AS Date), CAST(N'2020-06-20' AS Date), N'ádasdasđ213qưeqưeqưe', N'T003', NULL, N'BN07062019000', 4)
INSERT [dbo].[BHYT] ([IDbhyt], [Ngaycap], [Ngayhethan], [Csbd], [IDtuyen], [DTUT], [IDbn], [IDdt]) VALUES (N'dfdsf', CAST(N'2019-05-29' AS Date), CAST(N'2019-05-29' AS Date), N'dfdsf', N'T003', 4, N'BN12052019003', 2)
INSERT [dbo].[BHYT] ([IDbhyt], [Ngaycap], [Ngayhethan], [Csbd], [IDtuyen], [DTUT], [IDbn], [IDdt]) VALUES (N'earwerwer', CAST(N'2019-06-12' AS Date), CAST(N'2019-06-29' AS Date), N'earwerwer', N'T002', NULL, N'BN05102019001', 3)
INSERT [dbo].[BHYT] ([IDbhyt], [Ngaycap], [Ngayhethan], [Csbd], [IDtuyen], [DTUT], [IDbn], [IDdt]) VALUES (N'eqeqeqeqe', CAST(N'2015-01-21' AS Date), CAST(N'2016-01-01' AS Date), N'eqeqeqeqe', N'T003', 5, N'BN05102019001', 1)
INSERT [dbo].[BHYT] ([IDbhyt], [Ngaycap], [Ngayhethan], [Csbd], [IDtuyen], [DTUT], [IDbn], [IDdt]) VALUES (N'h50023', CAST(N'2019-01-03' AS Date), CAST(N'2020-08-01' AS Date), N'h5002322323', N'T002', NULL, N'BN07062019000', 4)
INSERT [dbo].[BHYT] ([IDbhyt], [Ngaycap], [Ngayhethan], [Csbd], [IDtuyen], [DTUT], [IDbn], [IDdt]) VALUES (N'hihihihihi huhuhuhu', CAST(N'2019-04-16' AS Date), CAST(N'2019-06-27' AS Date), N'hihihihihi huhuhuhu', N'T003', NULL, N'BN05102019001', 4)
INSERT [dbo].[BHYT] ([IDbhyt], [Ngaycap], [Ngayhethan], [Csbd], [IDtuyen], [DTUT], [IDbn], [IDdt]) VALUES (N'mnbasmnbasnmd', CAST(N'2019-06-12' AS Date), CAST(N'2020-06-12' AS Date), N'mnb', N'T003', NULL, N'BN05102019001', 3)
INSERT [dbo].[BHYT] ([IDbhyt], [Ngaycap], [Ngayhethan], [Csbd], [IDtuyen], [DTUT], [IDbn], [IDdt]) VALUES (N'queqwe', CAST(N'2015-01-01' AS Date), CAST(N'2016-01-01' AS Date), N'ádasdsadasd', N'T003', 5, N'BN12052019001', 1)
INSERT [dbo].[BHYT] ([IDbhyt], [Ngaycap], [Ngayhethan], [Csbd], [IDtuyen], [DTUT], [IDbn], [IDdt]) VALUES (N'sadasdasd', CAST(N'2019-06-01' AS Date), CAST(N'2020-06-20' AS Date), N'sadasdasd', N'T003', NULL, N'BN07062019000', 4)
INSERT [dbo].[BHYT] ([IDbhyt], [Ngaycap], [Ngayhethan], [Csbd], [IDtuyen], [DTUT], [IDbn], [IDdt]) VALUES (N'sdasd', CAST(N'2019-06-20' AS Date), CAST(N'2020-06-20' AS Date), N'sdasd', N'T003', NULL, N'BN05102019001', 4)
INSERT [dbo].[BHYT] ([IDbhyt], [Ngaycap], [Ngayhethan], [Csbd], [IDtuyen], [DTUT], [IDbn], [IDdt]) VALUES (N'Sdsasdf', CAST(N'2019-05-29' AS Date), CAST(N'2019-05-29' AS Date), N'Sdsasdf', N'T003', 6, N'BN25052019000', 1)
INSERT [dbo].[BHYT] ([IDbhyt], [Ngaycap], [Ngayhethan], [Csbd], [IDtuyen], [DTUT], [IDbn], [IDdt]) VALUES (N'SV12345678', CAST(N'2019-01-01' AS Date), CAST(N'2019-12-31' AS Date), N'SV12345678', N'T003', NULL, N'BN13062019000', 4)
INSERT [dbo].[BHYT] ([IDbhyt], [Ngaycap], [Ngayhethan], [Csbd], [IDtuyen], [DTUT], [IDbn], [IDdt]) VALUES (N'SV133216356', CAST(N'2019-01-01' AS Date), CAST(N'2019-12-31' AS Date), N'Bệnh viện đa khoa Hoa Sữa', N'T003', NULL, N'BN31052019000', 1)
INSERT [dbo].[BHYT] ([IDbhyt], [Ngaycap], [Ngayhethan], [Csbd], [IDtuyen], [DTUT], [IDbn], [IDdt]) VALUES (N'uqe', CAST(N'2015-01-01' AS Date), CAST(N'2016-01-01' AS Date), N'ưqe', N'T003', NULL, N'BN05102019001', 2)
INSERT [dbo].[CHITIETDONTHUOC] ([IDdonthuoc], [IDthuoc], [DVM], [Soluong], [Lieudung]) VALUES (N'DT07062019001', N'TH0001', N'Hộp', 22, N'sdsfsđfdfdf')
INSERT [dbo].[CHITIETDONTHUOC] ([IDdonthuoc], [IDthuoc], [DVM], [Soluong], [Lieudung]) VALUES (N'DT07062019001', N'TH0002', N'Lọ', 1, N'56')
INSERT [dbo].[CHITIETDONTHUOC] ([IDdonthuoc], [IDthuoc], [DVM], [Soluong], [Lieudung]) VALUES (N'DT13062019001', N'TH0001', N'Lọ', 50, N'ngày 2 viên ')
INSERT [dbo].[CHITIETDONTHUOC] ([IDdonthuoc], [IDthuoc], [DVM], [Soluong], [Lieudung]) VALUES (N'DT13062019003', N'TH0001', N'Viên', 35, N'ấdasd')
INSERT [dbo].[CHITIETDONTHUOC] ([IDdonthuoc], [IDthuoc], [DVM], [Soluong], [Lieudung]) VALUES (N'DT13062019003', N'TH0002', N'Viên', 23, N'ádasd')
INSERT [dbo].[CHITIETDONTHUOC] ([IDdonthuoc], [IDthuoc], [DVM], [Soluong], [Lieudung]) VALUES (N'DT13062019003', N'TH0003', N'Lọ', 17, N'ádasdasd')
INSERT [dbo].[CHITIETDONTHUOC] ([IDdonthuoc], [IDthuoc], [DVM], [Soluong], [Lieudung]) VALUES (N'DT13062019013', N'TH0001', N'Bìa', 23, N'2 ngày 1 lần sau ăn ')
INSERT [dbo].[CHITIETDONTHUOC] ([IDdonthuoc], [IDthuoc], [DVM], [Soluong], [Lieudung]) VALUES (N'DT13062019013', N'TH0002', N'Chai', 43, N'uống đều sau bữa ăn')
INSERT [dbo].[CHITIETDONTHUOC] ([IDdonthuoc], [IDthuoc], [DVM], [Soluong], [Lieudung]) VALUES (N'DT14062019001', N'TH0001', N'Hộp', 58, N'1')
INSERT [dbo].[CHITIETDONTHUOC] ([IDdonthuoc], [IDthuoc], [DVM], [Soluong], [Lieudung]) VALUES (N'DT14062019004', N'TH0001', N'Bìa', 18, N'1 ngày 1 lần')
INSERT [dbo].[CHITIETDONTHUOC] ([IDdonthuoc], [IDthuoc], [DVM], [Soluong], [Lieudung]) VALUES (N'DT14062019004', N'TH0002', N'Bìa', 12, N'1 ngày 1 lần ')
INSERT [dbo].[CHITIETDONTHUOC] ([IDdonthuoc], [IDthuoc], [DVM], [Soluong], [Lieudung]) VALUES (N'DT14062019004', N'TH0003', N'Bìa', 1, N'1 ngày 1 lần ')
INSERT [dbo].[CHITIETDONTHUOC] ([IDdonthuoc], [IDthuoc], [DVM], [Soluong], [Lieudung]) VALUES (N'DT20062019001', N'TH0001', N'Hộp', 81, N'1')
INSERT [dbo].[CHITIETDONTHUOC] ([IDdonthuoc], [IDthuoc], [DVM], [Soluong], [Lieudung]) VALUES (N'DT20062019001', N'TH0002', N'Hộp', 27, N'1')
INSERT [dbo].[CHITIETDONTHUOC] ([IDdonthuoc], [IDthuoc], [DVM], [Soluong], [Lieudung]) VALUES (N'DT20062019003', N'TH0001', N'Chai', 25, N'fsdf')
INSERT [dbo].[CHITIETDONTHUOC] ([IDdonthuoc], [IDthuoc], [DVM], [Soluong], [Lieudung]) VALUES (N'DT20062019003', N'TH0002', N'Lọ', 26, N'dfsdf')
INSERT [dbo].[CHITIETDONTHUOC] ([IDdonthuoc], [IDthuoc], [DVM], [Soluong], [Lieudung]) VALUES (N'DT20062019004', N'TH0001', N'Chai', 1, N'ádsa')
INSERT [dbo].[CHITIETDONTHUOC] ([IDdonthuoc], [IDthuoc], [DVM], [Soluong], [Lieudung]) VALUES (N'DT20062019005', N'TH0001', N'Chai', 1, N'ngày 1 lọ')
INSERT [dbo].[CHITIETDONTHUOC] ([IDdonthuoc], [IDthuoc], [DVM], [Soluong], [Lieudung]) VALUES (N'DT20062019005', N'TH0002', N'Chai', 11, N'ngày 1 lọ')
INSERT [dbo].[CHITIETDONTHUOC] ([IDdonthuoc], [IDthuoc], [DVM], [Soluong], [Lieudung]) VALUES (N'DT20062019005', N'TH0003', N'Chai', 1, N'ngày 1 lọ')
INSERT [dbo].[CHITIETDONTHUOC] ([IDdonthuoc], [IDthuoc], [DVM], [Soluong], [Lieudung]) VALUES (N'DT20062019006', N'TH0001', N'Vỉ', 1, N'Ngày 2 viên sau ăn ')
INSERT [dbo].[CHITIETDONTHUOC] ([IDdonthuoc], [IDthuoc], [DVM], [Soluong], [Lieudung]) VALUES (N'DT20062019006', N'TH0002', N'Viên', 3, N'Ngày 2 viên trước ăn ')
INSERT [dbo].[CHITIETDONTHUOC] ([IDdonthuoc], [IDthuoc], [DVM], [Soluong], [Lieudung]) VALUES (N'DT20062019006', N'TH0003', N'Viên', 3, N'Ngày 2 viên lúc sáng')
INSERT [dbo].[CHITIETDONTHUOC] ([IDdonthuoc], [IDthuoc], [DVM], [Soluong], [Lieudung]) VALUES (N'DT21062019001', N'TH0001', N'Viên', 22, N'ngày 1 viên sau ăn ')
INSERT [dbo].[CHITIETDONTHUOC] ([IDdonthuoc], [IDthuoc], [DVM], [Soluong], [Lieudung]) VALUES (N'DT21062019001', N'TH0003', N'Viên', 23, N'ngày 1 viên sau ăn')
INSERT [dbo].[CHITIETDONTHUOC] ([IDdonthuoc], [IDthuoc], [DVM], [Soluong], [Lieudung]) VALUES (N'DT21062019001', N'TH0004', N'Viên', 22, N'ngày 2 viên trước ăn ')
INSERT [dbo].[CHITIETDONTHUOC] ([IDdonthuoc], [IDthuoc], [DVM], [Soluong], [Lieudung]) VALUES (N'DT21062019001', N'TH0006', N'Viên', 31, N'ngày 3 viên sau ăn ')
INSERT [dbo].[CHITIETDONTHUOC] ([IDdonthuoc], [IDthuoc], [DVM], [Soluong], [Lieudung]) VALUES (N'DT21062019001', N'TH0008', N'Viên', 22, N'ngày 1 viên sau ăn ')
INSERT [dbo].[CHITIETDONTHUOC] ([IDdonthuoc], [IDthuoc], [DVM], [Soluong], [Lieudung]) VALUES (N'DT30052019001', N'TH0003', N'Viên', 22, N'uống ít ít ')
INSERT [dbo].[CHUCVU] ([IDchucvu], [tenchucvu]) VALUES (N'CV001', N'Giám đốc bệnh viện ')
INSERT [dbo].[CHUCVU] ([IDchucvu], [tenchucvu]) VALUES (N'CV002', N'Bác sỹ khám bệnh')
INSERT [dbo].[CHUCVU] ([IDchucvu], [tenchucvu]) VALUES (N'CV003', N'Nhân viên lễ tân')
INSERT [dbo].[CHUCVU] ([IDchucvu], [tenchucvu]) VALUES (N'CV004', N'Nhân viên tiếp nhận bệnh nhân')
INSERT [dbo].[CHUCVU] ([IDchucvu], [tenchucvu]) VALUES (N'CV005', N'Bác sỹ xét nghiệm')
INSERT [dbo].[CHUCVU] ([IDchucvu], [tenchucvu]) VALUES (N'CV006', N'Nhân viên thu ngân')
INSERT [dbo].[DICHVU] ([IDdichvu], [TenDV], [Maymoc], [Giatien]) VALUES (N'DV0001', N'Siêu âm ổ bụng', NULL, 30000)
INSERT [dbo].[DICHVU] ([IDdichvu], [TenDV], [Maymoc], [Giatien]) VALUES (N'DV0002', N'Xét nghiệm máu', N'abc', 100000)
INSERT [dbo].[DICHVU] ([IDdichvu], [TenDV], [Maymoc], [Giatien]) VALUES (N'DV0003', N'Chụp X-quang hộp sọ', N'abc', 100000)
INSERT [dbo].[DICHVU] ([IDdichvu], [TenDV], [Maymoc], [Giatien]) VALUES (N'DV0004', N'Chụp X-quang lồng ngực', NULL, 100000)
INSERT [dbo].[DONTHUOC] ([IDdonthuoc], [Ngaylap], [IDba], [IDnv], [Thanhtien]) VALUES (N'DT07062019001', CAST(N'2019-06-07' AS Date), N'BA07062019001', N'NV012', NULL)
INSERT [dbo].[DONTHUOC] ([IDdonthuoc], [Ngaylap], [IDba], [IDnv], [Thanhtien]) VALUES (N'DT13062019001', CAST(N'2019-06-13' AS Date), N'BA13062019002', N'NV001', NULL)
INSERT [dbo].[DONTHUOC] ([IDdonthuoc], [Ngaylap], [IDba], [IDnv], [Thanhtien]) VALUES (N'DT13062019003', CAST(N'2019-06-13' AS Date), N'BA13062019012', N'NV001', NULL)
INSERT [dbo].[DONTHUOC] ([IDdonthuoc], [Ngaylap], [IDba], [IDnv], [Thanhtien]) VALUES (N'DT13062019013', CAST(N'2019-06-13' AS Date), N'BA13062019013', N'NV001', NULL)
INSERT [dbo].[DONTHUOC] ([IDdonthuoc], [Ngaylap], [IDba], [IDnv], [Thanhtien]) VALUES (N'DT13062019014', CAST(N'2019-06-13' AS Date), N'BA13062019025', N'NV014', NULL)
INSERT [dbo].[DONTHUOC] ([IDdonthuoc], [Ngaylap], [IDba], [IDnv], [Thanhtien]) VALUES (N'DT14062019001', CAST(N'2019-06-14' AS Date), N'BA14062019003', N'NV001', NULL)
INSERT [dbo].[DONTHUOC] ([IDdonthuoc], [Ngaylap], [IDba], [IDnv], [Thanhtien]) VALUES (N'DT14062019004', CAST(N'2019-06-14' AS Date), N'BA14062019006', N'NV001', NULL)
INSERT [dbo].[DONTHUOC] ([IDdonthuoc], [Ngaylap], [IDba], [IDnv], [Thanhtien]) VALUES (N'DT20062019001', CAST(N'2019-06-20' AS Date), N'BA20062019001', N'NV001', NULL)
INSERT [dbo].[DONTHUOC] ([IDdonthuoc], [Ngaylap], [IDba], [IDnv], [Thanhtien]) VALUES (N'DT20062019002', CAST(N'2019-06-20' AS Date), N'BA20062019001', N'NV001', NULL)
INSERT [dbo].[DONTHUOC] ([IDdonthuoc], [Ngaylap], [IDba], [IDnv], [Thanhtien]) VALUES (N'DT20062019003', CAST(N'2019-06-20' AS Date), N'BA20062019004', N'NV001', NULL)
INSERT [dbo].[DONTHUOC] ([IDdonthuoc], [Ngaylap], [IDba], [IDnv], [Thanhtien]) VALUES (N'DT20062019004', CAST(N'2019-06-20' AS Date), N'BA20062019005', N'NV001', NULL)
INSERT [dbo].[DONTHUOC] ([IDdonthuoc], [Ngaylap], [IDba], [IDnv], [Thanhtien]) VALUES (N'DT20062019005', CAST(N'2019-06-20' AS Date), N'BA20062019006', N'NV001', NULL)
INSERT [dbo].[DONTHUOC] ([IDdonthuoc], [Ngaylap], [IDba], [IDnv], [Thanhtien]) VALUES (N'DT20062019006', CAST(N'2019-06-20' AS Date), N'BA20062019009', N'NV001', NULL)
INSERT [dbo].[DONTHUOC] ([IDdonthuoc], [Ngaylap], [IDba], [IDnv], [Thanhtien]) VALUES (N'DT20062019007', CAST(N'2019-06-20' AS Date), N'BA20062019013', NULL, NULL)
INSERT [dbo].[DONTHUOC] ([IDdonthuoc], [Ngaylap], [IDba], [IDnv], [Thanhtien]) VALUES (N'DT21062019001', CAST(N'2019-06-21' AS Date), N'BA21062019001', N'NV001', NULL)
INSERT [dbo].[DONTHUOC] ([IDdonthuoc], [Ngaylap], [IDba], [IDnv], [Thanhtien]) VALUES (N'DT30052019001', CAST(N'2019-05-30' AS Date), N'BA29052019010', N'NV001', NULL)
INSERT [dbo].[DTUT] ([IDdt], [TenDT], [phantramhuong]) VALUES (1, N'Mẹ VN anh hùng', 100)
INSERT [dbo].[DTUT] ([IDdt], [TenDT], [phantramhuong]) VALUES (2, N'Hộ nghèo ', 100)
INSERT [dbo].[DTUT] ([IDdt], [TenDT], [phantramhuong]) VALUES (3, N'Cựu chiến binh ', 100)
INSERT [dbo].[DTUT] ([IDdt], [TenDT], [phantramhuong]) VALUES (4, N'Nhân dân ', 80)
INSERT [dbo].[GIAYCHUYENVIEN] ([IDgcv], [IDbhyt], [Ngaycap], [Chuandoan], [lydochuyen], [Noicap], [Nguoicap]) VALUES (N'123', N'112233', CAST(N'2012-01-01' AS Date), N'Viêm gan B', N'qưeqwe', N'Hà nội', N'abc')
INSERT [dbo].[GIAYCHUYENVIEN] ([IDgcv], [IDbhyt], [Ngaycap], [Chuandoan], [lydochuyen], [Noicap], [Nguoicap]) VALUES (N'213213', N'112233', CAST(N'2012-01-01' AS Date), N'Viêm gan B', N'không đủ ddieefu kiện ', N'Hà nội', N'abc')
INSERT [dbo].[GIAYCHUYENVIEN] ([IDgcv], [IDbhyt], [Ngaycap], [Chuandoan], [lydochuyen], [Noicap], [Nguoicap]) VALUES (N'213213124', N'112233', CAST(N'2012-01-01' AS Date), N'Viêm gan B', N'abc', N'Hà nội', N'ád')
INSERT [dbo].[GIAYCHUYENVIEN] ([IDgcv], [IDbhyt], [Ngaycap], [Chuandoan], [lydochuyen], [Noicap], [Nguoicap]) VALUES (N'ádasd', N'sdasd', CAST(N'2019-06-20' AS Date), N'ádas', N'zxczxc', N'sada', N'sadasd')
INSERT [dbo].[GIAYCHUYENVIEN] ([IDgcv], [IDbhyt], [Ngaycap], [Chuandoan], [lydochuyen], [Noicap], [Nguoicap]) VALUES (N'bbbbbbbbbbbbbbbb', N'112233', CAST(N'2012-01-01' AS Date), N'Viêm gan B', N'không đủ điều kiện chữa trị', N'Hà nội', N'ádasd')
INSERT [dbo].[GIAYCHUYENVIEN] ([IDgcv], [IDbhyt], [Ngaycap], [Chuandoan], [lydochuyen], [Noicap], [Nguoicap]) VALUES (N'ffhghfgh', N'112233', CAST(N'2012-01-28' AS Date), N'Viêm gan B', N'Không đủ điều kiện chữa trị', N'Hà Nội', N'Nguyễn Thị Mai')
INSERT [dbo].[KHOA] ([IDkhoa], [Tenkhoa], [IDtruongkhoa], [Ngaythanhlap]) VALUES (N'BP001', N'Khoa khám bệnh ', N'NV003', CAST(N'2019-06-06' AS Date))
INSERT [dbo].[KHOA] ([IDkhoa], [Tenkhoa], [IDtruongkhoa], [Ngaythanhlap]) VALUES (N'BP002', N'Khoa Xét Nghiệm', N'NV004', CAST(N'2019-06-12' AS Date))
INSERT [dbo].[KHOA] ([IDkhoa], [Tenkhoa], [IDtruongkhoa], [Ngaythanhlap]) VALUES (N'BP003', N'Khoa cấp cứu ', N'NV005', CAST(N'2019-06-03' AS Date))
INSERT [dbo].[KHOA] ([IDkhoa], [Tenkhoa], [IDtruongkhoa], [Ngaythanhlap]) VALUES (N'BP004', N'Khoa da liễu', N'NV006', CAST(N'2014-01-01' AS Date))
INSERT [dbo].[KHOA] ([IDkhoa], [Tenkhoa], [IDtruongkhoa], [Ngaythanhlap]) VALUES (N'BP005', N'Khoa mắt ', N'NV001', CAST(N'2019-01-01' AS Date))
INSERT [dbo].[KHOA] ([IDkhoa], [Tenkhoa], [IDtruongkhoa], [Ngaythanhlap]) VALUES (N'BP006', N'Khoa tim mạch', NULL, CAST(N'2019-06-01' AS Date))
INSERT [dbo].[KHOA] ([IDkhoa], [Tenkhoa], [IDtruongkhoa], [Ngaythanhlap]) VALUES (N'BP007', N'Khoa sản', N'NV007', CAST(N'2019-06-03' AS Date))
INSERT [dbo].[KHOA] ([IDkhoa], [Tenkhoa], [IDtruongkhoa], [Ngaythanhlap]) VALUES (N'KH008', N'Khoa hồi sức', NULL, CAST(N'2019-06-13' AS Date))
INSERT [dbo].[LOAIHINHDIEUTRI] ([IDloaihinh], [tenloaihinh]) VALUES (N'1', N'Điều trị nội trú')
INSERT [dbo].[LOAIHINHDIEUTRI] ([IDloaihinh], [tenloaihinh]) VALUES (N'2', N'Điều trị ngoại trú')
INSERT [dbo].[LOAIPHIEUXETNGHIEM] ([IDloai], [Tenloai]) VALUES (N'LH001', N'Phiếu siêu âm ổ bụng ')
INSERT [dbo].[LOAIPHIEUXETNGHIEM] ([IDloai], [Tenloai]) VALUES (N'LH002', N'Phiếu chụp X-quang')
INSERT [dbo].[NHANVIEN] ([IDnv], [Hodem], [Ten], [Gioitinh], [Sđt], [Xaphuong], [Quanhuyen], [Tinhthanhpho], [IDchucvu], [Trinhdo], [IDtk], [IDkhoa]) VALUES (N'NV001', N'Vũ Văn', N'Trung', 1, N'4545664545', N'Minh Tân', N'Kinh Môn', N'Hải Dương', N'CV003', N'Tiến Sỹ', NULL, N'BP005')
INSERT [dbo].[NHANVIEN] ([IDnv], [Hodem], [Ten], [Gioitinh], [Sđt], [Xaphuong], [Quanhuyen], [Tinhthanhpho], [IDchucvu], [Trinhdo], [IDtk], [IDkhoa]) VALUES (N'NV002', N'Vũ Minh', N'Hiếu', 1, N'3213213', N'Minh Tân', N'Kinh Môn', N'Hải Dương', N'CV001', N'Cao học ', NULL, N'BP005')
INSERT [dbo].[NHANVIEN] ([IDnv], [Hodem], [Ten], [Gioitinh], [Sđt], [Xaphuong], [Quanhuyen], [Tinhthanhpho], [IDchucvu], [Trinhdo], [IDtk], [IDkhoa]) VALUES (N'NV003', N'Vũ Hoàng', N'Lâm', 1, N'312313', N'Minh Tân', N'Kinh Môn', N'Hải Dương', N'CV001', N'Đại học ', NULL, N'BP001')
INSERT [dbo].[NHANVIEN] ([IDnv], [Hodem], [Ten], [Gioitinh], [Sđt], [Xaphuong], [Quanhuyen], [Tinhthanhpho], [IDchucvu], [Trinhdo], [IDtk], [IDkhoa]) VALUES (N'NV004', N'Nguyễn Thị', N'Liên', 0, N'123123123', N'Minh Tân', N'Kinh Môn', N'Hải Dương', N'CV001', N'Cử nhân', NULL, N'BP002')
INSERT [dbo].[NHANVIEN] ([IDnv], [Hodem], [Ten], [Gioitinh], [Sđt], [Xaphuong], [Quanhuyen], [Tinhthanhpho], [IDchucvu], [Trinhdo], [IDtk], [IDkhoa]) VALUES (N'NV005', N'Nguyễn Minh', N'Tâm', 0, N'13131', N'Chùa Láng', N'Đống Đa', N'Hà Nội', N'CV001', N'Thạc sỹ', NULL, N'BP003')
INSERT [dbo].[NHANVIEN] ([IDnv], [Hodem], [Ten], [Gioitinh], [Sđt], [Xaphuong], [Quanhuyen], [Tinhthanhpho], [IDchucvu], [Trinhdo], [IDtk], [IDkhoa]) VALUES (N'NV006', N'Nguyễn Văn', N'Ba', 1, N'13231', N'Láng Hạ', N'Đống Đa', N'Hà Nội', N'CV001', N'Giáo sư', NULL, N'BP004')
INSERT [dbo].[NHANVIEN] ([IDnv], [Hodem], [Ten], [Gioitinh], [Sđt], [Xaphuong], [Quanhuyen], [Tinhthanhpho], [IDchucvu], [Trinhdo], [IDtk], [IDkhoa]) VALUES (N'NV007', N'Nguyễn Văn', N'Hòa', 1, N'123', N'Minh Hòa', N'Minh Khai', N'Hà Nội', N'CV001', N'Đại học ', NULL, N'BP007')
INSERT [dbo].[NHANVIEN] ([IDnv], [Hodem], [Ten], [Gioitinh], [Sđt], [Xaphuong], [Quanhuyen], [Tinhthanhpho], [IDchucvu], [Trinhdo], [IDtk], [IDkhoa]) VALUES (N'NV008', N'Vũ Thị', N'Hoa', 0, N'213123', N'Minh Hòa', N'Hải Hậu', N'Hải Dương', N'CV001', N'Đại học ', NULL, N'BP002')
INSERT [dbo].[NHANVIEN] ([IDnv], [Hodem], [Ten], [Gioitinh], [Sđt], [Xaphuong], [Quanhuyen], [Tinhthanhpho], [IDchucvu], [Trinhdo], [IDtk], [IDkhoa]) VALUES (N'NV009', N'Nguyễn Văn', N'Hải', 1, N'1233', N'Minh Khai', N'Văn Giang', N'Điện Biên', N'CV001', N'Thạc sỹ', NULL, N'BP005')
INSERT [dbo].[NHANVIEN] ([IDnv], [Hodem], [Ten], [Gioitinh], [Sđt], [Xaphuong], [Quanhuyen], [Tinhthanhpho], [IDchucvu], [Trinhdo], [IDtk], [IDkhoa]) VALUES (N'NV010', N'Vũ Minh', N'Hiếu', 0, N'132123', N'Minh Hòa', N'Minh Tân', N'Hải Dương', N'CV001', N'Cao học ', NULL, N'BP005')
INSERT [dbo].[NHANVIEN] ([IDnv], [Hodem], [Ten], [Gioitinh], [Sđt], [Xaphuong], [Quanhuyen], [Tinhthanhpho], [IDchucvu], [Trinhdo], [IDtk], [IDkhoa]) VALUES (N'NV011', N'Vũ Minh', N'Tú', 1, N'112', N'Mai Sơn', N'Hòa Mai', N'Điện Biên', N'CV001', N'Cao học ', NULL, N'BP003')
INSERT [dbo].[NHANVIEN] ([IDnv], [Hodem], [Ten], [Gioitinh], [Sđt], [Xaphuong], [Quanhuyen], [Tinhthanhpho], [IDchucvu], [Trinhdo], [IDtk], [IDkhoa]) VALUES (N'NV012', N'Phan Huy', N'Toàn', 1, N'131322311', N'Đinh La', N'Hải Mai', N'Nam Định', N'CV005', N'Cao đẳng ', NULL, N'BP005')
INSERT [dbo].[NHANVIEN] ([IDnv], [Hodem], [Ten], [Gioitinh], [Sđt], [Xaphuong], [Quanhuyen], [Tinhthanhpho], [IDchucvu], [Trinhdo], [IDtk], [IDkhoa]) VALUES (N'NV013', N'Lý Văn', N'Hòa', 1, N'1', N'Hữu Hòa', N'Đinh Mai', N'Nam Định', N'CV005', N'Giáo sư ', NULL, N'BP002')
INSERT [dbo].[NHANVIEN] ([IDnv], [Hodem], [Ten], [Gioitinh], [Sđt], [Xaphuong], [Quanhuyen], [Tinhthanhpho], [IDchucvu], [Trinhdo], [IDtk], [IDkhoa]) VALUES (N'NV014', N'Vũ Thị', N'Hoài', 0, N'123123', N'Mai Linh', N'Mê Linh', N'Hà Nội', N'CV002', N'Giáo sư ', NULL, N'BP001')
INSERT [dbo].[NHANVIEN] ([IDnv], [Hodem], [Ten], [Gioitinh], [Sđt], [Xaphuong], [Quanhuyen], [Tinhthanhpho], [IDchucvu], [Trinhdo], [IDtk], [IDkhoa]) VALUES (N'NV015', N'Nguyễn Minh', N'Long', 1, N'0132312361', N'Binh Minh', N'Đống Đa', N'Hà Nội', N'CV002', N'Giáo sư ', NULL, N'BP001')
INSERT [dbo].[NHANVIEN] ([IDnv], [Hodem], [Ten], [Gioitinh], [Sđt], [Xaphuong], [Quanhuyen], [Tinhthanhpho], [IDchucvu], [Trinhdo], [IDtk], [IDkhoa]) VALUES (N'NV016', N'Vũ Hoài', N'Nam', 1, N'012837123', N'Hải Sơn', N'Sinh Bình', N'Nam Định', N'CV002', N'Giáo sư ', NULL, N'BP001')
INSERT [dbo].[NHANVIEN] ([IDnv], [Hodem], [Ten], [Gioitinh], [Sđt], [Xaphuong], [Quanhuyen], [Tinhthanhpho], [IDchucvu], [Trinhdo], [IDtk], [IDkhoa]) VALUES (N'NV017', N'Ninh Duy', N'Tuấn', 1, N'023823743', N'Ha Son', N'Đống Đa', N'Hà Nội', N'CV002', N'Giáo sư ', NULL, N'BP001')
INSERT [dbo].[NHANVIEN] ([IDnv], [Hodem], [Ten], [Gioitinh], [Sđt], [Xaphuong], [Quanhuyen], [Tinhthanhpho], [IDchucvu], [Trinhdo], [IDtk], [IDkhoa]) VALUES (N'NV018', N'Phạm Gia', N'Hưng', 1, N'012382372', N'Hà Đông ', N'Hà Đông ', N'Hà Nội', N'CV005', N'Thạc sỹ', NULL, N'BP002')
INSERT [dbo].[NHANVIEN] ([IDnv], [Hodem], [Ten], [Gioitinh], [Sđt], [Xaphuong], [Quanhuyen], [Tinhthanhpho], [IDchucvu], [Trinhdo], [IDtk], [IDkhoa]) VALUES (N'NV019', N'Nguyễn Minh', N'Phòng', 1, N'0123128371', N'Minh Hòa', N'Sơn Minh', N'Nam Định', N'CV005', N'Tiến sỹ ', NULL, N'BP002')
INSERT [dbo].[NHANVIEN] ([IDnv], [Hodem], [Ten], [Gioitinh], [Sđt], [Xaphuong], [Quanhuyen], [Tinhthanhpho], [IDchucvu], [Trinhdo], [IDtk], [IDkhoa]) VALUES (N'NV020', N'Nguyễn Trường', N'Sơn', 1, N'012371236', N'Ba Ninh', N'Thanh Miện', N'Hải Dương', N'CV005', N'Tiến sỹ ', NULL, N'BP002')
INSERT [dbo].[NHANVIENLAMVIEC] ([IDnvlv], [IDnv], [IDpb], [Thoigianbatdau], [Thoigianketthuc]) VALUES (N'NVLV13062019001', N'NV001', N'PB022', CAST(N'2019-01-01' AS Date), CAST(N'2019-12-31' AS Date))
INSERT [dbo].[NHANVIENLAMVIEC] ([IDnvlv], [IDnv], [IDpb], [Thoigianbatdau], [Thoigianketthuc]) VALUES (N'NVLV13062019002', N'NV003', N'PB029', CAST(N'2019-01-01' AS Date), CAST(N'2019-12-31' AS Date))
INSERT [dbo].[NHANVIENLAMVIEC] ([IDnvlv], [IDnv], [IDpb], [Thoigianbatdau], [Thoigianketthuc]) VALUES (N'NVLV13062019003', N'NV011', N'PB032', CAST(N'2019-01-01' AS Date), CAST(N'2019-12-31' AS Date))
INSERT [dbo].[NHANVIENLAMVIEC] ([IDnvlv], [IDnv], [IDpb], [Thoigianbatdau], [Thoigianketthuc]) VALUES (N'NVLV13062019004', N'NV007', N'PB035', CAST(N'2019-01-01' AS Date), CAST(N'2019-12-31' AS Date))
INSERT [dbo].[NHANVIENLAMVIEC] ([IDnvlv], [IDnv], [IDpb], [Thoigianbatdau], [Thoigianketthuc]) VALUES (N'NVLV13062019005', N'NV014', N'PB023', CAST(N'2019-01-01' AS Date), CAST(N'2019-12-31' AS Date))
INSERT [dbo].[NHANVIENLAMVIEC] ([IDnvlv], [IDnv], [IDpb], [Thoigianbatdau], [Thoigianketthuc]) VALUES (N'NVLV13062019006', N'NV013', N'PB037', CAST(N'2019-01-01' AS Date), CAST(N'2019-12-31' AS Date))
INSERT [dbo].[NHANVIENLAMVIEC] ([IDnvlv], [IDnv], [IDpb], [Thoigianbatdau], [Thoigianketthuc]) VALUES (N'NVLV13062019007', N'NV015', N'PB023', CAST(N'2019-01-01' AS Date), CAST(N'2019-12-31' AS Date))
INSERT [dbo].[NHANVIENLAMVIEC] ([IDnvlv], [IDnv], [IDpb], [Thoigianbatdau], [Thoigianketthuc]) VALUES (N'NVLV13062019008', N'NV016', N'PB024', CAST(N'2019-01-01' AS Date), CAST(N'2019-12-31' AS Date))
INSERT [dbo].[NHANVIENLAMVIEC] ([IDnvlv], [IDnv], [IDpb], [Thoigianbatdau], [Thoigianketthuc]) VALUES (N'NVLV13062019009', N'NV017', N'PB025', CAST(N'2019-01-01' AS Date), CAST(N'2019-12-31' AS Date))
INSERT [dbo].[NHANVIENLAMVIEC] ([IDnvlv], [IDnv], [IDpb], [Thoigianbatdau], [Thoigianketthuc]) VALUES (N'NVLV13062019010', N'NV018', N'PB039', CAST(N'2019-01-01' AS Date), CAST(N'2019-12-31' AS Date))
INSERT [dbo].[NHANVIENLAMVIEC] ([IDnvlv], [IDnv], [IDpb], [Thoigianbatdau], [Thoigianketthuc]) VALUES (N'NVLV13062019011', N'NV019', N'PB040', CAST(N'2019-01-01' AS Date), CAST(N'2019-12-31' AS Date))
INSERT [dbo].[NHANVIENLAMVIEC] ([IDnvlv], [IDnv], [IDpb], [Thoigianbatdau], [Thoigianketthuc]) VALUES (N'NVLV13062019012', N'NV020', N'PB037', CAST(N'2019-01-01' AS Date), CAST(N'2019-12-31' AS Date))
INSERT [dbo].[PHANQUYEN] ([IDquyen], [Tenquyen]) VALUES (N'PQ001', N'Nhân Sự quản lý')
INSERT [dbo].[PHANQUYEN] ([IDquyen], [Tenquyen]) VALUES (N'PQ002', N'Nhân viên quầy thuốc')
INSERT [dbo].[PHANQUYEN] ([IDquyen], [Tenquyen]) VALUES (N'PQ003', N'Nhân viên quầy tiếp nhận bệnh nhân')
INSERT [dbo].[PHANQUYEN] ([IDquyen], [Tenquyen]) VALUES (N'PQ004', N'Nhân viên khám bệnh')
INSERT [dbo].[PHANQUYEN] ([IDquyen], [Tenquyen]) VALUES (N'PQ005', N'Nhân viên thu ngân')
INSERT [dbo].[PHANQUYEN] ([IDquyen], [Tenquyen]) VALUES (N'PQ006', N'Nhân viên xét nghiệm')
INSERT [dbo].[PHIEUHENKHAMLAI] ([IDphieuhen], [ngaylap], [ngayhen], [IDnv], [IDba]) VALUES (N'PH13062019001', CAST(N'2019-06-13' AS Date), CAST(N'2019-09-25' AS Date), N'NV001', N'BA13062019004')
INSERT [dbo].[PHIEUHENKHAMLAI] ([IDphieuhen], [ngaylap], [ngayhen], [IDnv], [IDba]) VALUES (N'PH13062019002', CAST(N'2019-06-13' AS Date), CAST(N'2019-06-07' AS Date), N'NV001', N'BA13062019017')
INSERT [dbo].[PHIEUHENKHAMLAI] ([IDphieuhen], [ngaylap], [ngayhen], [IDnv], [IDba]) VALUES (N'PH13062019003', CAST(N'2019-06-13' AS Date), CAST(N'2020-01-09' AS Date), N'NV001', N'BA13062019018')
INSERT [dbo].[PHIEUHENKHAMLAI] ([IDphieuhen], [ngaylap], [ngayhen], [IDnv], [IDba]) VALUES (N'PH13062019004', CAST(N'2019-06-13' AS Date), CAST(N'2019-08-09' AS Date), N'NV001', N'BA13062019019')
INSERT [dbo].[PHIEUHENKHAMLAI] ([IDphieuhen], [ngaylap], [ngayhen], [IDnv], [IDba]) VALUES (N'PH13062019005', CAST(N'2019-06-13' AS Date), CAST(N'2019-06-07' AS Date), N'NV001', N'BA13062019020')
INSERT [dbo].[PHIEUHENKHAMLAI] ([IDphieuhen], [ngaylap], [ngayhen], [IDnv], [IDba]) VALUES (N'PH13062019006', CAST(N'2019-06-13' AS Date), CAST(N'2019-07-05' AS Date), N'NV001', N'BA13062019021')
INSERT [dbo].[PHIEUHENKHAMLAI] ([IDphieuhen], [ngaylap], [ngayhen], [IDnv], [IDba]) VALUES (N'PH14062019001', CAST(N'2019-06-14' AS Date), CAST(N'2019-06-21' AS Date), N'NV014', N'BA14062019001')
INSERT [dbo].[PHIEUHENKHAMLAI] ([IDphieuhen], [ngaylap], [ngayhen], [IDnv], [IDba]) VALUES (N'PH20062019001', CAST(N'2019-06-20' AS Date), CAST(N'2019-05-29' AS Date), N'NV001', N'BA20062019006')
INSERT [dbo].[PHIEUHENKHAMLAI] ([IDphieuhen], [ngaylap], [ngayhen], [IDnv], [IDba]) VALUES (N'PH20062019002', CAST(N'2019-06-20' AS Date), CAST(N'2019-06-30' AS Date), N'NV001', N'BA20062019008')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB07062019001', CAST(N'2019-06-07' AS Date), CAST(N'13:37:00' AS Time), N'', N'', N'', N'', N'', N'', 1, NULL, N'dfsdfdfsdfs', N'ghvgvnvbn', N'BA07062019001', N'NV012')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB13062019001', CAST(N'2019-06-13' AS Date), CAST(N'01:18:12' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'BA13062019001', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB13062019002', CAST(N'2019-06-13' AS Date), CAST(N'01:19:28' AS Time), N'', N'', N'', N'', N'', N'', NULL, NULL, N'.kj', N'mhgggj', N'BA13062019002', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB13062019003', CAST(N'2019-06-13' AS Date), CAST(N'08:51:29' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'BA13062019003', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB13062019004', CAST(N'2019-06-13' AS Date), CAST(N'09:44:55' AS Time), N'a', N'a', N'a', N'a', N'a', N'a', NULL, NULL, N'a', N'a', N'BA13062019004', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB13062019005', CAST(N'2019-06-13' AS Date), CAST(N'09:49:33' AS Time), N'1', N'1', N'1', N'1', N'a', N'a', NULL, NULL, N'a', N'â', N'BA13062019005', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB13062019006', CAST(N'2019-06-13' AS Date), CAST(N'09:53:08' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'BA13062019006', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB13062019009', CAST(N'2019-06-13' AS Date), CAST(N'10:01:09' AS Time), N'1', N'1', N'1', N'1', N'ssdsdfsdsf', N'sd', NULL, NULL, N'dfsdf', N'sdfsdf', N'BA13062019009', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB13062019010', CAST(N'2019-06-13' AS Date), CAST(N'10:05:03' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'BA13062019010', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB13062019011', CAST(N'2019-06-13' AS Date), CAST(N'10:12:59' AS Time), N'1', N'11', N'1', N'1', N'xcvcxv', N'xvxcvxv', NULL, NULL, N'xcvxcv', N'xcvxcv', N'BA13062019011', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB13062019012', CAST(N'2019-06-13' AS Date), CAST(N'10:15:34' AS Time), N'', N'', N'', N'', N'dasdasd', N'sad', NULL, NULL, N'ádasd', N'ádasd', N'BA13062019012', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB13062019013', CAST(N'2019-06-13' AS Date), CAST(N'10:21:04' AS Time), N'1', N'1', N'1', N'1', N'dasdasd', N'sad', NULL, NULL, N'ádasd', N'ádasd', N'BA13062019013', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB13062019014', CAST(N'2019-06-13' AS Date), CAST(N'10:36:54' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, N'BA13062019014', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB13062019015', CAST(N'2019-06-13' AS Date), CAST(N'10:54:57' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, N'BA13062019015', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB13062019017', CAST(N'2019-06-13' AS Date), CAST(N'12:00:48' AS Time), N'', N'', N'', N'', N'', N'', NULL, NULL, N'fsdfsdf', N'sdfsdf', N'BA13062019017', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB13062019018', CAST(N'2019-06-13' AS Date), CAST(N'12:02:24' AS Time), N'', N'', N'', N'', N'', N'', NULL, NULL, N'êr', N'fsdf', N'BA13062019018', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB13062019019', CAST(N'2019-06-13' AS Date), CAST(N'12:06:40' AS Time), N'', N'', N'', N'', N'', N'', NULL, NULL, N'sdasd', N'ádasd', N'BA13062019019', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB13062019020', CAST(N'2019-06-13' AS Date), CAST(N'12:08:17' AS Time), N'', N'', N'', N'', N'', N'', NULL, NULL, N'đasa', N'ádasd', N'BA13062019020', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB13062019021', CAST(N'2019-06-13' AS Date), CAST(N'12:10:24' AS Time), N'', N'', N'', N'', N'', N'', NULL, NULL, N'scs', N'ádasd', N'BA13062019021', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB13062019022', CAST(N'2019-06-13' AS Date), CAST(N'13:12:59' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'BA13062019022', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB13062019023', CAST(N'2019-06-13' AS Date), CAST(N'23:39:56' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'BA13062019023', N'NV014')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB13062019024', CAST(N'2019-06-13' AS Date), CAST(N'23:55:32' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'BA13062019024', N'NV014')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB13062019025', CAST(N'2019-06-13' AS Date), CAST(N'23:58:34' AS Time), N'1', N'1', N'1', N'1', N'ádasd', N'ádsad', NULL, NULL, N'ádasd', N'sadasd', N'BA13062019025', N'NV014')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB14062019001', CAST(N'2019-06-14' AS Date), CAST(N'00:10:14' AS Time), N'z', N'z', N'z', N'z', N'Không sao', N'Không bị làm sao', NULL, NULL, N'Sức khỏe bình thường', N'uống thuốc', N'BA14062019001', N'NV014')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB14062019002', CAST(N'2019-06-14' AS Date), CAST(N'00:12:59' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, N'BA14062019002', N'NV014')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB14062019003', CAST(N'2019-06-14' AS Date), CAST(N'00:27:21' AS Time), N'1', N'1', N'1', N'1', N'adsasd', N'sdasd', 1, N'dasdasd                                                                                             ', N'ádasSDf', N'đâsddfsdf', N'BA14062019003', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB14062019004', CAST(N'2019-06-14' AS Date), CAST(N'01:50:03' AS Time), N'', N'', N'', N'', N'ádas', N'dsd', 1, N'                                                                                                    ', N'', N'', N'BA14062019004', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB14062019005', CAST(N'2019-06-14' AS Date), CAST(N'01:54:44' AS Time), N'', N'', N'', N'', N'', N'', 1, N'                                                                                                    ', N'', N'', N'BA14062019005', N'NV014')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB14062019006', CAST(N'2019-06-14' AS Date), CAST(N'10:15:21' AS Time), N'1', N'11', N'1', N'1', N'jasdgjashgdhg', N'kjasdhaskd', NULL, NULL, N'ahjdjahsd', N'asdsđ', N'BA14062019006', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB19062019001', CAST(N'2019-06-19' AS Date), CAST(N'14:42:14' AS Time), N'', N'', N'', N'', N'', N'', 1, N'                                                                                                    ', N'', N'', N'BA19062019001', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB19062019002', CAST(N'2019-06-19' AS Date), CAST(N'15:57:17' AS Time), N'', N'', N'', N'', N'', N'', 1, N'                                                                                                    ', N'', N'', N'BA19062019002', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB19062019003', CAST(N'2019-06-19' AS Date), CAST(N'16:00:08' AS Time), N'', N'', N'', N'', N'', N'', 1, N'                                                                                                    ', N'', N'', N'BA19062019003', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB20062019001', CAST(N'2019-06-20' AS Date), CAST(N'07:26:08' AS Time), N'1', N'1', N'1', N'1', N'hshsh', N'hahs', 1, N'sdasdđâsd                                                                                           ', N'ádasd', N'ádasdasdasd', N'BA20062019001', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB20062019002', CAST(N'2019-06-20' AS Date), CAST(N'07:38:20' AS Time), N'', N'', N'', N'', N'ssfsdf', N'sdsd', NULL, NULL, N'dsfs', N'sdfsdf', N'BA20062019002', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB20062019003', CAST(N'2019-06-20' AS Date), CAST(N'07:43:09' AS Time), N'', N'', N'', N'', N'qưewqe', N'ewq', NULL, NULL, N'qưeqw', N'qưeqwe', N'BA20062019003', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB20062019004', CAST(N'2019-06-20' AS Date), CAST(N'07:45:19' AS Time), N'', N'', N'', N'', N'ádasd', N'adasd', NULL, NULL, N'ádasd', N'ádasd', N'BA20062019004', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB20062019005', CAST(N'2019-06-20' AS Date), CAST(N'07:50:53' AS Time), N'', N'', N'', N'', N'sfsdf', N'sdsf', NULL, NULL, N'dsfsdf', N'dsfsdf', N'BA20062019005', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB20062019006', CAST(N'2019-06-20' AS Date), CAST(N'10:08:26' AS Time), N'', N'', N'', N'', N'Thiếu não', N'Si đa', NULL, NULL, N'Bị ăn trộm não', N'Trồng cây', N'BA20062019006', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB20062019007', CAST(N'2019-06-20' AS Date), CAST(N'10:15:19' AS Time), N'1', N'1', N'1', N'1', N'dasdasd', N'ádad', 1, N'                                                                                                    ', N'', N'', N'BA20062019007', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB20062019008', CAST(N'2019-06-20' AS Date), CAST(N'12:44:03' AS Time), N'79', N'65', N'121', N'37', N'Bình Thường', N'Viêm Gan A', NULL, NULL, N'Sốt Virus', N'Uống thuốc điều trị ngoại trú', N'BA20062019008', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB20062019009', CAST(N'2019-06-20' AS Date), CAST(N'12:54:49' AS Time), N'75', N'65', N'122', N'37', N'Xuất huyết dạ giày', N'Không có', 1, N'Viêm Gan B                                                                                          ', N'Viêm Gan B', N'Uống thuốc điều trị ngoại trú', N'BA20062019009', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB20062019010', CAST(N'2019-06-20' AS Date), CAST(N'13:57:22' AS Time), N'', N'', N'', N'', N'jhjhjh', N'jhjh', NULL, NULL, N'jbjhj', N'kjjjkjkjk', N'BA20062019010', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB20062019011', CAST(N'2019-06-20' AS Date), CAST(N'15:26:52' AS Time), N'', N'', N'', N'', N'', N'', 1, N'                                                                                                    ', N'', N'', N'BA20062019011', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB20062019012', CAST(N'2019-06-20' AS Date), CAST(N'15:33:11' AS Time), N'', N'', N'', N'', N'', N'', 1, N'                                                                                                    ', N'', N'', N'BA20062019012', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB20062019013', CAST(N'2019-06-20' AS Date), CAST(N'16:01:57' AS Time), N'', N'', N'', N'', N'', N'', 1, N'                                                                                                    ', N'', N'', N'BA20062019013', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB20062019014', CAST(N'2019-06-20' AS Date), CAST(N'16:11:29' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'BA20062019014', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB21062019001', CAST(N'2019-06-21' AS Date), CAST(N'09:30:22' AS Time), N'', N'', N'', N'', N'', N'', 1, N'ádasdjhasd                                                                                          ', N'ádhjasdhjasdh', N'ạdhajsdhajsdhasjd', N'BA21062019001', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB23062019001', CAST(N'2019-06-23' AS Date), CAST(N'22:36:42' AS Time), N'ưer', N'ưer', N'ưerwe', N'ưerw', N'ewrwe', N'ểwr', 1, N'ádsadas                                                                                             ', N'ádasd', N'dasd', N'BA23062019001', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB23062019002', CAST(N'2019-06-23' AS Date), CAST(N'23:35:04' AS Time), N'', N'', N'', N'', N'ádasd', N'đâsd', 1, N'áda                                                                                                 ', N'ád', N'ad', N'BA23062019002', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB28052019001', CAST(N'2019-05-28' AS Date), CAST(N'23:05:15' AS Time), N'sad', N'ád', N'ád', N'ádasd', N'adsad', N'dasd', 1, NULL, N'ád', N'ádasdasd', N'BA28052019001', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB28052019002', CAST(N'2019-05-28' AS Date), CAST(N'23:06:17' AS Time), N'', N'', N'', N'', N'', N'', NULL, NULL, N'â', N'ádas', N'BA28052019002', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB28052019003', CAST(N'2019-05-28' AS Date), CAST(N'23:06:49' AS Time), N'', N'', N'', N'', N'', N'', 1, NULL, N'zxc', N'zxc', N'BA28052019003', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB28052019004', CAST(N'2019-05-28' AS Date), CAST(N'23:10:47' AS Time), N'sdfsdf', N'sdf', N'sdf', N'sdf', N'dsfdsf', N'dsf', 1, NULL, N'sdfsdf', N'sdfsdfdsf', N'BA28052019004', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB28052019005', CAST(N'2019-05-28' AS Date), CAST(N'23:18:57' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'BA28052019005', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB28052019006', CAST(N'2019-05-28' AS Date), CAST(N'23:20:00' AS Time), N'qưe', N'qưe', N'ưe', N'qưe', N'qưe', N'ưqe', 1, NULL, N'qưe', N'qưe', N'BA28052019006', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB29052019001', CAST(N'2019-05-29' AS Date), CAST(N'12:19:19' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'BA29052019001', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB29052019002', CAST(N'2019-05-29' AS Date), CAST(N'12:21:29' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'BA29052019002', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB29052019003', CAST(N'2019-05-29' AS Date), CAST(N'14:25:57' AS Time), N'ád', N'ád', N'ád', N'ádd', N'ád', N'ấd', NULL, NULL, N'ád', N'ádasd', N'BA29052019003', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB29052019004', CAST(N'2019-05-29' AS Date), CAST(N'14:29:27' AS Time), N'sad', N'ád', N'ád', N'ád', N'sdf', N'fsd', 1, NULL, N'f', N'df', N'BA29052019004', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB29052019005', CAST(N'2019-05-29' AS Date), CAST(N'14:30:17' AS Time), N'', N'', N'', N'', N'sad', N'ád', 1, NULL, N'ád', N'ád', N'BA29052019005', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB29052019006', CAST(N'2019-05-29' AS Date), CAST(N'14:42:14' AS Time), N'sdf', N'sdf', N'fs', N'fdsf', N'sdfsdf', N'df', NULL, NULL, N'dfsdf', N'sdfdsf', N'BA29052019006', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB29052019007', CAST(N'2019-05-29' AS Date), CAST(N'15:38:24' AS Time), N'', N'', N'', N'', N'ẻwe', N'er', 1, NULL, N'ưer', N'ưerwer', N'BA29052019007', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB29052019008', CAST(N'2019-05-29' AS Date), CAST(N'17:37:06' AS Time), N'', N'', N'', N'', N'', N'', NULL, NULL, N'sad', N'ád', N'BA29052019008', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB29052019009', CAST(N'2019-05-29' AS Date), CAST(N'17:41:25' AS Time), N'', N'', N'', N'', N'', N'', NULL, NULL, N'd', N'adsd', N'BA29052019009', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB29052019010', CAST(N'2019-05-29' AS Date), CAST(N'19:07:05' AS Time), N'', N'', N'', N'', N'qưe', N'qưe', 1, NULL, N'qưe', N'qưe', N'BA29052019010', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB30052019001', CAST(N'2019-05-30' AS Date), CAST(N'01:42:31' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'BA30052019001', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB30052019003', CAST(N'2019-05-30' AS Date), CAST(N'03:03:21' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'BA30052019003', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB30052019004', CAST(N'2019-05-30' AS Date), CAST(N'03:03:53' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'BA30052019004', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB30052019005', CAST(N'2019-05-30' AS Date), CAST(N'03:07:53' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'BA30052019005', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB30052019006', CAST(N'2019-05-30' AS Date), CAST(N'03:12:14' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'BA30052019006', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB30052019007', CAST(N'2019-05-30' AS Date), CAST(N'15:11:42' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'BA30052019007', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB30052019008', CAST(N'2019-05-30' AS Date), CAST(N'15:28:39' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'BA30052019008', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB30052019009', CAST(N'2019-05-30' AS Date), CAST(N'15:30:57' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'BA30052019009', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB30052019010', CAST(N'2019-05-30' AS Date), CAST(N'15:33:01' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'BA30052019010', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB30052019011', CAST(N'2019-05-30' AS Date), CAST(N'15:34:24' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'BA30052019011', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB30052019012', CAST(N'2019-05-30' AS Date), CAST(N'15:35:50' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'BA30052019012', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB30052019013', CAST(N'2019-05-30' AS Date), CAST(N'15:37:32' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'BA30052019013', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB30052019014', CAST(N'2019-05-30' AS Date), CAST(N'15:40:48' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'BA30052019014', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB30052019015', CAST(N'2019-05-30' AS Date), CAST(N'15:42:28' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'BA30052019015', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB30052019016', CAST(N'2019-05-30' AS Date), CAST(N'15:46:50' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'BA30052019016', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB30052019017', CAST(N'2019-05-30' AS Date), CAST(N'15:51:57' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'BA30052019017', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB30052019018', CAST(N'2019-05-30' AS Date), CAST(N'15:54:04' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'BA30052019018', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB30052019019', CAST(N'2019-05-30' AS Date), CAST(N'15:56:57' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'BA30052019019', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB30052019020', CAST(N'2019-05-30' AS Date), CAST(N'15:59:29' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'BA30052019020', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB30052019021', CAST(N'2019-05-30' AS Date), CAST(N'16:31:13' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'BA30052019021', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB30052019022', CAST(N'2019-05-30' AS Date), CAST(N'17:26:55' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'BA30052019022', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB30052019023', CAST(N'2019-05-30' AS Date), CAST(N'17:29:18' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'BA30052019023', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB30052019024', CAST(N'2019-05-30' AS Date), CAST(N'17:31:51' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'BA30052019024', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB30052019025', CAST(N'2019-05-30' AS Date), CAST(N'17:34:04' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'BA30052019025', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB30052019026', CAST(N'2019-05-30' AS Date), CAST(N'17:36:00' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'BA30052019026', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB31052019001', CAST(N'2019-05-31' AS Date), CAST(N'08:56:24' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, N'BA31052019001', N'NV001')
INSERT [dbo].[PHIEUKHAMBENH] ([IDpk], [Ngaylap], [giolap], [Nhiptim], [Nhiptho], [Huyetap], [Nhietdo], [Cacbophan], [Tieusubenh], [CLS], [ChuandoanCLS], [Ketluan], [Xuly], [IDba], [IDnv]) VALUES (N'PKB31052019002', CAST(N'2019-05-31' AS Date), CAST(N'09:06:29' AS Time), NULL, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, N'BA31052019002', N'NV001')
INSERT [dbo].[PHIEUTHANHTOANXNKT] ([IDpttxn], [IDdichvu], [ngaylap], [giolap], [trangthaitt], [phantramgiam], [IDnv], [IDba], [IDbnlv], [IDnvthungan], [trangthaiXN]) VALUES (N'PTT20062019001', N'DV0003', CAST(N'2019-06-20' AS Date), CAST(N'16:02:49' AS Time), 1, N'100', N'NV001', N'BA20062019013', N'BNLV20062019008', N'NV003', 1)
INSERT [dbo].[PHIEUTHANHTOANXNKT] ([IDpttxn], [IDdichvu], [ngaylap], [giolap], [trangthaitt], [phantramgiam], [IDnv], [IDba], [IDbnlv], [IDnvthungan], [trangthaiXN]) VALUES (N'PTT21062019001', N'DV0003', CAST(N'2019-06-21' AS Date), CAST(N'09:31:33' AS Time), 0, N'0', N'NV001', N'BA21062019001', NULL, NULL, NULL)
INSERT [dbo].[PHIEUTHANHTOANXNKT] ([IDpttxn], [IDdichvu], [ngaylap], [giolap], [trangthaitt], [phantramgiam], [IDnv], [IDba], [IDbnlv], [IDnvthungan], [trangthaiXN]) VALUES (N'PTT23062019001', N'DV0003', CAST(N'2019-06-23' AS Date), CAST(N'23:35:15' AS Time), 1, N'100', N'NV001', N'BA23062019002', N'BNLV23062019003', N'NV003', 0)
INSERT [dbo].[PHIEUXETNGHIEM] ([IDpxn], [gan], [mat], [tuy], [lach], [hethongtietlieu], [tuyentienliet], [mota], [ketluan], [IDnv], [thoigianlap], [IDpb], [IDloai], [IDpttxn]) VALUES (N'PXQ20062019001', NULL, NULL, NULL, NULL, NULL, NULL, N'Hoàn toàn bình thường', N'Không sao cả', N'NV013', CAST(N'2019-06-20T16:05:36.200' AS DateTime), N'PB037', N'LH002', N'PTT20062019001')
INSERT [dbo].[PHONGBAN] ([IDpb], [Tenpb], [Diachi], [Nhiemvu], [IDpbCha], [IDkhoa]) VALUES (N'PB001', N'Phòng nhân viên trực ban', N'hjhjhg', N'likui', NULL, N'BP001')
INSERT [dbo].[PHONGBAN] ([IDpb], [Tenpb], [Diachi], [Nhiemvu], [IDpbCha], [IDkhoa]) VALUES (N'PB003', N'Phòng khám bệnh số 2', N'Tầng 5 nhà s3', N'Khám bệnh cho bệnh nhân', N'PB001', N'BP001')
INSERT [dbo].[PHONGBAN] ([IDpb], [Tenpb], [Diachi], [Nhiemvu], [IDpbCha], [IDkhoa]) VALUES (N'PB004', N'Phòng trực khám bệnh', N'Tầng 1 nhà s5', N'Khám bệnh ch', N'PB003', N'BP001')
INSERT [dbo].[PHONGBAN] ([IDpb], [Tenpb], [Diachi], [Nhiemvu], [IDpbCha], [IDkhoa]) VALUES (N'PB005', N'Phòng tiếp nhận bệnh nhân', N'Tầng 12 nhà s6', N'Đăng ký khám bệnh cho bệnh nhân', NULL, N'BP001')
INSERT [dbo].[PHONGBAN] ([IDpb], [Tenpb], [Diachi], [Nhiemvu], [IDpbCha], [IDkhoa]) VALUES (N'PB006', N'Phòng chờ', N'Tầng 1 nhà s1', N'Bệnh nhân chờ khám', NULL, N'BP001')
INSERT [dbo].[PHONGBAN] ([IDpb], [Tenpb], [Diachi], [Nhiemvu], [IDpbCha], [IDkhoa]) VALUES (N'PB007', N'Phòng kiểm toán', N'a', N'â', NULL, N'BP001')
INSERT [dbo].[PHONGBAN] ([IDpb], [Tenpb], [Diachi], [Nhiemvu], [IDpbCha], [IDkhoa]) VALUES (N'PB008', N'Phòng khám bệnh số 3', N'a', N'', N'PB001', N'BP001')
INSERT [dbo].[PHONGBAN] ([IDpb], [Tenpb], [Diachi], [Nhiemvu], [IDpbCha], [IDkhoa]) VALUES (N'PB010', N'Phòng trực số 1 ', N'Tầng 2 nhà s1', N'Quản lý trực ban ', N'PB004', N'BP001')
INSERT [dbo].[PHONGBAN] ([IDpb], [Tenpb], [Diachi], [Nhiemvu], [IDpbCha], [IDkhoa]) VALUES (N'PB011', N'Phòng khám bệnh số 4', N'a', N'', N'PB001', N'BP001')
INSERT [dbo].[PHONGBAN] ([IDpb], [Tenpb], [Diachi], [Nhiemvu], [IDpbCha], [IDkhoa]) VALUES (N'PB013', N'Phòng tiếp nhận bệnh nhân số 1', N'a', N'â', N'PB005', N'BP001')
INSERT [dbo].[PHONGBAN] ([IDpb], [Tenpb], [Diachi], [Nhiemvu], [IDpbCha], [IDkhoa]) VALUES (N'PB017', N'phòng họp', N'tầng 5', N'no', NULL, N'BP001')
INSERT [dbo].[PHONGBAN] ([IDpb], [Tenpb], [Diachi], [Nhiemvu], [IDpbCha], [IDkhoa]) VALUES (N'PB020', N'Phòng phỏng vấn', N'tầng 5', N'5', N'PB001', N'BP001')
INSERT [dbo].[PHONGBAN] ([IDpb], [Tenpb], [Diachi], [Nhiemvu], [IDpbCha], [IDkhoa]) VALUES (N'PB021', N'Phòng khám bệnh', N'Khu A', N'Khám bệnh cho bệnh nhân', NULL, N'BP001')
INSERT [dbo].[PHONGBAN] ([IDpb], [Tenpb], [Diachi], [Nhiemvu], [IDpbCha], [IDkhoa]) VALUES (N'PB022', N'Phòng khám bệnh số 1 ', N'Phòng 201 nhà Khu A', N'Khám bệnh cho bệnh nhân', N'PB021', N'BP001')
INSERT [dbo].[PHONGBAN] ([IDpb], [Tenpb], [Diachi], [Nhiemvu], [IDpbCha], [IDkhoa]) VALUES (N'PB023', N'Phòng khám bệnh số 2', N'Phòng 202 nhà khu A', N'Khám bệnh cho bệnh nhân', N'PB021', N'BP001')
INSERT [dbo].[PHONGBAN] ([IDpb], [Tenpb], [Diachi], [Nhiemvu], [IDpbCha], [IDkhoa]) VALUES (N'PB024', N'Phòng khám bệnh số 3', N'Phòng 203 khu nhà A', N'Khám bệnh cho bệnh nhân', N'PB021', N'BP001')
INSERT [dbo].[PHONGBAN] ([IDpb], [Tenpb], [Diachi], [Nhiemvu], [IDpbCha], [IDkhoa]) VALUES (N'PB025', N'Phòng khám bệnh số 4', N'Phòng 204 nhà khu A', N'Khám bệnh cho bệnh nhân', N'PB021', N'BP001')
INSERT [dbo].[PHONGBAN] ([IDpb], [Tenpb], [Diachi], [Nhiemvu], [IDpbCha], [IDkhoa]) VALUES (N'PB026', N'Bộ phận thu ngân', N'Tầng 1 nhà A', N'Thu phí khám chữa bệnh', NULL, NULL)
INSERT [dbo].[PHONGBAN] ([IDpb], [Tenpb], [Diachi], [Nhiemvu], [IDpbCha], [IDkhoa]) VALUES (N'PB028', N'Phòng thu ngân số 2', N'Tầng 1 nhà khu A', N'Thu phí khám chữa bệnh', N'PB026', NULL)
INSERT [dbo].[PHONGBAN] ([IDpb], [Tenpb], [Diachi], [Nhiemvu], [IDpbCha], [IDkhoa]) VALUES (N'PB029', N'Phòng thu ngân số 1', N'Tầng 1 nhà khu A', N'Khám bệnh cho bệnh nhân', N'PB026', NULL)
INSERT [dbo].[PHONGBAN] ([IDpb], [Tenpb], [Diachi], [Nhiemvu], [IDpbCha], [IDkhoa]) VALUES (N'PB030', N'Phòng bảo vệ', N'a', N'a', NULL, NULL)
INSERT [dbo].[PHONGBAN] ([IDpb], [Tenpb], [Diachi], [Nhiemvu], [IDpbCha], [IDkhoa]) VALUES (N'PB031', N'Phòng siêu âm ', N'Tầng 2 nhà A', N'Siêu âm chuẩn đoán', NULL, N'BP002')
INSERT [dbo].[PHONGBAN] ([IDpb], [Tenpb], [Diachi], [Nhiemvu], [IDpbCha], [IDkhoa]) VALUES (N'PB032', N'Phòng siêm âm ổ bụng ', N'Phòng 211 tầng 2 nhà A', N'Siêu âm ổ bụng cho bệnh nhân ', N'PB031', N'BP002')
INSERT [dbo].[PHONGBAN] ([IDpb], [Tenpb], [Diachi], [Nhiemvu], [IDpbCha], [IDkhoa]) VALUES (N'PB033', N'Bộ phận bán thuốc ', N'Tầng 1 nhà A', N'Bán thuốc cho bệnh nhân', NULL, NULL)
INSERT [dbo].[PHONGBAN] ([IDpb], [Tenpb], [Diachi], [Nhiemvu], [IDpbCha], [IDkhoa]) VALUES (N'PB034', N'Phòng bán thuốc số 1 ', N'Phòng 101', N'Bán thuốc', NULL, NULL)
INSERT [dbo].[PHONGBAN] ([IDpb], [Tenpb], [Diachi], [Nhiemvu], [IDpbCha], [IDkhoa]) VALUES (N'PB035', N'Phòng bán thuốc số 1', N'Nhà A tầng 1', N'Bán thuốc', N'PB033', NULL)
INSERT [dbo].[PHONGBAN] ([IDpb], [Tenpb], [Diachi], [Nhiemvu], [IDpbCha], [IDkhoa]) VALUES (N'PB036', N'Phòng chụp X-quang', N'Tầng 3 Nhà khu B', N'Chụp chiếu chuẩn đoán', NULL, N'BP002')
INSERT [dbo].[PHONGBAN] ([IDpb], [Tenpb], [Diachi], [Nhiemvu], [IDpbCha], [IDkhoa]) VALUES (N'PB037', N'Phòng chụp X-quang số 1', N'Phòng 301 tầng 3 nhà khu B', N'Chụp X-quang ', N'PB036', N'BP002')
INSERT [dbo].[PHONGBAN] ([IDpb], [Tenpb], [Diachi], [Nhiemvu], [IDpbCha], [IDkhoa]) VALUES (N'PB039', N'Phòng siêu âm ổ bụng số 1', N'Phòng 303 tầng 3 nhà khu B', N'Siêu âm ổ bụng', N'PB032', N'BP002')
INSERT [dbo].[PHONGBAN] ([IDpb], [Tenpb], [Diachi], [Nhiemvu], [IDpbCha], [IDkhoa]) VALUES (N'PB040', N'Phòng siêu âm ổ bụng số 2', N'Phòng 304 tầng 3 nhà khu B', N'Siêu âm ổ bụng', N'PB032', N'BP002')
INSERT [dbo].[PHONGBAN] ([IDpb], [Tenpb], [Diachi], [Nhiemvu], [IDpbCha], [IDkhoa]) VALUES (N'PB041', N'Phòng chụp X-quang số 2', N'Phòng 302 tầng 3 nhà khu B', N'Chụp X-quang', N'PB036', N'BP002')
INSERT [dbo].[PHONGBANDICHVU] ([IDpb], [IDdichvu], [ghichu]) VALUES (N'PB037', N'DV0003', NULL)
INSERT [dbo].[PHONGBANDICHVU] ([IDpb], [IDdichvu], [ghichu]) VALUES (N'PB037', N'DV0004', NULL)
INSERT [dbo].[PHONGBANDICHVU] ([IDpb], [IDdichvu], [ghichu]) VALUES (N'PB039', N'DV0001', NULL)
INSERT [dbo].[PHONGBANDICHVU] ([IDpb], [IDdichvu], [ghichu]) VALUES (N'PB040', N'DV0001', NULL)
INSERT [dbo].[PHONGBANDICHVU] ([IDpb], [IDdichvu], [ghichu]) VALUES (N'PB041', N'DV0003', NULL)
INSERT [dbo].[PHONGBANDICHVU] ([IDpb], [IDdichvu], [ghichu]) VALUES (N'PB041', N'DV0004', NULL)
INSERT [dbo].[TAIKHOAN] ([IDtk], [Tendn], [Matkhau], [IDnv], [IDquyen]) VALUES (N'TK001', N'nguyenvanbaa', N'1233', N'NV006', N'PQ001')
INSERT [dbo].[TAIKHOAN] ([IDtk], [Tendn], [Matkhau], [IDnv], [IDquyen]) VALUES (N'TK002', N'nguyenminhtam', N'123', N'NV005', N'PQ001')
INSERT [dbo].[TAIKHOAN] ([IDtk], [Tendn], [Matkhau], [IDnv], [IDquyen]) VALUES (N'TK003', N'nguyenvanhoa', N'123', N'NV007', N'PQ002')
INSERT [dbo].[TAIKHOAN] ([IDtk], [Tendn], [Matkhau], [IDnv], [IDquyen]) VALUES (N'TK004', N'vuminhhieu', N'123', N'NV010', N'PQ004')
INSERT [dbo].[TAIKHOAN] ([IDtk], [Tendn], [Matkhau], [IDnv], [IDquyen]) VALUES (N'TK005', N'nguyenvana', N'123', N'NV009', N'PQ003')
INSERT [dbo].[TAIKHOAN] ([IDtk], [Tendn], [Matkhau], [IDnv], [IDquyen]) VALUES (N'TK006', N'vuminhtu', N'123', N'NV011', N'PQ006')
INSERT [dbo].[TAIKHOAN] ([IDtk], [Tendn], [Matkhau], [IDnv], [IDquyen]) VALUES (N'TK007', N'vuvantrung', N'123', N'NV001', N'PQ004')
INSERT [dbo].[TAIKHOAN] ([IDtk], [Tendn], [Matkhau], [IDnv], [IDquyen]) VALUES (N'TK008', N'phanhuytoan', N'123', N'NV012', N'PQ004')
INSERT [dbo].[TAIKHOAN] ([IDtk], [Tendn], [Matkhau], [IDnv], [IDquyen]) VALUES (N'TK009', N'nguyenthilien', N'123', N'NV004', N'PQ005')
INSERT [dbo].[TAIKHOAN] ([IDtk], [Tendn], [Matkhau], [IDnv], [IDquyen]) VALUES (N'TK010', N'vuhoanglam', N'123', N'NV003', N'PQ005')
INSERT [dbo].[TAIKHOAN] ([IDtk], [Tendn], [Matkhau], [IDnv], [IDquyen]) VALUES (N'TK011', N'vuthihoai', N'123', N'NV014', N'PQ004')
INSERT [dbo].[TAIKHOAN] ([IDtk], [Tendn], [Matkhau], [IDnv], [IDquyen]) VALUES (N'TK012', N'lyvanhoa', N'123', N'NV013', N'PQ006')
INSERT [dbo].[TAIKHOAN] ([IDtk], [Tendn], [Matkhau], [IDnv], [IDquyen]) VALUES (N'TK013', N'nguyenminhlong', N'123', N'NV015', N'PQ004')
INSERT [dbo].[TAIKHOAN] ([IDtk], [Tendn], [Matkhau], [IDnv], [IDquyen]) VALUES (N'TK014', N'vuhoainam', N'123', N'NV016', N'PQ004')
INSERT [dbo].[TAIKHOAN] ([IDtk], [Tendn], [Matkhau], [IDnv], [IDquyen]) VALUES (N'TK015', N'ninhduytuan', N'123', N'NV017', N'PQ004')
INSERT [dbo].[TAIKHOAN] ([IDtk], [Tendn], [Matkhau], [IDnv], [IDquyen]) VALUES (N'TK016', N'phamgiahung', N'123', N'NV018', N'PQ006')
INSERT [dbo].[TAIKHOAN] ([IDtk], [Tendn], [Matkhau], [IDnv], [IDquyen]) VALUES (N'TK017', N'nguyenminhphong', N'123', N'NV019', N'PQ006')
INSERT [dbo].[TAIKHOAN] ([IDtk], [Tendn], [Matkhau], [IDnv], [IDquyen]) VALUES (N'TK018', N'nguyentruongson', N'123', N'NV020', N'PQ006')
INSERT [dbo].[THUOC] ([IDthuoc], [Tenthuoc], [Thanhphan], [Luongdung], [DVT], [Dongia], [Xuatxu]) VALUES (N'TH0001', N'Paracetamon', N'Paracetamon 100%', N'Ngày 2 viên sau ăn ', N'Bìa', 20000, N'Việt Nam')
INSERT [dbo].[THUOC] ([IDthuoc], [Tenthuoc], [Thanhphan], [Luongdung], [DVT], [Dongia], [Xuatxu]) VALUES (N'TH0002', N'Vitamin C', N'Vinamin C 100 %', N'Ngày 2 lần mỗi lần 1 viên sau ăn ', N'Bìa', 10000, N'Việt Nam')
INSERT [dbo].[THUOC] ([IDthuoc], [Tenthuoc], [Thanhphan], [Luongdung], [DVT], [Dongia], [Xuatxu]) VALUES (N'TH0003', N'Vitamin E', NULL, NULL, N'vỉ ', 2100, NULL)
INSERT [dbo].[THUOC] ([IDthuoc], [Tenthuoc], [Thanhphan], [Luongdung], [DVT], [Dongia], [Xuatxu]) VALUES (N'TH0004', N'Vitamin K', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[THUOC] ([IDthuoc], [Tenthuoc], [Thanhphan], [Luongdung], [DVT], [Dongia], [Xuatxu]) VALUES (N'TH0005', N'Angbixilin', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[THUOC] ([IDthuoc], [Tenthuoc], [Thanhphan], [Luongdung], [DVT], [Dongia], [Xuatxu]) VALUES (N'TH0006', N'Ameflu', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[THUOC] ([IDthuoc], [Tenthuoc], [Thanhphan], [Luongdung], [DVT], [Dongia], [Xuatxu]) VALUES (N'TH0007', N'An thảo', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[THUOC] ([IDthuoc], [Tenthuoc], [Thanhphan], [Luongdung], [DVT], [Dongia], [Xuatxu]) VALUES (N'TH0008', N'Hoạt huyết dưỡng não', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[TRANGTHAILAMVIEC] ([IDtrangthai], [tentrangthai]) VALUES (N'1', N'Chờ làm việc')
INSERT [dbo].[TRANGTHAILAMVIEC] ([IDtrangthai], [tentrangthai]) VALUES (N'2', N'Đang làm việc')
INSERT [dbo].[TRANGTHAILAMVIEC] ([IDtrangthai], [tentrangthai]) VALUES (N'3', N'Đang xét nghiệm')
INSERT [dbo].[TRANGTHAILAMVIEC] ([IDtrangthai], [tentrangthai]) VALUES (N'4', N'Hoàn thành ')
INSERT [dbo].[TUYENBHYT] ([IDtuyen], [Tentuyen]) VALUES (N'T001', N'Tuyến Huyện , Xã')
INSERT [dbo].[TUYENBHYT] ([IDtuyen], [Tentuyen]) VALUES (N'T002', N'Tuyến Tỉnh')
INSERT [dbo].[TUYENBHYT] ([IDtuyen], [Tentuyen]) VALUES (N'T003', N'Tuyến Trung Ương ')
ALTER TABLE [dbo].[BENHAN]  WITH CHECK ADD  CONSTRAINT [FK_BENHAN_BENHNHAN] FOREIGN KEY([IDbn])
REFERENCES [dbo].[BENHNHAN] ([IDbn])
GO
ALTER TABLE [dbo].[BENHAN] CHECK CONSTRAINT [FK_BENHAN_BENHNHAN]
GO
ALTER TABLE [dbo].[BENHAN]  WITH CHECK ADD  CONSTRAINT [FK_BENHAN_LOAIHINHDIEUTRI] FOREIGN KEY([IDloaihinh])
REFERENCES [dbo].[LOAIHINHDIEUTRI] ([IDloaihinh])
GO
ALTER TABLE [dbo].[BENHAN] CHECK CONSTRAINT [FK_BENHAN_LOAIHINHDIEUTRI]
GO
ALTER TABLE [dbo].[BENHNHANLAMVIEC]  WITH CHECK ADD  CONSTRAINT [FK_BENHNHANLAMVIEC_BENHAN] FOREIGN KEY([IDba])
REFERENCES [dbo].[BENHAN] ([IDba])
GO
ALTER TABLE [dbo].[BENHNHANLAMVIEC] CHECK CONSTRAINT [FK_BENHNHANLAMVIEC_BENHAN]
GO
ALTER TABLE [dbo].[BENHNHANLAMVIEC]  WITH CHECK ADD  CONSTRAINT [FK_BENHNHANLAMVIEC_BENHNHAN] FOREIGN KEY([IDbn])
REFERENCES [dbo].[BENHNHAN] ([IDbn])
GO
ALTER TABLE [dbo].[BENHNHANLAMVIEC] CHECK CONSTRAINT [FK_BENHNHANLAMVIEC_BENHNHAN]
GO
ALTER TABLE [dbo].[BENHNHANLAMVIEC]  WITH CHECK ADD  CONSTRAINT [FK_BENHNHANLAMVIEC_PHONGBAN] FOREIGN KEY([IDpb])
REFERENCES [dbo].[PHONGBAN] ([IDpb])
GO
ALTER TABLE [dbo].[BENHNHANLAMVIEC] CHECK CONSTRAINT [FK_BENHNHANLAMVIEC_PHONGBAN]
GO
ALTER TABLE [dbo].[BENHNHANLAMVIEC]  WITH CHECK ADD  CONSTRAINT [FK_BENHNHANLAMVIEC_TRANGTHAILAMVIEC] FOREIGN KEY([IDtrangthai])
REFERENCES [dbo].[TRANGTHAILAMVIEC] ([IDtrangthai])
GO
ALTER TABLE [dbo].[BENHNHANLAMVIEC] CHECK CONSTRAINT [FK_BENHNHANLAMVIEC_TRANGTHAILAMVIEC]
GO
ALTER TABLE [dbo].[BHYT]  WITH CHECK ADD  CONSTRAINT [FK_BHYT_BENHNHAN] FOREIGN KEY([IDbn])
REFERENCES [dbo].[BENHNHAN] ([IDbn])
GO
ALTER TABLE [dbo].[BHYT] CHECK CONSTRAINT [FK_BHYT_BENHNHAN]
GO
ALTER TABLE [dbo].[BHYT]  WITH CHECK ADD  CONSTRAINT [FK_BHYT_DTUT] FOREIGN KEY([IDdt])
REFERENCES [dbo].[DTUT] ([IDdt])
GO
ALTER TABLE [dbo].[BHYT] CHECK CONSTRAINT [FK_BHYT_DTUT]
GO
ALTER TABLE [dbo].[BHYT]  WITH CHECK ADD  CONSTRAINT [FK_BHYT_TUYENBHYT] FOREIGN KEY([IDtuyen])
REFERENCES [dbo].[TUYENBHYT] ([IDtuyen])
GO
ALTER TABLE [dbo].[BHYT] CHECK CONSTRAINT [FK_BHYT_TUYENBHYT]
GO
ALTER TABLE [dbo].[CHITIETDONTHUOC]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETDONTHUOC_DONTHUOC] FOREIGN KEY([IDdonthuoc])
REFERENCES [dbo].[DONTHUOC] ([IDdonthuoc])
GO
ALTER TABLE [dbo].[CHITIETDONTHUOC] CHECK CONSTRAINT [FK_CHITIETDONTHUOC_DONTHUOC]
GO
ALTER TABLE [dbo].[CHITIETDONTHUOC]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETDONTHUOC_THUOC] FOREIGN KEY([IDthuoc])
REFERENCES [dbo].[THUOC] ([IDthuoc])
GO
ALTER TABLE [dbo].[CHITIETDONTHUOC] CHECK CONSTRAINT [FK_CHITIETDONTHUOC_THUOC]
GO
ALTER TABLE [dbo].[DONTHUOC]  WITH CHECK ADD  CONSTRAINT [FK_DONTHUOC_BACSY] FOREIGN KEY([IDnv])
REFERENCES [dbo].[NHANVIEN] ([IDnv])
GO
ALTER TABLE [dbo].[DONTHUOC] CHECK CONSTRAINT [FK_DONTHUOC_BACSY]
GO
ALTER TABLE [dbo].[DONTHUOC]  WITH CHECK ADD  CONSTRAINT [FK_DONTHUOC_BENHAN] FOREIGN KEY([IDba])
REFERENCES [dbo].[BENHAN] ([IDba])
GO
ALTER TABLE [dbo].[DONTHUOC] CHECK CONSTRAINT [FK_DONTHUOC_BENHAN]
GO
ALTER TABLE [dbo].[GIAYCHUYENVIEN]  WITH CHECK ADD  CONSTRAINT [FK_GIAYCHUYENVIEN_BHYT] FOREIGN KEY([IDbhyt])
REFERENCES [dbo].[BHYT] ([IDbhyt])
GO
ALTER TABLE [dbo].[GIAYCHUYENVIEN] CHECK CONSTRAINT [FK_GIAYCHUYENVIEN_BHYT]
GO
ALTER TABLE [dbo].[KHOA]  WITH CHECK ADD  CONSTRAINT [FK_KHOA_NHANVIEN] FOREIGN KEY([IDtruongkhoa])
REFERENCES [dbo].[NHANVIEN] ([IDnv])
GO
ALTER TABLE [dbo].[KHOA] CHECK CONSTRAINT [FK_KHOA_NHANVIEN]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_BACSY_KHOA] FOREIGN KEY([IDkhoa])
REFERENCES [dbo].[KHOA] ([IDkhoa])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_BACSY_KHOA]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_CHUCVU] FOREIGN KEY([IDchucvu])
REFERENCES [dbo].[CHUCVU] ([IDchucvu])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_CHUCVU]
GO
ALTER TABLE [dbo].[NHANVIENLAMVIEC]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIENLAMVIEC_NHANVIEN] FOREIGN KEY([IDnv])
REFERENCES [dbo].[NHANVIEN] ([IDnv])
GO
ALTER TABLE [dbo].[NHANVIENLAMVIEC] CHECK CONSTRAINT [FK_NHANVIENLAMVIEC_NHANVIEN]
GO
ALTER TABLE [dbo].[NHANVIENLAMVIEC]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIENLAMVIEC_PHONGBAN] FOREIGN KEY([IDpb])
REFERENCES [dbo].[PHONGBAN] ([IDpb])
GO
ALTER TABLE [dbo].[NHANVIENLAMVIEC] CHECK CONSTRAINT [FK_NHANVIENLAMVIEC_PHONGBAN]
GO
ALTER TABLE [dbo].[PHIEUHENKHAMLAI]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUHENKHAMLAI_BENHAN] FOREIGN KEY([IDba])
REFERENCES [dbo].[BENHAN] ([IDba])
GO
ALTER TABLE [dbo].[PHIEUHENKHAMLAI] CHECK CONSTRAINT [FK_PHIEUHENKHAMLAI_BENHAN]
GO
ALTER TABLE [dbo].[PHIEUHENKHAMLAI]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUHENKHAMLAI_NHANVIEN] FOREIGN KEY([IDnv])
REFERENCES [dbo].[NHANVIEN] ([IDnv])
GO
ALTER TABLE [dbo].[PHIEUHENKHAMLAI] CHECK CONSTRAINT [FK_PHIEUHENKHAMLAI_NHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUKHAMBENH]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUKHAMBENH_BENHAN] FOREIGN KEY([IDba])
REFERENCES [dbo].[BENHAN] ([IDba])
GO
ALTER TABLE [dbo].[PHIEUKHAMBENH] CHECK CONSTRAINT [FK_PHIEUKHAMBENH_BENHAN]
GO
ALTER TABLE [dbo].[PHIEUKHAMBENH]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUKHAMBENH_NHANVIEN] FOREIGN KEY([IDnv])
REFERENCES [dbo].[NHANVIEN] ([IDnv])
GO
ALTER TABLE [dbo].[PHIEUKHAMBENH] CHECK CONSTRAINT [FK_PHIEUKHAMBENH_NHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUTHANHTOANXNKT]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTHANHTOANXNKT_BENHAN] FOREIGN KEY([IDba])
REFERENCES [dbo].[BENHAN] ([IDba])
GO
ALTER TABLE [dbo].[PHIEUTHANHTOANXNKT] CHECK CONSTRAINT [FK_PHIEUTHANHTOANXNKT_BENHAN]
GO
ALTER TABLE [dbo].[PHIEUTHANHTOANXNKT]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTHANHTOANXNKT_BENHNHANLAMVIEC] FOREIGN KEY([IDbnlv])
REFERENCES [dbo].[BENHNHANLAMVIEC] ([IDbnlv])
GO
ALTER TABLE [dbo].[PHIEUTHANHTOANXNKT] CHECK CONSTRAINT [FK_PHIEUTHANHTOANXNKT_BENHNHANLAMVIEC]
GO
ALTER TABLE [dbo].[PHIEUTHANHTOANXNKT]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTHANHTOANXNKT_DICHVU] FOREIGN KEY([IDdichvu])
REFERENCES [dbo].[DICHVU] ([IDdichvu])
GO
ALTER TABLE [dbo].[PHIEUTHANHTOANXNKT] CHECK CONSTRAINT [FK_PHIEUTHANHTOANXNKT_DICHVU]
GO
ALTER TABLE [dbo].[PHIEUTHANHTOANXNKT]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTHANHTOANXNKT_NHANVIEN] FOREIGN KEY([IDnv])
REFERENCES [dbo].[NHANVIEN] ([IDnv])
GO
ALTER TABLE [dbo].[PHIEUTHANHTOANXNKT] CHECK CONSTRAINT [FK_PHIEUTHANHTOANXNKT_NHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUTHANHTOANXNKT]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTHANHTOANXNKT_NHANVIEN1] FOREIGN KEY([IDnvthungan])
REFERENCES [dbo].[NHANVIEN] ([IDnv])
GO
ALTER TABLE [dbo].[PHIEUTHANHTOANXNKT] CHECK CONSTRAINT [FK_PHIEUTHANHTOANXNKT_NHANVIEN1]
GO
ALTER TABLE [dbo].[PHIEUXETNGHIEM]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUSIEUAM_PHIEUTHANHTOANXNKT] FOREIGN KEY([IDpttxn])
REFERENCES [dbo].[PHIEUTHANHTOANXNKT] ([IDpttxn])
GO
ALTER TABLE [dbo].[PHIEUXETNGHIEM] CHECK CONSTRAINT [FK_PHIEUSIEUAM_PHIEUTHANHTOANXNKT]
GO
ALTER TABLE [dbo].[PHIEUXETNGHIEM]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUXETNGHIEM_BACSY] FOREIGN KEY([IDnv])
REFERENCES [dbo].[NHANVIEN] ([IDnv])
GO
ALTER TABLE [dbo].[PHIEUXETNGHIEM] CHECK CONSTRAINT [FK_PHIEUXETNGHIEM_BACSY]
GO
ALTER TABLE [dbo].[PHIEUXETNGHIEM]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUXETNGHIEM_LOAIPHIEUXETNGHIEM] FOREIGN KEY([IDloai])
REFERENCES [dbo].[LOAIPHIEUXETNGHIEM] ([IDloai])
GO
ALTER TABLE [dbo].[PHIEUXETNGHIEM] CHECK CONSTRAINT [FK_PHIEUXETNGHIEM_LOAIPHIEUXETNGHIEM]
GO
ALTER TABLE [dbo].[PHIEUXETNGHIEM]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUXETNGHIEM_PHONGBAN] FOREIGN KEY([IDpb])
REFERENCES [dbo].[PHONGBAN] ([IDpb])
GO
ALTER TABLE [dbo].[PHIEUXETNGHIEM] CHECK CONSTRAINT [FK_PHIEUXETNGHIEM_PHONGBAN]
GO
ALTER TABLE [dbo].[PHONGBAN]  WITH CHECK ADD  CONSTRAINT [FK_PHONGBAN_KHOA] FOREIGN KEY([IDkhoa])
REFERENCES [dbo].[KHOA] ([IDkhoa])
GO
ALTER TABLE [dbo].[PHONGBAN] CHECK CONSTRAINT [FK_PHONGBAN_KHOA]
GO
ALTER TABLE [dbo].[PHONGBAN]  WITH CHECK ADD  CONSTRAINT [FK_PHONGBAN_PHONGBAN] FOREIGN KEY([IDpbCha])
REFERENCES [dbo].[PHONGBAN] ([IDpb])
GO
ALTER TABLE [dbo].[PHONGBAN] CHECK CONSTRAINT [FK_PHONGBAN_PHONGBAN]
GO
ALTER TABLE [dbo].[PHONGBANDICHVU]  WITH CHECK ADD  CONSTRAINT [FK_PHONGBANDICHVU_DICHVU] FOREIGN KEY([IDdichvu])
REFERENCES [dbo].[DICHVU] ([IDdichvu])
GO
ALTER TABLE [dbo].[PHONGBANDICHVU] CHECK CONSTRAINT [FK_PHONGBANDICHVU_DICHVU]
GO
ALTER TABLE [dbo].[PHONGBANDICHVU]  WITH CHECK ADD  CONSTRAINT [FK_PHONGBANDICHVU_PHONGBAN] FOREIGN KEY([IDpb])
REFERENCES [dbo].[PHONGBAN] ([IDpb])
GO
ALTER TABLE [dbo].[PHONGBANDICHVU] CHECK CONSTRAINT [FK_PHONGBANDICHVU_PHONGBAN]
GO
ALTER TABLE [dbo].[TAIKHOAN]  WITH CHECK ADD  CONSTRAINT [FK_TAIKHOAN_NHANVIEN] FOREIGN KEY([IDnv])
REFERENCES [dbo].[NHANVIEN] ([IDnv])
GO
ALTER TABLE [dbo].[TAIKHOAN] CHECK CONSTRAINT [FK_TAIKHOAN_NHANVIEN]
GO
ALTER TABLE [dbo].[TAIKHOAN]  WITH CHECK ADD  CONSTRAINT [FK_TAIKHOAN_PHANQUYEN] FOREIGN KEY([IDquyen])
REFERENCES [dbo].[PHANQUYEN] ([IDquyen])
GO
ALTER TABLE [dbo].[TAIKHOAN] CHECK CONSTRAINT [FK_TAIKHOAN_PHANQUYEN]
GO
/****** Object:  StoredProcedure [dbo].[danhsachbenhnhancho]    Script Date: 6/29/2019 11:40:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[danhsachbenhnhancho] @idpb varchar(20)
as
begin


SELECT        BENHNHAN.IDbn, BENHNHAN.hodem, BENHNHAN.Ten, BENHNHAN.Xaphuong, BENHNHAN.Quanhuyen, BENHNHAN.Tinhthanhpho, case when  BENHNHAN.gioitinh =1 then 'Nam' else N'Nữ' end as gioitinh, BENHNHAN.ngaysinh, BENHNHANLAMVIEC.STT, 
                         BENHNHANLAMVIEC.IDbnlv
FROM            BENHNHAN INNER JOIN
                         BENHNHANLAMVIEC ON BENHNHAN.IDbn = BENHNHANLAMVIEC.IDbn
WHERE        (BENHNHANLAMVIEC.IDtrangthai = '1') AND (BENHNHANLAMVIEC.ngaydk = format(GETDATE(), 'yyyy-MM-dd')) AND (BENHNHANLAMVIEC.IDpb = @idpb) 
end
GO
/****** Object:  StoredProcedure [dbo].[dsbnChokham]    Script Date: 6/29/2019 11:40:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[dsbnChokham] @id varchar(20)
as
begin
declare @date date;
set @date = format (GETDATE(),'yyyy-MM-dd')
select ROW_NUMBER() over (order by BENHNHAN.IDbn) as Stt,PHIEUDANGKYKHAM.IDpdk,BENHNHAN.IDbn,CONCAT_WS(' ',BENHNHAN.hodem,BENHNHAN.Ten) as hovaten ,CONCAT_WS('-', BENHNHAN.Xaphuong,BENHNHAN.Quanhuyen,BENHNHAN.Tinhthanhpho) as quequan,BENHNHAN.Sdt,DIADIEMPB.tendiadiem,PHIEUDANGKYKHAM.STT as STTK,PHIEUDANGKYKHAM.trangthaikham
 from PHIEUDANGKYKHAM,BENHNHAN ,DIADIEMPB
 where PHIEUDANGKYKHAM.IDbn=BENHNHAN.IDbn and PHIEUDANGKYKHAM.IDdiadiem=DIADIEMPB.IDdiadiem and PHIEUDANGKYKHAM.IDdiadiem=@id and PHIEUDANGKYKHAM.trangthaikham = 0 and PHIEUDANGKYKHAM.ngaydk= @date

end
GO
/****** Object:  StoredProcedure [dbo].[filter_BHYT]    Script Date: 6/29/2019 11:40:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[filter_BHYT] @idbn varchar(20)
as
begin
 select * 
 from BHYT
 where IDbn=@idbn and Ngayhethan > GETDATE()
end
GO
/****** Object:  StoredProcedure [dbo].[ktNV_thoigianlam]    Script Date: 6/29/2019 11:40:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ktNV_thoigianlam] @idnv varchar(20)
as
begin

select BOPHAN.IDbp,BOPHAN.IDtruongbp,BOPHAN.Ngaythanhlap,BOPHAN.Tenbophan from NHANVIENLAMVIEC,BOPHAN,PHONGBAN
where Thoigianbatdau<GETDATE() and Thoigianketthuc>GETDATE() and IDnv=@idnv and BOPHAN.IDbp=PHONGBAN.IDbp and NHANVIENLAMVIEC.IDpb=PHONGBAN.IDpb
end
GO
/****** Object:  StoredProcedure [dbo].[nhanviencongviec]    Script Date: 6/29/2019 11:40:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[nhanviencongviec] @id varchar(20)
as
begin
SELECT        NHANVIEN.IDnv, NHANVIEN.Hodem, NHANVIEN.Ten, BOPHAN.Tenbophan, PHONGBAN.Tenpb, DIADIEMPB.tendiadiem, NHANVIENLAMVIEC.Thoigianbatdau, NHANVIENLAMVIEC.Thoigianketthuc
FROM            NHANVIEN INNER JOIN
                         NHANVIENLAMVIEC ON NHANVIEN.IDnv = NHANVIENLAMVIEC.IDnv INNER JOIN
                         DIADIEMPB ON NHANVIENLAMVIEC.IDdiadiem = DIADIEMPB.IDdiadiem INNER JOIN
                         PHONGBAN ON NHANVIENLAMVIEC.IDpb = PHONGBAN.IDpb INNER JOIN
                         BOPHAN ON PHONGBAN.IDbp = BOPHAN.IDbp
WHERE        (NHANVIEN.IDnv = @id)
end
GO
/****** Object:  StoredProcedure [dbo].[search_bhyt]    Script Date: 6/29/2019 11:40:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[search_bhyt] @idBHYT varchar(20) ,@IDbn varchar(20)
as
begin
select IDbhyt
from BHYT 
where IDbhyt like'%'+@idBHYT+'%' and IDbn=@IDbn
end
GO
/****** Object:  StoredProcedure [dbo].[search_bhytBN]    Script Date: 6/29/2019 11:40:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[search_bhytBN] @bhyt nvarchar(20)
as
begin
select ROW_NUMBER()over(order by BENHNHAN.IDbn) as STT,BENHNHAN.IDbn,BENHNHAN.hodem,BENHNHAN.Ten,case when BENHNHAN.gioitinh=1 then 'Nam' else N'Nữ' end gioitinh,BENHNHAN.ngaysinh,BENHNHAN.Sdt,BENHNHAN.Xaphuong,BENHNHAN.Quanhuyen,BENHNHAN.Tinhthanhpho,BENHNHAN.Nghenghiep,BENHNHAN.CMTND,BENHNHAN.Giaykhaisinh
from BENHNHAN,BHYT
where IDbhyt like '%'+@bhyt+'%' and BENHNHAN.IDbn=BHYT.IDbn
end
GO
/****** Object:  StoredProcedure [dbo].[search_cmndBN]    Script Date: 6/29/2019 11:40:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[search_cmndBN] @cmnd varchar(15)
as
begin
select ROW_NUMBER()over(order by BENHNHAN.IDbn) as STT,BENHNHAN.IDbn,BENHNHAN.hodem,BENHNHAN.Ten,case when  BENHNHAN.gioitinh =1 then 'Nam' else N'Nữ' end as gioitinh,BENHNHAN.ngaysinh,BENHNHAN.Sdt,BENHNHAN.Xaphuong,BENHNHAN.Quanhuyen,BENHNHAN.Tinhthanhpho,BENHNHAN.Nghenghiep,BENHNHAN.CMTND,BENHNHAN.Giaykhaisinh
from BENHNHAN
where CMTND  like '%'+ @cmnd+'%'

end
GO
/****** Object:  StoredProcedure [dbo].[search_GCV]    Script Date: 6/29/2019 11:40:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[search_GCV] @txt varchar(20)
as
begin
select IDgcv
from GIAYCHUYENVIEN
where IDgcv like '%'+@txt+'%'

end
GO
/****** Object:  StoredProcedure [dbo].[search_gksBN]    Script Date: 6/29/2019 11:40:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[search_gksBN] @gks varchar(20)
as
begin
select ROW_NUMBER()over(order by BENHNHAN.IDbn)as STT,BENHNHAN.IDbn,BENHNHAN.hodem,BENHNHAN.Ten,case when BENHNHAN.gioitinh=1 then 'Nam' else N'Nữ' end gioitinh,BENHNHAN.ngaysinh,BENHNHAN.Sdt,BENHNHAN.Xaphuong,BENHNHAN.Quanhuyen,BENHNHAN.Tinhthanhpho,BENHNHAN.Nghenghiep,BENHNHAN.CMTND,BENHNHAN.Giaykhaisinh

from BENHNHAN
where Giaykhaisinh  like '%'+ @gks+'%'

end
GO
/****** Object:  StoredProcedure [dbo].[search_PDK]    Script Date: 6/29/2019 11:40:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[search_PDK] @id varchar(20)
as
begin
select ROW_NUMBER()over(order by IDbn) as Stt,* 
from PHIEUDANGKYKHAM
where IDpdk like '%'+@id+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[searchBN_IDbn]    Script Date: 6/29/2019 11:40:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[searchBN_IDbn] @idbn varchar(20)
as
begin
select ROW_NUMBER()over(order by BENHNHAN.IDbn) as STT,BENHNHAN.IDbn,BENHNHAN.hodem,BENHNHAN.Ten,case when  BENHNHAN.gioitinh =1 then 'Nam' else 'Nữ' end as gioitinh,BENHNHAN.ngaysinh,BENHNHAN.Sdt,BENHNHAN.Xaphuong,BENHNHAN.Quanhuyen,BENHNHAN.Tinhthanhpho,BENHNHAN.Nghenghiep,BENHNHAN.CMTND,BENHNHAN.Giaykhaisinh
from BENHNHAN,search_hotenbn
where BENHNHAN.idbn like '%'+@idbn+'%' and BENHNHAN.IDbn=search_hotenbn.IDbn
end
GO
/****** Object:  StoredProcedure [dbo].[searchGCV_idBHYT]    Script Date: 6/29/2019 11:40:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[searchGCV_idBHYT] @idbhyt varchar(20)
as
begin
select *
from GIAYCHUYENVIEN
where IDbhyt = @idbhyt and DATEADD(day,10,Ngaycap) <GETDATE()

end
GO
/****** Object:  StoredProcedure [dbo].[searchIDbn_bnKP]    Script Date: 6/29/2019 11:40:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[searchIDbn_bnKP] @txt varchar(20)
as
begin
select IDbn,CONCAT_WS(' ',BENHNHAN.hodem,BENHNHAN.Ten)as hoten
from BENHNHAN
where BENHNHAN.IDbn like '%'+@txt+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[show_bn]    Script Date: 6/29/2019 11:40:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[show_bn]
as
begin
select ROW_NUMBER()over(order by BENHNHAN.IDbn) as STT,BENHNHAN.IDbn,BENHNHAN.hodem,BENHNHAN.Ten,case when  BENHNHAN.gioitinh =1 then 'Nam' else N'Nữ' end as gioitinh,BENHNHAN.ngaysinh,BENHNHAN.Sdt,BENHNHAN.Xaphuong,BENHNHAN.Quanhuyen,BENHNHAN.Tinhthanhpho,BENHNHAN.Nghenghiep,BENHNHAN.CMTND,BENHNHAN.Giaykhaisinh
from BENHNHAN 
order by IDbn
end
GO
/****** Object:  StoredProcedure [dbo].[show_PDK]    Script Date: 6/29/2019 11:40:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[show_PDK] @id varchar(20)
as
begin
select ROW_NUMBER()over(order by IDbn) as Stt,* 
from PHIEUDANGKYKHAM
where IDbn =@id
end
GO
/****** Object:  StoredProcedure [dbo].[ttsearch_hotenBN]    Script Date: 6/29/2019 11:40:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ttsearch_hotenBN] @ten nvarchar(30)
as
begin
select ROW_NUMBER()over(order by BENHNHAN.IDbn) as STT,BENHNHAN.IDbn,BENHNHAN.hodem,BENHNHAN.Ten,case when  BENHNHAN.gioitinh =1 then 'Nam' else 'Nữ' end as gioitinh,BENHNHAN.ngaysinh,BENHNHAN.Sdt,BENHNHAN.Xaphuong,BENHNHAN.Quanhuyen,BENHNHAN.Tinhthanhpho,BENHNHAN.Nghenghiep,BENHNHAN.CMTND,BENHNHAN.Giaykhaisinh
from BENHNHAN,search_hotenbn
where hovaten like '%'+@ten+'%' and BENHNHAN.IDbn=search_hotenbn.IDbn
end
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "NHANVIEN"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CHUCVU"
            Begin Extent = 
               Top = 17
               Left = 395
               Bottom = 113
               Right = 565
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'DANHSACHNHANVIENVIEW'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'DANHSACHNHANVIENVIEW'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "NHANVIEN"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 6
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'TTnhanvien'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'TTnhanvien'
GO
