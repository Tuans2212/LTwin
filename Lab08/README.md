# Bài tập Lab 08 - Ứng dụng Simple Paint (WinForms & GDI+)

## 1. Thông tin sinh viên
- **Họ và tên:** Nguyễn Văn Tuấn
- **MSSV:** 50.01.104.175
- **Lớp:** 50.01.CNTT.A
- **Môn học:** Lập trình trên Windows (COMP1019)

## 2. Mô tả dự án
Project Lab 08 được xây dựng bằng C# (Windows Forms, .NET 8) sử dụng thư viện đồ họa GDI+, mô phỏng một ứng dụng Paint thu nhỏ. Ứng dụng tập trung vào việc thực hành xử lý sự kiện chuột (Mouse Events), thao tác với đối tượng `Graphics`, `Pen`, cấu trúc dữ liệu lưu trữ lịch sử nét vẽ và kỹ thuật vẽ lại (Redraw) để không mất dữ liệu khi thay đổi kích thước Form. Phiên bản này đã được tích hợp đầy đủ các chức năng nâng cao.

## 3. Hướng dẫn thao tác
Ứng dụng cung cấp các công cụ và thao tác trực quan sau:

- **Thao tác vẽ cơ bản:**
  1. Chọn công cụ vẽ tại mục **Chế độ**: `Pen` (Vẽ tự do), `Line` (Đường thẳng), `Rectangle` (Hình chữ nhật) hoặc `Ellipse` (Hình Elip).
  2. Tùy chỉnh kích thước nét vẽ tại ô **Độ dày** (từ 1 đến 20).
  3. Bấm **Màu vẽ** để mở hộp thoại `ColorDialog` và chọn màu sắc mong muốn.
  4. Nhấn giữ và kéo chuột trái trên vùng canvas trắng để vẽ.

- **Quản lý lịch sử nét vẽ:**
  1. **Undo:** Nhấn nút **Undo** hoặc sử dụng phím tắt `Ctrl + Z` để hoàn tác (xóa nét vẽ vừa thực hiện gần nhất).
  2. **Xóa tất cả:** Nhấn nút **Xóa tất cả** và xác nhận để làm sạch toàn bộ vùng canvas (bao gồm cả ảnh nền nếu có).

- **Chức năng nâng cao (Tương tác tệp tin):**
  1. **Mở ảnh nền:** Nhấn nút **Mở ảnh nền**, chọn một file ảnh (`.jpg`, `.png`, `.bmp`...) từ máy tính để chèn vào vùng vẽ. Bạn có thể vẽ đè lên bức ảnh này.
  2. **Lưu (PNG):** Nhấn nút **Lưu (PNG)**, đặt tên tệp để xuất toàn bộ tác phẩm (gồm ảnh nền và các nét đã vẽ) ra file hình ảnh.

## 4. Các điểm nhấn kỹ thuật
- **Sự kiện Paint & Quản lý đối tượng:** Không vẽ trực tiếp và bỏ quên dữ liệu, mọi thao tác kéo chuột sẽ tạo ra một đối tượng `DrawItem` (chứa tọa độ, màu sắc, độ dày) lưu vào danh sách `List<DrawItem>`. Hệ thống gọi `Invalidate()` để kích hoạt lại sự kiện `Paint`, duyệt qua danh sách và vẽ lại toàn bộ, giúp hình không bị mất khi thu phóng cửa sổ.
- **Kỹ thuật Double Buffering:** Kích hoạt thuộc tính `DoubleBuffered = true` trên Panel tùy chỉnh (`DrawSurface`) để triệt tiêu hoàn toàn hiện tượng nhấp nháy (flickering) khi cập nhật khung hình liên tục lúc kéo chuột.
- **Chuẩn hóa tọa độ thông minh:** Áp dụng thuật toán `Math.Min` và `Math.Abs` để xử lý mượt mà việc vẽ Hình chữ nhật / Hình Elip ngay cả khi người dùng kéo chuột ngược hướng (từ dưới lên hoặc từ phải sang trái).
- **Xử lý đồ họa chống răng cưa:** Kích hoạt `SmoothingMode.AntiAlias` và bo tròn đầu nét vẽ (`LineCap.Round`) để nét bút mượt mà, chuyên nghiệp.

## 5. Hướng dẫn chạy chương trình
1. Giải nén thư mục bài làm `Lab08.zip`.
2. Mở file dự án `Lab08.sln` hoặc `Lab08.csproj` bằng Visual Studio 2022/2026.
3. Nhấn tổ hợp `Ctrl + Shift + B` để Build project.
4. Nhấn `F5` hoặc nút **Start** trên thanh công cụ để khởi chạy ứng dụng.

## 6. Hình ảnh minh họa

- **Ảnh mẫu 1:**
  ![Ảnh mẫu 1](Hình%20Ảnh%20Lab08/Ảnh%20mẫu%201.png)

- **Ảnh mẫu 2:**
  ![Ảnh mẫu 2](Hình%20Ảnh%20Lab08/Ảnh%20mẫu%202.png)

- **Ảnh mẫu 3:**
  ![Ảnh mẫu 3](Hình%20Ảnh%20Lab08/Ảnh%20mẫu%203.png)

- **Ảnh mẫu 4:**
  ![Ảnh mẫu 4](Hình%20Ảnh%20Lab08/Ảnh%20mẫu%204.png)