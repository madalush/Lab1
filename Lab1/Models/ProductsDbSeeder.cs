
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Lab1.Models
{
    public class ProductsDbSeeder
    {

        public static void Initialize(ProductsDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any product
            if (context.Products.Any())
            {
                return;   // DB has been seeded
            }

            context.Products.AddRange(
                new Product
                {
                    Name = "Huawei P10Lite",
                    Description = "White",
                    Category = "Huawei",
                    Price = 5.00
                }

            );
            context.SaveChanges();
        }
    }
}
