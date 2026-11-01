using System.Collections.Generic;
using EduManager.DAL;
using EduManager.Models;

namespace EduManager.BLL
{
    public class MonHocBLL
    {
        private MonHocDAL dal = new MonHocDAL();

        public List<MonHoc> LayDanhSachMonHoc()
        {
            return dal.LayDanhSach();
        }

        // Kiểm tra các ràng buộc dữ liệu trước khi gọi xuống DAL
        private string KiemTraHopLe(MonHoc mh)
        {
            if (mh == null)
                return "Dữ liệu môn học không hợp lệ!";

            if (string.IsNullOrWhiteSpace(mh.MaMonHoc))
                return "Mã môn học không được để trống!";

            if (mh.MaMonHoc.Trim().Length > 10)
                return "Mã môn học chỉ tối đa 10 ký tự!";

            if (string.IsNullOrWhiteSpace(mh.TenMonHoc))
                return "Tên môn học không được để trống!";

            if (mh.TenMonHoc.Trim().Length > 100)
                return "Tên môn học chỉ tối đa 100 ký tự!";

            if (mh.SoTinChi < 1 || mh.SoTinChi > 6)
                return "Số tín chỉ phải nằm trong khoảng từ 1 đến 6!";

            return "";
        }

        public bool ThemMonHoc(MonHoc mh, out string thongBao)
        {
            thongBao = KiemTraHopLe(mh);
            if (thongBao != "")
                return false;

            mh.MaMonHoc = mh.MaMonHoc.Trim().ToUpper();
            mh.TenMonHoc = mh.TenMonHoc.Trim();

            if (dal.KiemTraTonTai(mh.MaMonHoc))
            {
                thongBao = "Mã môn học " + mh.MaMonHoc + " đã tồn tại, vui lòng nhập mã khác!";
                return false;
            }

            bool kq = dal.Them(mh);
            if (kq)
                thongBao = "Thêm môn học mới thành công!";
            else
                thongBao = "Không thể thêm môn học vào CSDL!";

            return kq;
        }

        public bool SuaMonHoc(MonHoc mh, out string thongBao)
        {
            thongBao = KiemTraHopLe(mh);
            if (thongBao != "")
                return false;

            mh.MaMonHoc = mh.MaMonHoc.Trim().ToUpper();
            mh.TenMonHoc = mh.TenMonHoc.Trim();

            if (!dal.KiemTraTonTai(mh.MaMonHoc))
            {
                thongBao = "Không tìm thấy mã môn học " + mh.MaMonHoc + " để cập nhật!";
                return false;
            }

            bool kq = dal.Sua(mh);
            if (kq)
                thongBao = "Cập nhật thông tin môn học thành công!";
            else
                thongBao = "Cập nhật thất bại!";

            return kq;
        }

        public bool XoaMonHoc(string maMon, out string thongBao)
        {
            if (string.IsNullOrWhiteSpace(maMon))
            {
                thongBao = "Vui lòng chọn môn học cần xóa!";
                return false;
            }

            string ma = maMon.Trim().ToUpper();
            if (!dal.KiemTraTonTai(ma))
            {
                thongBao = "Mã môn học " + ma + " không tồn tại trong hệ thống!";
                return false;
            }

            bool kq = dal.Xoa(ma);
            if (kq)
                thongBao = "Đã xóa môn học thành công!";
            else
                thongBao = "Xóa môn học thất bại!";

            return kq;
        }

        public List<MonHoc> TimKiemMonHoc(string tuKhoa)
        {
            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                return dal.LayDanhSach();
            }
            return dal.TimKiem(tuKhoa);
        }
    }
}
