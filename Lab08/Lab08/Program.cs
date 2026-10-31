using System;
using System.Windows.Forms;

namespace Lab08
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmMainPaint());
        }
    }
}
