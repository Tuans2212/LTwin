# Bài tập Lab 14 - Entity Framework Core và Mô hình ba lớp (3-Layer)

## 1. Thông tin sinh viên
- **Họ và tên:** Nguyễn Văn Tuấn
- **Lớp:** 50CNTTA
- **Môn học:** Lập trình trên Windows (COMP1019)

## 2. Mô tả bài làm
Bài tập xây dựng phân hệ **Quản lý danh mục môn học (`EduManager`)** trên nền tảng C# Windows Forms (.NET 8.0), kết nối cơ sở dữ liệu SQL Server thông qua **Entity Framework Core** và tổ chức mã nguồn theo kiến trúc 3 lớp (**GUI - BLL - DAL**). Chương trình đáp ứng đầy đủ các chức năng tải danh sách, thêm mới, sửa, xóa có xác nhận, tìm kiếm theo mã/tên môn học và kiểm tra dữ liệu đầu vào tại tầng nghiệp vụ.

## 3. Cấu trúc thư mục
```text
Lab14/
├── Database/
│   └── EduManagerDB.sql          # Script tạo CSDL EduManagerDB và bảng MONHOC
├── EduManager/
│   ├── Models/
│   │   └── MonHoc.cs             # Lớp thực thể ánh xạ bảng MONHOC
│   ├── Data/
│   │   └── EduManagerContext.cs  # Lớp DbContext cấu hình kết nối SQL Server
│   ├── DAL/
│   │   └── MonHocDAL.cs          # Tầng truy xuất dữ liệu bằng EF Core
│   ├── BLL/
│   │   └── MonHocBLL.cs          # Tầng xử lý nghiệp vụ và kiểm tra hợp lệ (Validation)
│   ├── GUI/
│   │   ├── FrmMonHoc.cs          # Xử lý sự kiện trên Form và gọi tầng BLL
│   │   └── FrmMonHoc.Designer.cs # Thiết kế giao diện Form FrmMonHoc
│   ├── Program.cs                # Điểm bắt đầu chạy ứng dụng
│   └── EduManager.csproj         # File cấu hình project và gói NuGet EF Core
├── Hình ảnh Lab14/               # Ảnh chụp màn hình kết quả chạy thực tế
├── EduManager.sln                # File Solution mở bằng Visual Studio
└── README.md                     # File báo cáo ngắn, test case và trả lời câu hỏi
```

## 4. Hướng dẫn cài đặt và chạy chương trình
1. Mở **SQL Server Management Studio (SSMS)**, mở file `Database/EduManagerDB.sql` và nhấn **F5 (Execute)** để tạo database `EduManagerDB` cùng bảng `MONHOC` và dữ liệu mẫu.
2. Mở file `EduManager.sln` bằng **Visual Studio 2022**.
3. Kiểm tra lại chuỗi kết nối trong file `Data/EduManagerContext.cs`:
   ```text
   Data Source=DESKTOP-LLS5J07\SQLEXPRESS;Initial Catalog=EduManagerDB;Integrated Security=True;TrustServerCertificate=True
   ```
   *(Nếu chạy trên máy khác thì đổi lại tên `Data Source` cho khớp với tên SQL Server của máy).*
4. Nhấn **F5** để biên dịch và chạy chương trình.

## 5. Kịch bản kiểm thử (Test Cases)

| Mã TC | Chức năng kiểm thử | Dữ liệu đầu vào | Kết quả mong đợi | Kết quả thực tế |
| :--- | :--- | :--- | :--- | :--- |
| **TC01** | Tải danh sách khi mở Form | Khởi chạy `FrmMonHoc` | Hiển thị đầy đủ 7 môn học mẫu từ bảng `MONHOC` lên lưới `dgvMonHoc` | Đạt |
| **TC02** | Thêm môn học hợp lệ | Mã: `COMP1050`, Tên: `Lập trình Web`, Số TC: `3`, Trạng thái: `Checked` | Thông báo thêm thành công, bảng cập nhật dòng mới và xóa trắng ô nhập | Đạt |
| **TC03** | Thêm trùng mã môn học | Mã: `COMP1019` (đã có), Tên: `Môn kiểm thử`, Số TC: `3` | Cảnh báo mã môn học `COMP1019` đã tồn tại, không lưu xuống CSDL | Đạt |
| **TC04** | Bỏ trống mã hoặc tên môn | Để trống `txtMaMonHoc` hoặc `txtTenMonHoc`, nhấn `Thêm mới` | BLL chặn lại và hiện thông báo yêu cầu không được để trống | Đạt |
| **TC05** | Chọn dòng trên bảng | Click vào dòng môn `COMP1019` trên `dgvMonHoc` | Đổ dữ liệu lên các ô nhập bên trên, ô `txtMaMonHoc` tự động khóa lại | Đạt |
| **TC06** | Sửa thông tin môn học | Chọn môn `COMP1010`, sửa Số tín chỉ thành `4`, nhấn `Sửa môn` | Báo cập nhật thành công, dữ liệu mới hiển thị trên `dgvMonHoc` | Đạt |
| **TC07** | Xóa môn học có xác nhận | Chọn môn `COMP1002`, nhấn `Xóa môn` -> chọn `Yes` | Hiện hộp thoại hỏi xác nhận trước khi xóa; bấm Yes thì xóa khỏi CSDL | Đạt |
| **TC08** | Tìm kiếm môn học | Nhập từ khóa `"Lập trình"` vào `txtTimKiem`, nhấn `Tìm kiếm` | Lưới lọc và hiển thị 2 môn có chữ `"Lập trình"` (`COMP1013`, `COMP1019`) | Đạt |
| **TC09** | Làm mới Form | Nhấn nút `Làm mới` | Mở khóa ô mã môn học, xóa trắng các ô nhập và tải lại toàn bộ danh sách | Đạt |

## 6. Trả lời câu hỏi nộp kèm

**Câu 8: Vì sao không nên viết toàn bộ code CRUD trong sự kiện Button Click?**
- Nếu viết chung cả code kiểm tra dữ liệu, kết nối CSDL và truy vấn trực tiếp trong hàm `Button_Click` thì code trong Form sẽ rất dài và rối.
- Khi bảng trong SQL thay đổi (ví dụ đổi tên cột hoặc kiểu dữ liệu), người viết phải mở từng Form, tìm từng nút bấm để sửa lại rất mất thời gian và dễ sót lỗi.
- Ngoài ra, nếu có form khác cũng cần lấy danh sách môn học thì không tái sử dụng được mà phải copy lại code, đồng thời khi làm đồ án nhóm sẽ rất dễ bị đụng code (conflict) trên cùng một file Form.

**Câu 9: BLL và DAL khác nhau ở điểm nào?**
- **DAL (Data Access Layer):** Chỉ tập trung vào việc đóng mở kết nối và làm việc trực tiếp với cơ sở dữ liệu qua `DbContext` (lấy danh sách, thêm, sửa, xóa, tìm kiếm). DAL không tự kiểm tra xem dữ liệu đó có đúng quy định nghiệp vụ hay không.
- **BLL (Business Logic Layer):** Nằm ở giữa GUI và DAL, có nhiệm vụ kiểm tra tính hợp lệ của dữ liệu và các quy tắc nghiệp vụ (như kiểm tra rỗng, kiểm tra số tín chỉ từ 1 đến 6, kiểm tra trùng mã môn học). Khi dữ liệu đạt yêu cầu thì BLL mới gọi xuống DAL để lưu vào SQL Server.

**Câu 10: Entity Framework khác ADO.NET ở điểm nào?**
- Với **ADO.NET**, mình phải tự tạo `SqlConnection`, `SqlCommand`, tự viết câu lệnh SQL dạng chuỗi (`SELECT`, `INSERT`, `UPDATE`, `DELETE`) rồi đọc dữ liệu qua `SqlDataReader` hoặc `DataTable`. Nếu gõ sai tên bảng hay tên cột trong chuỗi SQL thì lúc chạy chương trình mới phát hiện lỗi.
- Với **Entity Framework Core (EF Core)**, bảng `MONHOC` được ánh xạ thành class `MonHoc` và quản lý qua `DbContext`. Mình thao tác thêm, sửa, xóa, tìm kiếm trực tiếp trên đối tượng C# bằng LINQ (`.Where()`, `.FirstOrDefault()`, `.Add()`, `.SaveChanges()`) mà không cần viết câu lệnh SQL thủ công, giúp code ngắn gọn và ít bị lỗi cú pháp SQL hơn.

**Câu 11: Trong bài lab này, validation nào nên đặt ở BLL?**
Các kiểm tra dữ liệu đặt ở tầng **BLL (`MonHocBLL.cs`)** trong bài gồm:
1. Kiểm tra `MaMonHoc` không được để trống và không dài quá 10 ký tự.
2. Kiểm tra `TenMonHoc` không được để trống và không dài quá 100 ký tự.
3. Kiểm tra `SoTinChi` phải nằm trong khoảng từ 1 đến 6.
4. Kiểm tra trùng khóa chính khi thêm mới (gọi DAL kiểm tra xem `MaMonHoc` đã có trong bảng `MONHOC` chưa, nếu có rồi thì báo lỗi không cho thêm).
5. Kiểm tra mã môn học có thực sự tồn tại trong CSDL hay không trước khi thực hiện lệnh sửa hoặc xóa.

## 7. Hình ảnh minh họa kết quả chạy chương trình

- **Giao diện chính khi mở Form và tải danh sách môn học từ SQL Server:**
  ![Giao diện chính](Hình%20ảnh%20Lab14/Giao%20diện%20chính.png)

- **Chọn một dòng trên bảng DataGridView để hiển thị thông tin lên các ô nhập:**
  ![Chọn dòng dữ liệu](Hình%20ảnh%20Lab14/Chọn%20dòng%20dữ%20liệu.png)

- **Tìm kiếm môn học theo từ khóa:**
  ![Tìm kiếm môn học](Hình%20ảnh%20Lab14/Tìm%20kiếm%20môn%20học.png)
