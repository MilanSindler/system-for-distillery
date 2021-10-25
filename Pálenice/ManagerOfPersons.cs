using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Pálenice
{
    static class ManagerOfPersons
    {
        static public List<Person> Persons { get; private set; } = new List<Person>();
        private static string FileName { get; } = "Persons.csv";
        static ManagerOfPersons()
        {
            if (!File.Exists(FileName))
                return;
            using StreamReader reader = new StreamReader(FileName);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                try
                {
                    Persons.Add(new Person(line));
                }
                catch { }
            }
        }
        public static void Delete(Person person)
            => Persons.Remove(person);
        static public Person GetPerson(string birthNum)
        {
            foreach (var person in Persons)
            {
                if (person.BirthNum == birthNum)
                {
                    return person;
                }
            }
            return new Person(birthNum, "", "", null, "", "", "");
        }
        public static void Save()
        {
            if (!File.Exists(FileName))
                File.Create(FileName);
            using StreamWriter writer = new StreamWriter(FileName);
            foreach (Person person in Persons)
            {
                writer.WriteLine(person.ToCsv());
            }
        }
        public static bool Exist(string birthNum)
            => Persons.Exists(x => x.BirthNum == birthNum);
        static public void AddPerson(Person person)
        {
            if (Exist(person.BirthNum))
            {
                GetPerson(person.BirthNum).Edit(person.Name, person.Surname, person.PostalCode, person.City, person.Street, person.DescriptiveNumber);
            }
            else
            {
                Persons.Add(person);
            }
        }
    }
}
