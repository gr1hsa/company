using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace company
{
    public class Company
    {
        public string CompanyName { get; private set; }
        public string Owner { get; private set; }
        public int TaxNumber { get; private set; }
        public List<Employees> Employ = new List<Employees>();
        public List<Property> Property = new List<Property>();
        public List<Apartment> Apartment = new List<Apartment>();
        public List<House> House = new List<House>();
        public List<ComfortableHouse> ComfortableHouse = new List<ComfortableHouse>();
        public List<Shop> Shop = new List<Shop>();

        public Company(string companyname, string owner, int taxnumber)
        {
            CompanyName = companyname;
            Owner = owner;
            TaxNumber = taxnumber;
        }
        public Company(string file)
        {
            try
            {
                using (var sr = new StreamReader(file))
                {
                    string[] s = sr.ReadLine().Split(", ");
                    CompanyName = s[0];
                    Owner = s[1];
                    TaxNumber = int.Parse(s[2]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public int PriceAll()
        {
            int sum = 0;
            for (int i = 0; i < Apartment.Count; i++)
                sum += Apartment[i].Price();
            for (int i = 0; i < Shop.Count; i++)
                sum += Shop[i].Price();
            for (int i = 0; i < House.Count; i++)
                sum += House[i].Price();
            for (int i = 0; i < ComfortableHouse.Count; i++)
                sum += ComfortableHouse[i].Price();
            return sum;
        }       
        public void GetEmployees()
        {
            for(int i = 0; i < Employ.Count; i++)
                Console.WriteLine($"Имя сотрудника: {Employ[i].FirstName} Фамилия сотрудника: {Employ[i].SecondName} Должность: {Employ[i].Position} Опыт работы: {Employ[i].Experience} лет!");
        }
        public void GetProperty()
        {
            for(int i = 0; i < Apartment.Count; i++)
                Console.WriteLine($"Тип: Квартира Цена: {Apartment[i].Price()}000 рублей Площадь: {Apartment[i].Area}м Количество этажей: {Apartment[i].NumbOfFloors}");
            for (int i = 0; i < Shop.Count; i++)
                Console.WriteLine($"Тип: Магазин Цена: {Shop[i].Price()}000 рублей Площадь: {Shop[i].Area}м Количество этажей: {Shop[i].NumbOfFloors} Удачное местоположение: {Shop[i].Attractiveness}%");
            for (int i = 0; i < House.Count; i++)
                Console.WriteLine($"Тип: Дом Цена: {House[i].Price()}000 рублей Площадь: {House[i].Area}м Территория: {House[i].AmountOfTerritory}м");
            for (int i = 0; i < ComfortableHouse.Count; i++)
                Console.WriteLine($"Тип: Обустроенный дом Цена: {ComfortableHouse[i].Price()}000 рублей Площадь: {ComfortableHouse[i].Area}м Количество этажей: {ComfortableHouse[i].Floors} Территория: {ComfortableHouse[i].AmountOfTerritory}м");
        }
        public void SaveAll()
        {
            try
            {
                for (int i = 0; i < Apartment.Count; i++)
                {   
                    
                    using (var sw = new StreamWriter("Apartment.txt", Convert.ToBoolean(i)))
                    {
                        sw.WriteLine($"{Apartment[i].Area}, {Apartment[i].CostMeters}, {Apartment[i].Location}, {Apartment[i].NumbOfFloors}, {Apartment[i].Elevator}, {Apartment[i].Furnished}");
                    }
                }
                for (int i = 0; i < Shop.Count; i++)
                {
                    using (var sw = new StreamWriter("Shop.txt", Convert.ToBoolean(i)))
                    {
                        sw.WriteLine($"{i}{Shop[i].Area}, {Shop[i].CostMeters}, {Shop[i].Location}, {Shop[i].NumbOfFloors}, {Shop[i].Attractiveness}");
                    }
                }
                for (int i = 0; i < House.Count; i++)
                {
                    using (var sw = new StreamWriter("House.txt", Convert.ToBoolean(i)))
                    {
                        sw.WriteLine($"{House[i].Area}, {House[i].CostMeters}, {House[i].Location}, {House[i].AmountOfTerritory}");
                    }
                }
                for (int i = 0; i < ComfortableHouse.Count; i++)
                {
                    using (var sw = new StreamWriter("ComfortableHouse.txt", Convert.ToBoolean(i)))
                    {
                        sw.WriteLine($"{ComfortableHouse[i].Area}, {ComfortableHouse[i].CostMeters}, {ComfortableHouse[i].Location}, {ComfortableHouse[i].AmountOfTerritory}, {ComfortableHouse[i].Floors}, {ComfortableHouse[i].Furnished}");
                    }
                }
                for (int i = 0; i < Employ.Count; i++)
                {
                    using (var sw = new StreamWriter("Employees.txt", Convert.ToBoolean(i)))
                    {
                        sw.WriteLine($"{Employ[i].FirstName}, {Employ[i].SecondName}, {Employ[i].Position}, {Employ[i].Experience}");
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
       
    }
}
