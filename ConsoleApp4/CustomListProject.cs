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
            CustomList<string> thing = new CustomList<string>();
            CustomList<string> things = new CustomList<string>();
            CustomList<string> result;
            thing.Add("make");
            thing.Add("bubba");
            things.Add("bubba");
            things.Add("dave");
            result = thing - things;
            
            
            foreach(string name in thing)
            {
                Console.WriteLine(name);
                // Console.ReadKey();
            }
            
          
         
        }
    }
}
