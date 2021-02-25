using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace L1nkedL1st
{
    public class Item<T> : ComparableObject<Item<T>>
    {
        public T value;
        public Item<T> Next;
        public Item<T> Previous;
        public Item() { }
        public Item(T a)
        {
            value = a;
        }

        public override int CompareTo(object obj)
        {
            Item<T> item = obj as Item<T>;
            if (value.Equals(item.value))
                return 0;
            else
                return 1;
        }
    }

}