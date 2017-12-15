using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryServiceLogic
{
    public class Shop
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double Rating { get; set; }
        public int AvgCheck { get; set; }
        public string LogoPath { get; set; }

        public string RatingInfo
        {
            get
            {
                return $"{Rating}/5";
            }
        }
        public string AvgCheckInfo
        {
            get
            {
                return $"Средний чек: {AvgCheck} руб.";
            }
        }
    }
}
