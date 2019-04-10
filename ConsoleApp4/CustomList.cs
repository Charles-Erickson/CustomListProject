using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class CustomList<T>
    {
        private T[] items = new T[10];

        public T this[int i]
        {
            get { return items[i]; }
            set { items[i] = value; }
        }

        private int count;
        public int listlength;

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
            else if (count > 0)
            {
                items[count + 1] = item;
                count++;
            }
        }

        public void Remove(T item)
        {
            int i;
            count = 0;

            for (i = 0; i < count; i++)
            {
                if (!Equals(items[i], item))
                {
                    Add(item);
                }
                else if (Equals(items[i], item))
                {

                }
            }
        }

        //public string ToString()
        //{

        //}
        //public List<T> Zipper();
    }
}


//i=0;i<list.length;i+2
//i=1;i<list.length;i+2