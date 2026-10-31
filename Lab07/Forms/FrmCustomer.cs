using System;
using System.ComponentModel;
using System.Windows.Forms;
using Lab07.Models;
using System.Linq;

namespace Lab07.Forms
{
    public partial class FrmCustomer : Form
    {
        private BindingList<Customer> listKH = new BindingList<Customer>();

        public FrmCustomer()
        {
            InitializeComponent();
            
            // Dữ liệu mẫu khách hàng
            listKH.Add(new Customer { MaKH = "KH01", HoTen = "Nguyễn Văn A", DienThoai = "0905123456", LoaiKH = "Thân thiết" });
            listKH.Add(new Customer { MaKH = "KH02", HoTen = "Trần Thị B", DienThoai = "0988765432", LoaiKH = "Mới" });
            
            dgvCustomer.DataSource = listKH;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Mã khách hàng và Họ tên không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listKH.Any(c => c.MaKH.Trim().ToLower() == txtMaKH.Text.Trim().ToLower()))
            {
                MessageBox.Show("Mã khách hàng đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            listKH.Add(new Customer
            {
                MaKH = txtMaKH.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                DienThoai = txtDienThoai.Text.Trim(),
                LoaiKH = txtLoaiKH.Text.Trim()
            });

            MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnReset_Click(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.CurrentRow != null && dgvCustomer.CurrentRow.Index >= 0)
            {
                string id = dgvCustomer.CurrentRow.Cells["MaKH"].Value.ToString();
                if (MessageBox.Show($"Bạn có muốn xóa khách hàng [{id}] không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var item = listKH.FirstOrDefault(c => c.MaKH == id);
                    if (item != null)
                    {
                        listKH.Remove(item);
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnReset_Click(null, null);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaKH.Clear();
            txtHoTen.Clear();
            txtDienThoai.Clear();
            txtLoaiKH.Clear();
            txtMaKH.ReadOnly = false;
            dgvCustomer.DataSource = listKH;
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCustomer.CurrentRow != null && e.RowIndex >= 0)
            {
                txtMaKH.Text = dgvCustomer.CurrentRow.Cells["MaKH"].Value?.ToString();
                txtHoTen.Text = dgvCustomer.CurrentRow.Cells["HoTen"].Value?.ToString();
                txtDienThoai.Text = dgvCustomer.CurrentRow.Cells["DienThoai"].Value?.ToString();
                txtLoaiKH.Text = dgvCustomer.CurrentRow.Cells["LoaiKH"].Value?.ToString();
                txtMaKH.ReadOnly = true;
            }
        }
    }
}