using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryServiceLogic
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ProductType Type { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }
                
        public string LogoPath { get; set; }

        public string PriceInfo => $"{Price} руб.";
     
    }
}
