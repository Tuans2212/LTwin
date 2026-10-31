using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Windows.Forms;
using Lab09.Models;
using QRCoder; // Thư viện mở rộng tạo mã QR giả lập

namespace Lab09.Views
{
    public partial class FrmStudentCard : Form
    {
        private readonly Color primaryBlue = Color.FromArgb(12, 62, 153);
        private readonly Color primaryRed = Color.FromArgb(217, 38, 50);
        
        private Color cardBackgroundColor = Color.White; // Mở rộng: Màu nền thẻ

        public FrmStudentCard()
        {
            InitializeComponent();
            ApplyAesthetics();
            InitializeData();
            RegisterEvents();
        }

        private void ApplyAesthetics()
        {
            SetupFlatButton(btnChoosePhoto, primaryBlue, Color.White);
            SetupFlatButton(btnChooseColor, Color.DarkTurquoise, Color.White); // Nút màu nền
            SetupFlatButton(btnPreviewPrint, primaryBlue, Color.White);
            SetupFlatButton(btnPrint, primaryRed, Color.White);
            SetupFlatButton(btnSaveImage, Color.DarkOrange, Color.White); // Nút lưu ảnh
            SetupFlatButton(btnClear, Color.DarkGray, Color.White);

            btnChoosePhoto.Paint += RoundedButton_Paint;
            btnChooseColor.Paint += RoundedButton_Paint;
            btnPreviewPrint.Paint += RoundedButton_Paint;
            btnPrint.Paint += RoundedButton_Paint;
            btnSaveImage.Paint += RoundedButton_Paint;
            btnClear.Paint += RoundedButton_Paint;
        }

        private void SetupFlatButton(Button btn, Color backColor, Color foreColor)
        {
            btn.BackColor = backColor;
            btn.ForeColor = foreColor;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        }

        private void RoundedButton_Paint(object? sender, PaintEventArgs e)
        {
            if (sender is Button btn)
            {
                int radius = 18;
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();
                
                btn.Region = new Region(path);

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (SolidBrush brush = new SolidBrush(btn.BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }
                TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font, btn.ClientRectangle, btn.ForeColor, 
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }

        private void InitializeData()
        {
            cboClass.Items.AddRange(new object[] { "K49.CNTT.A", "K50.CNTT.A", "K51.CNTT.A" });
            cboFaculty.Items.AddRange(new object[] { "Công nghệ thông tin", "Ngôn ngữ Anh", "Toán - Tin học" });
            cboGender.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            
            if (cboClass.Items.Count > 0) cboClass.SelectedIndex = 0;
            if (cboFaculty.Items.Count > 0) cboFaculty.SelectedIndex = 0;
            if (cboGender.Items.Count > 0) cboGender.SelectedIndex = 0;
        }

        private void RegisterEvents()
        {
            btnChoosePhoto.Click += btnChoosePhoto_Click;
            btnChooseColor.Click += btnChooseColor_Click; // Mở rộng
            btnSaveImage.Click += btnSaveImage_Click;     // Mở rộng
            btnPreviewPrint.Click += btnPreviewPrint_Click;
            btnPrint.Click += btnPrint_Click;
            btnClear.Click += btnClear_Click;
            
            pnlCardPreview.Paint += pnlCardPreview_Paint;
            printDocument1.PrintPage += printDocument1_PrintPage;
            
            EventHandler inputChanged = (s, e) => pnlCardPreview.Invalidate();
            txtStudentId.TextChanged += inputChanged;
            txtFullName.TextChanged += inputChanged;
            txtCourse.TextChanged += inputChanged;
            cboClass.SelectedIndexChanged += inputChanged;
            cboFaculty.SelectedIndexChanged += inputChanged;
            cboGender.SelectedIndexChanged += inputChanged;
            dtpBirthDate.ValueChanged += inputChanged;
        }

        private StudentCardInfo GetStudentInfo()
        {
            return new StudentCardInfo
            {
                StudentId = txtStudentId.Text.Trim(),
                FullName = txtFullName.Text.Trim(),
                ClassName = cboClass.Text,
                Faculty = cboFaculty.Text,
                Course = txtCourse.Text.Trim(),
                BirthDate = dtpBirthDate.Value,
                Gender = cboGender.Text,
                Photo = picAvatar.Image,
                BackgroundColor = cardBackgroundColor
            };
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtStudentId.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentId.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return false;
            }
            if (picAvatar.Image == null)
            {
                MessageBox.Show("Vui lòng chọn ảnh sinh viên.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnChoosePhoto_Click(object? sender, EventArgs e)
        {
            using OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Chọn ảnh sinh viên";
            dlg.Filter = "Image files|*.jpg;*.jpeg;*.png;*.bmp";
            
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using Image temp = Image.FromFile(dlg.FileName);
                    Image copy = new Bitmap(temp);
                    picAvatar.Image?.Dispose();
                    picAvatar.Image = copy;
                    pnlCardPreview.Invalidate();
                }
                catch
                {
                    MessageBox.Show("File được chọn không phải ảnh hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- MỞ RỘNG: CHỌN MÀU NỀN THẺ ---
        private void btnChooseColor_Click(object? sender, EventArgs e)
        {
            colorDialog1.Color = cardBackgroundColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                cardBackgroundColor = colorDialog1.Color;
                pnlCardPreview.Invalidate();
            }
        }

        // --- MỞ RỘNG: LƯU PREVIEW THÀNH ẢNH PNG ---
        private void btnSaveImage_Click(object? sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            using SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG Image|*.png";
            sfd.Title = "Lưu thẻ sinh viên thành ảnh";
            sfd.FileName = $"TheSV_{txtStudentId.Text}.png";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                int cardWidth = 480;
                int cardHeight = 290;
                
                // Khởi tạo Bitmap trống theo kích thước thẻ
                using Bitmap bmp = new Bitmap(cardWidth, cardHeight);
                using Graphics g = Graphics.FromImage(bmp);
                
                // Vẽ thẻ lên Bitmap bắt đầu từ tọa độ 0,0
                Rectangle cardRect = new Rectangle(0, 0, cardWidth, cardHeight);
                DrawStudentCard(g, cardRect, GetStudentInfo());
                
                try
                {
                    bmp.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    MessageBox.Show("Đã lưu thẻ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi lưu ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object? sender, EventArgs e)
        {
            txtStudentId.Clear();
            txtFullName.Clear();
            txtCourse.Clear();
            if (cboClass.Items.Count > 0) cboClass.SelectedIndex = 0;
            if (cboFaculty.Items.Count > 0) cboFaculty.SelectedIndex = 0;
            if (cboGender.Items.Count > 0) cboGender.SelectedIndex = 0;
            dtpBirthDate.Value = DateTime.Today;
            picAvatar.Image?.Dispose();
            picAvatar.Image = null;
            cardBackgroundColor = Color.White; // Reset màu nền
            pnlCardPreview.Invalidate();
            txtStudentId.Focus();
        }

        private void pnlCardPreview_Paint(object? sender, PaintEventArgs e)
        {
            int cardWidth = 480;
            int cardHeight = 290;
            int x = (pnlCardPreview.Width - cardWidth) / 2;
            int y = (pnlCardPreview.Height - cardHeight) / 2;
            
            if(x < 10) x = 10;
            if(y < 10) y = 10;

            Rectangle card = new Rectangle(x, y, cardWidth, cardHeight);
            DrawStudentCard(e.Graphics, card, GetStudentInfo());
        }

        private void btnPreviewPrint_Click(object? sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Width = 900;
            printPreviewDialog1.Height = 700;
            printPreviewDialog1.ShowIcon = false;
            printPreviewDialog1.ShowDialog();
        }

        private void btnPrint_Click(object? sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            if(e.Graphics == null) return;
            StudentCardInfo info = GetStudentInfo();
            Rectangle card = new Rectangle(e.MarginBounds.Left, e.MarginBounds.Top, 480, 290);
            DrawStudentCard(e.Graphics, card, info);
            e.HasMorePages = false;
        }

        private void DrawStudentCard(Graphics g, Rectangle card, StudentCardInfo s)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            
            using Font uniFont = new Font("Segoe UI", 11, FontStyle.Bold);
            using Font sloganFont = new Font("Segoe UI", 9, FontStyle.Italic);
            using Font titleFont = new Font("Segoe UI", 15, FontStyle.Bold);
            using Font nameFont = new Font("Segoe UI", 12, FontStyle.Bold);
            using Font labelFont = new Font("Segoe UI", 10, FontStyle.Bold);
            using Font normalFont = new Font("Segoe UI", 10, FontStyle.Regular);
            
            using Pen borderPen = new Pen(primaryBlue, 1);
            using SolidBrush blueBrush = new SolidBrush(primaryBlue);
            using SolidBrush redBrush = new SolidBrush(primaryRed);
            using SolidBrush bgBrush = new SolidBrush(s.BackgroundColor); // Áp dụng màu nền do người dùng chọn
            
            g.FillRectangle(bgBrush, card);
            g.DrawRectangle(borderPen, card);

            int stripeWidth = 14;
            Rectangle leftStripe = new Rectangle(card.Left, card.Top, stripeWidth, card.Height);
            g.FillRectangle(blueBrush, leftStripe);
            g.FillRectangle(redBrush, new Rectangle(card.Left, card.Top + 130, stripeWidth, 40));

            int contentX = card.Left + stripeWidth + 15;
            int yPos = card.Top + 15;

            DrawCenteredString(g, "TRƯỜNG ĐẠI HỌC SƯ PHẠM", uniFont, blueBrush, contentX, card.Right, yPos);
            yPos += 20;
            DrawCenteredString(g, "THÀNH PHỐ HỒ CHÍ MINH", uniFont, blueBrush, contentX, card.Right, yPos);
            yPos += 18;
            DrawCenteredString(g, "Chất lượng - Sáng tạo - Nhân văn", sloganFont, blueBrush, contentX, card.Right, yPos);
            
            yPos += 25;
            DrawCenteredString(g, "THẺ SINH VIÊN", titleFont, blueBrush, contentX, card.Right, yPos);

            yPos += 30;
            int photoWidth = 90;
            int photoHeight = 120;
            Rectangle photoBox = new Rectangle(contentX, yPos, photoWidth, photoHeight);
            g.FillRectangle(Brushes.White, photoBox);
            g.DrawRectangle(Pens.LightGray, photoBox);
            
            if (s.Photo != null)
                DrawImageZoom(g, s.Photo, photoBox);
            else
                g.DrawString("Ảnh", normalFont, Brushes.Gray, photoBox.Left + 30, photoBox.Top + 50);

            int infoX = photoBox.Right + 15;
            int infoY = yPos + 5;
            
            g.DrawString(s.FullName.ToUpper(), nameFont, redBrush, infoX, infoY);
            
            infoY += 30;
            DrawInfoLine(g, "Ngành:", s.Faculty, labelFont, normalFont, infoX, infoY);
            infoY += 25;
            DrawInfoLine(g, "Niên khóa:", s.Course, labelFont, normalFont, infoX, infoY);
            infoY += 25;
            DrawInfoLine(g, "MSSV:", s.StudentId, labelFont, normalFont, infoX, infoY);
            infoY += 25;
            DrawInfoLine(g, "Lớp:", s.ClassName, labelFont, normalFont, infoX, infoY);

            // --- MỞ RỘNG: VẼ MÃ QR GÓC PHẢI DƯỚI ---
            if (!string.IsNullOrEmpty(s.StudentId))
            {
                try
                {
                    QRCodeGenerator qrGenerator = new QRCodeGenerator();
                    QRCodeData qrCodeData = qrGenerator.CreateQrCode(s.StudentId, QRCodeGenerator.ECCLevel.Q);
                    QRCode qrCode = new QRCode(qrCodeData);
                    Bitmap qrCodeImage = qrCode.GetGraphic(2); // Kích thước QR (pixels per module)

                    int qrSize = 50;
                    Rectangle qrRect = new Rectangle(card.Right - qrSize - 15, card.Bottom - qrSize - 15, qrSize, qrSize);
                    g.DrawImage(qrCodeImage, qrRect);
                    
                    qrCodeImage.Dispose();
                }
                catch
                {
                    // Nếu lỗi QR (ví dụ chưa cài Nuget), vẽ ô vuông giả lập theo đúng Gợi ý mở rộng của đề
                    Rectangle dummyQR = new Rectangle(card.Right - 55, card.Bottom - 55, 40, 40);
                    g.DrawRectangle(Pens.Black, dummyQR);
                    g.DrawString("QR", normalFont, Brushes.Black, dummyQR.Left + 10, dummyQR.Top + 10);
                }
            }
        }

        private void DrawCenteredString(Graphics g, string text, Font font, Brush brush, int leftX, int rightX, int y)
        {
            SizeF size = g.MeasureString(text, font);
            float x = leftX + ((rightX - leftX) - size.Width) / 2;
            g.DrawString(text, font, brush, x, y);
        }

        private void DrawInfoLine(Graphics g, string label, string value, Font labelFont, Font normalFont, int x, int y)
        {
            g.DrawString(label, labelFont, blueBrush_cached, x, y);
            g.DrawString(value, normalFont, Brushes.Black, x + 85, y);
        }
        private SolidBrush blueBrush_cached = new SolidBrush(Color.FromArgb(12, 62, 153));

        private void DrawImageZoom(Graphics g, Image image, Rectangle box)
        {
            float ratio = Math.Min((float)box.Width / image.Width, (float)box.Height / image.Height);
            int width = (int)(image.Width * ratio);
            int height = (int)(image.Height * ratio);
            int x = box.Left + (box.Width - width) / 2;
            int y = box.Top + (box.Height - height) / 2;
            g.DrawImage(image, new Rectangle(x, y, width, height));
        }
    }
}
