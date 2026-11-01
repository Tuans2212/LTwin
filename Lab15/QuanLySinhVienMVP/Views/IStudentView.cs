using System.Collections.Generic;
using QuanLySinhVienMVP.Models;

namespace QuanLySinhVienMVP.Views
{
    public interface IStudentView
    {
        string StudentId { get; set; }
        string FullName { get; set; }
        string ClassName { get; set; }
        string ScoreText { get; set; }
        string SearchKeyword { get; set; }

        void DisplayStudents(List<Student> students);
        void ShowMessage(string message, string title, bool isError);
        void ClearInputs();
        void UpdateSummary(int totalStudents, int passedStudents, double averageScore);
    }
}
