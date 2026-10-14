using System;
using System.Collections.Generic;
using System.Text;
namespace task2
{
    public class Repository<T> where T : Entity
    {
        protected List<T> _items = new List<T>();

        public void Add(T item)
        {
            _items.Add(item);
        }

        public List<T> GetAll()
        {
            return _items;
        }
    }
}