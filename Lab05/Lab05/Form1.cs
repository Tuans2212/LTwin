using System;
using System.Windows.Forms;

namespace Lab05
{
    public partial class Form1 : Form
    {
        // Biến toàn cục để lưu học phí của môn đang được chọn
        private decimal currentFee = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // 1. Chạy khi Form vừa bật lên
        private void Form1_Load(object sender, EventArgs e)
        {
            dtpDateOfBirth.Value = new DateTime(2026, 9, 29);

            // Thêm danh sách các khóa học CNTT đa dạng hơn
            cboCourse.Items.Clear();
            cboCourse.Items.Add("Lập trình Web");
            cboCourse.Items.Add("Python Data");
            cboCourse.Items.Add("Lập trình C# WinForms");
            cboCourse.Items.Add("Quản trị mạng Cisco");
            cboCourse.Items.Add("Kiểm thử phần mềm (Tester)");

            nudDuration.Minimum = 1;
            nudDuration.Value = 1;
            rdoOnline.Checked = true;

            // Giới hạn ô nhập Họ Tên tối đa 50 ký tự
            txtFullName.MaxLength = 50;
            lblCharCount.Text = "0/50";

            // Tự động chọn môn đầu tiên để hiển thị học phí mặc định
            cboCourse.SelectedIndex = 0;
        }

        // 2. Sự kiện thay đổi số lượng ký tự (0/50) khi gõ Họ tên
        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            lblCharCount.Text = $"{txtFullName.Text.Length}/50";
        }

        // 3. Sự kiện đổi học phí khi chọn môn khác trong ComboBox
        private void cboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCourse = cboCourse.Text;

            // Gán giá tiền tùy theo môn học
            switch (selectedCourse)
            {
                case "Lập trình Web": currentFee = 500000; break;
                case "Python Data": currentFee = 650000; break;
                case "Lập trình C# WinForms": currentFee = 550000; break;
                case "Quản trị mạng Cisco": currentFee = 700000; break;
                case "Kiểm thử phần mềm (Tester)": currentFee = 450000; break;
                default: currentFee = 0; break;
            }

            // Cập nhật chữ Học Phí ra ngoài màn hình
            lblFee.Text = $"{currentFee:N0} VNĐ";

            // Lập tức tính lại Tổng tiền
            UpdateTotal();
        }

        // 4. Sự kiện tự động tính Tổng tiền khi tăng/giảm Số tháng
        private void nudDuration_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        // Hàm dùng chung để tính Toán tổng tiền
        private void UpdateTotal()
        {
            decimal total = currentFee * nudDuration.Value;
            lblTotal.Text = $"{total:N0} VNĐ";
        }

        // 5. Nút Đăng ký: Hiển thị BẢNG THÔNG TIN CUỐI CÙNG
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();

            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Vui lòng nhập họ và tên học viên!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal total = currentFee * nudDuration.Value;

            // Tạo chuỗi hiển thị Bảng thông tin giống như hóa đơn (Receipt)
            string message = "===== BẢNG THÔNG TIN ĐĂNG KÝ =====\n\n" +
                             $"🎓 Học viên: {fullName.ToUpper()}\n" +
                             $"📞 Số ĐT: {txtPhoneNumber.Text}\n" +
                             $"🎂 Ngày sinh: {dtpDateOfBirth.Value.ToString("dd/MM/yyyy")}\n" +
                             $"📧 Nhận email: {(chkReceiveEmail.Checked ? "Có đăng ký" : "Không")}\n\n" +
                             "--- CHI TIẾT KHÓA HỌC ---\n" +
                             $"📚 Khóa học: {cboCourse.Text}\n" +
                             $"💻 Hình thức: {(rdoOnline.Checked ? "Trực tuyến" : "Trực tiếp")}\n" +
                             $"⏱️ Thời gian học: {nudDuration.Value} tháng\n" +
                             $"💰 Học phí gốc: {currentFee:N0} VNĐ / tháng\n\n" +
                             $"💵 TỔNG CỘNG: {total:N0} VNĐ\n\n" +
                             "===================================";

            MessageBox.Show(message, "Xác nhận đăng ký khóa học", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 6. Nút Làm mới
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtPhoneNumber.Clear();
            dtpDateOfBirth.Value = DateTime.Now;
            chkReceiveEmail.Checked = false;
            cboCourse.SelectedIndex = 0;
            rdoOnline.Checked = true;
            nudDuration.Value = 1;
        }

        // 7. Nút Thoát
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}