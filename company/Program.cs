using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Security.Cryptography;

namespace company
{
    class Program
    {
        static void Main(string[] args)
        {
            Company maincommpany = new Company("CompanyInfo.txt");
            new Employees("Employees.txt", maincommpany);
            new Apartment("Apartment.txt", maincommpany);
            new ComfortableHouse("ComfortableHouse.txt", maincommpany);
            new House("House.txt", maincommpany);
            new Shop("Shop.txt", maincommpany);
            maincommpany.GetProperty();
            maincommpany.GetEmployees();
            new Employees("Георгий", "Валерьев", "junior", 1, maincommpany);
            maincommpany.SaveAll();
        }
    }
}
