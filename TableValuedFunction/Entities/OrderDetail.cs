﻿namespace TableValuedFunction.Entities
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrederId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
