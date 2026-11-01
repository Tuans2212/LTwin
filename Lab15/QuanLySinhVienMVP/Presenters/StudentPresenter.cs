using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using QuanLySinhVienMVP.Models;
using QuanLySinhVienMVP.Repositories;
using QuanLySinhVienMVP.Views;

namespace QuanLySinhVienMVP.Presenters
{
    public class StudentPresenter
    {
        private readonly IStudentView _view;
        private readonly IStudentRepository _repository;

        public StudentPresenter(IStudentView view, IStudentRepository repository)
        {
            _view = view;
            _repository = repository;
        }

        public void LoadStudents()
        {
            List<Student> danhSach = _repository.GetAll();
            _view.DisplayStudents(danhSach);
            CapNhatThongKe(danhSach);
        }

        public void AddStudent()
        {
            string maSV = _view.StudentId != null ? _view.StudentId.Trim().ToUpper() : "";
            string hoTen = _view.FullName != null ? _view.FullName.Trim() : "";
            string lopHoc = _view.ClassName != null ? _view.ClassName.Trim().ToUpper() : "";
            string chuoiDiem = _view.ScoreText != null ? _view.ScoreText.Trim() : "";

            if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(hoTen) ||
                string.IsNullOrEmpty(lopHoc) || string.IsNullOrEmpty(chuoiDiem))
            {
                _view.ShowMessage("Vui lòng nhập đầy đủ Mã sinh viên, Họ tên, Lớp và Điểm trung bình!",
                    "Thiếu thông tin", true);
                return;
            }

            string diemChuanHoa = chuoiDiem.Replace(',', '.');
            double diemSo;
            bool hopLe = double.TryParse(diemChuanHoa, NumberStyles.Any, CultureInfo.InvariantCulture, out diemSo);

            if (!hopLe)
            {
                _view.ShowMessage("Điểm trung bình không hợp lệ! Vui lòng nhập kiểu số (ví dụ: 7.5).",
                    "Sai kiểu dữ liệu", true);
                return;
            }

            if (diemSo < 0 || diemSo > 10)
            {
                _view.ShowMessage("Điểm trung bình phải nằm trong khoảng từ 0 đến 10!",
                    "Điểm ngoài phạm vi", true);
                return;
            }

            if (_repository.Exists(maSV))
            {
                _view.ShowMessage("Mã sinh viên '" + maSV + "' đã tồn tại trong danh sách! Vui lòng nhập mã khác.",
                    "Trùng mã sinh viên", true);
                return;
            }

            Student svMoi = new Student(maSV, hoTen, lopHoc, Math.Round(diemSo, 2));
            _repository.Add(svMoi);

            List<Student> danhSachMoi = _repository.GetAll();
            _view.DisplayStudents(danhSachMoi);
            CapNhatThongKe(danhSachMoi);
            _view.ClearInputs();

            _view.ShowMessage("Đã thêm sinh viên " + hoTen + " (" + maSV + ") thành công!",
                "Thêm thành công", false);
        }

        public void DeleteStudent()
        {
            string maSV = _view.StudentId != null ? _view.StudentId.Trim().ToUpper() : "";

            if (string.IsNullOrEmpty(maSV))
            {
                _view.ShowMessage("Vui lòng chọn sinh viên trên bảng hoặc nhập Mã sinh viên cần xóa!",
                    "Chưa có mã xóa", true);
                return;
            }

            Student svCanXoa = _repository.GetById(maSV);
            if (svCanXoa == null)
            {
                _view.ShowMessage("Không tìm thấy sinh viên có mã '" + maSV + "' để xóa!",
                    "Không tìm thấy", true);
                return;
            }

            string tenSV = svCanXoa.FullName;
            bool daXoa = _repository.Delete(maSV);

            if (daXoa)
            {
                List<Student> danhSachMoi = _repository.GetAll();
                _view.DisplayStudents(danhSachMoi);
                CapNhatThongKe(danhSachMoi);
                _view.ClearInputs();

                _view.ShowMessage("Đã xóa sinh viên " + tenSV + " (Mã: " + maSV + ") khỏi danh sách!",
                    "Xóa thành công", false);
            }
        }

        public void SearchStudents()
        {
            string tuKhoa = _view.SearchKeyword != null ? _view.SearchKeyword.Trim() : "";
            List<Student> ketQua = _repository.Search(tuKhoa);

            _view.DisplayStudents(ketQua);
            CapNhatThongKe(ketQua);

            if (string.IsNullOrEmpty(tuKhoa))
            {
                _view.ShowMessage("Đang hiển thị toàn bộ danh sách (" + ketQua.Count + " sinh viên).",
                    "Danh sách sinh viên", false);
            }
            else if (ketQua.Count == 0)
            {
                _view.ShowMessage("Không tìm thấy sinh viên nào khớp với từ khóa '" + tuKhoa + "'.",
                    "Kết quả tìm kiếm", true);
            }
            else
            {
                _view.ShowMessage("Tìm thấy " + ketQua.Count + " sinh viên khớp với từ khóa '" + tuKhoa + "'.",
                    "Kết quả tìm kiếm", false);
            }
        }

        public void SelectStudent(Student student)
        {
            if (student == null)
                return;

            _view.StudentId = student.StudentId;
            _view.FullName = student.FullName;
            _view.ClassName = student.ClassName;
            _view.ScoreText = student.Score.ToString("0.##");
        }

        public void ResetForm()
        {
            _view.ClearInputs();
            List<Student> danhSach = _repository.GetAll();
            _view.DisplayStudents(danhSach);
            CapNhatThongKe(danhSach);
        }

        private void CapNhatThongKe(List<Student> danhSach)
        {
            int tongSo = danhSach.Count;
            int soDat = danhSach.Count(sv => sv.Score >= 5.0);
            double diemTB = tongSo > 0 ? Math.Round(danhSach.Average(sv => sv.Score), 2) : 0;

            _view.UpdateSummary(tongSo, soDat, diemTB);
        }
    }
}
