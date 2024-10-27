using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Orders.Microservices.Models;

namespace Orders.Microservices.Data
{
    public class OrdersMicroservicesContext : DbContext
    {
        public OrdersMicroservicesContext (DbContextOptions<OrdersMicroservicesContext> options)
            : base(options)
        {
        }

        public DbSet<Orders.Microservices.Models.Order> Order { get; set; } = default!;
    }
}
