using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StudentReportDemo.Models;

namespace StudentReportDemo.Forms
{
    public partial class FrmBaoCaoSinhVien : Form
    {
        private List<SinhVien> dsSinhVien = new List<SinhVien>();
        private List<object> duLieuDangHienThi = new List<object>();
        private bool dangKhoiTao = false;

        public FrmBaoCaoSinhVien()
        {
            InitializeComponent();
        }

        private void FrmBaoCaoSinhVien_Load(object sender, EventArgs e)
        {
            TrangTriGiaoDien();
            TaoDuLieuMau();
            LoadComboBox();
            XemBaoCao();
        }

        private void TrangTriGiaoDien()
        {
            BoGocControl(btnXemBaoCao, 12);
            BoGocControl(btnThongKe, 12);
            BoGocControl(btnXuatFile, 12);
            BoGocControl(btnLamMoi, 12);

            BoGocControl(pnlTheTong, 10);
            BoGocControl(pnlTheDat, 10);
            BoGocControl(pnlTheKhongDat, 10);
            BoGocControl(pnlTheDiemTB, 10);

            dgvBaoCao.EnableHeadersVisualStyles = false;
            dgvBaoCao.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 58, 138);
            dgvBaoCao.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvBaoCao.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvBaoCao.ColumnHeadersHeight = 38;

            dgvBaoCao.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgvBaoCao.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgvBaoCao.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dgvBaoCao.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgvBaoCao.RowTemplate.Height = 32;
            dgvBaoCao.GridColor = Color.FromArgb(226, 232, 240);
        }

        private void BoGocControl(Control ctrl, int banKinh)
        {
            GraphicsPath path = new GraphicsPath();
            int d = banKinh * 2;
            path.AddArc(0, 0, d, d, 180, 90);
            path.AddArc(ctrl.Width - d, 0, d, d, 270, 90);
            path.AddArc(ctrl.Width - d, ctrl.Height - d, d, d, 0, 90);
            path.AddArc(0, ctrl.Height - d, d, d, 90, 90);
            path.CloseFigure();
            ctrl.Region = new Region(path);
        }

        private void TaoDuLieuMau()
        {
            dsSinhVien = new List<SinhVien>
            {
                new SinhVien { MaSV = "4801101", HoTen = "Nguyễn Hoàng Nam", MaLop = "COMP48A", TenLop = "Công nghệ thông tin K48A", Diem = 8.6 },
                new SinhVien { MaSV = "4801102", HoTen = "Trần Lê Bảo Ngọc", MaLop = "COMP48A", TenLop = "Công nghệ thông tin K48A", Diem = 9.2 },
                new SinhVien { MaSV = "4801103", HoTen = "Lê Quốc Tuấn", MaLop = "COMP48A", TenLop = "Công nghệ thông tin K48A", Diem = 4.5 },
                new SinhVien { MaSV = "4801104", HoTen = "Phạm Thị Minh Thư", MaLop = "COMP48A", TenLop = "Công nghệ thông tin K48A", Diem = 7.1 },
                new SinhVien { MaSV = "4801105", HoTen = "Võ Đình Khôi", MaLop = "COMP48B", TenLop = "Công nghệ thông tin K48B", Diem = 6.4 },
                new SinhVien { MaSV = "4801106", HoTen = "Đặng Ngọc Hân", MaLop = "COMP48B", TenLop = "Công nghệ thông tin K48B", Diem = 8.0 },
                new SinhVien { MaSV = "4801107", HoTen = "Bùi Thanh Hải", MaLop = "COMP48B", TenLop = "Công nghệ thông tin K48B", Diem = 3.8 },
                new SinhVien { MaSV = "4801108", HoTen = "Hoàng Gia Bảo", MaLop = "COMP48B", TenLop = "Công nghệ thông tin K48B", Diem = 5.5 },
                new SinhVien { MaSV = "4901201", HoTen = "Ngô Phương Linh", MaLop = "KTPM49A", TenLop = "Kỹ thuật phần mềm K49A", Diem = 9.5 },
                new SinhVien { MaSV = "4901202", HoTen = "Đỗ Minh Quân", MaLop = "KTPM49A", TenLop = "Kỹ thuật phần mềm K49A", Diem = 4.2 },
                new SinhVien { MaSV = "4901203", HoTen = "Huỳnh Tấn Phát", MaLop = "KTPM49A", TenLop = "Kỹ thuật phần mềm K49A", Diem = 7.8 },
                new SinhVien { MaSV = "4901204", HoTen = "Lý Thanh Thảo", MaLop = "KTPM49A", TenLop = "Kỹ thuật phần mềm K49A", Diem = 6.9 },
                new SinhVien { MaSV = "4901301", HoTen = "Trương Quốc Việt", MaLop = "HTTT49A", TenLop = "Hệ thống thông tin K49A", Diem = 5.2 },
                new SinhVien { MaSV = "4901302", HoTen = "Phan Ánh Tuyết", MaLop = "HTTT49A", TenLop = "Hệ thống thông tin K49A", Diem = 8.4 },
                new SinhVien { MaSV = "4901303", HoTen = "Dương Nhật Hào", MaLop = "HTTT49A", TenLop = "Hệ thống thông tin K49A", Diem = 3.5 },
                new SinhVien { MaSV = "4901304", HoTen = "Mai Khánh Vy", MaLop = "HTTT49A", TenLop = "Hệ thống thông tin K49A", Diem = 7.6 }
            };
        }

        private void LoadComboBox()
        {
            dangKhoiTao = true;

            var dsLop = dsSinhVien
                .Select(sv => new { sv.MaLop, sv.TenLop })
                .Distinct()
                .OrderBy(lop => lop.MaLop)
                .ToList();

            dsLop.Insert(0, new { MaLop = "TATCA", TenLop = "--- Tất cả các lớp ---" });

            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
            cboLop.DataSource = dsLop;
            cboLop.SelectedIndex = 0;

            cboKetQua.Items.Clear();
            cboKetQua.Items.Add("Tất cả");
            cboKetQua.Items.Add("Đạt");
            cboKetQua.Items.Add("Không đạt");
            cboKetQua.SelectedIndex = 0;

            dangKhoiTao = false;
        }

        private void XemBaoCao()
        {
            if (dangKhoiTao || cboLop.SelectedValue == null)
                return;

            string maLopChon = cboLop.SelectedValue.ToString();
            string ketQuaChon = cboKetQua.SelectedItem != null ? cboKetQua.SelectedItem.ToString() : "Tất cả";
            string tuKhoa = txtTuKhoa.Text.Trim().ToLower();

            IEnumerable<SinhVien> truyVan = dsSinhVien;

            if (maLopChon != "TATCA")
            {
                truyVan = truyVan.Where(sv => sv.MaLop == maLopChon);
            }

            if (ketQuaChon == "Đạt")
            {
                truyVan = truyVan.Where(sv => sv.Diem >= 5.0);
            }
            else if (ketQuaChon == "Không đạt")
            {
                truyVan = truyVan.Where(sv => sv.Diem < 5.0);
            }

            if (!string.IsNullOrEmpty(tuKhoa))
            {
                truyVan = truyVan.Where(sv =>
                    sv.MaSV.ToLower().Contains(tuKhoa) ||
                    sv.HoTen.ToLower().Contains(tuKhoa));
            }

            var ketQuaLoc = truyVan
                .OrderByDescending(sv => sv.Diem)
                .ThenBy(sv => sv.HoTen)
                .Select(sv => new
                {
                    sv.MaSV,
                    sv.HoTen,
                    sv.MaLop,
                    sv.TenLop,
                    sv.Diem,
                    sv.KetQua
                })
                .ToList();

            dgvBaoCao.DataSource = ketQuaLoc;
            duLieuDangHienThi = ketQuaLoc.Cast<object>().ToList();
            DinhDangCotBaoCaoSV();

            CapNhatThongKe(ketQuaLoc.Count);

            if (ketQuaLoc.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sinh viên nào phù hợp với điều kiện lọc!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DinhDangCotBaoCaoSV()
        {
            if (dgvBaoCao.Columns.Count == 0) return;

            if (dgvBaoCao.Columns["MaSV"] != null)
                dgvBaoCao.Columns["MaSV"].HeaderText = "Mã SV";
            if (dgvBaoCao.Columns["HoTen"] != null)
                dgvBaoCao.Columns["HoTen"].HeaderText = "Họ và tên";
            if (dgvBaoCao.Columns["MaLop"] != null)
                dgvBaoCao.Columns["MaLop"].HeaderText = "Mã lớp";
            if (dgvBaoCao.Columns["TenLop"] != null)
                dgvBaoCao.Columns["TenLop"].HeaderText = "Tên lớp";
            if (dgvBaoCao.Columns["Diem"] != null)
                dgvBaoCao.Columns["Diem"].HeaderText = "Điểm TB";
            if (dgvBaoCao.Columns["KetQua"] != null)
                dgvBaoCao.Columns["KetQua"].HeaderText = "Kết quả";
        }

        private void CapNhatThongKe(int soLuongHienThi)
        {
            string maLopChon = cboLop.SelectedValue != null ? cboLop.SelectedValue.ToString() : "TATCA";

            var dsTheoLop = maLopChon == "TATCA"
                ? dsSinhVien
                : dsSinhVien.Where(sv => sv.MaLop == maLopChon).ToList();

            int tongSo = dsTheoLop.Count;
            int soDat = dsTheoLop.Count(sv => sv.Diem >= 5.0);
            int soKhongDat = dsTheoLop.Count(sv => sv.Diem < 5.0);
            double diemTB = tongSo > 0 ? dsTheoLop.Average(sv => sv.Diem) : 0;

            lblGiaTriTong.Text = tongSo.ToString();
            lblGiaTriDat.Text = soDat.ToString();
            lblGiaTriKhongDat.Text = soKhongDat.ToString();
            lblGiaTriDiemTB.Text = diemTB.ToString("0.00");

            string thongTin = string.Format(
                "Đang lọc: {0} SV | Tổng số SV: {1} | Số đạt: {2} | Không đạt: {3} | Điểm trung bình: {4:0.00}",
                soLuongHienThi, tongSo, soDat, soKhongDat, diemTB);

            lblThongKe.Text = thongTin;
            tslTrangThai.Text = thongTin;
        }

        private void ThongKeTheoLop()
        {
            var bangThongKe = dsSinhVien
                .GroupBy(sv => new { sv.MaLop, sv.TenLop })
                .Select(nhom => new
                {
                    MaLop = nhom.Key.MaLop,
                    TenLop = nhom.Key.TenLop,
                    SoLuongSV = nhom.Count(),
                    SoDat = nhom.Count(sv => sv.Diem >= 5.0),
                    SoKhongDat = nhom.Count(sv => sv.Diem < 5.0),
                    DiemTrungBinh = Math.Round(nhom.Average(sv => sv.Diem), 2)
                })
                .OrderBy(x => x.MaLop)
                .ToList();

            dgvBaoCao.DataSource = bangThongKe;
            duLieuDangHienThi = bangThongKe.Cast<object>().ToList();

            if (dgvBaoCao.Columns["MaLop"] != null)
                dgvBaoCao.Columns["MaLop"].HeaderText = "Mã lớp";
            if (dgvBaoCao.Columns["TenLop"] != null)
                dgvBaoCao.Columns["TenLop"].HeaderText = "Tên lớp";
            if (dgvBaoCao.Columns["SoLuongSV"] != null)
                dgvBaoCao.Columns["SoLuongSV"].HeaderText = "Sĩ số";
            if (dgvBaoCao.Columns["SoDat"] != null)
                dgvBaoCao.Columns["SoDat"].HeaderText = "Số SV Đạt";
            if (dgvBaoCao.Columns["SoKhongDat"] != null)
                dgvBaoCao.Columns["SoKhongDat"].HeaderText = "Số SV Không đạt";
            if (dgvBaoCao.Columns["DiemTrungBinh"] != null)
                dgvBaoCao.Columns["DiemTrungBinh"].HeaderText = "Điểm TB lớp";

            int tongToanKhoa = dsSinhVien.Count;
            int datToanKhoa = dsSinhVien.Count(sv => sv.Diem >= 5.0);
            int rotToanKhoa = dsSinhVien.Count(sv => sv.Diem < 5.0);
            double dtbToanKhoa = tongToanKhoa > 0 ? dsSinhVien.Average(sv => sv.Diem) : 0;

            lblGiaTriTong.Text = tongToanKhoa.ToString();
            lblGiaTriDat.Text = datToanKhoa.ToString();
            lblGiaTriKhongDat.Text = rotToanKhoa.ToString();
            lblGiaTriDiemTB.Text = dtbToanKhoa.ToString("0.00");

            lblThongKe.Text = string.Format(
                "Chế độ: Thống kê tổng hợp ({0} lớp) | Tổng SV: {1} | Đạt: {2} | Không đạt: {3} | ĐTB chung: {4:0.00}",
                bangThongKe.Count, tongToanKhoa, datToanKhoa, rotToanKhoa, dtbToanKhoa);
            tslTrangThai.Text = lblThongKe.Text;
        }

        private void XuatFile()
        {
            if (dgvBaoCao.Rows.Count == 0)
            {
                MessageBox.Show("Hiện không có dữ liệu trên bảng để xuất file!",
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Chọn nơi lưu báo cáo sinh viên";
                sfd.Filter = "CSV File (*.csv)|*.csv|Text File (*.txt)|*.txt";
                sfd.FileName = "BaoCaoSinhVien_" + DateTime.Now.ToString("ddMMyyyy");

                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    StringBuilder sb = new StringBuilder();
                    bool laFileTxt = Path.GetExtension(sfd.FileName).ToLower() == ".txt";
                    string kyTuNganCach = laFileTxt ? "\t|\t" : ",";

                    if (laFileTxt)
                    {
                        sb.AppendLine("==========================================================================");
                        sb.AppendLine("                     BÁO CÁO KẾT QUẢ HỌC TẬP SINH VIÊN                    ");
                        sb.AppendLine("==========================================================================");
                        sb.AppendLine("Thời gian xuất: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                        sb.AppendLine(lblThongKe.Text);
                        sb.AppendLine("--------------------------------------------------------------------------");
                    }

                    for (int i = 0; i < dgvBaoCao.Columns.Count; i++)
                    {
                        sb.Append(dgvBaoCao.Columns[i].HeaderText);
                        if (i < dgvBaoCao.Columns.Count - 1)
                            sb.Append(kyTuNganCach);
                    }
                    sb.AppendLine();

                    if (laFileTxt)
                    {
                        sb.AppendLine("--------------------------------------------------------------------------");
                    }

                    foreach (DataGridViewRow row in dgvBaoCao.Rows)
                    {
                        if (row.IsNewRow) continue;

                        for (int i = 0; i < dgvBaoCao.Columns.Count; i++)
                        {
                            string giaTri = row.Cells[i].Value != null ? row.Cells[i].Value.ToString() : "";
                            if (!laFileTxt)
                            {
                                giaTri = giaTri.Replace(",", " ");
                            }
                            sb.Append(giaTri);
                            if (i < dgvBaoCao.Columns.Count - 1)
                                sb.Append(kyTuNganCach);
                        }
                        sb.AppendLine();
                    }

                    File.WriteAllText(sfd.FileName, sb.ToString(), new UTF8Encoding(true));
                    MessageBox.Show("Đã xuất báo cáo thành công tại: " + sfd.FileName,
                        "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể lưu file. Chi tiết lỗi: " + ex.Message,
                        "Lỗi xuất file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            XemBaoCao();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThongKeTheoLop();
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            XuatFile();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dangKhoiTao = true;
            cboLop.SelectedIndex = 0;
            cboKetQua.SelectedIndex = 0;
            txtTuKhoa.Clear();
            dangKhoiTao = false;
            XemBaoCao();
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            XemBaoCao();
        }

        private void cboKetQua_SelectedIndexChanged(object sender, EventArgs e)
        {
            XemBaoCao();
        }

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {
            XemBaoCao();
        }
    }
}
