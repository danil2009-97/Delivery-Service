using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryServiceLogic
{
    public class Order
    {
        public int Id { get; set; }

        public User User { get; set; }

        public DateTime OrderedTime { get; set; }

        public DateTime DeliveredTime { get; set; }

        public bool IsDelivered { get; set; }

        public List<OrderedProduct> OrderedProducts { get; set; }

        public string Code => $"{RandomCode.rs.GetString(5)}";

        public string StatusInfo => !IsDelivered ? "В ожидании" : "Доставлен";
       
    }
}
