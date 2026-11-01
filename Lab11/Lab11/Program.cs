using System;
using System.Windows.Forms;

namespace Lab11
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmLop());
        }
    }
}