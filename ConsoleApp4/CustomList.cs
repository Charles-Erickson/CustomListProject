using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class CustomList<T>
    {
        private T[] items = new T[4];

        public T this[int i]
        {
            get { return items[i]; }
            set { items[i] = value; }
        }
        private int count;

        public int Count
        {
            get { return count; }

            //int i;
            //int count=0;
            //if (items[0] = null)
            //{
            //    return count;
            //}
            //for (i = 0;items.Length ; i++)
            //{
            //    count++;
            //}
            //return count;
        }

        public void Add(T item)
        {
            if (count == 0)
            {
                items[0] = item;
                count++;
            }
            else if (count > 0)
            {
                items[count + 1] = item;
                count++;
            }
        }

        public void Remove(T item)
        {

        }
        //public string ToString()
        //{

        //}
        //public List<T> Zipper();
    }
}


//i=0;i<list.length;i+2
//i=1;i<list.length;i+2