namespace Lab05
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            this.grpStudentInfo = new System.Windows.Forms.GroupBox();
            this.lblCharCount = new System.Windows.Forms.Label();
            this.chkReceiveEmail = new System.Windows.Forms.CheckBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpCourseInfo = new System.Windows.Forms.GroupBox();
            this.rdoOffline = new System.Windows.Forms.RadioButton();
            this.rdoOnline = new System.Windows.Forms.RadioButton();
            this.cboCourse = new System.Windows.Forms.ComboBox();
            this.nudDuration = new System.Windows.Forms.NumericUpDown();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblFee = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            this.grpStudentInfo.SuspendLayout();
            this.grpCourseInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(305, 32);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(385, 26);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG KÝ KHÓA HỌC NGẮN HẠN";
            // 
            // grpStudentInfo
            // 
            this.grpStudentInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpStudentInfo.Controls.Add(this.lblCharCount);
            this.grpStudentInfo.Controls.Add(this.chkReceiveEmail);
            this.grpStudentInfo.Controls.Add(this.dtpDateOfBirth);
            this.grpStudentInfo.Controls.Add(this.txtPhoneNumber);
            this.grpStudentInfo.Controls.Add(this.txtFullName);
            this.grpStudentInfo.Controls.Add(this.label4);
            this.grpStudentInfo.Controls.Add(this.label3);
            this.grpStudentInfo.Controls.Add(this.label2);
            this.grpStudentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStudentInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpStudentInfo.Location = new System.Drawing.Point(27, 79);
            this.grpStudentInfo.Name = "grpStudentInfo";
            this.grpStudentInfo.Size = new System.Drawing.Size(454, 373);
            this.grpStudentInfo.TabIndex = 1;
            this.grpStudentInfo.TabStop = false;
            this.grpStudentInfo.Text = "Thông Tin Học Viên";
            // 
            // lblCharCount
            // 
            this.lblCharCount.AutoSize = true;
            this.lblCharCount.Location = new System.Drawing.Point(408, 79);
            this.lblCharCount.Name = "lblCharCount";
            this.lblCharCount.Size = new System.Drawing.Size(40, 18);
            this.lblCharCount.TabIndex = 7;
            this.lblCharCount.Text = "0/50";
            // 
            // chkReceiveEmail
            // 
            this.chkReceiveEmail.AutoSize = true;
            this.chkReceiveEmail.Location = new System.Drawing.Point(31, 276);
            this.chkReceiveEmail.Name = "chkReceiveEmail";
            this.chkReceiveEmail.Size = new System.Drawing.Size(203, 22);
            this.chkReceiveEmail.TabIndex = 6;
            this.chkReceiveEmail.Text = "Nhận Email Thông Báo";
            this.chkReceiveEmail.UseVisualStyleBackColor = true;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(152, 206);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(245, 24);
            this.dtpDateOfBirth.TabIndex = 5;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(152, 147);
            this.txtPhoneNumber.MaxLength = 13;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(245, 24);
            this.txtPhoneNumber.TabIndex = 4;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(152, 79);
            this.txtFullName.MaxLength = 50;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(245, 24);
            this.txtFullName.TabIndex = 3;
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Năm Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số Điện Thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ Tên";
            // 
            // grpCourseInfo
            // 
            this.grpCourseInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpCourseInfo.Controls.Add(this.rdoOffline);
            this.grpCourseInfo.Controls.Add(this.rdoOnline);
            this.grpCourseInfo.Controls.Add(this.cboCourse);
            this.grpCourseInfo.Controls.Add(this.nudDuration);
            this.grpCourseInfo.Controls.Add(this.lblTotal);
            this.grpCourseInfo.Controls.Add(this.lblFee);
            this.grpCourseInfo.Controls.Add(this.label9);
            this.grpCourseInfo.Controls.Add(this.label8);
            this.grpCourseInfo.Controls.Add(this.label7);
            this.grpCourseInfo.Controls.Add(this.label6);
            this.grpCourseInfo.Controls.Add(this.label5);
            this.grpCourseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCourseInfo.Location = new System.Drawing.Point(534, 79);
            this.grpCourseInfo.Name = "grpCourseInfo";
            this.grpCourseInfo.Size = new System.Drawing.Size(419, 373);
            this.grpCourseInfo.TabIndex = 0;
            this.grpCourseInfo.TabStop = false;
            this.grpCourseInfo.Text = "Thông TIn Khóa Học";
            // 
            // rdoOffline
            // 
            this.rdoOffline.AutoSize = true;
            this.rdoOffline.Location = new System.Drawing.Point(272, 149);
            this.rdoOffline.Name = "rdoOffline";
            this.rdoOffline.Size = new System.Drawing.Size(78, 22);
            this.rdoOffline.TabIndex = 12;
            this.rdoOffline.TabStop = true;
            this.rdoOffline.Text = "Offline";
            this.rdoOffline.UseVisualStyleBackColor = true;
            // 
            // rdoOnline
            // 
            this.rdoOnline.AutoSize = true;
            this.rdoOnline.Location = new System.Drawing.Point(154, 149);
            this.rdoOnline.Name = "rdoOnline";
            this.rdoOnline.Size = new System.Drawing.Size(77, 22);
            this.rdoOnline.TabIndex = 11;
            this.rdoOnline.TabStop = true;
            this.rdoOnline.Text = "Online";
            this.rdoOnline.UseVisualStyleBackColor = true;
            // 
            // cboCourse
            // 
            this.cboCourse.FormattingEnabled = true;
            this.cboCourse.Location = new System.Drawing.Point(154, 82);
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.Size = new System.Drawing.Size(228, 26);
            this.cboCourse.TabIndex = 10;
            this.cboCourse.SelectedIndexChanged += new System.EventHandler(this.cboCourse_SelectedIndexChanged);
            // 
            // nudDuration
            // 
            this.nudDuration.Location = new System.Drawing.Point(154, 206);
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(228, 24);
            this.nudDuration.TabIndex = 9;
            this.nudDuration.ValueChanged += new System.EventHandler(this.nudDuration_ValueChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblTotal.Location = new System.Drawing.Point(151, 300);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(138, 18);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "150.000.000 VND";
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Location = new System.Drawing.Point(151, 253);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(106, 18);
            this.lblFee.TabIndex = 5;
            this.lblFee.Text = "500.000 VND";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 18);
            this.label9.TabIndex = 4;
            this.label9.Text = "Học Phí";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tổng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Số Tháng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Hình Thức";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Khóa Học";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExit);
            this.groupBox3.Controls.Add(this.btnReset);
            this.groupBox3.Controls.Add(this.btnRegister);
            this.groupBox3.Location = new System.Drawing.Point(233, 467);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(516, 56);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(368, 15);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 29);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(205, 15);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(88, 29);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Làm Mới";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(38, 15);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(88, 29);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Đăng Ký";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 535);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpCourseInfo);
            this.Controls.Add(this.grpStudentInfo);
            this.Controls.Add(label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpStudentInfo.ResumeLayout(false);
            this.grpStudentInfo.PerformLayout();
            this.grpCourseInfo.ResumeLayout(false);
            this.grpCourseInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpStudentInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpCourseInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkReceiveEmail;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudDuration;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCharCount;
        private System.Windows.Forms.RadioButton rdoOffline;
        private System.Windows.Forms.RadioButton rdoOnline;
        private System.Windows.Forms.ComboBox cboCourse;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
    }
}

