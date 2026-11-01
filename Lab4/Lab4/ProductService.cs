using System;
using System.Collections.Generic;

namespace Lab4
{
    public class ProductService
    {
        private Repository<Product> repository = new Repository<Product>();

        public event Action<string> OnProductChanged;

        public void AddProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentException("Dữ liệu sản phẩm không hợp lệ.");
            }

            Product daTonTai = repository.FindById(product.MaSP);
            if (daTonTai != null)
            {
                throw new DuplicateProductException("Mã sản phẩm '" + product.MaSP + "' đã tồn tại trong hệ thống.");
            }

            repository.Add(product);
            OnProductChanged?.Invoke("Đã thêm mới sản phẩm thành công: " + product.TenSP + " [" + product.MaSP + "]");
        }

        public void RemoveProduct(string maSP)
        {
            if (string.IsNullOrWhiteSpace(maSP))
            {
                throw new ArgumentException("Mã sản phẩm không được để trống.");
            }

            Product canXoa = repository.FindById(maSP);
            if (canXoa == null)
            {
                throw new ProductNotFoundException("Không tìm thấy sản phẩm có mã '" + maSP + "' để xóa.");
            }

            repository.Remove(maSP);
            OnProductChanged?.Invoke("Đã xóa thành công sản phẩm: " + canXoa.TenSP + " [" + canXoa.MaSP + "]");
        }

        public Product FindById(string maSP)
        {
            if (string.IsNullOrWhiteSpace(maSP))
            {
                throw new ArgumentException("Mã sản phẩm cần tìm không được để trống.");
            }

            Product sp = repository.FindById(maSP);
            if (sp == null)
            {
                throw new ProductNotFoundException("Không tìm thấy sản phẩm có mã '" + maSP + "'.");
            }

            return sp;
        }

        public List<Product> Search(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                return repository.GetAll();
            }

            string tuKhoa = keyword.Trim().ToLower();
            Func<Product, bool> condition = delegate (Product p)
            {
                return p.TenSP != null && p.TenSP.ToLower().Contains(tuKhoa);
            };

            return repository.Find(condition);
        }

        public List<Product> Filter(Func<Product, bool> condition)
        {
            return repository.Find(condition);
        }

        public List<Product> GetAll()
        {
            return repository.GetAll();
        }

        public double TinhTongGiaTriKho()
        {
            double tong = 0;
            List<Product> list = repository.GetAll();
            foreach (Product p in list)
            {
                tong += p.Price * p.Quantity;
            }
            return tong;
        }
    }
}
