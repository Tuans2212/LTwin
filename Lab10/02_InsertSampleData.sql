-- Script nhap du lieu
USE EduManagerDB;
GO

-- Clear data de khong bi loi trung khi chay lai
DELETE FROM KETQUA;
DELETE FROM TAIKHOAN;
DELETE FROM SINHVIEN;
DELETE FROM MONHOC;
DELETE FROM LOP;
DELETE FROM KHOA;
GO

-- Them 2 khoa
INSERT INTO KHOA (MaKhoa, TenKhoa, SoDienThoai) VALUES 
('CNTT', N'Khoa Công nghệ thông tin', '0901234567'),
('KT', N'Khoa Kinh tế', '0909876543');

-- Them 3 lop
INSERT INTO LOP (MaLop, TenLop, MaKhoa) VALUES 
('24CT1', N'Lớp CNTT 1', 'CNTT'),
('24CT2', N'Lớp CNTT 2', 'CNTT'),
('24KT1', N'Lớp Kinh tế 1', 'KT');

-- Them 6 sinh vien (co minh trong nay nhe)
INSERT INTO SINHVIEN (MaSV, HoTen, NgaySinh, GioiTinh, MaLop) VALUES 
('SV01', N'Nguyễn Văn Tuấn', '2005-01-15', N'Nam', '24CT1'),
('SV02', N'Trần Thị Mai', '2005-04-20', N'Nữ', '24CT1'),
('SV03', N'Lê Minh Hoàng', '2004-11-05', N'Nam', '24CT2'),
('SV04', N'Phạm Thu Thảo', '2005-08-30', N'Nữ', '24CT2'),
('SV05', N'Võ Tấn Phát', '2005-02-22', N'Nam', '24KT1'),
('SV06', N'Đặng Thanh Trúc', '2005-12-10', N'Nữ', '24KT1');

-- Them 4 mon hoc
INSERT INTO MONHOC (MaMH, TenMH, SoTinChi) VALUES 
('LTW', N'Lập trình Windows', 3),
('CSDL', N'Cơ sở dữ liệu', 3),
('MMT', N'Mạng máy tính', 4),
('KTCT', N'Kinh tế chính trị', 2);

-- Them 8 ket qua (chu y dung MaSV va MaMH)
INSERT INTO KETQUA (MaSV, MaMH, Diem) VALUES 
('SV01', 'LTW', 8.5),
('SV01', 'CSDL', 9.0),
('SV02', 'LTW', 7.5),
('SV02', 'MMT', 8.0),
('SV03', 'CSDL', 6.0),
('SV04', 'LTW', 9.5),
('SV05', 'KTCT', 8.5),
('SV05', 'CSDL', 7.0);

-- Them 2 tai khoan 
INSERT INTO TAIKHOAN (TenDangNhap, MatKhau, HoTen, VaiTro) VALUES 
('admin', 'admin123', N'Quản trị viên', 'Admin'),
('tuan123', 'pass123', N'Nguyễn Văn Tuấn', 'User');
