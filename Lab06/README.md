# Bài tập Lab 06 - Ứng dụng Quản lý Sản phẩm

## 1. Thông tin sinh viên
- **Họ và tên:** Nguyễn Văn Tuấn
- **MSSV:** 50.01.104.175
- **Lớp:** 50.01.CNTT.A
- **Môn học:** Lập trình trên Windows (COMP1019)

## 2. Mô tả bài làm
Đây là project Lab 06 viết bằng C# (WinForms). Bài này yêu cầu quản lý danh sách sản phẩm của cửa hàng. Dữ liệu được mình lưu tạm trong bộ nhớ (dùng `BindingList`) chứ chưa kết nối Database, chủ yếu để thực hành các thao tác trên lưới `DataGridView` và xử lý giao diện.

## 3. Hướng dẫn thao tác trên phần mềm (Cách dùng)

Giao diện được chia làm 2 phần chính: Bảng danh sách ở trên và Khu vực nhập liệu ở dưới. Các chức năng chính đều nằm trên thanh công cụ (ToolStrip) trên cùng.

- **Cách Thêm sản phẩm mới:** 
  1. Bạn nhập đầy đủ thông tin vào các ô ở nửa dưới form (Mã SP, Tên SP, Loại, Giá...).
  2. Bấm nút **Chọn Ảnh** để chèn hình minh họa nếu muốn.
  3. Bấm vào icon **Thêm (dấu +)** trên thanh công cụ. Sản phẩm sẽ tự động nhảy lên bảng.
  *(Lưu ý: Nếu nhập trùng Mã SP hoặc bỏ trống Tên, phần mềm sẽ hiện chấm đỏ báo lỗi ngay tại ô đó chứ không cho thêm).*

- **Cách Sửa thông tin:**
  1. Click chuột vào một dòng sản phẩm bất kỳ trên bảng.
  2. Toàn bộ thông tin (kể cả hình ảnh) sẽ tự động nảy xuống các ô nhập liệu bên dưới.
  3. Bạn sửa lại thông tin ở các ô dưới, sau đó bấm icon **Sửa** trên thanh công cụ để cập nhật.

- **Cách Xóa sản phẩm:**
  1. Click chọn dòng muốn xóa trên bảng.
  2. Bấm icon **Xóa (dấu X màu đỏ)** trên thanh công cụ (hoặc click chuột phải chọn Xóa).
  3. Sẽ có một hộp thoại hiện lên hỏi "Bạn có chắc chắn muốn xóa không?" để tránh bấm nhầm. Chọn Yes để xóa.

- **Tìm kiếm nhanh:**
  Bạn gõ từ khóa (mã hoặc tên sản phẩm) vào ô trống dài trên thanh công cụ, rồi bấm vào nút **Kính lúp**. Bảng sẽ tự động lọc ra các sản phẩm trùng khớp.

## 4. Một số điểm cộng mình đã xử lý trong code
- **Tự động đồng bộ:** Mình dùng `BindingList` làm nguồn cho DataGridView, nên khi Thêm/Sửa/Xóa xong là bảng tự động thay đổi, không cần phải viết hàm load lại lưới thủ công.
- **Bắt lỗi thông minh:** Thay vì dùng `MessageBox` báo lỗi ầm ĩ, mình dùng `ErrorProvider`. Nhập sai ở đâu (ví dụ đơn giá âm, nhập ngày ở tương lai), nó sẽ nháy chấm đỏ ngay bên cạnh ô đó.
- **Thanh trạng thái:** Dưới cùng góc trái màn hình, mình có làm một thanh `StatusStrip` để đếm tổng số lượng sản phẩm hiện có và báo cho người dùng biết họ vừa làm thao tác gì (ví dụ: "Đã chọn ảnh sản phẩm | Số sản phẩm: 3").

## 5. Cách chạy project
1. Giải nén file nộp bài.
2. Mở file `.sln` bằng Visual Studio.
3. Nhấn `Ctrl + Shift + B` để Build project cho mượt.
4. Bấm `F5` (hoặc nút Start) để chạy form. 
5. Bạn có thể bấm thử vào các dòng có sẵn (như Chuột không dây, Bút bi) để xem dữ liệu đẩy xuống dưới nhé!

## 6. Hình ảnh Demo giao diện

![Giao diện Quản lý](Hình%20Ảnh%20Lab06/Giao%20Diện.png)
