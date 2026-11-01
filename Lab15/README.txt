========================================================================
BÀI TẬP LAB 15: MÔ HÌNH MVP, KIỂM THỬ VÀ BÀN GIAO ĐỒ ÁN
Học phần: Lập trình trên Windows (COMP1019)
========================================================================

1. THÔNG TIN SINH VIÊN
- Họ và tên: Nguyễn Văn Tuấn
- Lớp: 24CT1
- Module thực hiện: Quản lý hồ sơ sinh viên theo kiến trúc MVP (Model - View - Presenter)

2. MÔI TRƯỜNG & PHIÊN BẢN KỸ THUẬT
- Ngôn ngữ lập trình: C# (Windows Forms)
- Phiên bản .NET: .NET 8.0 Windows (net8.0-windows)
- Công cụ IDE: Microsoft Visual Studio 2022
- Lưu trữ dữ liệu: In-Memory Repository (List<Student> khởi tạo sẵn 10 sinh viên mẫu)
- Tài khoản demo: Không yêu cầu đăng nhập (chương trình vào thẳng màn hình quản lý chính với dữ liệu mẫu để kiểm tra ngay).

3. CẤU TRÚC THƯ MỤC DỰ ÁN (CHUẨN MVP)
QuanLySinhVienMVP
|-- Models
|   |-- Student.cs               : Lớp dữ liệu sinh viên (Mã SV, Họ tên, Lớp, Điểm, Xếp loại, Kết quả)
|-- Views
|   |-- IStudentView.cs          : Interface định nghĩa các thuộc tính và hàm giao tiếp với Form
|   |-- FrmStudent.cs            : Form giao diện chính thực thi IStudentView, chỉ gọi Presenter
|   |-- FrmStudent.Designer.cs   : Mã thiết kế giao diện WinForms
|-- Presenters
|   |-- StudentPresenter.cs      : Xử lý toàn bộ kiểm tra dữ liệu và nghiệp vụ Thêm/Xóa/Tìm/Load
|-- Repositories
|   |-- IStudentRepository.cs    : Interface định nghĩa các thao tác truy xuất dữ liệu
|   |-- StudentRepository.cs     : Lưu trữ danh sách List<Student> và khởi tạo 10 sinh viên mẫu
|-- Program.cs                   : Điểm khởi chạy ứng dụng

4. HƯỚNG DẪN CHẠY CHƯƠNG TRÌNH
Bước 1: Giải nén file bài nộp.
Bước 2: Mở file `QuanLySinhVienMVP.sln` bằng phần mềm Visual Studio 2022.
Bước 3: Nhấn tổ hợp phím `Ctrl + Shift + B` (Build -> Rebuild Solution) để biên dịch project.
Bước 4: Nhấn phím `F5` (hoặc nút Start) để chạy chương trình.
(Hoặc chạy bằng dòng lệnh Terminal tại thư mục gốc: `dotnet run --project QuanLySinhVienMVP/QuanLySinhVienMVP.csproj`)

5. DANH SÁCH TEST CASE ĐÃ KIỂM THỬ
- TC01 (Load danh sách): Mở Form hoặc bấm "Tải danh sách" -> Hiển thị 10 sinh viên mẫu trên bảng. (PASS)
- TC02 (Thêm hợp lệ): Nhập Mã "SV2411", Tên "Phan Nhật Minh", Lớp "24CT1", Điểm "8.6" -> Thêm thành công, bảng tăng lên 11 SV. (PASS)
- TC03 (Thêm trùng mã): Nhập Mã "SV2401" đã có sẵn -> Báo lỗi trùng mã sinh viên, không thêm vào danh sách. (PASS)
- TC04 (Xóa dữ liệu): Chọn sinh viên mã "SV2405" và bấm "Xóa theo mã" -> Xóa thành công khỏi bảng và cập nhật lại thống kê. (PASS)
- TC05 (Tìm kiếm): Nhập từ khóa "Ngọc" vào ô tìm kiếm và bấm "Tìm kiếm" -> Hiển thị đúng 2 sinh viên có tên chứa chữ "Ngọc". (PASS)
- TC06 (Kiểm tra dữ liệu rỗng): Để trống Mã SV hoặc Họ tên rồi bấm "Thêm sinh viên" -> Báo lỗi yêu cầu nhập đầy đủ thông tin. (PASS)
- TC07 (Kiểm tra sai kiểu/ngoài khoảng điểm): Nhập Điểm "abc" hoặc "12" -> Báo lỗi sai kiểu số hoặc điểm ngoài khoảng 0 - 10. (PASS)

6. GHI CHÚ BÀN GIAO
- Chi tiết các kịch bản kiểm thử xem tại file `TestCases.txt`.
- Danh mục rà soát trước khi nộp bài xem tại file `ChecklistBanGiao.txt`.
- Ảnh chụp màn hình thực tế khi chạy chương trình nằm trong thư mục `Hình ảnh Lab15/`.
