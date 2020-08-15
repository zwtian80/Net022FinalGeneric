/*
 Write a generic class that meets the following requirements:
1)    That constrains a developer to only instantiate the class based on value types
2)    Contains a private generic collection
3)    Has a method to add items to the private collection
4)    Has a method that will return an item from the list (e.g. item 3 or item 4 in the list)
5)    Has a method that returns a sorted collection with the items in descending order
 */

using System;

namespace Net022FinalGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericCollection<string> myList = new GenericCollection<String>();
            myList.Add("123");
            myList.Add("456");
            myList.Add("789");
            myList.Add("000");

        }

        public class GenericCollection<T>
        {
            private T[] _items = new T[100];

            private int _numitems = 0;

            public void Add(T item)
            {
                if (_numitems + 1 < 100)
                {
                    _items[_numitems] = item;
                    _numitems++;
                }
            }

            public string ReturnT()
            {
                foreach (var _numitems in _items)
                {
                    Console.WriteLine(_numitems);
                }
            }

            public void Sort()
            {
            }
        }
    }
}
