# Bài Lab 12 - Data Binding, Stored Procedure và Transaction
**Học phần:** COMP1019 - Lập trình trên Windows

## 1. Cấu trúc thư mục
- `Database/QLSinhVienLab12.sql`: Script tạo CSDL, bảng, ràng buộc khóa chính/khóa ngoại, dữ liệu mẫu và 4 Stored Procedure.
- `DAL/Database.cs`: Lưu chuỗi kết nối SQL Server.
- `DAL/KetQuaDAL.cs`: Các hàm gọi Stored Procedure bằng `SqlDataAdapter` và lưu danh sách điểm với `SqlTransaction`.
- `Forms/FrmNhapDiemTheoLop.cs`: Giao diện nhập điểm, kiểm tra dữ liệu đầu vào, lọc tìm kiếm và thống kê nhanh.

## 2. Hướng dẫn chạy chương trình
1. Mở SQL Server Management Studio (SSMS), chạy toàn bộ file `Database/QLSinhVienLab12.sql`.
2. Mở file `QLSinhVienLab12.sln` bằng Visual Studio.
3. Kiểm tra lại chuỗi kết nối `ConnectionString` trong `DAL/Database.cs` cho khớp với tên SQL Server trên máy (mặc định đang để `Data Source=.`).
4. Nhấn `F5` để build và chạy ứng dụng.

## 3. Chức năng đã hoàn thành
- Load danh sách lớp và môn học vào ComboBox thông qua Stored Procedure.
- Hiển thị danh sách sinh viên và điểm số lên DataGridView qua `BindingSource`.
- Chỉ cho phép sửa cột `Diem` và `GhiChu`, khóa cột `MaSV` và `HoTen`.
- Kiểm tra điểm hợp lệ (không rỗng, đúng định dạng số, từ 0 đến 10) trước khi lưu.
- Lưu toàn bộ bảng điểm bằng `SqlTransaction`: tự động `Commit` khi thành công và `Rollback` toàn bộ nếu có bất kỳ dòng nào lỗi.
- Mở rộng: Tìm kiếm sinh viên trực tiếp trên `BindingSource`, thống kê sĩ số, điểm trung bình và số lượng qua môn, giao diện chia 2 cột kèm nút bấm bo tròn.
