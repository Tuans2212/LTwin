using System;
using System.Windows.Forms;
using Lab07.Models;

namespace Lab07.Forms
{
    public partial class FrmLogin : Form
    {
        public Account CurrentAccount { get; private set; }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Kiểm tra rỗng thông tin đăng nhập
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tài khoản mẫu phân quyền cho sinh viên làm bài
            if (txtUser.Text.Trim() == "admin" && txtPass.Text == "123")
            {
                CurrentAccount = new Account { Username = "admin", FullName = "Nguyễn Văn Tuấn", Role = "Quản trị viên" };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (txtUser.Text.Trim() == "user" && txtPass.Text == "123")
            {
                CurrentAccount = new Account { Username = "user", FullName = "Nguyễn Văn Tuấn", Role = "Nhân viên" };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Clear();
                txtUser.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Thoát ứng dụng khi bấm hủy
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}