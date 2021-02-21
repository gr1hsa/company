using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Text;

namespace company
{
    public class Apartment : Property
    {   
        public int NumbOfFloors { get; set; }
        public bool Elevator { get; set; }
        public bool Furnished { get; set; }
        public Apartment(int area, int costMeters, string location, int numbOfFloors, bool elevator, bool furnished, Company company)
        {
            Area = area;
            CostMeters = costMeters;
            Location = location;
            NumbOfFloors = numbOfFloors;
            Elevator = elevator;
            Furnished = furnished;
            company.Apartment.Add(this);
            
        }
        public Apartment(string file, Company company)
        {
            string s;
            try
            {
                using (var sr = new StreamReader(file))
                {
                    while ((s = sr.ReadLine()) != null)
                    {
                        string[] a = s.Split(", ");
                        new Apartment(int.Parse(a[0]), int.Parse(a[1]), a[2], int.Parse(a[3]), Convert.ToBoolean(a[4]), Convert.ToBoolean(a[5]), company);
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
            return Area * CostMeters + NumbOfFloors * 13;
        }
    }
}
