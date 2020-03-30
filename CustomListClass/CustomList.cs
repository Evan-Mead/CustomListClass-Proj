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
            Capacity = 4;
            items = new T[Capacity];
        }

        // indexer is a property
    }           
}
