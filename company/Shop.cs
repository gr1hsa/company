using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace company
{
    public class Shop:Property
    {   
        public int NumbOfFloors { get; set; }
        public int Attractiveness { get; set; }
        public Shop(int area, int costMeters, string location, int numbOfFloors, int attractiveness, Company company)
        {
            Area = area;
            CostMeters = costMeters;
            Location = location;
            NumbOfFloors = numbOfFloors;
            Attractiveness = attractiveness;
            company.Shop.Add(this);

        }
        public Shop(string file, Company company)
        {
            string s;
            try
            {
                using (var sr = new StreamReader(file))
                {
                    while ((s = sr.ReadLine()) != null)
                    {
                        string[] a = s.Split(", ");
                        new Shop(int.Parse(a[0]), int.Parse(a[1]), a[2], int.Parse(a[3]), int.Parse(a[4]), company);
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
            return Area * CostMeters + NumbOfFloors * 13 + Attractiveness * 17;
        }
    }
}
