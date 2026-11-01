using System;

namespace Lab3
{
    public class SinhVien : Nguoi
    {
        private string maSinhVien;
        private string maLop;
        private double diemTrungBinh;

        public string MaSinhVien
        {
            get { return maSinhVien; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Mã sinh viên không được để trống.");
                }
                maSinhVien = value.Trim().ToUpper();
            }
        }

        public string MaLop
        {
            get { return maLop; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Mã lớp không được để trống.");
                }
                maLop = value.Trim().ToUpper();
            }
        }

        public double DiemTrungBinh
        {
            get { return diemTrungBinh; }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Điểm trung bình phải nằm trong khoảng từ 0 đến 10.");
                }
                diemTrungBinh = Math.Round(value, 2);
            }
        }

        public SinhVien() : base()
        {
        }

        public SinhVien(string maSinhVien, string hoTen, DateTime ngaySinh, string maLop, double diemTrungBinh)
            : base(hoTen, ngaySinh)
        {
            MaSinhVien = maSinhVien;
            MaLop = maLop;
            DiemTrungBinh = diemTrungBinh;
        }

        public string XepLoai()
        {
            if (DiemTrungBinh >= 8.0)
            {
                return "Giỏi";
            }
            else if (DiemTrungBinh >= 6.5)
            {
                return "Khá";
            }
            else if (DiemTrungBinh >= 5.0)
            {
                return "Trung bình";
            }
            else
            {
                return "Yếu";
            }
        }

        public override string LayThongTin()
        {
            return string.Format("│ {0,-10} │ {1,-24} │ {2,-12:dd/MM/yyyy} │ {3,-10} │ {4,8:0.00} │ {5,-12} │",
                MaSinhVien, HoTen, NgaySinh, MaLop, DiemTrungBinh, XepLoai());
        }

        public override string ToString()
        {
            return LayThongTin();
        }
    }
}
