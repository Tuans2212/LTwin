using System;
using System.Windows.Forms;
using Lab09.Views;

namespace Lab09
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmStudentCard());
        }
    }
}
