using System;
using System.Linq;
using System.Windows.Forms;
using Lab07.Models;

namespace Lab07.Forms
{
    public partial class FrmMain : Form
    {
        private Account acc;

        public FrmMain(Account account)
        {
            InitializeComponent();
            acc = account;
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            
            // Hiển thị thông tin sinh viên và tài khoản trên status bar
            lblStatusUser.Text = "Sinh viên: " + acc.FullName + " - MSSV: 50.01.104.175 | Vai trò: " + acc.Role;
            timerClock.Start();
        }

        private void OpenChildForm<T>() where T : Form, new()
        {
            Form f = this.MdiChildren.FirstOrDefault(x => x is T);
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                f = new T();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void mnuProduct_Click(object sender, EventArgs e) => OpenChildForm<FrmProduct>();
        private void mnuCustomer_Click(object sender, EventArgs e) => OpenChildForm<FrmCustomer>();
        private void mnuAbout_Click(object sender, EventArgs e) => OpenChildForm<FrmAbout>();

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                FrmLogin login = new FrmLogin();
                if (login.ShowDialog() == DialogResult.OK)
                {
                    acc = login.CurrentAccount;
                    lblStatusUser.Text = "Sinh viên: " + acc.FullName + " - MSSV: 50.01.104.175 | Vai trò: " + acc.Role;
                    this.Show();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void mnuExit_Click(object sender, EventArgs e) => this.Close();

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblStatusTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}