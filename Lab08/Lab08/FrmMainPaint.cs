using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Lab08
{
    public partial class FrmMainPaint : Form
    {
        private readonly DrawSurface canvas = new DrawSurface();
        private readonly ComboBox cboMode = new ComboBox();
        private readonly NumericUpDown nudWidth = new NumericUpDown();
        private readonly Button btnColor = new Button();
        private readonly Button btnUndo = new Button();
        private readonly Button btnClear = new Button();
        private readonly Button btnSave = new Button(); // Nút lưu ảnh (Nâng cao)
        private readonly Button btnLoadImage = new Button(); // Nút tải ảnh nền (Nâng cao)
        private readonly Label lblStatus = new Label();
        
        private readonly List<DrawItem> drawingHistory = new List<DrawItem>();
        private DrawItem activeItem;
        private bool isMouseDown = false;
        private Color selectedColor = Color.Black;

        public FrmMainPaint()
        {
            Text = "COMP1019 - Lab 08: Simple Paint";
            Width = 1100; // Tăng chiều rộng để chứa thêm nút
            Height = 700;
            StartPosition = FormStartPosition.CenterScreen;

            InitializeComponentCustom();
            RegisterEventHandlers();
        }

        private void InitializeComponentCustom()
        {
            Panel toolbarPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 52,
                BackColor = Color.FromArgb(245, 247, 250)
            };

            Label lblModeTitle = new Label { Text = "Chế độ:", Left = 15, Top = 18, AutoSize = true };
            cboMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMode.Items.AddRange(new object[] { "Pen", "Line", "Rectangle", "Ellipse" });
            cboMode.SelectedIndex = 0;
            cboMode.Width = 90;
            cboMode.Left = 65;
            cboMode.Top = 14;

            Label lblWidthTitle = new Label { Text = "Độ dày:", Left = 165, Top = 18, AutoSize = true };
            nudWidth.Minimum = 1;
            nudWidth.Maximum = 20;
            nudWidth.Value = 3;
            nudWidth.Width = 50;
            nudWidth.Left = 215;
            nudWidth.Top = 14;

            btnColor.Text = "Màu vẽ";
            btnColor.Left = 275;
            btnColor.Top = 12;
            btnColor.Width = 70;
            btnColor.Height = 28;
            btnColor.BackColor = selectedColor;
            btnColor.ForeColor = Color.White;
            btnColor.FlatStyle = FlatStyle.Flat;

            btnUndo.Text = "Undo (Ctrl+Z)";
            btnUndo.Left = 355;
            btnUndo.Top = 12;
            btnUndo.Width = 90;
            btnUndo.Height = 28;
            btnUndo.FlatStyle = FlatStyle.Flat;

            btnClear.Text = "Xóa tất cả";
            btnClear.Left = 455;
            btnClear.Top = 12;
            btnClear.Width = 80;
            btnClear.Height = 28;
            btnClear.FlatStyle = FlatStyle.Flat;

            // [NÂNG CAO] Nút Lưu ảnh
            btnSave.Text = "Lưu (PNG)";
            btnSave.Left = 545;
            btnSave.Top = 12;
            btnSave.Width = 80;
            btnSave.Height = 28;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.BackColor = Color.FromArgb(220, 255, 220); // Màu xanh nhạt dễ phân biệt

            // [NÂNG CAO] Nút Mở ảnh nền
            btnLoadImage.Text = "Mở ảnh nền";
            btnLoadImage.Left = 635;
            btnLoadImage.Top = 12;
            btnLoadImage.Width = 90;
            btnLoadImage.Height = 28;
            btnLoadImage.FlatStyle = FlatStyle.Flat;
            btnLoadImage.BackColor = Color.FromArgb(255, 240, 200); // Màu vàng nhạt

            toolbarPanel.Controls.Add(lblModeTitle);
            toolbarPanel.Controls.Add(cboMode);
            toolbarPanel.Controls.Add(lblWidthTitle);
            toolbarPanel.Controls.Add(nudWidth);
            toolbarPanel.Controls.Add(btnColor);
            toolbarPanel.Controls.Add(btnUndo);
            toolbarPanel.Controls.Add(btnClear);
            toolbarPanel.Controls.Add(btnSave);
            toolbarPanel.Controls.Add(btnLoadImage);

            lblStatus.Dock = DockStyle.Bottom;
            lblStatus.Height = 25;
            lblStatus.Text = "Sẵn sàng";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            lblStatus.BackColor = Color.FromArgb(240, 240, 240);

            Controls.Add(canvas);
            Controls.Add(lblStatus);
            Controls.Add(toolbarPanel);
        }

        private void RegisterEventHandlers()
        {
            canvas.Paint += Canvas_Paint;
            canvas.MouseDown += Canvas_MouseDown;
            canvas.MouseMove += Canvas_MouseMove;
            canvas.MouseUp += Canvas_MouseUp;

            btnColor.Click += BtnColor_Click;
            btnUndo.Click += BtnUndo_Click;
            btnClear.Click += BtnClear_Click;
            
            // Đăng ký sự kiện cho nút nâng cao
            btnSave.Click += BtnSave_Click;
            btnLoadImage.Click += BtnLoadImage_Click;
            
            // Bật nhận phím tắt trên Form
            KeyPreview = true;
            KeyDown += FrmMainPaint_KeyDown;
        }

        private DrawMode GetCurrentDrawMode()
        {
            string modeStr = cboMode.SelectedItem.ToString();
            return (DrawMode)Enum.Parse(typeof(DrawMode), modeStr);
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                dlg.Color = selectedColor;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    selectedColor = dlg.Color;
                    btnColor.BackColor = selectedColor;
                }
            }
        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            PerformUndo();
        }

        private void PerformUndo()
        {
            if (drawingHistory.Count == 0) return;
            drawingHistory.RemoveAt(drawingHistory.Count - 1);
            canvas.Invalidate();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (drawingHistory.Count == 0 && canvas.BackgroundImage == null) return;
            
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn xóa toàn bộ vùng vẽ (bao gồm cả ảnh nền)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                drawingHistory.Clear();
                canvas.BackgroundImage = null; // Xóa luôn ảnh nền nếu có
                canvas.Invalidate();
            }
        }

        // [NÂNG CAO] Lưu vùng vẽ thành file PNG
        private void BtnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                sfd.Title = "Lưu ảnh bản vẽ";
                sfd.FileName = "MyDrawing.png";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // Tạo một Bitmap với kích thước bằng canvas
                    using (Bitmap bmp = new Bitmap(canvas.Width, canvas.Height))
                    {
                        // Rút trích Graphics từ Bitmap
                        using (Graphics g = Graphics.FromImage(bmp))
                        {
                            // Đổ màu nền trắng nếu không có ảnh nền
                            g.Clear(canvas.BackColor);

                            // Nếu có ảnh nền, vẽ ảnh nền lên Bitmap trước
                            if (canvas.BackgroundImage != null)
                            {
                                // Vẽ ảnh nền (Mô phỏng ImageLayout.Zoom)
                                // Cách đơn giản nhất là dùng DrawImage với kích thước canvas, 
                                // ở mức độ lab này ta vẽ phủ đầy, hoặc canh giữa.
                                // Dùng Stretch cho đơn giản hoặc vẽ nguyên bản:
                                g.DrawImage(canvas.BackgroundImage, new Rectangle(0, 0, canvas.Width, canvas.Height));
                            }

                            // Bật khử răng cưa
                            g.SmoothingMode = SmoothingMode.AntiAlias;

                            // Vẽ lại toàn bộ lịch sử nét vẽ lên Graphics của Bitmap
                            foreach (var item in drawingHistory)
                            {
                                RenderItem(g, item);
                            }
                        }

                        // Lưu Bitmap ra file tùy định dạng
                        ImageFormat format = ImageFormat.Png;
                        if (sfd.FileName.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase))
                            format = ImageFormat.Jpeg;
                        else if (sfd.FileName.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase))
                            format = ImageFormat.Bmp;

                        bmp.Save(sfd.FileName, format);
                        MessageBox.Show("Đã lưu ảnh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        // [NÂNG CAO] Tải ảnh nền
        private void BtnLoadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.Title = "Chọn ảnh nền";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Gán ảnh nền cho canvas. Chế độ Zoom đã được set trong DrawSurface.cs
                        canvas.BackgroundImage = Image.FromFile(ofd.FileName);
                        canvas.Invalidate(); // Refresh lại canvas
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi tải ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void FrmMainPaint_KeyDown(object sender, KeyEventArgs e)
        {
            // [NÂNG CAO] Xử lý phím tắt Ctrl+Z để Undo thao tác vẽ
            if (e.Control && e.KeyCode == Keys.Z)
            {
                PerformUndo();
                e.Handled = true;
            }
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            isMouseDown = true;
            
            // Khởi tạo đối tượng hình vẽ tạm khi người dùng bắt đầu nhấn chuột trái
            activeItem = new DrawItem
            {
                Mode = GetCurrentDrawMode(),
                StartPoint = e.Location,
                EndPoint = e.Location,
                ItemColor = selectedColor,
                PenWidth = (float)nudWidth.Value
            };

            if (activeItem.Mode == DrawMode.Pen)
            {
                activeItem.StrokePoints.Add(e.Location);
            }
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            lblStatus.Text = $"Tọa độ: X = {e.X}, Y = {e.Y} | Số đối tượng: {drawingHistory.Count}";

            if (!isMouseDown || activeItem == null) return;
            
            // Cập nhật điểm kết thúc và vẽ thời gian thực khi đang kéo chuột
            activeItem.EndPoint = e.Location;
            if (activeItem.Mode == DrawMode.Pen)
            {
                activeItem.StrokePoints.Add(e.Location);
            }
            canvas.Invalidate();
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isMouseDown || activeItem == null) return;
            
            // Hoàn tất nét vẽ và lưu vào danh sách lịch sử khi thả chuột
            activeItem.EndPoint = e.Location;
            drawingHistory.Add(activeItem);
            activeItem = null;
            isMouseDown = false;
            canvas.Invalidate();
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            // Bật khử răng cưa để đường nét mịn màng hơn
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Vẽ lại toàn bộ danh sách hình đã lưu (giúp không bị mất khi resize Form hoặc refresh)
            foreach (var item in drawingHistory)
            {
                RenderItem(e.Graphics, item);
            }

            // Hiển thị nét vẽ tạm thời đang thao tác
            if (activeItem != null)
            {
                RenderItem(e.Graphics, activeItem);
            }
        }

        private void RenderItem(Graphics g, DrawItem item)
        {
            // Sử dụng using để tự động giải phóng đối tượng Pen sau khi vẽ xong
            using (Pen pen = new Pen(item.ItemColor, item.PenWidth))
            {
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                pen.LineJoin = LineJoin.Round;

                Rectangle rect = CalculateNormalizedRectangle(item.StartPoint, item.EndPoint);

                switch (item.Mode)
                {
                    case DrawMode.Pen:
                        DrawFreehandStroke(g, pen, item.StrokePoints);
                        break;
                    case DrawMode.Line:
                        g.DrawLine(pen, item.StartPoint, item.EndPoint);
                        break;
                    case DrawMode.Rectangle:
                        g.DrawRectangle(pen, rect);
                        break;
                    case DrawMode.Ellipse:
                        g.DrawEllipse(pen, rect);
                        break;
                }
            }
        }

        private void DrawFreehandStroke(Graphics g, Pen pen, List<Point> points)
        {
            if (points.Count < 2) return;
            for (int i = 1; i < points.Count; i++)
            {
                g.DrawLine(pen, points[i - 1], points[i]);
            }
        }

        private Rectangle CalculateNormalizedRectangle(Point p1, Point p2)
        {
            // Thuật toán chuẩn hóa tọa độ hình chữ nhật/ellipse khi kéo chuột theo bất kỳ hướng nào
            int x = Math.Min(p1.X, p2.X);
            int y = Math.Min(p1.Y, p2.Y);
            int w = Math.Abs(p1.X - p2.X);
            int h = Math.Abs(p1.Y - p2.Y);
            return new Rectangle(x, y, w, h);
        }
    }
}
