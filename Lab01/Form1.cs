using System;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // =========================================================
        // Yêu cầu 1: Khởi tạo ComboBox khi mở chương trình
        // =========================================================
        private void Form1_Load(object sender, EventArgs e)
        {
            // Thêm ít nhất 3 lựa chọn vào ComboBox khoa/lớp
            cboKhoa.Items.Add("Công nghệ thông tin");
            cboKhoa.Items.Add("Kinh tế - Quản trị");
            cboKhoa.Items.Add("Ngôn ngữ Anh");
            cboKhoa.Items.Add("Thiết kế đồ họa");

            // Xóa trắng nhãn hiển thị tuổi lúc mới mở chương trình (nếu có)
            label4.Text = "";
        }

        // =========================================================
        // TÍNH TUỔI TỰ ĐỘNG NGAY KHI ĐANG NHẬP NĂM SINH
        // =========================================================
        private void txtNamSinh_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem chữ người dùng đang gõ có phải là số không
            if (int.TryParse(txtNamSinh.Text.Trim(), out int namSinh))
            {
                int namHienTai = DateTime.Now.Year;

                // Chỉ tính và hiện tuổi nếu năm sinh hợp lý (từ 1900 đến năm hiện tại)
                if (namSinh >= 1900 && namSinh <= namHienTai)
                {
                    int tuoi = namHienTai - namSinh;
                    // Hiển thị kết quả ra lblTuoi
                    label4.Text = $"(Tuổi: {tuoi})";
                }
                else
                {
                    // Nếu nhập lố năm hoặc sai khoảng, tạm thời ẩn chữ đi
                    label4.Text = "";
                }
            }
            else
            {
                // Nếu người dùng xóa hết chữ hoặc nhập sai định dạng
                label4.Text = "";
            }
        }

        // =========================================================
        // Yêu cầu 2 & 5: Xử lý nút Hiển thị
        // =========================================================
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            // 1. Lấy dữ liệu dạng Text
            string hoTen = txtHoTen.Text.Trim();
            string namSinhText = txtNamSinh.Text.Trim();
            string email = txtEmail.Text.Trim();

            // 2. Lấy giới tính từ RadioButton
            string gioiTinh = "";
            if (rbNam.Checked)
            {
                gioiTinh = "Nam";
            }
            else if (rbNu.Checked)
            {
                gioiTinh = "Nữ";
            }

            // 3. Lấy khoa từ ComboBox
            string khoa = cboKhoa.SelectedItem != null ? cboKhoa.SelectedItem.ToString() : "";

            // 4. Kiểm tra dữ liệu rỗng
            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(namSinhText) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Họ tên, Năm sinh và Email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(gioiTinh))
            {
                MessageBox.Show("Vui lòng chọn Giới tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(khoa))
            {
                MessageBox.Show("Vui lòng chọn Khoa/Lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 5. Kiểm tra dữ liệu Năm sinh 
            if (!int.TryParse(namSinhText, out int namSinh))
            {
                MessageBox.Show("Năm sinh phải là một số nguyên (ví dụ: 2005)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamSinh.Focus();
                return;
            }

            int namHienTai = DateTime.Now.Year;
            if (namSinh < 1900 || namSinh > namHienTai)
            {
                MessageBox.Show($"Năm sinh phải nằm trong khoảng từ 1900 đến {namHienTai}!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamSinh.Focus();
                return;
            }

            // 6. Tính tuổi 
            int tuoi = namHienTai - namSinh;

            // 7. Gom chuỗi hiển thị 
            string thongTin = $"THÔNG TIN SINH VIÊN\n" +
                              $"Họ tên: {hoTen}\n" +
                              $"Tuổi: {tuoi}\n" +
                              $"Email: {email}\n" +
                              $"Giới tính: {gioiTinh}\n" +
                              $"Khoa/Lớp: {khoa}";

            // 8. Hiển thị hộp thoại kết quả
            MessageBox.Show(thongTin, "Thông tin sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // =========================================================
        // Yêu cầu 3: Xử lý nút Xóa (Làm sạch giao diện)
        // =========================================================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtNamSinh.Clear();
            txtEmail.Clear();
            rbNam.Checked = false;
            rbNu.Checked = false;
            cboKhoa.SelectedIndex = -1;

            // Xóa luôn chữ hiển thị ở nhãn Tuổi
            label4.Text = "";

            txtHoTen.Focus();
        }

        // =========================================================
        // Yêu cầu 4: Xử lý nút Thoát (Hỏi xác nhận)
        // =========================================================
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (ketQua == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // =========================================================
        // CÁC SỰ KIỆN TRỐNG (Giữ nguyên để không bị lỗi màn hình Design)
        // =========================================================
        private void radioButton1_CheckedChanged(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void txtHoTen_TextChanged(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }

        private void lbl_Click(object sender, EventArgs e)
        {

        }
    }
}