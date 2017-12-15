using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryServiceLogic
{
    public class Order
    {
        public User User { get; set; }
        public DateTime OrderedTime { get; set; }
        public DateTime DeliveredTime { get; set; }
        public bool IsDelivered { get; set; }
        public List<OrderedProduct> OrderedProducts { get; set; }

        public string Code
        {
            get
            {
                return $"{RandomCode.rs.GetString(5)}";
            }
        }

        public string StatusInfo
        {
            get
            {
                if (!IsDelivered)
                    return "В ожидании";
                else
                    return "Доставлен";
            }
        }
    }
}
