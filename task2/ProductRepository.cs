using System;
using System.Collections.Generic;
using System.Text;

namespace task2
{
    public class ProductRepository : Repository<Product>
    {
        public List<Product> GetCheaperThan(decimal maxPrice)
        {
            List<Product> result = new List<Product>();
            foreach (Product product in _items)
            {
                if (product.Price < maxPrice)
                {
                    result.Add(product);
                }
            }
            return result;
        }
    }
}