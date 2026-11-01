using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Lab3
{
    internal class Program
    {
        private static QuanLySinhVien quanLy = new QuanLySinhVien();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Title = "COMP1019 - Lab 03: Quản Lý Sinh Viên OOP";

            KhoiTaoDuLieuMau();

            bool dangChay = true;
            while (dangChay)
            {
                HienThiMenu();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("  >> Chọn chức năng (0 - 8): ");
                Console.ResetColor();
                string luaChon = Console.ReadLine();

                Console.WriteLine();
                switch (luaChon != null ? luaChon.Trim() : "")
                {
                    case "1":
                        ChucNangThemSinhVien();
                        break;
                    case "2":
                        ChucNangXuatDanhSach();
                        break;
                    case "3":
                        ChucNangTimTheoMa();
                        break;
                    case "4":
                        ChucNangTimTheoTen();
                        break;
                    case "5":
                        ChucNangSuaDiem();
                        break;
                    case "6":
                        ChucNangXoaSinhVien();
                        break;
                    case "7":
                        ChucNangSapXepTheoDiem();
                        break;
                    case "8":
                        ChucNangLocSinhVienDat();
                        break;
                    case "0":
                        dangChay = false;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("  Đã thoát chương trình. Hẹn gặp lại!");
                        Console.ResetColor();
                        break;
                    default:
                        InThongBaoLoi("Lựa chọn không hợp lệ! Vui lòng chọn số từ 0 đến 8.");
                        break;
                }

                if (dangChay)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("  Nhấn phím bất kỳ để quay lại menu chính...");
                    Console.ResetColor();
                    if (!Console.IsInputRedirected)
                    {
                        Console.ReadKey(true);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
            }
        }

        private static void KhoiTaoDuLieuMau()
        {
            quanLy.Them(new SinhVien("SV101", "Nguyễn Văn Tuấn", new DateTime(2006, 5, 14), "24CT1", 8.6));
            quanLy.Them(new SinhVien("SV102", "Trần Thị Minh Anh", new DateTime(2006, 9, 22), "24CT1", 7.4));
            quanLy.Them(new SinhVien("SV103", "Lê Hoàng Nam", new DateTime(2006, 2, 10), "24CT2", 5.8));
            quanLy.Them(new SinhVien("SV104", "Nguyễn Minh Khôi", new DateTime(2006, 11, 3), "24CT2", 4.2));
        }

        private static void HienThiMenu()
        {
            if (!Console.IsOutputRedirected)
            {
                Console.Clear();
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  ╭──────────────────────────────────────────────────────────────────────────╮");
            Console.Write("  │");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("                  CHƯƠNG TRÌNH QUẢN LÝ SINH VIÊN (OOP)                    ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("│");
            Console.Write("  │");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("                 Học phần: COMP1019 - Lập trình trên Windows              ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("│");
            Console.WriteLine("  ╰──────────────────────────────────────────────────────────────────────────╯");
            Console.ResetColor();

            VeHangButton("1", "Thêm sinh viên mới", "5", "Sửa điểm trung bình");
            VeHangButton("2", "Xuất danh sách sinh viên", "6", "Xóa sinh viên theo mã");
            VeHangButton("3", "Tìm sinh viên theo mã", "7", "Sắp xếp điểm giảm dần");
            VeHangButton("4", "Tìm sinh viên theo tên", "8", "Lọc sinh viên đạt (>= 5)");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("  ╭──────────────────────────────────────────────────────────────────────────╮");
            Console.Write("  │                           ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[0] Thoát chương trình");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("                         │");
            Console.WriteLine("  ╰──────────────────────────────────────────────────────────────────────────╯");
            Console.ResetColor();
        }

        private static void VeHangButton(string phimTrai, string tenTrai, string phimPhai, string tenPhai)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("  ╭────────────────────────────────────╮  ╭────────────────────────────────────╮");

            Console.Write("  │  ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[" + phimTrai + "] ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(string.Format("{0,-28}", tenTrai));
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("  │  │  ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[" + phimPhai + "] ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(string.Format("{0,-28}", tenPhai));
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("  │");

            Console.WriteLine("  ╰────────────────────────────────────╯  ╰────────────────────────────────────╯");
            Console.ResetColor();
        }

        private static void InTieuDeChucNang(string tieuDe)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  ╭──────────────────────────────────────────────────────────────────────────╮");
            Console.Write("  │  ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(string.Format("{0,-72}", tieuDe));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("│");
            Console.WriteLine("  ╰──────────────────────────────────────────────────────────────────────────╯");
            Console.ResetColor();
        }

        private static void InBangSinhVien(List<SinhVien> danhSach)
        {
            if (danhSach == null || danhSach.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("  [!] Không có sinh viên nào trong danh sách.");
                Console.ResetColor();
                return;
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  ╭────────────┬──────────────────────────┬──────────────┬────────────┬──────────┬──────────────╮");
            Console.Write("  │ ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(string.Format("{0,-10} │ {1,-24} │ {2,-12} │ {3,-10} │ {4,8} │ {5,-12}",
                "MÃ SV", "HỌ VÀ TÊN", "NGÀY SINH", "MÃ LỚP", "ĐIỂM TB", "XẾP LOẠI"));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" │");
            Console.WriteLine("  ├────────────┼──────────────────────────┼──────────────┼────────────┼──────────┼──────────────┤");
            Console.ResetColor();

            foreach (SinhVien sv in danhSach)
            {
                string xepLoai = sv.XepLoai();
                if (xepLoai == "Giỏi")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (xepLoai == "Khá")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if (xepLoai == "Trung bình")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                Console.WriteLine("  " + sv.LayThongTin());
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  ╰────────────┴──────────────────────────┴──────────────┴────────────┴──────────┴──────────────╯");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("  Tổng số: " + danhSach.Count + " sinh viên.");
            Console.ResetColor();
        }

        private static string NhapChuoiKhongRong(string loiNhac)
        {
            while (true)
            {
                Console.Write("  " + loiNhac);
                string duLieu = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(duLieu))
                {
                    return duLieu.Trim();
                }
                InThongBaoLoi("Dữ liệu không được để trống. Vui lòng nhập lại!");
            }
        }

        private static DateTime NhapNgaySinh()
        {
            string[] dinhDang = { "dd/MM/yyyy", "d/M/yyyy", "dd-MM-yyyy", "yyyy-MM-dd" };
            while (true)
            {
                Console.Write("  Nhập ngày sinh (dd/MM/yyyy): ");
                string chuoiNgay = Console.ReadLine();

                DateTime ngaySinh;
                if (DateTime.TryParseExact(chuoiNgay != null ? chuoiNgay.Trim() : "", dinhDang,
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaySinh) && ngaySinh <= DateTime.Now)
                {
                    return ngaySinh;
                }

                InThongBaoLoi("Ngày sinh không đúng định dạng dd/MM/yyyy (ví dụ: 15/08/2006). Vui lòng nhập lại!");
            }
        }

        private static double NhapDiemTrungBinh(string loiNhac)
        {
            while (true)
            {
                Console.Write("  " + loiNhac);
                string chuoiDiem = Console.ReadLine();
                if (chuoiDiem != null)
                {
                    chuoiDiem = chuoiDiem.Trim().Replace(',', '.');
                }

                double diem;
                if (!double.TryParse(chuoiDiem, NumberStyles.Any, CultureInfo.InvariantCulture, out diem))
                {
                    InThongBaoLoi("Điểm nhập vào phải là một con số! Vui lòng nhập lại.");
                    continue;
                }

                try
                {
                    SinhVien svKiemTra = new SinhVien();
                    svKiemTra.DiemTrungBinh = diem;
                    return svKiemTra.DiemTrungBinh;
                }
                catch (ArgumentException ex)
                {
                    InThongBaoLoi(ex.Message + " Vui lòng nhập lại!");
                }
            }
        }

        private static void ChucNangThemSinhVien()
        {
            InTieuDeChucNang("1. THÊM SINH VIÊN MỚI");

            string maSV = NhapChuoiKhongRong("Nhập mã sinh viên: ").ToUpper();
            if (quanLy.KiemTraTrungMa(maSV))
            {
                InThongBaoLoi("Mã sinh viên '" + maSV + "' đã tồn tại trong danh sách!");
                return;
            }

            string hoTen = NhapChuoiKhongRong("Nhập họ và tên: ");
            DateTime ngaySinh = NhapNgaySinh();
            string maLop = NhapChuoiKhongRong("Nhập mã lớp: ").ToUpper();
            double diemTB = NhapDiemTrungBinh("Nhập điểm trung bình (0 - 10): ");

            try
            {
                SinhVien svMoi = new SinhVien(maSV, hoTen, ngaySinh, maLop, diemTB);
                bool ketQua = quanLy.Them(svMoi);
                if (ketQua)
                {
                    InThongBaoThanhCong("Thêm sinh viên thành công! Xếp loại: " + svMoi.XepLoai());
                }
                else
                {
                    InThongBaoLoi("Không thể thêm sinh viên vì mã đã tồn tại.");
                }
            }
            catch (ArgumentException ex)
            {
                InThongBaoLoi(ex.Message);
            }
        }

        private static void ChucNangXuatDanhSach()
        {
            InTieuDeChucNang("2. DANH SÁCH TOÀN BỘ SINH VIÊN");
            List<SinhVien> danhSach = quanLy.LayDanhSach();
            InBangSinhVien(danhSach);
        }

        private static void ChucNangTimTheoMa()
        {
            InTieuDeChucNang("3. TÌM SINH VIÊN THEO MÃ");
            string maCanTim = NhapChuoiKhongRong("Nhập mã sinh viên cần tìm: ");

            SinhVien sv = quanLy.TimTheoMa(maCanTim);
            if (sv == null)
            {
                InThongBaoLoi("Không tìm thấy sinh viên có mã '" + maCanTim.ToUpper() + "'.");
            }
            else
            {
                Console.WriteLine();
                InBangSinhVien(new List<SinhVien> { sv });
            }
        }

        private static void ChucNangTimTheoTen()
        {
            InTieuDeChucNang("4. TÌM SINH VIÊN THEO HỌ TÊN");
            string tuKhoa = NhapChuoiKhongRong("Nhập từ khóa họ tên cần tìm: ");

            List<SinhVien> ketQua = quanLy.TimTheoTen(tuKhoa);
            if (ketQua.Count == 0)
            {
                InThongBaoLoi("Không tìm thấy sinh viên nào có tên chứa '" + tuKhoa + "'.");
            }
            else
            {
                Console.WriteLine();
                InBangSinhVien(ketQua);
            }
        }

        private static void ChucNangSuaDiem()
        {
            InTieuDeChucNang("5. SỬA ĐIỂM TRUNG BÌNH SINH VIÊN");
            string maSV = NhapChuoiKhongRong("Nhập mã sinh viên cần sửa điểm: ");

            SinhVien sv = quanLy.TimTheoMa(maSV);
            if (sv == null)
            {
                InThongBaoLoi("Không tìm thấy sinh viên có mã '" + maSV.ToUpper() + "'.");
                return;
            }

            Console.WriteLine("  Thông tin hiện tại:");
            InBangSinhVien(new List<SinhVien> { sv });

            double diemMoi = NhapDiemTrungBinh("Nhập điểm trung bình mới (0 - 10): ");
            bool daSua = quanLy.Sua(maSV, diemMoi);
            if (daSua)
            {
                InThongBaoThanhCong("Cập nhật điểm thành công! Xếp loại mới: " + sv.XepLoai());
            }
        }

        private static void ChucNangXoaSinhVien()
        {
            InTieuDeChucNang("6. XÓA SINH VIÊN KHỎI DANH SÁCH");
            string maSV = NhapChuoiKhongRong("Nhập mã sinh viên cần xóa: ");

            SinhVien sv = quanLy.TimTheoMa(maSV);
            if (sv == null)
            {
                InThongBaoLoi("Không tìm thấy sinh viên có mã '" + maSV.ToUpper() + "'.");
                return;
            }

            bool daXoa = quanLy.Xoa(maSV);
            if (daXoa)
            {
                InThongBaoThanhCong("Đã xóa sinh viên '" + sv.HoTen + "' (" + sv.MaSinhVien + ") khỏi danh sách.");
            }
        }

        private static void ChucNangSapXepTheoDiem()
        {
            InTieuDeChucNang("7. DANH SÁCH SINH VIÊN SẮP XẾP THEO ĐIỂM GIẢM DẦN");
            List<SinhVien> danhSachSapXep = quanLy.SapXepTheoDiem();
            InBangSinhVien(danhSachSapXep);
        }

        private static void ChucNangLocSinhVienDat()
        {
            InTieuDeChucNang("8. DANH SÁCH SINH VIÊN ĐẠT (ĐIỂM TRUNG BÌNH >= 5.0)");
            List<SinhVien> danhSachDat = quanLy.LocSinhVienDat();
            InBangSinhVien(danhSachDat);
        }

        private static void InThongBaoThanhCong(string thongDiep)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("  [THÀNH CÔNG] " + thongDiep);
            Console.ResetColor();
        }

        private static void InThongBaoLoi(string thongDiep)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  [LỖI] " + thongDiep);
            Console.ResetColor();
        }
    }
}
