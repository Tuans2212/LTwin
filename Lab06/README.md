# Bài tập Lab 06 - Ứng dụng Quản lý Sản phẩm

## 1. Thông tin sinh viên
- **Họ và tên:** Nguyễn Văn Tuấn
- **MSSV:** 50.01.104.175
- **Lớp:** 50.01.CNTT.A
- **Môn học:** Lập trình trên Windows (COMP1019)

## 2. Mô tả dự án
Project Lab 06 xây dựng bằng C# (WinForms), mô phỏng ứng dụng quản lý danh sách sản phẩm cơ bản. Dữ liệu được lưu trữ tạm thời trong bộ nhớ bằng `BindingList`, tập trung vào việc thực hành các thao tác trực tiếp trên lưới `DataGridView` và xử lý các control giao diện nâng cao.

## 3. Hướng dẫn thao tác
Giao diện chia làm hai khu vực chính: Bảng danh sách sản phẩm ở trên và Khu vực nhập thông tin ở dưới. Các chức năng điều khiển được tích hợp trên thanh công cụ (ToolStrip).

- **Thêm sản phẩm mới:** 
  1. Điền thông tin vào các trường bên dưới (Mã SP, Tên SP, Loại, Đơn giá, Số lượng, Ngày nhập).
  2. Nhấn nút **Chọn Ảnh** để tải hình minh họa lên (nếu có).
  3. Nhấn biểu tượng **Thêm (+)** trên thanh công cụ. Dữ liệu sẽ lập tức được đẩy lên bảng.
  *(Lưu ý: Nếu bỏ trống thông tin hoặc nhập trùng Mã SP, hệ thống sẽ hiện chấm đỏ báo lỗi ngay tại ô nhập liệu và từ chối lưu).*

- **Cập nhật thông tin (Sửa):**
  1. Click chọn một dòng sản phẩm bất kỳ trên bảng dữ liệu.
  2. Thông tin (bao gồm cả hình ảnh) sẽ tự động nạp xuống các ô nhập liệu bên dưới.
  3. Tiến hành chỉnh sửa nội dung và nhấn biểu tượng **Sửa** trên thanh công cụ.

- **Xóa sản phẩm:**
  1. Click chọn dòng sản phẩm cần xóa trên bảng.
  2. Nhấn biểu tượng **Xóa (dấu X đỏ)** trên thanh công cụ hoặc click chuột phải chọn lệnh Xóa.
  3. Hộp thoại xác nhận sẽ hiện ra để tránh thao tác nhầm. Chọn "Yes" để hoàn tất.

- **Tìm kiếm nhanh:**
  Nhập từ khóa (mã hoặc tên sản phẩm) vào ô trống trên thanh công cụ, sau đó nhấn biểu tượng **Kính lúp**. Bảng dữ liệu sẽ tự động lọc ra các kết quả trùng khớp.

## 4. Các điểm nhấn kỹ thuật
- **Đồng bộ dữ liệu tự động:** Sử dụng `BindingList` làm `DataSource` cho DataGridView. Bảng dữ liệu sẽ tự động làm mới ngay khi có thao tác Thêm, Sửa, hoặc Xóa mà không cần viết hàm load lại thủ công.
- **Validation trực quan:** Sử dụng `ErrorProvider` để kiểm tra tính hợp lệ của dữ liệu đầu vào (số âm, ngày tương lai, mã trùng), giúp cảnh báo lỗi chính xác vị trí mà không gây gián đoạn trải nghiệm như `MessageBox`.
- **Phản hồi trạng thái liên tục:** Thanh `StatusStrip` dưới cùng góc trái luôn cập nhật thao tác vừa thực hiện và đếm tổng số lượng sản phẩm hiện có trong danh sách.

## 5. Hướng dẫn chạy chương trình
1. Giải nén thư mục bài làm.
2. Mở file `.sln` bằng Visual Studio.
3. Nhấn tổ hợp `Ctrl + Shift + B` để Build project.
4. Nhấn `F5` hoặc nút Start để khởi chạy ứng dụng.

## 6. Hình ảnh minh họa

![Giao diện Quản lý](Hình%20Ảnh%20Lab06/Giao%20Diện.png)
