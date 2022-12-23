using ECommerceAPI.Application.Abstractions;
using ECommerceAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
        => new() 
        {
            new() { Id = Guid.NewGuid(),Name =" Laptop1",Price =100,Stock=10 },
            new() { Id = Guid.NewGuid(),Name =" Laptop2",Price =200,Stock=20 },
            new() { Id = Guid.NewGuid(),Name =" Laptop3",Price =150,Stock=15 },
            new() { Id = Guid.NewGuid(),Name =" Laptop4",Price =250,Stock=45 }
        };
    }
}
