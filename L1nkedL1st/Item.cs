using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace L1nkedL1st
{
    public class Item<T>  : ComparableObject where T : IComparable<T>
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
            if (value.CompareTo(item.value) > 0)
                return 1;
            else if (value.CompareTo(item.value) < 0)
                return -1;
            else return 0;
        }
         
    }
   

}