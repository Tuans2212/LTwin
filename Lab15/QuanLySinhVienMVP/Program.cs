using System;
using System.Windows.Forms;
using QuanLySinhVienMVP.Views;

namespace QuanLySinhVienMVP
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmStudent());
        }
    }
}
