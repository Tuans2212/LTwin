using System;

namespace StudentReportDemo.Models
{
    public class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public double Diem { get; set; }

        public string KetQua
        {
            get
            {
                if (Diem >= 5.0)
                    return "Đạt";
                return "Không đạt";
            }
        }
    }
}
