using System;
using System.Collections.Generic;

namespace QuanLyNhanVien
{
    // ==========================================
    // 1. LỚP CHA: NhanVien
    // ==========================================
    class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }

        private double luongCoBan;
        public double LuongCoBan
        {
            get { return luongCoBan; }
            set { luongCoBan = value > 0 ? value : 0; } // Đóng gói: Lương CB phải > 0
        }

        // Constructor
        public NhanVien(string maNV, string hoTen, double luongCoBan)
        {
            MaNV = maNV;
            HoTen = hoTen;
            LuongCoBan = luongCoBan;
        }

        public virtual double TinhLuong()
        {
            return LuongCoBan;
        }

        public virtual void HienThiThongTin()
        {
            Console.WriteLine($"Mã NV: {MaNV,-8} | Họ tên: {HoTen,-18} | Lương CB: {LuongCoBan,10:#,##0} | Lương TL: {TinhLuong(),12:#,##0}");
        }
    }

    // ==========================================
    // 2. LỚP CON: NhanVienVanPhong
    // ==========================================
    class NhanVienVanPhong : NhanVien
    {
        private int soNgayLamViec;
        public int SoNgayLamViec
        {
            get { return soNgayLamViec; }
            set { soNgayLamViec = (value >= 0 && value <= 31) ? value : 0; } // Đóng gói: 0-31 ngày
        }

        public NhanVienVanPhong(string maNV, string hoTen, double luongCoBan, int soNgayLamViec)
            : base(maNV, hoTen, luongCoBan)
        {
            SoNgayLamViec = soNgayLamViec;
        }

        public override double TinhLuong()
        {
            return LuongCoBan + (SoNgayLamViec * 200000);
        }

        public override void HienThiThongTin()
        {
            Console.WriteLine($"[VP] Mã: {MaNV,-6} | Tên: {HoTen,-18} | Lương CB: {LuongCoBan,10:#,##0} | Ngày làm: {SoNgayLamViec,-3} | Tổng Lương: {TinhLuong(),12:#,##0}");
        }
    }

    // ==========================================
    // 3. LỚP CON: NhanVienKinhDoanh
    // ==========================================
    class NhanVienKinhDoanh : NhanVien
    {
        private double doanhSo;
        public double DoanhSo
        {
            get { return doanhSo; }
            set { doanhSo = value >= 0 ? value : 0; } // Đóng gói: Doanh số >= 0
        }

        public NhanVienKinhDoanh(string maNV, string hoTen, double luongCoBan, double doanhSo)
            : base(maNV, hoTen, luongCoBan)
        {
            DoanhSo = doanhSo;
        }

        public override double TinhLuong()
        {
            return LuongCoBan + (DoanhSo * 0.05);
        }

        public override void HienThiThongTin()
        {
            Console.WriteLine($"[KD] Mã: {MaNV,-6} | Tên: {HoTen,-18} | Lương CB: {LuongCoBan,10:#,##0} | Doanh số: {DoanhSo,10:#,##0} | Tổng Lương: {TinhLuong(),12:#,##0}");
        }
    }

    // ==========================================
    // 4. LỚP BONUS: NhanVienThoiVu
    // ==========================================
    class NhanVienThoiVu : NhanVien
    {
        public double SoGioLam { get; set; }
        public double LuongTheoGio { get; set; }

        public NhanVienThoiVu(string maNV, string hoTen, double soGioLam, double luongTheoGio)
            : base(maNV, hoTen, 0) // Nhân viên thời vụ không dùng Lương cơ bản
        {
            SoGioLam = soGioLam;
            LuongTheoGio = luongTheoGio;
        }

        public override double TinhLuong()
        {
            return SoGioLam * LuongTheoGio;
        }

        public override void HienThiThongTin()
        {
            Console.WriteLine($"[TV] Mã: {MaNV,-6} | Tên: {HoTen,-18} | Giờ làm: {SoGioLam,-4} | Lương/giờ: {LuongTheoGio,9:#,##0} | Tổng Lương: {TinhLuong(),12:#,##0}");
        }
    }

    // ==========================================
    // 5. CHƯƠNG TRÌNH CHÍNH (MAIN)
    // ==========================================
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Hỗ trợ in tiếng Việt
            List<NhanVien> danhSach = new List<NhanVien>();

            // Khởi tạo sẵn 5 nhân viên theo yêu cầu (gồm cả bonus NhanVienThoiVu)
            danhSach.Add(new NhanVienVanPhong("NV01", "Nguyễn Văn Tuấn", 5000000, 24));
            danhSach.Add(new NhanVienVanPhong("NV02", "Trần Thị B", 6000000, 20));
            danhSach.Add(new NhanVienKinhDoanh("NV03", "Lê Văn C", 4500000, 150000000));
            danhSach.Add(new NhanVienKinhDoanh("NV04", "Phạm Thị D", 4000000, 200000000));
            danhSach.Add(new NhanVienThoiVu("NV05", "Hoàng Văn E", 120, 35000));

            int chon;
            do
            {
                Console.WriteLine("\n========== MENU ==========");
                Console.WriteLine("1. Xuất danh sách nhân viên");
                Console.WriteLine("2. Tìm nhân viên theo mã");
                Console.WriteLine("3. Tìm nhân viên có lương cao nhất");
                Console.WriteLine("4. Tính tổng lương công ty phải trả");
                Console.WriteLine("0. Thoát");
                Console.Write("Mời bạn chọn chức năng: ");

                if (!int.TryParse(Console.ReadLine(), out chon)) continue;

                switch (chon)
                {
                    case 1:
                        Console.WriteLine("\n--- DANH SÁCH NHÂN VIÊN ---");
                        // Đa hình: Tự động gọi đúng phương thức HienThiThongTin() của từng class con
                        foreach (var nv in danhSach)
                        {
                            nv.HienThiThongTin();
                        }
                        break;

                    case 2:
                        Console.Write("\nNhập mã nhân viên cần tìm: ");
                        string maTimKiem = Console.ReadLine();
                        bool found = false;
                        foreach (var nv in danhSach)
                        {
                            if (nv.MaNV.Equals(maTimKiem, StringComparison.OrdinalIgnoreCase))
                            {
                                nv.HienThiThongTin();
                                found = true;
                                break;
                            }
                        }
                        if (!found) Console.WriteLine("Không tìm thấy nhân viên này!");
                        break;

                    case 3:
                        if (danhSach.Count == 0) break;

                        // Thuật toán tìm Max, Đa hình tự tính TinhLuong() đúng class con mà không cần if/switch
                        double maxLuong = danhSach[0].TinhLuong();
                        foreach (var nv in danhSach)
                        {
                            if (nv.TinhLuong() > maxLuong)
                                maxLuong = nv.TinhLuong();
                        }

                        Console.WriteLine("\n--- NHÂN VIÊN CÓ LƯƠNG CAO NHẤT ---");
                        foreach (var nv in danhSach)
                        {
                            if (nv.TinhLuong() == maxLuong)
                                nv.HienThiThongTin();
                        }
                        break;

                    case 4:
                        double tongLuong = 0;
                        // Đa hình: Lặp qua List và tự động gọi TinhLuong() tương ứng
                        foreach (var nv in danhSach)
                        {
                            tongLuong += nv.TinhLuong();
                        }
                        Console.WriteLine($"\n=> Tổng lương công ty phải trả: {tongLuong:#,##0} VNĐ");
                        break;

                    case 0:
                        Console.WriteLine("Đã thoát chương trình.");
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ, vui lòng chọn lại!");
                        break;
                }
            } while (chon != 0);
        }
    }
}