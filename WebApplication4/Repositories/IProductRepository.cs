using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Entities;

namespace WebApplication4.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(String id);
        //Task<IEnumerable<Product>> GetProductByName(string name);
        Task CreateProduct(Product product);
        Task<bool> DeleteProduct(string id);
        Task<bool> UpdateProduct(Product product);
    }
}
