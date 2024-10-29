using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using TableValuedFunction.Data;
using TableValuedFunction.Entities;

namespace TableValuedFunction
{
    internal class Proram
    {
        static void Main(string[] args)
        {
            var orderBillDetails = new AppDbContext().Set<OrderBill>().FromSqlInterpolated($"SELECT * FROM GetOrderBill({1})").ToList();

            foreach (var orderBill in orderBillDetails)
                Console.WriteLine(orderBill);
        }
    }
}
