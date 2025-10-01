using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeProject
{
    public class Product : IItem
    {
        public string Name { get; }
        public decimal Price { get; }


        public Product(string name, decimal price)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Price = price;
        }

        public decimal GetPrice() => Price;

        public void Display(int depth)
        {
            Console.WriteLine(new string(' ', depth) + "+ " + Name + ": €" + Price);
        }
    }
}
