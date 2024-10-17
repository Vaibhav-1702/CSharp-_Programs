using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review4
{
    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }

    public class GroupProduct
    {
        static void Main()
        {
            List<Product> products = new List<Product>
        {
            new Product { Name = "Laptop", Category = "Electronics", Price = 1000 },
            new Product { Name = "Phone", Category = "Electronics", Price = 700 },
            new Product { Name = "Mercedes", Category = "Cars", Price = 80000000 },
            new Product { Name = "BMW", Category = "Cars", Price = 2000000 }
        };

            var categoryGroups = products
                .GroupBy(p => p.Category)
                .Select(g => new
                {
                    Category = g.Key,
                    AveragePrice = g.Average(p => p.Price)
                });

            foreach (var group in categoryGroups)
            {
                Console.WriteLine($"Category: {group.Category}, Average Price: {group.AveragePrice:C}");
            }
        }
    }
}
