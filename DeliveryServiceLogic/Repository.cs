using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryServiceLogic
{
    public class Repository<T> : IRepository<T>
    {
        protected List<T> _items = new List<T>();

        public IEnumerable<T> Data => _items;

        public IEnumerable<T> FindAll(Predicate<T> predicate)
        {
            return _items.FindAll(predicate);
        }
    }

    public class ShopRepository : Repository<Shop>
    {
        public ShopRepository()
        {
            using (var context = new Context())
            {
                _items = context.Shops.Include("Products").Include("Type").Include("Products.Type").ToList();
            }
        }
    }

    public class ProductRepository : Repository<Product>
    {
        public ProductRepository()
        {
            using (var context = new Context())
            {
                _items = context.Products.Include("Type").ToList();
            }
        }
    }
}
