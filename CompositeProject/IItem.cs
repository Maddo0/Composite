using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeProject
{
    public interface IItem
    {
        string Name { get; }

        decimal GetPrice();

        void Display(int depth);
    }
}
















