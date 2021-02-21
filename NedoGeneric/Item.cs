using System;
using System.Collections.Generic;
using System.Text;

namespace NedoGeneric
{
    public class Item<T>
    {
        public T value;
        public Item<T> Next;
        public Item() { }
        public Item(T a)
        {
            value = a;
            Next = null;
        }
    }
}
