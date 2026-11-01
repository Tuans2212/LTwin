using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3
{
    public class QuanLySinhVien
    {
        private List<SinhVien> danhSachSinhVien;

        public QuanLySinhVien()
        {
            danhSachSinhVien = new List<SinhVien>();
        }

        public bool KiemTraTrungMa(string maSV)
        {
            if (string.IsNullOrWhiteSpace(maSV))
            {
                return false;
            }

            string maCanTim = maSV.Trim().ToUpper();
            return danhSachSinhVien.Any(sv => sv.MaSinhVien == maCanTim);
        }

        public bool Them(SinhVien sv)
        {
            if (sv == null)
            {
                return false;
            }

            if (KiemTraTrungMa(sv.MaSinhVien))
            {
                return false;
            }

            danhSachSinhVien.Add(sv);
            return true;
        }

        public SinhVien TimTheoMa(string maSV)
        {
            if (string.IsNullOrWhiteSpace(maSV))
            {
                return null;
            }

            string maCanTim = maSV.Trim().ToUpper();
            return danhSachSinhVien.FirstOrDefault(sv => sv.MaSinhVien == maCanTim);
        }

        public List<SinhVien> TimTheoTen(string tuKhoa)
        {
            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                return new List<SinhVien>();
            }

            string tuKhoaTim = tuKhoa.Trim().ToLower();
            return danhSachSinhVien
                .Where(sv => sv.HoTen.ToLower().Contains(tuKhoaTim))
                .ToList();
        }

        public bool Sua(string maSV, double diemMoi)
        {
            SinhVien sv = TimTheoMa(maSV);
            if (sv == null)
            {
                return false;
            }

            sv.DiemTrungBinh = diemMoi;
            return true;
        }

        public bool Xoa(string maSV)
        {
            SinhVien sv = TimTheoMa(maSV);
            if (sv == null)
            {
                return false;
            }

            return danhSachSinhVien.Remove(sv);
        }

        public List<SinhVien> SapXepTheoDiem()
        {
            return danhSachSinhVien
                .OrderByDescending(sv => sv.DiemTrungBinh)
                .ToList();
        }

        public List<SinhVien> LocSinhVienDat()
        {
            return danhSachSinhVien
                .Where(sv => sv.DiemTrungBinh >= 5.0)
                .ToList();
        }

        public List<SinhVien> LayDanhSach()
        {
            return danhSachSinhVien.ToList();
        }
    }
}
