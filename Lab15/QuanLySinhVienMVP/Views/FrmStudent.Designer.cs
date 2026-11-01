namespace QuanLySinhVienMVP.Views
{
    partial class FrmStudent
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlBadgeDiemTB = new System.Windows.Forms.Panel();
            this.lblGiaTriDiemTB = new System.Windows.Forms.Label();
            this.lblNhanDiemTB = new System.Windows.Forms.Label();
            this.pnlBadgeDat = new System.Windows.Forms.Panel();
            this.lblGiaTriDat = new System.Windows.Forms.Label();
            this.lblNhanDat = new System.Windows.Forms.Label();
            this.pnlBadgeTong = new System.Windows.Forms.Panel();
            this.lblGiaTriTong = new System.Windows.Forms.Label();
            this.lblNhanTong = new System.Windows.Forms.Label();
            this.lblMoTaHeader = new System.Windows.Forms.Label();
            this.lblTieuDeChinh = new System.Windows.Forms.Label();
            this.pnlNhapLieu = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lblDiem = new System.Windows.Forms.Label();
            this.cboClassName = new System.Windows.Forms.ComboBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblHuongDan = new System.Windows.Forms.Label();
            this.lblTieuDeNhap = new System.Windows.Forms.Label();
            this.pnlTimKiem = new System.Windows.Forms.Panel();
            this.pnlThongBao = new System.Windows.Forms.Panel();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslTrangThai = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlHeader.SuspendLayout();
            this.pnlBadgeDiemTB.SuspendLayout();
            this.pnlBadgeDat.SuspendLayout();
            this.pnlBadgeTong.SuspendLayout();
            this.pnlNhapLieu.SuspendLayout();
            this.pnlTimKiem.SuspendLayout();
            this.pnlThongBao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.pnlHeader.Controls.Add(this.pnlBadgeDiemTB);
            this.pnlHeader.Controls.Add(this.pnlBadgeDat);
            this.pnlHeader.Controls.Add(this.pnlBadgeTong);
            this.pnlHeader.Controls.Add(this.lblMoTaHeader);
            this.pnlHeader.Controls.Add(this.lblTieuDeChinh);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1040, 82);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTieuDeChinh
            // 
            this.lblTieuDeChinh.AutoSize = true;
            this.lblTieuDeChinh.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTieuDeChinh.ForeColor = System.Drawing.Color.White;
            this.lblTieuDeChinh.Location = new System.Drawing.Point(22, 13);
            this.lblTieuDeChinh.Name = "lblTieuDeChinh";
            this.lblTieuDeChinh.Size = new System.Drawing.Size(442, 28);
            this.lblTieuDeChinh.TabIndex = 0;
            this.lblTieuDeChinh.Text = "QUẢN LÝ HỒ SƠ SINH VIÊN - MÔ HÌNH MVP";
            // 
            // lblMoTaHeader
            // 
            this.lblMoTaHeader.AutoSize = true;
            this.lblMoTaHeader.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.lblMoTaHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(243)))), ((int)(((byte)(208)))));
            this.lblMoTaHeader.Location = new System.Drawing.Point(24, 46);
            this.lblMoTaHeader.Name = "lblMoTaHeader";
            this.lblMoTaHeader.Size = new System.Drawing.Size(526, 17);
            this.lblMoTaHeader.TabIndex = 1;
            this.lblMoTaHeader.Text = "Học phần COMP1019 - Tách biệt giao diện (View), xử lý (Presenter) và dữ liệu (Repository)";
            // 
            // pnlBadgeTong
            // 
            this.pnlBadgeTong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(94)))), ((int)(((byte)(89)))));
            this.pnlBadgeTong.Controls.Add(this.lblGiaTriTong);
            this.pnlBadgeTong.Controls.Add(this.lblNhanTong);
            this.pnlBadgeTong.Location = new System.Drawing.Point(606, 12);
            this.pnlBadgeTong.Name = "pnlBadgeTong";
            this.pnlBadgeTong.Size = new System.Drawing.Size(130, 58);
            this.pnlBadgeTong.TabIndex = 2;
            // 
            // lblNhanTong
            // 
            this.lblNhanTong.AutoSize = true;
            this.lblNhanTong.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblNhanTong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(246)))), ((int)(((byte)(228)))));
            this.lblNhanTong.Location = new System.Drawing.Point(12, 7);
            this.lblNhanTong.Name = "lblNhanTong";
            this.lblNhanTong.Size = new System.Drawing.Size(80, 15);
            this.lblNhanTong.TabIndex = 0;
            this.lblNhanTong.Text = "TỔNG SỐ SV";
            // 
            // lblGiaTriTong
            // 
            this.lblGiaTriTong.AutoSize = true;
            this.lblGiaTriTong.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblGiaTriTong.ForeColor = System.Drawing.Color.White;
            this.lblGiaTriTong.Location = new System.Drawing.Point(12, 25);
            this.lblGiaTriTong.Name = "lblGiaTriTong";
            this.lblGiaTriTong.Size = new System.Drawing.Size(32, 25);
            this.lblGiaTriTong.TabIndex = 1;
            this.lblGiaTriTong.Text = "10";
            // 
            // pnlBadgeDat
            // 
            this.pnlBadgeDat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(94)))), ((int)(((byte)(89)))));
            this.pnlBadgeDat.Controls.Add(this.lblGiaTriDat);
            this.pnlBadgeDat.Controls.Add(this.lblNhanDat);
            this.pnlBadgeDat.Location = new System.Drawing.Point(748, 12);
            this.pnlBadgeDat.Name = "pnlBadgeDat";
            this.pnlBadgeDat.Size = new System.Drawing.Size(130, 58);
            this.pnlBadgeDat.TabIndex = 3;
            // 
            // lblNhanDat
            // 
            this.lblNhanDat.AutoSize = true;
            this.lblNhanDat.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblNhanDat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(231)))), ((int)(((byte)(183)))));
            this.lblNhanDat.Location = new System.Drawing.Point(12, 7);
            this.lblNhanDat.Name = "lblNhanDat";
            this.lblNhanDat.Size = new System.Drawing.Size(92, 15);
            this.lblNhanDat.TabIndex = 0;
            this.lblNhanDat.Text = "SINH VIÊN ĐẠT";
            // 
            // lblGiaTriDat
            // 
            this.lblGiaTriDat.AutoSize = true;
            this.lblGiaTriDat.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblGiaTriDat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(243)))), ((int)(((byte)(208)))));
            this.lblGiaTriDat.Location = new System.Drawing.Point(12, 25);
            this.lblGiaTriDat.Name = "lblGiaTriDat";
            this.lblGiaTriDat.Size = new System.Drawing.Size(22, 25);
            this.lblGiaTriDat.TabIndex = 1;
            this.lblGiaTriDat.Text = "8";
            // 
            // pnlBadgeDiemTB
            // 
            this.pnlBadgeDiemTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(94)))), ((int)(((byte)(89)))));
            this.pnlBadgeDiemTB.Controls.Add(this.lblGiaTriDiemTB);
            this.pnlBadgeDiemTB.Controls.Add(this.lblNhanDiemTB);
            this.pnlBadgeDiemTB.Location = new System.Drawing.Point(890, 12);
            this.pnlBadgeDiemTB.Name = "pnlBadgeDiemTB";
            this.pnlBadgeDiemTB.Size = new System.Drawing.Size(130, 58);
            this.pnlBadgeDiemTB.TabIndex = 4;
            // 
            // lblNhanDiemTB
            // 
            this.lblNhanDiemTB.AutoSize = true;
            this.lblNhanDiemTB.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblNhanDiemTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(230)))), ((int)(((byte)(138)))));
            this.lblNhanDiemTB.Location = new System.Drawing.Point(12, 7);
            this.lblNhanDiemTB.Name = "lblNhanDiemTB";
            this.lblNhanDiemTB.Size = new System.Drawing.Size(96, 15);
            this.lblNhanDiemTB.TabIndex = 0;
            this.lblNhanDiemTB.Text = "ĐIỂM TB CHUNG";
            // 
            // lblGiaTriDiemTB
            // 
            this.lblGiaTriDiemTB.AutoSize = true;
            this.lblGiaTriDiemTB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblGiaTriDiemTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(240)))), ((int)(((byte)(138)))));
            this.lblGiaTriDiemTB.Location = new System.Drawing.Point(12, 25);
            this.lblGiaTriDiemTB.Name = "lblGiaTriDiemTB";
            this.lblGiaTriDiemTB.Size = new System.Drawing.Size(47, 25);
            this.lblGiaTriDiemTB.TabIndex = 1;
            this.lblGiaTriDiemTB.Text = "7.00";
            // 
            // pnlNhapLieu
            // 
            this.pnlNhapLieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.pnlNhapLieu.Controls.Add(this.btnLoad);
            this.pnlNhapLieu.Controls.Add(this.btnClear);
            this.pnlNhapLieu.Controls.Add(this.btnDelete);
            this.pnlNhapLieu.Controls.Add(this.btnAdd);
            this.pnlNhapLieu.Controls.Add(this.txtScore);
            this.pnlNhapLieu.Controls.Add(this.lblDiem);
            this.pnlNhapLieu.Controls.Add(this.cboClassName);
            this.pnlNhapLieu.Controls.Add(this.lblLop);
            this.pnlNhapLieu.Controls.Add(this.txtFullName);
            this.pnlNhapLieu.Controls.Add(this.lblHoTen);
            this.pnlNhapLieu.Controls.Add(this.txtStudentId);
            this.pnlNhapLieu.Controls.Add(this.lblMaSV);
            this.pnlNhapLieu.Controls.Add(this.lblHuongDan);
            this.pnlNhapLieu.Controls.Add(this.lblTieuDeNhap);
            this.pnlNhapLieu.Location = new System.Drawing.Point(20, 96);
            this.pnlNhapLieu.Name = "pnlNhapLieu";
            this.pnlNhapLieu.Size = new System.Drawing.Size(1000, 152);
            this.pnlNhapLieu.TabIndex = 1;
            // 
            // lblTieuDeNhap
            // 
            this.lblTieuDeNhap.AutoSize = true;
            this.lblTieuDeNhap.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTieuDeNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.lblTieuDeNhap.Location = new System.Drawing.Point(20, 11);
            this.lblTieuDeNhap.Name = "lblTieuDeNhap";
            this.lblTieuDeNhap.Size = new System.Drawing.Size(218, 19);
            this.lblTieuDeNhap.TabIndex = 0;
            this.lblTieuDeNhap.Text = "THÔNG TIN HỒ SƠ SINH VIÊN";
            // 
            // lblHuongDan
            // 
            this.lblHuongDan.AutoSize = true;
            this.lblHuongDan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblHuongDan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblHuongDan.Location = new System.Drawing.Point(244, 13);
            this.lblHuongDan.Name = "lblHuongDan";
            this.lblHuongDan.Size = new System.Drawing.Size(375, 15);
            this.lblHuongDan.TabIndex = 1;
            this.lblHuongDan.Text = "(Nhập thông tin mới hoặc click chọn dòng trên bảng để thao tác nhanh)";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblMaSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblMaSV.Location = new System.Drawing.Point(20, 38);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(110, 17);
            this.lblMaSV.TabIndex = 2;
            this.lblMaSV.Text = "Mã sinh viên (*):";
            // 
            // txtStudentId
            // 
            this.txtStudentId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtStudentId.Location = new System.Drawing.Point(20, 60);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(185, 25);
            this.txtStudentId.TabIndex = 3;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblHoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblHoTen.Location = new System.Drawing.Point(228, 38);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(148, 17);
            this.lblHoTen.TabIndex = 4;
            this.lblHoTen.Text = "Họ và tên sinh viên (*):";
            // 
            // txtFullName
            // 
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFullName.Location = new System.Drawing.Point(228, 60);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(310, 25);
            this.txtFullName.TabIndex = 5;
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblLop.Location = new System.Drawing.Point(562, 38);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(112, 17);
            this.lblLop.TabIndex = 6;
            this.lblLop.Text = "Lớp biên chế (*):";
            // 
            // cboClassName
            // 
            this.cboClassName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboClassName.FormattingEnabled = true;
            this.cboClassName.Items.AddRange(new object[] {
            "24CT1",
            "24CT2",
            "24KTPM1",
            "24HTTT1"});
            this.cboClassName.Location = new System.Drawing.Point(562, 60);
            this.cboClassName.Name = "cboClassName";
            this.cboClassName.Size = new System.Drawing.Size(196, 25);
            this.cboClassName.TabIndex = 7;
            // 
            // lblDiem
            // 
            this.lblDiem.AutoSize = true;
            this.lblDiem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblDiem.Location = new System.Drawing.Point(782, 38);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(162, 17);
            this.lblDiem.TabIndex = 8;
            this.lblDiem.Text = "Điểm trung bình (0 - 10):";
            // 
            // txtScore
            // 
            this.txtScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtScore.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtScore.Location = new System.Drawing.Point(782, 60);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(198, 25);
            this.txtScore.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(20, 100);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(225, 38);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Thêm sinh viên";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(29)))), ((int)(((byte)(72)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(265, 100);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(225, 38);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Xóa theo mã";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(510, 100);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(225, 38);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Làm mới ô nhập";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(755, 100);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(225, 38);
            this.btnLoad.TabIndex = 13;
            this.btnLoad.Text = "Tải danh sách";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pnlTimKiem
            // 
            this.pnlTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlTimKiem.Controls.Add(this.pnlThongBao);
            this.pnlTimKiem.Controls.Add(this.btnSearch);
            this.pnlTimKiem.Controls.Add(this.txtSearch);
            this.pnlTimKiem.Controls.Add(this.lblTimKiem);
            this.pnlTimKiem.Location = new System.Drawing.Point(20, 260);
            this.pnlTimKiem.Name = "pnlTimKiem";
            this.pnlTimKiem.Size = new System.Drawing.Size(1000, 54);
            this.pnlTimKiem.TabIndex = 2;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblTimKiem.Location = new System.Drawing.Point(18, 18);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(142, 17);
            this.lblTimKiem.TabIndex = 0;
            this.lblTimKiem.Text = "Tìm kiếm (Mã / Tên):";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(166, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(248, 25);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(426, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 34);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlThongBao
            // 
            this.pnlThongBao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(250)))), ((int)(((byte)(229)))));
            this.pnlThongBao.Controls.Add(this.lblThongBao);
            this.pnlThongBao.Location = new System.Drawing.Point(572, 9);
            this.pnlThongBao.Name = "pnlThongBao";
            this.pnlThongBao.Size = new System.Drawing.Size(412, 36);
            this.pnlThongBao.TabIndex = 3;
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblThongBao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(95)))), ((int)(((byte)(70)))));
            this.lblThongBao.Location = new System.Drawing.Point(12, 10);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(261, 15);
            this.lblThongBao.TabIndex = 0;
            this.lblThongBao.Text = "Sẵn sàng: Đã tải danh sách sinh viên mẫu.";
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(20, 322);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersVisible = false;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(1000, 318);
            this.dgvStudents.TabIndex = 3;
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslTrangThai});
            this.statusStrip1.Location = new System.Drawing.Point(0, 650);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1040, 26);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslTrangThai
            // 
            this.tslTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tslTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.tslTrangThai.Name = "tslTrangThai";
            this.tslTrangThai.Size = new System.Drawing.Size(294, 21);
            this.tslTrangThai.Text = "Kiến trúc MVP: View <-> Presenter <-> Repository";
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1040, 676);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.pnlTimKiem);
            this.Controls.Add(this.pnlNhapLieu);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sinh Viên Theo Mô Hình MVP - Lab 15";
            this.Load += new System.EventHandler(this.FrmStudent_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBadgeDiemTB.ResumeLayout(false);
            this.pnlBadgeDiemTB.PerformLayout();
            this.pnlBadgeDat.ResumeLayout(false);
            this.pnlBadgeDat.PerformLayout();
            this.pnlBadgeTong.ResumeLayout(false);
            this.pnlBadgeTong.PerformLayout();
            this.pnlNhapLieu.ResumeLayout(false);
            this.pnlNhapLieu.PerformLayout();
            this.pnlTimKiem.ResumeLayout(false);
            this.pnlTimKiem.PerformLayout();
            this.pnlThongBao.ResumeLayout(false);
            this.pnlThongBao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlBadgeDiemTB;
        private System.Windows.Forms.Label lblGiaTriDiemTB;
        private System.Windows.Forms.Label lblNhanDiemTB;
        private System.Windows.Forms.Panel pnlBadgeDat;
        private System.Windows.Forms.Label lblGiaTriDat;
        private System.Windows.Forms.Label lblNhanDat;
        private System.Windows.Forms.Panel pnlBadgeTong;
        private System.Windows.Forms.Label lblGiaTriTong;
        private System.Windows.Forms.Label lblNhanTong;
        private System.Windows.Forms.Label lblMoTaHeader;
        private System.Windows.Forms.Label lblTieuDeChinh;
        private System.Windows.Forms.Panel pnlNhapLieu;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.ComboBox cboClassName;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblHuongDan;
        private System.Windows.Forms.Label lblTieuDeNhap;
        private System.Windows.Forms.Panel pnlTimKiem;
        private System.Windows.Forms.Panel pnlThongBao;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslTrangThai;
    }
}
