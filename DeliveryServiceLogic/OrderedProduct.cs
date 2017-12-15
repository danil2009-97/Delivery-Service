using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryServiceLogic
{
    public class OrderedProduct
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public double TotalPrice
        {
            get
            {
                return Product.Price * Quantity;
            }
        }
    }
}
