using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Lab11
{
    public partial class FrmLop : Form
    {
        string chuoiKetNoi = @"Data Source=.\SQLEXPRESS;Initial Catalog=EduManagerDB;Integrated Security=True;TrustServerCertificate=True";

        public FrmLop()
        {
            InitializeComponent();
            CaiDatGiaoDien();
        }

        // Thiết lập màu sắc và định dạng hiển thị cho Form
        private void CaiDatGiaoDien()
        {
            this.BackColor = Color.FromArgb(245, 246, 250);
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            dgvLop.BackgroundColor = Color.White;
            dgvLop.BorderStyle = BorderStyle.None;
            dgvLop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLop.EnableHeadersVisualStyles = false;

            dgvLop.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(108, 92, 231);
            dgvLop.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvLop.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvLop.ColumnHeadersHeight = 35;

            dgvLop.DefaultCellStyle.SelectionBackColor = Color.FromArgb(162, 155, 254);
            dgvLop.DefaultCellStyle.SelectionForeColor = Color.Black;

            BoTronNutBam(btnThem, Color.FromArgb(0, 184, 148));
            BoTronNutBam(btnSua, Color.FromArgb(9, 132, 227));
            BoTronNutBam(btnXoa, Color.FromArgb(214, 48, 49));
            BoTronNutBam(btnLamMoi, Color.FromArgb(253, 203, 110));
            BoTronNutBam(btnTimKiem, Color.FromArgb(108, 92, 231));
        }

        // Bo tròn góc và tô màu nút bấm
        private void BoTronNutBam(Button nutBam, Color mauNen)
        {
            nutBam.FlatStyle = FlatStyle.Flat;
            nutBam.FlatAppearance.BorderSize = 0;
            nutBam.BackColor = mauNen;
            nutBam.ForeColor = Color.White;
            nutBam.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            nutBam.Cursor = Cursors.Hand;

            GraphicsPath duongVien = new GraphicsPath();
            int banKinhBoGoc = 12;
            duongVien.AddArc(0, 0, banKinhBoGoc, banKinhBoGoc, 180, 90);
            duongVien.AddArc(nutBam.Width - banKinhBoGoc, 0, banKinhBoGoc, banKinhBoGoc, 270, 90);
            duongVien.AddArc(nutBam.Width - banKinhBoGoc, nutBam.Height - banKinhBoGoc, banKinhBoGoc, banKinhBoGoc, 0, 90);
            duongVien.AddArc(0, nutBam.Height - banKinhBoGoc, banKinhBoGoc, banKinhBoGoc, 90, 90);
            duongVien.CloseFigure();

            nutBam.Region = new Region(duongVien);
        }

        // Chức năng F1: Tự động tải danh sách lớp khi mở Form
        private void FrmLop_Load(object sender, EventArgs e)
        {
            TaiDanhSachLop();
        }

        // Truy vấn và hiển thị danh sách lớp lên DataGridView
        private void TaiDanhSachLop()
        {
            try
            {
                string cauLenhSql = "SELECT MaLop, TenLop FROM LOP";
                using (SqlConnection ketNoi = new SqlConnection(chuoiKetNoi))
                {
                    using (SqlCommand lenhThucThi = new SqlCommand(cauLenhSql, ketNoi))
                    {
                        SqlDataAdapter boChuyenDoiDuLieu = new SqlDataAdapter(lenhThucThi);
                        DataTable bangLopHoc = new DataTable();
                        boChuyenDoiDuLieu.Fill(bangLopHoc);
                        dgvLop.DataSource = bangLopHoc;

                        dgvLop.Columns["MaLop"].HeaderText = "Mã Lớp Học";
                        dgvLop.Columns["TenLop"].HeaderText = "Tên Lớp Học";
                    }
                }
            }
            catch (Exception loiKetNoi)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + loiKetNoi.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Chức năng F2: Đưa dữ liệu từ dòng được chọn lên các ô nhập liệu
        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dongDuocChon = dgvLop.Rows[e.RowIndex];
                txtMaLop.Text = dongDuocChon.Cells["MaLop"].Value.ToString();
                txtTenLop.Text = dongDuocChon.Cells["TenLop"].Value.ToString();

                txtMaLop.Enabled = false;
            }
        }

        // Kiểm tra dữ liệu nhập không được để trống
        private bool KiemTraDuLieuRong()
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text))
            {
                MessageBox.Show("Vui lòng nhập mã lớp!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaLop.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenLop.Text))
            {
                MessageBox.Show("Vui lòng nhập tên lớp!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenLop.Focus();
                return false;
            }
            return true;
        }

        // Kiểm tra mã lớp đã tồn tại trong cơ sở dữ liệu hay chưa
        private bool KiemTraTrungMaLop(string maLopCanKiemTra)
        {
            string cauLenhSql = "SELECT COUNT(*) FROM LOP WHERE MaLop = @MaLop";
            using (SqlConnection ketNoi = new SqlConnection(chuoiKetNoi))
            {
                using (SqlCommand lenhThucThi = new SqlCommand(cauLenhSql, ketNoi))
                {
                    lenhThucThi.Parameters.AddWithValue("@MaLop", maLopCanKiemTra);
                    ketNoi.Open();
                    int soLuongKetQua = Convert.ToInt32(lenhThucThi.ExecuteScalar());
                    return soLuongKetQua > 0;
                }
            }
        }

        // Đếm số lượng sinh viên thuộc lớp học
        private int DemSoSinhVienTrongLop(string maLopCanDem)
        {
            string cauLenhSql = "SELECT COUNT(*) FROM SINHVIEN WHERE MaLop = @MaLop";
            using (SqlConnection ketNoi = new SqlConnection(chuoiKetNoi))
            {
                using (SqlCommand lenhThucThi = new SqlCommand(cauLenhSql, ketNoi))
                {
                    lenhThucThi.Parameters.AddWithValue("@MaLop", maLopCanDem);
                    ketNoi.Open();
                    return Convert.ToInt32(lenhThucThi.ExecuteScalar());
                }
            }
        }

        // Chức năng F3: Thêm lớp học mới
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieuRong()) return;

            string maLopMoi = txtMaLop.Text.Trim();
            string tenLopMoi = txtTenLop.Text.Trim();

            try
            {
                if (KiemTraTrungMaLop(maLopMoi))
                {
                    MessageBox.Show("Mã lớp này đã tồn tại trong hệ thống!", "Lỗi trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string cauLenhSql = "INSERT INTO LOP (MaLop, TenLop) VALUES (@MaLop, @TenLop)";
                using (SqlConnection ketNoi = new SqlConnection(chuoiKetNoi))
                {
                    using (SqlCommand lenhThucThi = new SqlCommand(cauLenhSql, ketNoi))
                    {
                        lenhThucThi.Parameters.AddWithValue("@MaLop", maLopMoi);
                        lenhThucThi.Parameters.AddWithValue("@TenLop", tenLopMoi);
                        ketNoi.Open();
                        int soDongThem = lenhThucThi.ExecuteNonQuery();

                        if (soDongThem > 0)
                        {
                            MessageBox.Show("Thêm lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            XoaTrangOChuVaTaiLai();
                        }
                    }
                }
            }
            catch (Exception loiThucThi)
            {
                MessageBox.Show("Lỗi khi thêm lớp: " + loiThucThi.Message, "Lỗi cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Chức năng F4: Cập nhật tên lớp theo mã lớp đang chọn
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Enabled || string.IsNullOrWhiteSpace(txtMaLop.Text))
            {
                MessageBox.Show("Vui lòng chọn một lớp từ danh sách bên dưới để cập nhật!", "Chưa chọn lớp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!KiemTraDuLieuRong()) return;

            string maLopDangChon = txtMaLop.Text.Trim();
            string tenLopCapNhat = txtTenLop.Text.Trim();

            try
            {
                string cauLenhSql = "UPDATE LOP SET TenLop = @TenLop WHERE MaLop = @MaLop";
                using (SqlConnection ketNoi = new SqlConnection(chuoiKetNoi))
                {
                    using (SqlCommand lenhThucThi = new SqlCommand(cauLenhSql, ketNoi))
                    {
                        lenhThucThi.Parameters.AddWithValue("@MaLop", maLopDangChon);
                        lenhThucThi.Parameters.AddWithValue("@TenLop", tenLopCapNhat);
                        ketNoi.Open();
                        int soDongCapNhat = lenhThucThi.ExecuteNonQuery();

                        if (soDongCapNhat > 0)
                        {
                            MessageBox.Show("Cập nhật tên lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            XoaTrangOChuVaTaiLai();
                        }
                    }
                }
            }
            catch (Exception loiThucThi)
            {
                MessageBox.Show("Lỗi khi cập nhật lớp: " + loiThucThi.Message, "Lỗi cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Chức năng F5: Xóa lớp học sau khi xác nhận và kiểm tra ràng buộc sinh viên
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maLopCanXoa = txtMaLop.Text.Trim();
            if (txtMaLop.Enabled || string.IsNullOrWhiteSpace(maLopCanXoa))
            {
                MessageBox.Show("Vui lòng chọn một lớp từ danh sách bên dưới để xóa!", "Chưa chọn lớp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult ketQuaXacNhan = MessageBox.Show("Bạn có chắc chắn muốn xóa lớp này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ketQuaXacNhan == DialogResult.No) return;

            try
            {
                int soLuongSinhVien = DemSoSinhVienTrongLop(maLopCanXoa);
                if (soLuongSinhVien > 0)
                {
                    MessageBox.Show("Không thể xóa lớp đang có sinh viên theo học!", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string cauLenhSql = "DELETE FROM LOP WHERE MaLop = @MaLop";
                using (SqlConnection ketNoi = new SqlConnection(chuoiKetNoi))
                {
                    using (SqlCommand lenhThucThi = new SqlCommand(cauLenhSql, ketNoi))
                    {
                        lenhThucThi.Parameters.AddWithValue("@MaLop", maLopCanXoa);
                        ketNoi.Open();
                        int soDongXoa = lenhThucThi.ExecuteNonQuery();

                        if (soDongXoa > 0)
                        {
                            MessageBox.Show("Đã xóa lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            XoaTrangOChuVaTaiLai();
                        }
                    }
                }
            }
            catch (Exception loiThucThi)
            {
                MessageBox.Show("Lỗi khi xóa lớp: " + loiThucThi.Message, "Lỗi cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Chức năng F6: Tìm kiếm lớp học theo mã hoặc tên lớp
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoaTimKiem = txtTimKiem.Text.Trim();
            try
            {
                string cauLenhSql = "SELECT MaLop, TenLop FROM LOP WHERE MaLop LIKE @TuKhoa OR TenLop LIKE @TuKhoa";
                using (SqlConnection ketNoi = new SqlConnection(chuoiKetNoi))
                {
                    using (SqlCommand lenhThucThi = new SqlCommand(cauLenhSql, ketNoi))
                    {
                        lenhThucThi.Parameters.AddWithValue("@TuKhoa", "%" + tuKhoaTimKiem + "%");
                        SqlDataAdapter boChuyenDoiDuLieu = new SqlDataAdapter(lenhThucThi);
                        DataTable bangKetQua = new DataTable();
                        boChuyenDoiDuLieu.Fill(bangKetQua);
                        dgvLop.DataSource = bangKetQua;
                    }
                }
            }
            catch (Exception loiThucThi)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + loiThucThi.Message, "Lỗi cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Chức năng F7: Làm mới ô nhập liệu, mở khóa mã lớp và tải lại danh sách
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            XoaTrangOChuVaTaiLai();
        }

        // Xóa dữ liệu đang nhập trên các TextBox và tải lại bảng
        private void XoaTrangOChuVaTaiLai()
        {
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtTimKiem.Clear();
            txtMaLop.Enabled = true;
            txtMaLop.Focus();
            TaiDanhSachLop();
        }

        private void dgvLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}