USE [TTN_QLHS]
GO
/****** Object:  Database [TTN_QLHS]    Script Date: 04/19/2017 5:52:42 PM ******/
CREATE DATABASE [TTN_QLHS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TTN_QLHS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\TTN_QLHS.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TTN_QLHS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\TTN_QLHS_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TTN_QLHS] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TTN_QLHS].[dbo].[sp_fulltext_database] @action = 'enable'
end
Go
ALTER DATABASE [TTN_QLHS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TTN_QLHS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TTN_QLHS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TTN_QLHS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TTN_QLHS] SET ARITHABORT OFF 
GO
ALTER DATABASE [TTN_QLHS] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [TTN_QLHS] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [TTN_QLHS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TTN_QLHS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TTN_QLHS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TTN_QLHS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TTN_QLHS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TTN_QLHS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TTN_QLHS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TTN_QLHS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TTN_QLHS] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TTN_QLHS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TTN_QLHS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TTN_QLHS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TTN_QLHS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TTN_QLHS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TTN_QLHS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TTN_QLHS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TTN_QLHS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TTN_QLHS] SET  MULTI_USER 
GO
ALTER DATABASE [TTN_QLHS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TTN_QLHS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TTN_QLHS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TTN_QLHS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [TTN_QLHS]
GO
/****** Object:  StoredProcedure [dbo].[getListGV]    Script Date: 04/19/2017 5:52:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[getListGV]
  @ten NVARCHAR(30)
AS 
   BEGIN
   IF EXISTS(
     SELECT  *
	 FROM    Giaovien 
	 WHERE   Ten LIKE '%'+@ten+'%'
	 )
	 BEGIN
	    SELECT *
		FROM   DBO.Giaovien
	 END
   ELSE
      BEGIN
	      SELECT 0;
		  RETURN ;
	  END
   END

GO
/****** Object:  StoredProcedure [dbo].[getListSV]    Script Date: 04/19/2017 5:52:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getListSV]
  @TEN NVARCHAR(30)
AS
  BEGIN 
  IF EXISTS(
      SELECT   *
	  FROM     Sinhvien
	  WHERE    Ten LIKE '%'+@ten+'%'
	  )
	  BEGIN 
	     SELECT *
		 FROM   DBO.Sinhvien
	  END

	  ELSE 
	     BEGIN 
		      SELECT 0;
			  RETURN ;
		 END
  END

GO
/****** Object:  Table [dbo].[Bomon]    Script Date: 04/19/2017 5:52:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Bomon](
	[Ma] [varchar](20) NOT NULL,
	[Ten] [varchar](50) NOT NULL,
	[Diadiem] [varchar](200) NOT NULL,
 CONSTRAINT [PK__Bomon__3214CC9F1DF05710] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Diem]    Script Date: 04/19/2017 5:52:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Diem](
	[Diem1] [float] NOT NULL,
	[Diem2] [float] NOT NULL,
	[Diem3] [float] NOT NULL,
	[Tongket] [float] NOT NULL,
	[Lopma] [varchar](20) NOT NULL,
	[Hocsinhma] [varchar](20) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Giaovien]    Script Date: 04/19/2017 5:52:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Giaovien](
	[Ma] [varchar](20) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[Gioitinh] [bit] NOT NULL,
	[Ngaysinh] [date] NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Anh] [varchar](30) NOT NULL,
	[Luong] [money] NOT NULL,
	[Nhiemvu] [nvarchar](30) NOT NULL,
	[Vaitro] [text] NOT NULL,
	[Bomonma] [varchar](20) NOT NULL,
	[Trangthai] [bit] NOT NULL,
 CONSTRAINT [PK__Giaovien__3214CC9F25203FEB] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Hocsinh]    Script Date: 04/19/2017 5:52:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Hocsinh](
	[Ma] [varchar](20) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[Lopma] [varchar](20) NOT NULL,
	[Ngaysinh] [date] NOT NULL,
	[Gioitinh] [bit] NOT NULL,
	[dantoc] [nvarchar](30) NOT NULL,
	[Diachi] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](30) NOT NULL,
	[Sodienthoai] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK__Hocsinh__3214CC9F37CAA671] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Lophocphan]    Script Date: 04/19/2017 5:52:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Lophocphan](
	[Ma] [varchar](20) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[Hocki] [char](5) NOT NULL,
	[NgayBD] [date] NOT NULL,
	[NgayKT] [date] NOT NULL,
	[Ngaythi] [date] NOT NULL,
	[Siso] [int] NOT NULL,
	[Thu] [char](10) NOT NULL,
	[Tiet] [int] NOT NULL,
	[Namhoc] [char](5) NOT NULL,
	[Monma] [varchar](20) NOT NULL,
	[Giaovienma] [varchar](20) NOT NULL,
 CONSTRAINT [PK__Lophocph__3214CC9F27ABCE0A] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Monhoc]    Script Date: 04/19/2017 5:52:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Monhoc](
	[Ma] [varchar](20) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[Tinchi] [int] NOT NULL,
	[Sotiet] [int] NOT NULL,
	[Gioithieu] [text] NOT NULL,
	[Hinhthucthi] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK__Monhoc__3214CC9F8E6745DA] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Bomon] ([Ma], [Ten], [Diadiem]) VALUES (N'BM001', N'Công ngh? thông tin', N'T?ng 19 nhà S1')
INSERT [dbo].[Bomon] ([Ma], [Ten], [Diadiem]) VALUES (N'BM002', N'Công ngh? thông tin', N'T?ng 19 nhà S1')
INSERT [dbo].[Bomon] ([Ma], [Ten], [Diadiem]) VALUES (N'BM003', N'Công ngh? thông tin', N'T?ng 19 nhà S1')
INSERT [dbo].[Bomon] ([Ma], [Ten], [Diadiem]) VALUES (N'BM004', N'Công ngh? thông tin', N'T?ng 19 nhà S1')
INSERT [dbo].[Diem] ([Diem1], [Diem2], [Diem3], [Tongket], [Lopma], [Hocsinhma]) VALUES (7, 8, 9, 24, N'L001', N'SV001')
INSERT [dbo].[Diem] ([Diem1], [Diem2], [Diem3], [Tongket], [Lopma], [Hocsinhma]) VALUES (7, 8, 9, 24, N'L002', N'SV002')
INSERT [dbo].[Diem] ([Diem1], [Diem2], [Diem3], [Tongket], [Lopma], [Hocsinhma]) VALUES (7, 8, 9, 24, N'L003', N'SV003')
INSERT [dbo].[Diem] ([Diem1], [Diem2], [Diem3], [Tongket], [Lopma], [Hocsinhma]) VALUES (7, 8, 9, 24, N'L004', N'SV001')
INSERT [dbo].[Giaovien] ([Ma], [Ten], [Gioitinh], [Ngaysinh], [Email], [Anh], [Luong], [Nhiemvu], [Vaitro], [Bomonma], [Trangthai]) VALUES (N'GV001', N'Nguyen Van A', 1, CAST(N'1987-04-03' AS Date), N'NVA@gmail.com', N'anh1', 120.0000, N'giảng dạy', N'giáo viên', N'BM001', 1)
INSERT [dbo].[Giaovien] ([Ma], [Ten], [Gioitinh], [Ngaysinh], [Email], [Anh], [Luong], [Nhiemvu], [Vaitro], [Bomonma], [Trangthai]) VALUES (N'GV002', N'Nguyen Van B', 1, CAST(N'1987-04-03' AS Date), N'NVA@gmail.com', N'anh1', 120.0000, N'giảng dạy', N'giáo viên', N'BM002', 0)
INSERT [dbo].[Giaovien] ([Ma], [Ten], [Gioitinh], [Ngaysinh], [Email], [Anh], [Luong], [Nhiemvu], [Vaitro], [Bomonma], [Trangthai]) VALUES (N'GV003', N'Nguyen Van C', 1, CAST(N'1987-04-03' AS Date), N'NVA@gmail.com', N'anh1', 120.0000, N'giảng dạy', N'giáo viên', N'BM003', 1)
INSERT [dbo].[Giaovien] ([Ma], [Ten], [Gioitinh], [Ngaysinh], [Email], [Anh], [Luong], [Nhiemvu], [Vaitro], [Bomonma], [Trangthai]) VALUES (N'GV004', N'Nguyen Van D', 1, CAST(N'1987-04-03' AS Date), N'NVA@gmail.com', N'anh1', 120.0000, N'giảng dạy', N'giáo viên', N'BM004', 1)
INSERT [dbo].[Hocsinh] ([Ma], [Ten], [Lopma], [Ngaysinh], [Gioitinh], [dantoc], [Diachi], [Email], [Sodienthoai]) VALUES (N'SV001', N'Nguyễn Văn A', N'L001', CAST(N'1997-04-03' AS Date), 1, N'Kinh', N'Sinh viên', N'NVA@gmail.com', N'012345322')
INSERT [dbo].[Hocsinh] ([Ma], [Ten], [Lopma], [Ngaysinh], [Gioitinh], [dantoc], [Diachi], [Email], [Sodienthoai]) VALUES (N'SV002', N'Nguyễn Văn B', N'L002', CAST(N'1997-04-03' AS Date), 1, N'Kinh', N'abc', N'NVA@gmail.com', N'012345322')
INSERT [dbo].[Hocsinh] ([Ma], [Ten], [Lopma], [Ngaysinh], [Gioitinh], [dantoc], [Diachi], [Email], [Sodienthoai]) VALUES (N'SV003', N'Nguyễn Văn C', N'L003', CAST(N'1997-04-03' AS Date), 1, N'Kinh', N'abc', N'NVA@gmail.com', N'012345322')
INSERT [dbo].[Hocsinh] ([Ma], [Ten], [Lopma], [Ngaysinh], [Gioitinh], [dantoc], [Diachi], [Email], [Sodienthoai]) VALUES (N'SV004', N'Nguyễn Văn D', N'L004', CAST(N'1997-04-03' AS Date), 1, N'Kinh', N'abc', N'NVA@gmail.com', N'012345322')
INSERT [dbo].[Lophocphan] ([Ma], [Ten], [Hocki], [NgayBD], [NgayKT], [Ngaythi], [Siso], [Thu], [Tiet], [Namhoc], [Monma], [Giaovienma]) VALUES (N'L001', N'Nguyễn Văn A', N'1    ', CAST(N'2016-08-15' AS Date), CAST(N'2017-06-01' AS Date), CAST(N'2017-05-03' AS Date), 34, N'2016-2017 ', 3, N'4-6  ', N'MH001', N'GV001')
INSERT [dbo].[Lophocphan] ([Ma], [Ten], [Hocki], [NgayBD], [NgayKT], [Ngaythi], [Siso], [Thu], [Tiet], [Namhoc], [Monma], [Giaovienma]) VALUES (N'L002', N'Nguyễn Văn B', N'1    ', CAST(N'2016-08-15' AS Date), CAST(N'2017-06-01' AS Date), CAST(N'2017-05-03' AS Date), 34, N'2016-2017 ', 3, N'4-6  ', N'MH002', N'GV002')
INSERT [dbo].[Lophocphan] ([Ma], [Ten], [Hocki], [NgayBD], [NgayKT], [Ngaythi], [Siso], [Thu], [Tiet], [Namhoc], [Monma], [Giaovienma]) VALUES (N'L003', N'Nguyễn Văn C', N'1    ', CAST(N'2016-08-15' AS Date), CAST(N'2017-06-01' AS Date), CAST(N'2017-05-03' AS Date), 34, N'2016-2017 ', 3, N'4-6  ', N'MH003', N'GV003')
INSERT [dbo].[Lophocphan] ([Ma], [Ten], [Hocki], [NgayBD], [NgayKT], [Ngaythi], [Siso], [Thu], [Tiet], [Namhoc], [Monma], [Giaovienma]) VALUES (N'L004', N'Nguyễn Văn D', N'1    ', CAST(N'2016-08-15' AS Date), CAST(N'2017-06-01' AS Date), CAST(N'2017-05-03' AS Date), 34, N'2016-2017 ', 3, N'4-6  ', N'MH004', N'GV004')
INSERT [dbo].[Monhoc] ([Ma], [Ten], [Tinchi], [Sotiet], [Gioithieu], [Hinhthucthi]) VALUES (N'MH001', N'Công nghệ Web', 3, 75, N'Công ngh? Web', N'Vấn đáp')
INSERT [dbo].[Monhoc] ([Ma], [Ten], [Tinchi], [Sotiet], [Gioithieu], [Hinhthucthi]) VALUES (N'MH002', N'Công nghệ phần mềm', 3, 75, N'Công ngh? ph?n m?m', N'Vấn đáp')
INSERT [dbo].[Monhoc] ([Ma], [Ten], [Tinchi], [Sotiet], [Gioithieu], [Hinhthucthi]) VALUES (N'MH003', N'Xây dựng và thiết kế', 3, 75, N'Xây d?ng và thi?t k?', N'Vấn đáp')
INSERT [dbo].[Monhoc] ([Ma], [Ten], [Tinchi], [Sotiet], [Gioithieu], [Hinhthucthi]) VALUES (N'MH004', N'Đường lối quân sự Đảng', 3, 75, N'Ðu?ng l?i quân s? Ð?ng', N'Vấn đáp')
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD  CONSTRAINT [FK__Diem__Hocsinhma__5CA1C101] FOREIGN KEY([Hocsinhma])
REFERENCES [dbo].[Hocsinh] ([Ma])
GO
ALTER TABLE [dbo].[Diem] CHECK CONSTRAINT [FK__Diem__Hocsinhma__5CA1C101]
GO
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD  CONSTRAINT [FK__Diem__Lopma__5BAD9CC8] FOREIGN KEY([Lopma])
REFERENCES [dbo].[Lophocphan] ([Ma])
GO
ALTER TABLE [dbo].[Diem] CHECK CONSTRAINT [FK__Diem__Lopma__5BAD9CC8]
GO
ALTER TABLE [dbo].[Giaovien]  WITH CHECK ADD  CONSTRAINT [fk_gv] FOREIGN KEY([Bomonma])
REFERENCES [dbo].[Bomon] ([Ma])
GO
ALTER TABLE [dbo].[Giaovien] CHECK CONSTRAINT [fk_gv]
GO
ALTER TABLE [dbo].[Hocsinh]  WITH CHECK ADD  CONSTRAINT [FK__Hocsinh__Lopma__59C55456] FOREIGN KEY([Lopma])
REFERENCES [dbo].[Lophocphan] ([Ma])
GO
ALTER TABLE [dbo].[Hocsinh] CHECK CONSTRAINT [FK__Hocsinh__Lopma__59C55456]
GO
ALTER TABLE [dbo].[Lophocphan]  WITH CHECK ADD  CONSTRAINT [FK__Lophocpha__Giaov__56E8E7AB] FOREIGN KEY([Giaovienma])
REFERENCES [dbo].[Giaovien] ([Ma])
GO
ALTER TABLE [dbo].[Lophocphan] CHECK CONSTRAINT [FK__Lophocpha__Giaov__56E8E7AB]
GO
ALTER TABLE [dbo].[Lophocphan]  WITH CHECK ADD  CONSTRAINT [FK__Lophocpha__Monma__55F4C372] FOREIGN KEY([Monma])
REFERENCES [dbo].[Monhoc] ([Ma])
GO
ALTER TABLE [dbo].[Lophocphan] CHECK CONSTRAINT [FK__Lophocpha__Monma__55F4C372]
GO
USE [master]
GO
ALTER DATABASE [TTN_QLHS] SET  READ_WRITE 
GO


create function [dbo].[auto_ma_HS]() returns varchar(6)
as
begin
	declare @ma varchar(20)
	if(select count(ma) from Hocsinh)=0
	set @ma='0'
	else 
		select @ma=max(right(ma,3)) from Hocsinh
		set @ma=case
		when
		@ma>=0 and @ma<9 then 'SV000'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=9 and @ma<99then 'SV00'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=99 and @ma<999then 'SV0'+CONVERT(char,CONVERT(int,@ma)+1)
		end
		return @ma
end

create function [dbo].[auto_ma_GV]() returns varchar(6)
as
begin
	declare @ma varchar(20)
	if(select count(ma) from Giaovien)=0
	set @ma='0'
	else 
		select @ma=max(right(ma,3)) from GiaoVien
		set @ma=case
		when
		@ma>=0 and @ma<9 then 'GV000'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=9 and @ma<99then 'GV00'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=99 and @ma<999then 'GV0'+CONVERT(char,CONVERT(int,@ma)+1)
		end
		return @ma
end



create proc [dbo].[proc_insertHS](@ten nvarchar(50),@lopma varchar(20), @ngaysinh date,@gioitinh bit, @dantoc nvarchar(30), @diachi nvarchar(50) , @email nvarchar(30), @sodienthoai nvarchar(30))
	
as
begin  
	insert into Hocsinh(ma, ten,lopma ,ngaysinh,gioitinh, dantoc, diachi, email , sodienthoai)
	values (dbo.auto_ma_HS(), @ten,@lopma, @ngaysinh , @gioitinh ,@dantoc, @diachi , @email , @sodienthoai )
end
go

create proc [dbo].[proc_insertGV](@ten nvarchar(50),@gioitinh bit, @ngaysinh date, @email varchar(50),@anh varchar(30), @luong money, @nhiemvu nvarchar(30), @vaitro text , @bomonma varchar(20), @trangthai bit)
	
as
begin  
	insert into Giaovien(ma, ten, gioitinh, ngaysinh , Email,anh , luong , nhiemvu, Vaitro, Bomonma , trangthai )
	values (dbo.auto_ma_GV(), @ten, @gioitinh, @ngaysinh, @email, @anh , @luong , @nhiemvu , @vaitro, @bomonma , @trangthai)
end
go


CREATE proc [dbo].[updateGV](@ma varchar(20), @ten nvarchar(50), @gioitinh int, @ngaysinh date, @email varchar(50), 
@luong money, @nhiemvu nvarchar(30), @vaitro text, 
 @diachi nvarchar(20), @bomonma varchar(20) )
as
begin
if(@bomonma like '') SET @bomonma = 'BM0001' 
if(@diachi = '') set @diachi = N'null'
if(@luong = 0) set @luong = 0
if(@nhiemvu = N'') set @nhiemvu = N'null'
if(@vaitro like '') set @vaitro = N'null'
update Giaovien set Ten = @ten, Gioitinh = @gioitinh, Ngaysinh = @ngaysinh, Email = @email, Luong = @luong, Nhiemvu = @nhiemvu,
Vaitro = @vaitro,
Bomonma = @bomonma where Ma = @ma
end
GO
-----------------------
create proc [dbo].[updateHS](@ma varchar(20), @ten nvarchar(50), @gioitinh int, @ngaysinh date, @email varchar(30), 
@doituong nvarchar(30) , @sodt nvarchar(30),@lopma varchar(20) )
as
begin
if(@email like '') SET @email = 'null' 
if(@sodt = '') set @sodt = N'0'
if(@lopma = '') set @lopma = 'L001'
if(@doituong = '') set @doituong = N'Sinh viên'
update Sinhvien set Ten = @ten, Gioitinh = @gioitinh, Ngaysinh = @ngaysinh, Email = @email, Doituong = @doituong, 
Sodienthoai = @sodt, Lopma = @lopma where Ma = @ma
end
GO