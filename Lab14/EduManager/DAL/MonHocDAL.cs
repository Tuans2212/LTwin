using System.Collections.Generic;
using System.Linq;
using EduManager.Data;
using EduManager.Models;

namespace EduManager.DAL
{
    public class MonHocDAL
    {
        public List<MonHoc> LayDanhSach()
        {
            using (EduManagerContext db = new EduManagerContext())
            {
                return db.MonHocs.OrderBy(m => m.MaMonHoc).ToList();
            }
        }

        public MonHoc TimTheoMa(string maMon)
        {
            using (EduManagerContext db = new EduManagerContext())
            {
                return db.MonHocs.FirstOrDefault(m => m.MaMonHoc == maMon);
            }
        }

        public bool KiemTraTonTai(string maMon)
        {
            return TimTheoMa(maMon) != null;
        }

        public bool Them(MonHoc mh)
        {
            using (EduManagerContext db = new EduManagerContext())
            {
                db.MonHocs.Add(mh);
                int soDong = db.SaveChanges();
                return soDong > 0;
            }
        }

        public bool Sua(MonHoc mh)
        {
            using (EduManagerContext db = new EduManagerContext())
            {
                MonHoc monCu = db.MonHocs.FirstOrDefault(m => m.MaMonHoc == mh.MaMonHoc);
                if (monCu == null)
                {
                    return false;
                }

                monCu.TenMonHoc = mh.TenMonHoc;
                monCu.SoTinChi = mh.SoTinChi;
                monCu.TrangThai = mh.TrangThai;

                int soDong = db.SaveChanges();
                return soDong > 0;
            }
        }

        public bool Xoa(string maMon)
        {
            using (EduManagerContext db = new EduManagerContext())
            {
                MonHoc monXoa = db.MonHocs.FirstOrDefault(m => m.MaMonHoc == maMon);
                if (monXoa == null)
                {
                    return false;
                }

                db.MonHocs.Remove(monXoa);
                int soDong = db.SaveChanges();
                return soDong > 0;
            }
        }

        public List<MonHoc> TimKiem(string tuKhoa)
        {
            using (EduManagerContext db = new EduManagerContext())
            {
                string tk = tuKhoa.Trim().ToLower();
                return db.MonHocs
                    .Where(m => m.MaMonHoc.ToLower().Contains(tk) || m.TenMonHoc.ToLower().Contains(tk))
                    .OrderBy(m => m.MaMonHoc)
                    .ToList();
            }
        }
    }
}
