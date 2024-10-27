using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Product.Microservice.Models;

namespace Product.Microservice.Data
{
    public class ProductMicroserviceContext : DbContext
    {
        public ProductMicroserviceContext (DbContextOptions<ProductMicroserviceContext> options)
            : base(options)
        {
        }

        public DbSet<Product.Microservice.Models.ProductModel> ProductModel { get; set; } = default!;
    }
}
