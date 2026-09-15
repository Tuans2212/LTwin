# Lab 01 - Ứng dụng thông tin cá nhân

## Mô tả
Ứng dụng C# WinForms cho phép nhập, kiểm tra tính hợp lệ và hiển thị thông tin cá nhân cơ bản của sinh viên, đồng thời tích hợp tính năng tự động tính toán tuổi thực tế.

## Chức năng
- Nhập dữ liệu: Họ tên, Năm sinh, Email.
- Tự động tính toán và hiển thị ngay Tuổi khi người dùng nhập Năm sinh.
- Chọn Giới tính (Nam/Nữ) và Khoa/Lớp (từ danh sách xổ xuống).
- Bắt lỗi và cảnh báo khi bỏ trống bất kỳ trường thông tin nào (chưa chọn giới tính, khoa...).
- Bắt lỗi khi nhập Năm sinh sai định dạng (nhập chữ) hoặc ngoài khoảng hợp lệ (1900 - năm hiện tại).
- Hiển thị thông báo tổng hợp thông tin sinh viên thành công.
- Xóa trắng toàn bộ dữ liệu trên form để nhập mới.
- Hiển thị hộp thoại hỏi xác nhận trước khi thoát chương trình.

## Công nghệ sử dụng
- C# WinForms
- .NET 8 (hoặc phiên bản .NET Framework tương ứng)

## Cách chạy
1. Mở file `Lab01/Lab01.sln` bằng Visual Studio.
2. Build solution.
3. Nhấn F5 để chạy chương trình.

## Hình ảnh minh họa

### Màn hình chính (Giao diện khởi tạo)
![Man hinh chinh](screenshots/man_hinh_chinh.png)

### Tính năng tự động tính tuổi khi nhập năm sinh
![Tu dong tinh tuoi](screenshots/tu_dong_tinh_tuoi.png)

### Cảnh báo khi bỏ trống thông tin hoặc chưa chọn giới tính/khoa
![Canh bao de trong](screenshots/canh_bao_de_trong.png)

### Cảnh báo khi năm sinh không hợp lệ (chứa chữ hoặc sai khoảng)
![Canh bao nam sinh](screenshots/canh_bao_nam_sinh.png)

### Hiển thị kết quả thành công
![Hien thi ket qua](screenshots/hien_thi_ket_qua.png)

### Xác nhận thoát chương trình
![Xac nhan thoat](screenshots/xac_nhan_thoat.png)
