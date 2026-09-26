# BTLOP (16092026) - Quản lý nhân viên

**Sinh viên thực hiện:** Nguyễn Văn Tuấn

## Mô tả
Ứng dụng C# Console Application quản lý nhân viên trong công ty. Chương trình được xây dựng dựa trên các nguyên lý cốt lõi của Lập trình hướng đối tượng (OOP) bao gồm Class, Property, Encapsulation, Kế thừa và Đa hình (Polymorphism) để xử lý nghiệp vụ tính lương cho nhiều đối tượng nhân viên khác nhau.

## Chức năng
- Khởi tạo và quản lý danh sách đa dạng các loại nhân viên: Nhân viên văn phòng, Nhân viên kinh doanh, và Nhân viên thời vụ.
- Tự động tính lương chuẩn xác cho từng loại nhân viên thông qua cơ chế Đa hình (không sử dụng if/switch).
- Xuất danh sách chi tiết thông tin toàn bộ nhân viên.
- Tìm kiếm thông tin nhân viên nhanh chóng dựa trên Mã nhân viên.
- Lọc và hiển thị (các) nhân viên có mức lương thực lĩnh cao nhất công ty.
- Tính toán tổng quỹ lương mà công ty phải chi trả cho toàn bộ nhân sự.
- Hệ thống Menu điều hướng trực quan, dễ thao tác trong môi trường Console.

## Công nghệ sử dụng
- C# Console Application
- .NET 8 (hoặc các phiên bản .NET tương thích)

## Cách chạy
1. Điều hướng đến thư mục `BTLOP/16092026` trong repository.
2. Mở project bằng Visual Studio hoặc Visual Studio Code.
3. Nếu dùng Visual Studio: Nhấn `F5` để chạy chương trình.
4. Nếu dùng Terminal/CMD: Gõ lệnh `dotnet run` tại thư mục chứa file `.csproj`.

## Hình ảnh minh họa

### Giao diện Menu chính
![Giao dien Menu](screenshots/Menu.png)

### Xuất danh sách nhân viên
![Xuat danh sach](screenshots/XuatDanhSachNV.png)

### Tìm nhân viên theo mã
![Tim nhan vien theo ma](screenshots/TimNV.png)

### Tìm nhân viên có lương cao nhất
![Nhan vien luong cao nhat](screenshots/NVLuongCaoNhat.png)

### Tính tổng lương công ty phải trả
![Tong luong](screenshots/TongLuong.png)
