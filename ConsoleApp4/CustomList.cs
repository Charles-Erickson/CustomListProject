﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class CustomList<T>
    {

        public int capacity = 4;
        private T[] items;
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
            for (int i = 0; i < count; i++, v++)
            {
                if (!Equals(items[i], item))
                {
                    temp[v] = items[i];
                    
                    test = false;
                }
                else if (Equals(items[i], item))
                {
                    test = true;
                    v--;
                }
            }
            count--;
            for(int c = 0; c < count; c++)
            {
                items[c] = temp[c];
            }
            return test;
        }
    }
}


//i=0;i<list.length;i+2
//i=1;i<list.length;i+2

    //if(%2=0) add array[i]