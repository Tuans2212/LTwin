using System.Drawing;
using System.Windows.Forms;

namespace Lab08
{
    // Panel tùy chỉnh kích hoạt DoubleBuffered để triệt tiêu hiện tượng nhấp nháy khi vẽ
    public class DrawSurface : Panel
    {
        public DrawSurface()
        {
            DoubleBuffered = true;
            BackColor = Color.White;
            Dock = DockStyle.Fill;
            // Cho phép nhận sự kiện BackgroundImageLayout để vẽ nền
            BackgroundImageLayout = ImageLayout.Zoom; 
        }
    }
}
