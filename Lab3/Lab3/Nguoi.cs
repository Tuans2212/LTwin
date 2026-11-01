using System;

namespace Lab3
{
    public class Nguoi
    {
        private string hoTen;
        private DateTime ngaySinh;

        public string HoTen
        {
            get { return hoTen; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Họ tên không được để trống.");
                }
                hoTen = value.Trim();
            }
        }

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("Ngày sinh không hợp lệ.");
                }
                ngaySinh = value;
            }
        }

        public Nguoi()
        {
        }

        public Nguoi(string hoTen, DateTime ngaySinh)
        {
            HoTen = hoTen;
            NgaySinh = ngaySinh;
        }

        public virtual string LayThongTin()
        {
            return string.Format("{0,-24} | {1,-12:dd/MM/yyyy}", HoTen, NgaySinh);
        }
    }
}
