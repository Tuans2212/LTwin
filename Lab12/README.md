# Bài tập Lab 12 - Data Binding, Stored Procedure và Transaction (ADO.NET & SQL Server)



## 1. Thông tin sinh viên

- **Họ và tên:** Nguyễn Văn Tuấn

- **Lớp:** 24CT1

- **Môn học:** Lập trình trên Windows (COMP1019)



## 2. Mô tả dự án

Project Lab 12 xây dựng module Quản lý kết quả học tập sinh viên bằng C# Windows Forms, kết nối SQL Server qua công nghệ ADO.NET. Ứng dụng áp dụng Data Binding để liên kết dữ liệu giữa DataTable, BindingSource với ComboBox và DataGridView, sử dụng Stored Procedure với SqlParameter để thao tác dữ liệu, đồng thời hiện thực hóa cơ chế giao dịch (Transaction) để lưu đồng loạt nhiều dòng điểm an toàn với khả năng Rollback tự động khi phát sinh lỗi.



## 3. Cấu trúc bài nộp

Bài làm được đóng gói trong một thư mục Solution hoàn chỉnh:

  1. QLSinhVienLab12.sln / Thư mục source code: Chứa toàn bộ mã nguồn ứng dụng C#.

  2. Database/QLSinhVienLab12.sql: Script SQL tạo cơ sở dữ liệu, các bảng (LOP, SINHVIEN, MONHOC, KETQUA) có ràng buộc khóa chính, khóa ngoại, kiểm tra điểm và 4 Stored Procedure bắt buộc.

  3. DAL/: Chứa lớp Database.cs (lưu chuỗi kết nối) và KetQuaDAL.cs (giao tiếp CSDL, Transaction).

  4. Forms/: Chứa FrmNhapDiemTheoLop.cs quản lý giao diện và nghiệp vụ nhập điểm.

  5. Thư mục Hình ảnh lab12/: Chứa các ảnh chụp màn hình minh chứng kết quả chạy chương trình.



## 4. Các điểm nhấn kỹ thuật

- **Data Binding:** Sử dụng BindingSource làm cầu nối hiển thị và đồng bộ dữ liệu mượt mà giữa cơ sở dữ liệu và các control trên Form.

- **Transaction an toàn:** Khi bấm "Lưu tất cả", chương trình mở SqlTransaction để ghi nhận điểm của toàn bộ danh sách; nếu bất kỳ dòng nào không hợp lệ, hệ thống sẽ Rollback toàn bộ để đảm bảo tính toàn vẹn dữ liệu.

- **Validation chặt chẽ:** Kiểm tra dữ liệu điểm trước khi lưu (bắt lỗi để trống, kiểm tra định dạng số, giới hạn điểm trong khoảng từ 0 đến 10).

- **Tính năng mở rộng:** Tích hợp ô tìm kiếm nhanh trực tiếp trên BindingSource và khung thống kê tự động cập nhật sĩ số, điểm trung bình, số sinh viên đạt >= 5.0.

- **Giao diện hiện đại (UI/UX):** Phân chia bố cục 2 cột gọn gàng, nút bấm bo tròn tinh tế bằng GraphicsPath và tùy chỉnh giao diện DataGridView chuyên nghiệp.



## 5. Hướng dẫn chạy chương trình

1. Giải nén thư mục bài làm `MSSV_HoTen_Lab12.zip`.

2. Mở phần mềm SQL Server Management Studio (SSMS):

   - Mở file `Database/QLSinhVienLab12.sql`.

   - Nhấn F5 (Execute) để tạo database, bảng và dữ liệu mẫu.

3. Chạy ứng dụng C#:

   - Mở file `QLSinhVienLab12.sln` bằng Visual Studio.

   - Mở file `DAL/Database.cs` và kiểm tra chuỗi kết nối cho khớp với máy cá nhân.

   - Nhấn F5 để Start ứng dụng.



## 6. Ghi chú Connection String (Yêu cầu nộp bài)

Chuỗi kết nối (Connection string) đang được sử dụng và chạy thành công trên máy cá nhân:

Data Source=DESKTOP-LLS5J07\SQLEXPRESS;Initial Catalog=QLSinhVienLab12;Integrated Security=True;TrustServerCertificate=True



## 7. Hình ảnh minh họa kết quả chạy ứng dụng



  - **Giao diện chính khi vừa khởi động:**

    ![Giao diện](Hình%20ảnh%20lab12/Giao%20diện.png)



  - **Danh sách sinh viên trước khi sửa điểm:**

    ![Trước sửa điểm](Hình%20ảnh%20lab12/Trước%20sửa%20điểm.png)



  - **Bắt lỗi dữ liệu điểm và Rollback transaction:**

    ![Lỗi điểm](Hình%20ảnh%20lab12/Lỗi%20Điểm.png)



  - **Giao diện sau khi sửa và lưu điểm thành công:**

    ![Sau khi sửa điểm](Hình%20ảnh%20lab12/Sau%20khi%20sửa%20điểm.png)