namespace QLSinhVienLab12.Forms
{
    partial class FrmNhapDiemTheoLop
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblPhuDe;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblChonLop;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label lblChonMon;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.Button btnTaiDanhSach;
        private System.Windows.Forms.Button btnLuuTatCa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel pnlThongKe;
        private System.Windows.Forms.Label lblTieuDeThongKe;
        private System.Windows.Forms.Label lblSiSo;
        private System.Windows.Forms.Label lblDiemTB;
        private System.Windows.Forms.Label lblQuaMon;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTrangThai;

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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblPhuDe = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlThongKe = new System.Windows.Forms.Panel();
            this.lblQuaMon = new System.Windows.Forms.Label();
            this.lblDiemTB = new System.Windows.Forms.Label();
            this.lblSiSo = new System.Windows.Forms.Label();
            this.lblTieuDeThongKe = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnLuuTatCa = new System.Windows.Forms.Button();
            this.btnTaiDanhSach = new System.Windows.Forms.Button();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.lblChonMon = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.lblChonLop = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTrangThai = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlHeader.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlThongKe.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(43, 45, 66);
            this.pnlHeader.Controls.Add(this.lblPhuDe);
            this.pnlHeader.Controls.Add(this.lblTieuDe);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(980, 72);
            this.pnlHeader.TabIndex = 0;

            // lblTieuDe
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(22, 12);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(370, 28);
            this.lblTieuDe.Text = "QUẢN LÝ KẾT QUẢ HỌC TẬP SINH VIÊN";

            // lblPhuDe
            this.lblPhuDe.AutoSize = true;
            this.lblPhuDe.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
            this.lblPhuDe.ForeColor = System.Drawing.Color.FromArgb(237, 242, 244);
            this.lblPhuDe.Location = new System.Drawing.Point(24, 43);
            this.lblPhuDe.Name = "lblPhuDe";
            this.lblPhuDe.Size = new System.Drawing.Size(415, 17);
            this.lblPhuDe.Text = "Học phần COMP1019 - Data Binding, Stored Procedure & Transaction";

            // pnlLeft
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.Controls.Add(this.pnlThongKe);
            this.pnlLeft.Controls.Add(this.btnLamMoi);
            this.pnlLeft.Controls.Add(this.btnLuuTatCa);
            this.pnlLeft.Controls.Add(this.btnTaiDanhSach);
            this.pnlLeft.Controls.Add(this.cboMonHoc);
            this.pnlLeft.Controls.Add(this.lblChonMon);
            this.pnlLeft.Controls.Add(this.cboLop);
            this.pnlLeft.Controls.Add(this.lblChonLop);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 72);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(16);
            this.pnlLeft.Size = new System.Drawing.Size(270, 506);
            this.pnlLeft.TabIndex = 1;

            // lblChonLop
            this.lblChonLop.AutoSize = true;
            this.lblChonLop.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblChonLop.ForeColor = System.Drawing.Color.FromArgb(43, 45, 66);
            this.lblChonLop.Location = new System.Drawing.Point(18, 18);
            this.lblChonLop.Name = "lblChonLop";
            this.lblChonLop.Size = new System.Drawing.Size(115, 19);
            this.lblChonLop.Text = "Chọn lớp học:";

            // cboLop
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(18, 42);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(232, 25);
            this.cboLop.TabIndex = 0;

            // lblChonMon
            this.lblChonMon.AutoSize = true;
            this.lblChonMon.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblChonMon.ForeColor = System.Drawing.Color.FromArgb(43, 45, 66);
            this.lblChonMon.Location = new System.Drawing.Point(18, 84);
            this.lblChonMon.Name = "lblChonMon";
            this.lblChonMon.Size = new System.Drawing.Size(120, 19);
            this.lblChonMon.Text = "Chọn môn học:";

            // cboMonHoc
            this.cboMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboMonHoc.FormattingEnabled = true;
            this.cboMonHoc.Location = new System.Drawing.Point(18, 108);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(232, 25);
            this.cboMonHoc.TabIndex = 1;

            // btnTaiDanhSach
            this.btnTaiDanhSach.BackColor = System.Drawing.Color.FromArgb(58, 134, 255);
            this.btnTaiDanhSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaiDanhSach.FlatAppearance.BorderSize = 0;
            this.btnTaiDanhSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiDanhSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTaiDanhSach.ForeColor = System.Drawing.Color.White;
            this.btnTaiDanhSach.Location = new System.Drawing.Point(18, 156);
            this.btnTaiDanhSach.Name = "btnTaiDanhSach";
            this.btnTaiDanhSach.Size = new System.Drawing.Size(232, 42);
            this.btnTaiDanhSach.TabIndex = 2;
            this.btnTaiDanhSach.Text = "Tải danh sách";
            this.btnTaiDanhSach.UseVisualStyleBackColor = false;
            this.btnTaiDanhSach.Click += new System.EventHandler(this.btnTaiDanhSach_Click);

            // btnLuuTatCa
            this.btnLuuTatCa.BackColor = System.Drawing.Color.FromArgb(46, 196, 182);
            this.btnLuuTatCa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuTatCa.FlatAppearance.BorderSize = 0;
            this.btnLuuTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuTatCa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuuTatCa.ForeColor = System.Drawing.Color.White;
            this.btnLuuTatCa.Location = new System.Drawing.Point(18, 210);
            this.btnLuuTatCa.Name = "btnLuuTatCa";
            this.btnLuuTatCa.Size = new System.Drawing.Size(232, 42);
            this.btnLuuTatCa.TabIndex = 3;
            this.btnLuuTatCa.Text = "Lưu tất cả (Transaction)";
            this.btnLuuTatCa.UseVisualStyleBackColor = false;
            this.btnLuuTatCa.Click += new System.EventHandler(this.btnLuuTatCa_Click);

            // btnLamMoi
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(141, 153, 174);
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(18, 264);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(232, 38);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm mới dữ liệu";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            // pnlThongKe
            this.pnlThongKe.BackColor = System.Drawing.Color.FromArgb(237, 242, 244);
            this.pnlThongKe.Controls.Add(this.lblQuaMon);
            this.pnlThongKe.Controls.Add(this.lblDiemTB);
            this.pnlThongKe.Controls.Add(this.lblSiSo);
            this.pnlThongKe.Controls.Add(this.lblTieuDeThongKe);
            this.pnlThongKe.Location = new System.Drawing.Point(18, 325);
            this.pnlThongKe.Name = "pnlThongKe";
            this.pnlThongKe.Size = new System.Drawing.Size(232, 150);
            this.pnlThongKe.TabIndex = 5;

            // lblTieuDeThongKe
            this.lblTieuDeThongKe.AutoSize = true;
            this.lblTieuDeThongKe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTieuDeThongKe.ForeColor = System.Drawing.Color.FromArgb(43, 45, 66);
            this.lblTieuDeThongKe.Location = new System.Drawing.Point(14, 12);
            this.lblTieuDeThongKe.Name = "lblTieuDeThongKe";
            this.lblTieuDeThongKe.Size = new System.Drawing.Size(145, 19);
            this.lblTieuDeThongKe.Text = "THỐNG KÊ NHANH";

            // lblSiSo
            this.lblSiSo.AutoSize = true;
            this.lblSiSo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSiSo.ForeColor = System.Drawing.Color.FromArgb(43, 45, 66);
            this.lblSiSo.Location = new System.Drawing.Point(14, 44);
            this.lblSiSo.Name = "lblSiSo";
            this.lblSiSo.Size = new System.Drawing.Size(65, 17);
            this.lblSiSo.Text = "Sĩ số: 0 SV";

            // lblDiemTB
            this.lblDiemTB.AutoSize = true;
            this.lblDiemTB.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDiemTB.ForeColor = System.Drawing.Color.FromArgb(217, 4, 41);
            this.lblDiemTB.Location = new System.Drawing.Point(14, 76);
            this.lblDiemTB.Name = "lblDiemTB";
            this.lblDiemTB.Size = new System.Drawing.Size(88, 17);
            this.lblDiemTB.Text = "Điểm TB: 0.00";

            // lblQuaMon
            this.lblQuaMon.AutoSize = true;
            this.lblQuaMon.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblQuaMon.ForeColor = System.Drawing.Color.FromArgb(43, 45, 66);
            this.lblQuaMon.Location = new System.Drawing.Point(14, 108);
            this.lblQuaMon.Name = "lblQuaMon";
            this.lblQuaMon.Size = new System.Drawing.Size(85, 17);
            this.lblQuaMon.Text = "Qua môn: 0/0";

            // pnlRight
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.pnlRight.Controls.Add(this.dgvKetQua);
            this.pnlRight.Controls.Add(this.pnlSearch);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(270, 72);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(16);
            this.pnlRight.Size = new System.Drawing.Size(710, 506);
            this.pnlRight.TabIndex = 2;

            // pnlSearch
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.Controls.Add(this.txtTimKiem);
            this.pnlSearch.Controls.Add(this.lblTimKiem);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(16, 16);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(678, 50);
            this.pnlSearch.TabIndex = 0;

            // lblTimKiem
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblTimKiem.ForeColor = System.Drawing.Color.FromArgb(43, 45, 66);
            this.lblTimKiem.Location = new System.Drawing.Point(14, 15);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(172, 19);
            this.lblTimKiem.Text = "Tìm nhanh (Mã / Họ tên):";

            // txtTimKiem
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimKiem.Location = new System.Drawing.Point(195, 12);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(465, 25);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);

            // dgvKetQua
            this.dgvKetQua.AllowUserToAddRows = false;
            this.dgvKetQua.AllowUserToDeleteRows = false;
            this.dgvKetQua.BackgroundColor = System.Drawing.Color.White;
            this.dgvKetQua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKetQua.Location = new System.Drawing.Point(16, 66);
            this.dgvKetQua.MultiSelect = false;
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.RowHeadersVisible = false;
            this.dgvKetQua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKetQua.Size = new System.Drawing.Size(678, 424);
            this.dgvKetQua.TabIndex = 1;
            this.dgvKetQua.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKetQua_CellEndEdit);

            // statusStrip1
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(237, 242, 244);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTrangThai});
            this.statusStrip1.Location = new System.Drawing.Point(0, 578);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(980, 24);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";

            // lblTrangThai
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTrangThai.ForeColor = System.Drawing.Color.FromArgb(43, 45, 66);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(130, 19);
            this.lblTrangThai.Text = "Trạng thái hệ thống";

            // FrmNhapDiemTheoLop
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.ClientSize = new System.Drawing.Size(980, 602);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(880, 560);
            this.Name = "FrmNhapDiemTheoLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài Lab 12 - Quản lý điểm sinh viên theo lớp";
            this.Load += new System.EventHandler(this.FrmNhapDiemTheoLop_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlThongKe.ResumeLayout(false);
            this.pnlThongKe.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
