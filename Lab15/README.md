# Bài tập Lab 15 - Mô hình MVP, kiểm thử và bàn giao đồ án (C# Windows Forms)

## 1. Thông tin sinh viên
- **Họ và tên:** Nguyễn Văn Tuấn
- **Lớp:** 24CT1
- **Môn học:** Lập trình trên Windows (COMP1019)

## 2. Mô tả dự án
Project bài tập thực hành buổi 15 xây dựng module **Quản lý hồ sơ sinh viên** bằng C# Windows Forms theo kiến trúc **MVP (Model - View - Presenter)**. Chương trình tách biệt hoàn toàn phần giao diện hiển thị (`FrmStudent`) với phần xử lý nghiệp vụ (`StudentPresenter`) và tầng truy xuất dữ liệu (`StudentRepository`) thông qua các interface (`IStudentView`, `IStudentRepository`).

## 3. Cấu trúc thư mục theo kiến trúc MVP
```text
QuanLySinhVienMVP
|-- Models
|   |-- Student.cs
|-- Views
|   |-- IStudentView.cs
|   |-- FrmStudent.cs
|   |-- FrmStudent.Designer.cs
|-- Presenters
|   |-- StudentPresenter.cs
|-- Repositories
|   |-- IStudentRepository.cs
|   |-- StudentRepository.cs
|-- Program.cs
```

- **Models (`Student.cs`):** Lưu trữ thông tin sinh viên (`StudentId`, `FullName`, `ClassName`, `Score`) cùng hai thuộc tính tính toán tự động là `AcademicRank` (Xếp loại) và `Status` (Đạt / Chưa đạt).
- **Views (`IStudentView.cs`, `FrmStudent.cs`):** Form thực thi interface `IStudentView`. Các sự kiện `Click` của nút bấm chỉ gọi phương thức của `_presenter`, không xử lý logic trực tiếp trên Form.
- **Presenters (`StudentPresenter.cs`):** Độc lập hoàn toàn với thư viện `System.Windows.Forms`, không truy cập trực tiếp `TextBox` hay `DataGridView` mà chỉ nhận/trả dữ liệu qua `IStudentView` và `IStudentRepository`.
- **Repositories (`IStudentRepository.cs`, `StudentRepository.cs`):** Quản lý danh sách `List<Student>` với 10 bản ghi dữ liệu mẫu khởi tạo sẵn cùng các hàm `GetAll`, `GetById`, `Exists`, `Add`, `Delete`, `Search`.

## 4. Hướng dẫn chạy chương trình
- **Phiên bản công cụ:** Visual Studio 2022 / .NET 8.0 Windows (`net8.0-windows`).
- **Tài khoản demo:** Không yêu cầu đăng nhập (vào thẳng màn hình quản lý đã nạp sẵn 10 sinh viên mẫu).
1. Giải nén file nén bài nộp.
2. Mở file `QuanLySinhVienMVP.sln` bằng **Visual Studio 2022**.
3. Nhấn `Ctrl + Shift + B` để biên dịch Solution.
4. Nhấn `F5` để khởi chạy ứng dụng.

## 5. Kịch bản kiểm thử (Test Cases)

| ID | Chức năng | Thao tác / Dữ liệu | Kết quả mong đợi | Trạng thái |
| :--- | :--- | :--- | :--- | :--- |
| **TC01** | Load danh sách | Mở Form hoặc bấm nút `Tải danh sách` | Hiển thị 10 sinh viên mẫu lên bảng và cập nhật 3 thẻ thống kê trên Header | Đạt |
| **TC02** | Thêm hợp lệ | Nhập Mã `SV2411`, Tên `Phan Nhật Minh`, Lớp `24CT1`, Điểm `8.6` rồi bấm `Thêm sinh viên` | Thêm thành công, xóa trắng ô nhập, bảng hiển thị 11 sinh viên | Đạt |
| **TC03** | Thêm trùng mã | Nhập Mã `SV2401` đã tồn tại, Tên `Lê Văn Thử Nghiệm`, Điểm `7.5` rồi bấm `Thêm sinh viên` | Báo lỗi trùng mã sinh viên `SV2401`, không thêm vào danh sách | Đạt |
| **TC04** | Xóa dữ liệu | Chọn sinh viên có mã `SV2405` và bấm `Xóa theo mã` | Xóa thành công `SV2405` khỏi bảng và cập nhật lại số lượng | Đạt |
| **TC05** | Tìm kiếm | Nhập từ khóa `Ngọc` vào ô tìm kiếm và bấm `Tìm kiếm` | Hiển thị 2 sinh viên khớp tên (`SV2402`, `SV2406`) và thông báo kết quả | Đạt |
| **TC06** | Kiểm tra rỗng | Để trống ô Mã SV hoặc Họ tên rồi bấm `Thêm sinh viên` | Báo lỗi yêu cầu nhập đầy đủ thông tin | Đạt |
| **TC07** | Điểm sai kiểu | Nhập Điểm là chữ `abc` hoặc số ngoài khoảng `0 - 10` (`11.5`) | Báo lỗi sai kiểu dữ liệu hoặc điểm nằm ngoài phạm vi hợp lệ | Đạt |

## 6. Checklist bàn giao đồ án cuối kỳ
- [x] Form có đầy đủ các ô nhập liệu (`Mã sinh viên`, `Họ và tên`, `Lớp biên chế`, `Điểm trung bình`, `Từ khóa tìm kiếm`) và `DataGridView`.
- [x] Tách đúng 4 tầng thư mục: `Models`, `Views`, `Presenters`, `Repositories`.
- [x] Sự kiện Button Click chỉ gọi Presenter (`_presenter.AddStudent()`, `_presenter.DeleteStudent()`, `_presenter.SearchStudents()`, `_presenter.LoadStudents()`).
- [x] Presenter không truy cập trực tiếp `TextBox` hoặc `DataGridView`, chỉ giao tiếp qua `IStudentView`.
- [x] Có đầy đủ dữ liệu mẫu (10 sinh viên), kiểm tra rỗng, kiểm tra sai kiểu số, kiểm tra trùng mã và thông báo kết quả.
- [x] Đính kèm đầy đủ `README.txt`, `TestCases.txt`, `ChecklistBanGiao.txt` và hình ảnh chạy chương trình.

## 7. Hình ảnh minh họa kết quả chạy ứng dụng

- **TC01 - Giao diện chính khi vừa mở Form và tải danh sách dữ liệu mẫu:**
  ![Giao diện chính](Hình%20ảnh%20Lab15/Giao%20Diện.png)

- **TC02 - Thêm mới sinh viên hợp lệ (`SV2411 - Phan Nhật Minh`):**
  ![Thêm sinh viên](Hình%20ảnh%20Lab15/Thêm%20Sinh%20Viên.png)

- **TC03 - Kiểm tra và báo lỗi khi nhập trùng mã sinh viên (`SV2401`):**
  ![Báo lỗi trùng mã](Hình%20ảnh%20Lab15/Báo%20Lỗi%20Trùng%20Mã.png)

- **TC04 - Xóa sinh viên theo mã (`SV2405`):**
  ![Xóa sinh viên](Hình%20ảnh%20Lab15/Xóa%20Sinh%20Viên.png)

- **TC05 - Tìm kiếm sinh viên theo tên hoặc mã (`Ngọc`):**
  ![Tìm kiếm sinh viên](Hình%20ảnh%20Lab15/Tìm%20Kiếm.png)
