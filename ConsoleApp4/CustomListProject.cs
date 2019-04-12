using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> thing = new CustomList<int>();
            CustomList<int> things = new CustomList<int>();
            thing.Add(6);
            thing.Add(2);
            thing.Add(5);
            things.Add(4);
            things.Add(2);
            thing.Combine(things);
        }
    }
}
