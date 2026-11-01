using System;

namespace QuanLySinhVienMVP.Models
{
    public class Student
    {
        public string StudentId { get; set; }
        public string FullName { get; set; }
        public string ClassName { get; set; }
        public double Score { get; set; }

        public string AcademicRank
        {
            get
            {
                if (Score >= 8.0) return "Giỏi";
                if (Score >= 6.5) return "Khá";
                if (Score >= 5.0) return "Trung bình";
                return "Yếu";
            }
        }

        public string Status
        {
            get { return Score >= 5.0 ? "Đạt" : "Chưa đạt"; }
        }

        public Student()
        {
        }

        public Student(string studentId, string fullName, string className, double score)
        {
            StudentId = studentId;
            FullName = fullName;
            ClassName = className;
            Score = score;
        }
    }
}
