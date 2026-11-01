using System;

namespace Lab4
{
    public class Product : IEntity
    {
        private string maSP;
        private string tenSP;
        private double price;
        private int quantity;

        public string Id
        {
            get { return maSP; }
        }

        public string MaSP
        {
            get { return maSP; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Mã sản phẩm không được để trống.");
                }
                maSP = value.Trim().ToUpper();
            }
        }

        public string TenSP
        {
            get { return tenSP; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Tên sản phẩm không được để trống.");
                }
                tenSP = value.Trim();
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Đơn giá không được nhận giá trị âm.");
                }
                price = value;
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Số lượng không được nhận giá trị âm.");
                }
                quantity = value;
            }
        }

        public Product()
        {
        }

        public Product(string maSP, string tenSP, double price, int quantity)
        {
            MaSP = maSP;
            TenSP = tenSP;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return string.Format("{0,-8} | {1,-24} | {2,12:N0} đ | {3,6} | {4,14:N0} đ",
                MaSP, TenSP, Price, Quantity, Price * Quantity);
        }
    }
}
