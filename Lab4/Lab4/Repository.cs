using System;
using System.Collections.Generic;

namespace Lab4
{
    public class Repository<T> where T : IEntity
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public bool Remove(string id)
        {
            T canXoa = FindById(id);
            if (canXoa != null)
            {
                items.Remove(canXoa);
                return true;
            }
            return false;
        }

        public T FindById(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return default(T);
            }

            foreach (T item in items)
            {
                if (string.Equals(item.Id, id.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    return item;
                }
            }
            return default(T);
        }

        public List<T> Find(Func<T, bool> predicate)
        {
            List<T> ketQua = new List<T>();
            foreach (T item in items)
            {
                if (predicate(item))
                {
                    ketQua.Add(item);
                }
            }
            return ketQua;
        }

        public List<T> GetAll()
        {
            return new List<T>(items);
        }
    }
}
