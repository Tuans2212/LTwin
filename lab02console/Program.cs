using System;

namespace Lab02_QuanLyMang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = null;
            int luaChon;

            do
            {
                HienThiMenu();
                luaChon = NhapSoNguyen("Chon chuc nang: ");

                // Kiểm tra điều kiện mảng rỗng trước khi thực hiện các chức năng 2-7
                if (luaChon >= 2 && luaChon <= 7 && arr == null)
                {
                    Console.WriteLine("=> Loi: Ban chua nhap mang! Vui long chon chuc nang 1 truoc.\n");
                    continue;
                }

                switch (luaChon)
                {
                    case 1:
                        arr = NhapMang();
                        break;
                    case 2:
                        XuatMang(arr);
                        break;
                    case 3:
                        Console.WriteLine($"=> Tong cac phan tu trong mang la: {TinhTong(arr)}\n");
                        break;
                    case 4:
                        Console.WriteLine($"=> Gia tri Max: {TimMax(arr)} | Gia tri Min: {TimMin(arr)}\n");
                        break;
                    case 5:
                        Console.WriteLine($"=> So luong phan tu Chan: {DemChan(arr)} | So luong phan tu Le: {DemLe(arr)}\n");
                        break;
                    case 6:
                        SapXepTangDan(arr);
                        break;
                    case 7:
                        int x = NhapSoNguyen("Nhap gia tri x can tim: ");
                        int viTri = TimKiem(arr, x);
                        if (viTri != -1)
                            Console.WriteLine($"=> Tim thay {x} tai vi tri dau tien la index [{viTri}]\n");
                        else
                            Console.WriteLine($"=> Khong tim thay {x} trong mang.\n");
                        break;
                    case 0:
                        Console.WriteLine("=> Chuong trinh ket thuc. Tam biet!");
                        break;
                    default:
                        Console.WriteLine("=> Loi: Lua chon khong hop le. Vui long chon tu 0 den 7.\n");
                        break;
                }
            } while (luaChon != 0);
        }

        // ========================================================
        // CÁC PHƯƠNG THỨC HỖ TRỢ THEO YÊU CẦU ĐỀ BÀI
        // ========================================================

        // Hiển thị menu
        static void HienThiMenu()
        {
            Console.WriteLine("===== MENU =====");
            Console.WriteLine("1. Nhap mang");
            Console.WriteLine("2. Xuat mang");
            Console.WriteLine("3. Tinh tong");
            Console.WriteLine("4. Tim max/min");
            Console.WriteLine("5. Dem chan/le");
            Console.WriteLine("6. Sap xep tang dan");
            Console.WriteLine("7. Tim kiem");
            Console.WriteLine("0. Thoat");
        }

        // Nhập số nguyên với kiểm tra dữ liệu hợp lệ (chống nhập sai kiểu)
        static int NhapSoNguyen(string message)
        {
            int giaTri;
            while (true)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out giaTri))
                {
                    return giaTri;
                }
                Console.WriteLine("Loi: Vui long nhap mot so nguyen hop le!");
            }
        }

        // Nhập số nguyên dương (Dùng để bắt buộc n > 0)
        static int NhapSoNguyenDuong(string message)
        {
            int giaTri;
            while (true)
            {
                giaTri = NhapSoNguyen(message);
                if (giaTri > 0)
                {
                    return giaTri;
                }
                Console.WriteLine("Loi: Gia tri phai la so nguyen duong (> 0). Vui long nhap lai!");
            }
        }

        // Chức năng 1: Nhập mảng
        static int[] NhapMang()
        {
            Console.WriteLine("--- NHAP MANG ---");
            int n = NhapSoNguyenDuong("Nhap so luong phan tu n: ");
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = NhapSoNguyen($"Nhap phan tu a[{i}]: ");
            }
            Console.WriteLine("=> Nhap mang thanh cong!\n");
            return a;
        }

        // Chức năng 2: Xuất mảng
        static void XuatMang(int[] a)
        {
            Console.Write("=> Cac phan tu cua mang: ");
            foreach (int item in a)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
        }

        // Chức năng 3: Tính tổng
        static int TinhTong(int[] a)
        {
            int tong = 0;
            foreach (int item in a)
            {
                tong += item;
            }
            return tong;
        }

        // Chức năng 4: Tìm Max
        static int TimMax(int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max) max = a[i];
            }
            return max;
        }

        // Chức năng 4: Tìm Min
        static int TimMin(int[] a)
        {
            int min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min) min = a[i];
            }
            return min;
        }

        // Chức năng 5: Đếm chẵn
        static int DemChan(int[] a)
        {
            int dem = 0;
            foreach (int item in a)
            {
                if (item % 2 == 0) dem++;
            }
            return dem;
        }

        // Chức năng 5: Đếm lẻ
        static int DemLe(int[] a)
        {
            int dem = 0;
            foreach (int item in a)
            {
                if (item % 2 != 0) dem++;
            }
            return dem;
        }

        // Chức năng 6: Sắp xếp tăng dần (Sử dụng thuật toán Bubble Sort cơ bản hoặc Array.Sort)
        static void SapXepTangDan(int[] a)
        {
            Array.Sort(a); // Tối ưu bằng hàm có sẵn của C#
            Console.WriteLine("=> Da sap xep mang tang dan.");
            XuatMang(a); // In kết quả sau khi sắp xếp
        }

        // Chức năng 7: Tìm kiếm
        static int TimKiem(int[] a, int x)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == x)
                {
                    return i; // Trả về vị trí đầu tiên tìm thấy
                }
            }
            return -1; // Không tìm thấy
        }
    }
}