namespace Lab07.Forms
{
    partial class FrmCustomer
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtLoaiKH;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.Label l1, l2, l3, l4;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtLoaiKH = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.grpBox.SuspendLayout();
            this.SuspendLayout();
            
            // grpBox
            this.grpBox.Controls.Add(this.l4);
            this.grpBox.Controls.Add(this.l3);
            this.grpBox.Controls.Add(this.l2);
            this.grpBox.Controls.Add(this.l1);
            this.grpBox.Controls.Add(this.btnReset);
            this.grpBox.Controls.Add(this.btnDelete);
            this.grpBox.Controls.Add(this.btnAdd);
            this.grpBox.Controls.Add(this.txtLoaiKH);
            this.grpBox.Controls.Add(this.txtDienThoai);
            this.grpBox.Controls.Add(this.txtHoTen);
            this.grpBox.Controls.Add(this.txtMaKH);
            this.grpBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpBox.Location = new System.Drawing.Point(15, 15);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(695, 155);
            this.grpBox.TabIndex = 0;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Thông tin khách hàng";
            
            // Labels
            this.l1.AutoSize = true; this.l1.Font = new System.Drawing.Font("Segoe UI", 9F); this.l1.Location = new System.Drawing.Point(15, 30); this.l1.Text = "Mã KH:";
            this.l2.AutoSize = true; this.l2.Font = new System.Drawing.Font("Segoe UI", 9F); this.l2.Location = new System.Drawing.Point(180, 30); this.l2.Text = "Họ tên:";
            this.l3.AutoSize = true; this.l3.Font = new System.Drawing.Font("Segoe UI", 9F); this.l3.Location = new System.Drawing.Point(390, 30); this.l3.Text = "Điện thoại:";
            this.l4.AutoSize = true; this.l4.Font = new System.Drawing.Font("Segoe UI", 9F); this.l4.Location = new System.Drawing.Point(545, 30); this.l4.Text = "Loại KH:";
            
            // TextBoxes
            this.txtMaKH.Font = new System.Drawing.Font("Segoe UI", 9.5F); this.txtMaKH.Location = new System.Drawing.Point(15, 52); this.txtMaKH.Size = new System.Drawing.Size(155, 27);
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9.5F); this.txtHoTen.Location = new System.Drawing.Point(180, 52); this.txtHoTen.Size = new System.Drawing.Size(195, 27);
            this.txtDienThoai.Font = new System.Drawing.Font("Segoe UI", 9.5F); this.txtDienThoai.Location = new System.Drawing.Point(390, 52); this.txtDienThoai.Size = new System.Drawing.Size(140, 27);
            this.txtLoaiKH.Font = new System.Drawing.Font("Segoe UI", 9.5F); this.txtLoaiKH.Location = new System.Drawing.Point(545, 52); this.txtLoaiKH.Size = new System.Drawing.Size(130, 27);
            
            // Buttons
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen; this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.btnAdd.ForeColor = System.Drawing.Color.White; this.btnAdd.Location = new System.Drawing.Point(15, 100); this.btnAdd.Size = new System.Drawing.Size(100, 35); this.btnAdd.Text = "Thêm"; this.btnAdd.UseVisualStyleBackColor = false; this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnDelete.BackColor = System.Drawing.Color.Firebrick; this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.btnDelete.ForeColor = System.Drawing.Color.White; this.btnDelete.Location = new System.Drawing.Point(130, 100); this.btnDelete.Size = new System.Drawing.Size(100, 35); this.btnDelete.Text = "Xóa"; this.btnDelete.UseVisualStyleBackColor = false; this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnReset.BackColor = System.Drawing.Color.DimGray; this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.btnReset.ForeColor = System.Drawing.Color.White; this.btnReset.Location = new System.Drawing.Point(245, 100); this.btnReset.Size = new System.Drawing.Size(110, 35); this.btnReset.Text = "Làm mới"; this.btnReset.UseVisualStyleBackColor = false; this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            
            // dgvCustomer
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(15, 185);
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(695, 260);
            this.dgvCustomer.TabIndex = 1;
            this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellClick);
            
            // FrmCustomer
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(725, 465);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.grpBox);
            this.Name = "FrmCustomer";
            this.Text = "Quản lý khách hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}