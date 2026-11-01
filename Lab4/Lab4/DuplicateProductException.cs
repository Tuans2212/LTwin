using System;

namespace Lab4
{
    public class DuplicateProductException : Exception
    {
        public DuplicateProductException(string message) : base(message)
        {
        }
    }
}
