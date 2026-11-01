# Bài tập Lab 13 - Báo cáo sinh viên bằng LINQ (C# Windows Forms)

## 1. Thông tin sinh viên
- **Họ và tên:** Nguyễn Văn Tuấn
- **Lớp:** K50CNTTA
- **Môn học:** Lập trình trên Windows (COMP1019)

## 2. Mô tả dự án
Project Lab 13 xây dựng module Báo cáo danh sách và kết quả học tập sinh viên bằng C# Windows Forms, áp dụng kỹ thuật truy vấn dữ liệu với ngôn ngữ LINQ (Language Integrated Query). Ứng dụng cho phép người dùng lọc danh sách sinh viên theo lớp, theo kết quả học tập (Đạt / Không đạt) và tra cứu nhanh qua từ khóa; gom nhóm và thống kê số liệu theo từng lớp học phần; đồng thời xuất dữ liệu đang hiển thị ra file CSV hoặc TXT có xử lý ngoại lệ an toàn.

## 3. Cấu trúc bài nộp
Bài làm được đóng gói trong một thư mục Solution hoàn chỉnh:
1. `StudentReportDemo.sln` / Thư mục source code: Chứa toàn bộ mã nguồn ứng dụng C# WinForms (.NET 8.0 Windows).
2. `Models/SinhVien.cs`: Model đối tượng sinh viên với các thuộc tính (`MaSV`, `HoTen`, `MaLop`, `TenLop`, `Diem`) và thuộc tính chỉ đọc `KetQua` tự động trả về "Đạt" hoặc "Không đạt".
3. `Forms/FrmBaoCaoSinhVien.cs`: Quản lý giao diện, khởi tạo dữ liệu mẫu và hiện thực các hàm nghiệp vụ độc lập bằng LINQ (`TaoDuLieuMau`, `LoadComboBox`, `XemBaoCao`, `CapNhatThongKe`, `ThongKeTheoLop`, `XuatFile`).
4. `BaoCaoXuatMau/`: Chứa các file kết quả mẫu đã được xuất thành công từ chương trình (`BaoCaoSinhVien_DanhSach.csv` và `BaoCaoThongKeTheoLop.txt`).
5. `Hình ảnh Lab13/`: Chứa các ảnh chụp màn hình minh chứng kết quả chạy chương trình.

## 4. Các điểm nhấn kỹ thuật
- **Truy vấn LINQ linh hoạt:** Sử dụng mệnh đề `Where` để kết hợp lọc đa điều kiện (lớp học, kết quả, từ khóa tìm kiếm), dùng `OrderByDescending` để xếp điểm giảm dần và `ThenBy` sắp xếp phụ theo họ tên sinh viên.
- **Thống kê nâng cao bằng LINQ GroupBy:** Nhóm dữ liệu theo mã lớp và tên lớp để tính sĩ số, số lượng sinh viên đạt/không đạt bằng hàm `Count` và điểm trung bình lớp bằng hàm `Average` kết hợp làm tròn `Math.Round`.
- **Xuất file an toàn & chuẩn mã hóa:** Hỗ trợ người dùng lựa chọn xuất ra định dạng `.csv` hoặc `.txt` qua `SaveFileDialog`; tự động chuẩn hóa dấu phẩy trong nội dung; sử dụng `UTF8Encoding(true)` có BOM giúp mở file trên Microsoft Excel không bị lỗi font tiếng Việt; bao bọc toàn bộ thao tác trong khối `try - catch` để bắt lỗi khi ghi file.
- **Giao diện hiện đại (UI/UX):** Bố cục 2 cột gọn gàng (cột bộ lọc/nút bấm bên trái và bảng dữ liệu bên phải), 4 thẻ thống kê số liệu (Cards) có màu sắc nhận diện trực quan, các nút bấm được bo góc mềm mại bằng `GraphicsPath`.

## 5. Hướng dẫn chạy chương trình
1. Giải nén thư mục bài nộp `MSSV_HoTen_Lab13.zip`.
2. Mở file solution `StudentReportDemo.sln` bằng Visual Studio 2022.
3. Nhấn tổ hợp phím `Ctrl + Shift + B` (hoặc vào menu **Build -> Rebuild Solution**) để biên dịch ứng dụng.
4. Nhấn phím `F5` (hoặc nút **Start**) để khởi chạy chương trình.

## 6. Dữ liệu mẫu & Tính năng kiểm thử
- Dữ liệu mẫu khởi tạo sẵn 16 sinh viên thuộc 4 lớp chuyên ngành CNTT (`COMP48A`, `COMP48B`, `KTPM49A`, `HTTT49A`), vượt yêu cầu tối thiểu của đề bài (12 sinh viên / 3 lớp).
- ComboBox lớp học được bổ sung thêm lựa chọn `--- Tất cả các lớp ---` giúp người dùng có thể xem báo cáo toàn khóa hoặc xem chi tiết từng lớp riêng biệt.
- Ô tìm kiếm từ khóa hỗ trợ tìm kiếm không phân biệt hoa thường theo cả Mã sinh viên và Họ tên sinh viên.

## 7. Hình ảnh minh họa kết quả chạy ứng dụng

- **Giao diện chính khi vừa khởi động và hiển thị báo cáo sinh viên:**
  ![Giao diện](Hình%20ảnh%20Lab13/Giao%20Diện.png)

- **Chế độ thống kê tổng hợp số lượng và điểm trung bình theo từng lớp:**
  ![Chế độ thống kê](Hình%20ảnh%20Lab13/Chế%20độ%20thống%20kê.png)

- **Thông báo xuất báo cáo ra file CSV/TXT thành công:**
  ![Thông Báo Thành Công](Hình%20ảnh%20Lab13/Thông%20Báo%20Thành%20Công.png)
