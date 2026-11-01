using System;
using System.Drawing;
using System.Windows.Forms;

namespace EduManager.GUI
{
    partial class FrmMonHoc
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlHeader;
        private Panel pnlVachCam;
        private Label lblTieuDe;
        private Label lblPhuDe;
        private Label lblBadgeTong;
        private Label lblBadgeMo;
        private Label lblBadgeNgung;

        private Panel pnlNhapLieu;
        private Label lblHeaderNhap;
        private Label lblMaMon;
        private TextBox txtMaMonHoc;
        private Label lblTenMon;
        private TextBox txtTenMonHoc;
        private Label lblSoTinChi;
        private NumericUpDown nudSoTinChi;
        private Label lblTrangThai;
        private CheckBox chkTrangThai;

        private Panel pnlChucNang;
        private Label lblHeaderNut;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;

        private Panel pnlTimKiem;
        private Label lblTimKiem;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Label lblCheDo;

        private Panel pnlDanhSach;
        private Label lblHeaderBang;
        private DataGridView dgvMonHoc;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new Panel();
            this.pnlVachCam = new Panel();
            this.lblTieuDe = new Label();
            this.lblPhuDe = new Label();
            this.lblBadgeTong = new Label();
            this.lblBadgeMo = new Label();
            this.lblBadgeNgung = new Label();

            this.pnlNhapLieu = new Panel();
            this.lblHeaderNhap = new Label();
            this.lblMaMon = new Label();
            this.txtMaMonHoc = new TextBox();
            this.lblTenMon = new Label();
            this.txtTenMonHoc = new TextBox();
            this.lblSoTinChi = new Label();
            this.nudSoTinChi = new NumericUpDown();
            this.lblTrangThai = new Label();
            this.chkTrangThai = new CheckBox();

            this.pnlChucNang = new Panel();
            this.lblHeaderNut = new Label();
            this.btnThem = new Button();
            this.btnSua = new Button();
            this.btnXoa = new Button();
            this.btnLamMoi = new Button();

            this.pnlTimKiem = new Panel();
            this.lblTimKiem = new Label();
            this.txtTimKiem = new TextBox();
            this.btnTimKiem = new Button();
            this.lblCheDo = new Label();

            this.pnlDanhSach = new Panel();
            this.lblHeaderBang = new Label();
            this.dgvMonHoc = new DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.nudSoTinChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlNhapLieu.SuspendLayout();
            this.pnlChucNang.SuspendLayout();
            this.pnlTimKiem.SuspendLayout();
            this.pnlDanhSach.SuspendLayout();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = Color.FromArgb(17, 75, 70);
            this.pnlHeader.Dock = DockStyle.Top;
            this.pnlHeader.Location = new Point(0, 0);
            this.pnlHeader.Size = new Size(1006, 74);
            this.pnlHeader.Controls.Add(this.lblBadgeNgung);
            this.pnlHeader.Controls.Add(this.lblBadgeMo);
            this.pnlHeader.Controls.Add(this.lblBadgeTong);
            this.pnlHeader.Controls.Add(this.lblPhuDe);
            this.pnlHeader.Controls.Add(this.lblTieuDe);
            this.pnlHeader.Controls.Add(this.pnlVachCam);

            // pnlVachCam
            this.pnlVachCam.BackColor = Color.FromArgb(245, 158, 11);
            this.pnlVachCam.Dock = DockStyle.Bottom;
            this.pnlVachCam.Height = 4;

            // lblTieuDe
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new Font("Segoe UI", 14.5F, FontStyle.Bold);
            this.lblTieuDe.ForeColor = Color.White;
            this.lblTieuDe.Location = new Point(20, 11);
            this.lblTieuDe.Text = "QUẢN LÝ DANH MỤC MÔN HỌC - EDUMANAGER";

            // lblPhuDe
            this.lblPhuDe.AutoSize = true;
            this.lblPhuDe.Font = new Font("Segoe UI", 9.5F, FontStyle.Italic);
            this.lblPhuDe.ForeColor = Color.FromArgb(167, 243, 208);
            this.lblPhuDe.Location = new Point(22, 41);
            this.lblPhuDe.UseMnemonic = false;
            this.lblPhuDe.Text = "Học phần COMP1019 - Lập trình trên Windows (Mô hình 3 lớp & EF Core)";

            // lblBadgeTong
            this.lblBadgeTong.BackColor = Color.FromArgb(13, 148, 136);
            this.lblBadgeTong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblBadgeTong.ForeColor = Color.White;
            this.lblBadgeTong.Location = new Point(636, 20);
            this.lblBadgeTong.Size = new Size(112, 32);
            this.lblBadgeTong.Text = "Tổng: 0 môn";
            this.lblBadgeTong.TextAlign = ContentAlignment.MiddleCenter;
            this.lblBadgeTong.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // lblBadgeMo
            this.lblBadgeMo.BackColor = Color.FromArgb(16, 185, 129);
            this.lblBadgeMo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblBadgeMo.ForeColor = Color.White;
            this.lblBadgeMo.Location = new Point(756, 20);
            this.lblBadgeMo.Size = new Size(112, 32);
            this.lblBadgeMo.Text = "Đang mở: 0";
            this.lblBadgeMo.TextAlign = ContentAlignment.MiddleCenter;
            this.lblBadgeMo.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // lblBadgeNgung
            this.lblBadgeNgung.BackColor = Color.FromArgb(217, 119, 6);
            this.lblBadgeNgung.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblBadgeNgung.ForeColor = Color.White;
            this.lblBadgeNgung.Location = new Point(876, 20);
            this.lblBadgeNgung.Size = new Size(112, 32);
            this.lblBadgeNgung.Text = "Tạm ngưng: 0";
            this.lblBadgeNgung.TextAlign = ContentAlignment.MiddleCenter;
            this.lblBadgeNgung.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // pnlNhapLieu
            this.pnlNhapLieu.BackColor = Color.White;
            this.pnlNhapLieu.Location = new Point(18, 88);
            this.pnlNhapLieu.Size = new Size(622, 192);
            this.pnlNhapLieu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.pnlNhapLieu.Controls.Add(this.lblHeaderNhap);
            this.pnlNhapLieu.Controls.Add(this.lblMaMon);
            this.pnlNhapLieu.Controls.Add(this.txtMaMonHoc);
            this.pnlNhapLieu.Controls.Add(this.lblTenMon);
            this.pnlNhapLieu.Controls.Add(this.txtTenMonHoc);
            this.pnlNhapLieu.Controls.Add(this.lblSoTinChi);
            this.pnlNhapLieu.Controls.Add(this.nudSoTinChi);
            this.pnlNhapLieu.Controls.Add(this.lblTrangThai);
            this.pnlNhapLieu.Controls.Add(this.chkTrangThai);

            // lblHeaderNhap
            this.lblHeaderNhap.BackColor = Color.FromArgb(209, 250, 229);
            this.lblHeaderNhap.Dock = DockStyle.Top;
            this.lblHeaderNhap.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            this.lblHeaderNhap.ForeColor = Color.FromArgb(6, 95, 70);
            this.lblHeaderNhap.Height = 38;
            this.lblHeaderNhap.Text = "   THÔNG TIN CHI TIẾT MÔN HỌC";
            this.lblHeaderNhap.TextAlign = ContentAlignment.MiddleLeft;

            // lblMaMon & txtMaMonHoc
            this.lblMaMon.AutoSize = true;
            this.lblMaMon.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.lblMaMon.ForeColor = Color.FromArgb(30, 41, 59);
            this.lblMaMon.Location = new Point(20, 52);
            this.lblMaMon.Text = "Mã môn học (*):";

            this.txtMaMonHoc.Font = new Font("Segoe UI", 10.5F);
            this.txtMaMonHoc.Location = new Point(20, 75);
            this.txtMaMonHoc.MaxLength = 10;
            this.txtMaMonHoc.Size = new Size(265, 27);
            this.txtMaMonHoc.PlaceholderText = "VD: COMP1019";

            // lblTenMon & txtTenMonHoc
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.lblTenMon.ForeColor = Color.FromArgb(30, 41, 59);
            this.lblTenMon.Location = new Point(310, 52);
            this.lblTenMon.Text = "Tên môn học (*):";

            this.txtTenMonHoc.Font = new Font("Segoe UI", 10.5F);
            this.txtTenMonHoc.Location = new Point(310, 75);
            this.txtTenMonHoc.MaxLength = 100;
            this.txtTenMonHoc.Size = new Size(290, 27);
            this.txtTenMonHoc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.txtTenMonHoc.PlaceholderText = "VD: Lập trình trên Windows";

            // lblSoTinChi & nudSoTinChi
            this.lblSoTinChi.AutoSize = true;
            this.lblSoTinChi.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.lblSoTinChi.ForeColor = Color.FromArgb(30, 41, 59);
            this.lblSoTinChi.Location = new Point(20, 118);
            this.lblSoTinChi.Text = "Số tín chỉ (1 - 6):";

            this.nudSoTinChi.Font = new Font("Segoe UI", 10.5F);
            this.nudSoTinChi.Location = new Point(20, 141);
            this.nudSoTinChi.Minimum = 1;
            this.nudSoTinChi.Maximum = 6;
            this.nudSoTinChi.Value = 3;
            this.nudSoTinChi.Size = new Size(145, 27);
            this.nudSoTinChi.TextAlign = HorizontalAlignment.Center;

            // lblTrangThai & chkTrangThai
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.lblTrangThai.ForeColor = Color.FromArgb(30, 41, 59);
            this.lblTrangThai.Location = new Point(310, 118);
            this.lblTrangThai.Text = "Trạng thái học phần:";

            this.chkTrangThai.AutoSize = true;
            this.chkTrangThai.Checked = true;
            this.chkTrangThai.CheckState = CheckState.Checked;
            this.chkTrangThai.Font = new Font("Segoe UI", 10F);
            this.chkTrangThai.ForeColor = Color.FromArgb(15, 118, 110);
            this.chkTrangThai.Location = new Point(312, 143);
            this.chkTrangThai.Text = "Đang còn sử dụng giảng dạy";

            // pnlChucNang
            this.pnlChucNang.BackColor = Color.White;
            this.pnlChucNang.Location = new Point(654, 88);
            this.pnlChucNang.Size = new Size(334, 192);
            this.pnlChucNang.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.pnlChucNang.Controls.Add(this.lblHeaderNut);
            this.pnlChucNang.Controls.Add(this.btnThem);
            this.pnlChucNang.Controls.Add(this.btnSua);
            this.pnlChucNang.Controls.Add(this.btnXoa);
            this.pnlChucNang.Controls.Add(this.btnLamMoi);

            // lblHeaderNut
            this.lblHeaderNut.BackColor = Color.FromArgb(209, 250, 229);
            this.lblHeaderNut.Dock = DockStyle.Top;
            this.lblHeaderNut.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            this.lblHeaderNut.ForeColor = Color.FromArgb(6, 95, 70);
            this.lblHeaderNut.Height = 38;
            this.lblHeaderNut.Text = "   THAO TÁC CHỨC NĂNG";
            this.lblHeaderNut.TextAlign = ContentAlignment.MiddleLeft;

            // btnThem
            this.btnThem.BackColor = Color.FromArgb(16, 163, 127);
            this.btnThem.Cursor = Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = FlatStyle.Flat;
            this.btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnThem.ForeColor = Color.White;
            this.btnThem.Location = new Point(18, 56);
            this.btnThem.Size = new Size(142, 48);
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new EventHandler(this.btnThem_Click);

            // btnSua
            this.btnSua.BackColor = Color.FromArgb(37, 99, 235);
            this.btnSua.Cursor = Cursors.Hand;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = FlatStyle.Flat;
            this.btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnSua.ForeColor = Color.White;
            this.btnSua.Location = new Point(174, 56);
            this.btnSua.Size = new Size(142, 48);
            this.btnSua.Text = "Sửa môn";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new EventHandler(this.btnSua_Click);

            // btnXoa
            this.btnXoa.BackColor = Color.FromArgb(225, 29, 72);
            this.btnXoa.Cursor = Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = FlatStyle.Flat;
            this.btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnXoa.ForeColor = Color.White;
            this.btnXoa.Location = new Point(18, 120);
            this.btnXoa.Size = new Size(142, 48);
            this.btnXoa.Text = "Xóa môn";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new EventHandler(this.btnXoa_Click);

            // btnLamMoi
            this.btnLamMoi.BackColor = Color.FromArgb(100, 116, 139);
            this.btnLamMoi.Cursor = Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = FlatStyle.Flat;
            this.btnLamMoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnLamMoi.ForeColor = Color.White;
            this.btnLamMoi.Location = new Point(174, 120);
            this.btnLamMoi.Size = new Size(142, 48);
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new EventHandler(this.btnLamMoi_Click);

            // pnlTimKiem
            this.pnlTimKiem.BackColor = Color.White;
            this.pnlTimKiem.Location = new Point(18, 294);
            this.pnlTimKiem.Size = new Size(970, 54);
            this.pnlTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.pnlTimKiem.Controls.Add(this.lblTimKiem);
            this.pnlTimKiem.Controls.Add(this.txtTimKiem);
            this.pnlTimKiem.Controls.Add(this.btnTimKiem);
            this.pnlTimKiem.Controls.Add(this.lblCheDo);

            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.lblTimKiem.ForeColor = Color.FromArgb(30, 41, 59);
            this.lblTimKiem.Location = new Point(18, 17);
            this.lblTimKiem.Text = "Tìm kiếm môn học (mã hoặc tên):";

            this.txtTimKiem.Font = new Font("Segoe UI", 10.5F);
            this.txtTimKiem.Location = new Point(258, 13);
            this.txtTimKiem.Size = new Size(400, 27);
            this.txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.txtTimKiem.PlaceholderText = "Nhập từ khóa cần tìm...";
            this.txtTimKiem.KeyDown += new KeyEventHandler(this.txtTimKiem_KeyDown);

            this.btnTimKiem.BackColor = Color.FromArgb(13, 148, 136);
            this.btnTimKiem.Cursor = Cursors.Hand;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = FlatStyle.Flat;
            this.btnTimKiem.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnTimKiem.ForeColor = Color.White;
            this.btnTimKiem.Location = new Point(672, 10);
            this.btnTimKiem.Size = new Size(116, 34);
            this.btnTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new EventHandler(this.btnTimKiem_Click);

            this.lblCheDo.AutoSize = true;
            this.lblCheDo.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            this.lblCheDo.ForeColor = Color.FromArgb(15, 118, 110);
            this.lblCheDo.Location = new Point(804, 18);
            this.lblCheDo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.lblCheDo.Text = "Chế độ: Thêm mới";

            // pnlDanhSach
            this.pnlDanhSach.BackColor = Color.White;
            this.pnlDanhSach.Location = new Point(18, 362);
            this.pnlDanhSach.Size = new Size(970, 276);
            this.pnlDanhSach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.pnlDanhSach.Controls.Add(this.dgvMonHoc);
            this.pnlDanhSach.Controls.Add(this.lblHeaderBang);

            this.lblHeaderBang.BackColor = Color.FromArgb(209, 250, 229);
            this.lblHeaderBang.Dock = DockStyle.Top;
            this.lblHeaderBang.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            this.lblHeaderBang.ForeColor = Color.FromArgb(6, 95, 70);
            this.lblHeaderBang.Height = 38;
            this.lblHeaderBang.Text = "   DANH SÁCH MÔN HỌC TRONG CƠ SỞ DỮ LIỆU";
            this.lblHeaderBang.TextAlign = ContentAlignment.MiddleLeft;

            // dgvMonHoc
            this.dgvMonHoc.AllowUserToAddRows = false;
            this.dgvMonHoc.AllowUserToDeleteRows = false;
            this.dgvMonHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonHoc.BackgroundColor = Color.White;
            this.dgvMonHoc.BorderStyle = BorderStyle.None;
            this.dgvMonHoc.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMonHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMonHoc.ColumnHeadersHeight = 38;
            this.dgvMonHoc.Location = new Point(14, 46);
            this.dgvMonHoc.Size = new Size(942, 218);
            this.dgvMonHoc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvMonHoc.MultiSelect = false;
            this.dgvMonHoc.ReadOnly = true;
            this.dgvMonHoc.RowHeadersVisible = false;
            this.dgvMonHoc.RowTemplate.Height = 32;
            this.dgvMonHoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonHoc.CellClick += new DataGridViewCellEventHandler(this.dgvMonHoc_CellClick);

            // FrmMonHoc
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(230, 240, 236);
            this.ClientSize = new Size(1006, 656);
            this.Controls.Add(this.pnlDanhSach);
            this.Controls.Add(this.pnlTimKiem);
            this.Controls.Add(this.pnlChucNang);
            this.Controls.Add(this.pnlNhapLieu);
            this.Controls.Add(this.pnlHeader);
            this.MinimumSize = new Size(960, 640);
            this.Name = "FrmMonHoc";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "EduManager - Quản lý danh mục môn học";
            this.Load += new EventHandler(this.FrmMonHoc_Load);

            ((System.ComponentModel.ISupportInitialize)(this.nudSoTinChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlNhapLieu.ResumeLayout(false);
            this.pnlNhapLieu.PerformLayout();
            this.pnlChucNang.ResumeLayout(false);
            this.pnlTimKiem.ResumeLayout(false);
            this.pnlTimKiem.PerformLayout();
            this.pnlDanhSach.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
