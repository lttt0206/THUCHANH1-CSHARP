create table Phim (
	idphim int IDENTITY(1,1) not null PRIMARY KEY,
	tenphimtv nvarchar(200),
	tenphimta nvarchar(200),
	danhmuc nvarchar(200),
	theloai nvarchar(200),
	daodien nvarchar(200),
	dienvien nvarchar(200),
	phathanh int,
	thoiluong int,
	mota nvarchar(300),
	sao int,
	luotxem int,
	yeuthich int
)

---
create table TaiKhoan (
	idtaikhoan int IDENTITY(1,1) not null PRIMARY KEY,
	tentk varchar(200),
	matkhau varchar(10)
)

-----

create table DaXem (
	idtaikhoan int not null,
	idphim int not null,
	sogiay int
)

ALTER TABLE DaXem ADD CONSTRAINT FK_DX_Phim FOREIGN KEY (idphim) REFERENCES Phim(idphim);
ALTER TABLE DaXem ADD CONSTRAINT FK_DX_TK FOREIGN KEY (idtaikhoan) REFERENCES TaiKhoan(idtaikhoan);

----
create table YeuThich (
	idtaikhoan int not null,
	idphim int not null
)

ALTER TABLE YeuThich ADD CONSTRAINT FK_YT_Phim FOREIGN KEY (idphim) REFERENCES Phim(idphim);
ALTER TABLE YeuThich ADD CONSTRAINT FK_YT_TK FOREIGN KEY (idtaikhoan) REFERENCES TaiKhoan(idtaikhoan);

---
create table DanhGia (
	idtaikhoan int not null,
	idphim int not null,
	sosao int,
	noidung nvarchar(300)
)

ALTER TABLE DanhGia ADD CONSTRAINT FK_DG_Phim FOREIGN KEY (idphim) REFERENCES Phim(idphim);
ALTER TABLE DanhGia ADD CONSTRAINT FK_DG_TK FOREIGN KEY (idtaikhoan) REFERENCES TaiKhoan(idtaikhoan);