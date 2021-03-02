using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace L1nkedL1st
{
    class ListComparer<T> : IComparer where T : IComparable<T>
    {
        public int Compare(object x, object y)
        {
            MyLinkedList<T> first = x as MyLinkedList<T>;
            MyLinkedList<T> second = y as MyLinkedList<T>;
            if (first != null && second != null)
            {
                if (first.Count > second.Count)
                    return 1;
                else if (first.Count < second.Count)
                    return -1;
                else
                    return 0;
            }
            else
                throw new Exception("Разные типы!");

            }
        }
    }
