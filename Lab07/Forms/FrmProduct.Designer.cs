namespace Lab07.Forms
{
    partial class FrmProduct
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtLoaiSP;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.Label lbl1, lbl2, lbl3, lbl4, lbl5;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtLoaiSP = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.grpBox.SuspendLayout();
            this.SuspendLayout();
            
            // grpBox
            this.grpBox.Controls.Add(this.lbl5);
            this.grpBox.Controls.Add(this.lbl4);
            this.grpBox.Controls.Add(this.lbl3);
            this.grpBox.Controls.Add(this.lbl2);
            this.grpBox.Controls.Add(this.lbl1);
            this.grpBox.Controls.Add(this.btnSearch);
            this.grpBox.Controls.Add(this.txtSearch);
            this.grpBox.Controls.Add(this.btnReset);
            this.grpBox.Controls.Add(this.btnDelete);
            this.grpBox.Controls.Add(this.btnEdit);
            this.grpBox.Controls.Add(this.btnAdd);
            this.grpBox.Controls.Add(this.txtSoLuong);
            this.grpBox.Controls.Add(this.txtDonGia);
            this.grpBox.Controls.Add(this.txtLoaiSP);
            this.grpBox.Controls.Add(this.txtTenSP);
            this.grpBox.Controls.Add(this.txtMaSP);
            this.grpBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpBox.Location = new System.Drawing.Point(15, 15);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(775, 155);
            this.grpBox.TabIndex = 0;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Thông tin sản phẩm";
            
            // Labels
            this.lbl1.AutoSize = true; this.lbl1.Font = new System.Drawing.Font("Segoe UI", 9F); this.lbl1.Location = new System.Drawing.Point(15, 30); this.lbl1.Text = "Mã SP:";
            this.lbl2.AutoSize = true; this.lbl2.Font = new System.Drawing.Font("Segoe UI", 9F); this.lbl2.Location = new System.Drawing.Point(180, 30); this.lbl2.Text = "Tên SP:";
            this.lbl3.AutoSize = true; this.lbl3.Font = new System.Drawing.Font("Segoe UI", 9F); this.lbl3.Location = new System.Drawing.Point(390, 30); this.lbl3.Text = "Loại SP:";
            this.lbl4.AutoSize = true; this.lbl4.Font = new System.Drawing.Font("Segoe UI", 9F); this.lbl4.Location = new System.Drawing.Point(550, 30); this.lbl4.Text = "Đơn giá:";
            this.lbl5.AutoSize = true; this.lbl5.Font = new System.Drawing.Font("Segoe UI", 9F); this.lbl5.Location = new System.Drawing.Point(670, 30); this.lbl5.Text = "SL:";
            
            // TextBoxes
            this.txtMaSP.Font = new System.Drawing.Font("Segoe UI", 9.5F); this.txtMaSP.Location = new System.Drawing.Point(15, 52); this.txtMaSP.Size = new System.Drawing.Size(155, 27);
            this.txtTenSP.Font = new System.Drawing.Font("Segoe UI", 9.5F); this.txtTenSP.Location = new System.Drawing.Point(180, 52); this.txtTenSP.Size = new System.Drawing.Size(195, 27);
            this.txtLoaiSP.Font = new System.Drawing.Font("Segoe UI", 9.5F); this.txtLoaiSP.Location = new System.Drawing.Point(390, 52); this.txtLoaiSP.Size = new System.Drawing.Size(145, 27);
            this.txtDonGia.Font = new System.Drawing.Font("Segoe UI", 9.5F); this.txtDonGia.Location = new System.Drawing.Point(550, 52); this.txtDonGia.Size = new System.Drawing.Size(105, 27);
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 9.5F); this.txtSoLuong.Location = new System.Drawing.Point(670, 52); this.txtSoLuong.Size = new System.Drawing.Size(85, 27);
            
            // Buttons
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen; this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.btnAdd.ForeColor = System.Drawing.Color.White; this.btnAdd.Location = new System.Drawing.Point(15, 100); this.btnAdd.Size = new System.Drawing.Size(85, 35); this.btnAdd.Text = "Thêm"; this.btnAdd.UseVisualStyleBackColor = false; this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnEdit.BackColor = System.Drawing.Color.DarkCyan; this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.btnEdit.ForeColor = System.Drawing.Color.White; this.btnEdit.Location = new System.Drawing.Point(110, 100); this.btnEdit.Size = new System.Drawing.Size(85, 35); this.btnEdit.Text = "Sửa"; this.btnEdit.UseVisualStyleBackColor = false; this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnDelete.BackColor = System.Drawing.Color.Firebrick; this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.btnDelete.ForeColor = System.Drawing.Color.White; this.btnDelete.Location = new System.Drawing.Point(205, 100); this.btnDelete.Size = new System.Drawing.Size(85, 35); this.btnDelete.Text = "Xóa"; this.btnDelete.UseVisualStyleBackColor = false; this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnReset.BackColor = System.Drawing.Color.DimGray; this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.btnReset.ForeColor = System.Drawing.Color.White; this.btnReset.Location = new System.Drawing.Point(300, 100); this.btnReset.Size = new System.Drawing.Size(95, 35); this.btnReset.Text = "Làm mới"; this.btnReset.UseVisualStyleBackColor = false; this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            
            // Search
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F); this.txtSearch.Location = new System.Drawing.Point(430, 104); this.txtSearch.PlaceholderText = "Tìm kiếm SP..."; this.txtSearch.Size = new System.Drawing.Size(220, 27);
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue; this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.btnSearch.ForeColor = System.Drawing.Color.White; this.btnSearch.Location = new System.Drawing.Point(660, 100); this.btnSearch.Size = new System.Drawing.Size(95, 35); this.btnSearch.Text = "Tìm kiếm"; this.btnSearch.UseVisualStyleBackColor = false; this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            
            // dgvProduct
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(15, 185);
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(775, 260);
            this.dgvProduct.TabIndex = 1;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            
            // FrmProduct
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(805, 465);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.grpBox);
            this.Name = "FrmProduct";
            this.Text = "Quản lý sản phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}