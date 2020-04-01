using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class Indexer
    {
        private int[] items = new int[4];

        public int Length
        {
            get { return items.Length; }
        }

        public int this[int index]
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
    }
}
