using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class CustomList<T>
    {

        public int capacity = 4;
        public T[] items;
        bool test;

        public T this[int i]
        {
            get { return items[i]; }
            set { items[i] = value; }
        }

        private int count;
        public int listlength;

        public CustomList()
        {
            items = new T[capacity];
        }

        public int Count
        {
            get { return count; }
        }

        public void Add(T item)
        {
            if (count == 0)
            {
                items[0] = item;
            }
            else if (count == capacity)
            {
                capacity = capacity * 2;
                T[] temp = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    temp[i] = items[i];
                }
                items = temp;
                items[count] = item;
            }
            else if (count > 0)
            {
                items[count] = item;
            }
            count++;
        }

        public bool Remove(T item)
        {
            T[] temp = new T[capacity];
            int v = 0;
            int d = 0;
            for (int i = 0; i < count; i++, v++)
            {
                if (d > 0)
                {
                    temp[v] = items[i];
                    test = true;
                }
                else if (!Equals(items[i], item))
                {
                    temp[v] = items[i];                    
                    test = false;
                }
                else if (Equals(items[i], item))
                {
                    test = true;
                    v--;
                    d++;
                }
            }
            for (int c = 0; c < count; c++)
            {
                if (c == count)
                {
                    items[c] = temp[c + 2];
                    break;
                }
                else
                {
                    items[c] = temp[c];
                }
            }
            count--;
            return test;
        }

        public static CustomList<T> operator +(CustomList<T> a, CustomList<T> b)
        {
            CustomList<T> returnList;
            CustomList<T> temp = new CustomList<T>();
            for(int i = 0; i < a.Count; i++)
            {
                temp.Add(a.items[i]);
            }
            for(int c = 0; c < b.Count; c++)
            {
                temp.Add(b.items[c]);
            }            
            returnList = temp;
            return returnList;
        }

        public void Zipper(CustomList<T> array)
        {

        }



        //public string toString()
        //{
        //    string testString;
        //    for (int i = 0; i < count; i++)
        //    {

        //        testString = testString + items[i]
        //    }

        //}


    }
}


//i=0;i<list.length;i+2
//i=1;i<list.length;i+2

//if(%2=0) add array[i]


//public void Combine(CustomList<T> list2)
//{
//  for(int i = 0; i < count; i++)
//    {
//        Add(list2[i]);
//    }
//}