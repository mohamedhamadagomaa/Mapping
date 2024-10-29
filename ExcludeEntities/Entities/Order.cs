using System;
using System.Collections.Generic;

namespace MappingView.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerEmail { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
