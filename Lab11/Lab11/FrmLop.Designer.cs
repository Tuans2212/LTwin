namespace Lab11
{
    partial class FrmLop
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

        private void InitializeComponent()
        {
            lblMaLop = new Label();
            txtMaLop = new TextBox();
            lblTenLop = new Label();
            txtTenLop = new TextBox();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            dgvLop = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLop).BeginInit();
            SuspendLayout();
            // 
            // lblMaLop
            // 
            lblMaLop.AutoSize = true;
            lblMaLop.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblMaLop.Location = new Point(40, 70);
            lblMaLop.Name = "lblMaLop";
            lblMaLop.Size = new Size(67, 21);
            lblMaLop.TabIndex = 0;
            lblMaLop.Text = "Mã lớp:";
            // 
            // txtMaLop
            // 
            txtMaLop.Font = new Font("Segoe UI", 9.5F);
            txtMaLop.Location = new Point(110, 67);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(227, 29);
            txtMaLop.TabIndex = 1;
            // 
            // lblTenLop
            // 
            lblTenLop.AutoSize = true;
            lblTenLop.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTenLop.Location = new Point(376, 70);
            lblTenLop.Name = "lblTenLop";
            lblTenLop.Size = new Size(70, 21);
            lblTenLop.TabIndex = 2;
            lblTenLop.Text = "Tên lớp:";
            // 
            // txtTenLop
            // 
            txtTenLop.Font = new Font("Segoe UI", 9.5F);
            txtTenLop.Location = new Point(452, 67);
            txtTenLop.Name = "txtTenLop";
            txtTenLop.Size = new Size(220, 29);
            txtTenLop.TabIndex = 3;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 9.5F);
            txtTimKiem.Location = new Point(40, 115);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = " Nhập mã hoặc tên lớp để tìm...";
            txtTimKiem.Size = new Size(316, 29);
            txtTimKiem.TabIndex = 4;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(376, 112);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(85, 32);
            btnTimKiem.TabIndex = 5;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // dgvLop
            // 
            dgvLop.AllowUserToAddRows = false;
            dgvLop.AllowUserToDeleteRows = false;
            dgvLop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLop.Location = new Point(28, 227);
            dgvLop.Name = "dgvLop";
            dgvLop.ReadOnly = true;
            dgvLop.RowHeadersWidth = 51;
            dgvLop.RowTemplate.Height = 30;
            dgvLop.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLop.Size = new Size(662, 253);
            dgvLop.TabIndex = 6;
            dgvLop.CellClick += dgvLop_CellClick;
            dgvLop.CellContentClick += dgvLop_CellContentClick;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(28, 169);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(90, 38);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(210, 169);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(90, 38);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(414, 169);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(90, 38);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(600, 169);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(90, 38);
            btnLamMoi.TabIndex = 10;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(108, 92, 231);
            lblTitle.Location = new Point(190, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(257, 37);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "QUẢN LÝ LỚP HỌC";
            // 
            // FrmLop
            // 
            ClientSize = new Size(730, 511);
            Controls.Add(lblTitle);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dgvLop);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(txtTenLop);
            Controls.Add(lblTenLop);
            Controls.Add(txtMaLop);
            Controls.Add(lblMaLop);
            Name = "FrmLop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Lớp Học - SV Nguyễn Văn Tuấn";
            Load += FrmLop_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLop).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lblTitle;
    }
}