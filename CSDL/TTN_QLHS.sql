USE [master]
GO
/****** Object:  Database [TTN_QLHS]    Script Date: 30/05/2017 4:59:19 AM ******/
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
GO
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
/****** Object:  StoredProcedure [dbo].[DSGVTHEOBOMON]    Script Date: 30/05/2017 4:59:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[DSGVTHEOBOMON]
    @bomon NVARCHAR(50)
    AS
	  BEGIN
	    SELECT  *FROM Giaovien gv WHERE Bomonma LIKE '%'+@bomon+'%'
	  END
GO
/****** Object:  StoredProcedure [dbo].[DSGVTHEOGIOITINH]    Script Date: 30/05/2017 4:59:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	     create proc [dbo].[DSGVTHEOGIOITINH]
    @gioitinh NVARCHAR(50)
    AS
	  BEGIN
	    SELECT * FROM Giaovien WHERE Gioitinh LIKE @gioitinh
	  END
GO
/****** Object:  StoredProcedure [dbo].[DSGVTHEOMA]    Script Date: 30/05/2017 4:59:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DSGVTHEOMA]
    @ma VARCHAR(20)
    AS
	  BEGIN
	    SELECT * FROM Giaovien WHERE Ma LIKE '%'+@ma+'%'
	  END
GO
/****** Object:  StoredProcedure [dbo].[DSGVTHEOTEN]    Script Date: 30/05/2017 4:59:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DSGVTHEOTEN]
@ten nvarchar(30)
as
 begin
   select *from Giaovien where ten='%'+@ten+'%'
 end
GO
/****** Object:  StoredProcedure [dbo].[DSHSTHEODANTOC]    Script Date: 30/05/2017 4:59:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[DSHSTHEODANTOC]
    @dantoc NVARCHAR(50)
    AS
	  BEGIN
	    SELECT * FROM Hocsinh WHERE dantoc LIKE dantoc
	  END
GO
/****** Object:  StoredProcedure [dbo].[DSHSTHEODIACHI]    Script Date: 30/05/2017 4:59:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create proc [dbo].[DSHSTHEODIACHI]
    @diachi NVARCHAR(50)
    AS
	  BEGIN
	    SELECT * FROM Hocsinh WHERE Diachi LIKE '%'+@diachi+'%'
	  END
GO
/****** Object:  StoredProcedure [dbo].[DSHSTHEOGIOITINH]    Script Date: 30/05/2017 4:59:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[DSHSTHEOGIOITINH]
    @gioitinh NVARCHAR(50)
    AS
	  BEGIN
	    SELECT * FROM Hocsinh WHERE Gioitinh LIKE @gioitinh
	  END
GO
/****** Object:  StoredProcedure [dbo].[DSHSTHEOLOP]    Script Date: 30/05/2017 4:59:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
   create proc [dbo].[DSHSTHEOLOP]
    @lop NVARCHAR(50)
    AS
	  BEGIN
	    SELECT * FROM Hocsinh WHERE Lopma LIKE @lop
	  END

GO
/****** Object:  StoredProcedure [dbo].[DSHSTHEOMA]    Script Date: 30/05/2017 4:59:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[DSHSTHEOMA]
    @ma VARCHAR(20)
    AS
	  BEGIN
	    SELECT * FROM Hocsinh WHERE Ma LIKE '%'+@ma+'%'
	  END
GO
/****** Object:  StoredProcedure [dbo].[DSHSTHEOTEN]    Script Date: 30/05/2017 4:59:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
   create proc [dbo].[DSHSTHEOTEN]
    @ten NVARCHAR(50)
    AS
	  BEGIN
	    SELECT * FROM Hocsinh WHERE Ten LIKE '%'+@ten+'%'
	  END
GO
/****** Object:  StoredProcedure [dbo].[getListGV]    Script Date: 30/05/2017 4:59:19 AM ******/
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
/****** Object:  StoredProcedure [dbo].[getListSV]    Script Date: 30/05/2017 4:59:19 AM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_insertGV]    Script Date: 30/05/2017 4:59:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_insertGV](@ten nvarchar(50),@gioitinh bit, @ngaysinh date, @email varchar(50), @luong money, @nhiemvu nvarchar(30), @vaitro text , @bomonma varchar(20))
	
as
begin  
	insert into Giaovien(ma, ten, gioitinh, ngaysinh , Email , luong , nhiemvu, Vaitro, Bomonma , trangthai )
	values (dbo.auto_ma_GV(), @ten, @gioitinh, @ngaysinh, @email, @luong , @nhiemvu , @vaitro, @bomonma ,1)
end
GO
/****** Object:  StoredProcedure [dbo].[proc_insertHS]    Script Date: 30/05/2017 4:59:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_insertHS](@ten nvarchar(50),@lopma varchar(20), @ngaysinh date,@gioitinh bit, @dantoc nvarchar(30), @diachi nvarchar(50) , @email nvarchar(30), @sodienthoai nvarchar(30))
	
as
begin  
	insert into Hocsinh(ma, ten,lopma ,ngaysinh,gioitinh, dantoc, diachi, email , sodienthoai,trangthai)
	values (dbo.auto_ma_HS(), @ten,@lopma, @ngaysinh , @gioitinh ,@dantoc, @diachi , @email , @sodienthoai,1)
end
GO
/****** Object:  StoredProcedure [dbo].[updateGV]    Script Date: 30/05/2017 4:59:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[updateGV](@ma varchar(20), @ten nvarchar(50), @gioitinh int, @ngaysinh date, @email varchar(50), 
@luong money, @nhiemvu nvarchar(30), @vaitro text, @bomonma varchar(20) )
as
begin
if(@luong = 0) set @luong = 0
if(@nhiemvu = N'') set @nhiemvu = N'null'
if(@vaitro like '') set @vaitro = N'null'
update Giaovien set Ten = @ten, Gioitinh = @gioitinh, Ngaysinh = @ngaysinh, Email = @email, Luong = @luong, Nhiemvu = @nhiemvu,
Vaitro = @vaitro,
Bomonma = @bomonma where Ma = @ma
end

GO
/****** Object:  StoredProcedure [dbo].[updateHS]    Script Date: 30/05/2017 4:59:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updateHS](@ma varchar(20), @ten nvarchar(50), @gioitinh int, @ngaysinh date, @email varchar(30), 
@dantoc nvarchar(30) , @diachi nvarchar(100), @sodt nvarchar(30),@lopma varchar(20) )
as
begin
if(@email like '') SET @email = 'null' 
if(@sodt = '') set @sodt = N'0'
if(@lopma = '') set @lopma = 'L001'
if(@dantoc = '') set @dantoc = N'Sinh viên'
update hocsinh set Ten = @ten, Gioitinh = @gioitinh, Ngaysinh = @ngaysinh, Email = @email, Dantoc = @dantoc, 
Sodienthoai = @sodt, Lopma = @lopma where Ma = @ma
end

GO
/****** Object:  UserDefinedFunction [dbo].[auto_ma_GV]    Script Date: 30/05/2017 4:59:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
/****** Object:  UserDefinedFunction [dbo].[auto_ma_HS]    Script Date: 30/05/2017 4:59:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
GO
/****** Object:  Table [dbo].[Bomon]    Script Date: 30/05/2017 4:59:19 AM ******/
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
/****** Object:  Table [dbo].[Diem]    Script Date: 30/05/2017 4:59:19 AM ******/
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
/****** Object:  Table [dbo].[Giaovien]    Script Date: 30/05/2017 4:59:19 AM ******/
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
/****** Object:  Table [dbo].[Hocsinh]    Script Date: 30/05/2017 4:59:19 AM ******/
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
	[trangthai] [bit] NULL,
 CONSTRAINT [PK__Hocsinh__3214CC9F37CAA671] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Lophocphan]    Script Date: 30/05/2017 4:59:19 AM ******/
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
/****** Object:  Table [dbo].[Monhoc]    Script Date: 30/05/2017 4:59:19 AM ******/
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
