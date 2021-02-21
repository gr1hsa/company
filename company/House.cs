using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace company
{
    public class House : Property
    {
        public int AmountOfTerritory { get; set; }
        public House(int area, int costMeters, string location, int amountOfTerritory, Company company)
        {
            Area = area;
            CostMeters = costMeters;
            Location = location;
            AmountOfTerritory = amountOfTerritory;
            company.House.Add(this);
        }
        public House(string file, Company company)
        {
            string s;
            try
            {
                using (var sr = new StreamReader(file))
                {
                    while ((s = sr.ReadLine()) != null)
                    {
                        string[] a = s.Split(", ");
                        new House(int.Parse(a[0]), int.Parse(a[1]), a[2], int.Parse(a[3]), company);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public override int Price()
        {
            return Area * CostMeters + AmountOfTerritory * 3;
        }
    }
}
