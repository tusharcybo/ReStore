using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Nike1",
                    Description = "asndaksdaksnd",
                    Price = 111200,
                    PictureUrl = "/images/products/Nike1.png",
                    Brand = "Nike",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Nike2",
                    Description = "asndaksdaksnd",
                    Price = 111200,
                    PictureUrl = "/images/products/Nike2.png",
                    Brand = "Nike",
                    Type = "Boots",
                    QuantityInStock = 20
                },
                new Product
                {
                    Name = "Nike3",
                    Description = "asndaksdaksnd",
                    Price = 111200,
                    PictureUrl = "/images/products/Nike3.png",
                    Brand = "Nike",
                    Type = "Boots",
                    QuantityInStock = 1
                }
            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();

        }
    }
}