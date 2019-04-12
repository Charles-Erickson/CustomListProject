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
            CustomList<int> result;
            thing.Add(1);
            thing.Add(2);
            things.Add(2);
            things.Add(4);
            result = thing - things;
        }
    }
}
