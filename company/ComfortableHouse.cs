using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.IO;
using System.Text;

namespace company
{
    public class ComfortableHouse : Property
    {
        public int Floors {     get; set; }
        public bool Furnished { get; set; }
        public int AmountOfTerritory { get; set; }
        public ComfortableHouse(int area, int costMeters, string location, int amountOfTerritory, int floors, bool furnished, Company company)
        {
            Area = area;
            CostMeters = costMeters;
            Location = location;
            AmountOfTerritory = amountOfTerritory;
            Floors = floors;
            Furnished = furnished;
            company.ComfortableHouse.Add(this);
        }
        public ComfortableHouse(string file, Company company)
        {
            string s;
            try
            {
                using (var sr = new StreamReader(file))
                {
                    while ((s = sr.ReadLine()) != null)
                    {
                        string[] a = s.Split(", ");
                        new ComfortableHouse(int.Parse(a[0]), int.Parse(a[1]), a[2], int.Parse(a[3]), int.Parse(a[4]), Convert.ToBoolean(a[5]), company);
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
            return Area * CostMeters + Floors * 100 + AmountOfTerritory * 13;
        }
    }
}
