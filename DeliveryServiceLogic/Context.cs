using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryServiceLogic
{
    class Context : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<OrderedProduct> OrderedProducts { get; set; }

        public DbSet<Shop> Shops { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<ProductType> ProductTypes { get; set; }

        public DbSet<ShopType> ShopTypes { get; set; }

        public Context() : base("localsql") { }
    }
}
