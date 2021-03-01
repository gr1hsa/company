using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;


namespace L1nkedL1st
{
    public class ItemComparer2<T> : IComparer where T : IComparable<T>
    {


        public int Compare(object x, object y)
        {
            Item<T> item1 = x as Item<T>;
            Item<T> item2 = y as Item<T>;
            if (item1 != null && item2 != null)
                return String.Compare(item1.GetType().FullName, item2.GetType().FullName);
            else
                throw new Exception("Разные типы!");

        }


    }
}
