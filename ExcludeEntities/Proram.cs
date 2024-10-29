using MappingView.Data;
using System;

namespace MappingView
{
    internal class Proram
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                foreach (var item in context.OrderWithDetailsViews)
                    Console.WriteLine(item);
            }
        }
    }
}
