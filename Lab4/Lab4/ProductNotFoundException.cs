using System;

namespace Lab4
{
    public class ProductNotFoundException : Exception
    {
        public ProductNotFoundException(string message) : base(message)
        {
        }
    }
}
