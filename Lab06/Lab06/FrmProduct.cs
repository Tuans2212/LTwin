using Lab06;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Lab06
{
    public partial class FrmProduct : Form
    {
        private BindingList<Product> products = new BindingList<Product>();
        private BindingSource productSource = new BindingSource();
        private string selectedImagePath = string.Empty;

        public FrmProduct()
        {
            InitializeComponent();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            cboLoaiSP.Items.AddRange(new object[] { "Điện tử", "Văn phòng", "Gia dụng", "Thời trang" });
            cboLoaiSP.SelectedIndex = 0;

            products.Add(new Product { MaSP = "SP01", TenSP = "Chuột không dây", LoaiSP = "Điện tử", DonGia = 150000, SoLuong = 20, NgayNhap = DateTime.Today, ConKinhDoanh = true });
            products.Add(new Product { MaSP = "SP02", TenSP = "Bút bi", LoaiSP = "Văn phòng", DonGia = 5000, SoLuong = 100, NgayNhap = DateTime.Today, ConKinhDoanh = true });
            products.Add(new Product { MaSP = "SP03", TenSP = "Nồi cơm điện", LoaiSP = "Gia dụng", DonGia = 450000, SoLuong = 10, NgayNhap = DateTime.Today, ConKinhDoanh = true });

            productSource.DataSource = products;
            dgvProducts.AutoGenerateColumns = true;
            dgvProducts.DataSource = productSource;
            dgvProducts.ReadOnly = true;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.MultiSelect = false;
            dgvProducts.AllowUserToAddRows = false;

            UpdateStatus("Sẵn sàng");
        }

        private bool ValidateInput(bool isEdit = false)
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                errorProvider1.SetError(txtMaSP, "Mã sản phẩm không được rỗng");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                errorProvider1.SetError(txtTenSP, "Tên sản phẩm không được rỗng");
                isValid = false;
            }

            if (numDonGia.Value <= 0)
            {
                errorProvider1.SetError(numDonGia, "Đơn giá phải lớn hơn 0");
                isValid = false;
            }

            if (dtpNgayNhap.Value.Date > DateTime.Today)
            {
                errorProvider1.SetError(dtpNgayNhap, "Ngày nhập không được lớn hơn hôm nay");
                isValid = false;
            }

            string ma = txtMaSP.Text.Trim();
            bool isDuplicate = products.Any(p => p.MaSP.Equals(ma, StringComparison.OrdinalIgnoreCase));
            if (!isEdit && isDuplicate)
            {
                errorProvider1.SetError(txtMaSP, "Mã sản phẩm đã tồn tại");
                isValid = false;
            }

            return isValid;
        }

        // Lấy sản phẩm đang được chọn trên DataGridView[cite: 5]
        private Product GetSelectedProduct()
        {
            if (productSource.Current == null)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            return productSource.Current as Product;
        }

        private void tsbThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            Product p = new Product
            {
                MaSP = txtMaSP.Text.Trim(),
                TenSP = txtTenSP.Text.Trim(),
                LoaiSP = cboLoaiSP.Text,
                DonGia = numDonGia.Value,
                SoLuong = (int)numSoLuong.Value,
                NgayNhap = dtpNgayNhap.Value.Date,
                ConKinhDoanh = chkConKinhDoanh.Checked,
                DuongDanAnh = selectedImagePath
            };

            products.Add(p);
            ClearInput();
            UpdateStatus("Đã thêm sản phẩm mới");
        }

        private void tsbSua_Click(object sender, EventArgs e)
        {
            Product p = GetSelectedProduct();
            if (p == null) return;

            if (!ValidateInput(isEdit: true)) return;

            p.TenSP = txtTenSP.Text.Trim();
            p.LoaiSP = cboLoaiSP.Text;
            p.DonGia = numDonGia.Value;
            p.SoLuong = (int)numSoLuong.Value;
            p.NgayNhap = dtpNgayNhap.Value.Date;
            p.ConKinhDoanh = chkConKinhDoanh.Checked;
            p.DuongDanAnh = selectedImagePath;

            // Cập nhật lại giao diện sau khi sửa dữ liệu object[cite: 6]
            productSource.ResetBindings(false);
            UpdateStatus("Đã cập nhật sản phẩm");
        }

        private void tsbXoa_Click(object sender, EventArgs e)
        {
            Product p = GetSelectedProduct();
            if (p == null) return;

            DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa sản phẩm {p.TenSP}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                products.Remove(p);
                ClearInput();
                UpdateStatus("Đã xóa sản phẩm");
            }
        }

        private void tsbLamMoi_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource = productSource;
            ClearInput();
            UpdateStatus("Đã làm mới dữ liệu");
        }

        private void tsbTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower();
            var result = products.Where(p => p.MaSP.ToLower().Contains(keyword) || p.TenSP.ToLower().Contains(keyword)).ToList();

            dgvProducts.DataSource = result;
            lblStatus.Text = $"Tìm thấy {result.Count} sản phẩm";
        }

        // Đưa dữ liệu từ dòng được chọn lên các control nhập liệu[cite: 6]
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Product p = productSource.Current as Product;
            if (p == null) return;

            txtMaSP.Text = p.MaSP;
            txtTenSP.Text = p.TenSP;
            cboLoaiSP.Text = p.LoaiSP;
            numDonGia.Value = p.DonGia;
            numSoLuong.Value = p.SoLuong;
            dtpNgayNhap.Value = p.NgayNhap;
            chkConKinhDoanh.Checked = p.ConKinhDoanh;
            selectedImagePath = p.DuongDanAnh;

            if (!string.IsNullOrWhiteSpace(p.DuongDanAnh) && File.Exists(p.DuongDanAnh))
                picSanPham.Image = Image.FromFile(p.DuongDanAnh);
            else
                picSanPham.Image = null;
        }

        // Mở hộp thoại chọn file ảnh từ máy tính[cite: 7]
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Chọn ảnh sản phẩm";
                dialog.Filter = "Image files *.jpg;*.jpeg;*.png;*.bmp|*.jpg;*.jpeg;*.png;*.bmp";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = dialog.FileName;
                    picSanPham.Image = Image.FromFile(selectedImagePath);
                    UpdateStatus("Đã chọn ảnh sản phẩm");
                }
            }
        }

        private void ClearInput()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            cboLoaiSP.SelectedIndex = 0;
            numDonGia.Value = 1;
            numSoLuong.Value = 0;
            dtpNgayNhap.Value = DateTime.Today;
            chkConKinhDoanh.Checked = true;
            txtTimKiem.Clear();
            picSanPham.Image = null;
            selectedImagePath = string.Empty;
            errorProvider1.Clear();
            txtMaSP.Focus();
        }

        private void UpdateStatus(string message)
        {
            lblStatus.Text = $"{message} | Số sản phẩm: {products.Count}";
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmsSua_Click(object sender, EventArgs e)
        {
            tsbSua.PerformClick();
        }

        private void cmsXoa_Click(object sender, EventArgs e)
        {
            tsbXoa.PerformClick();
        }

        private void cmsChiTiet_Click(object sender, EventArgs e)
        {
            Product p = GetSelectedProduct();
            if (p == null) return;
            MessageBox.Show($"Mã: {p.MaSP}\nTên: {p.TenSP}\nLoại: {p.LoaiSP}\nTổng tiền: {p.ThanhTien:N0}",
                "Chi tiết sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}