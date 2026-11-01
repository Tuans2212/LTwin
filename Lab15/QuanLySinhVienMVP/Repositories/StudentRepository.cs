using System;
using System.Collections.Generic;
using System.Linq;
using QuanLySinhVienMVP.Models;

namespace QuanLySinhVienMVP.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly List<Student> _students;

        public StudentRepository()
        {
            _students = new List<Student>
            {
                new Student("SV2401", "Nguyễn Văn Tuấn", "24CT1", 8.8),
                new Student("SV2402", "Trần Lê Bảo Ngọc", "24CT1", 9.1),
                new Student("SV2403", "Lê Hoàng Minh Quân", "24CT1", 7.4),
                new Student("SV2404", "Phạm Thị Thanh Thảo", "24CT2", 6.5),
                new Student("SV2405", "Võ Quốc Khánh", "24CT2", 4.2),
                new Student("SV2406", "Đặng Ngọc Phương Linh", "24KTPM1", 8.5),
                new Student("SV2407", "Bùi Thanh Hải", "24KTPM1", 5.6),
                new Student("SV2408", "Hoàng Gia Bảo", "24KTPM1", 3.9),
                new Student("SV2409", "Ngô Đình Khôi", "24HTTT1", 7.8),
                new Student("SV2410", "Mai Khánh Vy", "24HTTT1", 8.2)
            };
        }

        public List<Student> GetAll()
        {
            return _students.ToList();
        }

        public Student GetById(string studentId)
        {
            if (string.IsNullOrWhiteSpace(studentId))
                return null;

            string maCanTim = studentId.Trim().ToUpper();
            return _students.FirstOrDefault(sv => sv.StudentId.ToUpper() == maCanTim);
        }

        public bool Exists(string studentId)
        {
            return GetById(studentId) != null;
        }

        public void Add(Student student)
        {
            _students.Add(student);
        }

        public bool Delete(string studentId)
        {
            Student svCanXoa = GetById(studentId);
            if (svCanXoa == null)
                return false;

            _students.Remove(svCanXoa);
            return true;
        }

        public List<Student> Search(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return GetAll();

            string tuKhoa = keyword.Trim().ToLower();
            return _students
                .Where(sv => sv.StudentId.ToLower().Contains(tuKhoa) ||
                             sv.FullName.ToLower().Contains(tuKhoa))
                .ToList();
        }
    }
}
