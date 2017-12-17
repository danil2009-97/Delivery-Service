﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryServiceLogic
{
    public class Order
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public DateTime OrderedTime { get; set; }

        public DateTime DeliveredTime { get; set; }

        public virtual List<OrderedProduct> OrderedProducts { get; set; }

        public string Code => $"{Methods.methods.GetString(5)}";

    }
}
