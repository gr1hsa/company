using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace MylinkedlistStupidVersion
{
    public class Item<T>
    {
        public T value;
        public Item<T> Next;
        public Item<T> Previous;
        public Item() { }
        public Item(T a)
        {
            value = a;
        }
    }

}