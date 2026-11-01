using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using QuanLySinhVienMVP.Models;
using QuanLySinhVienMVP.Presenters;
using QuanLySinhVienMVP.Repositories;

namespace QuanLySinhVienMVP.Views
{
    public partial class FrmStudent : Form, IStudentView
    {
        private readonly StudentPresenter _presenter;

        public FrmStudent()
        {
            InitializeComponent();
            IStudentRepository repository = new StudentRepository();
            _presenter = new StudentPresenter(this, repository);
        }

        public string StudentId
        {
            get { return txtStudentId.Text; }
            set { txtStudentId.Text = value; }
        }

        public string FullName
        {
            get { return txtFullName.Text; }
            set { txtFullName.Text = value; }
        }

        public string ClassName
        {
            get { return cboClassName.Text; }
            set { cboClassName.Text = value; }
        }

        public string ScoreText
        {
            get { return txtScore.Text; }
            set { txtScore.Text = value; }
        }

        public string SearchKeyword
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            TrangTriGiaoDien();
            if (cboClassName.Items.Count > 0)
            {
                cboClassName.SelectedIndex = 0;
            }
            _presenter.LoadStudents();
        }

        private void TrangTriGiaoDien()
        {
            BoGocControl(pnlNhapLieu, 14);
            BoGocControl(pnlTimKiem, 12);
            BoGocControl(pnlThongBao, 8);

            BoGocControl(pnlBadgeTong, 10);
            BoGocControl(pnlBadgeDat, 10);
            BoGocControl(pnlBadgeDiemTB, 10);

            BoGocControl(btnAdd, 12);
            BoGocControl(btnDelete, 12);
            BoGocControl(btnClear, 12);
            BoGocControl(btnLoad, 12);
            BoGocControl(btnSearch, 10);

            dgvStudents.EnableHeadersVisualStyles = false;
            dgvStudents.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 118, 110);
            dgvStudents.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvStudents.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvStudents.ColumnHeadersHeight = 34;

            dgvStudents.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgvStudents.DefaultCellStyle.SelectionBackColor = Color.FromArgb(204, 251, 241);
            dgvStudents.DefaultCellStyle.SelectionForeColor = Color.FromArgb(19, 78, 74);
            dgvStudents.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 253, 250);
            dgvStudents.RowTemplate.Height = 25;
            dgvStudents.GridColor = Color.FromArgb(203, 213, 225);
        }

        private void BoGocControl(Control ctrl, int banKinh)
        {
            GraphicsPath path = TaoDuongBoGoc(ctrl.ClientRectangle, banKinh);
            ctrl.Region = new Region(path);
            ctrl.Paint += (s, e) =>
            {
                if (ctrl.Parent == null) return;
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (GraphicsPath gp = TaoDuongBoGoc(new Rectangle(0, 0, ctrl.Width - 1, ctrl.Height - 1), banKinh))
                using (Region mask = new Region(ctrl.ClientRectangle))
                {
                    mask.Exclude(gp);
                    using (SolidBrush parentBrush = new SolidBrush(ctrl.Parent.BackColor))
                    {
                        e.Graphics.FillRegion(parentBrush, mask);
                    }
                    using (Pen smoothPen = new Pen(ctrl.Parent.BackColor, 1.5f))
                    {
                        e.Graphics.DrawPath(smoothPen, gp);
                    }
                }
            };
        }

        private GraphicsPath TaoDuongBoGoc(Rectangle rect, int banKinh)
        {
            GraphicsPath path = new GraphicsPath();
            int d = banKinh * 2;
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        public void DisplayStudents(List<Student> students)
        {
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = students;

            if (dgvStudents.Columns["StudentId"] != null)
                dgvStudents.Columns["StudentId"].HeaderText = "Mã sinh viên";
            if (dgvStudents.Columns["FullName"] != null)
                dgvStudents.Columns["FullName"].HeaderText = "Họ và tên";
            if (dgvStudents.Columns["ClassName"] != null)
                dgvStudents.Columns["ClassName"].HeaderText = "Lớp học";
            if (dgvStudents.Columns["Score"] != null)
                dgvStudents.Columns["Score"].HeaderText = "Điểm TB";
            if (dgvStudents.Columns["AcademicRank"] != null)
                dgvStudents.Columns["AcademicRank"].HeaderText = "Xếp loại";
            if (dgvStudents.Columns["Status"] != null)
                dgvStudents.Columns["Status"].HeaderText = "Kết quả";
        }

        public void ShowMessage(string message, string title, bool isError)
        {
            lblThongBao.Text = message;
            tslTrangThai.Text = title + ": " + message;

            if (isError)
            {
                pnlThongBao.BackColor = Color.FromArgb(254, 226, 226);
                lblThongBao.ForeColor = Color.FromArgb(185, 28, 28);
                MessageBox.Show(this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                pnlThongBao.BackColor = Color.FromArgb(209, 250, 229);
                lblThongBao.ForeColor = Color.FromArgb(6, 95, 70);
                MessageBox.Show(this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ClearInputs()
        {
            txtStudentId.Clear();
            txtFullName.Clear();
            txtScore.Clear();
            txtSearch.Clear();
            if (cboClassName.Items.Count > 0)
            {
                cboClassName.SelectedIndex = 0;
            }
            txtStudentId.Focus();
        }

        public void UpdateSummary(int totalStudents, int passedStudents, double averageScore)
        {
            lblGiaTriTong.Text = totalStudents.ToString();
            lblGiaTriDat.Text = passedStudents.ToString();
            lblGiaTriDiemTB.Text = averageScore.ToString("0.00");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _presenter.AddStudent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _presenter.DeleteStudent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _presenter.SearchStudents();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            _presenter.LoadStudents();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _presenter.ResetForm();
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvStudents.Rows.Count)
                return;

            Student svChon = dgvStudents.Rows[e.RowIndex].DataBoundItem as Student;
            _presenter.SelectStudent(svChon);
        }
    }
}
