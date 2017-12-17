using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryServiceLogic
{
    public class Repository<T> : IRepository<T>
    {
        protected List<T> _items;

        public List<T> Data => _items ?? (_items = new List<T>());

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

    public class ShopTypeRepo : Repository<ShopType>
    {
        public ShopTypeRepo()
        {
            using (var context = new Context())
            {
                _items = context.ShopTypes.ToList();
            }
        }
    }

    public class ProductTypeRepo : Repository<ProductType>
    {
        public ProductTypeRepo()
        {
            using (var context = new Context())
            {
                _items = context.ProductTypes.ToList();
            }
        }
    }

    public class RepositoryCRUD<T> : Repository<T>, IRepositoryCRUD<T>
    {
        public virtual void AddItem(T item)
        {
            _items.Add(item);
        }

        public virtual void RemoveItem(T item)
        {
            _items.Remove(item);

        }
    }

    public class OrderedProductRepo : RepositoryCRUD<OrderedProduct>
    {
        public override void AddItem(OrderedProduct op)
        {
            Data.Add(op);
        }
        public override void RemoveItem(OrderedProduct op)
        {
            Data.Remove(op);
        }
    }

    public class OrderRepo : RepositoryCRUD<Order>
    { 
        public override void AddItem(Order ord)
        {
            using (var context = new Context())
                context.Set<Order>().Add(ord);
            Data.Add(ord);
        }
        public override void RemoveItem(Order ord)
        {
            using (var context = new Context())
                context.Set<Order>().Remove(ord);
            Data.Remove(ord);
        }
    }




}
