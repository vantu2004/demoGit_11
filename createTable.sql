CREATE TABLE HocSinh (
	Ten varchar(100),
	Diachi varchar(255),
	Cmnd varchar(100),
	NgaySinh varchar (50)
);

INSERT INTO HocSinh (Ten, Diachi, Cmnd, NgaySinh, Email, Id, Sdt, GioiTinh) 
VALUES ('nva', 'hcm', '123', '12/08/2004', '001@gmail.com', '001', '0385068953', 'nam');
INSERT INTO HocSinh (Ten, Diachi, Cmnd, NgaySinh, Email, Id, Sdt, GioiTinh) 
VALUES ('nva2', 'hcm', '123', '12/08/2004', '001@gmail.com', '001', '0385068953', 'nam');
INSERT INTO HocSinh (Ten, Diachi, Cmnd, NgaySinh, Email, Id, Sdt, GioiTinh) 
VALUES ('nva3', 'hcm', '123', '12/08/2004', '001@gmail.com', '001', '0385068953', 'nam');
INSERT INTO HocSinh (Ten, Diachi, Cmnd, NgaySinh, Email, Id, Sdt, GioiTinh) 
VALUES ('nva4', 'hcm', '123', '12/08/2004', '001@gmail.com', '001', '0385068953', 'nam');
INSERT INTO HocSinh (Ten, Diachi, Cmnd, NgaySinh, Email, Id, Sdt, GioiTinh) 
VALUES ('nva5', 'hcm', '123', '12/08/2004', '001@gmail.com', '001', '0385068953', 'nam');

select * from HocSinh


create table GiangVien(
	Ten varchar(100),
	DiaChi varchar(100),
	Cmnd varchar(100),
	NgaySinh varchar (50)
);

insert into GiangVien(Ten, DiaChi, Cmnd, NgaySinh, Email, Id, Sdt, GioiTinh) 
values('lvt', 'hcm', '001', '12/08/2004', '001@gmail.com', '001', '0385068953', 'nam');
insert into GiangVien(Ten, DiaChi, Cmnd, NgaySinh, Email, Id, Sdt, GioiTinh) 
values('lat', 'hcm', '002', '12/08/2004', '001@gmail.com', '001', '0385068953', 'nam');
insert into GiangVien(Ten, DiaChi, Cmnd, NgaySinh, Email, Id, Sdt, GioiTinh) 
values('nat', 'hcm', '003', '12/08/2004', '001@gmail.com', '001', '0385068953', 'nam');
insert into GiangVien(Ten, DiaChi, Cmnd, NgaySinh, Email, Id, Sdt, GioiTinh) 
values('vvk', 'hcm', '004', '12/08/2004', '001@gmail.com', '001', '0385068953', 'nam');
insert into GiangVien(Ten, DiaChi, Cmnd, NgaySinh, Email, Id, Sdt, GioiTinh) 
values('dbl', 'hcm', '005', '12/08/2004', '001@gmail.com', '001', '0385068953', 'nam');
insert into GiangVien(Ten, DiaChi, Cmnd, NgaySinh, Email, Id, Sdt, GioiTinh) 
values('pdd', 'hcm', '006', '12/08/2004', '001@gmail.com', '001', '0385068953', 'nam');

select *from GiangVien

ALTER TABLE HocSinh ADD Email varchar(100);
ALTER TABLE HocSinh ADD Id varchar(20);
ALTER TABLE HocSinh ADD Sdt varchar(20);
ALTER TABLE HocSinh ADD GioiTinh varchar(10);

ALTER TABLE GiangVien ADD Email varchar(100);
ALTER TABLE GiangVien ADD Id varchar(20);
ALTER TABLE GiangVien ADD Sdt varchar(20);
ALTER TABLE GiangVien ADD GioiTinh varchar(10);