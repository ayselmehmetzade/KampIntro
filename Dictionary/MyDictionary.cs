using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<T,T1>
    {
        T[] items;
        T1[] items1;
        public MyDictionary()
        {
            items = new T[0];
            items1 = new T1[0];
        }
        public void Add(T item, T1 item1)
        {
            T[] tempArray = items;
            T1[] tempArray1 = items1;

            items = new T[items.Length + 1];
            items1 = new T1[items1.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
                items1[i] = tempArray1[i];
            }
            items[items.Length - 1] = item;
            items1[items1.Length - 1] = item1;
          
        
        }
        public int Count
        {
            get { return items.Length; }
        }
    }
}
