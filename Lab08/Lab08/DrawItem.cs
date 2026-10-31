using System.Collections.Generic;
using System.Drawing;

namespace Lab08
{
    // Lớp mô hình lưu trữ thông tin của từng đối tượng hình vẽ (phục vụ việc vẽ lại và Undo)
    public class DrawItem
    {
        public DrawMode Mode { get; set; }
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public Color ItemColor { get; set; }
        public float PenWidth { get; set; }
        public List<Point> StrokePoints { get; set; } = new List<Point>();
    }
}
