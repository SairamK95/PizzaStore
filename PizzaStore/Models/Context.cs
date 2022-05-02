using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaStore.Models
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions options) : base(options) { }
        DbSet<Order> Orders     
        {
            get;
            set;
        }
    }
}
    