using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using EduManager.BLL;
using EduManager.Models;

namespace EduManager.GUI
{
    public partial class FrmMonHoc : Form
    {
        private MonHocBLL bll = new MonHocBLL();

        public FrmMonHoc()
        {
            InitializeComponent();
        }

        private void FrmMonHoc_Load(object sender, EventArgs e)
        {
            CaiDatGiaoDien();
            TaiDanhSachMonHoc();
        }

        private void CaiDatGiaoDien()
        {
            BoGocControl(btnThem, 12);
            BoGocControl(btnSua, 12);
            BoGocControl(btnXoa, 12);
            BoGocControl(btnLamMoi, 12);
            BoGocControl(btnTimKiem, 10);

            BoGocControl(lblBadgeTong, 8);
            BoGocControl(lblBadgeMo, 8);
            BoGocControl(lblBadgeNgung, 8);

            BoGocControl(pnlNhapLieu, 10);
            BoGocControl(pnlChucNang, 10);
            BoGocControl(pnlTimKiem, 10);
            BoGocControl(pnlDanhSach, 10);

            dgvMonHoc.EnableHeadersVisualStyles = false;
            dgvMonHoc.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(17, 75, 70);
            dgvMonHoc.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvMonHoc.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(17, 75, 70);
            dgvMonHoc.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dgvMonHoc.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvMonHoc.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgvMonHoc.DefaultCellStyle.SelectionBackColor = Color.FromArgb(204, 251, 241);
            dgvMonHoc.DefaultCellStyle.SelectionForeColor = Color.FromArgb(17, 94, 89);
            dgvMonHoc.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(242, 249, 246);
            dgvMonHoc.GridColor = Color.FromArgb(226, 232, 240);
        }

        // Bo góc tròn cho các nút bấm và khung chứa
        private void BoGocControl(Control ctrl, int banKinh)
        {
            if (ctrl.Width <= 0 || ctrl.Height <= 0) return;

            GraphicsPath path = TaoHinhBoGoc(ctrl.Width, ctrl.Height, banKinh);
            ctrl.Region = new Region(path);

            ctrl.Paint += (s, e) =>
            {
                if (ctrl.Parent == null) return;
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (GraphicsPath vien = TaoHinhBoGoc(ctrl.Width - 1, ctrl.Height - 1, banKinh))
                using (Region vungNgoai = new Region(new Rectangle(0, 0, ctrl.Width, ctrl.Height)))
                {
                    vungNgoai.Exclude(vien);
                    using (SolidBrush coNen = new SolidBrush(ctrl.Parent.BackColor))
                    {
                        e.Graphics.FillRegion(coNen, vungNgoai);
                    }
                    using (Pen but = new Pen(ctrl.Parent.BackColor, 1.5f))
                    {
                        e.Graphics.DrawPath(but, vien);
                    }
                }
            };
        }

        private GraphicsPath TaoHinhBoGoc(int w, int h, int r)
        {
            GraphicsPath path = new GraphicsPath();
            int d = r * 2;
            path.AddArc(0, 0, d, d, 180, 90);
            path.AddArc(w - d, 0, d, d, 270, 90);
            path.AddArc(w - d, h - d, d, d, 0, 90);
            path.AddArc(0, h - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void HienThiLenBang(List<MonHoc> ds)
        {
            dgvMonHoc.DataSource = null;
            dgvMonHoc.DataSource = ds;

            if (dgvMonHoc.Columns["MaMonHoc"] != null)
            {
                dgvMonHoc.Columns["MaMonHoc"].HeaderText = "Mã môn học";
                dgvMonHoc.Columns["MaMonHoc"].FillWeight = 20;
            }
            if (dgvMonHoc.Columns["TenMonHoc"] != null)
            {
                dgvMonHoc.Columns["TenMonHoc"].HeaderText = "Tên môn học";
                dgvMonHoc.Columns["TenMonHoc"].FillWeight = 48;
            }
            if (dgvMonHoc.Columns["SoTinChi"] != null)
            {
                dgvMonHoc.Columns["SoTinChi"].HeaderText = "Số tín chỉ";
                dgvMonHoc.Columns["SoTinChi"].FillWeight = 16;
            }
            if (dgvMonHoc.Columns["TrangThai"] != null)
            {
                dgvMonHoc.Columns["TrangThai"].HeaderText = "Còn sử dụng";
                dgvMonHoc.Columns["TrangThai"].FillWeight = 16;
            }

            CapNhatThongKe(ds);
        }

        private void CapNhatThongKe(List<MonHoc> ds)
        {
            int tong = ds.Count;
            int dangMo = 0;
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i].TrangThai)
                    dangMo++;
            }
            int tamNgung = tong - dangMo;

            lblBadgeTong.Text = "Tổng: " + tong + " môn";
            lblBadgeMo.Text = "Đang mở: " + dangMo;
            lblBadgeNgung.Text = "Tạm ngưng: " + tamNgung;
        }

        private void TaiDanhSachMonHoc()
        {
            try
            {
                List<MonHoc> ds = bll.LayDanhSachMonHoc();
                HienThiLenBang(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private MonHoc LayThongTinTuForm()
        {
            MonHoc mh = new MonHoc();
            mh.MaMonHoc = txtMaMonHoc.Text.Trim();
            mh.TenMonHoc = txtTenMonHoc.Text.Trim();
            mh.SoTinChi = (int)nudSoTinChi.Value;
            mh.TrangThai = chkTrangThai.Checked;
            return mh;
        }

        private void LamMoiOThongTin()
        {
            txtMaMonHoc.Clear();
            txtMaMonHoc.Enabled = true;
            txtTenMonHoc.Clear();
            nudSoTinChi.Value = 3;
            chkTrangThai.Checked = true;
            txtTimKiem.Clear();
            lblCheDo.Text = "Chế độ: Thêm mới";
            txtMaMonHoc.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                MonHoc mh = LayThongTinTuForm();
                string thongBao;
                bool ketQua = bll.ThemMonHoc(mh, out thongBao);

                if (ketQua)
                {
                    MessageBox.Show(thongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TaiDanhSachMonHoc();
                    LamMoiOThongTin();
                }
                else
                {
                    MessageBox.Show(thongBao, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm môn học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                MonHoc mh = LayThongTinTuForm();
                string thongBao;
                bool ketQua = bll.SuaMonHoc(mh, out thongBao);

                if (ketQua)
                {
                    MessageBox.Show(thongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TaiDanhSachMonHoc();
                    LamMoiOThongTin();
                }
                else
                {
                    MessageBox.Show(thongBao, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật môn học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maXoa = txtMaMonHoc.Text.Trim();
            if (string.IsNullOrWhiteSpace(maXoa))
            {
                MessageBox.Show("Vui lòng chọn môn học trên bảng trước khi xóa!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult hoi = MessageBox.Show(
                "Bạn có chắc muốn xóa môn học " + maXoa + " không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (hoi == DialogResult.Yes)
            {
                try
                {
                    string thongBao;
                    bool ketQua = bll.XoaMonHoc(maXoa, out thongBao);

                    if (ketQua)
                    {
                        MessageBox.Show(thongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TaiDanhSachMonHoc();
                        LamMoiOThongTin();
                    }
                    else
                    {
                        MessageBox.Show(thongBao, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa môn học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiOThongTin();
            TaiDanhSachMonHoc();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string tuKhoa = txtTimKiem.Text.Trim();
                List<MonHoc> dsTim = bll.TimKiemMonHoc(tuKhoa);
                HienThiLenBang(dsTim);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        // Đổ dữ liệu từ dòng được chọn lên các ô nhập liệu
        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvMonHoc.Rows.Count)
            {
                DataGridViewRow row = dgvMonHoc.Rows[e.RowIndex];

                if (row.Cells["MaMonHoc"].Value != null)
                {
                    txtMaMonHoc.Text = row.Cells["MaMonHoc"].Value.ToString();
                    txtMaMonHoc.Enabled = false;
                    lblCheDo.Text = "Đang chọn: " + txtMaMonHoc.Text;
                }

                if (row.Cells["TenMonHoc"].Value != null)
                {
                    txtTenMonHoc.Text = row.Cells["TenMonHoc"].Value.ToString();
                }

                if (row.Cells["SoTinChi"].Value != null)
                {
                    int tc = Convert.ToInt32(row.Cells["SoTinChi"].Value);
                    if (tc >= nudSoTinChi.Minimum && tc <= nudSoTinChi.Maximum)
                    {
                        nudSoTinChi.Value = tc;
                    }
                }

                if (row.Cells["TrangThai"].Value != null)
                {
                    chkTrangThai.Checked = Convert.ToBoolean(row.Cells["TrangThai"].Value);
                }
            }
        }
    }
}
