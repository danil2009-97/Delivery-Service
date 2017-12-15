using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryServiceLogic
{
    public class Product
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public double Weight { get; set; }
        public string LogoPath { get; set; }

        public string PriceInfo
        {
            get
            {
                return $"{Price} руб.";
            }
        }
    }
}
