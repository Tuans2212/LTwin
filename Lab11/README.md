# Bài tập Lab 11 - Ứng dụng Quản lý Lớp học (ADO.NET & SQL Server)



## 1. Thông tin sinh viên

- **Họ và tên:** Nguyễn Văn Tuấn

- **Lớp:** 24CT1

- **Môn học:** Lập trình trên Windows (COMP1019)



## 2. Mô tả dự án

Project Lab 11 tập trung vào việc xây dựng ứng dụng C# Windows Forms kết nối và tương tác trực tiếp với cơ sở dữ liệu SQL Server (EduManagerDB) thông qua công nghệ ADO.NET. Dự án hiện thực hóa đầy đủ các thao tác CRUD (Thêm, Đọc, Sửa, Xóa) dữ liệu của bảng LOP, đồng thời áp dụng các kỹ thuật kiểm tra ràng buộc nghiệp vụ (Validation) và xử lý lỗi khóa ngoại.



## 3. Cấu trúc bài nộp

Bài làm được đóng gói trong một thư mục Solution hoàn chỉnh bao gồm các thành phần chính:



  1. **Lab11.sln / Thư mục project C#:** Chứa mã nguồn ứng dụng giao diện.

  2. **FrmLop.cs:** Tệp mã nguồn trung tâm xử lý giao diện, sự kiện người dùng và thực thi các câu lệnh tương tác SQL.

  3. **EduManagerDB.sql:** Script SQL khởi tạo cơ sở dữ liệu, tạo bảng (LOP, SINHVIEN) và chèn dữ liệu mẫu ban đầu để test ứng dụng.

  4. **Thư mục Hình ảnh Lab11:** Chứa các ảnh chụp màn hình minh chứng chức năng hoạt động.



## 4. Các điểm nhấn kỹ thuật

- **Bảo mật truy vấn (Anti SQL-Injection):** 100% các câu lệnh T-SQL (INSERT, UPDATE, DELETE, SELECT LIKE) đều sử dụng tham số hóa (`SqlParameter`) thay vì nối chuỗi trực tiếp.

- **Xử lý toàn vẹn dữ liệu (Foreign Key Constraint):** Trực tiếp kiểm tra logic trước khi xóa (đếm số sinh viên trong lớp) để ngăn chặn lỗi sập chương trình do vi phạm khóa ngoại.

- **Validation Dữ liệu:** Xử lý chặn lỗi người dùng chặt chẽ: cảnh báo thiếu thông tin, chặn nhập trùng mã lớp (Primary Key).

- **Giao diện hiện đại (UI/UX):** Tự động tùy chỉnh lại DataGridView (đổi màu header, bỏ viền, bôi đen nguyên dòng) và tự code vẽ bo tròn các nút bấm (sử dụng `GraphicsPath`) giúp form chuyên nghiệp, bắt mắt hơn.



## 5. Hướng dẫn chạy chương trình

1. Giải nén thư mục bài làm `Lab11.zip`.

2. Mở phần mềm **SQL Server Management Studio (SSMS)**:

   - Mở file `EduManagerDB.sql`.

   - Nhấn `F5` (Execute) để tạo database và dữ liệu mẫu.

3. Chạy ứng dụng C#:

   - Mở file `Lab11.sln` bằng **Visual Studio**.

   - (Tùy chọn) Mở file `FrmLop.cs` và kiểm tra lại dòng biến `chuoiKetNoi`.

   - Nhấn `F5` để Start ứng dụng.



## 6. Ghi chú Connection String (Yêu cầu nộp bài)

Chuỗi kết nối (Connection string) đang được sử dụng và chạy thành công trên máy cá nhân:

Data Source=.DESKTOP-LLS5J07\SQLEXPRESS;Initial Catalog=EduManagerDB;Integrated Security=True;TrustServerCertificate=True



## 7. Hình ảnh minh họa kết quả chạy ứng dụng



  - **Giao diện load dữ liệu thành công từ SQL Server:**

    ![Giao diện load dữ liệu](Hình%20ảnh%20Lab11/KetQua.png)



  - **Bắt lỗi khóa ngoại (Chặn xóa lớp CNTT01 do đang có sinh viên):**

    ![Lỗi xóa lớp có sinh viên](Hình%20ảnh%20Lab11/Không%20thể%20xóa%20lớp%20có%20SV.png)
