# Bài Lab 13 - Báo cáo sinh viên bằng LINQ
**Học phần:** COMP1019 - Lập trình trên Windows  

## 1. Cấu trúc thư mục
- `StudentReportDemo/Models/SinhVien.cs`: Lớp đối tượng SinhVien gồm các thuộc tính `MaSV`, `HoTen`, `MaLop`, `TenLop`, `Diem` và thuộc tính chỉ đọc `KetQua`.
- `StudentReportDemo/Forms/FrmBaoCaoSinhVien.cs`: Xử lý giao diện, tạo dữ liệu mẫu, lọc danh sách, thống kê theo lớp bằng LINQ và xuất báo cáo CSV/TXT.
- `BaoCaoXuatMau/`: Chứa 2 file kết quả mẫu đã xuất từ chương trình (`BaoCaoSinhVien_DanhSach.csv` và `BaoCaoThongKeTheoLop.txt`).

## 2. Các chức năng đã thực hiện
1. Khởi tạo danh sách 16 sinh viên thuộc 4 lớp học phần khác nhau (`COMP48A`, `COMP48B`, `KTPM49A`, `HTTT49A`).
2. Load danh sách lớp vào `cboLop` (dùng LINQ `Select`, `Distinct`, `OrderBy`) và các trạng thái kết quả học tập vào `cboKetQua`.
3. Lọc sinh viên theo lớp, kết quả (`Tất cả`, `Đạt`, `Không đạt`) và từ khóa tìm kiếm theo mã SV hoặc họ tên, sắp xếp điểm giảm dần bằng `OrderByDescending` và `ThenBy`.
4. Thống kê số lượng sinh viên, số lượng đạt, không đạt và điểm trung bình theo từng lớp bằng `GroupBy`.
5. Hiển thị thông tin tổng hợp trên các thẻ thống kê nhanh, `lblThongKe` và thanh trạng thái `StatusStrip`.
6. Xuất dữ liệu trên bảng `dgvBaoCao` ra file `.csv` hoặc `.txt` qua `SaveFileDialog` có kèm `try-catch` bắt lỗi.
