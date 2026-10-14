using System;
using System.Collections.Generic;
using System.Text;

namespace task2
{
    public class EntityStorage<T> where T : Entity
    {
        private List<T> _items = new List<T>();

        public void Add(T item)
        {
            _items.Add(item);
        }

        public T GetById(int id)
        {
            foreach (T item in _items)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        public List<T> GetAll()
        {
            return _items;
        }
    }
}