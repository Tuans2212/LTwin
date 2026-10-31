using System;
using System.ComponentModel;
using System.Windows.Forms;
using Lab07.Models;
using System.Linq;

namespace Lab07.Forms
{
    public partial class FrmProduct : Form
    {
        private BindingList<Product> listSP = new BindingList<Product>();

        public FrmProduct()
        {
            InitializeComponent();
            
            // Thêm dữ liệu mẫu ban đầu để test
            listSP.Add(new Product { MaSP = "SP01", TenSP = "Bánh gạo An", LoaiSP = "Đồ ăn vặt", DonGia = 22000, SoLuong = 45 });
            listSP.Add(new Product { MaSP = "SP02", TenSP = "Nước suối Aquafina", LoaiSP = "Đồ uống", DonGia = 6000, SoLuong = 150 });
            listSP.Add(new Product { MaSP = "SP03", TenSP = "Mì Hảo Hảo chua cay", LoaiSP = "Thực phẩm", DonGia = 4500, SoLuong = 200 });
            
            dgvProduct.DataSource = listSP;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kiểm tra rỗng các trường bắt buộc
            if (string.IsNullOrWhiteSpace(txtMaSP.Text) || string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                MessageBox.Show("Mã sản phẩm và Tên sản phẩm không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trùng mã
            if (listSP.Any(p => p.MaSP.Trim().ToLower() == txtMaSP.Text.Trim().ToLower()))
            {
                MessageBox.Show("Mã sản phẩm này đã tồn tại!", "Lỗi trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate đơn giá
            decimal donGia;
            if (!decimal.TryParse(txtDonGia.Text, out donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá phải là số và lớn hơn hoặc bằng 0!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate số lượng
            int soLuong;
            if (!int.TryParse(txtSoLuong.Text, out soLuong) || soLuong < 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên không âm!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Thêm sản phẩm vào danh sách
            listSP.Add(new Product
            {
                MaSP = txtMaSP.Text.Trim(),
                TenSP = txtTenSP.Text.Trim(),
                LoaiSP = txtLoaiSP.Text.Trim(),
                DonGia = donGia,
                SoLuong = soLuong
            });

            MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnReset_Click(null, null);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProduct.CurrentRow != null && dgvProduct.CurrentRow.Index >= 0)
            {
                string id = dgvProduct.CurrentRow.Cells["MaSP"].Value.ToString();
                var prod = listSP.FirstOrDefault(x => x.MaSP == id);
                if (prod != null)
                {
                    decimal donGia;
                    if (!decimal.TryParse(txtDonGia.Text, out donGia) || donGia < 0)
                    {
                        MessageBox.Show("Đơn giá không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int soLuong;
                    if (!int.TryParse(txtSoLuong.Text, out soLuong) || soLuong < 0)
                    {
                        MessageBox.Show("Số lượng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    prod.TenSP = txtTenSP.Text.Trim();
                    prod.LoaiSP = txtLoaiSP.Text.Trim();
                    prod.DonGia = donGia;
                    prod.SoLuong = soLuong;

                    dgvProduct.Refresh();
                    MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng sản phẩm cần sửa trên bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProduct.CurrentRow != null && dgvProduct.CurrentRow.Index >= 0)
            {
                string id = dgvProduct.CurrentRow.Cells["MaSP"].Value.ToString();
                if (MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm [{id}] không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var item = listSP.FirstOrDefault(p => p.MaSP == id);
                    if (item != null)
                    {
                        listSP.Remove(item);
                        MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnReset_Click(null, null);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtLoaiSP.Clear();
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtSearch.Clear();
            txtMaSP.ReadOnly = false;
            dgvProduct.DataSource = listSP;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string key = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(key))
            {
                dgvProduct.DataSource = listSP;
                return;
            }

            var result = new BindingList<Product>(
                listSP.Where(p => p.TenSP.ToLower().Contains(key) || p.MaSP.ToLower().Contains(key)).ToList()
            );
            dgvProduct.DataSource = result;
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProduct.CurrentRow != null && e.RowIndex >= 0)
            {
                txtMaSP.Text = dgvProduct.CurrentRow.Cells["MaSP"].Value?.ToString();
                txtTenSP.Text = dgvProduct.CurrentRow.Cells["TenSP"].Value?.ToString();
                txtLoaiSP.Text = dgvProduct.CurrentRow.Cells["LoaiSP"].Value?.ToString();
                txtDonGia.Text = dgvProduct.CurrentRow.Cells["DonGia"].Value?.ToString();
                txtSoLuong.Text = dgvProduct.CurrentRow.Cells["SoLuong"].Value?.ToString();
                txtMaSP.ReadOnly = true; // Không cho sửa mã khi đang chỉnh sửa
            }
        }
    }
}