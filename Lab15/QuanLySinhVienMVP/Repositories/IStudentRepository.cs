using System.Collections.Generic;
using QuanLySinhVienMVP.Models;

namespace QuanLySinhVienMVP.Repositories
{
    public interface IStudentRepository
    {
        List<Student> GetAll();
        Student GetById(string studentId);
        bool Exists(string studentId);
        void Add(Student student);
        bool Delete(string studentId);
        List<Student> Search(string keyword);
    }
}
