using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter25And26Generics
{
    class PracticeList<T> where T : IComparable
    {
        private T[] items;

        public PracticeList()
        {
            items = new T[0];
        }

        public T GetItem(int index)
        {
            return items[index];
        }

        public void Add(T newItem)
        {
            // Make a new bigger array with room to store the new item
            T[] newItems = new T[items.Length + 1];

            // Copy all of the old items over to the new array
            for(int index = 0; index < items.Length; index++)
            {
                newItems[index] = items[index];
            }

            // Put the new item at the end
            newItems[newItems.Length - 1] = newItem;

            // Update our instance variable to hold this new array instead of the old array
            items = newItems;
        }
    }
}
