# Bài tập Lab 04 - Exception, Delegate/Event, Func/Action và Generic trong C#

## 1. Thông tin sinh viên

- **Họ và tên:** Nguyễn Văn Tuấn
- **Lớp:** 50CNTTA
- **Môn học:** Lập trình trên Windows (COMP1019)

## 2. Mô tả dự án

Project Lab 04 xây dựng chương trình Console quản lý sản phẩm bằng ngôn ngữ C#. Ứng dụng lưu trữ và thao tác dữ liệu trên bộ nhớ thông qua lớp Generic `Repository<T>`, kết hợp xử lý nghiệp vụ tại lớp `ProductService`. Chương trình áp dụng cơ chế bắt lỗi `try-catch` cùng các Exception tự định nghĩa để kiểm soát lỗi nhập liệu, trùng mã hoặc sản phẩm không tồn tại; đồng thời sử dụng `Action` event để thông báo tự động khi dữ liệu thay đổi và `Func<Product, bool>` để tìm kiếm, lọc sản phẩm theo điều kiện.

## 3. Cấu trúc bài nộp

Bài làm được đóng gói trong một thư mục Solution hoàn chỉnh:

  1. `Lab4.sln` / Thư mục `Lab4/`: Chứa toàn bộ mã nguồn ứng dụng Console App C#.
  2. `IEntity.cs`: Interface định nghĩa thuộc tính `Id` dùng làm ràng buộc (constraint) cho lớp Generic `Repository<T>`.
  3. `Product.cs`: Lớp thực thể sản phẩm (`MaSP`, `TenSP`, `Price`, `Quantity`) thực thi `IEntity`, kiểm tra dữ liệu đầu vào không âm và định dạng chuỗi hiển thị `ToString()`.
  4. `DuplicateProductException.cs` & `ProductNotFoundException.cs`: Hai lớp Exception tự tạo phát sinh khi thêm trùng mã sản phẩm hoặc khi thao tác trên mã sản phẩm không tồn tại.
  5. `Repository.cs`: Lớp Generic `Repository<T> where T : IEntity` quản lý danh sách đối tượng với các phương thức `Add`, `Remove`, `FindById`, `Find`, `GetAll`.
  6. `ProductService.cs`: Lớp xử lý nghiệp vụ (`AddProduct`, `RemoveProduct`, `FindById`, `Search`, `Filter`, `TinhTongGiaTriKho`), gọi `Repository<Product>` và phát sự kiện `OnProductChanged`.
  7. `Program.cs`: Xây dựng hệ thống Menu điều khiển chương trình, xử lý nhập xuất dữ liệu và bắt các ngoại lệ (`try-catch`).
  8. Thư mục `Hình ảnh lab4/`: Chứa ảnh chụp màn hình minh chứng kết quả chạy chương trình.

## 4. Các điểm nhấn kỹ thuật

- **Generic Repository (`Repository<T>`):** Xây dựng lớp lưu trữ tổng quát có ràng buộc `where T : IEntity`, tách biệt hoàn toàn tầng lưu trữ dữ liệu khỏi tầng giao diện Console.
- **Xử lý ngoại lệ chặt chẽ (Custom Exception & Try-Catch):** Tự định nghĩa `DuplicateProductException` và `ProductNotFoundException` kết hợp bắt lỗi `FormatException`, `ArgumentException` đảm bảo chương trình hoạt động ổn định, không bị dừng đột ngột khi người dùng nhập sai kiểu dữ liệu.
- **Sự kiện (`Action<string>` Event):** Khai báo sự kiện `OnProductChanged` trong `ProductService` để tự động phát thông báo ra màn hình mỗi khi thêm mới hoặc xóa sản phẩm thành công.
- **Ứng dụng `Func<Product, bool>`:** Sử dụng biểu thức điều kiện truyền vào hàm `Find` và `Filter` để tìm kiếm sản phẩm theo từ khóa tên và lọc sản phẩm theo khoảng giá `[Min, Max]`.
- **Trình bày giao diện Console trực quan:** Phân tách rõ ràng từng chức năng trong Menu, hỗ trợ hiển thị tiếng Việt có dấu (UTF-8), kẻ bảng danh sách sản phẩm thẳng cột và tích hợp sẵn dữ liệu mẫu phục vụ kiểm thử nhanh.

## 5. Hướng dẫn chạy chương trình

1. Giải nén thư mục bài làm (hoặc clone từ kho lưu trữ GitHub cá nhân).
2. Mở file `Lab4.sln` bằng phần mềm **Visual Studio**.
3. Nhấn phím `F5` (hoặc `Ctrl + F5`) để biên dịch và khởi chạy ứng dụng Console.
4. Nhập các phím số từ `1` đến `7` trên bàn phím để thực hiện từng chức năng quản lý sản phẩm, hoặc nhấn `0` để thoát chương trình.

## 6. Hình ảnh minh họa kết quả chạy ứng dụng

  - **Giao diện Menu chính của chương trình:**

    ![Giao diện Menu](Hình%20ảnh%20lab4/Menu.png)
