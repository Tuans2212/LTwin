namespace Lab01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>s
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtHoTen = new TextBox();
            txtNamSinh = new TextBox();
            txtEmail = new TextBox();
            rbNam = new RadioButton();
            rbNu = new RadioButton();
            cboKhoa = new ComboBox();
            btnHienThi = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            lblTuoi = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.AccessibleName = "txtHoTen";
            txtHoTen.Location = new Point(106, 30);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(288, 23);
            txtHoTen.TabIndex = 0;
            txtHoTen.TextChanged += txtHoTen_TextChanged;
            // 
            // txtNamSinh
            // 
            txtNamSinh.AccessibleName = "txtNamSinh";
            txtNamSinh.Location = new Point(106, 122);
            txtNamSinh.Name = "txtNamSinh";
            txtNamSinh.Size = new Size(100, 23);
            txtNamSinh.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.AccessibleName = "txtEmail";
            txtEmail.Location = new Point(106, 78);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(288, 23);
            txtEmail.TabIndex = 2;
            // 
            // rbNam
            // 
            rbNam.AccessibleName = "radNam";
            rbNam.AutoSize = true;
            rbNam.Location = new Point(6, 22);
            rbNam.Name = "rbNam";
            rbNam.Size = new Size(51, 19);
            rbNam.TabIndex = 4;
            rbNam.TabStop = true;
            rbNam.Text = "Nam";
            rbNam.UseVisualStyleBackColor = true;
            rbNam.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rbNu
            // 
            rbNu.AccessibleName = "radnu";
            rbNu.AutoSize = true;
            rbNu.Location = new Point(153, 22);
            rbNu.Name = "rbNu";
            rbNu.Size = new Size(41, 19);
            rbNu.TabIndex = 5;
            rbNu.TabStop = true;
            rbNu.Text = "Nữ";
            rbNu.UseVisualStyleBackColor = true;
            // 
            // cboKhoa
            // 
            cboKhoa.AccessibleName = "cboKhoa";
            cboKhoa.FormattingEnabled = true;
            cboKhoa.Location = new Point(106, 172);
            cboKhoa.Name = "cboKhoa";
            cboKhoa.Size = new Size(288, 23);
            cboKhoa.TabIndex = 6;
            cboKhoa.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnHienThi
            // 
            btnHienThi.AccessibleName = "bthHienThi";
            btnHienThi.Location = new Point(20, 313);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(75, 23);
            btnHienThi.TabIndex = 7;
            btnHienThi.Text = "Hiển Thị";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // btnXoa
            // 
            btnXoa.AccessibleName = "btnXoa";
            btnXoa.Location = new Point(166, 313);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.AccessibleName = "btnThoat";
            btnThoat.Location = new Point(319, 313);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // label1
            // 
            label1.AccessibleName = "lblTitle";
            label1.AutoSize = true;
            label1.Location = new Point(214, 9);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 10;
            label1.Text = "Thông Tin Sinh Viên";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbNam);
            groupBox1.Controls.Add(rbNu);
            groupBox1.Location = new Point(25, 217);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(369, 68);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giới Tính";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 33);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 12;
            label2.Text = "Họ Và Tên ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 81);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 13;
            label3.Text = "Email";
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 175);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 15;
            label5.Text = "Khoa";
            // 
            // lblTuoi
            // 
            lblTuoi.AutoSize = true;
            lblTuoi.Location = new Point(33, 125);
            lblTuoi.Name = "lblTuoi";
            lblTuoi.Size = new Size(59, 15);
            lblTuoi.TabIndex = 16;
            lblTuoi.Text = "Năm Sinh";
            lblTuoi.Click += lbl_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 125);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 17;
            label4.Text = "Năm Sinh";
            // 
            // Form1
            // 
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(lblTuoi);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnHienThi);
            Controls.Add(cboKhoa);
            Controls.Add(txtEmail);
            Controls.Add(txtNamSinh);
            Controls.Add(txtHoTen);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoTen;
        private TextBox txtNamSinh;
        private TextBox txtEmail;
        private RadioButton rbNam;
        private RadioButton rbNu;
        private ComboBox cboKhoa;
        private Button btnHienThi;
        private Button btnXoa;
        private Button btnThoat;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label lblTuoi;
        private Label label4;
    }
}
