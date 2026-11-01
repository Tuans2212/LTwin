using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    internal class Program
    {
        private static ProductService productService = new ProductService();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            productService.OnProductChanged += ThongBaoThayDoi;

            KhoiTaoDuLieuMau();

            bool tiepTuc = true;
            while (tiepTuc)
            {
                HienThiMenu();
                Console.Write("Nhập lựa chọn của bạn: ");
                string luaChon = Console.ReadLine();

                Console.WriteLine();
                switch (luaChon)
                {
                    case "1":
                        XuLyThemSanPham();
                        break;
                    case "2":
                        XuLyXuatDanhSach();
                        break;
                    case "3":
                        XuLyTimTheoMa();
                        break;
                    case "4":
                        XuLyTimTheoTen();
                        break;
                    case "5":
                        XuLyLocTheoKhoangGia();
                        break;
                    case "6":
                        XuLyXoaSanPham();
                        break;
                    case "7":
                        XuLyTinhTongGiaTriKho();
                        break;
                    case "0":
                        tiepTuc = false;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Cảm ơn bạn đã sử dụng chương trình. Tạm biệt!");
                        Console.ResetColor();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn từ 0 đến 7!");
                        Console.ResetColor();
                        break;
                }

                if (tiepTuc)
                {
                    Console.WriteLine();
                    Console.Write("Nhấn phím bất kỳ để quay lại menu...");
                    Console.ReadKey();
                }
            }
        }

        private static void ThongBaoThayDoi(string noiDung)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[EVENT SỰ KIỆN] " + noiDung);
            Console.ResetColor();
        }

        private static void KhoiTaoDuLieuMau()
        {
            try
            {
                productService.AddProduct(new Product("SP01", "Bàn phím cơ Akko 3087", 1250000, 15));
                productService.AddProduct(new Product("SP02", "Chuột Logitech G102", 420000, 30));
                productService.AddProduct(new Product("SP03", "Màn hình LG 24 inch IPS", 3450000, 8));
                productService.AddProduct(new Product("SP04", "Tai nghe Gaming HyperX", 1850000, 12));
            }
            catch
            {
            }
        }

        private static void HienThiMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==================================================");
            Console.WriteLine("           HỆ THỐNG QUẢN LÝ SẢN PHẨM              ");
            Console.WriteLine("==================================================");
            Console.ResetColor();
            Console.WriteLine("1. Thêm sản phẩm");
            Console.WriteLine("2. Xuất danh sách sản phẩm");
            Console.WriteLine("3. Tìm sản phẩm theo mã");
            Console.WriteLine("4. Tìm sản phẩm theo tên");
            Console.WriteLine("5. Lọc sản phẩm theo khoảng giá");
            Console.WriteLine("6. Xóa sản phẩm theo mã");
            Console.WriteLine("7. Tính tổng giá trị kho");
            Console.WriteLine("0. Thoát chương trình");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------------------------------------------");
            Console.ResetColor();
        }

        private static void InTieuDeBang()
        {
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine(string.Format("{0,-8} | {1,-24} | {2,14} | {3,6} | {4,16}",
                "MÃ SP", "TÊN SẢN PHẨM", "ĐƠN GIÁ", "SL", "THÀNH TIỀN"));
            Console.WriteLine("-------------------------------------------------------------------------------");
        }

        private static void InDanhSachSanPham(List<Product> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Danh sách sản phẩm trống!");
                Console.ResetColor();
                return;
            }

            InTieuDeBang();
            foreach (Product sp in list)
            {
                Console.WriteLine(sp.ToString());
            }
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("Tổng cộng: " + list.Count + " sản phẩm.");
        }

        private static void XuLyThemSanPham()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--- CHỨC NĂNG 1: THÊM SẢN PHẨM MỚI ---");
            Console.ResetColor();

            try
            {
                Console.Write("Nhập mã sản phẩm: ");
                string ma = Console.ReadLine();

                Console.Write("Nhập tên sản phẩm: ");
                string ten = Console.ReadLine();

                Console.Write("Nhập đơn giá: ");
                string chuoiGia = Console.ReadLine();
                double gia;
                if (!double.TryParse(chuoiGia, out gia))
                {
                    throw new FormatException("Đơn giá nhập vào phải là một số hợp lệ.");
                }

                Console.Write("Nhập số lượng: ");
                string chuoiSoLuong = Console.ReadLine();
                int soLuong;
                if (!int.TryParse(chuoiSoLuong, out soLuong))
                {
                    throw new FormatException("Số lượng nhập vào phải là một số nguyên hợp lệ.");
                }

                Product sp = new Product(ma, ten, gia, soLuong);
                productService.AddProduct(sp);
            }
            catch (DuplicateProductException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[LỖI TRÙNG MÃ] " + ex.Message);
                Console.ResetColor();
            }
            catch (ArgumentException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[LỖI DỮ LIỆU] " + ex.Message);
                Console.ResetColor();
            }
            catch (FormatException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[LỖI ĐỊNH DẠNG] " + ex.Message);
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[LỖI HỆ THỐNG] " + ex.Message);
                Console.ResetColor();
            }
        }

        private static void XuLyXuatDanhSach()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--- CHỨC NĂNG 2: DANH SÁCH TOÀN BỘ SẢN PHẨM ---");
            Console.ResetColor();

            List<Product> tatCa = productService.GetAll();
            InDanhSachSanPham(tatCa);
        }

        private static void XuLyTimTheoMa()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--- CHỨC NĂNG 3: TÌM KIẾM SẢN PHẨM THEO MÃ ---");
            Console.ResetColor();

            try
            {
                Console.Write("Nhập mã sản phẩm cần tìm: ");
                string ma = Console.ReadLine();

                Product sp = productService.FindById(ma);

                Console.WriteLine();
                InTieuDeBang();
                Console.WriteLine(sp.ToString());
                Console.WriteLine("-------------------------------------------------------------------------------");
            }
            catch (ProductNotFoundException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[THÔNG BÁO] " + ex.Message);
                Console.ResetColor();
            }
            catch (ArgumentException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[LỖI DỮ LIỆU] " + ex.Message);
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[LỖI] " + ex.Message);
                Console.ResetColor();
            }
        }

        private static void XuLyTimTheoTen()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--- CHỨC NĂNG 4: TÌM KIẾM SẢN PHẨM THEO TÊN ---");
            Console.ResetColor();

            Console.Write("Nhập từ khóa tên sản phẩm: ");
            string tuKhoa = Console.ReadLine();

            List<Product> ketQua = productService.Search(tuKhoa);
            Console.WriteLine();
            InDanhSachSanPham(ketQua);
        }

        private static void XuLyLocTheoKhoangGia()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--- CHỨC NĂNG 5: LỌC SẢN PHẨM THEO KHOẢNG GIÁ (FUNC<PRODUCT, BOOL>) ---");
            Console.ResetColor();

            try
            {
                Console.Write("Nhập giá thấp nhất (Min): ");
                string chuoiMin = Console.ReadLine();
                double giaMin;
                if (!double.TryParse(chuoiMin, out giaMin))
                {
                    throw new FormatException("Giá thấp nhất phải là số hợp lệ.");
                }

                Console.Write("Nhập giá cao nhất (Max): ");
                string chuoiMax = Console.ReadLine();
                double giaMax;
                if (!double.TryParse(chuoiMax, out giaMax))
                {
                    throw new FormatException("Giá cao nhất phải là số hợp lệ.");
                }

                if (giaMin < 0 || giaMax < 0)
                {
                    throw new ArgumentException("Giá không được âm.");
                }

                if (giaMin > giaMax)
                {
                    throw new ArgumentException("Giá thấp nhất không được lớn hơn giá cao nhất.");
                }

                Func<Product, bool> dieuKienGia = delegate (Product p)
                {
                    return p.Price >= giaMin && p.Price <= giaMax;
                };

                List<Product> ketQua = productService.Filter(dieuKienGia);

                Console.WriteLine();
                Console.WriteLine("Kết quả lọc sản phẩm có giá từ {0:N0} đ đến {1:N0} đ:", giaMin, giaMax);
                InDanhSachSanPham(ketQua);
            }
            catch (FormatException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[LỖI ĐỊNH DẠNG] " + ex.Message);
                Console.ResetColor();
            }
            catch (ArgumentException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[LỖI DỮ LIỆU] " + ex.Message);
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[LỖI] " + ex.Message);
                Console.ResetColor();
            }
        }

        private static void XuLyXoaSanPham()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--- CHỨC NĂNG 6: XÓA SẢN PHẨM ---");
            Console.ResetColor();

            try
            {
                Console.Write("Nhập mã sản phẩm cần xóa: ");
                string ma = Console.ReadLine();

                Console.Write("Bạn có chắc chắn muốn xóa sản phẩm '" + ma + "' không? (Y/N): ");
                string xacNhan = Console.ReadLine();
                if (xacNhan != null && (xacNhan.Trim().ToUpper() == "Y" || xacNhan.Trim().ToUpper() == "YES"))
                {
                    productService.RemoveProduct(ma);
                }
                else
                {
                    Console.WriteLine("Đã hủy thao tác xóa.");
                }
            }
            catch (ProductNotFoundException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[THÔNG BÁO] " + ex.Message);
                Console.ResetColor();
            }
            catch (ArgumentException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[LỖI DỮ LIỆU] " + ex.Message);
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[LỖI] " + ex.Message);
                Console.ResetColor();
            }
        }

        private static void XuLyTinhTongGiaTriKho()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--- CHỨC NĂNG 7: TÍNH TỔNG GIÁ TRỊ KHO HÀNG ---");
            Console.ResetColor();

            double tongTien = productService.TinhTongGiaTriKho();
            List<Product> list = productService.GetAll();

            Console.WriteLine("Tổng số loại mặt hàng đang có: " + list.Count);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Tổng giá trị kho hàng hiện tại: {0:N0} VNĐ", tongTien);
            Console.ResetColor();
        }
    }
}
