using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace company
{
    public class Employees
    {
        public string FirstName { get; private set; }
        public string SecondName { get; private set; }
        public string Position { get; set; }
        public int Experience { get; private set; }
        public Employees(string firstName, string secondName, string position, int experience)
        {
            FirstName = firstName;
            SecondName = secondName;
            Position = position;
            Experience = experience;
        }
        public Employees(string firstName, string secondName, string position, int experience, Company company)
        {
            FirstName = firstName;
            SecondName = secondName;
            Position = position;
            Experience = experience;
            company.Employ.Add(this);
        }
        public Employees(string file, Company company)
        {
            string s;
            using (var sr = new StreamReader(file))
            {
                while ((s = sr.ReadLine()) != null)
                {
                    string[] a = s.Split(", ");
                    company.Employ.Add(new Employees(a[0], a[1], a[2], int.Parse(a[3])));
                }
            }
        }
    }
}
