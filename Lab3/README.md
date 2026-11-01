# Bài tập Lab 03 - C# và Lập trình hướng đối tượng: Quản lý sinh viên bằng Console

## 1. Thông tin sinh viên

- **Họ và tên:** Nguyễn Văn Tuấn
- **Lớp:** 50CNTTA
- **Môn học:** Lập trình trên Windows (COMP1019)

## 2. Mô tả dự án

Project Lab 03 xây dựng chương trình Console quản lý sinh viên theo phương pháp lập trình hướng đối tượng (OOP) bằng ngôn ngữ C#. Ứng dụng mô hình hóa quan hệ kế thừa giữa lớp `SinhVien` và lớp cha `Nguoi`, lưu trữ dữ liệu trong bộ nhớ thông qua `List<SinhVien>` tại lớp `QuanLySinhVien` và sử dụng LINQ cơ bản để tìm kiếm, lọc và sắp xếp dữ liệu.

## 3. Cấu trúc bài nộp

Bài làm được đóng gói trong một thư mục Solution hoàn chỉnh:

  1. `Lab3.sln` / Thư mục `Lab3/`: Chứa toàn bộ mã nguồn ứng dụng Console App C#.
  2. `Nguoi.cs`: Lớp cha chứa các thuộc tính `HoTen`, `NgaySinh`, constructor khởi tạo và phương thức `virtual LayThongTin()` cho phép lớp con ghi đè.
  3. `SinhVien.cs`: Lớp kế thừa từ `Nguoi`, bổ sung các thuộc tính `MaSinhVien`, `MaLop`, `DiemTrungBinh` (kiểm tra dữ liệu hợp lệ trong khoảng từ 0 đến 10), phương thức `XepLoai()` và ghi đè `override LayThongTin()`.
  4. `QuanLySinhVien.cs`: Lớp quản lý danh sách `List<SinhVien>` với các phương thức `Them`, `Sua`, `Xoa`, `TimTheoMa`, `TimTheoTen`, `SapXepTheoDiem`, `LocSinhVienDat` và `LayDanhSach`, tách biệt hoàn toàn xử lý dữ liệu khỏi hàm `Main`.
  5. `Program.cs`: Xây dựng hệ thống Menu điều khiển chương trình từ chức năng 1 đến 8, xử lý kiểm tra nhập liệu an toàn và hiển thị bảng danh sách sinh viên có màu sắc.
  6. Thư mục `Hình ảnh lab3/`: Chứa ảnh chụp màn hình minh chứng kết quả chạy chương trình.

## 4. Các điểm nhấn kỹ thuật

- **Kế thừa và Đa hình (`Nguoi` -> `SinhVien`):** Lớp `SinhVien` kế thừa thuộc tính và constructor từ lớp `Nguoi` thông qua từ khóa `base`, đồng thời `override` phương thức `LayThongTin()` để xuất đầy đủ thông tin sinh viên và học lực.
- **Đóng gói và Kiểm tra dữ liệu (Property Validation):** Các thuộc tính được đóng gói chặt chẽ; thuộc tính `DiemTrungBinh` chỉ nhận giá trị từ `0` đến `10`, tự động báo lỗi nếu dữ liệu ngoài khoảng cho phép.
- **Quản lý danh sách với `List<SinhVien>` và LINQ:** Sử dụng các phương thức LINQ cơ bản (`Any`, `FirstOrDefault`, `Where`, `OrderByDescending`) để kiểm tra trùng mã sinh viên, tìm kiếm theo mã, tìm kiếm theo từ khóa họ tên, lọc sinh viên đạt (`>= 5.0`) và sắp xếp điểm giảm dần.
- **Xử lý nhập liệu an toàn:** Kết hợp `double.TryParse`, `DateTime.TryParseExact` và `try-catch` trong các hàm nhập liệu giúp chương trình không bị dừng đột ngột khi người dùng nhập sai định dạng hoặc nhập điểm ngoài khoảng `0 - 10`.
- **Trình bày giao diện Console trực quan:** Thiết kế Menu 2 cột với khung bo góc thẩm mỹ, hỗ trợ tiếng Việt có dấu (UTF-8), kẻ bảng danh sách sinh viên thẳng hàng và phân màu theo từng mức xếp loại (`Giỏi`, `Khá`, `Trung bình`, `Yếu`).

## 5. Hướng dẫn chạy chương trình

1. Giải nén thư mục bài làm (hoặc clone từ kho lưu trữ GitHub cá nhân).
2. Mở file `Lab3.sln` bằng phần mềm **Visual Studio**.
3. Nhấn phím `F5` (hoặc `Ctrl + F5`) để biên dịch và khởi chạy ứng dụng Console.
4. Nhập các phím số từ `1` đến `8` trên bàn phím để thực hiện từng chức năng quản lý sinh viên, hoặc nhấn `0` để thoát chương trình.

## 6. Hình ảnh minh họa kết quả chạy ứng dụng

  - **Giao diện Menu chính và kết quả chạy chương trình:**

    ![Giao diện chương trình](Hình%20ảnh%20lab3/Giao%20Diện.png)
