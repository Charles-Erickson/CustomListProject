using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class CustomList<T>
    {
      
        public int capicty = 10;
        private T[] items;

        public T this[int i]
        {
            get { return items[i]; }
            set { items[i] = value; }
        }

        private int count;
        public int listlength;

        public CustomList()
        {
            items = new T[capicty];
        }

        //public int increaseListSize()
        //{

        //}

        public int Count
        {
            get { return count; }
        }

        public void Add(T item)
        {
            if (count == 0)
            {
                items[0] = item;
                count++;
            }
            else if (count == capicty)
            {
                capicty = capicty * 2;
                items[count] = item;
                count++;
            }
            else if (count > 0)
            {
                items[count] = item;
                count++;
            }
        }

        public void Remove(T item)
        {
            int i;

            for (i = 0; i < count; i++)
            {
                if (!Equals(items[i], item))
                {
                    Add(items[i]);
                }
                else if (Equals(items[i], item))
                {
    
                }
             
            }
            count--;

            //static List<T>Combine(List<T> list, List<T> list2)
            //{

            //}
        }

        //public string ToString()
        //{

        //}
        //public List<T> Zipper();
    }
}


//i=0;i<list.length;i+2
//i=1;i<list.length;i+2