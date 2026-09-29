# Lab 05 - Ứng dụng Đăng ký Khóa học Ngắn hạn

## Thông tin sinh viên
- **Họ tên:** Nguyễn Văn Tuấn
- **MSSV:** 50.01.104.175
- **Lớp:** 50.01.CNTT.A

## Mô tả dự án
Chương trình Windows Forms (WinForms) bằng C# mô phỏng giao diện đăng ký khóa học ngắn hạn cho học viên. Ứng dụng cho phép người dùng nhập thông tin cá nhân, chọn khóa học, tự động tính toán chi phí và xuất biên lai xác nhận sau khi đăng ký.

## Công nghệ sử dụng
- C# Windows Forms Application (WinForms)
- .NET Framework / .NET Core (Visual Studio)

## Các chức năng chính
- **Quản lý nhập liệu:** Cung cấp các trường nhập liệu cơ bản (TextBox, DateTimePicker, ComboBox, RadioButton, CheckBox).
- **Kiểm soát dữ liệu:** Bắt lỗi nếu người dùng để trống Họ và Tên. Tự động đếm và hiển thị số lượng ký tự đã nhập (ví dụ: `15/50`).
- **Tính toán động:** 
  - Tự động thay đổi `Học phí` dựa trên môn học được chọn trong danh sách.
  - Tự động tính `Tổng tiền` ngay lập tức khi người dùng thay đổi số tháng học.
- **Xác nhận đăng ký:** Hiển thị hộp thoại (MessageBox) thông báo thành công dạng biên lai chi tiết bao gồm thông tin học viên, khóa học và tổng chi phí.
- **Làm mới dữ liệu:** Xóa trắng form và đưa các giá trị về mặc định ban đầu.

## Hướng dẫn chạy chương trình
1. Mở thư mục dự án và khởi chạy file `.sln` bằng phần mềm Visual Studio.
2. Nhấn `Ctrl + Shift + B` để Build project.
3. Nhấn `F5` hoặc nút **Start** để chạy ứng dụng.
4. Nhập thông tin thử nghiệm vào form và nhấn nút **Đăng Ký**.

## Hình ảnh minh họa

### 1. Giao diện Form đăng ký (Khi vừa khởi động và nhập liệu)
*(Giao diện trực quan với các chức năng chọn khóa học và tự động tính tiền)*
![Giao diện Form Đăng ký](Hình%20Ảnh%20Lab05/Giao_Dien_Form.png)

### 2. Thông báo Đăng ký thành công
*(Biên lai chi tiết hiển thị sau khi người dùng điền đủ thông tin và bấm Đăng ký)*
![Đăng ký thành công](Hình%20Ảnh%20Lab05/Dang_Ky_Thanh_Cong.png)
