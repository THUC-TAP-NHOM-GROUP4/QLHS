USE [TTN_QLHS]
GO

-- TAO BANG BO MON
CREATE TABLE Bomon
(
Ma VARCHAR(20) PRIMARY KEY NOT NULL,
Ten VARCHAR(50) NOT NULL,
Diadiem VARCHAR(200)
)

-- TAO BANG MON HOC
CREATE TABLE Monhoc
(
Ma VARCHAR(20) PRIMARY KEY NOT NULL,
Ten NVARCHAR(50) NOT NULL,
Tinchi INT ,
Sotiet INT,
Gioithieu TEXT,
Hinhthucthi NVARCHAR(20)
)

-- TAO BANG GIAO VIEN

CREATE TABLE Giaovien
(
Ma VARCHAR(20) PRIMARY KEY,
Ten NVARCHAR(50) NOT NULL,
Gioitinh BIT,
Ngaysinh DATE,
Email VARCHAR(50),
Anh VARCHAR(30),
Luong MONEY,
Nhiemvu NVARCHAR(30),
Vaitro TEXT,
Bomonma VARCHAR(20),
Trangthai bit,
CONSTRAINT fk_gv FOREIGN KEY(Bomonma) REFERENCES Bomon(Ma)
)

-- TAOJ BANGR LOP HOC PHAN
CREATE TABLE Lophocphan
(
Ma VARCHAR(20) PRIMARY KEY NOT NULL,
Ten NVARCHAR(50) NOT NULL,
Hocki CHAR(5),
NgayBD DATE,
NgayKT DATE,
Ngaythi DATE,
Siso INT,
Thu CHAR(10),
Tiet INT ,
Namhoc CHAR(5),
Monma VARCHAR(20),
Giaovienma VARCHAR(20),
FOREIGN KEY(Monma) REFERENCES Monhoc(Ma),
FOREIGN KEY(Giaovienma) REFERENCES Giaovien(Ma)
)

-- TAOJ BANG HocSinh
CREATE TABLE Hocsinh
(
Ma varchar(20) PRIMARY KEY NOT NULL,
Ten NVARCHAR(50) NOT NULL,
Lopma VARCHAR(20),
Ngaysinh DATE,
Gioitinh BIT,
dantoc NVARCHAR(30),
Diachi nvarchar(50),
Email NVARCHAR(30),
Sodienthoai NVARCHAR(30),

FOREIGN KEY (Lopma) REFERENCES Lophocphan(Ma)

)

-- TOA BANG DIEM
CREATE TABLE Diem
(
Diem1 FLOAT ,
Diem2 FLOAT,
Diem3 FLOAT,
Tongket FLOAT,
Lopma VARCHAR(20),
Hocsinhma VARCHAR(20),
FOREIGN KEY(Lopma) REFERENCES Lophocphan(Ma),
FOREIGN KEY(Hocsinhma) REFERENCES Hocsinh(Ma)
)

-- INSERT INTO
 

 -- BANG BOMON
 INSERT INTO Bomon VALUES('BM001',N'Công nghệ thông tin',N'Tầng 19 nhà S1'),
                         ('BM002',N'Công nghệ thông tin',N'Tầng 19 nhà S1'),
				         ('BM003',N'Công nghệ thông tin',N'Tầng 19 nhà S1'),
				         ('BM004',N'Công nghệ thông tin',N'Tầng 19 nhà S1')

      -- BANG MON HOC
	  INSERT INTO Monhoc VALUES('MH001',N'Công nghệ Web','3','75',N'Công nghệ Web',N'Vấn đáp'),
	                           ('MH002',N'Công nghệ phần mềm','3','75',N'Công nghệ phần mềm',N'Vấn đáp'),
							   ('MH003',N'Xây dựng và thiết kế','3','75',N'Xây dựng và thiết kế',N'Vấn đáp'),
							   ('MH004',N'Đường lối quân sự Đảng','3','75',N'Đường lối quân sự Đảng',N'Vấn đáp')


		-- BANG GIAO VIEN
		INSERT INTO Giaovien VALUES('GV001',N'Nguyen Van A',N'1','4/3/1987','NVA@gmail.com','anh1','120',N'giảng dạy',N'giáo viên','BM001',1),
		                           ('GV002',N'Nguyen Van B',N'1','4/3/1987','NVA@gmail.com','anh1','120',N'giảng dạy',N'giáo viên','BM002',0),
								   ('GV003',N'Nguyen Van C',N'1','4/3/1987','NVA@gmail.com','anh1','120',N'giảng dạy',N'giáo viên','BM003',1),
								   ('GV004',N'Nguyen Van D',N'1','4/3/1987','NVA@gmail.com','anh1','120',N'giảng dạy',N'giáo viên','BM004',1)

		-- BANG LỚP HỌC PHẦN
		INSERT INTO Lophocphan VALUES('L001',N'Nguyễn Văn A','1','8/15/2016','6/1/2017','5/3/2017','34','2016-2017','3','4-6','MH001','GV001'),
		                             ('L002',N'Nguyễn Văn B','1','8/15/2016','6/1/2017','5/3/2017','34','2016-2017','3','4-6','MH002','GV002'),
									 ('L003',N'Nguyễn Văn C','1','8/15/2016','6/1/2017','5/3/2017','34','2016-2017','3','4-6','MH003','GV003'),
									 ('L004',N'Nguyễn Văn D','1','8/15/2016','6/1/2017','5/3/2017','34','2016-2017','3','4-6','MH004','GV004')

		-- BANG SINH VIÊN
		INSERT INTO Hocsinh VALUES('SV001',N'Nguyễn Văn A','1','4/3/1997','kinh','abc','NVA@gmail.com','012345322','L001'),
		                           ('SV002',N'Nguyễn Văn B','1','4/3/1997','kinh','abc','NVA@gmail.com','012345322','L002'),
								   ('SV003',N'Nguyễn Văn C','1','4/3/1997','kinh','abc','NVA@gmail.com','012345322','L003'),
								   ('SV004',N'Nguyễn Văn D','1','4/3/1997','kinh','abc','NVA@gmail.com','012345322','L004')


		-- BẢNG ĐIỂM
		INSERT INTO Diem VALUES('7','8','9','24','L001','SV001'),
		                       ('7','8','9','24','L002','SV002'),
							   ('7','8','9','24','L003','SV003'),
							   ('7','8','9','24','L004','SV001')

create function [dbo].[auto_ma_HS]() returns varchar(6)
as
begin
	declare @ma varchar(20)
	if(select count(ma) from Hocsinh)=0
	set @ma='0'
	else 
		select @ma=max(right(ma,4)) from Hocsinh
		set @ma=case
		when
		@ma>=0 and @ma<9 then 'DK000'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=9 and @ma<99then 'DK00'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=99 and @ma<999then 'DK0'+CONVERT(char,CONVERT(int,@ma)+1)
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
		select @ma=max(right(ma,4)) from Hocsinh
		set @ma=case
		when
		@ma>=0 and @ma<9 then 'DK000'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=9 and @ma<99then 'DK00'+CONVERT(char,CONVERT(int,@ma)+1)
		when @ma>=99 and @ma<999then 'DK0'+CONVERT(char,CONVERT(int,@ma)+1)
		end
		return @ma
end

create proc [dbo].[proc_insertHS](@ten nvarchar(50),@lopma varchar(20), @ngaysinh date,@gioitinh int, @dantoc nvarchar(30), @diachi nvarchar(50))
	
as
begin  
	insert into Hocsinh(ma, ten,lopma, ngaysinh, gioitinh,dantoc, diachi )
	values (dbo.auto_ma_HS(), @ten,@lopma, @ngaysinh, @gioitinh,@dantoc, @diachi )
end
go

create proc [dbo].[proc_insertGV](@ten nvarchar(50),@gioitinh int, @ngaysinh date, @email nvarchar(50), @vaitro text , @bomonma varchar(20) )
	
as
begin  
	insert into Giaovien(ma, ten, gioitinh, ngaysinh , Email, Vaitro, Bomonma )
	values (dbo.auto_ma_HS(), @ten, @gioitinh, @ngaysinh, @email,@vaitro, @bomonma )
end
go

