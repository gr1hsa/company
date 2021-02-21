using System;
using System.Collections.Generic;
using System.Text;

namespace company
{
    public class Property
    {
        public int Area { get; set; }
        public int CostMeters { get; set; }
        public string Location { get; set; }
        public virtual int Price()
        {
            return Area * CostMeters;
        }
    }
}
