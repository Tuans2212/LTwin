using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using QLSinhVienLab12.DAL;

namespace QLSinhVienLab12.Forms
{
    public partial class FrmNhapDiemTheoLop : Form
    {
        private readonly KetQuaDAL db = new KetQuaDAL();
        private readonly BindingSource bsKetQua = new BindingSource();
        private DataTable dtHienTai = new DataTable();

        public FrmNhapDiemTheoLop()
        {
            InitializeComponent();
        }

        private void FrmNhapDiemTheoLop_Load(object sender, EventArgs e)
        {
            BoTronNut(btnTaiDanhSach, 14);
            BoTronNut(btnLuuTatCa, 14);
            BoTronNut(btnLamMoi, 14);

            CauHinhDataGridView();
            LoadComboBox();
            lblTrangThai.Text = "Sẵn sàng. Hãy chọn lớp và môn học để tải danh sách.";
        }

        private void BoTronNut(Button btn, int banKinh)
        {
            btn.Resize += (s, e) => CapNhatVungBoTron(btn, banKinh);
            CapNhatVungBoTron(btn, banKinh);
        }

        private void CapNhatVungBoTron(Control ctrl, int banKinh)
        {
            if (ctrl.Width <= 0 || ctrl.Height <= 0) return;
            using GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, banKinh, banKinh, 180, 90);
            path.AddArc(ctrl.Width - banKinh, 0, banKinh, banKinh, 270, 90);
            path.AddArc(ctrl.Width - banKinh, ctrl.Height - banKinh, banKinh, banKinh, 0, 90);
            path.AddArc(0, ctrl.Height - banKinh, banKinh, banKinh, 90, 90);
            path.CloseAllFigures();
            ctrl.Region = new Region(path);
        }

        private void CauHinhDataGridView()
        {
            dgvKetQua.AutoGenerateColumns = false;
            dgvKetQua.Columns.Clear();

            DataGridViewTextBoxColumn colMaSV = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MaSV",
                HeaderText = "Mã SV",
                Name = "colMaSV",
                ReadOnly = true,
                Width = 130
            };

            DataGridViewTextBoxColumn colHoTen = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "HoTen",
                HeaderText = "Họ và tên sinh viên",
                Name = "colHoTen",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };

            DataGridViewTextBoxColumn colDiem = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Diem",
                HeaderText = "Điểm số (0 - 10)",
                Name = "colDiem",
                ReadOnly = false,
                Width = 150
            };

            DataGridViewTextBoxColumn colGhiChu = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "GhiChu",
                HeaderText = "Ghi chú",
                Name = "colGhiChu",
                ReadOnly = false,
                Width = 240
            };

            dgvKetQua.Columns.AddRange(colMaSV, colHoTen, colDiem, colGhiChu);
            dgvKetQua.DataSource = bsKetQua;

            dgvKetQua.EnableHeadersVisualStyles = false;
            dgvKetQua.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(43, 45, 66);
            dgvKetQua.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvKetQua.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvKetQua.ColumnHeadersHeight = 40;

            dgvKetQua.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvKetQua.DefaultCellStyle.SelectionBackColor = Color.FromArgb(216, 226, 220);
            dgvKetQua.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvKetQua.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);
            dgvKetQua.RowTemplate.Height = 34;
        }

        private void LoadComboBox()
        {
            try
            {
                DataTable dtLop = db.GetLop();
                cboLop.DataSource = dtLop;
                cboLop.DisplayMember = "TenLop";
                cboLop.ValueMember = "MaLop";

                DataTable dtMon = db.GetMonHoc();
                cboMonHoc.DataSource = dtMon;
                cboMonHoc.DisplayMember = "TenMon";
                cboMonHoc.ValueMember = "MaMon";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL khi tải danh mục: " + ex.Message,
                    "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblTrangThai.Text = "Lỗi kết nối cơ sở dữ liệu.";
            }
        }

        private void btnTaiDanhSach_Click(object sender, EventArgs e)
        {
            TaiDanhSachSinhVien();
        }

        private void TaiDanhSachSinhVien()
        {
            string maLop = cboLop.SelectedValue?.ToString() ?? "";
            string maMon = cboMonHoc.SelectedValue?.ToString() ?? "";

            if (string.IsNullOrEmpty(maLop) || string.IsNullOrEmpty(maMon))
            {
                MessageBox.Show("Vui lòng chọn đầy đủ lớp và môn học.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                dtHienTai = db.GetKetQuaByLopMon(maLop, maMon);
                bsKetQua.DataSource = dtHienTai;
                bsKetQua.RemoveFilter();
                txtTimKiem.Clear();

                CapNhatThongKe();
                lblTrangThai.Text = $"Đã tải {dtHienTai.Rows.Count} sinh viên của lớp {maLop} - Môn {maMon}.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải danh sách: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblTrangThai.Text = "Tải danh sách thất bại.";
            }
        }

        private void btnLuuTatCa_Click(object sender, EventArgs e)
        {
            if (bsKetQua.DataSource == null || dtHienTai.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu sinh viên để lưu. Hãy bấm Tải danh sách trước.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                dgvKetQua.EndEdit();
                bsKetQua.EndEdit();

                KiemTraHopLe(dtHienTai);

                string maMon = cboMonHoc.SelectedValue?.ToString() ?? "";
                int soDong = db.SaveAll(maMon, dtHienTai);

                CapNhatThongKe();
                lblTrangThai.Text = $"Lưu thành công {soDong} sinh viên lúc {DateTime.Now:HH:mm:ss}.";
                MessageBox.Show($"Đã lưu thành công kết quả của {soDong} sinh viên!",
                    "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                lblTrangThai.Text = "Lỗi khi lưu điểm! Đã hủy (Rollback) toàn bộ thao tác.";
                MessageBox.Show("Không thể lưu dữ liệu (Đã Rollback toàn bộ):\n" + ex.Message,
                    "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void KiemTraHopLe(DataTable table)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                string maSV = row["MaSV"]?.ToString() ?? "";
                string hoTen = row["HoTen"]?.ToString() ?? "";
                string diemStr = row["Diem"]?.ToString()?.Trim() ?? "";

                if (string.IsNullOrEmpty(diemStr))
                {
                    throw new Exception($"Dòng {i + 1}: Điểm của sinh viên {maSV} ({hoTen}) không được để trống.");
                }

                if (!double.TryParse(diemStr, out double diem))
                {
                    throw new Exception($"Dòng {i + 1}: Điểm của sinh viên {maSV} ({hoTen}) phải là chữ số hợp lệ.");
                }

                if (diem < 0 || diem > 10)
                {
                    throw new Exception($"Dòng {i + 1}: Điểm của sinh viên {maSV} ({hoTen}) là {diem}, nằm ngoài khoảng [0 - 10].");
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (bsKetQua.DataSource == null) return;

            string tuKhoa = txtTimKiem.Text.Trim().Replace("'", "''");
            if (string.IsNullOrEmpty(tuKhoa))
            {
                bsKetQua.RemoveFilter();
            }
            else
            {
                bsKetQua.Filter = $"MaSV LIKE '%{tuKhoa}%' OR HoTen LIKE '%{tuKhoa}%'";
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            if (bsKetQua.DataSource != null)
            {
                bsKetQua.RemoveFilter();
                TaiDanhSachSinhVien();
            }
        }

        private void dgvKetQua_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CapNhatThongKe();
        }

        private void CapNhatThongKe()
        {
            if (dtHienTai == null || dtHienTai.Rows.Count == 0)
            {
                lblSiSo.Text = "Sĩ số: 0";
                lblDiemTB.Text = "Điểm TB: 0.00";
                lblQuaMon.Text = "Đạt (>=5): 0";
                return;
            }

            int tongSV = dtHienTai.Rows.Count;
            double tongDiem = 0;
            int demHopLe = 0;
            int soQuaMon = 0;

            foreach (DataRow r in dtHienTai.Rows)
            {
                if (double.TryParse(r["Diem"]?.ToString(), out double d) && d >= 0 && d <= 10)
                {
                    tongDiem += d;
                    demHopLe++;
                    if (d >= 5.0) soQuaMon++;
                }
            }

            double dtb = demHopLe > 0 ? tongDiem / demHopLe : 0;
            lblSiSo.Text = $"Sĩ số: {tongSV} SV";
            lblDiemTB.Text = $"Điểm TB: {dtb:0.00}";
            lblQuaMon.Text = $"Qua môn: {soQuaMon}/{tongSV}";
        }
    }
}
