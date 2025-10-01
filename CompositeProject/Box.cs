using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeProject
{
    public class Box : IItem
    {
        public string Name { get; }
        private readonly List<IItem> _items = new List<IItem>();
        public IReadOnlyList<IItem> Items => _items.AsReadOnly(); //Om Items in Box te kunnen bekijken


        public Box(string name) => Name = name ?? throw new ArgumentNullException(nameof(name));

        public void AddItem(IItem item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            _items.Add(item);
        }

        public decimal GetPrice()
        {
            return _items.Sum(item => item.GetPrice());
        }

        public void Display(int depth)
        {
            Console.WriteLine(new string(' ', depth) + "- Box: " + Name);
            foreach (var item in _items)
            {
                item.Display(depth + 2);
            }
        }
    }
}
