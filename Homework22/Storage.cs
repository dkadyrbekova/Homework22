using System;
using System.Collections.Generic;
using System.Text;

namespace Homework22
{
    public class Storage<T>
    {
        private List<T> _items = new List<T>();
        public void Add(T item)
        {
            _items.Add(item);
        }
        public T GetByIndex(int index)
        {
            return _items[index];
        }
        public List<T> GetAll()
        {
            return _items;
        }
    }
}