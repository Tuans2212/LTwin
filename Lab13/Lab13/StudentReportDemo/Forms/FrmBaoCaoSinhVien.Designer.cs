namespace StudentReportDemo.Forms
{
    partial class FrmBaoCaoSinhVien
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
            this.lblMoTaHeader = new System.Windows.Forms.Label();
            this.lblTieuDeChinh = new System.Windows.Forms.Label();
            this.pnlBoLoc = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.lblNhomChucNang = new System.Windows.Forms.Label();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.lblTuKhoa = new System.Windows.Forms.Label();
            this.cboKetQua = new System.Windows.Forms.ComboBox();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.lblTieuDeLoc = new System.Windows.Forms.Label();
            this.pnlChinh = new System.Windows.Forms.Panel();
            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.pnlThongKeNhanh = new System.Windows.Forms.Panel();
            this.lblThongKe = new System.Windows.Forms.Label();
            this.pnlTheDiemTB = new System.Windows.Forms.Panel();
            this.lblGiaTriDiemTB = new System.Windows.Forms.Label();
            this.lblNhanDiemTB = new System.Windows.Forms.Label();
            this.pnlTheKhongDat = new System.Windows.Forms.Panel();
            this.lblGiaTriKhongDat = new System.Windows.Forms.Label();
            this.lblNhanKhongDat = new System.Windows.Forms.Label();
            this.pnlTheDat = new System.Windows.Forms.Panel();
            this.lblGiaTriDat = new System.Windows.Forms.Label();
            this.lblNhanDat = new System.Windows.Forms.Label();
            this.pnlTheTong = new System.Windows.Forms.Panel();
            this.lblGiaTriTong = new System.Windows.Forms.Label();
            this.lblNhanTong = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslTrangThai = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlHeader.SuspendLayout();
            this.pnlBoLoc.SuspendLayout();
            this.pnlChinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            this.pnlThongKeNhanh.SuspendLayout();
            this.pnlTheDiemTB.SuspendLayout();
            this.pnlTheKhongDat.SuspendLayout();
            this.pnlTheDat.SuspendLayout();
            this.pnlTheTong.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(84)))));
            this.pnlHeader.Controls.Add(this.lblMoTaHeader);
            this.pnlHeader.Controls.Add(this.lblTieuDeChinh);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1020, 76);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblMoTaHeader
            // 
            this.lblMoTaHeader.AutoSize = true;
            this.lblMoTaHeader.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.lblMoTaHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(253)))));
            this.lblMoTaHeader.Location = new System.Drawing.Point(24, 44);
            this.lblMoTaHeader.Name = "lblMoTaHeader";
            this.lblMoTaHeader.Size = new System.Drawing.Size(375, 17);
            this.lblMoTaHeader.TabIndex = 1;
            this.lblMoTaHeader.Text = "Học phần COMP1019 - Quản lý và truy vấn dữ liệu với LINQ";
            // 
            // lblTieuDeChinh
            // 
            this.lblTieuDeChinh.AutoSize = true;
            this.lblTieuDeChinh.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTieuDeChinh.ForeColor = System.Drawing.Color.White;
            this.lblTieuDeChinh.Location = new System.Drawing.Point(22, 12);
            this.lblTieuDeChinh.Name = "lblTieuDeChinh";
            this.lblTieuDeChinh.Size = new System.Drawing.Size(420, 28);
            this.lblTieuDeChinh.TabIndex = 0;
            this.lblTieuDeChinh.Text = "BÁO CÁO KẾT QUẢ HỌC TẬP SINH VIÊN";
            // 
            // pnlBoLoc
            // 
            this.pnlBoLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlBoLoc.Controls.Add(this.btnLamMoi);
            this.pnlBoLoc.Controls.Add(this.lblNhomChucNang);
            this.pnlBoLoc.Controls.Add(this.btnXuatFile);
            this.pnlBoLoc.Controls.Add(this.btnThongKe);
            this.pnlBoLoc.Controls.Add(this.btnXemBaoCao);
            this.pnlBoLoc.Controls.Add(this.txtTuKhoa);
            this.pnlBoLoc.Controls.Add(this.lblTuKhoa);
            this.pnlBoLoc.Controls.Add(this.cboKetQua);
            this.pnlBoLoc.Controls.Add(this.lblKetQua);
            this.pnlBoLoc.Controls.Add(this.cboLop);
            this.pnlBoLoc.Controls.Add(this.lblLop);
            this.pnlBoLoc.Controls.Add(this.lblTieuDeLoc);
            this.pnlBoLoc.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBoLoc.Location = new System.Drawing.Point(0, 76);
            this.pnlBoLoc.Name = "pnlBoLoc";
            this.pnlBoLoc.Padding = new System.Windows.Forms.Padding(16);
            this.pnlBoLoc.Size = new System.Drawing.Size(270, 542);
            this.pnlBoLoc.TabIndex = 1;
            // 
            // lblTieuDeLoc
            // 
            this.lblTieuDeLoc.AutoSize = true;
            this.lblTieuDeLoc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTieuDeLoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblTieuDeLoc.Location = new System.Drawing.Point(18, 18);
            this.lblTieuDeLoc.Name = "lblTieuDeLoc";
            this.lblTieuDeLoc.Size = new System.Drawing.Size(156, 20);
            this.lblTieuDeLoc.TabIndex = 0;
            this.lblTieuDeLoc.Text = "THÔNG TIN BỘ LỌC";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblLop.Location = new System.Drawing.Point(18, 54);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(96, 17);
            this.lblLop.TabIndex = 1;
            this.lblLop.Text = "Chọn lớp học:";
            // 
            // cboLop
            // 
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(20, 76);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(230, 25);
            this.cboLop.TabIndex = 2;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblKetQua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblKetQua.Location = new System.Drawing.Point(18, 118);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(112, 17);
            this.lblKetQua.TabIndex = 3;
            this.lblKetQua.Text = "Kết quả học tập:";
            // 
            // cboKetQua
            // 
            this.cboKetQua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKetQua.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboKetQua.FormattingEnabled = true;
            this.cboKetQua.Location = new System.Drawing.Point(20, 140);
            this.cboKetQua.Name = "cboKetQua";
            this.cboKetQua.Size = new System.Drawing.Size(230, 25);
            this.cboKetQua.TabIndex = 4;
            this.cboKetQua.SelectedIndexChanged += new System.EventHandler(this.cboKetQua_SelectedIndexChanged);
            // 
            // lblTuKhoa
            // 
            this.lblTuKhoa.AutoSize = true;
            this.lblTuKhoa.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTuKhoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblTuKhoa.Location = new System.Drawing.Point(18, 182);
            this.lblTuKhoa.Name = "lblTuKhoa";
            this.lblTuKhoa.Size = new System.Drawing.Size(172, 17);
            this.lblTuKhoa.TabIndex = 5;
            this.lblTuKhoa.Text = "Từ khóa (Mã SV / Họ tên):";
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTuKhoa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTuKhoa.Location = new System.Drawing.Point(20, 204);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(230, 25);
            this.txtTuKhoa.TabIndex = 6;
            this.txtTuKhoa.TextChanged += new System.EventHandler(this.txtTuKhoa_TextChanged);
            // 
            // lblNhomChucNang
            // 
            this.lblNhomChucNang.AutoSize = true;
            this.lblNhomChucNang.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNhomChucNang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblNhomChucNang.Location = new System.Drawing.Point(18, 252);
            this.lblNhomChucNang.Name = "lblNhomChucNang";
            this.lblNhomChucNang.Size = new System.Drawing.Size(148, 20);
            this.lblNhomChucNang.TabIndex = 7;
            this.lblNhomChucNang.Text = "TÁC VỤ BÁO CÁO";
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnXemBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXemBaoCao.FlatAppearance.BorderSize = 0;
            this.btnXemBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemBaoCao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXemBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnXemBaoCao.Location = new System.Drawing.Point(20, 284);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(230, 42);
            this.btnXemBaoCao.TabIndex = 8;
            this.btnXemBaoCao.Text = "Xem báo cáo";
            this.btnXemBaoCao.UseVisualStyleBackColor = false;
            this.btnXemBaoCao.Click += new System.EventHandler(this.btnXemBaoCao_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(20, 338);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(230, 42);
            this.btnThongKe.TabIndex = 9;
            this.btnThongKe.Text = "Thống kê theo lớp";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.btnXuatFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatFile.FlatAppearance.BorderSize = 0;
            this.btnXuatFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatFile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXuatFile.ForeColor = System.Drawing.Color.White;
            this.btnXuatFile.Location = new System.Drawing.Point(20, 392);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(230, 42);
            this.btnXuatFile.TabIndex = 10;
            this.btnXuatFile.Text = "Xuất file CSV / TXT";
            this.btnXuatFile.UseVisualStyleBackColor = false;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(20, 446);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(230, 38);
            this.btnLamMoi.TabIndex = 11;
            this.btnLamMoi.Text = "Đặt lại mặc định";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // pnlChinh
            // 
            this.pnlChinh.BackColor = System.Drawing.Color.White;
            this.pnlChinh.Controls.Add(this.dgvBaoCao);
            this.pnlChinh.Controls.Add(this.pnlThongKeNhanh);
            this.pnlChinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChinh.Location = new System.Drawing.Point(270, 76);
            this.pnlChinh.Name = "pnlChinh";
            this.pnlChinh.Padding = new System.Windows.Forms.Padding(16);
            this.pnlChinh.Size = new System.Drawing.Size(750, 542);
            this.pnlChinh.TabIndex = 2;
            // 
            // pnlThongKeNhanh
            // 
            this.pnlThongKeNhanh.BackColor = System.Drawing.Color.White;
            this.pnlThongKeNhanh.Controls.Add(this.lblThongKe);
            this.pnlThongKeNhanh.Controls.Add(this.pnlTheDiemTB);
            this.pnlThongKeNhanh.Controls.Add(this.pnlTheKhongDat);
            this.pnlThongKeNhanh.Controls.Add(this.pnlTheDat);
            this.pnlThongKeNhanh.Controls.Add(this.pnlTheTong);
            this.pnlThongKeNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlThongKeNhanh.Location = new System.Drawing.Point(16, 16);
            this.pnlThongKeNhanh.Name = "pnlThongKeNhanh";
            this.pnlThongKeNhanh.Size = new System.Drawing.Size(718, 118);
            this.pnlThongKeNhanh.TabIndex = 0;
            // 
            // pnlTheTong
            // 
            this.pnlTheTong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.pnlTheTong.Controls.Add(this.lblGiaTriTong);
            this.pnlTheTong.Controls.Add(this.lblNhanTong);
            this.pnlTheTong.Location = new System.Drawing.Point(0, 0);
            this.pnlTheTong.Name = "pnlTheTong";
            this.pnlTheTong.Size = new System.Drawing.Size(168, 76);
            this.pnlTheTong.TabIndex = 0;
            // 
            // lblNhanTong
            // 
            this.lblNhanTong.AutoSize = true;
            this.lblNhanTong.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblNhanTong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.lblNhanTong.Location = new System.Drawing.Point(12, 10);
            this.lblNhanTong.Name = "lblNhanTong";
            this.lblNhanTong.Size = new System.Drawing.Size(102, 15);
            this.lblNhanTong.TabIndex = 0;
            this.lblNhanTong.Text = "TỔNG SINH VIÊN";
            // 
            // lblGiaTriTong
            // 
            this.lblGiaTriTong.AutoSize = true;
            this.lblGiaTriTong.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblGiaTriTong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblGiaTriTong.Location = new System.Drawing.Point(12, 32);
            this.lblGiaTriTong.Name = "lblGiaTriTong";
            this.lblGiaTriTong.Size = new System.Drawing.Size(37, 30);
            this.lblGiaTriTong.TabIndex = 1;
            this.lblGiaTriTong.Text = "16";
            // 
            // pnlTheDat
            // 
            this.pnlTheDat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(253)))), ((int)(((byte)(245)))));
            this.pnlTheDat.Controls.Add(this.lblGiaTriDat);
            this.pnlTheDat.Controls.Add(this.lblNhanDat);
            this.pnlTheDat.Location = new System.Drawing.Point(182, 0);
            this.pnlTheDat.Name = "pnlTheDat";
            this.pnlTheDat.Size = new System.Drawing.Size(168, 76);
            this.pnlTheDat.TabIndex = 1;
            // 
            // lblNhanDat
            // 
            this.lblNhanDat.AutoSize = true;
            this.lblNhanDat.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblNhanDat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(120)))), ((int)(((byte)(87)))));
            this.lblNhanDat.Location = new System.Drawing.Point(12, 10);
            this.lblNhanDat.Name = "lblNhanDat";
            this.lblNhanDat.Size = new System.Drawing.Size(92, 15);
            this.lblNhanDat.TabIndex = 0;
            this.lblNhanDat.Text = "SỐ LƯỢNG ĐẠT";
            // 
            // lblGiaTriDat
            // 
            this.lblGiaTriDat.AutoSize = true;
            this.lblGiaTriDat.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblGiaTriDat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(95)))), ((int)(((byte)(70)))));
            this.lblGiaTriDat.Location = new System.Drawing.Point(12, 32);
            this.lblGiaTriDat.Name = "lblGiaTriDat";
            this.lblGiaTriDat.Size = new System.Drawing.Size(37, 30);
            this.lblGiaTriDat.TabIndex = 1;
            this.lblGiaTriDat.Text = "12";
            // 
            // pnlTheKhongDat
            // 
            this.pnlTheKhongDat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pnlTheKhongDat.Controls.Add(this.lblGiaTriKhongDat);
            this.pnlTheKhongDat.Controls.Add(this.lblNhanKhongDat);
            this.pnlTheKhongDat.Location = new System.Drawing.Point(364, 0);
            this.pnlTheKhongDat.Name = "pnlTheKhongDat";
            this.pnlTheKhongDat.Size = new System.Drawing.Size(168, 76);
            this.pnlTheKhongDat.TabIndex = 2;
            // 
            // lblNhanKhongDat
            // 
            this.lblNhanKhongDat.AutoSize = true;
            this.lblNhanKhongDat.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblNhanKhongDat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblNhanKhongDat.Location = new System.Drawing.Point(12, 10);
            this.lblNhanKhongDat.Name = "lblNhanKhongDat";
            this.lblNhanKhongDat.Size = new System.Drawing.Size(111, 15);
            this.lblNhanKhongDat.TabIndex = 0;
            this.lblNhanKhongDat.Text = "CHƯA ĐẠT (< 5.0)";
            // 
            // lblGiaTriKhongDat
            // 
            this.lblGiaTriKhongDat.AutoSize = true;
            this.lblGiaTriKhongDat.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblGiaTriKhongDat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.lblGiaTriKhongDat.Location = new System.Drawing.Point(12, 32);
            this.lblGiaTriKhongDat.Name = "lblGiaTriKhongDat";
            this.lblGiaTriKhongDat.Size = new System.Drawing.Size(25, 30);
            this.lblGiaTriKhongDat.TabIndex = 1;
            this.lblGiaTriKhongDat.Text = "4";
            // 
            // pnlTheDiemTB
            // 
            this.pnlTheDiemTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(235)))));
            this.pnlTheDiemTB.Controls.Add(this.lblGiaTriDiemTB);
            this.pnlTheDiemTB.Controls.Add(this.lblNhanDiemTB);
            this.pnlTheDiemTB.Location = new System.Drawing.Point(546, 0);
            this.pnlTheDiemTB.Name = "pnlTheDiemTB";
            this.pnlTheDiemTB.Size = new System.Drawing.Size(172, 76);
            this.pnlTheDiemTB.TabIndex = 3;
            // 
            // lblNhanDiemTB
            // 
            this.lblNhanDiemTB.AutoSize = true;
            this.lblNhanDiemTB.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblNhanDiemTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.lblNhanDiemTB.Location = new System.Drawing.Point(12, 10);
            this.lblNhanDiemTB.Name = "lblNhanDiemTB";
            this.lblNhanDiemTB.Size = new System.Drawing.Size(113, 15);
            this.lblNhanDiemTB.TabIndex = 0;
            this.lblNhanDiemTB.Text = "ĐIỂM TRUNG BÌNH";
            // 
            // lblGiaTriDiemTB
            // 
            this.lblGiaTriDiemTB.AutoSize = true;
            this.lblGiaTriDiemTB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblGiaTriDiemTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(64)))), ((int)(((byte)(14)))));
            this.lblGiaTriDiemTB.Location = new System.Drawing.Point(12, 32);
            this.lblGiaTriDiemTB.Name = "lblGiaTriDiemTB";
            this.lblGiaTriDiemTB.Size = new System.Drawing.Size(55, 30);
            this.lblGiaTriDiemTB.TabIndex = 1;
            this.lblGiaTriDiemTB.Text = "6.89";
            // 
            // lblThongKe
            // 
            this.lblThongKe.AutoSize = true;
            this.lblThongKe.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblThongKe.Location = new System.Drawing.Point(2, 88);
            this.lblThongKe.Name = "lblThongKe";
            this.lblThongKe.Size = new System.Drawing.Size(435, 17);
            this.lblThongKe.TabIndex = 4;
            this.lblThongKe.Text = "Tổng số SV: 16 | Số đạt: 12 | Không đạt: 4 | Điểm trung bình: 6.89";
            // 
            // dgvBaoCao
            // 
            this.dgvBaoCao.AllowUserToAddRows = false;
            this.dgvBaoCao.AllowUserToDeleteRows = false;
            this.dgvBaoCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBaoCao.BackgroundColor = System.Drawing.Color.White;
            this.dgvBaoCao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBaoCao.Location = new System.Drawing.Point(16, 134);
            this.dgvBaoCao.Name = "dgvBaoCao";
            this.dgvBaoCao.ReadOnly = true;
            this.dgvBaoCao.RowHeadersVisible = false;
            this.dgvBaoCao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBaoCao.Size = new System.Drawing.Size(718, 392);
            this.dgvBaoCao.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslTrangThai});
            this.statusStrip1.Location = new System.Drawing.Point(0, 618);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1020, 24);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslTrangThai
            // 
            this.tslTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tslTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.tslTrangThai.Name = "tslTrangThai";
            this.tslTrangThai.Size = new System.Drawing.Size(141, 19);
            this.tslTrangThai.Text = "Sẵn sàng hiển thị báo cáo";
            // 
            // FrmBaoCaoSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1020, 642);
            this.Controls.Add(this.pnlChinh);
            this.Controls.Add(this.pnlBoLoc);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.statusStrip1);
            this.MinimumSize = new System.Drawing.Size(960, 620);
            this.Name = "FrmBaoCaoSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý & Báo Cáo Điểm Sinh Viên - Lab 13";
            this.Load += new System.EventHandler(this.FrmBaoCaoSinhVien_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBoLoc.ResumeLayout(false);
            this.pnlBoLoc.PerformLayout();
            this.pnlChinh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.pnlThongKeNhanh.ResumeLayout(false);
            this.pnlThongKeNhanh.PerformLayout();
            this.pnlTheDiemTB.ResumeLayout(false);
            this.pnlTheDiemTB.PerformLayout();
            this.pnlTheKhongDat.ResumeLayout(false);
            this.pnlTheKhongDat.PerformLayout();
            this.pnlTheDat.ResumeLayout(false);
            this.pnlTheDat.PerformLayout();
            this.pnlTheTong.ResumeLayout(false);
            this.pnlTheTong.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblMoTaHeader;
        private System.Windows.Forms.Label lblTieuDeChinh;
        private System.Windows.Forms.Panel pnlBoLoc;
        private System.Windows.Forms.Label lblNhomChucNang;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnXemBaoCao;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Label lblTuKhoa;
        private System.Windows.Forms.ComboBox cboKetQua;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblTieuDeLoc;
        private System.Windows.Forms.Panel pnlChinh;
        private System.Windows.Forms.DataGridView dgvBaoCao;
        private System.Windows.Forms.Panel pnlThongKeNhanh;
        private System.Windows.Forms.Label lblThongKe;
        private System.Windows.Forms.Panel pnlTheDiemTB;
        private System.Windows.Forms.Label lblGiaTriDiemTB;
        private System.Windows.Forms.Label lblNhanDiemTB;
        private System.Windows.Forms.Panel pnlTheKhongDat;
        private System.Windows.Forms.Label lblGiaTriKhongDat;
        private System.Windows.Forms.Label lblNhanKhongDat;
        private System.Windows.Forms.Panel pnlTheDat;
        private System.Windows.Forms.Label lblGiaTriDat;
        private System.Windows.Forms.Label lblNhanDat;
        private System.Windows.Forms.Panel pnlTheTong;
        private System.Windows.Forms.Label lblGiaTriTong;
        private System.Windows.Forms.Label lblNhanTong;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslTrangThai;
        private System.Windows.Forms.Button btnLamMoi;
    }
}
