-- Script chay truy van yeu cau 
USE EduManagerDB;
GO

-- 1. Liệt kê toàn bộ sinh viên
SELECT * FROM SINHVIEN;

-- 2. Liệt kê sinh viên kèm tên lớp và tên khoa
SELECT sv.MaSV, sv.HoTen, l.TenLop, k.TenKhoa
FROM SINHVIEN sv
JOIN LOP l ON sv.MaLop = l.MaLop
JOIN KHOA k ON l.MaKhoa = k.MaKhoa;

-- 3. Tìm sinh viên theo một phần họ tên bằng LIKE
SELECT * FROM SINHVIEN WHERE HoTen LIKE N'%Tuấn%';

-- 4. Liệt kê sinh viên theo mã lớp
SELECT * FROM SINHVIEN WHERE MaLop = '24CT1';

-- 5. Cập nhật họ tên hoặc lớp của một sinh viên
UPDATE SINHVIEN
SET HoTen = N'Nguyễn Văn Tuấn (Đã cập nhật)'
WHERE MaSV = 'SV01';

-- 6. Xóa một sinh viên chưa có dữ liệu điểm 
-- Dang Thanh Truc (SV06) chua co diem trong bang KETQUA nen thoa dieu kien nay
DELETE FROM SINHVIEN
WHERE MaSV NOT IN (SELECT MaSV FROM KETQUA);

-- 7. Liệt kê điểm của từng sinh viên theo từng môn
SELECT sv.HoTen, mh.TenMH, kq.Diem
FROM KETQUA kq
JOIN SINHVIEN sv ON kq.MaSV = sv.MaSV
JOIN MONHOC mh ON kq.MaMH = mh.MaMH;

-- 8. Tính điểm trung bình của từng sinh viên
SELECT sv.HoTen, AVG(kq.Diem) AS DiemTB
FROM SINHVIEN sv
JOIN KETQUA kq ON sv.MaSV = kq.MaSV
GROUP BY sv.MaSV, sv.HoTen;

-- 9. Thống kê số sinh viên theo từng lớp
SELECT l.TenLop, COUNT(sv.MaSV) AS SoLuongSV
FROM LOP l
LEFT JOIN SINHVIEN sv ON l.MaLop = sv.MaLop
GROUP BY l.MaLop, l.TenLop;

-- 10. Liệt kê các lớp có từ 2 sinh viên trở lên
SELECT l.TenLop, COUNT(sv.MaSV) AS SoLuongSV
FROM LOP l
JOIN SINHVIEN sv ON l.MaLop = sv.MaLop
GROUP BY l.MaLop, l.TenLop
HAVING COUNT(sv.MaSV) >= 2;

-- ==========================================
-- PHAN KIEM THU LOI CUA DE BAI
-- ==========================================

-- 11. Test lỗi khi thêm sinh viên vào lớp không tồn tại (Loi FK)
INSERT INTO SINHVIEN (MaSV, HoTen, NgaySinh, GioiTinh, MaLop) 
VALUES ('SV99', N'Sinh vien test', '2005-01-01', N'Nam', 'LopAoNaoDo');

-- 12. Test lỗi khi nhập điểm ngoài khoảng 0 đến 10 (Loi Check)
INSERT INTO KETQUA (MaSV, MaMH, Diem) 
VALUES ('SV01', 'MMT', 11.5);
