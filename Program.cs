using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class Generic_class<T>
    {
       private List<T> myCollection;

        public Generic_conatiner()
        {
            myCollection = new List<T>();
        }

        public void Add(T item)
        {
            myCollection.Add(item);
        }

        public T GetItem(int index)
        {

            return myCollection[index];
        }
    }
}
