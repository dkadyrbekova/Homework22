using System;
using System.Collections.Generic;
using System.Text;

namespace task2
{
    
        public class Product : Entity
        {
            public string Name { get; set; }
            public decimal Price { get; set; }

        public Product() { }

        public Product(int id, string name, decimal price)
            {
                Id = id;
                Name = name;
                Price = price;
            }
        }
    }

