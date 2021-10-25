use master;
drop database QLSach;
create database QLSach;
use QLSach;

--- tạo bảng ---
create table NhaXuatBan(
	MaNXB integer primary key identity(1,1),
	TenNXB nvarchar(60) not null,
    DiaChi nvarchar(120) not null
);

create table TacGia(
    MaTacGia integer primary key identity(1,1),
    TenTacGia nvarchar(60) not null,
    MoTa nvarchar(255)
);

create table TheLoai(
    MaLoai integer primary key identity(1,1),
    TenLoai nvarchar(60) not null unique
);

create table Sach(
    MaSach integer primary key identity(1,1),
    TenSach nvarchar(120) not null,
    MaNXB integer references NhaXuatBan(MaNXB),
    MaTacGia integer references TacGia(MaTacGia),
    GiaBia integer not null,
    GiaBan integer not null,
    NamXuatBan integer not null,
    MaLoai integer references TheLoai(MaLoai)
);

create table NguoiDung(
    MaNguoiDung integer primary key identity(1,1),
    TenNguoiDung nvarchar(120) not null,
    Email nvarchar(50) not null unique,
    NgayDangKy date default(getdate()),
    SDT varchar(13) not null unique,
    DiaChi nvarchar(120)
);

create table Quyen(
    MaQuyen integer primary key identity(1,1),
    TenQuyen varchar(32) not null unique
);

create table DangNhap(
    TenDangNhap char(32) primary key,
    MatKhau varchar(32) not null,
    MaNguoiDung integer references NguoiDung(MaNguoiDung),
    MaQuyen integer references Quyen(MaQuyen)
);

create table DonHang(
    MaDonHang integer primary key identity(1,1),
    MaNguoiDung integer references NguoiDung(MaNguoiDung),
    NgayTao date default(getdate())
);

create table ChiTietDonHang(
    MaDonHang integer references DonHang(MaDonHang),
    MaSach integer references Sach(MaSach),
    SoLuong integer not null,
    primary key (MaDonHang, MaSach)
);


insert into NhaXuatBan(TenNXB, DiaChi) values('Kim Dong', 'Ha noi'); 
insert into tacgia(tentacgia, mota) values('dh ktqd', '');
insert into theloai(tenloai) values('khoa hoc vien tuong');
insert into sach(TenSach, MaNXB, MaTacGia ,GiaBia, GiaBan , NamXuatBan, MaLoai) values ('giao trinh dotnet', 1, 1, 1000000,2000000, 2020, 1);
insert into Quyen(TenQuyen) values('admin');
insert into NguoiDung(TenNguoiDung,Email,SDT,DiaChi) values('admin', 'admin', '0000000000', 'admin');
insert into DangNhap(TenDangNhap, MatKhau, MaNguoiDung, MaQuyen) values ('admin','admin',1,1);
insert into DonHang( MaNguoiDung) values (1);
insert into ChiTietDonHang(MaDonHang,MaSach,SoLuong) values (1,1,10);


select * from NguoiDung;

select * from DangNhap where BINARY_CHECKSUM(TenDangNhap) = BINARY_CHECKSUM('admin') and BINARY_CHECKSUM(MATKHAU) = BINARY_CHECKSUM('{1}');

select * from DangNhap where BINARY_CHECKSUM(TenDangNhap) = BINARY_CHECKSUM('admin') and BINARY_CHECKSUM(MATKHAU) = BINARY_CHECKSUM('admin') and MaQuyen = 1;