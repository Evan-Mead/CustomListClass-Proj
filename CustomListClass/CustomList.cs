using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T> : IEnumerable
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

        public T this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < items.Length; i++)
            {
                yield return items[i];
            }
        }

        public void CheckCapacity()
        {
            if (Count >= Capacity)
            {
                Capacity = Capacity * 2;
                T[] tempArray = new T[Count];
                for (int i = 0; i < Count; i++)
                {
                    tempArray[i] = items[i];
                }
                items = tempArray;
            }
        }

        public void Add(T item)
        {
            CheckCapacity();
            items[Count] = item;
            Count++;
        }
    }
}