create table DaXem (
    iddaxem int IDENTITY(1,1) not null PRIMARY KEY,
	idphim int not null,
	sogiay int
)
ALTER TABLE DaXem ADD CONSTRAINT FK_DX_Phim FOREIGN KEY (idphim) REFERENCES Phim(idphim);

create table YeuThich (
	idyeuthich int IDENTITY(1,1) not null PRIMARY KEY,
	idphim int not null
)

ALTER TABLE YeuThich ADD CONSTRAINT FK_YT_Phim FOREIGN KEY (idphim) REFERENCES Phim(idphim);