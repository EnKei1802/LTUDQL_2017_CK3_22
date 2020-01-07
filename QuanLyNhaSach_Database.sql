create database QuanLyNhaSach
go
use QuanLyNhaSach
go
create table SACH
(
	MaSach varchar(10) primary key,
	TenSach nvarchar(30),
	TacGia nvarchar(30),
	TheLoai nvarchar(30),
	SoLuongTon int ,
	DonGiaBanCuaDauSach float
)

create table KHACHHANG
(
	MaKhachHang varchar(10) primary key,
	HoTen nvarchar(30),
	DiaChi nvarchar(30),
	DienThoai nvarchar(30),
	Email varchar(30) ,
	TienNo float
)
create table PHIEUNHAP
(
	MaPhieuNhap varchar(10) primary key,
	NgayNhap smalldatetime,
)
create table CHITIETPHIEUNHAP
(
	MaChiTietPhieuNhap varchar(10) primary key,
	MaSach varchar(10),
	MaPhieuNhap varchar(10),
	SoLuongNhap int
	constraint fk_CHITIETPHIEUNHAP_SACH foreign key(MaSach) references SACH(MaSach),
	constraint fk_CHITIETPHIEUNHAP_PHIEUNHAP foreign key(MaPhieuNhap) references PHIEUNHAP(MaPhieuNhap)
)
create table BAOCAOCONGNO
(
	MaBaoCaoCongNo varchar(10) primary key,
	Thang int
)
create table CHITIETBAOCAOCONGNO
(
	MaBaoCaoCTCongNo varchar(10) primary key,
	MaBCCongNo  varchar(10),
	MaKhachHang varchar(10),
	NoDau float,
	PhatSinh float ,
	NoCuoi float
	constraint fk_CHITIETBAOCAOCONGNO_KHACHHANG foreign key(MaKhachHang) references KHACHHANG(MaKhachHang),
	constraint fk_CHITIETBAOCAOCONGNO_BAOCAOCONGNO foreign key(MaBCCongNo) references BAOCAOCONGNO(MaBaoCaoCongNo)
)
create table HOADONBANSACH
(
	MaHoaDon varchar(10) primary key,
	MaKhachHang varchar(10),
	NgayLapHoaHon smalldatetime ,
	constraint fk_HOADONBANSACH_KHACHHANG foreign key(MaKhachHang) references KHACHHANG(MaKhachHang)
)
create table CHITIETHOADONBS
(
	MaCTHoaDon varchar(10) primary key,
	MaSach varchar(10),
	MaHoaDon varchar(10),
	SoLuongBan int ,
	DonGiaBanCuaHoaDon float
	constraint fk_CHITIETHOADONBS_SACH foreign key(MaSach) references SACH(MaSach),
	constraint fk_CHITIETHOADONBS_HOADONBANSACH foreign key(MaHoaDon) references HOADONBANSACH(MaHoaDon) 
)

create table PHIEUTHUTIEN
(
	MaPhieuThuTien varchar(10) primary key,
	MaKhachHang varchar(10),
	NgayThuTien smalldatetime ,
	SoTienThu float
	constraint fk_PHIEUTHUTIEN_KHACHHANG foreign key(MaKhachHang) references KHACHHANG(MaKhachHang)
)
create table BAOCAOTON
 (
	MaBaoCaoTon varchar(10) primary key,
	Thang int
 )
create table CHITIETBAOCAOTON
(
	MaCTBaoCaoTon varchar(10) primary key,
	MaSach varchar(10),
	MaBaoCaoTOn varchar(10),
	TonDau float,
	PhatSinh float,
	TonCuoi float
	constraint fk_CHITITETBAOCAOTON_SACH foreign key(MaSach) references SACH(MASACH),
	constraint fk_CHITIETBAOCAOTON_BAOCAOTON foreign key(MaBaoCaoTon) references BAOCAOTON(MaBaoCaoTon)
)
 create table THAMSO
 (
	SoLuongNhapItNhat int,
	SoLuongTonItNhatDeNhap int,
	SoTienKhachHangNoToiDa float,
	SoLuongTonToiDaDeBan int
 )
 select * from KHACHHANG