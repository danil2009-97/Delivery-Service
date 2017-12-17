using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryServiceLogic
{
   public class Factory
    {
        private Factory() { }

        private static Factory _default;

        public static Factory Default
        {
            get
            {
                if (_default == null)
                    _default = new Factory();
                return _default;
            }
        }

        public IRepository<T> GetRepository<T>()
        {
            if (typeof(T) == typeof(Shop))
                return (IRepository<T>)new ShopRepository();
            else if (typeof(T) == typeof(Product))
                return (IRepository<T>)new ProductRepository();
            else if (typeof(T) == typeof(ShopType))
                return (IRepository<T>)new ShopTypeRepo();
            else if (typeof(T) == typeof(ProductType))
                return (IRepository<T>)new ProductTypeRepo();
            else
                throw new Exception("No repository");
        }
    }
}
