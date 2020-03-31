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
            //check count == capacity before adding to list
            //increase capacity in here

            if (Count == Capacity)
            {
                Capacity = Capacity * 2;
            }

            T tempArray;
            tempArray = new T[item];

            // items: david evan mike brett
            // tempArray: david evan mike brett

            // items: null null null null null null null null

            // items: david evan mike brett null null null null


                items = new T[Capacity];
                
                 
            
        }

        // indexer is a property
    }
}