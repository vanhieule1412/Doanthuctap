CREATE TABLE CTHOADON (Madk varchar(8) NOT NULL, Mahd varchar(10) NOT NULL, Dntt int NOT NULL, Dongia money NOT NULL, Ngaythanhlap datetime NOT NULL, PRIMARY KEY (Madk, Mahd));
CREATE TABLE DIENKE (Madk varchar(8) NOT NULL, Makh varchar(30) NOT NULL, Ngaysx datetime NOT NULL, Ngaylap datetime NOT NULL, Mota nvarchar(100) NOT NULL, Trangthai bit NOT NULL, PRIMARY KEY (Madk));
CREATE TABLE GIADIEN (Mabac int IDENTITY NOT NULL, Tenbac nvarchar(255) NOT NULL, Tusokw int NOT NULL, Densokw int NOT NULL, Dongia money NOT NULL, Ngaythanhlap datetime NOT NULL, PRIMARY KEY (Mabac));
CREATE TABLE HOADON (Mahd varchar(10) NOT NULL, Ky nvarchar(7) NOT NULL, Tungay datetime NOT NULL, Denngay datetime NOT NULL, Chisodau int NOT NULL, Chisocuoi int NOT NULL, Tongthanhtien money NOT NULL, Ngaylaphd datetime NOT NULL, Tinhtrang bit NOT NULL, PRIMARY KEY (Mahd));
CREATE TABLE KHANHHANG (Makh varchar(30) NOT NULL, Tenkh nvarchar(255) NOT NULL, Diachi nvarchar(100) NOT NULL, Dienthoai int NOT NULL, CMND int NOT NULL, PRIMARY KEY (Makh));
ALTER TABLE DIENKE ADD CONSTRAINT FKDIENKE282020 FOREIGN KEY (Makh) REFERENCES KHANHHANG (Makh);
ALTER TABLE CTHOADON ADD CONSTRAINT FKCTHOADON521844 FOREIGN KEY (Madk) REFERENCES DIENKE (Madk);
ALTER TABLE CTHOADON ADD CONSTRAINT FKCTHOADON592401 FOREIGN KEY (Mahd) REFERENCES HOADON (Mahd);
