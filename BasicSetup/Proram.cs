using BasicSetup.Data;
using System;

namespace BasicSetup
{
    internal class Proram
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                foreach (var item in context.Products)
                    Console.WriteLine(item.Name);
            }
        }
    }
}
