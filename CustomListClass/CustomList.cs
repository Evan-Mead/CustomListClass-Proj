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

        public override string ToString()
        {
            string userInput = "";
            if (Count > 0)
            {
                for (int i = 0; i < Count; i++)
                {
                    userInput = items[i].ToString() + "";
                }
            }
            return userInput;
        }

        public T this[int index]
        {
            get
            {
                if (Count ==  0 || index >= Count)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return items[index];
                }
            }
            set
            {
                if (Count == 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    items[index] = value;
                }
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
                T[] tempArray = new T[Capacity];
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

        public void Remove(T RemoveValue)
        {
            int removeItem = -1;
            for (int i = 0; i < Count; i++)
            {
                if (items[i].Equals(RemoveValue))
                {
                    removeItem = i;
                    break;
                }
            }

            if (removeItem >= 0)
            {
                for (int j = removeItem; j < Count; j++)
                {
                    if (Count - 1 != j)
                    {
                        items[j] = items[j + 1];
                    }
                }
                Count--;
            }

        }

        public static CustomList<T> operator+ (CustomList<T> listOne, CustomList<T> ListTwo)
        {
            CustomList<T> customList = new CustomList<T>();
            customList = customList.Add.listOne + ListTwo;
            return customList;
        }
    }
}