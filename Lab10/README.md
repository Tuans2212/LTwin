# Bài tập Lab 10 - Thiết kế và Cài đặt CSDL EduManagerDB (SQL Server)

## 1. Thông tin sinh viên
- **Họ và tên:** Nguyễn Văn Tuấn
- **Lớp:** K50CNTTA
- **Môn học:** Lập trình trên Windows (COMP1019)

## 2. Mô tả dự án
Project Lab 10 tập trung vào việc thiết kế và cài đặt cơ sở dữ liệu quan hệ cho hệ thống quản lý sinh viên (EduManagerDB) bằng hệ quản trị cơ sở dữ liệu SQL Server. Dự án bao gồm việc khởi tạo cấu trúc dữ liệu, định nghĩa các bảng, thiết lập các mối quan hệ (khóa chính, khóa ngoại), áp dụng các ràng buộc dữ liệu (Check Constraints), nạp dữ liệu mẫu và thực thi các câu truy vấn T-SQL từ cơ bản đến nâng cao. 

## 3. Cấu trúc bài nộp
Bài làm bao gồm 3 file kịch bản (script) chính, được phân chia theo luồng thực thi:

  1. **01_CreateDatabase.sql:** Script tạo Database `EduManagerDB` và định nghĩa 6 bảng (KHOA, LOP, SINHVIEN, MONHOC, KETQUA, TAIKHOAN) với đầy đủ kiểu dữ liệu và ràng buộc.
  2. **02_InsertSampleData.sql:** Script dọn dẹp dữ liệu cũ (chống lỗi khi chạy lại) và nạp bộ dữ liệu mẫu chuẩn vào các bảng theo đúng thứ tự logic của khóa ngoại.
  3. **03_Queries.sql:** Tổng hợp 12 câu lệnh T-SQL để truy xuất dữ liệu (SELECT, JOIN, GROUP BY), thao tác dữ liệu (UPDATE, DELETE) và kiểm thử các ràng buộc an toàn của DB (Test lỗi).

## 4. Các điểm nhấn kỹ thuật
- **Thiết kế CSDL chuẩn:** Xây dựng cấu trúc bảng chặt chẽ, đảm bảo tính toàn vẹn tham chiếu thông qua hệ thống Foreign Key giữa Lớp - Khoa, Sinh Viên - Lớp, và Kết Quả - Sinh Viên/Môn Học.
- **Ràng buộc dữ liệu an toàn (Constraints):** Sử dụng `CHECK CONSTRAINT` để chặn các dữ liệu rác ngay từ mức Database (VD: Điểm chỉ từ 0-10, Giới tính chỉ nhận 'Nam'/'Nữ', Tín chỉ > 0).
- **T-SQL tối ưu và dễ đọc:** Các câu truy vấn được viết rõ ràng, đặt alias (bí danh) dễ hiểu. Tận dụng tốt các mệnh đề `JOIN` và `GROUP BY ... HAVING` thay vì viết các sub-queries rườm rà.
- **Kiểm thử triệt để:** Cung cấp sẵn các kịch bản test ngoại lệ (nhập điểm 11.5, thêm sinh viên vào lớp không tồn tại) để chứng minh thiết kế DB hoạt động bắt lỗi chính xác.

## 5. Hướng dẫn chạy script
1. Giải nén thư mục bài làm `Lab10_LTrinhWindows_NguyenVanTuan.zip`.
2. Mở phần mềm **SQL Server Management Studio (SSMS)** và kết nối vào server.
3. Lần lượt mở và chạy (`F5` hoặc nhấn `Execute`) các file theo thứ tự:
   - Chạy `01_CreateDatabase.sql` để tạo CSDL.
   - Chạy `02_InsertSampleData.sql` để nạp dữ liệu.
   - Mở file `03_Queries.sql`. Khuyến nghị: Bôi đen (Select) từng câu lệnh truy vấn rồi nhấn `F5` để xem kết quả của từng câu. Đối với phần kiểm thử lỗi (câu 11, 12), hãy bỏ comment hoặc bôi đen phần code đó rồi chạy để xem SQL Server văng lỗi đỏ.

## 6. Hình ảnh minh họa kết quả truy vấn chính

  - **Truy vấn câu 2 (JOIN thông tin Sinh viên - Lớp - Khoa):**
    ![Truy vấn câu 2](Hình%20ảnh%20lab10/Truy%20vấn%20câu%202.png)

  - **Truy vấn câu 7 (Liệt kê điểm theo từng môn học):**
    ![Truy vấn câu 7](Hình%20ảnh%20lab10/Truy%20vấn%20câu%207.png)

  - **Truy vấn câu 8 (Gom nhóm tính điểm trung bình):**
    ![Truy vấn câu 8](Hình%20ảnh%20lab10/Truy%20vấn%20câu%208.png)

  - **Truy vấn câu 10 (Lọc HAVING các lớp >2 sinh viên):**
    ![Truy vấn câu 10](Hình%20ảnh%20lab10/Truy%20vấn%20câu%2010.png)

  - **Lỗi câu 11 (Bắt lỗi Foreign Key khi thêm sai lớp):**
    ![Lỗi câu 11](Hình%20ảnh%20lab10/Lỗi%20câu%2011.png)

  - **Lỗi câu 12 (Bắt lỗi Check Constraint khi nhập điểm >10):**
    ![Lỗi câu 12](Hình%20ảnh%20lab10/Lỗi%20câu%2012.png)
