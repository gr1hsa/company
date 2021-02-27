using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace L1nkedL1st
{
    class ItemComparer<T> : IComparer<Item<T>>  where T : IComparable
    {
        public int Compare(Item<T> x, Item<T> y)
        {
            return x.CompareTo(y);
            
        }
    }
}
