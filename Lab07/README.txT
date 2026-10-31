# Bài tập Lab 07 - Ứng dụng Quản lý Cửa hàng Mini

## 1. Thông tin sinh viên
- **Họ và tên:** Nguyễn Văn Tuấn
- **MSSV:** 50.01.104.175
- **Lớp:** 50.01.CNTT.A
- **Môn học:** Lập trình trên Windows (COMP1019)

## 2. Mô tả dự án
Project Lab 07 được xây dựng bằng C# (Windows Forms, .NET 8), mô phỏng một hệ thống quản lý cửa hàng mini toàn diện bao gồm phân quyền đăng nhập, giao diện chính dạng MDI Container, quản lý danh mục sản phẩm và quản lý khách hàng. Ứng dụng tập trung thực hành thiết kế đa form, xử lý sự kiện menu, điều hướng form con và thao tác dữ liệu trực quan trên lưới `DataGridView`.

## 3. Hướng dẫn thao tác
Ứng dụng được chia thành các phân hệ thao tác chính sau:

- **Đăng nhập hệ thống (`FrmLogin`):**
  1. Khởi động ứng dụng, hộp thoại đăng nhập sẽ hiển thị.
  2. Nhập tài khoản (`admin` hoặc `user`) và mật khẩu (`123`).
  3. Nhấn **Đăng nhập** để vào màn hình chính (hoặc **Thoát** để đóng ứng dụng).

- **Giao diện chính (`FrmMain` & MDI Container):**
  - Thanh menu (`MenuStrip`) chứa các chức năng điều hướng:
    - **Hệ thống:** Đăng xuất tài khoản hoặc Thoát ứng dụng.
    - **Danh mục:** Mở form Quản lý sản phẩm hoặc Quản lý khách hàng.
    - **Trợ giúp:** Xem thông tin Giới thiệu.
  - Thanh trạng thái (`StatusStrip`) bên dưới hiển thị thông tin sinh viên, MSSV, vai trò người dùng và đồng hồ thời gian thực cập nhật từng giây.

- **Quản lý sản phẩm (`FrmProduct`):**
  1. **Thêm:** Nhập mã SP, tên SP, loại, đơn giá, số lượng vào các ô nhập liệu bên dưới rồi bấm **Thêm**. (Hệ thống có kiểm tra rỗng, trùng mã và định dạng số không âm).
  2. **Sửa:** Click chọn một dòng sản phẩm trên bảng, thông tin sẽ tự động đổ lên ô nhập. Chỉnh sửa nội dung rồi bấm **Sửa**.
  3. **Xóa:** Chọn dòng sản phẩm trên bảng, bấm **Xóa** và xác nhận "Yes" để xóa.
  4. **Tìm kiếm:** Nhập từ khóa vào ô tìm kiếm và bấm **Tìm kiếm** để lọc nhanh danh sách.
  5. **Làm mới:** Xóa trống ô nhập liệu và reset lại bảng dữ liệu ban đầu.

- **Quản lý khách hàng (`FrmCustomer`):**
  1. **Thêm:** Điền mã KH, họ tên, điện thoại, loại khách hàng rồi bấm **Thêm**.
  2. **Xóa:** Chọn khách hàng trên bảng và bấm **Xóa**.
  3. **Làm mới:** Reset lại form nhập liệu.

## 4. Các điểm nhấn kỹ thuật
- **Kiến trúc MDI (Multiple Document Interface):** Giao diện chính quản lý các form con (`FrmProduct`, `FrmCustomer`, `FrmAbout`) với thuật toán kiểm tra chống mở trùng form, giúp người dùng dễ dàng thao tác song song.
- **Đồng bộ dữ liệu tự động:** Sử dụng `BindingList<T>` làm `DataSource` cho các `DataGridView`, giúp lưới tự động cập nhật ngay lập tức khi thêm/sửa/xóa phần tử mà không cần thủ công load lại.
- **Xác thực bảo mật cơ bản:** Form đăng nhập chạy ở chế độ `ShowDialog()` chặn luồng chính, bắt buộc xác thực thành công mới mở được màn hình quản lý.
- **Xử lý ngoại lệ & Validate:** Kiểm tra tính hợp lệ của dữ liệu đầu vào (đơn giá, số lượng phải >= 0, mã không được trùng) trước khi thực thi thao tác.

## 5. Hướng dẫn chạy chương trình
1. Giải nén thư mục bài làm `Lab07.zip`.
2. Mở file dự án hoặc file `.csproj` bằng Visual Studio.
3. Nhấn tổ hợp `Ctrl + Shift + B` để Build project.
4. Nhấn `F5` hoặc nút **Start** trên thanh công cụ để khởi chạy ứng dụng.

## 6. Hình ảnh minh họa

* **Giao diện Đăng nhập:**
  ![Giao diện Login](Hình%20Ảnh%20Lab07/Giao%20Diện%20Login.png)

* **Giao diện Thao tác Chính (MDI):**
  ![Giao diện Thao Tác Chính](Hình%20Ảnh%20Lab07/Giao%20Diện%20Thao%20Tác%20Chính.png)

* **Form Giới thiệu:**
  ![Giới thiệu](Hình%20Ảnh%20Lab07/Giới%20thiệu.png)

* **Quản lý Khách hàng:**
  ![Quản Lý Khách Hàng](Hình%20Ảnh%20Lab07/Quản%20Lý%20Khách%20Hàng.png)

* **Quản lý Sản phẩm:**
  ![Quản Lý Sản Phẩm](Hình%20Ảnh%20Lab07/Quản%20Lý%20Sản%20Phẩm.png)