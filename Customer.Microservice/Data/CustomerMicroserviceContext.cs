using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Customer.Microservice.Models;

namespace Customer.Microservice.Data
{
    public class CustomerMicroserviceContext : DbContext
    {
        public CustomerMicroserviceContext (DbContextOptions<CustomerMicroserviceContext> options)
            : base(options)
        {
        }

        public DbSet<Customer.Microservice.Models.CustomerModel> Customer { get; set; } = default!;
    }
}
