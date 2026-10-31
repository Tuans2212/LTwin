using System;
using System.Windows.Forms;
using Lab07.Forms;

namespace Lab07
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            // Khởi động form đăng nhập trước
            FrmLogin loginFrm = new FrmLogin();
            if (loginFrm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FrmMain(loginFrm.CurrentAccount));
            }
        }
    }
}