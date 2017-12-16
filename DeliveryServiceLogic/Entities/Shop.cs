using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryServiceLogic
{
    public class Shop
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ShopType Type { get; set; }

        public double Rating { get; set; }

        public int AvgCheck { get; set; }

        public string LogoPath { get; set; }

        public string RatingInfo => $"{Rating}/5";
     
        public string AvgCheckInfo => $"Средний чек: {AvgCheck} руб.";
       
    }
}
