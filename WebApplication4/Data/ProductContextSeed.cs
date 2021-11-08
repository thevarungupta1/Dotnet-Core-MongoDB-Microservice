using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using WebApplication4.Entities;

namespace WebApplication4.Data
{
    public class ProductContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if(!existProduct)
            {
                productCollection.InsertManyAsync(GetPreconfiguredProducts());
            }
        }

        private static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f5",
                    Name = "Phone",
                    Description = "Phone description"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f6",
                    Name = "Laptop",
                    Description = "Laptop description"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f7",
                    Name = "Table",
                    Description = "Table description"
                },
            };
        }
    }
}
