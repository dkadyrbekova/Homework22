using System;
using System.Collections.Generic;
using System.Text;

namespace task2
{
    public class ObjectFactory<T> where T : new()
    {
        public T Create()
        {
            return new T();
        }

        public List<T> CreateMany(int count)
        {
            List<T> result = new List<T>();
            for (int i = 0; i < count; i++)
            {
                result.Add(new T());
            }
            return result;
        }
    }
}