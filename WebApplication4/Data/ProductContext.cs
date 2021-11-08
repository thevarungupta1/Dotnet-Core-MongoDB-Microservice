using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Entities;

namespace WebApplication4.Data
{
    public class ProductContext : IProductContext
    {
        public ProductContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("DatebaseSettings:ConnectionString"));
            var database = client.GetDatabase(configuration.GetValue<string>("DatebaseSettings:DatabaseName"));

            Products =  database.GetCollection<Product>(configuration.GetValue<string>("DatebaseSettings:CollectionName"));
            ProductContextSeed.SeedData(Products);
        }

        public IMongoCollection<Product> Products { get;  }
    }
}
