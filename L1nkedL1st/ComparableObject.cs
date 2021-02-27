using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace L1nkedL1st
{
    public abstract class ComparableObject : IComparable
    {
        public abstract int CompareTo(object obj);
        private int Compare(object obj)
        {
            
            if (obj != null && GetType() == obj.GetType())
                return CompareTo(obj);

            else
                return GetType().FullName.CompareTo(obj.GetType().FullName);
        }
        public override bool Equals(object obj)
        {
            return Compare(obj) == 0;
        }



        public static bool operator ==(ComparableObject c, object o)
        {
            if ((object)c == null || (object)o == null)
                return ((object)c == (object)o);
            else
                return c.Compare(o) == 0;
        }
        public static bool operator !=(ComparableObject c, object o)
        {
            if ((object)c == null || (object)o == null)
                return ((object)c != (object)o);
            else
                return c.Compare(o) != 0;
        }
        public static bool operator <(ComparableObject c, object o)
        {
            return c.Compare(o) < 0;
        }
        public static bool operator >(ComparableObject c, object o)
        {
            return c.Compare(o) > 0;
        }
        public static bool operator <=(ComparableObject c, object o)
        {
            return c.Compare(o) <= 0;
        }
        public static bool operator >=(ComparableObject c, object o)
        {
            return c.Compare(o) >= 0;
        }

    }
}
