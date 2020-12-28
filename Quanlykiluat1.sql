create database Quanlykiluat1
go
use Quanlykiluat1
go
create table Quanly(
	MaQL nchar(10) primary key,
	Matkhau varchar(20),
	Hoten nvarchar(30),
	Chucvu nvarchar(30),
	Capbac nvarchar(20),
	MaDD nchar(10)
);
create table Daidoi(
	MaDD nchar(10) primary key,
	TenDD nvarchar(20)
);
create table Lop(
	Malop nchar(10) primary key,
	Matkhau varchar(20),
	Tenlop nvarchar(30),
	MaDD nchar(10)
);
create table Hocvien(
	MaHV nchar(10) primary key,
	TenHV nvarchar(40),
	GioiTinh nvarchar(5),
	Chucvu nvarchar(30),
	Capbac nvarchar(20),
	Malop nchar(10)
);
create table Phanloaikiluat(
	MaPLKL nchar(10) primary key,
	TenPLKL nvarchar(20)
);
create table Phanloairenluyen(
	MaPLRL nchar(10) primary key,
	TenPLRL nvarchar(20)
);
create table HocVien_Phanloaikiluat(
	Mahv_plkl nchar(10),
	Thoigian datetime,
	MaHV nchar(10),
	MaPLKL nchar(10),
	Capdanhgia nvarchar(20),
	Nguoidanhgia nvarchar(30),
	Diemkiluat int,
	Diemhoctap int,
	Diemloisong int,
	Diemhoatdongdoan int,
	primary key(Mahv_plkl,Thoigian)
);
create table Hocvien_Phanloairenluyen(
	Mahv_plrl nchar(10),
	Thoigian datetime,
	MaHV nchar(10),
	MaPLRL nchar(10),
	MaGS nchar(10),
	Boi float,
	Chaydai float,
	Chayngan float,
	nhayxa float, 
	xa int,
	primary key(Mahv_plrl,Thoigian)
);
create table giamsat(
	Mags nchar(10) primary key,
	Tennguoigiamsat nvarchar(30),
	Chucvu nvarchar(20),
	Capbac nvarchar(15)
);
create table Quychuan(
	MaQCRL nchar(10) primary key,
	Noidung nvarchar(20),
	Donvitinh nvarchar(20),
	Gioi float,
	Kha float,
	Trungbinh float
);
ALTER TABLE dbo.Quanly ADD CONSTRAINT FK_qldd1 FOREIGN KEY (MaDD) REFERENCES dbo.Daidoi(MaDD)
ALTER TABLE dbo.Lop ADD CONSTRAINT FK_lopdd FOREIGN KEY (MaDD) REFERENCES dbo.Daidoi (MaDD)
ALTER TABLE dbo.Hocvien ADD CONSTRAINT FK_HVL FOREIGN KEY (Malop) REFERENCES dbo.Lop (Malop)
ALTER TABLE dbo.HocVien_Phanloaikiluat ADD CONSTRAINT FK_hvplkl FOREIGN KEY (MaHV) REFERENCES dbo.Hocvien (MaHV)
ALTER TABLE dbo.Hocvien_Phanloairenluyen ADD CONSTRAINT FK_hvplrl FOREIGN KEY (MaHV) REFERENCES dbo.Hocvien (MaHV)
ALTER TABLE dbo.HocVien_Phanloaikiluat ADD CONSTRAINT FK_hvkl FOREIGN KEY (MaPLKL) REFERENCES dbo.Phanloaikiluat (MaPLKL)
ALTER TABLE dbo.Hocvien_Phanloairenluyen ADD CONSTRAINT FK_hvrl FOREIGN KEY (MaPLRL) REFERENCES dbo.Phanloairenluyen (MaPLRL)
ALTER TABLE dbo.Hocvien_Phanloairenluyen ADD CONSTRAINT FK_gshv FOREIGN KEY (MaGS) REFERENCES dbo.giamsat (Mags)
go
CREATE procedure spgetMaQl (@MaQL nchar(10))
as
begin
	select * from dbo.Quanly WHERE MaQL= @MaQL
end
GO
insert into Quanly
values('QL0001','123456',N'Nguyễn Quốc Nhân','Dai Truong','Thuong Ta','DD153');
insert into Quanly
values('QL0002','123456',N'Nguyễn Văn Duy','Pho Dai Truong','Thuong Ta','DD153');
select * from Quanly
insert into Daidoi
values('DD153','C153')
insert into Lop
values('LOPCNTT1','123456','CNTT1','DD153')
insert into Lop
values('LOPCNTT2','123456','CNTT2','DD153')
insert into Lop
values('LOPAN3','123456','ANHTTT','DD153')
insert into Lop
values('LOPBD4','123456','BDATTT','DD153')
insert into Hocvien
values('HV0001',N'Nguyễn Vĩnh Hiền',N'Nam',N'Học Viên',N'Thượng Sĩ','LOPCNTT2')
insert into Hocvien
values('HV0002',N'Nguyễn Đình Việt',N'Nam',N'Học Viên',N'Thượng Sĩ','LOPCNTT1')
insert into Hocvien
values('HV0003',N'Nguyễn Mạnh Cường',N'Nam',N'Học Viên',N'Thượng Sĩ','LOPAN3')
insert into Hocvien
values('HV0005',N'Nguyễn Văn Đạt',N'Nam',N'Học Viên',N'Thượng Sĩ','LOPAN3')
insert into Hocvien
values('HV0004',N'Nguyễn Quốc Khánh',N'Nam',N'Học Viên',N'Thượng Sĩ','LOPBD4')
insert into Phanloairenluyen
values('PLRL001','Giỏi')
insert into Phanloairenluyen
values('PLRL002','Khá')
insert into Phanloairenluyen
values('PLRL003','Trung bình')
insert into giamsat
values('GS0001',N'Nguyễn Bá Khải','Tiểu Đoàn Trưởng','Thượng Tá')
go
create proc spgetTableAllLop
as
	begin
		select * from Lop
	end
go
create proc spgetTableHVLop
@Malop nchar(10)
as
	begin
		select hv.MaHV,l.Malop,l.Tenlop,hv.TenHV,hv.GioiTinh,hv.Capbac,hv.Chucvu from Lop as l, Hocvien as hv 
		where l.Malop = @Malop and hv.Malop = l.Malop
	end
go
select * from hocvien
go
create proc insert_HVRL
	@Mahv_plrl nchar(10),
	@Thoigian datetime,
	@MaHV nchar(10),
	@MaPLRL nchar(10),
	@MaGS nchar(10),
	@Boi float,
	@Chaydai float,
	@Chayngan float,
	@nhayxa float, 
	@xa int
as
	begin
		insert into Hocvien_Phanloairenluyen(Mahv_plrl,Thoigian,MaHV,MaPLRL,MaGS,Boi,Chaydai,Chayngan,nhayxa,xa)
		values (@Mahv_plrl,@Thoigian,@MaHV,@MaPLRL,@MaGS,@Boi,@Chaydai,@Chayngan,@nhayxa,@xa)
	end
go

-- tu tang ma doc gia
create function func_NextID(@Mahv_plrl nchar(10),@prefix varchar(3),@size int)
returns varchar(10)
as
	begin
		if(@Mahv_plrl='')
			set @Mahv_plrl=@prefix + REPLICATE(0,@size-LEN(@prefix))
		declare @num_nextUserID int,@nextUserID varchar(6)
		set @Mahv_plrl = LTRIM(RTRIM(@Mahv_plrl))
		set @num_nextUserID = REPLACE(@Mahv_plrl,@prefix,'')+1
		set @size =@size -len(@prefix)
		set @nextUserID = @prefix + REPLICATE(0,@size-LEN(@prefix))
		set @nextUserID = @prefix + RIGHT(REPLICATE(0,@size)+CONVERT(varchar(max),@num_nextUserID),@size)
		return @nextUserID
	end
go
create trigger Tr_NextUserID on [Hocvien_Phanloairenluyen]
for insert
as
	begin
		DECLARE @Mahv_plrl nchar(10)
		set @Mahv_plrl = (select top 1 Mahv_plrl from [Hocvien_Phanloairenluyen] order by Mahv_plrl desc)
		UPDATE [Hocvien_Phanloairenluyen] set Mahv_plrl = dbo.func_NextID(@Mahv_plrl,'ID_',6)
		where Mahv_plrl = ''
	end
go
insert into Hocvien_Phanloairenluyen
values('','1/1/2020','HV0001','PLRL001','GS0001',2,13,13,7,15)
GO
create proc getHocvien
@MaHV nchar(10)
as
	begin
		select hv.MaHV from Hocvien as hv
		where hv.MaHV = @MaHV
	end
go

create function func_NextIDKL(@Mahv_plkl nchar(10),@prefix varchar(3),@size int)
returns varchar(10)
as
	begin
		if(@Mahv_plkl='')
			set @Mahv_plkl=@prefix + REPLICATE(0,@size-LEN(@prefix))
		declare @num_nextUserID int,@nextUserID varchar(6)
		set @Mahv_plkl = LTRIM(RTRIM(@Mahv_plkl))
		set @num_nextUserID = REPLACE(@Mahv_plkl,@prefix,'')+1
		set @size =@size -len(@prefix)
		set @nextUserID = @prefix + REPLICATE(0,@size-LEN(@prefix))
		set @nextUserID = @prefix + RIGHT(REPLICATE(0,@size)+CONVERT(varchar(max),@num_nextUserID),@size)
		return @nextUserID
	end
go
create trigger Tr_NextUserIDKL on [HocVien_Phanloaikiluat]
for insert
as
	begin
		DECLARE @Mahv_plkl nchar(10)
		set @Mahv_plkl = (select top 1 Mahv_plkl from [HocVien_Phanloaikiluat] order by Mahv_plkl desc)
		UPDATE [HocVien_Phanloaikiluat] set Mahv_plkl = dbo.func_NextID(@Mahv_plkl,'ID_',6)
		where Mahv_plkl = ''
	end
go