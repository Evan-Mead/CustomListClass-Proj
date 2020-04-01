using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T>
    {
        private T[] items;
        public int Capacity { get; set; }
        public int Count { get; set; }

        public CustomList()
        {
            Count = 0;
            Capacity = 4;
            items = new T[Capacity];
        }

        public void Add(T item)
        {
            while (Count >= 0 || Count < Capacity)
            {
                Count++;
            }

            if (Count >= Capacity)
            {
                Capacity = Capacity * 2;
                TempArray<T>(ref item);
            }
            else
            {
                Count++;
            }

            items = new T[Capacity];

            items[Count] = item;
            Count++;
        }

        public void TempArray<T>(ref T item)
        {
            T tempArray;
            tempArray =  item;
        }

        // indexer is a property
    }
}