# Bài tập Lab 09 - Thiết kế và In thẻ sinh viên (WinForms & GDI+)



## 1. Thông tin sinh viên

- **Họ và tên:** Nguyễn Văn Tuấn

- **MSSV:** 50.01.104.175

- **Lớp:** 50.01.CNTT.A

- **Môn học:** Lập trình trên Windows (COMP1019)



## 2. Mô tả dự án

Project Lab 09 được xây dựng bằng C# (Windows Forms, .NET) tập trung vào việc xử lý đồ họa GDI+ để thiết kế bản xem trước (Live Preview) và tích hợp các chức năng in ấn. Ứng dụng cho phép nhập thông tin sinh viên, chọn ảnh đại diện, tùy chỉnh thẻ và sau đó xuất ra bản in hoặc lưu thành file ảnh. Phiên bản này đã được thiết kế lại giao diện hiện đại và tích hợp toàn bộ các chức năng mở rộng theo yêu cầu của đề bài.



## 3. Hướng dẫn thao tác

Ứng dụng cung cấp các chức năng theo luồng thao tác trực quan:



- **Nhập liệu & Khởi tạo thẻ:**

  1. Nhập đầy đủ thông tin cá nhân: *MSSV, Họ tên, Lớp, Khoa, Khóa, Ngày sinh, Giới tính*.

  2. Bấm nút **Chọn ảnh** (OpenFileDialog) để tải ảnh đại diện lên (hỗ trợ JPG, PNG, BMP...).

  3. Ngay khi dữ liệu thay đổi, vùng bên phải (Panel) sẽ tự động cập nhật và vẽ lại (Live Preview) hình dáng của chiếc thẻ sinh viên thực tế.



- **Tùy biến thẻ (Chức năng mở rộng):**

  1. **Màu nền:** Bấm nút **Màu nền** để mở `ColorDialog`. Bạn có thể thoải mái chọn màu nền yêu thích cho chiếc thẻ của mình.

  2. **Mã QR:** Hệ thống sẽ tự động generate một mã QR (dựa trên MSSV) ở góc dưới cùng bên phải của thẻ.



- **In ấn & Xuất file:**

  1. **Xem trước in:** Bấm nút **Xem trước in** (`PrintPreviewDialog`) để kiểm tra thẻ trên khổ giấy ảo trước khi in thật. *Lưu ý: Phải điền đủ MSSV, Tên và Ảnh mới có thể xem.*

  2. **In thẻ:** Bấm nút **In** (`PrintDialog`) để gọi máy in thực tế thông qua đối tượng `PrintDocument`.

  3. **Lưu ảnh thẻ:** Bấm nút **Lưu ảnh thẻ** (chức năng nâng cao) để xuất trực tiếp chiếc thẻ đã thiết kế ra một file ảnh `.png` chất lượng cao lưu vào máy. Tên file sẽ được tự động gợi ý theo MSSV.

  4. **Làm mới:** Bấm nút **Làm mới** để xóa trắng toàn bộ Form, trả về trạng thái khởi tạo ban đầu.



## 4. Các điểm nhấn kỹ thuật

- **Kiến trúc hàm vẽ lõi (DRY Principle):** Thay vì viết code vẽ 2 lần, ứng dụng chỉ dùng đúng 1 hàm lõi `CoreDrawStudentCard(Graphics g)`. Hàm này được dùng chung để vẽ lên `Panel` (khi preview), vẽ lên `PrintPage` (khi in), và vẽ lên `Bitmap` (khi lưu file PNG), đảm bảo tính đồng nhất tuyệt đối 100% giữa bản xem trước và bản xuất ra.

- **Xử lý ảnh an toàn (Anti-Lock File):** Khi load ảnh từ máy tính, file gốc được đọc vào biến tạm, sau đó copy thành `Bitmap` mới và giải phóng lập tức bằng `Dispose()`. Kỹ thuật này giúp ứng dụng không "khóa" (lock) file ảnh gốc của người dùng trên Windows.

- **Thuật toán giữ nguyên tỷ lệ (Aspect Ratio):** Áp dụng phép toán `Math.Min` để tính toán khung bao chữ nhật, giúp ảnh đại diện dù có kích thước nào cũng được căn giữa và không bao giờ bị méo lệch khi vẽ lên thẻ.

- **Giao diện tùy chỉnh (Custom UI):** Sử dụng sự kiện `Paint` và `GraphicsPath` để cắt gọt, bo tròn (Border Radius) các nút bấm trực tiếp bằng code GDI+, tạo ra phong cách Modern Flat UI sang trọng mà không cần dùng thư viện ngoài cho UI.

- **Tự động hóa:** Tích hợp bộ mã hóa QR Code và khả năng bắt lỗi (Try-Catch) triệt để trong các tác vụ liên quan đến File I/O.



## 5. Hướng dẫn chạy chương trình

1. Giải nén thư mục bài làm `lab09.zip`.

2. Mở file dự án `Lab09.sln` hoặc `Lab09.csproj` bằng Visual Studio 2022.

3. Nhấn tổ hợp `Ctrl + Shift + B` để Build project (hệ thống sẽ tự động khôi phục các gói thư viện nếu có).

4. Nhấn `F5` hoặc nút **Start** trên thanh công cụ để khởi chạy ứng dụng.



## 6. Hình ảnh minh họa



- **Giao diện chính:**

  ![Giao diện](Hình%20ảnh%20lab09/Giao%20diện%20.png)



- **Xem trước bản in (Print Preview):**

  ![Print Preview](Hình%20ảnh%20lab09/Print%20Preview.png)



- **Các mẫu thẻ xuất ra file PNG (Mở rộng - Custom Color & QR Code):**

  ![Mẫu thẻ 1](Hình%20ảnh%20lab09/TheSV_49.01.104.175.png)

  ![Mẫu thẻ 2](Hình%20ảnh%20lab09/TheSV_50.01.104.170.png)

  ![Mẫu thẻ 3](Hình%20ảnh%20lab09/TheSV_50.01.104.171.png)

  ![Mẫu thẻ 4](Hình%20ảnh%20lab09/TheSV_50.01.104.172.png)

  ![Mẫu thẻ 5](Hình%20ảnh%20lab09/TheSV_50.01.104.173.png)

  ![Mẫu thẻ 6](Hình%20ảnh%20lab09/TheSV_50.01.104.174.png)

  ![Mẫu thẻ 7](Hình%20ảnh%20lab09/TheSV_50.01.104.176.png)

  ![Mẫu thẻ 8](Hình%20ảnh%20lab09/TheSV_50.01.104.177.png)

  ![Mẫu thẻ 9](Hình%20ảnh%20lab09/TheSV_50.01.104.178.png)