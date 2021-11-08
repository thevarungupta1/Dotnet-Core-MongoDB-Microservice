using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using WebApplication4.Entities;

namespace WebApplication4.Data
{
    public interface IProductContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
