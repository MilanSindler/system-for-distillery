using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Pálenice
{
    public class Person
    {
        public string BirthNum { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int? PostalCode { get; private set; }
        public string City { get; private set; }
        public string Street { get; private set; }
        public string DescriptiveNumber { get; private set; }

        public Person(string birthNum, string name, string surname, int? postalCode, string city, string street, string descriptiveNumber)
        {
            BirthNum = birthNum;
            Edit(name, surname, postalCode, city, street, descriptiveNumber);
        }
        public Person(string str)
        {
            string[] parts = str.Split(";");
            int value;
            if (parts.Length != 7 || !int.TryParse(parts[3], out value))
                throw new FormatException("wrong format");
            BirthNum = parts[0];
            Edit(parts[1], parts[2], value, parts[4], parts[5], parts[6]);
        }
        public void Edit(string name, string surname, int? postalCode, string city, string street, string descriptiveNumber)
        {
            Name = name;
            Surname = surname;
            PostalCode = postalCode;
            City = city;
            Street = street;
            DescriptiveNumber = descriptiveNumber;
        }

            
        public double LaaInSeason(int startYear)
        {
            double count = 0;
            foreach (Month month in Enum.GetValues(typeof(Month)))
            {
                ManagerOfRecords
                    .GetRecords(startYear + (month <= Month.Červen ? 1 : 0), month)
                    .FindAll(x => x.Person.BirthNum == BirthNum)
                    .ForEach(x => count += x.Etanol);
            }
            return count;
        }

        public static bool IsValidBirthNum(string birthNum)
        {
            Regex format = new Regex(@"\d{6}\/\d{3,4}");
            string allovedThirdChar = "01235678";
            return (format.IsMatch(birthNum) &&
                allovedThirdChar.Contains(birthNum[2]) &&
                (birthNum.Length == 10 || (int.Parse(birthNum.Substring(0, 6)) * 1000 + int.Parse(birthNum[7..10])) % 11 == int.Parse(birthNum[10..])));
        }
        public string ToCsv()
            => string.Format("{0};{1};{2};{3};{4};{5};{6}", BirthNum, Name, Surname, PostalCode, City, Street, DescriptiveNumber);
        public override bool Equals(object obj)
            => obj is Person person &&BirthNum == person.BirthNum;

        public override int GetHashCode()
            => base.GetHashCode();
    }
}
