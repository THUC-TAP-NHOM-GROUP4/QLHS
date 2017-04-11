USE [TTN_QLHS]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Bomon](
	[Ma] [varchar](20) NOT NULL,
	[Ten] [varchar](50) NOT NULL,
	[Diadiem] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[Giaovien]    Script Date: 03/24/2017 5:39:42 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

USE [TTN_QLHS]
GO

/****** Object:  Table [dbo].[Giaovien]    Script Date: 03/28/2017 12:01:43 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Giaovien](
	[Ma] [varchar](20) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[Gioitinh] [bit] NULL,
	[Ngaysinh] [date] NULL,
	[Email] [varchar](50) NULL,
	[Anh] [varchar](30) NULL,
	[Luong] [money] NULL,
	[Nhiemvu] [nvarchar](30) NULL,
	[Vaitro] [text] NULL,
	[Taikhoan] [varchar](20) NULL,
	[Matkhau] [varchar](20) NULL,
	[Hocham] [nvarchar](30) NULL,
	[Hocvi] [nvarchar](30) NULL,
	[sodt] [varchar](20) NULL,
	[diachi] [varchar](20) NULL,
	[Bomonma] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Giaovien]  WITH CHECK ADD  CONSTRAINT [fk_gv] FOREIGN KEY([Bomonma])
REFERENCES [dbo].[Bomon] ([Ma])
GO

ALTER TABLE [dbo].[Giaovien] CHECK CONSTRAINT [fk_gv]
GO



SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Giaovien]  WITH CHECK ADD  CONSTRAINT [fk_gv] FOREIGN KEY([Bomonma])
REFERENCES [dbo].[Bomon] ([Ma])
GO

ALTER TABLE [dbo].[Giaovien] CHECK CONSTRAINT [fk_gv]
GO


/****** Object:  Table [dbo].[Lophocphan]    Script Date: 03/24/2017 5:40:08 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Lophocphan](
	[Ma] varchar(20) primary key  NOT NULL,
	Ten nvarchar(50) NOT NULL,
	[Hocki] char(5) NULL,
	[NgayBD] date NULL,
	[NgayKT] date NULL,
	[Ngaythi] date NULL,
	[Siso] int NULL,
	[Thu] char(10) NULL,
	[Tiet] int NULL,
	[Namhoc] char(5) NULL,
	[Monma] varchar(20) NULL,
	[Giaovienma] varchar(20) NULL,
	FOREIGN KEY(Monma) REFERENCES Monhoc(Ma),
	FOREIGN KEY(Giaovienma) REFERENCES Giaovien(Ma)
	)
SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Lophocphan]  WITH CHECK ADD FOREIGN KEY([Giaovienma])
REFERENCES [dbo].[Giaovien] ([Ma])
GO

ALTER TABLE [dbo].[Lophocphan]  WITH CHECK ADD FOREIGN KEY([Monma])
REFERENCES [dbo].[Monhoc] ([Ma])
GO


/****** Object:  Table [dbo].[Monhoc]    Script Date: 03/24/2017 5:40:39 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Monhoc](
	[Ma] [varchar](20) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[Tinchi] [int] NULL,
	[Sotiet] [int] NULL,
	[Gioithieu] [text] NULL,
	[Hinhthucthi] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


CREATE TABLE Sinhvien
(
Ma VARCHAR(20) PRIMARY KEY NOT NULL,
Ten NVARCHAR(50) NOT NULL,
Gioitinh BIT,
Ngaysinh DATE,
Email NVARCHAR(30),
Doituong NVARCHAR(30),
Sodienthoai NVARCHAR(30),
Lopma VARCHAR(20),
FOREIGN KEY(Lopma) REFERENCES Lophocphan(Ma)
)

-- TẠO BẢNG DIEM
 CREATE TABLE Diem
 (
 Diem1 FLOAT,
 Diem2 FLOAT,
 Diem3 FLOAT,
 Tongket FLOAT,
 Lopma VARCHAR(20),
 Sinhvienma VARCHAR(20),
 FOREIGN KEY(Lopma) REFERENCES Lophocphan(Ma),
 FOREIGN KEY(Sinhvienma) REFERENCES Sinhvien(Ma)
 )



 -- THEM BỘ MÔN

 INSERT INTO Bomon VALUES('BM001',N'Công nghệ thông tin','tầng 19 nhà S1'),
                         ('BM002',N'Ngoại Ngữ','tầng 18 nhà S1'),
						 ('BM003',N'Điện tử y sinh','tầng 17 nhà S1')

  ---MON HỌC
  INSERT INTO Monhoc VALUES ('MH001',N'toán chuyên đề','3','75',N'môn toán',N'thi viết'),
                            ('MH002',N'toán rời rạc','3','75',N'môn toán',N'thi viết')

	---GIÁO VIÊN
	INSERT INTO Giaovien VALUES('GV001',N'Nguyễn Văn A','1','3/3/1987','','','12345','anh1','120','','1234567','',N'thạc sĩ','','','BM001'),
	                           ('GV002',N'Nguyễn Văn B','1','3/3/1987','','','12345','anh1','120','','1234567','',N'thạc sĩ','','','BM003'),
							   ('GV003',N'Nguyễn Văn C','1','3/3/1987','','','12345','anh1','120','','1234567','',N'thạc sĩ','','','BM002')


			-- SINH VIEN
			INSERT INTO Sinhvien VALUES('SV001',N'Nguyễn Văn A','1','','',N'Sinh viên','','L001'),
			                           ('SV002',N'Nguyễn Văn B','1','','',N'Sinh viên','','L002'),
									   ('SV003',N'Nguyễn Văn C','1','','',N'Sinh viên','','L003')


			-- LỚP HỌC PHẦN
			INSERT INTO Lophocphan VALUES('L001',N'Nguyễn Văn A','1','8/15/2016','','','35','2016-2017','4','3-6','MH001','GV001'),
			                             ('L002',N'Nguyễn Văn B','1','8/15/2016','','','35','2016-2017','3','3-6','MH002','GV003'),
										 ('L003',N'Nguyễn Văn C','1','8/15/2016','','','35','2016-2017','2','3-6','MH001','GV002')

				-- ĐIỂM
		INSERT INTO Diem VALUES('6','7','8','','L001','SV001'),
		                       ('6','7','8','','L002','SV002')

